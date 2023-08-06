using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingGameApp.Models;

namespace TypingGameApp.Forms
{
    public partial class CompleteTypeForm : BaseForm
    {
        public Article? Article { get; set; }
        public string wpm { get; set; }
        public int seconds { get; set; }

        public CompleteTypeForm(Article? Article, string wpm, int seconds)
        {
            InitializeComponent();

            this.Article = Article;
            this.wpm = wpm;
            this.seconds = seconds;
        }

        private void CompleteTypeForm_Load(object sender, EventArgs e)
        {
            this.label2.Text = this.Article?.Text;
            this.label3.Text = this.Article?.Description;

            this.label6.Text = $"{this.wpm}wpm";
            this.label7.Text = $"{this.seconds}s";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            new StartMenuForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            new GameForm().ShowDialog();
        }
    }
}
