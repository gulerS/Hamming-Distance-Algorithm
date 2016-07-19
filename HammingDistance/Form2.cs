using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HammingDistance
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

   

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            var counter = 0;
            var uzunluk = 0;
            metroGrid1.Rows.Clear();
            if (txtString1.Text.Length != txtString2.Text.Length)
            {
                MessageBox.Show(@"Girilen Metinler eşit uzunlukta değil");
                return;
            }

            Char[] metin1 = txtString1.Text.ToCharArray();
            Char[] metin2 = txtString2.Text.ToCharArray();
            uzunluk = metin1.Length;

            for (var i = 0; i < uzunluk; i++)
            {
                if (metin1[i].Equals(metin2[i]))
                {
                    counter++;
                }
                else
                {
                    metroGrid1.Rows.Add(i, metin1[i], metin2[i]);
                }
            }

            lblSonuc.Text = @"Hamming Distance : " + (uzunluk - counter);
        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            this.metroGrid1.ClearSelection();
        }


        //alternatif yöntem
        //public static int GetHammingDistance(string source, string target)
        //{
        //    if (source.Length != target.Length)
        //    {
        //        throw new Exception("Strings must be equal length");
        //    }

        //    int distance =
        //        source.ToCharArray()
        //        .Zip(target.ToCharArray(), (c1, c2) => new { c1, c2 })
        //        .Count(m => m.c1 != m.c2);

        //    return distance;
        //}
    }
}
