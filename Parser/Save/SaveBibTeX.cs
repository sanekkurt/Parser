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
            var data = list;
            int count = 0;
            
            var database = new BibTeXDatabase();
            BibTeXArticle[] article = new BibTeXArticle[data.Count / 4];
            for (int i = 0; i < data.Count; i += 4)
            {
                
                journal = data[i + 3].Trim();
                journal = journal.Replace("\n", " ");
                
                int indexOfSubstring = journal.LastIndexOf("pp."); //Получение индекса начала фразы "pp."
                if (indexOfSubstring == -1)
                {
                    pages = "";
                }
                else
                {
                    pages = journal.Substring(indexOfSubstring+4, journal.Length - indexOfSubstring-4);
                    journal = journal.Remove(indexOfSubstring);//удаление текста с информацией о странице
                    if (journal[journal.Length - 2] == ',')
                    {
                        journal = journal.Remove(journal.Length - 2);//удаление запятой с пробелом, оставшиеся после удаления инфы о странице
                    }
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
