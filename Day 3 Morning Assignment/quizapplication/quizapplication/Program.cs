using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizapplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Score = 0, ans;
            String name;
            
            Console.WriteLine("Enter your name");
            name =Console.ReadLine();
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Hi {0},Welcome to qui z by Sudha",name);
            Console.WriteLine("*********************************************************");

            Console.WriteLine("Q1.What are the missing letters in this word e_ep_ant ");
            Console.WriteLine("1.a,b   2.h,l   3.l,h   4.c,d");
            Console.WriteLine("Enter your Choice");
            ans=Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                Score += 20;

            Console.WriteLine("Q2.What are the missing letters in this word pa__nt ");
            Console.WriteLine("1.r,e   2.e,r   3.a,a   4.b,b");
            Console.WriteLine("Enter your Choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                Score += 20;

            Console.WriteLine("Q3.How many colours are there in Rainbow? ");
            Console.WriteLine("1.10   2.7   3.8  4.6");
            Console.WriteLine("Enter your Choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                Score += 20;

            Console.WriteLine("Q4.4*4= ");
            Console.WriteLine("1.8   2.0  3.23   4.16");
            Console.WriteLine("Enter your Choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                Score += 20;

            Console.WriteLine("Q5.Who is our Primeminister? ");
            Console.WriteLine("1.NarendraModi  2.Y.S.JaganMohanReddy   3.Amitshah  4.ChadraSekharaRao");
            Console.WriteLine("Enter your Choice");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                Score += 20;
            if(Score>=60)
                Console.WriteLine("Congratulations {0} you got {1}% in this quiz",name,Score);
            else
                Console.WriteLine("Sorry {0} you got only {1}%.Try again",name,Score);

            Console.ReadLine();
        }
    }
}
