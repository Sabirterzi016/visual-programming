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
    public partial class KitapEkle : Form
    {
        readonly AnaEkran anaEkran;
        readonly bool isEditMode;

        public KitapEkle(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(textBox1.Text, comboBox1.Text);
            anaEkran.kitapEkle(kitap);

            anaEkran.Show();
            this.Close();

            if (textBox1.Text == "" )
            {
                if (MessageBox.Show("Devam Etmek İstediğinize Emin Misiniz?", "Kitap Adı Veya Yazar Adı Girilmedi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }
            Kitap kitap2 = new Kitap
            {
                Ad = textBox1.Text,
                Yazar = comboBox1.Text
            };


            bool yazarDahaOnceEklendiMi = false;
            for (int i = 0; i < anaEkran.yazarIsimleri.Count; i++)
            {
                if ((string)anaEkran.yazarIsimleri[i] == comboBox1.Text)
                {
                    yazarDahaOnceEklendiMi = true;
                }
            }

            if (!yazarDahaOnceEklendiMi && comboBox1.Text != "")
            {
                anaEkran.yazarIsimleri.Add(comboBox1.Text);
            }

            if (isEditMode == false)
            {
                anaEkran.ekleKitap(kitap2);
                addCombo(textBox1.Text, comboBox1.Text);
            }
            else
            {
                anaEkran.yenileKitap(kitap2);
                anaEkran.kitap[anaEkran.selectedIndex] = kitap2;

            }
            anaEkran.Show();
            this.Close();
        }

        private void KitapEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
