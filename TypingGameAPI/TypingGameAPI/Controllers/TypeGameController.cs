using HtmlAgilityPack;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TypingGameAPI.Models;

namespace TypingGameAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TypeGameController : ControllerBase
    {
        public TypeGameController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> GetArticle()
        {
            var article = new Article();

            using (HttpClient client = new HttpClient())
            {
                var rand = new Random();
                int page = rand.Next(1, 90);

                string url = $"https://www.dissentmagazine.org/online-articles/page/{page}/";

                var res = await client.GetAsync(url);

                if (res.IsSuccessStatusCode)
                {
                    var htmlResult = await res.Content.ReadAsStringAsync();

                    HtmlDocument htmlDoc = new HtmlDocument();
                    htmlDoc.LoadHtml(htmlResult);

                    // Get all links to article pages
                    var linkNodes = htmlDoc.DocumentNode.SelectNodes("//a[contains(@href,'/online_articles/')]");
                    if (linkNodes != null && linkNodes.Any())
                    {
                        // Choose a random link from the list
                        var randomLinkNode = linkNodes[rand.Next(0, linkNodes.Count)];

                        string articleLink = randomLinkNode.GetAttributeValue("href", "");
                        var articleRes = await client.GetAsync(articleLink);

                        if (articleRes.IsSuccessStatusCode)
                        {
                            var articleHtml = await articleRes.Content.ReadAsStringAsync();
                            HtmlDocument articleHtmlDoc = new HtmlDocument();
                            articleHtmlDoc.LoadHtml(articleHtml);

                            var titleNode = articleHtmlDoc.DocumentNode.SelectSingleNode("//header//h1[contains(@class, 'hide-on-small-only')]");
                            if (titleNode != null)
                            {
                                article.Title = WebUtility.HtmlDecode(titleNode.InnerText.Trim());
                            }

                            var descriptionNode = articleHtmlDoc.DocumentNode.SelectSingleNode("//div[contains(@class, 'excerpt-tag')]//p");
                            if (descriptionNode != null)
                            {
                                article.Description = WebUtility.HtmlDecode(descriptionNode.InnerText.Trim());
                            }

                            var paragraphNodes = articleHtmlDoc.DocumentNode.SelectNodes("//article//p");
                            if (paragraphNodes != null)
                            {
                                List<string> paragraphs = new List<string>();
                                foreach (var pNode in paragraphNodes)
                                {
                                    string paragraphText = WebUtility.HtmlDecode(pNode.InnerText.Trim());
                                    paragraphs.Add(paragraphText);
                                }

                                // Combine paragraphs and split into strings with up to 2 sentences
                                string combinedText = string.Join(" ", paragraphs);
                                var sentences = combinedText.Split('.');

                                List<string> sentenceGroups = new List<string>();

                                for (int i = 0; i < sentences.Length; i += 2)
                                {
                                    var group = sentences.Skip(i).Take(2);
                                    sentenceGroups.Add(string.Join(".", group).Trim());
                                }

                                int randomGroupIndex = rand.Next(0, sentenceGroups.Count);
                                article.Text = sentenceGroups[randomGroupIndex].Trim() + ".";
                            }
                        }
                    }
                }
            }

            return Ok(article);
        }
    }
}
