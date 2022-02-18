using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
 

namespace Day19Project4
{
        /********************************************************
         * Author:Sudha Kumari Sugasani
         * Purpose:Program to read XML file using C# code,reading 
         *         input from the user and printing the value
         *         
         * ******************************************************/

        internal class Program
        {
            static void Main(string[] args)
            {
                int id;
                Console.WriteLine("Enter Id");
                id = Convert.ToInt32(Console.ReadLine());
                XmlDocument doc = new XmlDocument();

                doc.Load("C:\\NH\\XML Files\\Employee.xml");
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                     bool isMatch = false;
                    foreach (XmlNode cnode in node.ChildNodes)
                    {
                        if (cnode.Name == "ID")
                        {
                            if (cnode.InnerText==id.ToString())
                            {
                                isMatch = true;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        if(cnode.Name=="Name"&&isMatch==true)
                        {
                            Console.WriteLine(cnode.InnerText);
                             break;
                        }
                    }
                 
                }
                Console.ReadLine();
            }
        }
    }


  
