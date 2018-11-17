using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        



        private void Form3_Load(object sender, EventArgs e)
        {
            oprocentowanie.Text = "3";
            anualCost.Text = "40000";
            taxRate.Text = "19%";
            inflationRate.Text = "1.8%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pozostalaKasa = double.Parse(startMoney.Text);
            int lata = 0;
            while (pozostalaKasa > 0)
            {
                pozostalaKasa = (double)(pozostalaKasa * ((1 + int.Parse(oprocentowanie.Text)*0.01) * 0.81)-(double)(40000*(1+0.018)));
                lata++;
            }
            textBox4.Text = lata.ToString();
        }
    }
}
