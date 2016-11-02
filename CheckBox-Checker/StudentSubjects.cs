using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBox_Checker
{
    class StudentSubjects
    {
        public string studID { get; set; }
        public string studentName { get; set; }
        public string islamicEdArab { get; set; } 
        public string islamicEdNonArab { get; set; }
        public string arabLanguageArab { get; set; }
        public string arabLanguageNonArab { get; set; }
        public string socialStudUAEArab { get; set; }
        public string socialStudUAENonArab { get; set; }
        public string socialStudEnglish { get; set; }
        public string informationT { get; set; }
        public string frenchLang { get; set; }
        public string musicEd { get; set; }
        public string artEd { get; set; }
        public string physicalEd { get; set; }
        public string englishLang { get; set; }
        public string mathematics { get; set; }
        public string science { get; set; }

        public StudentSubjects studSubGrade6(List<string> fuckingCodes)
        {
            //1 or not null is true, 0 is  false
            this.studID = fuckingCodes[0].ToString().Trim().Split()[0];
            this.studentName = fuckingCodes[1].ToString().Trim();
            switch (fuckingCodes[2].ToString().Trim())
            {
                case "SP":
                    this.islamicEdNonArab = "1";
                    break;
                case "ISL":
                    this.islamicEdArab = "1";
                    break;
                default:
                    this.islamicEdArab = "0";
                    this.islamicEdNonArab = "0";
                    break;
            }
            switch (fuckingCodes[3].ToString().Trim())
            {
                case "SP":
                    this.arabLanguageNonArab = "1";
                    break;
                case "AFL":
                    this.arabLanguageArab = "1";
                    break;
                default:
                    this.arabLanguageArab = "0";
                    this.arabLanguageNonArab = "1";
                    break;
            }
            switch(fuckingCodes[4].ToString().Trim())
            {
                case "SP":
                    this.socialStudUAENonArab = "1";
                    break;
                case "SSA":
                    this.socialStudUAEArab = "1";
                    break;
                default:
                    this.socialStudUAEArab = "0";
                    this.socialStudUAENonArab = "0";
                    break;
            }
            if (fuckingCodes[5].ToString().Trim() != "") { this.englishLang = "1"; }
            if (fuckingCodes[6].ToString().Trim() != "") { this.mathematics = "1"; }
            if (fuckingCodes[7].ToString().Trim() != "") { this.science = "1"; }
            if (fuckingCodes[8].ToString().Trim() != "") { this.socialStudEnglish = "1"; }
            if (fuckingCodes[9].ToString().Trim() != "") { this.informationT = "1"; }
            this.frenchLang = "1";
            this.musicEd = "1";
            this.artEd = "1";
            this.physicalEd = "1";
            return this;
        }
    }
}
