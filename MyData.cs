using System.IO;
using System.Text.RegularExpressions;

namespace SQL_editor_edition
{
    class MyData
    // file class for standart files
    {
        protected const string footer = "exit"; //const for footer find 
        protected const string not_footer = "exit;"; //const for footer find 
        private const string header_indicator_1 = "select "; //const for header find
        private const string header_indicator_2 = @"PAUSE (.*);"; //const for header find
        private string name; //name of current file
        private string main_text; //text of current file without header and footer
        private string header; //text from header of current file
        private string pre_header; //pre header comment

        protected virtual void parseStream(ref StreamReader reader)
        // take text from stream find and remove header remove footer, save main part
        {
            string text = reader.ReadToEnd(); //string for reading stream
            int exitPos = text.LastIndexOf(footer); //int for footer find 

            if (exitPos != text.LastIndexOf(not_footer)) /// get text without "exit"
                main_text = text.Substring(0, text.LastIndexOf(footer));
            else
                main_text = text;

            int header_begin = text.IndexOf(header_indicator_1);
            foreach (Match match in Regex.Matches(text, header_indicator_2))
            {
                pre_header = main_text.Substring(0, header_begin); 
                header = main_text.Substring(header_begin, match.Index - header_begin + match.Length); 
                main_text = main_text.Substring(match.Index + match.Length, 
                            main_text.Length - match.Index - match.Length); 
                break;
            }
        }

        public MyData(string name, StreamReader reader)
        //formation of file fields for convenient output
        {
            this.name = name;
            main_text = "";
            parseStream(ref reader);

        }
        public string mainText { get => main_text; }
        public string Header { get => header; }
        public string preHeader { get => pre_header; }

    }
}
