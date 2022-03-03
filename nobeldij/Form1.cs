using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace nobeldij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" ||textBox3.Text =="" || textBox4.Text == "")
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
                return;
            }
            if (int.TryParse(textBox1.Text, out int év))
            {
                MessageBox.Show("Hiba! az évszám nem megfelelő!");
                return;
            }
            try
            {
                StreamWriter sw = new StreamWriter("uj_dijazott.txt");
                sw.WriteLine("Év;Név;SzületésHalálozás;Országkód");
                sw.WriteLine(textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text + ";");
                sw.Close();
                MessageBox.Show("sikeres mentés");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception error)
            {

                MessageBox.Show("hiba az állomány irásában!\n{error.Message}");
            }
           
        }
    }
}
