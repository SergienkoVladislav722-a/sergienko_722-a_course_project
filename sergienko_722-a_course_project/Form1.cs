using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace sergienko_722_a_course_project
{
    public partial class Form1 : Form
    {
        private bool Mode;
        private MajorWork MajorObject;
        public Form1()
        {
            InitializeComponent();
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

        }

        private void âèõ³äToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ïðîÏðîãðàìóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About A = new About();
            A.ShowDialog();
        }

        private void çáåðåãòèßêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                MajorObject.WriteSaveFileName(sfdSave.FileName); 
                MajorObject.SaveToFile();
            }
        }

        private void â³äêðèòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ofdOpen.FileName);
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
    }
}
