using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SQL_editor_edition
{
    class MyFile
    // file class for standart files
    {
        protected const string footer = "exit"; //const for footer find 
        private const string header_indicator_1 = "select version||decode"; //const for header find
        private const string header_indicator_2 = "PAUSE Встановити оновлення"; //const for header find
        private bool header_search_flag; //flag for header find
        protected string name; //name of current file
        protected List<string> main_text; //text of current file without header and footer

        protected virtual void parseStream(ref StreamReader reader, ref ColorStaff staff)
        // take text from stream find and remove header remove footer, save main part
        {
            string line; //string for reading stream
            header_search_flag = false;
            while ((line = reader.ReadLine()) != footer || (line = reader.ReadLine()) != null)
            {
                if (line.Contains(header_indicator_1))
                {
                    header_search_flag = true;
                    continue;
                }
                if (header_search_flag && line.Contains(header_indicator_2))
                {
                    break;
                }
                else
                {
                    staff.CheckLine(line);
                    main_text.Add(line);
                }     
            }
            while ((line = reader.ReadLine()) != footer || (line = reader.ReadLine()) != null)
            {
                staff.CheckLine(line);
                main_text.Add(line);
            }
        }

        public MyFile(string name, StreamReader reader, ref ColorStaff staff)
        //formation of file fields for convenient output
        {
            this.name = name;
            main_text = new List<string>();
            parseStream(ref reader, ref staff);
        }
        public List<string> Main_text { get => main_text; }
        // getter of main_text field

    }
}
