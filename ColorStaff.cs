using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQL_editor_edition
{
    class ColorStaff
    {
        private readonly List<Tuple<string, Color> > SQLsyntax;
        private List<Tuple<int, int, Color>> result;
        private int num;

        public List<Tuple<int, int, Color>> Result => result;

        public void CheckLine(string line)
        {
            foreach (var iter in SQLsyntax)
                foreach (Match match in Regex.Matches(line, iter.Item1))
                {
                    result.Add(Tuple.Create(num + match.Index, match.Length, iter.Item2));
                }
            num += line.Length + 1;
        }

        public ColorStaff()
        {
            result = new List<Tuple<int, int, Color>>();
            SQLsyntax = new List<Tuple<string, Color>>() { 
                Tuple.Create("\\bPAUSE\\b", Color.Blue),
                Tuple.Create(" BEGIN ", Color.Blue),
                Tuple.Create(" select ", Color.Blue),
                Tuple.Create(" decode ", Color.Blue),
                Tuple.Create(" as ", Color.Blue),
                Tuple.Create("\\bRPAD\\b", Color.Blue),
                Tuple.Create(" from ", Color.Blue),
                Tuple.Create(" null ", Color.Blue),
                Tuple.Create(" where ", Color.Blue),
                Tuple.Create("(?<Number>[0-9])", Color.Orange),
                //Tuple.Create(@"/*(\w*)*/", Color.Green),
                Tuple.Create(@"\'(\w*)\'", Color.Gray), 
                Tuple.Create("\".*?\"", Color.Gray) 

            };
        }
    }
}
