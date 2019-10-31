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
            string journal;
            string pages;
            string additionalContent;
            int index;
            var data = list;
            int count = 0;
            
            var database = new BibTeXDatabase();
            BibTeXArticle[] article = new BibTeXArticle[data.Count / 5];
            for (int i = 0; i < data.Count; i += 5)
            {
                additionalContent = data[i + 4].Trim();
                journal = data[i + 3].Trim();
                index = journal.LastIndexOf(additionalContent);
                journal = journal.Remove(index);
                journal = journal.Replace("\n", "");

                int indexOfSubstring = additionalContent.LastIndexOf("pp."); //Получение индекса начала фразы "pp."
                if (indexOfSubstring == -1)
                {
                    pages = "";
                }
                else
                {
                    pages = additionalContent.Substring(indexOfSubstring+4, additionalContent.Length - indexOfSubstring-4);
                    additionalContent = additionalContent.Remove(indexOfSubstring);//удаление текста с информацией о странице
                    
                }

                article[count] = new BibTeXArticle
                {
                    Title = data[i],
                    Author = data[i + 1].Trim(),
                    Year = data[i + 2],
                    Journal = journal,
                    Pages = pages
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
