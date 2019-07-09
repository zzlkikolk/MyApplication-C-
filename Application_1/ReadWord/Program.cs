using System;
using ReadWord.Dao;
using Word = Microsoft.Office.Interop.Word;

namespace ReadWord {
    class Program {
       public static void Main(string[] args) {
            // Read(@"D:\document\gtx.docx");
            WriteExcel.inputExcel();
        }
       public static void Read(string Fileptah) {
            //byte[] byData=new 
            try {
                    Word.Application app = new Microsoft.Office.Interop.Word.Application();
                    Word.Document doc = null;
                    object unknow = Type.Missing;
                    app.Visible = false;//如果为true，会打开word文档
                   

                string str = Fileptah;
                object file = str;
                doc = app.Documents.Open(ref file,ref unknow);
                string[] temp = new string[doc.Paragraphs.Count];

                for (int i = 0; i < doc.Paragraphs.Count; i++)
                    temp[i] = doc.Paragraphs[i + 1].Range.Text.Trim();
                foreach (string x in temp)
                    Console.WriteLine(x);
            } catch (Exception e) {
                Console.WriteLine(e.Source);
                Console.WriteLine(e.Message);
            }
        }
    }
}
