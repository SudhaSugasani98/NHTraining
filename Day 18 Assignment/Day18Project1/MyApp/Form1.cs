using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathematicsLibrary;

namespace MyApp
{
    /*****************************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Creating a DesktopApplication using MathematicsLibrary
     *****************************************************************/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int result = Algebra.Factorial(n);
            textBox2.Text = result.ToString();
            Console.ReadLine();

        }
    }
}
