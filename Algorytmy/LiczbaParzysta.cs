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
    public partial class LiczbaParzysta : Form
    {
        public LiczbaParzysta()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbNumber.Text); //pobranie wartości z kontrolki i zmiana na int 

            // reszta z dzielenia liczby przez 2 wynosi 0 (==)   if/else
            //% - modulo
            if (number % 2 == 0) 
            {
                lblResult.Text = "Liczba parzysta"; 
            }
            else
            {
                lblResult.Text = "Liczba nieparzysta";
            }

            //lblResult.Text = "Podana liczba to " + number.ToString(); //wstawienie wartości ze zmiennej zmienionej na string
            #region skróty klawiszone
            //lblResult.Text = DateTime.Now.ToString();
            //lblResult.ForeColor = System.Drawing.Color.Red;
            //CTRL + K + D - wyrównanie/formatowanie kodu
            //CTRL + Spacja - wymuszenie podpowiedzi
            //CTRL + K + C - komentarz dla lini/zaznaczonego kodu
            //CTRL + K + U - usunięcie komentarza dla lini/zaznaczonego kodu
            //F5 - uruchomienie aplikacji w trybie debugowania
            //SHIFT + F5 - zatrzymanie aplikacji w trybie debugowania
            #endregion
        }
    }
}
