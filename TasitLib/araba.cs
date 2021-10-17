using System;
using System.Collections.Generic;
using System.Text;

namespace TasitLib
{
    public class araba : tasit
    {

        private string VitesTipi;
        public string vitesTipi { get => VitesTipi; set => VitesTipi = value; }

        private int Yıl;
        public int yıl { get => yıl; set => yıl = value; }

        private int KoltukSayisi;
        public int koltuksayisi { get => koltuksayisi; set=> koltuksayisi = value; }


        private string Renk;
        public string renk { get=>renk; set=>renk=value; }
    }
    } 

