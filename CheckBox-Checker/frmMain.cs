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
            foreach (var row in thisDataGrid)
            {
                if(row[0].ToString().Trim() == "G.R No." || row[0].ToString().Trim() == "")
                {

                }
                else
                {
                    StudentSubjects currentStudent = new StudentSubjects();
                    currentStudent.studSubGrade6(row);
                    string elementID = "sub" + currentStudent.studID;
                    HtmlElementCollection fuckingIndiansDontKnowHowToUsIDasIndex = mainBrowserControl.Document.GetElementsByTagName("input");
                    HtmlElementCollection indiansDontKnowHowToUseIDasIndex = fuckingIndiansDontKnowHowToUsIDasIndex.GetElementsByName(elementID);
                    foreach(HtmlElement checkbox in indiansDontKnowHowToUseIDasIndex)
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
                            case "113$0":
                                checkbox.SetAttribute("checked", currentStudent.science);
                                break;
                        }
                    }

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
    }
}
