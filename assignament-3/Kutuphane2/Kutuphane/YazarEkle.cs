using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class YazarEkle : Form
    {
        readonly AnaEkran anaEkran;

        public YazarEkle(AnaEkran ae)
        {
            anaEkran = ae;
            InitializeComponent();
        }

        private void YazarEkle_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < anaEkran.yazarIsimleri.Count; i++)
            {
                comboBox1.Items.Add(anaEkran.yazarIsimleri[i]);
            }

            if (comboBox1.Items.Count < 1)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            anaEkran.yazarEkle(textBox1.Text);

            comboBox1.Items.Clear();
            for (int i = 0; i < anaEkran.yazarIsimleri.Count; i++)
            {
                comboBox1.Items.Add(anaEkran.yazarIsimleri[i]);
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.Text = (string)comboBox1.Items[comboBox1.Items.Count - 1];
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            anaEkran.yazarSil(comboBox1.SelectedIndex);

            comboBox1.Items.Clear();

            for (int i = 0; i < anaEkran.yazarIsimleri.Count; i++)
            {
                comboBox1.Items.Add(anaEkran.yazarIsimleri[i]);
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.Text = (string)comboBox1.Items[comboBox1.Items.Count - 1];
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count < 1)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void YazarEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }
    }
}
