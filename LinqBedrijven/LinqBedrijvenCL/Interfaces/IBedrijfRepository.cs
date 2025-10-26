using LinqBedrijvenCL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBedrijvenCL.Interfaces
{
    public interface IBedrijfRepository
    {
        private readonly IBedrijfRepository _repo;
        private readonly List<Bedrijf> _bedrijven;
    }
}
