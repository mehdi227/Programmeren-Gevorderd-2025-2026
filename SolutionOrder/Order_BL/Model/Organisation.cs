using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_BL.Model
{
    public class Organisation
    {
        private readonly List<Event> _events = new();
        public ReadOnlyCollection<Event> Events => _events.AsReadOnly();
        public void AddEvent(Event x)
        {
            _events.Add(x);
        }
        public void RemoveEvent(Event x)
        {
            _events.Remove(x);
        }
        private readonly List<Member> _members = new();
        public ReadOnlyCollection<Member> Members => _members.AsReadOnly();
        public void AddMember(Member member)
        {
            _members.Add(member);
        }
        public void RemoveMember(Member member)
        {
            _members.Remove(member);
        }
    }
}
