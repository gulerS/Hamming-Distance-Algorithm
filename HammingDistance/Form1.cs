﻿using System;
using System.Data;
using System.Windows.Forms;

namespace HammingDistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable dt = new DataTable();

        /*  
         *  hamming distance hesaplama         
         */

        private void btnHesapa_Click(object sender, EventArgs e)
        {
            var counter = 0;
            var uzunluk = 0;
            dataGridView1.Rows.Clear();
            if (txtString1.TextLength != txtString2.TextLength)
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
                    dataGridView1.Rows.Add(i, metin1[i], metin2[i]);
                }
            }

            lblSonuc.Text = @"Hamming Distance : " + (uzunluk - counter).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


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
