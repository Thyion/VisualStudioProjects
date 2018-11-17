using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();

            if(!checkBox1.Checked)
            checkBox1.Checked = true;
            else
            checkBox1.Checked = false;
            textBox1.ForeColor = Color.Lime;
            groupBox1.Visible = true;

            try {
                int number = int.Parse(textBox2.Text);
                textBox3.Text = number.ToString();
            }
            catch (Exception) {
                textBox3.Text = "Nie podałeś liczby tylko tekst";
            }

            //ctrl + K + D - wyrównanie/formatowanie kodu
            //ctrl+spacja - wymuszenie podpowiedzi
            //ctrl + K +C - komentarz dla lini/zaznaczonego kodu
            //ctrl + K + U - usunięcie komentarza
            //F5 - uruchomienie plikacji w trybie debugowania
            //SHIFT + F5 - zatrzymanie aplikacji w trybie debugowania

        }
    }
}
