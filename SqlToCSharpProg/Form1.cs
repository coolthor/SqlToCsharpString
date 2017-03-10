using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SqlToCSharpProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("UPDATE")|| textBox1.Text.Contains("INSERT"))
            {
                MatchEvaluator myEvaluator = new MatchEvaluator(replace);
                textBox2.Text = Regex.Replace(textBox1.Text, "<[^>]+>", myEvaluator);
                i = -1;
            }
            
        }

        public static int i = -1;

        private string replace(Match match)
        {
            i++;
            return "N'{" + i.ToString() + "}'";
        }
    }
}
