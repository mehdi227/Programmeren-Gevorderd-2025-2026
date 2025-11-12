using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_BL.Model
{
    public class Member
    {
        private int _id;
        public int Id {
            get { return _id; }
            set { if(value == null || value < 1) throw new Exception("id is null or smaller then 1"); _id = value; }
        }
        private string _name;
        private string _email;
        private string _adres;
        private string _status;

        public Member(string name, string email, string adres)
        {
            _name = name;
            _email = email;
            _adres = adres;
        }
    }
}
