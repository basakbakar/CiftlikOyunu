using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciftlik_Proje
{
    class Ordek:Hayvan
    {
        public bool Tekrar;//I defined fields here.
        public int OrdekYumurtası = 0;
        public int KasaSayaci = 0;
        public override void UrunVerme()//I printed UrunVerme function here.
        {
            base.UrunVerme();
            OrdekYumurtası++;
        }       
        public override void HayvanSesleri()//I printed HayvanSesleri function here.
        {
            base.HayvanSesleri();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Administrator\Desktop\NDP Ders Notları\Hayvan Ciftligi Dosyalar\ordek.wav");
            player.Play();
        }
    }
}