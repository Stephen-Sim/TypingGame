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

            articleService = new ArticleService();
            Words = new List<string>();
        }

        async void loadArticleAsync()
        {
            counter = 0;
            seconds = 0;
            wordCount = 0;
            label3.Text = $"0s";
            label5.Text = $"0wpm";

            this.panel1.Enabled = false;

            Article = await articleService.GetArticle();

            if (Article != null)
            {
                label1.Text = Article.Text;
                Words = Article.Text.Split(' ').ToList();
                label7.Text = Words[counter];
            }

            this.panel1.Enabled = true;

            await Task.Delay(1000);
            ++seconds;

            await StartGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            seconds = 0;

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

                        counter++;

                        textBox1.Text = string.Empty;

                        label7.Text = Words[counter];

                        wordCount++;

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
            loadArticleAsync();
        }

        int seconds = 0;
        int wordCount = 0;

        async Task StartGame()
        {
            if (seconds != 0)
            {
                await Task.Delay(1000);
                label3.Text = $"{++seconds}s";
                await StartGame();
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            loadArticleAsync();
        }
    }
}
