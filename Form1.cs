using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int soruNo = 0;
        int DogruSayısı = 0;
        int YanlısSayısı = 0;
        // Buttonlarım 
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            soruNo++;
            lblSoruNo.Text = soruNo.ToString();
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
       
            if (soruNo == 1)
            {
                richTextBox1.Text = "Türkiyenin Başkenti neresidir ?";
                BtnA.Text = "Ankara";
                BtnB.Text = "İstanbul";
                BtnC.Text = "Bursa";
                BtnD.Text = "İzmir";
                lblDogruCevap.Text = "Ankara";

            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "61 nerenin Plakası ?";
                BtnA.Text = "Trabzon";
                BtnB.Text = "İstanbul";
                BtnC.Text = "Bursa";
                BtnD.Text = "İzmir";
                lblDogruCevap.Text = "Trabzon";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "07 Nerenin Plakası?";
                BtnA.Text = "Ankara";
                BtnB.Text = "Antalya";
                BtnC.Text = "Bursa";
                BtnD.Text = "İzmir";
                lblDogruCevap.Text = "Antalya";
            }
          
        }
        private void BtnA_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            lblverilenCevap.Text = BtnA.Text;
            if (lblDogruCevap.Text == lblverilenCevap.Text)
            {
                DogruSayısı++;
                lblDogruSayısı.Text = DogruSayısı.ToString();
            }
            else
            {
                YanlısSayısı++;
                lblYAnlısSayısı.Text = YanlısSayısı.ToString();
            }
        }
        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            lblverilenCevap.Text = BtnB.Text;
            if (lblDogruCevap.Text == lblverilenCevap.Text)
            {
                DogruSayısı++;
                lblDogruSayısı.Text = DogruSayısı.ToString();
            }
            else
            {
                YanlısSayısı++;
                lblYAnlısSayısı.Text = YanlısSayısı.ToString();
            }
        }
        private void BtnC_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            lblverilenCevap.Text = BtnC.Text;
            if (lblDogruCevap.Text == lblverilenCevap.Text)
            {
                DogruSayısı++;
                lblDogruSayısı.Text = DogruSayısı.ToString();
            }
            else
            {
                YanlısSayısı++;
                lblYAnlısSayısı.Text = YanlısSayısı.ToString();
            }

        }
        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            lblverilenCevap.Text = BtnD.Text;
            if (lblDogruCevap.Text == lblverilenCevap.Text)
            {
                DogruSayısı++;
                lblDogruSayısı.Text = DogruSayısı.ToString();
            }
            else
            {
                YanlısSayısı++;
                lblYAnlısSayısı.Text = YanlısSayısı.ToString();
            }

        }
    }
}
