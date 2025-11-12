using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provincies_BL.Interfaces
{
    public interface IFileProcessor
    {
        public List<string> GetFileNamesFromZip(string zipFileName);
        public List<string> GetFilesFromZip(string zipFileName);
    }
}
