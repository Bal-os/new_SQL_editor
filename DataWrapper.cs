using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_editor_edition
{
    class DataWrapper
    {
        private const string header_top = "---------------------------------------------------------------------------------\n" +
                                          "--  ReleaseSQL_r10.8.3.6-2\n" +
                                          "---------------------------------------------------------------------------------\n";
        private const string footer_floor = "spool off\n\n" +
                                            "exit";
        private Dictionary<string, FileData> map;
        public DataWrapper(string[] names, List<string>[] data)
        {
            map = new Dictionary<string, FileData>();
            for (int i = 0; i < names.Length; i++)
            {
                map.Add(names[i], new FileData(data[i]));
            }
        }
        public string getResultString()
        {
            string result = header_top;
            result += map[map.Keys.Max()].Header;
            foreach (var current in map)
            {
                result += current.Value.MainData + '\n';
            }
            result += map[map.Keys.Last()].Footer;
            result += footer_floor;
            return result;
        }
    }
}
