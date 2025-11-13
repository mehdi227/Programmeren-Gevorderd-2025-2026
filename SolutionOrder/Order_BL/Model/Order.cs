using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_BL.Model
{
    public class Order
    {
        private int _id;
        private Member _member;
        private Ticket _ticket;
        private decimal _price;

        public Order(int id, Member member, Ticket ticket)
        {
            _id = id;
            _member = member;
            _ticket = ticket;
        }
    }
}
