using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_BL.Model
{
    public class Ticket
    {
        private int _id;
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { if (value == null) throw new Exception("price is NULL"); _price = value; }
        }
    }
}
