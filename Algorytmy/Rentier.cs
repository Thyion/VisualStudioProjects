using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytmy
{
    public partial class Rentier : Form
    {
        public Rentier()
        {
            InitializeComponent();
        }

        private void Inwestycja_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var amount = float.Parse(tbAmount.Text);         
            var rate = float.Parse(tbRate.Text) /100; //1.5%  -> 0.015

            var years = 0;
            while (amount <= 1000000)
            {
                amount *= (1 + rate);
                years++;
            }

            lblResult.Text = "Aby zostać milionerem potrzeba: " + years;
        }
    }
}
