using Day21Project2.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day21Project2
{
    /******************************************************************************
     * Author:Sudha Kumari Sugasani
     * Purpose:Example program for windows application and consume the web service
     *******************************************************************************/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            WebService1SoapClient obj = new WebService1SoapClient();
            textBox2.Text = obj.Factorial(n).ToString();
        }
    }
}
