using OpdrachtBedrijven_CL.BL;
using OpdrachtBedrijven_CL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OpdrachtBedrijven_CL.DL
{
    public class BestandLezer
    {
        public BestandLezer(string padNaarTeLezenBestand,string padNaarErrorLog) {
            List<string> errors = new();
            try
            {
                using (StreamWriter sw = new StreamWriter(padNaarErrorLog))
                using (StreamReader sr = new StreamReader(padNaarTeLezenBestand))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        try
                        {
                            //probeer alle data in variabelen te steken
                            string[] ss = line.Split('|');
                            string b_naam = ss[0];
                            string b_industrie = ss[1];
                            string b_sector = ss[2];
                            string b_hoofdkwartier = ss[3];
                            int b_oprichtjaar = Convert.ToInt32(ss[4]);
                            string b_extraInfo = ss[5];
                            int p_id = int.Parse(ss[6]);
                            string p_voornaam = ss[7];
                            string p_achternaam = ss[8];
                            DateTime p_Geboortedatum = DateTime.Parse(ss[9],new System.Globalization.CultureInfo("nl-BE"));
                            string a_woonplaats = ss[9];
                            int a_postcode = int.Parse(ss[10]);
                            string a_straatnaam = ss[11];
                            string a_huisnummer = ss[12];
                            string p_email = ss[13];
                            //maak objecten met alle data
                            try
                            {
                                Bedrijf bedrijf = new Bedrijf(b_naam, b_industrie, b_sector, b_hoofdkwartier, b_oprichtjaar, b_extraInfo);
                            }
                            catch (BedrijfException ex)
                            {
                                errors.Add(ex.Message);
                            }
                            Adres p_adres = new Adres(a_woonplaats,a_straatnaam,a_huisnummer,a_postcode);
                            Personeel personeel = new Personeel(p_id, p_voornaam, p_achternaam,p_email,p_Geboortedatum,p_adres);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
