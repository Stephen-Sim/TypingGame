using HtmlAgilityPack;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        public async Task<IActionResult> GetText()
        {
            string text = string.Empty; 

            using (HttpClient client = new HttpClient())
            {
                int page = new Random().Next(1, 89);

                string url = $"https://www.dissentmagazine.org/online-articles/page/{page}/";

                var res = await client.GetAsync(url);

                if (res.IsSuccessStatusCode)
                {
                    var htmlResult = await res.Content.ReadAsStringAsync();

                    HtmlDocument htmlDoc = new HtmlDocument();
                    htmlDoc.LoadHtml(htmlResult);

                    // Find all article elements on the page
                    var articleNodes = htmlDoc.DocumentNode.SelectNodes("//article");

                    List<string> descriptions = new List<string>();

                    if (articleNodes != null)
                    {
                        foreach (var articleNode in articleNodes)
                        {
                            // Find the first paragraph element within the article
                            var pNode = articleNode.SelectSingleNode(".//p");

                            if (pNode != null)
                            {
                                string description = WebUtility.HtmlDecode(pNode.InnerText.Trim());
                                descriptions.Add(description);
                            }
                        }
                    }

                    text = descriptions[new Random().Next(0, descriptions.Count() - 1)];
                }
            }

            return Ok(text);
        }
    }
}
