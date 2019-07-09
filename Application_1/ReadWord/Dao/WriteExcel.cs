using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;
using System.Xml;

namespace ReadWord.Dao {
    public class WriteExcel {
        
        public static void inputExcel() {
        
            //检查是否存在文件夹
            string subPath = @"D:/Excel";
            if (false == System.IO.Directory.Exists(subPath))
                System.IO.Directory.CreateDirectory(subPath);//创建Excel文件夹
            CreateXML(subPath);
        }
        private static void CreateXML(string Path) {
            string path = Path+ "/test1.xml";//创建或者覆盖文件
            Console.WriteLine(path);
            XmlTextWriter xml = new XmlTextWriter(path, Encoding.UTF8);
            xml.Formatting = Formatting.Indented;
            xml.WriteStartDocument();
            xml.WriteStartElement("web-app");//创建节点

            xml.WriteStartElement("servlet");//创建节点

            xml.WriteStartElement("ServletName");//创建节点
            xml.WriteCData("DispatchServlet");//写入数据
            xml.WriteEndElement();//结束

            xml.WriteStartElement("电话");//创建节点
            xml.WriteCData("134000000");
            xml.WriteEndElement();//结束

            xml.WriteEndElement();
            xml.WriteEndElement();

            xml.WriteEndDocument();
            xml.Flush();//刷新
            xml.Close();
        }
    }
}

