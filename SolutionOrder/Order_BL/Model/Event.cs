using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Order_BL.Model
{
    public class Event
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
            set { if (string.IsNullOrWhiteSpace(value)) throw new Exception("name is null or white space"); _name = value; }
        }
        private string _adres;
        public string Adres { 
            get { return _adres;}
            set { if (string.IsNullOrWhiteSpace(value)) throw new Exception("adres is null or white space"); _adres = value; }
        }
        private DateTime _date;
        public DateTime Date {
            get { return _date; }
            set { if (value < DateTime.Now) throw new Exception("Date is in the past"); _date = value; } 
        }
        private decimal _price;
        public decimal Price {
            get { return _price; }
            set { if (value == null) throw new Exception("price is NULL"); _price = value; }
        }
        private readonly List<Member> _attendees = new();

        public Event(string name, string adres, DateTime date)
        {
            _name = name;
            _adres = adres;
            _date = date;
        }

        public ReadOnlyCollection<Member> Attendees => _attendees.AsReadOnly();
        public void AddAttendee(Member member)
        {
            _attendees.Add(member);
        }
    }
}
