using System.Collections.Generic;
using System.Linq;
using AngleSharp.Html.Dom;
using Parser.Common;

namespace Parser.Scopus
{
    class ScopusParser : IParser<List<string>>
    {
        public List<string> Parse(IHtmlDocument document)
        {
            var list = new List<string>();


            var items = document.QuerySelectorAll("a.ddmDocTitle, td[data-type='source'], span.ddmAuthorList, span.ddmPubYr ");



            foreach (var item in items)
            {

                list.Add(item.TextContent);
            }

            if (list.Count == 0) return null;
            return list;
        }
    }
}

/* var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("ddmDocTitle"));
            var items1 = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains(" ddmAuthorList"));
            var items2 = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("ddmPubYr"));
            var items3 = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("ddmDocSource"));


            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }
            foreach (var item in items1)
            {
                list.Add(item.TextContent);
            }
            foreach (var item in items2)
            {
                list.Add(item.TextContent);
            }
            foreach (var item in items3)
            {
                list.Add(item.TextContent);
            }

            return list;*/
