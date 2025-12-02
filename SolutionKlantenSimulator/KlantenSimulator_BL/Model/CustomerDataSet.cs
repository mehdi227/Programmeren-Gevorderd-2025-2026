using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantenSimulator_BL.Model
{
    public class CustomerDataSet
    {
        public int? Id {  get; set; }
        private List<Customer> _customerList = new();
        public IReadOnlyCollection<Customer> CustomerList => _customerList.AsReadOnly();
        private Dictionary<string,int> _vrouwenNamenNaarAantal = new();
        public IReadOnlyDictionary<string, int> VrouwenNamenNaarAantal => _vrouwenNamenNaarAantal.AsReadOnly();
        private Dictionary<string, int> _mannenNamenNaarAantal = new();
        public IReadOnlyDictionary<string,int> MannenNamenNaarAantal => _mannenNamenNaarAantal.AsReadOnly();
        private Dictionary<string, int> _familieNamenNaarAantal = new();
        public IReadOnlyDictionary<string, int> FamilieNamenNaarAantal => _familieNamenNaarAantal.AsReadOnly();
    }
}
