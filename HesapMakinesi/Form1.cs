using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        
        double s1, s2;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }
        private void SayıEkle(string sayı)
        {
            if (TxtIslemEkranı.Text == "0")
            {
                TxtIslemEkranı.Text = sayı;
            }
            else
            {
                TxtIslemEkranı.Text += sayı;
            }
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            SayıEkle("1");   
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            SayıEkle("2");
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            SayıEkle("3");
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            SayıEkle("4");
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            SayıEkle("5");
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            SayıEkle("6");
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            SayıEkle("7");
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            SayıEkle("8");
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            SayıEkle("9");
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            SayıEkle("0");
        }
        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TxtIslemEkranı.Text) > 0)
            {
                TxtIslemEkranı.Text = TxtIslemEkranı.Text.Remove(TxtIslemEkranı.Text.Length - 1);
                if (TxtIslemEkranı.Text.Length == 0)
                {
                    TxtIslemEkranı.Text = "0";
                }
            }
        }
        private void BtnTopla_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(TxtIslemEkranı.Text);
            islem = "+";
            LblIslem.Text = TxtIslemEkranı.Text + " +";
            TxtIslemEkranı.Text = "";
        }
        private void BtnEsittir_Click(object sender, EventArgs e)
        {
            s2 = Convert.ToDouble(TxtIslemEkranı.Text);
            if (islem == "+")
            {
                TxtIslemEkranı.Text = Convert.ToString(s1 + s2);
                LblIslem.Text = "";
            }
            if (islem == "-")
            {
                TxtIslemEkranı.Text = Convert.ToString(s1 - s2);
                LblIslem.Text = "";
            }
            if (islem == "*")
            {
                TxtIslemEkranı.Text = Convert.ToString(s1 * s2);
                LblIslem.Text = "";
            }          
                if (islem == "/")
                {
                    if (s2 == 0)
                    {
                        TxtIslemEkranı.Text = "Uygulanamaz"; 
                    }
                    else
                    {
                        TxtIslemEkranı.Text = Convert.ToString(s1 / s2);
                        LblIslem.Text = "";
                    }
                }
            if(islem == "mod")
            {
                TxtIslemEkranı.Text = Convert.ToString(s1 % s2);
                LblIslem.Text = "";
            }
            LblIslem.Text = "";
            islem = null;
            s1 = 0;
            s2 = 0;
        }
        private void BtnCıkar_Click(object sender, EventArgs e)
        {           
            s1 = Convert.ToDouble(TxtIslemEkranı.Text);
            islem = "-";
            LblIslem.Text = TxtIslemEkranı.Text + " -";
            TxtIslemEkranı.Text = "";
        }
        private void BtnCarp_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(TxtIslemEkranı.Text);
            islem = "*";
            LblIslem.Text = TxtIslemEkranı.Text + " x";
            TxtIslemEkranı.Text = "";
        }
        private void BtnBol_Click(object sender, EventArgs e)
        {            
            s1 = Convert.ToDouble(TxtIslemEkranı.Text);
            islem = "/";
            LblIslem.Text = TxtIslemEkranı.Text + " ÷";
            TxtIslemEkranı.Text = "";            
        }
        private void BtnKareAlma_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(TxtIslemEkranı.Text);
            kare = Math.Pow(kare, 2);
            TxtIslemEkranı.Text = Convert.ToString(kare);
        }
        private void BtnMod_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(TxtIslemEkranı.Text);
            islem = "mod";
            LblIslem.Text = TxtIslemEkranı.Text + " %";
            TxtIslemEkranı.Text = "";
        }
        private void BtnVirgul_Click(object sender, EventArgs e)
        {
            if (TxtIslemEkranı.Text.IndexOf(",") < 1)
            {
                TxtIslemEkranı.Text += ",";
            }
        }

        
        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtIslemEkranı.Text = "0";
            LblIslem.Text = "";
        }
    }
}
