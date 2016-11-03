using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;

namespace CheckBox_Checker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            populateTheCBoxes();
        }

        void populateTheCBoxes()
        {
            Grades cmbGradeList = new Grades();
            cmbClass.DataSource = cmbGradeList.divisionList();
            cmbClass.DisplayMember = "Name";
            cmbClass.ValueMember = "Value";
            cmbSelectGrade.DataSource = cmbGradeList.gradeList();
            cmbSelectGrade.DisplayMember = "Name";
            cmbSelectGrade.ValueMember = "Value";
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog newOpenFile = new OpenFileDialog();

            newOpenFile.InitialDirectory = "c:\\";
            newOpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            newOpenFile.FilterIndex = 2;
            newOpenFile.RestoreDirectory = true;

            if (newOpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtDirectory.Text = newOpenFile.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (txtDirectory.Text == "")
            {
                MessageBox.Show("No File Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<List<string>> dataGrid = CsvFileReader.ReadAll(txtDirectory.Text, Encoding.GetEncoding("utf-8"));
                PlotTheData(dataGrid);
            }
        }

        private void PlotTheData(List<List<string>> thisDataGrid)
        {
            HtmlElementCollection fuckingIndiansDontKnowHowToUsIDasIndex = mainBrowserControl.Document.GetElementsByTagName("input");
            foreach (var row in thisDataGrid)
            {
                if (row[0].ToString().Trim() == "G.R No." || row[0].ToString().Trim() == "") { }
                else
                {
                    StudentSubjects currentStudent = new StudentSubjects();
                    string selectedClass = cmbSelectGrade.SelectedValue.ToString();
                    switch (selectedClass)
                    {
                        case "6":
                            tickGrade6(currentStudent.studSubGrade6(row), fuckingIndiansDontKnowHowToUsIDasIndex);
                            break;
                        case "7":
                            tickGrade7(currentStudent.stubSubGrade7(row), fuckingIndiansDontKnowHowToUsIDasIndex);
                            break;
                        case "8":
                            tickGrade8(currentStudent.stubSubGrade8(row), fuckingIndiansDontKnowHowToUsIDasIndex);
                            break;
                        case "9":
                            tickGrade9(currentStudent.stubSubGrade9(row), fuckingIndiansDontKnowHowToUsIDasIndex);
                            break;
                        case "10":
                            tickGrade10(currentStudent.stubSubGrade10(row), fuckingIndiansDontKnowHowToUsIDasIndex);
                            break;
                        case "11":
                            tickGrade11(currentStudent.stubSubGrade11(row), fuckingIndiansDontKnowHowToUsIDasIndex);
                            break;
                        case "12":
                            tickGrade12(currentStudent.stubSubGrade12(row), fuckingIndiansDontKnowHowToUsIDasIndex);
                            break;
                        default:
                            break;
                    }

                }
            }
        }

        private void tickGrade8(StudentSubjects currentStudent, HtmlElementCollection fuckingIndiansDontKnowHowToUsIDasIndex)
        {
            string elementID = "sub" + currentStudent.studID.ToString().Trim().Split()[0];
            HtmlElementCollection indiansDontKnowHowToUseIDasIndex = fuckingIndiansDontKnowHowToUsIDasIndex.GetElementsByName(elementID);
            foreach (HtmlElement checkbox in indiansDontKnowHowToUseIDasIndex)
            {
                switch (checkbox.GetAttribute("value").ToString().Trim())
                {
                    case "359$0":
                    case "230$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudUAEArab);
                        break;
                    case "443$0":
                        checkbox.SetAttribute("checked", currentStudent.enrichementEng);
                        break;
                    case "137$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdArab);
                        break;
                    case "284$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdNonArab);
                        break;
                    case "129$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageArab);
                        break;
                    case "283$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageNonArab);
                        break;
                    case "131$0":
                        checkbox.SetAttribute("checked", currentStudent.uaeCivics);
                        break;
                    case "135$0":
                        checkbox.SetAttribute("checked", currentStudent.uaeHistory);
                        break;
                    case "134$0":
                        checkbox.SetAttribute("checked", currentStudent.uaeGeo);
                        break;
                    case "190$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudUAENonArab);
                        break;
                    case "142$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudEnglish);
                        break;
                    case "136$0":
                        checkbox.SetAttribute("checked", currentStudent.informationT);
                        break;
                    case "133$0":
                        checkbox.SetAttribute("checked", currentStudent.frenchLang);
                        break;
                    case "139$0":
                        checkbox.SetAttribute("checked", currentStudent.musicEd);
                        break;
                    case "130$0":
                        checkbox.SetAttribute("checked", currentStudent.artEd);
                        break;
                    case "140$0":
                        checkbox.SetAttribute("checked", currentStudent.physicalEd);
                        break;
                    case "132$0":
                        checkbox.SetAttribute("checked", currentStudent.englishLang);
                        break;
                    case "138$0":
                        checkbox.SetAttribute("checked", currentStudent.mathematics);
                        break;
                    case "141$0":
                        checkbox.SetAttribute("checked", currentStudent.science);
                        break;
                    default:
                        checkbox.SetAttribute("checked", null);
                        break;
                }
            }
        }

        private void tickGrade7(StudentSubjects currentStudent, HtmlElementCollection fuckingIndiansDontKnowHowToUsIDasIndex)
        {
            string elementID = "sub" + currentStudent.studID;
            HtmlElementCollection indiansDontKnowHowToUseIDasIndex = fuckingIndiansDontKnowHowToUsIDasIndex.GetElementsByName(elementID);
            foreach (HtmlElement checkbox in indiansDontKnowHowToUseIDasIndex)
            {
                switch (checkbox.GetAttribute("value").ToString().Trim())
                {
                    case "281$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageNonArab);
                        break;
                    case "122$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdArab);
                        break;
                    case "282$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdNonArab);
                        break;
                    case "116$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageArab);
                        break;
                    case "128$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudUAEArab);
                        break;
                    case "191$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudUAENonArab);
                        break;
                    case "118$0":
                        checkbox.SetAttribute("checked", currentStudent.uaeCivics);
                        break;
                    case "127$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudEnglish);
                        break;
                    case "121$0":
                        checkbox.SetAttribute("checked", currentStudent.informationT);
                        break;
                    case "120$0":
                        checkbox.SetAttribute("checked", currentStudent.frenchLang);
                        break;
                    case "124$0":
                        checkbox.SetAttribute("checked", currentStudent.musicEd);
                        break;
                    case "117$0":
                        checkbox.SetAttribute("checked", currentStudent.artEd);
                        break;
                    case "125$0":
                        checkbox.SetAttribute("checked", currentStudent.physicalEd);
                        break;
                    case "119$0":
                        checkbox.SetAttribute("checked", currentStudent.englishLang);
                        break;
                    case "123$0":
                        checkbox.SetAttribute("checked", currentStudent.mathematics);
                        break;
                    case "126$0":
                        checkbox.SetAttribute("checked", currentStudent.science);
                        break;
                    default:
                        checkbox.SetAttribute("checked", null);
                        break;
                }
            }
        }

        private void tickGrade6(StudentSubjects currentStudent, HtmlElementCollection fuckingIndiansDontKnowHowToUsIDasIndex)
        {
            string elementID = "sub" + currentStudent.studID;
            HtmlElementCollection indiansDontKnowHowToUseIDasIndex = fuckingIndiansDontKnowHowToUsIDasIndex.GetElementsByName(elementID);
            foreach (HtmlElement checkbox in indiansDontKnowHowToUseIDasIndex)
            {
                switch (checkbox.GetAttribute("value").ToString().Trim())
                {
                    case "109$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdArab);
                        break;
                    case "280$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdNonArab);
                        break;
                    case "104$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageArab);
                        break;
                    case "274$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageNonArab);
                        break;
                    case "115$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudUAEArab);
                        break;
                    case "192$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudUAENonArab);
                        break;
                    case "114$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudEnglish);
                        break;
                    case "105$0":
                        checkbox.SetAttribute("checked", currentStudent.artEd);
                        break;
                    case "108$0":
                        checkbox.SetAttribute("checked", currentStudent.informationT);
                        break;
                    case "107$0":
                        checkbox.SetAttribute("checked", currentStudent.frenchLang);
                        break;
                    case "403$0":
                        checkbox.SetAttribute("checked", currentStudent.musicEd);
                        break;
                    case "106$0":
                        checkbox.SetAttribute("checked", currentStudent.englishLang);
                        break;
                    case "110$0":
                        checkbox.SetAttribute("checked", currentStudent.mathematics);
                        break;
                    case "112$0":
                        checkbox.SetAttribute("checked", currentStudent.physicalEd);
                        break;
                    case "113$0":
                        checkbox.SetAttribute("checked", currentStudent.science);
                        break;
                    default:
                        checkbox.SetAttribute("checked", null);
                        break;

                }
            }
        }

        private void tickGrade9(StudentSubjects currentStudent, HtmlElementCollection fuckingIndiansDontKnowHowToUsIDasIndex)
        {
            string elementID = "sub" + currentStudent.studID.ToString().Trim().Split()[0];
            HtmlElementCollection indiansDontKnowHowToUseIDasIndex = fuckingIndiansDontKnowHowToUsIDasIndex.GetElementsByName(elementID);
            foreach (HtmlElement checkbox in indiansDontKnowHowToUseIDasIndex)
            {
                switch (checkbox.GetAttribute("value").ToString().Trim())
                {
                    case "360$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudUAEArab);
                        break;
                    case "436$0":
                        checkbox.SetAttribute("checked", currentStudent.chemistry);
                        break;
                    case "437$0":
                        checkbox.SetAttribute("checked", currentStudent.biology);
                        break;
                    case "438$0":
                        checkbox.SetAttribute("checked", currentStudent.physics);
                        break;
                    case "150$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdArab);
                        break;
                    case "286$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdNonArab);
                        break;
                    case "143$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageArab);
                        break;
                    case "285$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageNonArab);
                        break;
                    case "145$0":
                        checkbox.SetAttribute("checked", currentStudent.uaeCivics);
                        break;
                    case "148$0":
                        checkbox.SetAttribute("checked", currentStudent.uaeHistory);
                        break;
                    case "147$0":
                        checkbox.SetAttribute("checked", currentStudent.uaeGeo);
                        break;
                    case "232$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudUAEArab);
                        break;
                    case "189$0":
                        checkbox.SetAttribute("checked", currentStudent.socialStudUAENonArab);
                        break;
                    case "146$0":
                        checkbox.SetAttribute("checked", currentStudent.englishLang);
                        break;
                    case "154$0":
                        checkbox.SetAttribute("checked", currentStudent.englishHistory);
                        break;
                    case "151$0":
                        checkbox.SetAttribute("checked", currentStudent.mathematics);
                        break;
                    case "153$0":
                        checkbox.SetAttribute("checked", currentStudent.science);
                        break;
                    case "149$0":
                        checkbox.SetAttribute("checked", currentStudent.informationT);
                        break;
                    case "152$0":
                        checkbox.SetAttribute("checked", currentStudent.physicalEd);
                        break;
                    case "440$0":
                        checkbox.SetAttribute("checked", currentStudent.englishHistory);
                        break;
                    default:
                        checkbox.SetAttribute("checked", null);
                        break;

                }
            }
        }

        private void tickGrade10(StudentSubjects currentStudent, HtmlElementCollection fuckingIndiansDontKnowHowToUsIDasIndex)
        {
            string elementID = "sub" + currentStudent.studID.ToString().Trim().Split()[0];
            HtmlElementCollection indiansDontKnowHowToUseIDasIndex = fuckingIndiansDontKnowHowToUsIDasIndex.GetElementsByName(elementID);
            foreach (HtmlElement checkbox in indiansDontKnowHowToUseIDasIndex)
            {
                switch (checkbox.GetAttribute("value").ToString().Trim())
                {
                    case "160$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdArab);
                        break;
                    case "290$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdNonArab);
                        break;
                    case "155$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageArab);
                        break;
                    case "289$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageNonArab);
                        break;
                    case "158$0":
                        checkbox.SetAttribute("checked", currentStudent.englishLang);
                        break;
                    case "161$0":
                        checkbox.SetAttribute("checked", currentStudent.mathematics);
                        break;
                    case "159$0":
                        checkbox.SetAttribute("checked", currentStudent.informationT);
                        break;
                    case "164$0":
                        checkbox.SetAttribute("checked", currentStudent.economics);
                        break;
                    case "162$0":
                        checkbox.SetAttribute("checked", currentStudent.physicalEd);
                        break;
                    case "163$0":
                        checkbox.SetAttribute("checked", currentStudent.physics);
                        break;
                    case "157$0":
                        checkbox.SetAttribute("checked", currentStudent.chemistry);
                        break;
                    case "156$0":
                        checkbox.SetAttribute("checked", currentStudent.biology);
                        break;
                    default:
                        checkbox.SetAttribute("checked", null);
                        break;
                }
            }
        }

        private void tickGrade11(StudentSubjects currentStudent, HtmlElementCollection fuckingIndiansDontKnowHowToUsIDasIndex)
        {
            string elementID = "sub" + currentStudent.studID.ToString().Trim().Split()[0];
            HtmlElementCollection indiansDontKnowHowToUseIDasIndex = fuckingIndiansDontKnowHowToUsIDasIndex.GetElementsByName(elementID);
            foreach (HtmlElement checkbox in indiansDontKnowHowToUseIDasIndex)
            {
                switch (checkbox.GetAttribute("value").ToString().Trim())
                {
                    case "442$0":
                        checkbox.SetAttribute("checked", currentStudent.finance);
                        break;
                    case "171$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdArab);
                        break;
                    case "294$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdNonArab);
                        break;
                    case "165$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageArab);
                        break;
                    case "293$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageNonArab);
                        break;
                    case "169$0":
                        checkbox.SetAttribute("checked", currentStudent.englishLang);
                        break;
                    case "172$0":
                        checkbox.SetAttribute("checked", currentStudent.mathematics);
                        break;
                    case "170$0":
                        checkbox.SetAttribute("checked", currentStudent.informationT);
                        break;
                    case "167$0":
                        checkbox.SetAttribute("checked", currentStudent.businessStudies);
                        break;
                    case "175$0":
                        checkbox.SetAttribute("checked", currentStudent.sociology);
                        break;
                    case "400$0":
                        checkbox.SetAttribute("checked", currentStudent.psychology);
                        break;
                    case "173$0":
                        checkbox.SetAttribute("checked", currentStudent.physicalEd);
                        break;
                    case "174$0":
                        checkbox.SetAttribute("checked", currentStudent.physics);
                        break;
                    case "168$0":
                        checkbox.SetAttribute("checked", currentStudent.chemistry);
                        break;
                    case "166$0":
                        checkbox.SetAttribute("checked", currentStudent.biology);
                        break;
                    default:
                        checkbox.SetAttribute("checked", null);
                        break;
                }
            }
        }

        private void tickGrade12(StudentSubjects currentStudent, HtmlElementCollection fuckingIndiansDontKnowHowToUsIDasIndex)
        {
            string elementID = "sub" + currentStudent.studID.ToString().Trim().Split()[0];
            HtmlElementCollection indiansDontKnowHowToUseIDasIndex = fuckingIndiansDontKnowHowToUsIDasIndex.GetElementsByName(elementID);
            foreach (HtmlElement checkbox in indiansDontKnowHowToUseIDasIndex)
            {
                switch (checkbox.GetAttribute("value").ToString().Trim())
                {
                    case "181$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdArab);
                        break;
                    case "298$0":
                        checkbox.SetAttribute("checked", currentStudent.islamicEdNonArab);
                        break;
                    case "176$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageArab);
                        break;
                    case "297$0":
                        checkbox.SetAttribute("checked", currentStudent.arabLanguageNonArab);
                        break;
                    case "179$0":
                        checkbox.SetAttribute("checked", currentStudent.englishLang);
                        break;
                    case "182$0":
                        checkbox.SetAttribute("checked", currentStudent.mathematics);                        break;
                    case "180$0":
                        checkbox.SetAttribute("checked", currentStudent.informationT);
                        break;
                    case "428$0":
                        checkbox.SetAttribute("checked", currentStudent.businessStudies);
                        break;
                    case "186$0":
                        checkbox.SetAttribute("checked", currentStudent.enterpreneurship);
                        break;
                    case "185$0":
                        checkbox.SetAttribute("checked", currentStudent.psychology);
                        break;
                    case "183$0":
                        checkbox.SetAttribute("checked", currentStudent.physicalEd);                        break;
                    case "184$0":
                        checkbox.SetAttribute("checked", currentStudent.physics);
                        break;
                    case "178$0":
                        checkbox.SetAttribute("checked", currentStudent.chemistry);
                        break;
                    case "177$0":
                        checkbox.SetAttribute("checked", currentStudent.biology);
                        break;
                    default:
                        checkbox.SetAttribute("checked", null);
                        break;
                }
            }
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            if(this.Text == "")
            {
                btnRun.Enabled = false;
            }
            else
            {
                btnRun.Enabled = true;
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
