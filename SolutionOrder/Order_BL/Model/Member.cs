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
        public int Id
        {
            get { return _id; }
            set { if (value == null || value < 1) throw new Exception("id is null or smaller then 1"); _id = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new Exception("name is null or whitespace"); _name = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new Exception("email is null or whitespace"); _email = value; }
        }
        private string _adres;
        public string Adres { 
            get { return _adres; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new Exception("adres is null or whitespace"); _adres = value; }
        }
        private string _status;
        public string Status
        {
            get { return _status; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new Exception("Status is null or whitespace"); _status = value; }
        }

        public Member(string name, string email, string adres)
        {
            _name = name;
            _email = email;
            _adres = adres;
        }
    }
}
