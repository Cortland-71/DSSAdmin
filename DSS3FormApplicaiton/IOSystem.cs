using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DSS3FormApplicaiton
{
    class IOSystem
    {
        public List<string> ReturnNewestFile(string dirPath)
        {
            FileInfo latestFile = FindLatestFile(dirPath);

            return LoadFile(dirPath + latestFile);
        }

        //Finds the newest file.
        private FileInfo FindLatestFile(string dirPath)
        {
            var directory = new DirectoryInfo(dirPath);

            FileInfo myFile = (from f in directory.GetFiles()
                          orderby f.CreationTime descending
                          select f).First();
            return myFile;
        }

        //Imports and returns the newest file.
        private List<string> LoadFile(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            List<string> searchList = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }
            return searchList;
        }
    }
}
