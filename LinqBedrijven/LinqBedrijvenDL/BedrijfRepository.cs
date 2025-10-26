using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBedrijvenCL.Interfaces;

namespace LinqBedrijvenDL
{
    public class BedrijfRepository
    {
        private string _connectionString;

        public BedrijfRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
