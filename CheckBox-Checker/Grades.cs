using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBox_Checker
{
    class Grades
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public Grades() { }
        public Grades(string val1,string val2)
        {
            this.Name = val1;
            this.Value = val2;
        }

        public List<Grades> gradeList()
        {
            List<Grades> gList = new List<Grades>();
            for(int x=1;x<=12;x++)
            {
                gList.Add(new Grades(x.ToString(),x.ToString()));
                if (x == 9 || x == 10 || x == 11 || x == 12) { gList.Add(new Grades(x.ToString() + "iG", x.ToString() + "iG")); }
            }
            return gList;
        }

        public List<Grades> divisionList()
        {
            List<Grades> divisionList = new List<Grades>();
            for (int x = 1; x <= 5; x++) {
                if (x <= 2) { divisionList.Add(new Grades("f" + x.ToString(), "f" + x.ToString())); }
                else { divisionList.Add(new Grades("m" + (6 - x).ToString(), "m" + (6 - x).ToString())); }
            }
            char[] alphbee = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
            for(int y = 0; y <= alphbee.Length; y++)
            {
                divisionList.Add(new Grades(alphbee[y].ToString(),alphbee[y].ToString()));
            }
            return divisionList;
        }
    }
}
