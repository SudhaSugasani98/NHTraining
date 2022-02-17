using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project3
{
    /******************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Program to read XML file using C# code and 
     *         printing details in XML file followed by ","
     * ****************************************************/

    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("C:\\NH\\XML Files\\Employee.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode cnode in node.ChildNodes)
                {
                    if (cnode.Name == "ID")
                    {
                        Console.Write(cnode.InnerText);
                    }
                    if(cnode.Name=="Name")
                    {
                        Console.Write(","+cnode.InnerText);
                    }
                    if(cnode.Name=="Salary")
                    {
                        Console.Write(","+cnode.InnerText);
                    }
                }
                Console.WriteLine();


            }
            Console.ReadLine();
        }
    }
}
