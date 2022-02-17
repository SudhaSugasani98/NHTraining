using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project1
{
    /*************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Program to read XML file using C# code.
     * ************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
        
            doc.Load("C:\\NH\\XML Files\\Employee.xml");
            foreach(XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string text = node.InnerText;
                Console.WriteLine(text);
               
            }Console.ReadLine();
        }  
    }
}
