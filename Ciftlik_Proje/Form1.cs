using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciftlik_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ımageList1.Images[0];//I put the images of animals on the imageslist to the pictureboxes.
            pictureBox2.Image = ımageList1.Images[1];
            pictureBox3.Image = ımageList1.Images[2];
            pictureBox4.Image = ımageList1.Images[3];   
        }
        Tavuk TavukUrunu = new Tavuk();//I created a TavukUrunu object.
        private void timer1_Tick(object sender, EventArgs e)
        {
            TavukUrunu.UrunVerme();//I created a timer and made its interval to what it has to be, then called UrunVerme function of Tavuk class in this timer.
            label4.Text = Convert.ToString(TavukUrunu.TavukYumurtası+" ADET");   
        }

        Inek InekUrunu = new Inek();//I created an InekUrunu object.
        private void timer2_Tick(object sender, EventArgs e)
        {
            InekUrunu.UrunVerme();// I created a timer and made its interval to what it has to be, then called UrunVerme function of Inek class in this timer.
             label5.Text = Convert.ToString(InekUrunu.InekSutu+" KG");
        }

        Ordek OrdekUrunu = new Ordek();//I created an OrdekUrunu object.
        private void timer3_Tick(object sender, EventArgs e)
        {
            OrdekUrunu.UrunVerme();// I created a timer and made its interval to what it has to be, then called UrunVerme function of Ordek class in this timer.
            label8.Text = Convert.ToString(OrdekUrunu.OrdekYumurtası + " ADET");
        }

        Keci KeciUrunu = new Keci();//I created a KeciUrunu object.
        private void timer4_Tick(object sender, EventArgs e)
        {
            KeciUrunu.UrunVerme();// I created a timer and made its interval to what it has to be, then called UrunVerme function of Keci class in this timer.
            label9.Text = Convert.ToString(KeciUrunu.KeciSutu + " KG");
        }

        public int saniye = 0;//I defined my counters here.
        public int progressbarcounter1 = 0;
        public int progressbarcounter2 = 0;
        public int progressbarcounter3 = 0;
        public int progressbarcounter4 = 0;
        private void timer5_Tick(object sender, EventArgs e)
        {       
            saniye++;
            progressbarcounter1++;//I created my counters here.
            progressbarcounter2++;
            progressbarcounter3++;
            progressbarcounter4++;
            label16.Text = Convert.ToString(saniye);//I wanted the time to be printed in label16's text. 

            if (progressBar1.Value != 0)//I made the progressbar to be decreased here. If it decrease to the end, HayvanSesleri method of Tavuk class is going to be called and Tavuk is going to seem dead.
                progressBar1.Value = 100 - progressbarcounter1 * 2;
            else if(TavukUrunu.Tekrar==false)
            {
                TavukUrunu.Tekrar = true;
                TavukUrunu.HayvanSesleri();
                progressBar1.Enabled = false;
                label20.Text = "ÖLÜ";
                timer1.Stop();
            }

            if (progressBar2.Value > 1)//I made the progressbar to be decreased here. If it decrease to the end, HayvanSesleri method of Ordek class is going to be called and Ordek is going to seem dead.
                progressBar2.Value = 100 - progressbarcounter2 * 3;
            else if(OrdekUrunu.Tekrar == false)
            {
                OrdekUrunu.Tekrar = true;
                OrdekUrunu.HayvanSesleri();
                progressBar2.Value=0;
                progressBar2.Enabled = false;
                label22.Text = "ÖLÜ";
                timer3.Stop();
            }
            if (progressBar3.Value > 4)//I made the progressbar to be decreased here. If it decrease to the end, HayvanSesleri method of Inek class is going to be called and Inek is going to seem dead.
                progressBar3.Value = 100 - progressbarcounter3 * 8;
            else if(InekUrunu.Tekrar==false)
            {
                InekUrunu.Tekrar = true;
                InekUrunu.HayvanSesleri();
                progressBar3.Value = 0;
                progressBar3.Enabled = false;
                label25.Text = "ÖLÜ";
                timer2.Stop();
            }
            if (progressBar4.Value > 4)//I made the progressbar to be decreased here. If it decrease to the end, HayvanSesleri method of Keci class is going to be called and Keci is going to seem dead.
                progressBar4.Value = 100 - progressbarcounter4 * 6;
            else if(KeciUrunu.Tekrar==false)
            {
                KeciUrunu.Tekrar = true;
                KeciUrunu.HayvanSesleri();
                progressBar4.Value = 0;
                progressBar4.Enabled = false;
                label27.Text = "ÖLÜ";
                timer4.Stop();
            }

        }      
        private void button1_Click(object sender, EventArgs e)//If button1 is clicked product of Tavuk is going to be selled and become money.
        {
            label18.Text = Convert.ToString((TavukUrunu.KasaSayaci += TavukUrunu.TavukYumurtası)+ " TL");
            TavukUrunu.TavukYumurtası = 0;
            label4.Text = "0";
          
        }

        private void button2_Click(object sender, EventArgs e)//If button2 is clicked product of Ordek is going to be selled and become money.
        {
            label18.Text = Convert.ToString((OrdekUrunu.KasaSayaci += OrdekUrunu.OrdekYumurtası*3)+ " TL");
            OrdekUrunu.OrdekYumurtası = 0;
            label8.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)//If button3 is clicked product of Inek is going to be selled and become money.
        {
            label18.Text = Convert.ToString((InekUrunu.KasaSayaci += InekUrunu.InekSutu * 5)+ " TL");
            InekUrunu.InekSutu = 0;
            label5.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)//If button4 is clicked product of Keci is going to be selled and become money.
        {
            label18.Text = Convert.ToString((KeciUrunu.KasaSayaci += KeciUrunu.KeciSutu * 8) + " TL");
            KeciUrunu.KeciSutu = 0;
            label9.Text = "0";
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            if (progressBar1.Enabled == true)//If button5 which is "YEM VER" button is clicked, energy of Tavuk is goşng to be 100 percent.
            {
                progressBar1.Value = 100;
                progressbarcounter1 = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (progressBar2.Enabled == true)//If button6 which is "YEM VER" button is clicked, energy of Ordek is goşng to be 100 percent.
            {
                progressBar2.Value = 100;
                progressbarcounter2 = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (progressBar3.Enabled == true)//If button7 which is "YEM VER" button is clicked, energy of Inek is goşng to be 100 percent.
            {
                progressBar3.Value = 100;
                progressbarcounter3 = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (progressBar4.Enabled == true)//If button8 which is "YEM VER" button is clicked, energy of Keci is goşng to be 100 percent.
            {
                progressBar4.Value = 100;
                progressbarcounter4 = 0;
            }
        }
    }
}