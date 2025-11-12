using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_BL.Model
{
    public class Order
    {
        private Member _member;
        private Ticket _ticket;
        private decimal _price;
        private string _delivery;
        private bool _welcomePackage;
    }
}
