using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_editor_edition
{
    class FileData
    {
        private const string delimeter = "---------------------------------------------------------------------------------";
        private const string footer_marker = "spool off";
        private int counter = 0;
        private List<string> main_data;
        private List<string> header;
        private List<string> footer;
        private List<string> ParseData(List<string> data)
        {
            int i = 0;
            string line;
            bool footer_flag = false;
            header = new List<string>();
            footer = new List<string>();
            while (counter < 3)
            {
                line = data[i];
                if (line == delimeter)
                {
                    counter++;
                }
                if (counter > 1)
                    header.Add(line);
                data.RemoveAt(i);
                i++;
            }
            counter = 0;
            i = data.Count - 1;
            while (counter < 3)
            {
                line = data[i];
                if (line == footer_marker)
                {
                    footer_flag = true;
                }
                if (footer_flag)
                {
                    if (line == delimeter)
                    {
                        counter++;
                    }
                    footer.Add(line);
                }
                data.RemoveAt(i);
                i--;
            }
            footer.Reverse();
            return data;
        }
        public string MainData
        {
            get
            {
                string ans = "";
                foreach (string line in main_data) ans += line + '\n';
                return ans;
            }
        }
        public string Header
        {
            get
            {
                string ans = "";
                foreach (string line in header) ans += line + '\n';
                return ans;
            }
        }
        public string Footer
        {
            get
            {
                string ans = "";
                foreach (string line in footer) ans += line + '\n';
                return ans;
            }
        }
        public FileData(List<string> data) => main_data = ParseData(data);
    }
}
