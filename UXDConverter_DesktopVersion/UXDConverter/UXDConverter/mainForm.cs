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

namespace UXDConverter
{
    public partial class mainForm : Form
    {
        public string origin = "";
        public string owner = "";
        public StringBuilder sb = new StringBuilder();
        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "uxd files (*.uxd)|*.uxd|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            bool dataLine = false;
            sb = new StringBuilder();
            sb.AppendLine("##TITLE=Spectrum");
            sb.AppendLine("##JCAMP-DX=5.00 $$ c--- (0.1.0)");
            sb.AppendLine("##DATA TYPE=MASS SPECTRUM");
            sb.AppendLine("##DATA CLASS=NTUPLES");
            sb.AppendLine();
            sb.AppendLine("##ORIGIN= "+ origin);
            sb.AppendLine("##OWNER= "+owner);
            sb.AppendLine();
            List<double> X = new List<double>();
            List<double> Y = new List<double>();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadLines(dialog.FileName))
                {
                    if (line.StartsWith(";"))
                    {
                        if (line.Contains("Cnt2_D1"))
                        {
                            dataLine = true;
                            sb.AppendLine();
                            sb.AppendLine("##FIRSTX=");
                            sb.AppendLine("##LASTX=");
                            sb.AppendLine("##MINX=");
                            sb.AppendLine("##MAXX=");
                            sb.AppendLine("##MINY=");
                            sb.AppendLine("##MAXY=");
                            sb.AppendLine("##NPOINTS=");
                            sb.AppendLine("##FIRSTY=");
                            sb.AppendLine("##XUNITS=1/CM");
                            sb.AppendLine("##YUNITS=COUNTS");
                            sb.AppendLine("##XYPOINTS=(XY..XY)");
                        }
                        // commen line
                    }
                    else
                    {
                        if(dataLine)
                        {
                            int ix = line.IndexOf(" ");
                            if (ix== -1)
                                ix = line.IndexOf("\t");
                            double x = double.Parse(line.Substring(0, ix));
                            double y = double.Parse(line.Substring(ix + 1));
                            X.Add(x);
                            Y.Add(y);
                            sb.AppendLine(line);

                        }
                        else
                        {
                            if (line.StartsWith("_"))
                                sb.AppendLine("##" + line.Substring(1));
                        }
                    }
                }
                sb.AppendLine("##END=$$ End of the data block");
                sb.Replace("##FIRSTX=", string.Format("##FIRSTX={0:###.#####0}", X.First()));
                sb.Replace("##LASTX=", string.Format("##LASTX={0:###.#####0}", X.Last()));

                sb.Replace("##MINX=", string.Format("##MINX={0:###.#####0}", X.Min()));
                sb.Replace("##MAXX=", string.Format("##MAXX={0:###.#####0}", X.Max()));

                sb.Replace("##MINY=", string.Format("##MINY={0:###.#####0}", Y.Min()));
                sb.Replace("##MAXY=", string.Format("##MAXY={0:###.#####0}",Y.Max()));

                sb.Replace("##NPOINTS=", string.Format("##NPOINTS={0:####}",X.Count));
                sb.Replace("##FIRSTY=", string.Format("##FIRSTY={0:###.#####0}", Y.First()));

                textBox1.Text = sb.ToString();
                //File.WriteAllText(dialog.FileName, textBoxLeft.Text);
            }
            textBox1.Enabled = true;
            ribbonButtonSave.Enabled = true;

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string f = Application.StartupPath + "/settings.ini";
            if (File.Exists(f))
            {
                foreach (string line in File.ReadAllLines(f))
                {
                    if (line.StartsWith("#ORIGIN="))
                        origin = line.Substring(8);
                    if (line.StartsWith("#OWNER="))
                        owner = line.Substring(7);
                }
            }
        }

        private void ribbonButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ribbonButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "jdx files (*.jdx)|*.jdx|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, sb.ToString());
            }
        }

        private void mainRibbon_Click(object sender, EventArgs e)
        {

        }
    }
}
