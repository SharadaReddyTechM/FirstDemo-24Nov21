using System;
using System.Xml;

namespace FirstDemo
{
    class WorkingWithXML
    {
        static void Main(string[] args)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("");

            XmlReader xreader = XmlReader.Create("https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            while (xreader.Read())
            {
                if((xreader.NodeType==XmlNodeType.Element)&&(xreader.Name=="Cube"))
                {
                    if(xreader.HasAttributes)
                    {
                        Console.WriteLine(xreader.GetAttribute("currency")+" : "+xreader.GetAttribute("rate"));
                        
                    }
                }
            }

            Console.Read();
        }
    }
}
