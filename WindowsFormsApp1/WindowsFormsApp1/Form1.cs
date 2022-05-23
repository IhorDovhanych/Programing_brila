using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<Func<double, double>> funcList;
        Func<double, double> func;
        public Form1()
        {
            InitializeComponent();
            funcList = new List<Func<double, double>>();
            funcList.Add(Math.Sin);
            funcList.Add(Math.Cos);
            funcList.Add((x) => x*x);
        }

        private void sinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func = funcList[0];
        }

        private void cosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func = funcList[1];
        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func = funcList[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            double a = -10;
            double b = 10;
            double pointsStep = (b - a) / 200;
            double x = a;
            
            
            while(x < b)
            {
                
                chart1.Series[0].Points.AddXY(x, func(x));
                x += pointsStep;
            }
        }
    }
}
