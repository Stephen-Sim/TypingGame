using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingGameApp.Models;
using TypingGameApp.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TypingGameApp.Forms
{
    public partial class GameForm : BaseForm
    {
        private ArticleService articleService;
        public Article? Article { get; set; }

        public List<string> Words { get; set; }

        public int counter { get; set; }

        public GameForm()
        {
            InitializeComponent();

            richTextBox1.ReadOnly = true;
            richTextBox1.BorderStyle = 0;
            richTextBox1.BackColor = this.BackColor;
            richTextBox1.TabStop = false;

            articleService = new ArticleService();
            Words = new List<string>();
        }

        async void loadArticleAsync()
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = this.richTextBox1.BackColor;

            startLenght = 0;
            counter = 0;
            seconds = 0;
            wordCount = 0;
            label3.Text = $"0s";
            label5.Text = $"0wpm";
            textBox1.Text = string.Empty;
            richTextBox1.Text = string.Empty;

            this.panel1.Enabled = false;
            this.label1.Visible = true;

            Article = await articleService.GetArticle();

            if (Article != null)
            {
                richTextBox1.Text = Article.Text;
                Words = Article.Text.Split(' ').ToList();
            }

            this.label1.Visible = false;
            this.panel1.Enabled = true;

            richTextBox1.SelectionStart = startLenght;
            richTextBox1.SelectionLength = Words[counter].Length;
            richTextBox1.SelectionBackColor = Color.LightBlue;

            await StartGame(gameCancellationTokenSource.Token, ++currentGameCount);
        }

        int startLenght = 0;
        int seconds = 0;
        int wordCount = 0;
        int currentGameCount = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            seconds = 0;
            gameCancellationTokenSource.Cancel();

            var form = (StartMenuForm)Application.OpenForms["StartMenuForm"];
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var text = textBox1.Text;

            if (!string.IsNullOrEmpty(text))
            {
                if (text.Last() == ' ')
                {
                    if (text.Trim() == Words[counter])
                    {
                        if (wordCount + 1 == Words.Count())
                        {
                            var temp = seconds;
                            seconds = 0;

                            this.Hide();

                            new CompleteTypeForm(this.Article, ((wordCount / (double)temp) * 60).ToString("0"), temp).ShowDialog();
                            return;
                        }

                        richTextBox1.SelectionStart = 0;
                        richTextBox1.SelectAll();
                        richTextBox1.SelectionBackColor = this.richTextBox1.BackColor;

                        startLenght += Words[counter].Length + 1;
                        counter++;
                        textBox1.Text = string.Empty;

                        wordCount++;

                        richTextBox1.SelectionStart = startLenght;
                        richTextBox1.SelectionLength = Words[counter].Length;
                        richTextBox1.SelectionBackColor = Color.LightBlue;

                        label5.Text = $"{((wordCount / (double)seconds) * 60).ToString("0")}wpm";

                        return;
                    }
                }

                if (text.Length > Words[counter].Length)
                {
                    textBox1.BackColor = Color.Red;
                }
                else if (text.Substring(0, text.Length) != Words[counter].Substring(0, text.Length))
                {
                    textBox1.BackColor = Color.Red;
                }
                else
                {
                    textBox1.BackColor = Color.White;
                }
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameCancellationTokenSource.Cancel(); // Cancel the previous game
            gameCancellationTokenSource = new CancellationTokenSource(); // Create a new token source for the new game

            loadArticleAsync();
        }

        async Task StartGame(CancellationToken cancellationToken, int gameCount)
        {
            if (!cancellationToken.IsCancellationRequested && gameCount == currentGameCount)
            {
                await Task.Delay(1000);
                label3.Text = $"{++seconds}s";
                await StartGame(cancellationToken, gameCount);
            }
            else
            {
                seconds = 0;
                label3.Text = $"{seconds}s";
            }
        }

        private CancellationTokenSource gameCancellationTokenSource = new CancellationTokenSource();

        private void GameForm_Load(object sender, EventArgs e)
        {
            loadArticleAsync();
        }
    }
}
