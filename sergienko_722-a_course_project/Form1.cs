using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace sergienko_722_a_course_project
{
    public partial class Form1 : Form
    {
        private bool Mode;
        private MajorWork MajorObject;

        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;
        
        public Form1()
        {
            InitializeComponent();
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Òåêóùèå äàòà è âðåìÿ:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            tClock.Stop();
            MessageBox.Show("Ìèíóëî 25 ñåêóíä", "Óâàãà");
            tClock.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MajorObject = new MajorWork();
            MajorObject.SetTime();
            MajorObject.Modify = false;// çàáîðîíà çàïèñó
            About A = new About(); // ñòâîðåííÿ ôîðìè About
            A.tAbout.Start();
            A.ShowDialog();
            this.Mode = true;

            toolTip1.SetToolTip(bSearch, "Íàòèñí³òü íà êíîïêó äëÿ ïîøóêó");
            toolTip1.IsBalloon = true;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                tblnput.Enabled = true;
                tblnput.Focus();
                tClock.Start();
                bStart.Text = "Ñòîï"; // çì³íà òåêñòó íà êíîïö³ íà "Ñòîï"
                this.Mode = false;
                ïóñêToolStripMenuItem.Text = "Ñòîï";
            }
            else
            {
                tblnput.Enabled = false;
                tClock.Stop();
                bStart.Text = "Ïóñê";// çì³íà òåêñòó íà êíîïö³ íà "Ïóñê"
                this.Mode = true;
                MajorObject.Write(tblnput.Text);
                MajorObject.Task();
                label1.Text = MajorObject.Read();
                ïóñêToolStripMenuItem.Text = "Ñòàðò";
            }
        }


        private void tblnput_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();
            if ((e.KeyChar >= '0') & (e.KeyChar <= '9') | (e.KeyChar == (char)8))
            {
                return;
            }
            else
            {
                tClock.Stop();
                MessageBox.Show("Íåïðàâèëüíèé ñèìâîë", "Ïîìèëêà");
                tClock.Start();
                e.KeyChar = (char)0;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string s;
            s = (System.DateTime.Now - MajorObject.GetTime()).ToString();
            MessageBox.Show(s, "×àñ ðîáîòè ïðîãðàìè");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void íîâèéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajorObject.NewRec();
            tblnput.Clear();// î÷èñòèòè âì³ñò òåêñòó
            label1.Text = "";
        }

        private void âèõ³äToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ïðîÏðîãðàìóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About A = new About();
            A.progressBar1.Hide();
            A.ShowDialog();
        }

        private void çáåðåãòèßêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                MajorObject.WriteSaveFileName(sfdSave.FileName);
                MajorObject.Generator();
                MajorObject.SaveToFile();
            }
        }

        private void â³äêðèòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                MajorObject.WriteOpenFileName(ofdOpen.FileName);
                MajorObject.ReadFromFile(dgwOpen);
            }
        }

        private void ïðîÍàêîïè÷óâà÷³ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] Disks = System.IO.Directory.GetLogicalDrives();
            string disk = "";
            for (int i = 0; i < Disks.Length; i++)
            {
                try
                {
                    System.IO.DriveInfo D = new System.IO.DriveInfo(Disks[i]);
                    disk += D.Name + "-" + D.TotalSize.ToString() + "-" + D.TotalFreeSpace.ToString()
                    + (char)13;

                }
                catch
                {
                    disk += Disks[i] + "- íå ãîòîâèé" + (char)13;

                }
            }

            MessageBox.Show(disk, "Íàêîïè÷óâà÷³");
        }

        private void çáåðåãòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MajorObject.SaveFileNameExists()) // çàäàíå ³ì’ÿ ôàéëó ³ñíóº?
                MajorObject.SaveToFile(); // çáåðåãòè äàí³ â ôàéë
            else
                çáåðåãòèßêToolStripMenuItem_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MajorObject.Modify)
                if (MessageBox.Show("Äàí³ íå áóëè çáåðåæåí³. Ïðîäîâæèòè âèõ³ä?", "ÓÂÀÃÀ",
               MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            MajorObject.Find(tbSearch.Text);
        }

        private void ofdOpen_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
