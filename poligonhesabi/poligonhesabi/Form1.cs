using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace poligonhesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kirilma = 0; double pi = 2 * Math.Asin(1.0);
        double mod, tam, dagit;
        private void txtx4_TextChanged(object sender, EventArgs e)
        {

        }
        double fbmax;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                bool eh = true;
                while (eh == true)
                {
                    try
                    {
                        kirilma = Convert.ToInt32(Interaction.InputBox("Kaç tane kırılma açısı gireceksiniz ? ", "BİLGİ GİRİŞİ", "Örn:5"));
                        if (kirilma < 3 || kirilma > 9)
                        {
                            MessageBox.Show("3-9 arasında bir değer giriniz .");

                        }
                        else { eh = false; }
                    }
                    catch
                    { MessageBox.Show("Girdiğiniz sayı sayısal içerikler barındırmıyor olabilir veya tam sayı girmemiş olabilirsiniz. "); }
                }
                fbmax = 1.5 * Math.Sqrt(kirilma);
                fbmax = fbmax * 100;
                fbmax = Math.Round(fbmax, 0);
                lblbfb.Text = fbmax.ToString() + " ᶜᶜ";
                switch (kirilma)
                {
                    case 3:
                        {
                            txtka1.Visible = true; txtka2.Visible = true; txtka3.Visible = true;
                            txtka1.BackColor = Color.Indigo; txtka2.BackColor = Color.Indigo; txtka3.BackColor = Color.Indigo;
                            txtka1.ForeColor = Color.White; txtka2.ForeColor = Color.White; txtka3.ForeColor = Color.White;
                            lbl3.Visible = true; lbl4.Visible = true; lbl4.Text = "C"; lbl5.Visible = true; lbl5.Text = "D";
                            txtaa1.Visible = true; txtaa4.Visible = true; txtkenar1.Visible = true; txtkenar2.Visible = true;
                            txtaa1.BackColor = Color.Indigo; txtaa4.BackColor = Color.Indigo; txtkenar1.BackColor = Color.Indigo; txtkenar2.BackColor = Color.Indigo;
                            txtaa1.ForeColor = Color.White; txtaa4.ForeColor = Color.White; txtkenar1.ForeColor = Color.White; txtkenar2.ForeColor = Color.White;
                            txty1.Visible = true; txty3.Visible = true; txtx1.Visible = true; txtx3.Visible = true;
                            txty1.BackColor = Color.Indigo; txty3.BackColor = Color.Indigo; txtx1.BackColor = Color.Indigo; txtx3.BackColor = Color.Indigo;
                            txty1.ForeColor = Color.White; txty3.ForeColor = Color.White; txtx1.ForeColor = Color.White; txtx3.ForeColor = Color.White;
                            break;
                        }
                    case 4:
                        {
                            txtka1.Visible = true; txtka2.Visible = true; txtka3.Visible = true; txtka4.Visible = true;
                            txtka1.BackColor = Color.Indigo; txtka2.BackColor = Color.Indigo; txtka3.BackColor = Color.Indigo; txtka4.BackColor = Color.Indigo;
                            txtka1.ForeColor = Color.White; txtka2.ForeColor = Color.White; txtka3.ForeColor = Color.White; txtka4.ForeColor = Color.White;
                            lbl4.Visible = true; lbl5.Visible = true; lbl6.Visible = true; lbl3.Visible = true; lbl5.Text = "C"; lbl6.Text = "D";
                            txtaa1.Visible = true; txtaa5.Visible = true; txtkenar1.Visible = true; txtkenar2.Visible = true; txtkenar3.Visible = true;
                            txtaa1.BackColor = Color.Indigo; txtaa5.BackColor = Color.Indigo; txtkenar1.BackColor = Color.Indigo; txtkenar2.BackColor = Color.Indigo; txtkenar3.BackColor = Color.Indigo;
                            txtaa1.ForeColor = Color.White; txtaa5.ForeColor = Color.White; txtkenar1.ForeColor = Color.White; txtkenar2.ForeColor = Color.White; txtkenar3.ForeColor = Color.White;
                            txty1.Visible = true; txty4.Visible = true; txtx1.Visible = true; txtx4.Visible = true;
                            txty1.BackColor = Color.Indigo; txty4.BackColor = Color.Indigo; txtx1.BackColor = Color.Indigo; txtx4.BackColor = Color.Indigo;
                            txty1.ForeColor = Color.White; txty4.ForeColor = Color.White; txtx1.ForeColor = Color.White; txtx4.ForeColor = Color.White;
                            break;
                        }
                    case 5:
                        {
                            txtka1.Visible = true; txtka2.Visible = true; txtka3.Visible = true; txtka4.Visible = true; txtka5.Visible = true;
                            txtka1.BackColor = Color.Indigo; txtka2.BackColor = Color.Indigo; txtka3.BackColor = Color.Indigo; txtka4.BackColor = Color.Indigo; txtka5.BackColor = Color.Indigo;
                            txtka1.ForeColor = Color.White; txtka2.ForeColor = Color.White; txtka3.ForeColor = Color.White; txtka4.ForeColor = Color.White; txtka5.ForeColor = Color.White;
                            lbl4.Visible = true; lbl5.Visible = true; lbl6.Visible = true; lbl7.Visible = true; lbl3.Visible = true; lbl6.Text = "C"; lbl7.Text = "D";
                            txtaa1.Visible = true; txtaa6.Visible = true; txtkenar1.Visible = true; txtkenar2.Visible = true; txtkenar3.Visible = true; txtkenar4.Visible = true;
                            txtaa1.BackColor = Color.Indigo; txtaa6.BackColor = Color.Indigo; txtkenar1.BackColor = Color.Indigo; txtkenar2.BackColor = Color.Indigo; txtkenar3.BackColor = Color.Indigo; txtkenar4.BackColor = Color.Indigo;
                            txtaa1.ForeColor = Color.White; txtaa6.ForeColor = Color.White; txtkenar1.ForeColor = Color.White; txtkenar2.ForeColor = Color.White; txtkenar3.ForeColor = Color.White; txtkenar4.ForeColor = Color.White;
                            txty1.Visible = true; txty5.Visible = true; txtx1.Visible = true; txtx5.Visible = true;
                            txty1.BackColor = Color.Indigo; txty5.BackColor = Color.Indigo; txtx1.BackColor = Color.Indigo; txtx5.BackColor = Color.Indigo;
                            txty1.ForeColor = Color.White; txty5.ForeColor = Color.White; txtx1.ForeColor = Color.White; txtx5.ForeColor = Color.White;
                            break;
                        }
                    case 6:
                        {
                            txtka1.Visible = true; txtka2.Visible = true; txtka3.Visible = true; txtka4.Visible = true; txtka5.Visible = true; txtka6.Visible = true;
                            txtka1.BackColor = Color.Indigo; txtka2.BackColor = Color.Indigo; txtka3.BackColor = Color.Indigo; txtka4.BackColor = Color.Indigo; txtka5.BackColor = Color.Indigo; txtka6.BackColor = Color.Indigo;
                            txtka1.ForeColor = Color.White; txtka2.ForeColor = Color.White; txtka3.ForeColor = Color.White; txtka4.ForeColor = Color.White; txtka5.ForeColor = Color.White; txtka6.ForeColor = Color.White;
                            lbl4.Visible = true; lbl5.Visible = true; lbl6.Visible = true; lbl7.Visible = true; lbl3.Visible = true; lbl8.Visible = true; lbl7.Text = "C"; lbl8.Text = "D";
                            txtaa1.Visible = true; txtaa7.Visible = true; txtkenar1.Visible = true; txtkenar2.Visible = true; txtkenar3.Visible = true; txtkenar4.Visible = true; txtkenar5.Visible = true;
                            txtaa1.BackColor = Color.Indigo; txtaa7.BackColor = Color.Indigo; txtkenar1.BackColor = Color.Indigo; txtkenar2.BackColor = Color.Indigo; txtkenar3.BackColor = Color.Indigo; txtkenar4.BackColor = Color.Indigo; txtkenar5.BackColor = Color.Indigo;
                            txtaa1.ForeColor = Color.White; txtaa7.ForeColor = Color.White; txtkenar1.ForeColor = Color.White; txtkenar2.ForeColor = Color.White; txtkenar3.ForeColor = Color.White; txtkenar4.ForeColor = Color.White; txtkenar5.ForeColor = Color.White;
                            txty1.Visible = true; txty6.Visible = true; txtx1.Visible = true; txtx6.Visible = true;
                            txty1.BackColor = Color.Indigo; txty6.BackColor = Color.Indigo; txtx1.BackColor = Color.Indigo; txtx6.BackColor = Color.Indigo;
                            txty1.ForeColor = Color.White; txty6.ForeColor = Color.White; txtx1.ForeColor = Color.White; txtx6.ForeColor = Color.White;
                            break;
                        }
                    case 7:
                        {
                            txtka1.Visible = true; txtka2.Visible = true; txtka3.Visible = true; txtka4.Visible = true; txtka5.Visible = true; txtka6.Visible = true; txtka7.Visible = true;
                            txtka1.BackColor = Color.Indigo; txtka2.BackColor = Color.Indigo; txtka3.BackColor = Color.Indigo; txtka4.BackColor = Color.Indigo; txtka5.BackColor = Color.Indigo; txtka6.BackColor = Color.Indigo; txtka7.BackColor = Color.Indigo;
                            txtka1.ForeColor = Color.White; txtka2.ForeColor = Color.White; txtka3.ForeColor = Color.White; txtka4.ForeColor = Color.White; txtka5.ForeColor = Color.White; txtka6.ForeColor = Color.White; txtka7.ForeColor = Color.White;
                            lbl4.Visible = true; lbl5.Visible = true; lbl6.Visible = true; lbl7.Visible = true; lbl3.Visible = true; lbl8.Visible = true; lbl9.Visible = true; lbl8.Text = "C"; lbl9.Text = "D";
                            txtaa1.Visible = true; txtaa8.Visible = true; txtkenar1.Visible = true; txtkenar2.Visible = true; txtkenar3.Visible = true; txtkenar4.Visible = true; txtkenar5.Visible = true; txtkenar6.Visible = true;
                            txtaa1.BackColor = Color.Indigo; txtaa8.BackColor = Color.Indigo; txtkenar1.BackColor = Color.Indigo; txtkenar2.BackColor = Color.Indigo; txtkenar3.BackColor = Color.Indigo; txtkenar4.BackColor = Color.Indigo; txtkenar5.BackColor = Color.Indigo; txtkenar6.BackColor = Color.Indigo;
                            txtaa1.ForeColor = Color.White; txtaa8.ForeColor = Color.White; txtkenar1.ForeColor = Color.White; txtkenar2.ForeColor = Color.White; txtkenar3.ForeColor = Color.White; txtkenar4.ForeColor = Color.White; txtkenar5.ForeColor = Color.White; txtkenar6.ForeColor = Color.White;
                            txty1.Visible = true; txty7.Visible = true; txtx1.Visible = true; txtx7.Visible = true;
                            txty1.BackColor = Color.Indigo; txty7.BackColor = Color.Indigo; txtx1.BackColor = Color.Indigo; txtx7.BackColor = Color.Indigo;
                            txty1.ForeColor = Color.White; txty7.ForeColor = Color.White; txtx1.ForeColor = Color.White; txtx7.ForeColor = Color.White;
                            break;
                        }
                    case 8:
                        {
                            txtka1.Visible = true; txtka2.Visible = true; txtka3.Visible = true; txtka4.Visible = true; txtka5.Visible = true; txtka6.Visible = true; txtka7.Visible = true; txtka8.Visible = true;
                            txtka1.BackColor = Color.Indigo; txtka2.BackColor = Color.Indigo; txtka3.BackColor = Color.Indigo; txtka4.BackColor = Color.Indigo; txtka5.BackColor = Color.Indigo; txtka6.BackColor = Color.Indigo; txtka7.BackColor = Color.Indigo; txtka8.BackColor = Color.Indigo;
                            txtka1.ForeColor = Color.White; txtka2.ForeColor = Color.White; txtka3.ForeColor = Color.White; txtka4.ForeColor = Color.White; txtka5.ForeColor = Color.White; txtka6.ForeColor = Color.White; txtka7.ForeColor = Color.White; txtka8.ForeColor = Color.White;
                            lbl4.Visible = true; lbl5.Visible = true; lbl6.Visible = true; lbl7.Visible = true; lbl3.Visible = true; lbl8.Visible = true; lbl9.Visible = true; lbl10.Visible = true; lbl9.Text = "C"; lbl10.Text = "D";
                            txtaa1.Visible = true; txtaa9.Visible = true; txtkenar1.Visible = true; txtkenar2.Visible = true; txtkenar3.Visible = true; txtkenar4.Visible = true; txtkenar5.Visible = true; txtkenar6.Visible = true; txtkenar7.Visible = true;
                            txtaa1.BackColor = Color.Indigo; txtaa9.BackColor = Color.Indigo; txtkenar1.BackColor = Color.Indigo; txtkenar2.BackColor = Color.Indigo; txtkenar3.BackColor = Color.Indigo; txtkenar4.BackColor = Color.Indigo; txtkenar5.BackColor = Color.Indigo; txtkenar6.BackColor = Color.Indigo; txtkenar7.BackColor = Color.Indigo;
                            txtaa1.ForeColor = Color.White; txtaa9.ForeColor = Color.White; txtkenar1.ForeColor = Color.White; txtkenar2.ForeColor = Color.White; txtkenar3.ForeColor = Color.White; txtkenar4.ForeColor = Color.White; txtkenar5.ForeColor = Color.White; txtkenar6.ForeColor = Color.White; txtkenar7.ForeColor = Color.White;
                            txty1.Visible = true; txty8.Visible = true; txtx1.Visible = true; txtx8.Visible = true;
                            txty1.BackColor = Color.Indigo; txty8.BackColor = Color.Indigo; txtx1.BackColor = Color.Indigo; txtx8.BackColor = Color.Indigo;
                            txty1.ForeColor = Color.White; txty8.ForeColor = Color.White; txtx1.ForeColor = Color.White; txtx8.ForeColor = Color.White;
                            break;
                        }
                    case 9:
                        {
                            txtka1.Visible = true; txtka2.Visible = true; txtka3.Visible = true; txtka4.Visible = true; txtka5.Visible = true; txtka6.Visible = true; txtka7.Visible = true; txtka8.Visible = true; txtka9.Visible = true;
                            txtka1.BackColor = Color.Indigo; txtka2.BackColor = Color.Indigo; txtka3.BackColor = Color.Indigo; txtka4.BackColor = Color.Indigo; txtka5.BackColor = Color.Indigo; txtka6.BackColor = Color.Indigo; txtka7.BackColor = Color.Indigo; txtka8.BackColor = Color.Indigo; txtka9.BackColor = Color.Indigo;
                            txtka1.ForeColor = Color.White; txtka2.ForeColor = Color.White; txtka3.ForeColor = Color.White; txtka4.ForeColor = Color.White; txtka5.ForeColor = Color.White; txtka6.ForeColor = Color.White; txtka7.ForeColor = Color.White; txtka8.ForeColor = Color.White; txtka9.ForeColor = Color.White;
                            lbl4.Visible = true; lbl5.Visible = true; lbl6.Visible = true; lbl7.Visible = true; lbl3.Visible = true; lbl8.Visible = true; lbl9.Visible = true; lbl10.Visible = true; lbl11.Visible = true; lbl10.Text = "C"; lbl11.Text = "D";
                            txtaa1.Visible = true; txtaa10.Visible = true; txtkenar1.Visible = true; txtkenar2.Visible = true; txtkenar3.Visible = true; txtkenar4.Visible = true; txtkenar5.Visible = true; txtkenar6.Visible = true; txtkenar7.Visible = true; txtkenar8.Visible = true;
                            txtaa1.BackColor = Color.Indigo; txtaa10.BackColor = Color.Indigo; txtkenar1.BackColor = Color.Indigo; txtkenar2.BackColor = Color.Indigo; txtkenar3.BackColor = Color.Indigo; txtkenar4.BackColor = Color.Indigo; txtkenar5.BackColor = Color.Indigo; txtkenar6.BackColor = Color.Indigo; txtkenar7.BackColor = Color.Indigo; txtkenar8.BackColor = Color.Indigo;
                            txtaa1.ForeColor = Color.White; txtaa10.ForeColor = Color.White; txtkenar1.ForeColor = Color.White; txtkenar2.ForeColor = Color.White; txtkenar3.ForeColor = Color.White; txtkenar4.ForeColor = Color.White; txtkenar5.ForeColor = Color.White; txtkenar6.ForeColor = Color.White; txtkenar7.ForeColor = Color.White; txtkenar8.ForeColor = Color.White;
                            txty1.Visible = true; txty9.Visible = true; txtx1.Visible = true; txtx9.Visible = true;
                            txty1.BackColor = Color.Indigo; txty9.BackColor = Color.Indigo; txtx1.BackColor = Color.Indigo; txtx9.BackColor = Color.Indigo;
                            txty1.ForeColor = Color.White; txty9.ForeColor = Color.White; txtx1.ForeColor = Color.White; txtx9.ForeColor = Color.White;
                            break;
                        }
                }
            }
            catch 
            {

                MessageBox.Show("Girdiğiniz değerlerde bir hata gözüküyor.", "BİLGİLENDİRME PENCERESİ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        double aa2, aa3, aa4, aa5, aa6, aa7, aa8, aa9, aa10;
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            try
            {

                double ka1 = Convert.ToDouble(txtka1.Text);
                double ka2 = Convert.ToDouble(txtka2.Text);
                double ka3 = Convert.ToDouble(txtka3.Text);
                double ka4 = Convert.ToDouble(txtka4.Text);
                double ka5 = Convert.ToDouble(txtka5.Text);
                double ka6 = Convert.ToDouble(txtka6.Text);
                double ka7 = Convert.ToDouble(txtka7.Text);
                double ka8 = Convert.ToDouble(txtka8.Text);
                double ka9 = Convert.ToDouble(txtka9.Text);
                double aa1 = Convert.ToDouble(txtaa1.Text);
                double kenar1 = Convert.ToDouble(txtkenar1.Text);
                double kenar2 = Convert.ToDouble(txtkenar2.Text);
                double kenar3 = Convert.ToDouble(txtkenar3.Text);
                double kenar4 = Convert.ToDouble(txtkenar4.Text);
                double kenar5 = Convert.ToDouble(txtkenar5.Text);
                double kenar6 = Convert.ToDouble(txtkenar6.Text);
                double kenar7 = Convert.ToDouble(txtkenar7.Text);
                double kenar8 = Convert.ToDouble(txtkenar8.Text);
                double kenar9 = Convert.ToDouble(txtkenar9.Text);
                double dy1, dy2, dy3, dy4, dy5, dy6, dy7, dy8, dy9;
                double dx1, dx2, dx3, dx4, dx5, dx6, dx7, dx8, dx9;
                double y1 = Convert.ToDouble(txty1.Text), y2, y3, y4, y5, y6, y7, y8, y9, y10;
                double x1 = Convert.ToDouble(txtx1.Text), x2, x3, x4, x5, x6, x7, x8, x9, x10;
                if (chba.Checked == true)
                {
                    double koordinatya = Convert.ToDouble(txtya.Text);
                    double koordinatxa = Convert.ToDouble(txtxa.Text);
                    double koordinaty1 = Convert.ToDouble(txty1.Text);
                    double koordinatx1 = Convert.ToDouble(txtx1.Text);
                    aa1 = islemaciklikacisi1(koordinatxa, koordinatya, koordinatx1, koordinaty1);
                    txtaa1.Visible = true;
                    txtaa1.Text = aa1.ToString();
                }
                if (chbd.Checked == true)
                {
                    switch (kirilma)
                    {
                        case 3:
                            {
                                double koordinaty3 = Convert.ToDouble(txty3.Text);
                                double koordinatx3 = Convert.ToDouble(txtx3.Text);
                                double koordinaty4 = Convert.ToDouble(txty4.Text);
                                double koordinatx4 = Convert.ToDouble(txtx4.Text);
                                aa4 = islemaciklikacisi1(koordinatx3, koordinaty3, koordinatx4, koordinaty4);
                                txtaa4.Visible = true;
                                txtaa4.Text = aa4.ToString();
                                break;
                            }
                        case 4:
                            {
                                double koordinaty4 = Convert.ToDouble(txty4.Text);
                                double koordinatx4 = Convert.ToDouble(txtx4.Text);
                                double koordinaty5 = Convert.ToDouble(txty5.Text);
                                double koordinatx5 = Convert.ToDouble(txtx5.Text);
                                aa5 = islemaciklikacisi1(koordinatx4, koordinaty4, koordinatx5, koordinaty5);
                                txtaa5.Visible = true;
                                txtaa5.Text = aa5.ToString();
                                break;
                            }
                        case 5:
                            {
                                double koordinaty5 = Convert.ToDouble(txty5.Text);
                                double koordinatx5 = Convert.ToDouble(txtx5.Text);
                                double koordinaty6 = Convert.ToDouble(txty6.Text);
                                double koordinatx6 = Convert.ToDouble(txtx6.Text);
                                aa6 = islemaciklikacisi1(koordinatx5, koordinaty5, koordinatx6, koordinaty6);
                                txtaa6.Visible = true;
                                txtaa6.Text = aa6.ToString();
                                break;
                            }
                        case 6:
                            {
                                double koordinaty6 = Convert.ToDouble(txty6.Text);
                                double koordinatx6 = Convert.ToDouble(txtx6.Text);
                                double koordinaty7 = Convert.ToDouble(txty7.Text);
                                double koordinatx7 = Convert.ToDouble(txtx7.Text);
                                aa7 = islemaciklikacisi1(koordinatx6, koordinaty6, koordinatx7, koordinaty7);
                                txtaa7.Visible = true;
                                txtaa7.Text = aa7.ToString();
                                break;
                            }
                        case 7:
                            {
                                double koordinaty7 = Convert.ToDouble(txty7.Text);
                                double koordinatx7 = Convert.ToDouble(txtx7.Text);
                                double koordinaty8 = Convert.ToDouble(txty8.Text);
                                double koordinatx8 = Convert.ToDouble(txtx8.Text);
                                aa8 = islemaciklikacisi1(koordinatx7, koordinaty7, koordinatx8, koordinaty8);
                                txtaa8.Visible = true;
                                txtaa8.Text = aa8.ToString();
                                break;
                            }
                        case 8:
                            {
                                double koordinaty8 = Convert.ToDouble(txty8.Text);
                                double koordinatx8 = Convert.ToDouble(txtx8.Text);
                                double koordinaty9 = Convert.ToDouble(txty9.Text);
                                double koordinatx9 = Convert.ToDouble(txtx9.Text);
                                aa9 = islemaciklikacisi1(koordinatx8, koordinaty8, koordinatx9, koordinaty9);
                                txtaa9.Visible = true;
                                txtaa9.Text = aa9.ToString();
                                break;
                            }
                        case 9:
                            {
                                double koordinaty9 = Convert.ToDouble(txty9.Text);
                                double koordinatx9 = Convert.ToDouble(txtx9.Text);
                                double koordinaty10 = Convert.ToDouble(txty10.Text);
                                double koordinatx10 = Convert.ToDouble(txtx10.Text);
                                aa10 = islemaciklikacisi1(koordinatx9, koordinaty9, koordinatx10, koordinaty10);
                                txtaa10.Visible = true;
                                txtaa10.Text = aa10.ToString();
                                break;
                            }
                    }
                }
                if (acik.Checked == true || kapali.Checked == true)
                {

                    switch (kirilma)
                    {
                        case 3:
                            {
                                txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true;
                                break;
                            }
                        case 4:
                            {
                                txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtaa5.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true; txtdy4.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txtdx4.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true; txty5.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true; txtx5.Visible = true;
                                break;
                            }
                        case 5:
                            {
                                txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtaa5.Visible = true; txtaa6.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true; txtdy4.Visible = true; txtdy5.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txtdx4.Visible = true; txtdx5.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true; txty5.Visible = true; txty6.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true; txtx5.Visible = true; txtx6.Visible = true;
                                break;
                            }
                        case 6:
                            {
                                txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtaa5.Visible = true; txtaa6.Visible = true; txtaa7.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true; txtdy4.Visible = true; txtdy5.Visible = true; txtdy6.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txtdx4.Visible = true; txtdx5.Visible = true; txtdx6.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true; txty5.Visible = true; txty6.Visible = true; txty7.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true; txtx5.Visible = true; txtx6.Visible = true; txtx7.Visible = true;
                                break;
                            }
                        case 7:
                            {
                                txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtaa5.Visible = true; txtaa6.Visible = true; txtaa7.Visible = true; txtaa8.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true; txtdy4.Visible = true; txtdy5.Visible = true; txtdy6.Visible = true; txtdy7.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txtdx4.Visible = true; txtdx5.Visible = true; txtdx6.Visible = true; txtdx7.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true; txty5.Visible = true; txty6.Visible = true; txty7.Visible = true; txty8.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true; txtx5.Visible = true; txtx6.Visible = true; txtx7.Visible = true; txtx8.Visible = true;
                                break;
                            }
                        case 8:
                            {
                                txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtaa5.Visible = true; txtaa6.Visible = true; txtaa7.Visible = true; txtaa8.Visible = true; txtaa9.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true; txtdy4.Visible = true; txtdy5.Visible = true; txtdy6.Visible = true; txtdy7.Visible = true; txtdy8.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txtdx4.Visible = true; txtdx5.Visible = true; txtdx6.Visible = true; txtdx7.Visible = true; txtdx8.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true; txty5.Visible = true; txty6.Visible = true; txty7.Visible = true; txty8.Visible = true; txty9.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true; txtx5.Visible = true; txtx6.Visible = true; txtx7.Visible = true; txtx8.Visible = true; txtx9.Visible = true;
                                break;
                            }
                        case 9:
                            {
                                txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtaa5.Visible = true; txtaa6.Visible = true; txtaa7.Visible = true; txtaa8.Visible = true; txtaa9.Visible = true; txtaa10.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true; txtdy4.Visible = true; txtdy5.Visible = true; txtdy6.Visible = true; txtdy7.Visible = true; txtdy8.Visible = true; txtdy9.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txtdx4.Visible = true; txtdx5.Visible = true; txtdx6.Visible = true; txtdx7.Visible = true; txtdx8.Visible = true; txtdx9.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true; txty5.Visible = true; txty6.Visible = true; txty7.Visible = true; txty8.Visible = true; txty9.Visible = true; txty10.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true; txtx5.Visible = true; txtx6.Visible = true; txtx7.Visible = true; txtx8.Visible = true; txtx9.Visible = true; txtx10.Visible = true;
                                break;
                            }
                    }
                    aa2 = acikpoligon(aa1, ka1);
                    aa3 = acikpoligon(aa2, ka2);
                    aa4 = acikpoligon(aa3, ka3);
                    aa5 = acikpoligon(aa4, ka4);
                    aa6 = acikpoligon(aa5, ka5);
                    aa7 = acikpoligon(aa6, ka6);
                    aa8 = acikpoligon(aa7, ka7);
                    aa9 = acikpoligon(aa8, ka8);
                    aa10 = acikpoligon(aa9, ka9);
                    txtaa2.Text = aa2.ToString();
                    txtaa3.Text = aa3.ToString();
                    txtaa4.Text = aa4.ToString();
                    txtaa5.Text = aa5.ToString();
                    txtaa6.Text = aa6.ToString();
                    txtaa7.Text = aa7.ToString();
                    txtaa8.Text = aa8.ToString();
                    txtaa9.Text = aa9.ToString();
                    txtaa10.Text = aa10.ToString();
                    dy1 = dyhesap(aa2, kenar1);
                    dy2 = dyhesap(aa3, kenar2);
                    dy3 = dyhesap(aa4, kenar3);
                    dy4 = dyhesap(aa5, kenar4);
                    dy5 = dyhesap(aa6, kenar5);
                    dy6 = dyhesap(aa7, kenar6);
                    dy7 = dyhesap(aa8, kenar7);
                    dy8 = dyhesap(aa9, kenar8);
                    dy9 = dyhesap(aa10, kenar9);
                    dx1 = dxhesap(aa2, kenar1);
                    dx2 = dxhesap(aa3, kenar2);
                    dx3 = dxhesap(aa4, kenar3);
                    dx4 = dxhesap(aa5, kenar4);
                    dx5 = dxhesap(aa6, kenar5);
                    dx6 = dxhesap(aa7, kenar6);
                    dx7 = dxhesap(aa8, kenar7);
                    dx8 = dxhesap(aa9, kenar8);
                    dx9 = dxhesap(aa10, kenar9);
                    txtdy1.Text = dy1.ToString();
                    txtdy2.Text = dy2.ToString();
                    txtdy3.Text = dy3.ToString();
                    txtdy4.Text = dy4.ToString();
                    txtdy5.Text = dy5.ToString();
                    txtdy6.Text = dy6.ToString();
                    txtdy7.Text = dy7.ToString();
                    txtdy8.Text = dy8.ToString();
                    txtdy9.Text = dy9.ToString();
                    txtdx1.Text = dx1.ToString();
                    txtdx2.Text = dx2.ToString();
                    txtdx3.Text = dx3.ToString();
                    txtdx4.Text = dx4.ToString();
                    txtdx5.Text = dx5.ToString();
                    txtdx6.Text = dx6.ToString();
                    txtdx7.Text = dx7.ToString();
                    txtdx8.Text = dx8.ToString();
                    txtdx9.Text = dx9.ToString();
                    y2 = ytop(dy1, y1); x2 = xtop(dx1, x1);
                    y3 = ytop(dy2, y2); x3 = xtop(dx2, x2);
                    y4 = ytop(dy3, y3); x4 = xtop(dx3, x3);
                    y5 = ytop(dy4, y4); x5 = xtop(dx4, x4);
                    y6 = ytop(dy5, y5); x6 = xtop(dx5, x5);
                    y7 = ytop(dy6, y6); x7 = xtop(dx6, x6);
                    y8 = ytop(dy7, y7); x8 = xtop(dx7, x7);
                    y9 = ytop(dy8, y8); x9 = xtop(dx8, x8);
                    y10 = ytop(dy9, y9); x10 = xtop(dx9, x9);
                    txty2.Text = y2.ToString(); txtx2.Text = x2.ToString();
                    txty3.Text = y3.ToString(); txtx3.Text = x3.ToString();
                    txty4.Text = y4.ToString(); txtx4.Text = x4.ToString();
                    txty5.Text = y5.ToString(); txtx5.Text = x5.ToString();
                    txty6.Text = y6.ToString(); txtx6.Text = x6.ToString();
                    txty7.Text = y7.ToString(); txtx7.Text = x7.ToString();
                    txty8.Text = y8.ToString(); txtx8.Text = x8.ToString();
                    txty9.Text = y9.ToString(); txtx9.Text = x9.ToString();
                    txty10.Text = y10.ToString(); txtx10.Text = x10.ToString();

                }

                double toplam = aa1 + ka1 + ka2 + ka3 + ka4 + ka5 + ka6 + ka7 + ka8 + ka9;
                toplam = Math.Round(toplam, 4);
                txttop.Text = toplam.ToString();
                if (dayali.Checked == true)
                {

                    double sınır = kirilma * 200;
                    double semtd0 = toplam - sınır;
                    double farkx = 0, farky = 0;
                    if (semtd0 > 400)
                    {
                        semtd0 = semtd0 - 400;
                    }
                    if (semtd0 < 0)
                    {
                        semtd0 = semtd0 + 400;
                    }
                    double fb = 0;
                    txtxa.Visible = false; txtya.Visible = false;
                    switch (kirilma)
                    {
                        case 3:
                            {
                                txtaa2.Visible = true; txtaa3.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txty2.Visible = true;
                                txtx2.Visible = true;
                                aa4 = Convert.ToDouble(txtaa4.Text);
                                fb = semtd0 - aa4;
                                fb = fb * 10000;
                                fb = Math.Round(fb, 0);
                                lblfb.Text = fb.ToString() + " ᶜᶜ";
                                fb = -1 * fb;
                                mod = fb % kirilma;
                                tam = fb - mod;
                                dagit = tam / kirilma;
                                dagit = dagit / 10000;
                                y3 = Convert.ToDouble(txty3.Text);
                                y1 = Convert.ToDouble(txty1.Text);
                                x3 = Convert.ToDouble(txtx3.Text);
                                x1 = Convert.ToDouble(txtx1.Text);
                                farky = fark(y3, y1);
                                farkx = fark(x3, x1);
                                txtx4.Visible = false; txty4.Visible = false;

                                break;
                            }
                        case 4:
                            {
                                txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txty2.Visible = true; txty3.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true;
                                aa5 = Convert.ToDouble(txtaa5.Text);
                                fb = semtd0 - aa5;
                                fb = fb * 10000;
                                fb = Math.Round(fb, 0);
                                lblfb.Text = fb.ToString() + " ᶜᶜ";
                                fb = -1 * fb;
                                mod = fb % kirilma;
                                tam = fb - mod;
                                dagit = tam / kirilma;
                                dagit = dagit / 10000;
                                y4 = Convert.ToDouble(txty4.Text);
                                y1 = Convert.ToDouble(txty1.Text);
                                x4 = Convert.ToDouble(txtx4.Text);
                                x1 = Convert.ToDouble(txtx1.Text);
                                farky = fark(y4, y1);
                                farkx = fark(x4, x1);
                                txtx5.Visible = false; txty5.Visible = false;
                                break;
                            }
                        case 5:
                            {
                                txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtaa5.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true; txtdy4.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txtdx4.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true;
                                aa6 = Convert.ToDouble(txtaa6.Text);
                                fb = semtd0 - aa6;
                                fb = fb * 10000;
                                fb = Math.Round(fb, 0);
                                lblfb.Text = fb.ToString() + " ᶜᶜ";
                                fb = -1 * fb;
                                mod = fb % kirilma;
                                tam = fb - mod;
                                dagit = tam / kirilma;
                                dagit = dagit / 10000;
                                y5 = Convert.ToDouble(txty5.Text);
                                y1 = Convert.ToDouble(txty1.Text);
                                x5 = Convert.ToDouble(txtx5.Text);
                                x1 = Convert.ToDouble(txtx1.Text);
                                farky = fark(y5, y1);
                                farkx = fark(x5, x1);
                                txtx6.Visible = false; txty6.Visible = false;
                                break;
                            }
                        case 6:
                            {
                                txtaa6.Visible = true; txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtaa5.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true; txtdy4.Visible = true; txtdy5.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txtdx4.Visible = true; txtdx5.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true; txty5.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true; txtx5.Visible = true;
                                aa7 = Convert.ToDouble(txtaa7.Text);
                                fb = semtd0 - aa7;
                                fb = fb * 10000;
                                fb = Math.Round(fb, 0);
                                lblfb.Text = fb.ToString() + " ᶜᶜ";
                                fb = -1 * fb;
                                mod = fb % kirilma;
                                tam = fb - mod;
                                dagit = tam / kirilma;
                                dagit = dagit / 10000;
                                y6 = Convert.ToDouble(txty6.Text);
                                y1 = Convert.ToDouble(txty1.Text);
                                x6 = Convert.ToDouble(txtx6.Text);
                                x1 = Convert.ToDouble(txtx1.Text);
                                farky = fark(y6, y1);
                                farkx = fark(x6, x1);
                                txtx7.Visible = false; txty7.Visible = false;
                                break;
                            }
                        case 7:
                            {
                                txtaa6.Visible = true; txtaa7.Visible = true; txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtaa5.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true; txtdy4.Visible = true; txtdy5.Visible = true; txtdy6.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txtdx4.Visible = true; txtdx5.Visible = true; txtdx6.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true; txty5.Visible = true; txty6.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true; txtx5.Visible = true; txtx6.Visible = true;
                                aa8 = Convert.ToDouble(txtaa8.Text);
                                fb = semtd0 - aa8;
                                fb = fb * 10000;
                                fb = Math.Round(fb, 0);
                                lblfb.Text = fb.ToString() + " ᶜᶜ";
                                fb = -1 * fb;
                                mod = fb % kirilma;
                                tam = fb - mod;
                                dagit = tam / kirilma;
                                dagit = dagit / 10000;
                                y7 = Convert.ToDouble(txty7.Text);
                                y1 = Convert.ToDouble(txty1.Text);
                                x7 = Convert.ToDouble(txtx7.Text);
                                x1 = Convert.ToDouble(txtx1.Text);
                                farky = fark(y7, y1);
                                farkx = fark(x7, x1);
                                txtx8.Visible = false; txty8.Visible = false;
                                break;
                            }
                        case 8:
                            {
                                txtaa6.Visible = true; txtaa7.Visible = true; txtaa8.Visible = true; txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtaa5.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true; txtdy4.Visible = true; txtdy5.Visible = true; txtdy6.Visible = true; txtdy7.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txtdx4.Visible = true; txtdx5.Visible = true; txtdx6.Visible = true; txtdx7.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true; txty5.Visible = true; txty6.Visible = true; txty7.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true; txtx5.Visible = true; txtx6.Visible = true; txtx7.Visible = true;
                                aa9 = Convert.ToDouble(txtaa9.Text);
                                fb = semtd0 - aa9;
                                fb = fb * 10000;
                                fb = Math.Round(fb, 0);
                                lblfb.Text = fb.ToString() + " ᶜᶜ";
                                fb = -1 * fb;
                                mod = fb % kirilma;
                                tam = fb - mod;
                                dagit = tam / kirilma;
                                dagit = dagit / 10000;
                                y8 = Convert.ToDouble(txty8.Text);
                                y1 = Convert.ToDouble(txty1.Text);
                                x8 = Convert.ToDouble(txtx8.Text);
                                x1 = Convert.ToDouble(txtx1.Text);
                                farky = fark(y8, y1);
                                farkx = fark(x8, x1);
                                txtx9.Visible = false; txty9.Visible = false;
                                break;
                            }
                        case 9:
                            {
                                txtaa6.Visible = true; txtaa7.Visible = true; txtaa8.Visible = true; txtaa9.Visible = true; txtaa2.Visible = true; txtaa3.Visible = true; txtaa4.Visible = true; txtaa5.Visible = true; txtdy1.Visible = true; txtdy2.Visible = true; txtdy3.Visible = true; txtdy4.Visible = true; txtdy5.Visible = true; txtdy6.Visible = true; txtdy7.Visible = true; txtdy8.Visible = true;
                                txtdx1.Visible = true; txtdx2.Visible = true; txtdx3.Visible = true; txtdx4.Visible = true; txtdx5.Visible = true; txtdx6.Visible = true; txtdx7.Visible = true; txtdx8.Visible = true; txty2.Visible = true; txty3.Visible = true; txty4.Visible = true; txty5.Visible = true; txty6.Visible = true; txty7.Visible = true; txty8.Visible = true;
                                txtx2.Visible = true; txtx3.Visible = true; txtx4.Visible = true; txtx5.Visible = true; txtx6.Visible = true; txtx7.Visible = true; txtx8.Visible = true;
                                aa10 = Convert.ToDouble(txtaa10.Text);
                                fb = semtd0 - aa10;
                                fb = fb * 10000;
                                fb = Math.Round(fb, 0);
                                lblfb.Text = fb.ToString() + " ᶜᶜ";
                                fb = -1 * fb;
                                mod = fb % kirilma;
                                tam = fb - mod;
                                dagit = tam / kirilma;
                                dagit = dagit / 10000;
                                y9 = Convert.ToDouble(txty9.Text);
                                y1 = Convert.ToDouble(txty1.Text);
                                x9 = Convert.ToDouble(txtx9.Text);
                                x1 = Convert.ToDouble(txtx1.Text);
                                farky = fark(y9, y1);
                                farkx = fark(x9, x1);
                                txtx10.Visible = false; txty10.Visible = false;
                                break;
                            }
                    }
                    if (Math.Abs(fb) > fbmax)
                    {
                        MessageBox.Show("Girdiğiniz değerlerde bir hata gözüküyor. Fb > Fb (max) ", "BİLGİLENDİRME PENCERESİ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    double[] kirilmaacisi = { ka1, ka2, ka3, ka4, ka5, ka6, ka7, ka8, ka9 };
                    //int sayaci, saycj;
                    for (int i = 0; i < kirilma; i++)
                    {
                        kirilmaacisi[i] = kirilmaacisi[i] + dagit;
                        ///////////////////////////////////////////////
                        if (mod > 0)
                        {
                            kirilmaacisi[i] = kirilmaacisi[i] + 0.0001;
                            mod = mod - 1;
                        }
                        if (mod < 0)
                        {
                            kirilmaacisi[i] = kirilmaacisi[i] - 0.0001;
                            mod = mod + 1;
                        }
                    }
                    aa2 = acikpoligon(aa1, kirilmaacisi[0]);
                    aa3 = acikpoligon(aa2, kirilmaacisi[1]);
                    aa4 = acikpoligon(aa3, kirilmaacisi[2]);
                    aa5 = acikpoligon(aa4, kirilmaacisi[3]);
                    aa6 = acikpoligon(aa5, kirilmaacisi[4]);
                    aa7 = acikpoligon(aa6, kirilmaacisi[5]);
                    aa8 = acikpoligon(aa7, kirilmaacisi[6]);
                    aa9 = acikpoligon(aa8, kirilmaacisi[7]);
                    aa10 = acikpoligon(aa9, kirilmaacisi[8]);
                    dy1 = dyhesap(aa2, kenar1);
                    dy2 = dyhesap(aa3, kenar2);
                    dy3 = dyhesap(aa4, kenar3);
                    dy4 = dyhesap(aa5, kenar4);
                    dy5 = dyhesap(aa6, kenar5);
                    dy6 = dyhesap(aa7, kenar6);
                    dy7 = dyhesap(aa8, kenar7);
                    dy8 = dyhesap(aa9, kenar8);
                    dx1 = dxhesap(aa2, kenar1);
                    dx2 = dxhesap(aa3, kenar2);
                    dx3 = dxhesap(aa4, kenar3);
                    dx4 = dxhesap(aa5, kenar4);
                    dx5 = dxhesap(aa6, kenar5);
                    dx6 = dxhesap(aa7, kenar6);
                    dx7 = dxhesap(aa8, kenar7);
                    dx8 = dxhesap(aa9, kenar8);
                    txtaa2.Text = aa2.ToString();
                    txtaa3.Text = aa3.ToString();
                    txtaa4.Text = aa4.ToString();
                    txtaa5.Text = aa5.ToString();
                    txtaa6.Text = aa6.ToString();
                    txtaa7.Text = aa7.ToString();
                    txtaa8.Text = aa8.ToString();
                    txtaa9.Text = aa9.ToString();
                    txtaa10.Text = aa10.ToString();
                    txtka1.Text = kirilmaacisi[0].ToString();
                    txtka2.Text = kirilmaacisi[1].ToString();
                    txtka3.Text = kirilmaacisi[2].ToString();
                    txtka4.Text = kirilmaacisi[3].ToString();
                    txtka5.Text = kirilmaacisi[4].ToString();
                    txtka6.Text = kirilmaacisi[5].ToString();
                    txtka7.Text = kirilmaacisi[6].ToString();
                    txtka8.Text = kirilmaacisi[7].ToString();
                    txtka9.Text = kirilmaacisi[8].ToString();

                    double[] dydizi = { dy1, dy2, dy3, dy4, dy5, dy6, dy7, dy8 };
                    double[] dxdizi = { dx1, dx2, dx3, dx4, dx5, dx6, dx7, dx8 };
                    double dytop = dy1 + dy2 + dy3 + dy4 + dy5 + dy6 + dy7 + dy8;
                    double dxtop = dx1 + dx2 + dx3 + dx4 + dx5 + dx6 + dx7 + dx8;
                    double dyfark = dytop - farky;
                    double dxfark = dxtop - farkx;
                    double dxtam, dytam, dxmod, dymod, dagitdy, dagitdx, fdx, fdy;
                    fdx = dxfark;
                    fdy = dyfark;
                    dxfark = dxfark * (100);
                    dyfark = dyfark * (100);
                    lblfy.Text = (Math.Round(dyfark, 0)).ToString() + " cm";
                    lblfx.Text = (Math.Round(dxfark, 0)).ToString() + " cm";
                    dxfark = dxfark * (-1);
                    dyfark = dyfark * (-1);
                    dxfark = Math.Round(dxfark, 0);
                    dyfark = Math.Round(dyfark, 0);
                    dxmod = dxfark % (kirilma - 1);
                    dymod = dyfark % (kirilma - 1);
                    dxtam = dxfark - dxmod;
                    dytam = dyfark - dymod;
                    dagitdx = dxtam / (kirilma - 1);
                    dagitdy = dytam / (kirilma - 1);
                    for (int i = 0; i < kirilma - 1; i++)
                    {
                        dydizi[i] = dydizi[i] + dagitdy / 100;
                        dxdizi[i] = dxdizi[i] + dagitdx / 100;
                        ///////////////////////////////////// //////////
                        if (dymod > 0)
                        {
                            dydizi[i] = dydizi[i] + 0.01;
                            dymod = dymod - 1;
                        }
                        if (dymod < 0)
                        {
                            dydizi[i] = dydizi[i] - 0.01;
                            dymod = dymod + 1;
                        }
                        if (dxmod > 0)
                        {
                            dxdizi[i] = dxdizi[i] + 0.01;
                            dxmod = dxmod - 1;
                        }
                        if (dxmod < 0)
                        {
                            dxdizi[i] = dxdizi[i] - 0.01;
                            dxmod = dxmod + 1;
                        }
                    }
                    txtdx1.Text = dxdizi[0].ToString();
                    txtdx2.Text = dxdizi[1].ToString();
                    txtdx3.Text = dxdizi[2].ToString();
                    txtdx4.Text = dxdizi[3].ToString();
                    txtdx5.Text = dxdizi[4].ToString();
                    txtdx6.Text = dxdizi[5].ToString();
                    txtdx7.Text = dxdizi[6].ToString();
                    txtdx8.Text = dxdizi[7].ToString();
                    txtdy1.Text = dydizi[0].ToString();
                    txtdy2.Text = dydizi[1].ToString();
                    txtdy3.Text = dydizi[2].ToString();
                    txtdy4.Text = dydizi[3].ToString();
                    txtdy5.Text = dydizi[4].ToString();
                    txtdy6.Text = dydizi[5].ToString();
                    txtdy7.Text = dydizi[6].ToString();
                    txtdy8.Text = dydizi[7].ToString();
                    y2 = ytop(dydizi[0], y1); x2 = xtop(dxdizi[0], x1);
                    y3 = ytop(dydizi[1], y2); x3 = xtop(dxdizi[1], x2);
                    y4 = ytop(dydizi[2], y3); x4 = xtop(dxdizi[2], x3);
                    y5 = ytop(dydizi[3], y4); x5 = xtop(dxdizi[3], x4);
                    y6 = ytop(dydizi[4], y5); x6 = xtop(dxdizi[4], x5);
                    y7 = ytop(dydizi[5], y6); x7 = xtop(dxdizi[5], x6);
                    y8 = ytop(dydizi[6], y7); x8 = xtop(dxdizi[6], x7);
                    y9 = ytop(dydizi[7], y8); x9 = xtop(dxdizi[7], x8);
                    txty2.Text = y2.ToString(); txtx2.Text = x2.ToString();
                    txty3.Text = y3.ToString(); txtx3.Text = x3.ToString();
                    txty4.Text = y4.ToString(); txtx4.Text = x4.ToString();
                    txty5.Text = y5.ToString(); txtx5.Text = x5.ToString();
                    txty6.Text = y6.ToString(); txtx6.Text = x6.ToString();
                    txty7.Text = y7.ToString(); txtx7.Text = x7.ToString();
                    txty8.Text = y8.ToString(); txtx8.Text = x8.ToString();
                    txty9.Text = y9.ToString(); txtx9.Text = x9.ToString();
                    //dytop,dxtop,fdy,fdx
                    double s = Math.Sqrt((dytop * dytop) + (dxtop * dxtop));
                    s = s / 1000;
                    fdy = Math.Round(fdy, 2);
                    fdx = Math.Round(fdx, 2);
                    double fq = (1 / s) * ((dxtop * fdy) - (dytop * fdx));
                    double fl = (1 / s) * ((dytop * fdy) + (dxtop * fdx));
                    fq = fq / 10;
                    fl = fl / 10;
                    fq = Math.Round(fq, 2);
                    fl = Math.Round(fl, 2);
                    double fqmax = (0.05 + 0.15 * (Math.Sqrt(s))) * 100;
                    double flmax = (0.05 + 0.04 * (Math.Sqrt(kirilma - 1))) * 100;
                    fqmax = Math.Round(fqmax, 2);
                    flmax = Math.Round(flmax, 2);
                    fq = Math.Abs(fq);
                    fl = Math.Abs(fl);
                    txtyson.Text = y9.ToString();
                    txtxson.Text = x9.ToString();
                    txtyson.Visible = true; txtxson.Visible = true;
                    lblfq.Text = fq.ToString() + " cm";
                    lblfl.Text = fl.ToString() + " cm";
                    lblfqmax.Text = fqmax.ToString() + " cm";
                    lblflmax.Text = flmax.ToString() + " cm";
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    lblfl.Visible = true; lblflmax.Visible = true;
                    lblfq.Visible = true; lblfqmax.Visible = true;
                    if (fl > flmax && fq > fqmax)
                    {

                        MessageBox.Show("Girdiğiniz değerlerde bir hata gözüküyor. FQ veya FL değeri olması gereken aralıkta değil. ", "BİLGİLENDİRME PENCERESİ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }

                if (kapali.Checked == true)
                {
                    //////////////////////////////////////////////
                    double[] kapalikirilmaacisi = { ka1, ka2, ka3, ka4, ka5, ka6, ka7, ka8, ka9 };
                    double hatasiniri = ((kirilma + 2) * 200);
                    double hatafb = toplam - hatasiniri;
                    double kapalidagitilacak = hatafb - aa1;
                    double kapalimod, kapalidagitim;
                    kapalidagitilacak = kapalidagitilacak * 10000;
                    kapalidagitilacak = Math.Round(kapalidagitilacak, 0);
                    lblfb.Text = kapalidagitilacak.ToString() + " ᶜᶜ";
                    kapalidagitilacak = (-1) * kapalidagitilacak;
                    kapalimod = kapalidagitilacak % kirilma;
                    double kapalitam = kapalidagitilacak - kapalimod;
                    kapalidagitim = kapalidagitilacak / kirilma;
                    lblfx.Text = kapalidagitim.ToString();
                    for (int i = 0; i < kirilma; i++)
                    {
                        kapalikirilmaacisi[i] = kapalikirilmaacisi[i] + kapalidagitim / 10000;
                        if (mod > 0)
                        {
                            kapalikirilmaacisi[i] = kapalikirilmaacisi[i] + 0.0001;
                            kapalimod = kapalimod - 1;
                        }
                        if (mod < 0)
                        {
                            kapalikirilmaacisi[i] = kapalikirilmaacisi[i] - 0.0001;
                            kapalimod = kapalimod + 1;
                        }
                    }
                    double kapalidagitilacakdfy = 0, kapalidagitilacakdfx = 0;
                    lblfx.Text = kapalidagitilacakdfx.ToString() + " cm";
                    lblfy.Text = kapalidagitilacakdfy.ToString() + " cm";
                    txtka1.Text = kapalikirilmaacisi[0].ToString();
                    txtka2.Text = kapalikirilmaacisi[1].ToString();
                    txtka3.Text = kapalikirilmaacisi[2].ToString();
                    txtka4.Text = kapalikirilmaacisi[3].ToString();
                    txtka5.Text = kapalikirilmaacisi[4].ToString();
                    txtka6.Text = kapalikirilmaacisi[5].ToString();
                    txtka7.Text = kapalikirilmaacisi[6].ToString();
                    txtka8.Text = kapalikirilmaacisi[7].ToString();
                    txtka9.Text = kapalikirilmaacisi[8].ToString();
                    aa2 = acikpoligon(aa1, kapalikirilmaacisi[0]);
                    aa3 = acikpoligon(aa2, kapalikirilmaacisi[1]);
                    aa4 = acikpoligon(aa3, kapalikirilmaacisi[2]);
                    aa5 = acikpoligon(aa4, kapalikirilmaacisi[3]);
                    aa6 = acikpoligon(aa5, kapalikirilmaacisi[4]);
                    aa7 = acikpoligon(aa6, kapalikirilmaacisi[5]);
                    aa8 = acikpoligon(aa7, kapalikirilmaacisi[6]);
                    aa9 = acikpoligon(aa8, kapalikirilmaacisi[7]);
                    aa10 = acikpoligon(aa9, kapalikirilmaacisi[8]);
                    txtaa2.Text = aa2.ToString();
                    txtaa3.Text = aa3.ToString();
                    txtaa4.Text = aa4.ToString();
                    txtaa5.Text = aa5.ToString();
                    txtaa6.Text = aa6.ToString();
                    txtaa7.Text = aa7.ToString();
                    txtaa8.Text = aa8.ToString();
                    txtaa9.Text = aa9.ToString();
                    dy1 = dyhesap(aa2, kenar1);
                    dy2 = dyhesap(aa3, kenar2);
                    dy3 = dyhesap(aa4, kenar3);
                    dy4 = dyhesap(aa5, kenar4);
                    dy5 = dyhesap(aa6, kenar5);
                    dy6 = dyhesap(aa7, kenar6);
                    dy7 = dyhesap(aa8, kenar7);
                    dy8 = dyhesap(aa9, kenar8);
                    dy9 = dyhesap(aa10, kenar9);
                    dx1 = dxhesap(aa2, kenar1);
                    dx2 = dxhesap(aa3, kenar2);
                    dx3 = dxhesap(aa4, kenar3);
                    dx4 = dxhesap(aa5, kenar4);
                    dx5 = dxhesap(aa6, kenar5);
                    dx6 = dxhesap(aa7, kenar6);
                    dx7 = dxhesap(aa8, kenar7);
                    dx8 = dxhesap(aa9, kenar8);
                    dx9 = dxhesap(aa10, kenar9);
                    double[] dizideltadx = { dx1, dx2, dx3, dx4, dx5, dx6, dx7, dx8, dx9 };
                    double[] dizideltady = { dy1, dy2, dy3, dy4, dy5, dy6, dy7, dy8, dy9 };
                    double hatadeltay, hatadeltax;
                    hatadeltay = dy1 + dy2 + dy3 + dy4 + dy5 + dy6 + dy7 + dy8 + dy9;
                    hatadeltax = dx1 + dx2 + dx3 + dx4 + dx5 + dx6 + dx7 + dx8 + dx9;
                    double fs = Math.Sqrt((hatadeltax * hatadeltax) + (hatadeltay * hatadeltay));
                    double s = kenar1 + kenar2 + kenar3 + kenar4 + kenar5 + kenar6 + kenar7 + kenar8 + kenar9;
                    double fsmax = 0.01 * Math.Sqrt(s);
                    fsmax = fsmax * 100;
                    fsmax = Math.Round(fsmax, 0);
                    fs = fs * 100;
                    fs = Math.Round(fs,2);
                    fsmax = Math.Round(fsmax,2);
                    label3.Text = "[S]"; label3.Visible = true;
                    label2.Text = "FS"; label2.Visible = true;
                    label4.Text = "FS(max)"; label4.Visible = true;
                    lblflmax.Text = s.ToString() + " m"; lblflmax.Visible = true;
                    lblfq.Text = fs.ToString() + " cm"; lblfq.Visible = true;
                    lblfqmax.Text = fsmax.ToString() + " cm"; lblfqmax.Visible = true;
                    if (Math.Abs(fs) > fsmax)
                    {
                        MessageBox.Show("Girdiğiniz değerlerde bir hata gözüküyor. Fs > Fs (max) ", "BİLGİLENDİRME PENCERESİ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    hatadeltax = hatadeltax * 100;
                    hatadeltay = hatadeltay * 100;
                    hatadeltax = Math.Round(hatadeltax, 0);
                    hatadeltay = Math.Round(hatadeltay, 0);
                    lblfx.Text = hatadeltax.ToString() + " cm";
                    lblfy.Text = hatadeltay.ToString() + " cm";
                    hatadeltax = (-1) * hatadeltax;
                    hatadeltay = (-1) * hatadeltay;
                    double moddeltax, moddeltay, tamdeltax, tamdeltay;
                    moddeltax = hatadeltax % kirilma;
                    moddeltay = hatadeltay % kirilma;
                    tamdeltax = hatadeltax - moddeltax;
                    tamdeltay = hatadeltay - moddeltay;
                    for (int i = 0; i < kirilma; i++)
                    {
                        dizideltadx[i] = dizideltadx[i] + tamdeltax / 100;
                        dizideltady[i] = dizideltady[i] + tamdeltay / 100;
                        if (moddeltax > 0)
                        {
                            dizideltadx[i] = dizideltadx[i] + 0.01;
                            moddeltax = moddeltax - 1;
                        }
                        if (moddeltax < 0)
                        {
                            dizideltadx[i] = dizideltadx[i] - 0.01;
                            moddeltax = moddeltax + 1;
                        }
                        if (moddeltay > 0)
                        {
                            dizideltady[i] = dizideltady[i] + 0.01;
                            moddeltay = moddeltay - 1;
                        }
                        if (moddeltay < 0)
                        {
                            dizideltady[i] = dizideltady[i] - 0.01;
                            moddeltay = moddeltay + 1;
                        }

                    }
                    y2 = ytop(dizideltady[0], y1); x2 = xtop(dizideltadx[0], x1);
                    y3 = ytop(dizideltady[1], y2); x3 = xtop(dizideltadx[1], x2);
                    y4 = ytop(dizideltady[2], y3); x4 = xtop(dizideltadx[2], x3);
                    y5 = ytop(dizideltady[3], y4); x5 = xtop(dizideltadx[3], x4);
                    y6 = ytop(dizideltady[4], y5); x6 = xtop(dizideltadx[4], x5);
                    y7 = ytop(dizideltady[5], y6); x7 = xtop(dizideltadx[5], x6);
                    y8 = ytop(dizideltady[6], y7); x8 = xtop(dizideltadx[6], x7);
                    y9 = ytop(dizideltady[7], y8); x9 = xtop(dizideltadx[7], x8);
                    y10 = ytop(dizideltady[8], y9); x10 = xtop(dizideltadx[8], x9);
                    txty2.Text = y2.ToString(); txtx2.Text = x2.ToString();
                    txty3.Text = y3.ToString(); txtx3.Text = x3.ToString();
                    txty4.Text = y4.ToString(); txtx4.Text = x4.ToString();
                    txty5.Text = y5.ToString(); txtx5.Text = x5.ToString();
                    txty6.Text = y6.ToString(); txtx6.Text = x6.ToString();
                    txty7.Text = y7.ToString(); txtx7.Text = x7.ToString();
                    txty8.Text = y8.ToString(); txtx8.Text = x8.ToString();
                    txty9.Text = y9.ToString(); txtx9.Text = x9.ToString();
                    txty10.Text = y10.ToString(); txtx10.Text = x10.ToString();
                    txtdy1.Text = dizideltady[0].ToString();
                    txtdy2.Text = dizideltady[1].ToString();
                    txtdy3.Text = dizideltady[2].ToString();
                    txtdy4.Text = dizideltady[3].ToString();
                    txtdy5.Text = dizideltady[4].ToString();
                    txtdy6.Text = dizideltady[5].ToString();
                    txtdy7.Text = dizideltady[6].ToString();
                    txtdy8.Text = dizideltady[7].ToString();
                    txtdy9.Text = dizideltady[8].ToString();
                    txtdx1.Text = dizideltadx[0].ToString();
                    txtdx2.Text = dizideltadx[1].ToString();
                    txtdx3.Text = dizideltadx[2].ToString();
                    txtdx4.Text = dizideltadx[3].ToString();
                    txtdx5.Text = dizideltadx[4].ToString();
                    txtdx6.Text = dizideltadx[5].ToString();
                    txtdx7.Text = dizideltadx[6].ToString();
                    txtdx8.Text = dizideltadx[7].ToString();
                    txtdx9.Text = dizideltadx[8].ToString();
                    txtxson.Text = y10.ToString();txtyson.Text = y10.ToString();
                    txtxson.Visible = true;txtyson.Visible = true;
                }
            }
            catch 
            {

                MessageBox.Show("Girdiğiniz değerlerde bir hata gözüküyor.", "BİLGİLENDİRME PENCERESİ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void chba_CheckedChanged(object sender, EventArgs e)
        {

            if (chba.Checked == true) { txtxa.Visible = true; txtya.Visible = true; txtaa1.Visible = false; }
            else { txtxa.Visible = false; txtya.Visible = false; txtaa1.Visible = true; }


        }

        private void chbd_CheckedChanged(object sender, EventArgs e)
        {
            switch (kirilma)
            {
                case 3:
                    {
                        if (chbd.Checked == true)
                        {
                            txtx4.Visible = true; txty4.Visible = true; txtaa4.Visible = false;
                            txtx4.BackColor = Color.Black; txty4.BackColor = Color.Black; txtx4.ForeColor = Color.White; txty4.ForeColor = Color.White;
                        }
                        else { txtx4.Visible = false; txty4.Visible = false; txtaa4.Visible = true; }
                        break;
                    }
                case 4:
                    {
                        if (chbd.Checked == true)
                        {
                            txtx5.Visible = true; txty5.Visible = true; txtaa5.Visible = false;
                            txtx5.BackColor = Color.Black; txty5.BackColor = Color.Black; txtx5.ForeColor = Color.White; txty5.ForeColor = Color.White;
                        }
                        else { txtx5.Visible = false; txty5.Visible = false; txtaa5.Visible = true; }
                        break;
                    }
                case 5:
                    {
                        if (chbd.Checked == true)
                        {
                            txtx6.Visible = true; txty6.Visible = true; txtaa6.Visible = false;
                            txtx6.BackColor = Color.Black; txty6.BackColor = Color.Black; txtx6.ForeColor = Color.White; txty6.ForeColor = Color.White;
                        }
                        else { txtx6.Visible = false; txty6.Visible = false; txtaa6.Visible = true; }
                        break;
                    }
                case 6:
                    {
                        if (chbd.Checked == true)
                        {
                            txtx7.Visible = true; txty7.Visible = true; txtaa7.Visible = false;
                            txtx7.BackColor = Color.Black; txty7.BackColor = Color.Black; txtx7.ForeColor = Color.White; txty7.ForeColor = Color.White;
                        }
                        else { txtx7.Visible = false; txty7.Visible = false; txtaa7.Visible = true; }
                        break;
                    }
                case 7:
                    {
                        if (chbd.Checked == true)
                        {
                            txtx8.Visible = true; txty8.Visible = true; txtaa8.Visible = false;
                            txtx8.BackColor = Color.Black; txty8.BackColor = Color.Black; txtx8.ForeColor = Color.White; txty8.ForeColor = Color.White;
                        }
                        else { txtx8.Visible = false; txty8.Visible = false; txtaa8.Visible = true; }
                        break;
                    }
                case 8:
                    {
                        if (chbd.Checked == true)
                        {
                            txtx9.Visible = true; txty9.Visible = true; txtaa9.Visible = false;
                            txtx9.BackColor = Color.Black; txty9.BackColor = Color.Black; txtx9.ForeColor = Color.White; txty9.ForeColor = Color.White;
                        }
                        else { txtx9.Visible = false; txty9.Visible = false; txtaa9.Visible = true; }
                        break;
                    }
                case 9:
                    {
                        if (chbd.Checked == true)
                        {
                            txtx10.Visible = true; txty10.Visible = true; txtaa10.Visible = false;
                            txtx10.BackColor = Color.Black; txty10.BackColor = Color.Black; txtx10.ForeColor = Color.White; txty10.ForeColor = Color.White;
                        }
                        else { txtx10.Visible = false; txty10.Visible = false; txtaa10.Visible = true; }
                        break;
                    }

            }

        }

        double islemaciklikacisi1(double xa, double ya, double x1, double y1)
        {
            double aci = 0, dy = 0, dx = 0;
            dy = y1 - ya;
            dx = x1 - xa;
            aci = Math.Atan(dy / dx);
            aci = aci * 200 / pi;
            if (dy > 0 && dx < 0)
            { aci = aci + 200; }
            if (dy < 0 && dx < 0)
            { aci = aci + 200; }
            if (dy < 0 && dx > 0)
            { aci = aci + 400; }
            aci = Math.Round(aci, 4);
            return (aci);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"help.docx");
            }
            catch
            {
                MessageBox.Show("Dosya dizinde bulunamadı.");
            }
            
        }

        private void yENİDENBAŞLATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        double acikpoligon(double aa, double ka)
        {
            double aas = 0;
            aas = aa + ka;
            if (aas <= 200 && aas > 0)
            { aas = aas + 200; }
            if (aas > 200 && aas <= 600)
            { aas = aas - 200; }
            if (aas > 600)
            { aas = aas - 600; }
            aas = Math.Round(aas,4);
            return (aas);
        }
        double dyhesap(double aa, double kenar)
        {
            double dy, sin;
            aa = aa * pi / 200;
            sin = Math.Sin(aa);
            dy = sin * kenar;
            dy = Math.Round(dy, 2);
            return (dy);
        }
        double dxhesap(double aa, double kenar)
        {
            double dx, cos;
            aa = aa * pi / 200;
            cos = Math.Cos(aa);
            dx = cos * kenar;
            dx = Math.Round(dx, 2);
            return (dx);
        }
        double xtop(double dy, double d)
        {
            double ynew;
            ynew = dy + d;
            return (ynew);
        }
        double ytop(double dx, double d)
        {
            double ynew;
            ynew = dx + d;
            return (ynew);
        }

        private void btnonayla_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dayali.Checked == false && acik.Checked == false && kapali.Checked == false)
                { MessageBox.Show("Yapacağınız işlemi seçip tekrar deneyin ."); }
                if (dayali.Checked == true || acik.Checked == true || kapali.Checked == true)
                { panel2.Visible = false; }

                if (acik.Checked == true)
                {
                    chbd.Enabled = false;
                    switch (kirilma)
                    {
                        case 3:
                            {
                                txty3.Visible = false;
                                txty3.BackColor = Color.White;
                                txty3.ForeColor = Color.Black;
                                txtx3.Visible = false;
                                txtx3.BackColor = Color.White;
                                txtx3.ForeColor = Color.Black;
                                txtaa4.Visible = false;
                                txtaa4.BackColor = Color.White;
                                txtaa4.ForeColor = Color.Black;
                                txtkenar3.Visible = true;
                                txtkenar3.BackColor = Color.Indigo;
                                txtkenar3.ForeColor = Color.White;
                                break;
                            }
                        case 4: { txty4.Visible = false; txty4.BackColor = Color.White; txty4.ForeColor = Color.Black; txtx4.Visible = false; txtx4.BackColor = Color.White; txtx4.ForeColor = Color.Black; txtaa5.Visible = false; txtaa5.BackColor = Color.White; txtaa5.ForeColor = Color.Black; txtkenar4.Visible = true; txtkenar4.BackColor = Color.Indigo; txtkenar4.ForeColor = Color.White; break; }
                        case 5: { txty5.Visible = false; txty5.BackColor = Color.White; txty5.ForeColor = Color.Black; txtx5.Visible = false; txtx5.BackColor = Color.White; txtx5.ForeColor = Color.Black; txtaa6.Visible = false; txtaa6.BackColor = Color.White; txtaa6.ForeColor = Color.Black; txtkenar5.Visible = true; txtkenar5.BackColor = Color.Indigo; txtkenar5.ForeColor = Color.White; break; }
                        case 6: { txty6.Visible = false; txty6.BackColor = Color.White; txty6.ForeColor = Color.Black; txtx6.Visible = false; txtx6.BackColor = Color.White; txtx6.ForeColor = Color.Black; txtaa7.Visible = false; txtaa7.BackColor = Color.White; txtaa7.ForeColor = Color.Black; txtkenar6.Visible = true; txtkenar6.BackColor = Color.Indigo; txtkenar6.ForeColor = Color.White; break; }
                        case 7: { txty7.Visible = false; txty7.BackColor = Color.White; txty7.ForeColor = Color.Black; txtx7.Visible = false; txtx7.BackColor = Color.White; txtx7.ForeColor = Color.Black; txtaa8.Visible = false; txtaa8.BackColor = Color.White; txtaa8.ForeColor = Color.Black; txtkenar7.Visible = true; txtkenar7.BackColor = Color.Indigo; txtkenar7.ForeColor = Color.White; break; }
                        case 8: { txty8.Visible = false; txty8.BackColor = Color.White; txty8.ForeColor = Color.Black; txtx8.Visible = false; txtx8.BackColor = Color.White; txtx8.ForeColor = Color.Black; txtaa9.Visible = false; txtaa9.BackColor = Color.White; txtaa9.ForeColor = Color.Black; txtkenar8.Visible = true; txtkenar8.BackColor = Color.Indigo; txtkenar8.ForeColor = Color.White; break; }
                        case 9: { txty9.Visible = false; txty9.BackColor = Color.White; txty9.ForeColor = Color.Black; txtx9.Visible = false; txtx9.BackColor = Color.White; txtx9.ForeColor = Color.Black; txtaa10.Visible = false; txtaa10.BackColor = Color.White; txtaa10.ForeColor = Color.Black; txtkenar9.Visible = true; txtkenar9.BackColor = Color.Indigo; txtkenar9.ForeColor = Color.White; break; }
                    }
                }
                if (kapali.Checked == true)
                {
                    switch (kirilma)
                    {
                        case 3: { txty3.Visible = false; txty3.BackColor = Color.White; txty3.ForeColor = Color.Black; txtx3.Visible = false; txtx3.BackColor = Color.White; txtx3.ForeColor = Color.Black; txtaa4.Visible = true; txtaa4.Enabled = false; txtaa4.BackColor = Color.Indigo; txtaa4.ForeColor = Color.White; txtkenar3.Visible = true; txtkenar3.BackColor = Color.Indigo; txtkenar3.ForeColor = Color.White; txty4.Visible = true; txty4.ForeColor = Color.White; txty4.BackColor = Color.Indigo; txtx4.Visible = true; txtx4.ForeColor = Color.White; txtx4.BackColor = Color.Indigo; txty4.Enabled = false; txtx4.Enabled = false; break; }
                        case 4: { txty4.Visible = false; txty4.BackColor = Color.White; txty4.ForeColor = Color.Black; txtx4.Visible = false; txtx4.BackColor = Color.White; txtx4.ForeColor = Color.Black; txtkenar4.Visible = true; txtkenar4.BackColor = Color.Indigo; txtkenar4.ForeColor = Color.White; txty5.Visible = true; txty5.ForeColor = Color.White; txty5.BackColor = Color.Indigo; txtx5.Visible = true; txtx5.ForeColor = Color.White; txtx5.BackColor = Color.Indigo; txty5.Enabled = false; txtx5.Enabled = false; txtaa5.Enabled = false; break; }
                        case 5: { txty5.Visible = false; txty5.BackColor = Color.White; txty5.ForeColor = Color.Black; txtx5.Visible = false; txtx5.BackColor = Color.White; txtx5.ForeColor = Color.Black; txtkenar5.Visible = true; txtkenar5.BackColor = Color.Indigo; txtkenar5.ForeColor = Color.White; txty6.Visible = true; txty6.ForeColor = Color.White; txty6.BackColor = Color.Indigo; txtx6.Visible = true; txtx6.ForeColor = Color.White; txtx6.BackColor = Color.Indigo; txty6.Enabled = false; txtx6.Enabled = false; txtaa6.Enabled = false; break; }
                        case 6: { txty6.Visible = false; txty6.BackColor = Color.White; txty6.ForeColor = Color.Black; txtx6.Visible = false; txtx6.BackColor = Color.White; txtx6.ForeColor = Color.Black; txtkenar6.Visible = true; txtkenar6.BackColor = Color.Indigo; txtkenar6.ForeColor = Color.White; txty7.Visible = true; txty7.ForeColor = Color.White; txty7.BackColor = Color.Indigo; txtx7.Visible = true; txtx7.ForeColor = Color.White; txtx7.BackColor = Color.Indigo; txty7.Enabled = false; txtx7.Enabled = false; txtaa7.Enabled = false; break; }
                        case 7: { txty7.Visible = false; txty7.BackColor = Color.White; txty7.ForeColor = Color.Black; txtx7.Visible = false; txtx7.BackColor = Color.White; txtx7.ForeColor = Color.Black; txtkenar7.Visible = true; txtkenar7.BackColor = Color.Indigo; txtkenar7.ForeColor = Color.White; txty8.Visible = true; txty8.ForeColor = Color.White; txty8.BackColor = Color.Indigo; txtx8.Visible = true; txtx8.ForeColor = Color.White; txtx8.BackColor = Color.Indigo; txty8.Enabled = false; txtx8.Enabled = false; txtaa8.Enabled = false; break; }
                        case 8: { txty8.Visible = false; txty8.BackColor = Color.White; txty8.ForeColor = Color.Black; txtx8.Visible = false; txtx8.BackColor = Color.White; txtx8.ForeColor = Color.Black; txtkenar8.Visible = true; txtkenar8.BackColor = Color.Indigo; txtkenar8.ForeColor = Color.White; txty9.Visible = true; txty9.ForeColor = Color.White; txty9.BackColor = Color.Indigo; txtx9.Visible = true; txtx9.ForeColor = Color.White; txtx9.BackColor = Color.Indigo; txty9.Enabled = false; txtx9.Enabled = false; txtaa9.Enabled = false; break; }
                        case 9: { txty9.Visible = false; txty9.BackColor = Color.White; txty9.ForeColor = Color.Black; txtx9.Visible = false; txtx9.BackColor = Color.White; txtx9.ForeColor = Color.Black; txtkenar9.Visible = true; txtkenar9.BackColor = Color.Indigo; txtkenar9.ForeColor = Color.White; txty10.Visible = true; txty10.ForeColor = Color.White; txty10.BackColor = Color.Indigo; txtx10.Visible = true; txtx10.ForeColor = Color.White; txtx10.BackColor = Color.Indigo; txty10.Enabled = false; txtx10.Enabled = false; txtaa10.Enabled = false; break; }
                    }
                }
            }
            catch
            {

                MessageBox.Show("Girdiğiniz değerlerde bir hata gözüküyor.", "BİLGİLENDİRME PENCERESİ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void kapali_CheckedChanged_1(object sender, EventArgs e)
        {
            chbd.Enabled = false;
            if (kapali.Checked == true)
            { acik.Enabled = false; dayali.Enabled = false; panel3.Visible = false; }
            if (kapali.Checked == false)
            { acik.Enabled = true; dayali.Enabled = true; panel3.Visible = true; }
        }

        private void dayali_CheckedChanged(object sender, EventArgs e)
        {
            if (dayali.Checked == true)
            { acik.Enabled = false; kapali.Enabled = false;panel3.Visible = false; }
            if (dayali.Checked == false)
            { acik.Enabled = true; kapali.Enabled = true; panel3.Visible = true; }
        }

        private void acik_CheckedChanged(object sender, EventArgs e)
        {
            chbd.Enabled = false;
            if (acik.Checked == true)
            { dayali.Enabled = false; kapali.Enabled = false;  }
            if (acik.Checked == false)
            { dayali.Enabled = true; kapali.Enabled = true; }
        }
        double fark(double deger1,double deger2)
        {
            double fark = deger1 - deger2;
            fark = Math.Round(fark,2);
            return (fark);
        }
    }
}

