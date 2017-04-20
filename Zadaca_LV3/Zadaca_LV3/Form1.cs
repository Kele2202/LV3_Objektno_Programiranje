using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_LV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bFont_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                rtbText.SelectionFont = font;
            }
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                rtbText.SelectionColor = color;
            }
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files|*.txt*|All Files|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(File.OpenRead(openFile.FileName));
                rtbText.Text = null;
                rtbText.Text += stream.ReadToEnd();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files|*.txt*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(saveFile.FileName);
                stream.Write(rtbText.Text);
                stream.Close();
            }

        }
    }
}
