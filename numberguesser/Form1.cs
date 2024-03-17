using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberguesser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int incercari = 0;

        private Random rnd = new Random();
        private int numar;
        private DateTime starttime = DateTime.Now;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label3.Text = "Timp: " + (DateTime.Now - starttime).Seconds.ToString() + " secunde";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            starttime = DateTime.Now;
            timer1.Start();
            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            incercari++;
            if(Int16.Parse(textBox1.Text) == numar)
            {
                timer1.Stop();
                MessageBox.Show("Ai ghicit numarul in " + (DateTime.Now - starttime).Seconds.ToString() + " secunde si un numar de " + incercari.ToString() + " incercari");
                
            }
            else if(Int16.Parse(textBox1.Text) > numar)
            {
                MessageBox.Show("Numarul este mai mic.");
            }
            else
            {
                MessageBox.Show("Numarul este mai mare.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numar = rnd.Next(0, 101);
        }
    }
}
