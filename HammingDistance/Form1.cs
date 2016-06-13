using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HammingDistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapa_Click(object sender, EventArgs e)
        {

        }


        public static int GetHammingDistance(string source, string target)
        {
            if (source.Length != target.Length)
            {
                throw new Exception("Strings must be equal length");
            }

            int distance =
                source.ToCharArray()
                .Zip(target.ToCharArray(), (c1, c2) => new { c1, c2 })
                .Count(m => m.c1 != m.c2);

            return distance;
        }
    }
}
