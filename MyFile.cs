using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SQL_editor_edition
{
    class MyFile
    {
        private string[] path;
        private List<StreamReader> reader;
        private List<string>[] data;
        private void makeData()
        {
            data = new List<string>[path.Length];
            for (int i = 0; i < path.Length; i++)
            {
                string line;
                data[i] = new List<string>();
                while ((line = reader[i].ReadLine()) != null)
                {
                    data[i].Add(line);
                }
            }
        }
        public List<string>[] Data
        {
            get { return data; }
        }
        public string[] Path
        {
            get { return path; }
        }
        public MyFile(string[] path)
        {
            this.path = path;
            reader = new List<StreamReader>();
            foreach (string fileName in path)
            {
                reader.Add(new StreamReader(fileName));
            }
            makeData();
        }
    }
}
