using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }
        
        string path;
        TextEditor TE = new TextEditor();
        private void NewTab_Click(object sender, EventArgs e)
        {
            Notepad NewNot = new Notepad();
            NewNot.Show();
        }

        private void FontColer_Click(object sender, EventArgs e)
        {
            if (TextColor.ShowDialog() == DialogResult.OK)
            {
                NotepadText.ForeColor = TextColor.Color;
            }
        }

        private void FontFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                NotepadText.Font = fontDialog1.Font;
            }
        }

        private void BackColer_Click(object sender, EventArgs e)
        {
            if (BackColor.ShowDialog() == DialogResult.OK)
            {
                NotepadText.BackColor = BackColor.Color;
            }

        }

        private void WordWrap_Click(object sender, EventArgs e)
        {
            if (NotepadText.WordWrap == true)
            {
                NotepadText.WordWrap = false;
                WordWrap.Text = "Off";
            }
            else
            {
                NotepadText.WordWrap = true;
                WordWrap.Text = "On";
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            if (Researtch.Text != "")
            {
                NotepadText.SelectAll();
                NotepadText.SelectionBackColor = NotepadText.BackColor;
                int countText = 0;
                string WordSeartch = Researtch.Text;
                for (int i = 0; i < NotepadText.Text.Length - WordSeartch.Length; i++)
                {
                    if (string.Compare(WordSeartch, NotepadText.Text.Substring(i, WordSeartch.Length), true) == 0)
                    {
                        countText++;
                        NotepadText.SelectionStart = i;
                        NotepadText.SelectionLength = WordSeartch.Length;
                        if (NotepadText.BackColor == Color.Gray)
                            NotepadText.SelectionBackColor = Color.Wheat;
                        else
                            NotepadText.SelectionBackColor = Color.Gray;

                    }
                }
                Resulat.Text = "  " + countText.ToString();
            }
        }


        private void NotepadText_DoubleClick(object sender, EventArgs e)
        {
            NotepadText.SelectAll();
            NotepadText.SelectionBackColor = NotepadText.BackColor;
            Resulat.Text = "";
            Researtch.Text = "";
        }

        private void Researtch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Researtch.Text != "")
                {
                    NotepadText.SelectAll();
                    NotepadText.SelectionBackColor = NotepadText.BackColor;
                    int countText = 0;
                    string WordSeartch = Researtch.Text;
                    for (int i = 0; i < NotepadText.Text.Length - WordSeartch.Length; i++)
                    {
                        if (string.Compare(WordSeartch, NotepadText.Text.Substring(i, WordSeartch.Length), true) == 0)
                        {
                            countText++;
                            NotepadText.SelectionStart = i;
                            NotepadText.SelectionLength = WordSeartch.Length;
                            if (NotepadText.BackColor == Color.Gray)
                                NotepadText.SelectionBackColor = Color.Wheat;
                            else
                                NotepadText.SelectionBackColor = Color.Gray;

                        }
                    }
                    Resulat.Text = "  " + countText.ToString();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Researtch.Text != "" && Replace.Text != "")
            {
                int countText = 0;
                string WordSeartch = Researtch.Text;
                for (int i = 0; i < NotepadText.Text.Length - WordSeartch.Length; i++)
                {
                    if (string.Compare(WordSeartch, NotepadText.Text.Substring(i, WordSeartch.Length), true) == 0)
                    {
                        countText++;
                        NotepadText.SelectionStart = i;
                        NotepadText.SelectionLength = WordSeartch.Length;
                        NotepadText.SelectedText = Replace.Text;

                    }
                }
                Resulat.Text = "  " + countText.ToString();
            }
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            NotepadText.ForeColor = Properties.Settings.Default.TextColorSave;
            NotepadText.BackColor = Properties.Settings.Default.BackColorSave;
            NotepadText.Font = Properties.Settings.Default.TextFontSave;
            this.Size = Properties.Settings.Default.AppSizeSave;
            NotepadText.WordWrap = Properties.Settings.Default.WordWrapSave;
            WordWrap.Text = Properties.Settings.Default.TextWordSave;
            Properties.Settings.Default.Save();
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.TextColorSave = NotepadText.ForeColor;
            Properties.Settings.Default.BackColorSave = NotepadText.BackColor;
            Properties.Settings.Default.TextFontSave = NotepadText.Font;
            Properties.Settings.Default.AppSizeSave = this.Size;
            Properties.Settings.Default.WordWrapSave = NotepadText.WordWrap;
            Properties.Settings.Default.TextWordSave = WordWrap.Text;
            Properties.Settings.Default.Save();

            if (NotepadText.Text.Length != 0)
            {
                DialogResult s = MessageBox.Show("Do You Want Save File?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (s == DialogResult.Yes)
                {
                    SaveText.Filter = "All(*.mash)|*.mash";
                    SaveText.ShowDialog();
                }
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenText.Filter = "All(*.txt;*.mash)|*.txt;*.mash";
            if (OpenText.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (OpenText.FileName.EndsWith(".txt"))
                {
                    StreamReader file = new StreamReader(OpenText.FileName);
                    NotepadText.Text = file.ReadToEnd();
                    file.Close();
                }
                else
                {
                    StreamReader Opentxt = new StreamReader(OpenText.FileName);
                    string st = "";
                    while (!Opentxt.EndOfStream)
                    {
                        st += Opentxt.ReadLine();
                    }
                    Opentxt.Close();
                    NotepadText.Text = st;
                    NotepadText.LoadFile(OpenText.FileName);
                    path = OpenText.FileName;
                }
            }
        }

        private void OpenText_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveText.Filter = "All(*.mash)|*.mash";
            SaveText.ShowDialog();
        }

        private void SaveText_FileOk(object sender, CancelEventArgs e)
        {
            NotepadText.SaveFile(SaveText.FileName);
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            if (NotepadText.Text.Length == 0)
                NotepadText.Text = "";
            else
            {
                DialogResult s = MessageBox.Show("Do You Want Save File?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (s == DialogResult.Yes)
                {
                    SaveText.Filter = "All(*.mash)|*.mash";
                    SaveText.ShowDialog();
                    NotepadText.Text = "";
                }
                else
                    NotepadText.Text = "";
            }
        }

        private void NotepadText_TextChanged(object sender, EventArgs e)
        {
            if (NotepadText.Text.Length == 0)
            {
                Copy.Enabled = false;
                Cut.Enabled = false;
            }
            else
            {
                Copy.Enabled = true;
                Cut.Enabled = true;
            }
        }

        private void Past_Click(object sender, EventArgs e)
        {
            NotepadText.Paste();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            NotepadText.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            NotepadText.Copy();
        }

        private void Selectall_Click(object sender, EventArgs e)
        {
            NotepadText.SelectAll();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            NotepadText.Text = "";
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            NotepadText.Undo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TE.ShowDialog();
        }

        private void Replace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                toolStripButton1_Click(null, null);
            }
        }


    }
}
