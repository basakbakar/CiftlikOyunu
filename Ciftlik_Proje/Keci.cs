using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciftlik_Proje
{
    class Keci:Hayvan
    {
        public bool Tekrar;//I defined fields here.
        public int KeciSutu = 0;
        public int KasaSayaci = 0;
        public override void UrunVerme()//I printed UrunVerme function here.
        {
            base.UrunVerme();
            KeciSutu++;
        }       
        public override void HayvanSesleri()//I printed HayvanSesleri function here.
        {
            base.HayvanSesleri();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Administrator\Desktop\NDP Ders Notları\Hayvan Ciftligi Dosyalar\keci.wav");
            player.Play();
        }
    }
}