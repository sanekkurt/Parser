using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibTeX;

namespace Parser.Save
{
    class SaveBibTeX
    {

        public void InBibTeX(List<String> list, string path)
        {
            var data = list;
            int count = 0;
            var database = new BibTeXDatabase();
            BibTeXArticle[] article = new BibTeXArticle[data.Count / 3];
            for (int i = 0; i < data.Count; i += 3)
            {
                article[count] = new BibTeXArticle
                {
                    Title = data[i],
                    Author = data[i + 1],
                    Journal = data[i + 2]
                };
                count++;
            }

            foreach(var i in article)
            {
                database.Entries.Add(i);
            }

            var text = BibTeXUtilities.ConvertBibTeXDatabaseToText(database);
            var article1 = new BibTeXArticle();

        }

        
    }
}
