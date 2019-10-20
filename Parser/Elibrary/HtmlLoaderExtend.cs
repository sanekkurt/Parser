using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Parser.Elibrary
{
    class HtmlLoaderExtend
    {

        readonly HttpClient client;
        readonly string url;

        public HtmlLoaderExtend(IParserSettingsExtend settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseUrl}{settings.Parametr_Search}";
            url = url.Replace("{AuthorID}",settings.ID);
        }

        public async Task<string> GetSourceByPage(string pageNum)
        {
            var currentUrl = url.Replace("{PageNumber}", pageNum.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
