using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtBedrijven_CL.DL
{
    public class BestandLezer
    {
        public BestandLezer() {
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\mehdi\\Downloads\\bedrijvenbelgie_18092025.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
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
