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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double i = int.Parse(textBox1.Text);
                for (int j = 1; j < int.Parse(comboBox2.SelectedItem.ToString()); j++)
                {
                    i = i * (1 + 0.01 * int.Parse(comboBox1.SelectedItem.ToString()));
                }
                textBox4.Text = $"{i:F2}";
            } catch(Exception)
            {
                
            }
            

        }


        //form load wgrywa sie na poczatku odpalania aplikacji. 
        //odpalamy go klikajac 2 razy na "pulpit" naszej aplikacji
        //Pozwala na wgranie danych do kontrolek, list wybieralnych itp
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                
                comboBox1.Items.Add(i);

            }
            for (int i = 1; i <= 20; i++)
            {
                comboBox2.Items.Add(i);
            }
        }
    }
}
