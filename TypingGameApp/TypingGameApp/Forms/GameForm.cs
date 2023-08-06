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
using TypingGameApp.Services;

namespace TypingGameApp.Forms
{
    public partial class GameForm : BaseForm
    {
        private ArticleService articleService;
        public Article? Article { get; set; }

        public GameForm()
        {
            InitializeComponent();

            articleService = new ArticleService();
            loadArticleAsync();
        }

        async void loadArticleAsync()
        {
            Article = await articleService.GetArticle();

            if (Article != null)
            {
                label1.Text = Article.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            var form = (StartMenuForm)Application.OpenForms["StartMenuForm"];
            form.Show();
        }
    }
}
