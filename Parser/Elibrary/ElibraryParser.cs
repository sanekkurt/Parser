using System.Collections.Generic;
using System.Linq;
using AngleSharp.Html.Dom;
using Parser.Common;


namespace Parser.Elibrary
{
    class ElibraryParser : IParser<List<string>>
    {
        public List<string> Parse(IHtmlDocument document)
        {

            var list = new List<string>();


            var items = document.QuerySelectorAll("a b, table#restab tbody tr td font").Where(t => t.TextContent != " №" && t.TextContent != "Публикация" && t.TextContent != "Цит.");
            // var items1 = document.QuerySelectorAll("table#restab tbody tr td:not(.select-tr-left) font");
            //var items = document.QuerySelectorAll("a b, table#restab tbody tr td:not(.select-tr-left) font").Where(t=> t.TextContent != " №" && t.TextContent != "Публикация" && t.TextContent != "Цит.");
            foreach (var item in items)
            {
                if (item.ParentElement.ClassName == "select-tr-left")
                    list.Add("|");
                else
                    list.Add(item.TextContent);
            }



            if (list.Count == 0) return null;
            return list;
        }
    }
}
