using KlantenSimulator_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantenSimulator_BL.Interfaces {
    public interface IAdresReaderTxt {
        public List<Adres> FileReader_Adres(string path);
    }
}
