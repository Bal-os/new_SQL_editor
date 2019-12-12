using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace SQL_editor_edition
{
    class DataSet
    //class wrapper of instances of the file class
    {
        private const string footer = "\t\n\t\nexit\t\n"; //const for footer output
        private const string pre_header_begin = @"ReleaseSQL(.*)-"; //const for first pre header
        private const string pre_header_delimiter = " - ";
        private List<MyData> list_of_data; // data class container
        private string first_pre_header = ""; //variable for start comment in file
        private string file_name = ""; //variable for easier naming file

        private void MakeResultPreHeader(int size)
        // function for forming the version field
        {
            string text_from_first_header = list_of_data[0].preHeader; // get version from first file
            string text_from_last_header = list_of_data[size - 1].preHeader; // get version from last file
            first_pre_header = text_from_last_header;
            foreach (Match match in Regex.Matches(text_from_first_header, pre_header_begin))
            {
                first_pre_header = text_from_first_header.Substring(0, match.Index + match.Length - 1);
                file_name = text_from_first_header.Substring(match.Index, match.Length - 1);
                file_name += pre_header_delimiter;
                first_pre_header += pre_header_delimiter;
                foreach (Match match_next in Regex.Matches(text_from_last_header, pre_header_begin))
                {
                    file_name += text_from_last_header.Substring(match_next.Index, match_next.Length - 1);
                    first_pre_header += text_from_last_header.Substring(match_next.Index, match_next.Length - 1);
                    break;
                }
                first_pre_header +=
                    text_from_first_header.Substring(match.Index + match.Length + 1,
                    text_from_first_header.Length - match.Index - match.Length - 1);
                break;
            }
        }

        public string fileName { get => file_name; }
        public DataSet(string[] names)
        // add information from each file to the equivalent class
        {
            list_of_data = new List<MyData>();
            Array.Sort(names);
            foreach (var i in names)
                list_of_data.Add(new MyData(i, new StreamReader(i, Encoding.GetEncoding(1251))));
        }

        public string getResultData()
        // getter string with text of result file
        {
            string output_string = "";
            int size = list_of_data.Count;
            MakeResultPreHeader(size);
            output_string += first_pre_header;
            output_string += list_of_data[size - 1].Header;
            output_string += list_of_data[0].mainText;
            for (int i = 1; i < size; i++)
            {
                MyData file = list_of_data[i];
                output_string += file.preHeader;
                output_string += file.mainText;
            }
            output_string += footer;
            return output_string;
        }

    }
}
