using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SQL_editor_edition
{
    class FilesSet
    //class wrapper of instances of the file class
    {
        private const string footer = "exit"; //const for footer output
        private List<MyFile> files; // file class container
        public FilesSet(string[] names, ref ColorStaff staff)
        // add information from each file to the equivalent class
        {
            files = new List<MyFile>();
            Array.Sort(names);
            files.Add(new MyFirstFile(names[0], new StreamReader(names[0], Encoding.GetEncoding(1251)), ref staff));
            for (int i = 1; i < names.Length; i++)
                files.Add(new MyFile(names[i], new StreamReader(names[i], Encoding.GetEncoding(1251)), ref staff));
        }

        public List<string> getResultFile()
        // getter list of string with text of result file
        {
            List<string> output_list = new List<string>();
            foreach(var file in files)
                output_list.AddRange(file.Main_text);
            output_list.Add(footer);
            return output_list;
        }

    }
}
