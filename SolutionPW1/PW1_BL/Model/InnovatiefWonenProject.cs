using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_BL.Model
{
    public class InnovatiefWonenProject
    {
        public int AantalWoonEenheden { get; set; }
        public string Woonvorm { get; set; }
        public bool Rondleiding { get; set; }
        public bool ShowWoning { get; set; }
        public int ArchitecturaleInnovatieScore { get; set; }
        public bool InSamenwerkingMetErfgoedOfToerismeGent { get; set; }
    }
}
