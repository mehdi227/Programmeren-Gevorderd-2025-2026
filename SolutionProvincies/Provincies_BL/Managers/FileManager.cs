using Provincies_BL.Exceptions;
using Provincies_BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provincies_BL.Managers
{
    public class FileManager : IFileProcessor
    {
        private IFileProcessor processor;
        private const string adresFileName = "AdresInfo.txt";

        public FileManager(IFileProcessor processor)
        {
            this.processor = processor;
        }
        public List<string> GetFilesFromZip(string zipFileName)
        {
            try
            {
                var names = processor.GetFileNamesFromZip(zipFileName);
                return names;
            }
            catch (Exception e) { throw new FileManagerException($"GetFilesFromZip - {e.Message}", e); }
        }

        public List<string> GetFileNamesFromZip(string zipFileName)
        {
            throw new NotImplementedException();
        }
    }
}
