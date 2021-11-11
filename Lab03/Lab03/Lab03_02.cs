using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Lab03_02 : Form
    {
        public Lab03_02()
        {
            InitializeComponent();

        }

        public string path = string.Empty;
        private void newVanBan()
        {
            richTextBox1.Clear();
            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
            tsbFont.SelectedItem = "14";
            tsbSiZe.SelectedItem = "Tahoma";
            path = string.Empty;
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontDialog fontDig = new FontDialog();
            fontDig.ShowColor = true;
            fontDig.ShowApply = true;
            fontDig.ShowEffects = true;
            fontDig.ShowHelp = true;
            {
                richTextBox1.ForeColor = fontDig.Color;
                richTextBox1.Font = fontDig.Font;
            }
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.CheckPathExists = true;
            saveFile.DefaultExt = "rtf";
            saveFile.Filter = "Richtext files| *.rtf";
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Luu file thanh cong - " + saveFile.FileName, "Thong bao");
            }
        }

        private void MenuMoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "RTF File | *.rtf| Text file | *.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText);
                path = dlg.FileName;
            }
        }

        private void btBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
            }
        }

        private void btItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
            }
        }

        private void btUnder_Click(object sender, EventArgs e)
        {
                if (richTextBox1.SelectionFont.Underline)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
                }
        }
        private void tsbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(tsbFont.Text, float.Parse(tsbSiZe.Text));
        }

        private void MenuTaoVBMoi_Click(object sender, EventArgs e)
        {
            newVanBan();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            newVanBan();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path.Trim());
                writer.WriteLine(richTextBox1.Text);
                writer.Close();
                MessageBox.Show("Đã lưu thành công.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Lab03_02_Load(object sender, EventArgs e)
        {
        }

        private void tsbSiZe_SelectedIndexChanged(object sender, EventArgs e)
        {
           richTextBox1.SelectionFont = new Font(tsbFont.Text, float.Parse(tsbSiZe.Text));
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tsbFont_Click(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                tsbFont.Items.Add(font.Name);
            }
        }
    }
}
