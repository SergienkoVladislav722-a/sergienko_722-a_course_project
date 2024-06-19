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
            infoLabel.Text = "������� ���� � �����:";
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
            MessageBox.Show("������ 25 ������", "�����");
            tClock.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MajorObject = new MajorWork();
            MajorObject.SetTime();
            MajorObject.Modify = false;// �������� ������
            About A = new About(); // ��������� ����� About
            A.tAbout.Start();
            A.ShowDialog();
            this.Mode = true;

            toolTip1.SetToolTip(bSearch, "�������� �� ������ ��� ������");
            toolTip1.IsBalloon = true;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                tblnput.Enabled = true;
                tblnput.Focus();
                tClock.Start();
                bStart.Text = "����"; // ���� ������ �� ������ �� "����"
                this.Mode = false;
                ����ToolStripMenuItem.Text = "����";
            }
            else
            {
                tblnput.Enabled = false;
                tClock.Stop();
                bStart.Text = "����";// ���� ������ �� ������ �� "����"
                this.Mode = true;
                MajorObject.Write(tblnput.Text);
                MajorObject.Task();
                label1.Text = MajorObject.Read();
                ����ToolStripMenuItem.Text = "�����";
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
                MessageBox.Show("������������ ������", "�������");
                tClock.Start();
                e.KeyChar = (char)0;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string s;
            s = (System.DateTime.Now - MajorObject.GetTime()).ToString();
            MessageBox.Show(s, "��� ������ ��������");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajorObject.NewRec();
            tblnput.Clear();// �������� ���� ������
            label1.Text = "";
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About A = new About();
            A.progressBar1.Hide();
            A.ShowDialog();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                MajorObject.WriteSaveFileName(sfdSave.FileName);
                MajorObject.Generator();
                MajorObject.SaveToFile();
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                MajorObject.WriteOpenFileName(ofdOpen.FileName);
                MajorObject.ReadFromFile(dgwOpen);
            }
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
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
                    disk += Disks[i] + "- �� �������" + (char)13;

                }
            }

            MessageBox.Show(disk, "������������");
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MajorObject.SaveFileNameExists()) // ������ ��� ����� ����?
                MajorObject.SaveToFile(); // �������� ��� � ����
            else
                ����������ToolStripMenuItem_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MajorObject.Modify)
                if (MessageBox.Show("��� �� ���� ��������. ���������� �����?", "�����",
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
