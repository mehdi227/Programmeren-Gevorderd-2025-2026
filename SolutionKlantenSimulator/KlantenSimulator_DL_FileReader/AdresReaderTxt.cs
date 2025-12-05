using KlantenSimulator_BL.Interfaces;
using KlantenSimulator_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantenSimulator_DL_FileReader {
    public class AdresReaderTxt : IAdresReaderTxt {
        public List<Adres> FileReader_Adres(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                List<Adres> adresses = new();
                while ((line = sr.ReadLine())!= null)
                {
                    string[] data = line.Split(';');
                    string municipality = data[0];
                    string street = data[1];
                    Adres adres = new Adres(municipality,street);
                    adresses.Add(adres);
                }
                return adresses;
            }
        }
    }
}
