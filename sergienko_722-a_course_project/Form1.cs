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
            MessageBox.Show("Минуло 25 секунд", "Увага");
            tClock.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            About A = new About(); // створення форми About
            A.tAbout.Start();
            A.ShowDialog();
            MajorObject = new MajorWork();
            this.Mode = true;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                tblnput.Enabled = true;
                tblnput.Focus();
                tClock.Start();
                bStart.Text = "Стоп"; // зміна тексту на кнопці на "Стоп"
                this.Mode = false;
            }
            else
            {
                tblnput.Enabled = false;
                tClock.Stop();
                bStart.Text = "Пуск";// зміна тексту на кнопці на "Пуск"
                this.Mode = true;
                MajorObject.Write(tblnput.Text);
                MajorObject.Task();
                label1.Text = MajorObject.Read();
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
                MessageBox.Show("Неправильний символ", "Помилка");
                tClock.Start();
                e.KeyChar = (char)0;
            }
        }
    }
}
