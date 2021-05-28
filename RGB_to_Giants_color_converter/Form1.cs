using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_to_Giants_Color_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string Rtxt = txtColorR.Text;
            int Rint = int.Parse(Rtxt);
            double Rint1 = (double)(Rint) / (double)(255);
            double Rfinal = Math.Round(Math.Pow(Rint1, (1 / 2.2)), 3);
            string Rfinalstr = Rfinal.ToString().Replace(",", ".");


            string Gtxt = txtColorG.Text;
            int Gint = int.Parse(Gtxt);
            double Gint1 = (double)(Gint) / (double)(255);
            double Gfinal = Math.Round(Math.Pow(Gint1, (1 / 2.2)), 3);
            string Gfinalstr = Gfinal.ToString().Replace(",", ".");



            string Btxt = txtColorB.Text;
            int Bint = int.Parse(Btxt);
            double Bint1 = (double)(Bint) / (double)(255);
            double Bfinal = Math.Round(Math.Pow(Bint1, (1 / 2.2)), 3);
            string Bfinalstr = Bfinal.ToString().Replace(",", ".");


            txtOutPut.Text = Rfinalstr + " " + Gfinalstr + " " + Bfinalstr;

        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/pics-by-abe/");
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtOutPut.Text);
        }
    }
}
