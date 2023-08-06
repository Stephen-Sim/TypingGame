using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingGameApp.Models;

namespace TypingGameApp.Services
{
    public class ArticleService
    {
        public async Task<Article?> GetArticle()
        {
            string url = "https://localhost:7012/api/TypeGame/GetArticle";

            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<Article?>(res);
            }
        }
    }
}
