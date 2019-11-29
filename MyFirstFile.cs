using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace SQL_editor_edition
{
    class MyFirstFile : MyFile
    // file class for file with header
    {

        protected override void parseStream(ref StreamReader reader)
        // take text from stream find and remove header remove footer, save main part
        {
            string line;
            while ((line = reader.ReadLine()) != footer || (line = reader.ReadLine()) != null)
            {
                main_text.Add(line);
            }
        }
        public MyFirstFile(string name, StreamReader reader) : base(name, reader) 
        {
        }
    }
}
