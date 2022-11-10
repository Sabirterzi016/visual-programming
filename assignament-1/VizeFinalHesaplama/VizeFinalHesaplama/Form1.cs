using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinalHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 100;

            double vize = Convert.ToDouble(numericUpDown1.Value),
                final = Convert.ToDouble(numericUpDown2.Value),
                ort =0;

            ort = (final * 0.6) + (vize * 0.4);
            if (final < 50 )
            {
                label4.Text = "FF harf notu ile dersten kaldınız:(";
                label4.ForeColor = Color.Red;
            }
            else if (ort >= 85)
            {
                label4.Text = "AA harf notu ile dersten geçtiniz:)";
                label4.ForeColor = Color.Green;
            }
            else if (ort >= 80)
            {
                label4.Text = "BA harf notu ile dersten geçtiniz:)";
                label4.ForeColor = Color.Green;
            }
            else if (ort >= 75)
            {
                label4.Text = "BB harf notu ile dersten geçtiniz:)";
                label4.ForeColor = Color.Green;
            }
            else if (ort >= 70)
            {
                label4.Text = "CB harf notu ile dersten geçtiniz:)";
                label4.ForeColor = Color.Green;
            }
            else if (ort >= 60)
            {
                label4.Text = "CC harf notu ile dersten geçtiniz:)";
                label4.ForeColor = Color.Green;
            }
            else if (ort >= 55)
            {
                label4.Text = "DC harf notu ile dersten geçtiniz:)";
                label4.ForeColor = Color.Green;
            }
            else if (ort >= 50)
            {
                label4.Text = "DD harf notu ile dersten geçtiniz:)";
                label4.ForeColor = Color.Green;
            }
            else if (ort >= 40)
            {
                label4.Text = "FD harf notu ile dersten kaldınız:(";
                label4.ForeColor = Color.Red;
            }
            else if (ort >= 39)
            {
                label4.Text = "FF harf notu ile dersten kaldınız:(";
                label4.ForeColor = Color.Red;
            }
            label5.Text = "Ders ortalamanız: " + Convert.ToString(ort);
        }
    }
}
