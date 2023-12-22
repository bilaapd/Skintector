using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO20des
{
    public partial class main2 : Form
    {
        public main2()
        {
            InitializeComponent();
        }

        int goodDry = 0;
        int goodOily = 0;
        int goodSensitive = 0;
        int goodAcne = 0;
        int goodCombi = 0;
        int badDry = 0;
        int badOily = 0;
        int badSensitive = 0;
        int badAcne = 0;
        int badCombi = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void good_dry()
        {
            goodDry = goodDry + 1;
        }

        void good_oily()
        {
            goodOily = goodOily + 1;
        }

        void good_sensitive()
        {
            goodSensitive = goodSensitive + 1;
        }

        void good_acne()
        {
            goodAcne = goodAcne + 1;
        }

        void good_combi()
        {
            goodCombi = goodCombi + 1;
        }

        void bad_dry()
        {
            badDry = badDry + 1;
        }

        void bad_oily()
        {
            badOily = badOily + 1;
        }

        void bad_sensitive()
        {
            badSensitive = badSensitive + 1;
        }

        void bad_acne()
        {
            badAcne = badAcne + 1;
        }

        void bad_combi()
        {
            badCombi = badCombi + 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Essencial_Acid.Checked)
            {
                good_dry();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if(AHA.Checked)
            {
                good_combi();
                bad_sensitive();
            }
        }

        private void Done_test_Click(object sender, EventArgs e)
        {
            if(Skincarename.Text == "")
            {
                MessageBox.Show("Please input the skincare's name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resultboxgood.Text = "Skin types that are suitable for skincare " + Skincarename.Text + " are =";
                resultboxbad.Text = "Skin types that aren't suitable for skincare " + Skincarename.Text + " are =";
                
                string[] skintype = {"Dry", "Oily", "Sensitive", "Acne", "Combination" };
                
                int maxgood; int maxbad;

                int[] good = new int[5];
                good[0] = goodDry;
                good[1] = goodOily;
                good[2] = goodSensitive;
                good[3] = goodAcne;
                good[4] = goodCombi;
                maxgood = good.Max();

                if(maxgood == 0)
                {
                    //gdrybox.Text = "-"; goilybox.Text = "-"; gsensibox.Text = "-"; gacnebox.Text = "-"; gcombibox.Text = "-";
                }
                else
                {
                    if (maxgood == good[0]) { gdrybox.Text = skintype[0]; } else { gdrybox.Text = "-"; }
                    if (maxgood == good[1]) { goilybox.Text = skintype[1]; } else {  goilybox.Text = "-"; }
                    if (maxgood == good[2]) { gsensibox.Text = skintype[2]; } else { gsensibox.Text = "-"; }
                    if (maxgood == good[3]) { gacnebox.Text = skintype[3]; } else { gacnebox.Text = "-"; }
                    if (maxgood == good[4]) { gcombibox.Text = skintype[4]; } else { gcombibox.Text = "-"; }
                }
                
                int[] bad = new int[5];
                bad[0] = badDry;
                bad[1] = badOily;
                bad[2] = badSensitive;
                bad[3] = badAcne;
                bad[4] = badCombi;
                maxbad = bad.Max();

                if (maxbad == 0)
                {
                    //bdrybox.Text = "-"; boilybox.Text = "-"; bsensibox.Text = "-"; bacnebox.Text = "-"; bcombibox.Text = "-";
                }
                else
                {
                    if (maxbad == bad[0]) { bdrybox.Text = skintype[0]; } else { bdrybox.Text = "-"; }
                    if (maxbad == bad[1]) { boilybox.Text = skintype[1]; } else { boilybox.Text = "-"; }
                    if (maxbad == bad[2]) { bsensibox.Text = skintype[2]; } else { bsensibox.Text = "-"; }
                    if (maxbad == bad[3]) { bacnebox.Text = skintype[3]; } else { bacnebox.Text = "-"; }
                    if (maxbad == bad[4]) { bcombibox.Text = skintype[4]; } else { bcombibox.Text = "-"; }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Glycerin_CheckedChanged(object sender, EventArgs e)
        {
            if(Glycerin.Checked)
            {
                good_dry();
            }
        }

        private void Hyaluronic_Acid_CheckedChanged(object sender, EventArgs e)
        {
            if (Hyaluronic_Acid.Checked)
            {
                good_dry();
                good_combi();
            }
        }

        private void Kaolin_Clay_CheckedChanged(object sender, EventArgs e)
        {
            if (Kaolin_Clay.Checked)
            {
                good_oily();
            }
        }

        private void BHA_CheckedChanged(object sender, EventArgs e)
        {
            if(BHA.Checked)
            {
                good_combi();
                good_oily();
            }
        }

        private void ALS_CheckedChanged(object sender, EventArgs e)
        {
            if (ALS.Checked)
            {
                bad_dry();
                bad_acne();
            }
        }

        private void SLS_CheckedChanged(object sender, EventArgs e)
        {
            if(SLS.Checked)
            {
                bad_acne();
            }
        }

        private void Vit_C_CheckedChanged(object sender, EventArgs e)
        {
            if (Vit_C.Checked)
            {
                good_acne();
            }
        }

        private void Emollient_CheckedChanged(object sender, EventArgs e)
        {
            if(Emollient.Checked)
            {
                good_dry() ;
            }
        }

        private void Salysilic_Acid_CheckedChanged(object sender, EventArgs e)
        {
            if(Salysilic_Acid.Checked)
            {
                good_acne() ;
            }
        }

        private void Mandelic_Acid_CheckedChanged(object sender, EventArgs e)
        {
            if(Mandelic_Acid.Checked)
            {
                good_acne();
            }
        }

        private void Tea_Tree_CheckedChanged(object sender, EventArgs e)
        {
            if (Tea_Tree.Checked)
            {
                good_acne();
            }
        }

        private void Niacinamide_CheckedChanged(object sender, EventArgs e)
        {
            if (Niacinamide.Checked)
            {
                good_oily() ;
            }
        }

        private void Ferulic_Acid_CheckedChanged(object sender, EventArgs e)
        {
            if (Ferulic_Acid.Checked)
            {
                good_oily();
            }
        }

        private void Chamomile_CheckedChanged(object sender, EventArgs e)
        {
            if (Chamomile.Checked)
            {
                good_sensitive() ;
            }
        }

        private void Retinoid_CheckedChanged(object sender, EventArgs e)
        {
            if(Retinoid.Checked)
            {
                bad_dry() ;
            }
        }

        private void Glycolic_Acid_CheckedChanged(object sender, EventArgs e)
        {
            if (Glycolic_Acid.Checked)
            {
                good_dry() ;
            }
        }

        private void Benzoyl_CheckedChanged(object sender, EventArgs e)
        {
            if (Benzoyl.Checked)
            {
                bad_dry();
            }
        }

        private void Alcohol_Denat_CheckedChanged(object sender, EventArgs e)
        {
            if (Alcohol_Denat.Checked)
            {
                bad_oily() ;
            }
        }

        private void Isopropyl_CheckedChanged(object sender, EventArgs e)
        {
            if (Isopropyl.Checked)
            {
                bad_oily() ;
            }
        }

        private void Butyl_CheckedChanged(object sender, EventArgs e)
        {
            if (Butyl.Checked)
            {
                bad_oily() ;
            }
        }

        private void Sulfate_CheckedChanged(object sender, EventArgs e)
        {
            if (Sulfate.Checked)
            {
                bad_sensitive() ;
            }
        }

        private void Paraben_CheckedChanged(object sender, EventArgs e)
        {
            if (Paraben.Checked)
            {
                bad_sensitive() ;
            }
        }

        private void Allantoin_CheckedChanged(object sender, EventArgs e)
        {
            if (Allantoin.Checked)
            {
                good_sensitive() ;
            }
        }

        private void Ceramide_CheckedChanged(object sender, EventArgs e)
        {
            if (Ceramide.Checked)
            {
                good_dry() ;
            }
        }

        private void Lactic_Acid_CheckedChanged(object sender, EventArgs e)
        {
            if (Lactic_Acid.Checked)
            {
                good_dry() ;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            main2 cForm = new main2();
            cForm.Show();
            this.Hide();
        }
    }
}
