using System;
using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;

namespace Parser.Save
{
    public  class SaveDocument
    {
        public void InDoc(List<String> list, string path)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            Word.Document wordDoc = wordApp.Documents.Add();
            var wordParag = wordDoc.Paragraphs.Add();

            wordParag.Range.Font.Name = "Times New Roman";
            wordParag.Range.Font.Size = 16;
            wordParag.Range.Font.Bold = 1;
            wordParag.Range.Text = "БИБЛИОГРАФИЧЕСКИЙ СПИСОК АВТОРА";
            wordParag.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            wordDoc.Paragraphs.Add();
            wordParag.Range.Font.Name = "Times New Roman";
            wordParag.Range.Font.Size = 14;
            wordParag.Range.Font.Bold = 0;
            wordParag.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;

            wordDoc.Paragraphs.Add();
            
            wordParag.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordParag.Range.Tables.Add(wordParag.Range, list.Count/3+1, 5, Type.Missing, Type.Missing);
            var wordTable = wordDoc.Tables[1];
            wordTable.Range.Font.Bold = 0;
            wordTable.Range.Font.Size = 14;

            wordTable.Columns.PreferredWidthType = Word.WdPreferredWidthType.wdPreferredWidthPoints;
            wordTable.Columns[1].SetWidth(35, Word.WdRulerStyle.wdAdjustNone);
            wordTable.Columns[2].SetWidth(140, Word.WdRulerStyle.wdAdjustNone);
            wordTable.Columns[3].SetWidth(70, Word.WdRulerStyle.wdAdjustNone);
            wordTable.Columns[4].SetWidth(120, Word.WdRulerStyle.wdAdjustNone);
            wordTable.Rows.Alignment = Word.WdRowAlignment.wdAlignRowLeft;
           
            wordTable.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            wordTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            wordTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            wordTable.Range.Select();
            wordTable.Rows[1].Range.Font.Bold = 1;

           
            wordTable.Cell(1, 1).Range.Text = "№\nп/п";
            wordTable.Cell(1, 2).Range.Text = "Наименование научных трудов";
            wordTable.Cell(1, 3).Range.Text = "Форма научных трудов";
            wordTable.Cell(1, 4).Range.Text = "Выходные данные";
            wordTable.Cell(1, 5).Range.Text = "Соавторы";
          

            int k = 0;
            for (int i = 2; i <= list.Count/3+1; i++)
            {
                wordTable.Cell(i, 1).Range.Text = (i-1).ToString();
                for (int j = 2; j < 6; j++)
                {
                  
                    if (j == 3) wordTable.Cell(i, j).Range.Text = "Печатная";
                    else if (j == 4)
                    {
                        wordTable.Cell(i, j).Range.Text = list[k + 1].Replace("\n"," ");
                        k++;
                    }
                    else if (j == 5)
                    {
                        wordTable.Cell(i, j).Range.Text = list[k - 1].Replace("\n", " ");
                        k++;
                    }
                    else
                    {
                        wordTable.Cell(i, j).Range.Text = list[k].Replace("\n", " ");
                        k++;
                    }
                }
            }


            wordDoc.SaveAs(path);
            wordApp.ActiveDocument.Close();
            wordApp.Quit();
        }
    }
}
