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
    public partial class Inwestycja : Form
    {
        double[] amounts;

        public Inwestycja()
        {
            InitializeComponent();
        }

        private void Inwestycja_Load(object sender, EventArgs e)
        {
            for (ushort i = 1; i <= 100; i++) //100
            {
                cbYears.Items.Add(i); //dodanie wartości do listy 
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lbAmounds.Items.Clear();

            foreach (var control in this.Controls)
            {
                if (control is TextBox )
                {
                    ((TextBox)control).BackColor = Color.White;
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).BackColor = Color.White;
                }
            }
            try
            {

                var amount = float.Parse(tbAmount.Text);
                var years = ushort.Parse(cbYears.Text);
                //var years = (ushort) cbYears.SelectedItem;
                var rate = float.Parse(tbRate.Text) / 100; //1.5%  -> 0.015

                futureValue(amount, years, rate);
                lblResult.Text = String.Format("Dla kwoty {0} zł i {1} lat oprocentowanie {2}% kwota wyniesie {3} zł",
                tbAmount.Text, years, (rate * 100), amount);

                


            }
            catch (FormatException ex)
            {
                lbAmounds.Items.Clear();
                
                float a;
                ushort b;
                if(!float.TryParse(tbAmount.Text, out a))
                {
                    tbAmount.BackColor = Color.Red;
                    
                    lbAmounds.Items.Add("Błędne dane w oknie Podaj Kwotę");
                    lbAmounds.Visible = true;
                }
                if (!ushort.TryParse(cbYears.Text, out b))
                {
                    cbYears.BackColor = Color.Red;
                    
                    lbAmounds.Items.Add("Błędne dane w oknie Liczba lat");
                    lbAmounds.Visible = true;
                }
                if (!float.TryParse(tbRate.Text, out a))
                {
                    tbRate.BackColor = Color.Red;
                    
                    lbAmounds.Items.Add("Błędne dane w oknie Oprocentowanie");
                    lbAmounds.Visible = true;
                }

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="years"></param>
        /// <param name="rate"></param>
        /// <returns></returns>

        private double futureValue(double amount,  ushort years, double rate)
        {
            amounts = new double[years+1];
            amounts[0] = amount;
            for (int i = 1; i <= years; i++)
            {
                
                amount *= (1 + rate);  //amout = amout * rate;
                amounts[i] = amount;
            }
            amounts[years] = amount;
            return amount;
        }

        private void kdl_button_Click(object sender, EventArgs e)
        {
            lbAmounds.Items.Clear();
            try
            {
                foreach (double i in amounts)
                {
                    lbAmounds.Items.Add(i);
                }
                lbAmounds.Visible = true;
            } catch (NullReferenceException ex)
            {
                lbAmounds.Items.Add("Musisz najpierw podać dane i wcisnąć przycisk 'Wylicz'!");
                lbAmounds.Visible = true;
            } 
        }

        
    }
}
