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
        public string uaeCivics { get; set; }
        public string uaeHistory { get; set; }
        public string uaeGeo { get; set; }
        public string socialStudEnglish { get; set; }
        public string englishHistory { get; set; }
        public string physics { get; set; }
        public string chemistry { get; set; }
        public string biology { get; set; }
        public string informationT { get; set; }
        public string frenchLang { get; set; }
        public string enrichementEng { get; set; }
        public string economics { get; set; }
        public string musicEd { get; set; }
        public string artEd { get; set; }
        public string physicalEd { get; set; }
        public string sociology { get; set; }
        public string psychology { get; set; }
        public string englishLang { get; set; }
        public string mathematics { get; set; }
        public string enterpreneurship { get; set; }
        public string businessStudies { get; set; }
        public string finance { get; set; }
        public string science { get; set; }

        public StudentSubjects studSubGrade6(List<string> fuckingCodes)
        {
            //1 or not null is true, 0 is  false
            StudentSubjects iniThisBitch = new StudentSubjects();
            iniThisBitch.studID = fuckingCodes[0].ToString().Trim().Split()[0];
            iniThisBitch.studentName = fuckingCodes[1].ToString().Trim();
            switch (fuckingCodes[2].ToString().Trim())
            {
                case "SP":
                    iniThisBitch.islamicEdNonArab = "1";
                    iniThisBitch.islamicEdArab = null;
                    break;
                case "ISL":
                    iniThisBitch.islamicEdNonArab = null;
                    iniThisBitch.islamicEdArab = "1";
                    break;
                default:
                    iniThisBitch.islamicEdArab = null;
                    iniThisBitch.islamicEdNonArab = null;
                    break;
            }
            switch (fuckingCodes[3].ToString().Trim())
            {
                case "SP":
                    iniThisBitch.arabLanguageNonArab = "1";
                    iniThisBitch.arabLanguageArab = null;
                    break;
                case "AFL":
                    iniThisBitch.arabLanguageNonArab = null;
                    iniThisBitch.arabLanguageArab = "1";
                    break;
                default:
                    iniThisBitch.arabLanguageArab = null;
                    iniThisBitch.arabLanguageNonArab = null;
                    break;
            }
            switch (fuckingCodes[4].ToString().Trim())
            {
                case "SP":
                    iniThisBitch.socialStudUAENonArab = "1";
                    iniThisBitch.socialStudUAEArab = null;
                    break;
                case "SSA":
                    iniThisBitch.socialStudUAEArab = "1";
                    iniThisBitch.socialStudUAENonArab = null;
                    break;
                default:
                    iniThisBitch.socialStudUAEArab = null;
                    iniThisBitch.socialStudUAENonArab = null;
                    break;
            }
            if (fuckingCodes[5].ToString().Trim() != "") { iniThisBitch.englishLang = "1"; }
            if (fuckingCodes[6].ToString().Trim() != "") { iniThisBitch.mathematics = "1"; }
            if (fuckingCodes[7].ToString().Trim() != "") { iniThisBitch.science = "1"; }
            if (fuckingCodes[8].ToString().Trim() != "") { iniThisBitch.socialStudEnglish = "1"; }
            if (fuckingCodes[9].ToString().Trim() != "") { iniThisBitch.informationT = "1"; }
            iniThisBitch.frenchLang = "1";
            iniThisBitch.musicEd = "1";
            iniThisBitch.artEd = "1";
            iniThisBitch.physicalEd = "1";
            return iniThisBitch;
        }

        public StudentSubjects stubSubGrade8(List<string> fuckingCodes)
        {
            this.studID = fuckingCodes[0].ToString().Trim();
            this.studentName = fuckingCodes[1].ToString().Trim();
            switch (fuckingCodes[2].ToString().Trim())
            {
                case "SP":
                    this.islamicEdNonArab = "1";
                    this.islamicEdArab = null;
                    break;
                case "ISL":
                    this.islamicEdNonArab = null;
                    this.islamicEdArab = "1";
                    break;
                default:
                    this.islamicEdArab = null;
                    this.islamicEdNonArab = null;
                    break;
            }
            switch (fuckingCodes[3].ToString().Trim())
            {
                case "SP":
                    this.arabLanguageNonArab = "1";
                    this.arabLanguageArab = null;
                    break;
                case "AFL":
                    this.arabLanguageNonArab = null;
                    this.arabLanguageArab = "1";
                    break;
                default:
                    this.arabLanguageArab = null;
                    this.arabLanguageNonArab = null;
                    break;
            }
            switch (fuckingCodes[4].ToString().Trim())
            {
                case "SP":
                    this.socialStudUAENonArab = "1";
                    this.uaeCivics = null;
                    this.uaeHistory = null;
                    this.uaeGeo = null;
                    break;
                case "SSA":
                    this.socialStudUAEArab = "1";
                    this.uaeCivics = "1";
                    this.uaeHistory = "1";
                    this.uaeGeo = "1";
                    break;
                default:
                    this.socialStudUAEArab = null;
                    this.socialStudUAENonArab = null;
                    this.uaeCivics = null;
                    this.uaeHistory = null;
                    this.uaeGeo = null;
                    break;
            }
            if (fuckingCodes[5].ToString().Trim() != "") { this.englishLang = "1"; }
            if (fuckingCodes[6].ToString().Trim() != "") { this.enrichementEng = "1"; }
            if (fuckingCodes[7].ToString().Trim() != "") { this.mathematics = "1"; }
            if (fuckingCodes[8].ToString().Trim() != "") { this.science = "1"; }
            if (fuckingCodes[9].ToString().Trim() != "") { this.socialStudEnglish = "1"; }
            this.informationT = "1";
            this.frenchLang = "1";
            this.musicEd = "1";
            this.artEd = "1";
            this.physicalEd = "1";
            return this;
        }

        public StudentSubjects stubSubGrade7(List<string> fuckingCodes)
        {
            //1 or not null is true, 0 is  false
            this.studID = fuckingCodes[0].ToString().Trim();
            this.studentName = fuckingCodes[1].ToString().Trim();
            switch (fuckingCodes[2].ToString().Trim())
            {
                case "SP":
                    this.islamicEdNonArab = "1";
                    this.islamicEdArab = null;
                    break;
                case "ISL":
                    this.islamicEdNonArab = null;
                    this.islamicEdArab = "1";
                    break;
                default:
                    this.islamicEdArab = null;
                    this.islamicEdNonArab = null;
                    break;
            }
            switch (fuckingCodes[3].ToString().Trim())
            {
                case "SP":
                    this.arabLanguageNonArab = "1";
                    this.arabLanguageArab = null;
                    break;
                case "AFL":
                    this.arabLanguageNonArab = null;
                    this.arabLanguageArab = "1";
                    break;
                default:
                    this.arabLanguageArab = null;
                    this.arabLanguageNonArab = null;
                    break;
            }
            switch (fuckingCodes[4].ToString().Trim())
            {
                case "SP":
                    this.socialStudUAENonArab = "1";
                    this.uaeCivics = null;
                    this.socialStudUAEArab = null;
                    break;
                case "SSA":
                    this.socialStudUAEArab = "1";
                    this.uaeCivics = "1";
                    this.socialStudUAENonArab = null;
                    break;
                default:
                    this.socialStudUAEArab = null;
                    this.socialStudUAENonArab = null;
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

        public StudentSubjects stubSubGrade9(List<string> fuckingCodes)
        {
            //1 or not null is true, null is  false you stupid moron
            this.studID = fuckingCodes[0].ToString().Trim();
            this.studentName = fuckingCodes[1].ToString().Trim();
            switch (fuckingCodes[2].ToString().Trim())
            {
                case "ISL":
                    this.islamicEdArab = "1";
                    this.islamicEdNonArab = null;
                    break;
                case "SP":
                    this.islamicEdArab = null;
                    this.islamicEdNonArab = "1";
                    break;
                default:
                    this.islamicEdArab = null;
                    this.islamicEdNonArab = null;
                    break;
            }
            switch (fuckingCodes[3].ToString().Trim())
            {
                case "AFL":
                    this.arabLanguageArab = "1";
                    this.arabLanguageNonArab = null;
                    break;
                case "SP":
                    this.arabLanguageArab = null;
                    this.arabLanguageNonArab = "1";
                    break;
                default:
                    this.arabLanguageArab = null;
                    this.arabLanguageNonArab = null;
                    break;
            }
            switch (fuckingCodes[4].ToString().Trim())
            {
                case "SP":
                    this.socialStudUAENonArab = "1";
                    this.uaeCivics = null;
                    this.uaeHistory = null;
                    this.uaeGeo = null;
                    break;
                case "SSA":
                    this.socialStudUAEArab = "1";
                    this.uaeCivics = "1";
                    this.uaeHistory = "1";
                    this.uaeGeo = "1";
                    break;
                default:
                    this.socialStudUAEArab = null;
                    this.socialStudUAENonArab = null;
                    this.uaeCivics = null;
                    this.uaeHistory = null;
                    this.uaeGeo = null;
                    break;
            }
            if (fuckingCodes[5].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.englishLang = null; } else
            { this.englishLang = "1"; }

            if (fuckingCodes[6].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.mathematics = null; } else
            { this.mathematics = "1"; }

            if (fuckingCodes[7].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.physics = null; } else
            { this.physics = "1"; }

            if (fuckingCodes[8].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.chemistry = null; } else
            { this.chemistry = "1"; }

            if (fuckingCodes[9].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.biology = null; } else
            { this.biology = "1"; }

            if (fuckingCodes[10].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.englishHistory = null; } else
            { this.englishHistory = "1"; }

            if (fuckingCodes[11].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.informationT = null; } else
            { this.informationT = "1"; }

            this.physicalEd = "1";
            this.englishHistory = "1";

            return this;
        }

        public StudentSubjects stubSubGrade10(List<string> fuckingCodes)
        {
            //1 or not null is true, null is  false you stupid moron
            this.studID = fuckingCodes[0].ToString().Trim().Split()[0];
            this.studentName = fuckingCodes[1].ToString().Trim();
            switch (fuckingCodes[2].ToString().Trim())
            {
                case "ISL":
                    this.islamicEdArab = "1";
                    this.islamicEdNonArab = null;
                    break;
                case "SP":
                    this.islamicEdArab = null;
                    this.islamicEdNonArab = "1";
                    break;
                default:
                    this.islamicEdArab = null;
                    this.islamicEdNonArab = null;
                    break;
            }
            switch (fuckingCodes[3].ToString().Trim())
            {
                case "AFL":
                    this.arabLanguageArab = "1";
                    this.arabLanguageNonArab = null;
                    break;
                case "SP":
                    this.arabLanguageArab = null;
                    this.arabLanguageNonArab = "1";
                    break;
                default:
                    this.arabLanguageArab = null;
                    this.arabLanguageNonArab = null;
                    break;
            }
            if (fuckingCodes[4].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.englishLang = null; } else
            { this.englishLang = "1"; }

            if (fuckingCodes[5].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.mathematics = null; } else
            { this.mathematics = "1"; }

            if (fuckingCodes[6].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.physics = null; } else
            { this.physics = "1"; }

            if (fuckingCodes[7].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.chemistry = null; } else
            { this.chemistry = "1"; }

            if (fuckingCodes[8].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.biology = null; } else
            { this.biology = "1"; }

            if (fuckingCodes[9].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.economics = null; } else
            { this.economics = "1"; }

            if (fuckingCodes[10].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.informationT = null; } else
            { this.informationT = "1"; }

            this.physicalEd = "1";

            return this;
        }

        public StudentSubjects stubSubGrade11(List<string> fuckingCodes)
        {
            //1 or not null is true, null is  false you stupid moron
            this.studID = fuckingCodes[0].ToString().Trim().Split()[0];
            this.studentName = fuckingCodes[1].ToString().Trim();
            switch (fuckingCodes[2].ToString().Trim())
            {
                case "ISL":
                    this.islamicEdArab = "1";
                    this.islamicEdNonArab = null;
                    break;
                case "SP":
                    this.islamicEdArab = null;
                    this.islamicEdNonArab = "1";
                    break;
                default:
                    this.islamicEdArab = null;
                    this.islamicEdNonArab = null;
                    break;
            }
            switch (fuckingCodes[3].ToString().Trim())
            {
                case "AFL":
                    this.arabLanguageArab = "1";
                    this.arabLanguageNonArab = null;
                    break;
                case "SP":
                    this.arabLanguageArab = null;
                    this.arabLanguageNonArab = "1";
                    break;
                default:
                    this.arabLanguageArab = null;
                    this.arabLanguageNonArab = null;
                    break;
            }
            if (fuckingCodes[4].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.englishLang = null; }
            else
            { this.englishLang = "1"; }

            if (fuckingCodes[5].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.mathematics = null; }
            else
            { this.mathematics = "1"; }
            
            if (fuckingCodes[6].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.physics = null; }
            else
            { this.physics = "1"; }

            if (fuckingCodes[7].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.finance = null; }
            else
            { this.finance = "1"; }

            if (fuckingCodes[8].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.chemistry = null; }
            else
            { this.chemistry= "1"; }

            if (fuckingCodes[9].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.biology= null; }
            else
            { this.biology = "1"; }

            if (fuckingCodes[10].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.sociology = null; }
            else
            { this.sociology = "1"; }

            if (fuckingCodes[11].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.businessStudies = null; }
            else
            { this.businessStudies = "1"; }

            if (fuckingCodes[12].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.informationT = null; }
            else
            { this.informationT = "1"; }

            this.physicalEd = "1";

            return this;
        }

        public StudentSubjects stubSubGrade12(List<string> fuckingCodes)
        {
            //1 or not null is true, null is  false you stupid moron
            this.studID = fuckingCodes[0].ToString().Trim().Split()[0];
            this.studentName = fuckingCodes[1].ToString().Trim();
            switch (fuckingCodes[2].ToString().Trim())
            {
                case "ISL":
                    this.islamicEdArab = "1";
                    this.islamicEdNonArab = null;
                    break;
                case "SP":
                    this.islamicEdArab = null;
                    this.islamicEdNonArab = "1";
                    break;
                default:
                    this.islamicEdArab = null;
                    this.islamicEdNonArab = null;
                    break;
            }
            switch (fuckingCodes[3].ToString().Trim())
            {
                case "AFL":
                    this.arabLanguageArab = "1";
                    this.arabLanguageNonArab = null;
                    break;
                case "SP":
                    this.arabLanguageArab = null;
                    this.arabLanguageNonArab = "1";
                    break;
                default:
                    this.arabLanguageArab = null;
                    this.arabLanguageNonArab = null;
                    break;
            }
            if (fuckingCodes[4].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.englishLang = null; }
            else
            { this.englishLang = "1"; }

            if (fuckingCodes[5].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.mathematics = null; }
            else
            { this.mathematics = "1"; }

            if (fuckingCodes[6].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.physics = null; }
            else
            { this.physics = "1"; }
            
            if (fuckingCodes[7].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.chemistry = null; }
            else
            { this.chemistry = "1"; }

            if (fuckingCodes[8].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.biology = null; }
            else
            { this.biology = "1"; }

            if (fuckingCodes[9].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.psychology = null; }
            else
            { this.psychology = "1"; }

            if (fuckingCodes[10].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.enterpreneurship = null; }
            else
            { this.enterpreneurship = "1"; }

            if (fuckingCodes[11].ToString().Trim() == "" || fuckingCodes[5].ToString().Trim() == null)
            { this.informationT = null; }
            else
            { this.informationT = "1"; }
            return this;
        }
    }
}
