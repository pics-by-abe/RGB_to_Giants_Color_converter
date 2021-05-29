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

        string RintFinal;

        string GintFinal;

        string BintFinal;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string Rtxt = txtColorR.Text;
            int Rint = int.Parse(Rtxt);

            if (((double)Rint / (double)255) < 0.04045)
            {
                double Rint1 = (double)Rint / (double)255;
                RintFinal = Math.Round((Rint1 * 12.92), 3).ToString().Replace(",", ".");
            }
            else
            {
                double Rint1 = (double)Rint / (double)255;
                double Rint2 = Rint1 + 0.055;
                double Rint3 = (double)Rint2 / (double)1.055;
                double Rint4 = Math.Round(Math.Pow(Rint3, 2.4), 3);
                RintFinal = Rint4.ToString().Replace(",", ".");
            }


            string Gtxt = txtColorG.Text;
            int Gint = int.Parse(Gtxt);

            if (((double)Gint / (double)255) < 0.04045)
            {
                double Gint1 = (double)Gint / (double)255;
                GintFinal = Math.Round((Gint1 * 12.92), 3).ToString().Replace(",", ".");
            }
            else
            {
                double Gint1 = (double)Gint / (double)255;
                double Gint2 = Gint1 + 0.055;
                double Gint3 = (double)Gint2 / (double)1.055;
                double Gint4 = Math.Round(Math.Pow(Gint3, 2.4), 3);
                GintFinal = Gint4.ToString().Replace(",", ".");
            }
            



            string Btxt = txtColorB.Text;
            int Bint = int.Parse(Btxt);

            if (((double)Bint / (double)255) < 0.04045)
            {
                double Bint1 = (double)Bint / (double)255;
                BintFinal = Math.Round((Bint1 * 12.92), 3).ToString().Replace(",", ".");
            }
            else
            {
                double Bint1 = (double)Bint / (double)255;
                double Bint2 = Bint1 + 0.055;
                double Bint3 = (double)Bint2 / (double)1.055;
                double Bint4 = Math.Round(Math.Pow(Bint3, 2.4), 3);
                BintFinal = Bint4.ToString().Replace(",", ".");
            }
            txtOutPut.Text = $"{RintFinal} {GintFinal} {BintFinal}";

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
