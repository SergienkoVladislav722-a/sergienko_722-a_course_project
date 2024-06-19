namespace sergienko_722_a_course_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            bStart = new Button();
            tblnput = new TextBox();
            tClock = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новийToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem1 = new ToolStripMenuItem();
            роботаToolStripMenuItem = new ToolStripMenuItem();
            пускToolStripMenuItem = new ToolStripMenuItem();
            проНакопичувачіToolStripMenuItem = new ToolStripMenuItem();
            довідкаToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            sfdSave = new SaveFileDialog();
            ofdOpen = new OpenFileDialog();
            dgwOpen = new DataGridView();
            bSearch = new Button();
            tbSearch = new TextBox();
            toolTip1 = new ToolTip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            statusStrip1 = new StatusStrip();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            splitContainer1 = new SplitContainer();
            StackText = new Label();
            LabelStack = new Label();
            Stacktb = new TextBox();
            Peek = new Button();
            Pop = new Button();
            Push = new Button();
            QueueText = new Label();
            LabelQueue = new Label();
            Queuetb = new TextBox();
            Peek_q = new Button();
            Dequeue = new Button();
            Enqueue = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOpen).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 28);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // bStart
            // 
            bStart.Location = new Point(302, 121);
            bStart.Name = "bStart";
            bStart.Size = new Size(108, 30);
            bStart.TabIndex = 1;
            bStart.Text = "Пуск";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // tblnput
            // 
            tblnput.Enabled = false;
            tblnput.Location = new Point(219, 75);
            tblnput.Name = "tblnput";
            tblnput.Size = new Size(282, 23);
            tblnput.TabIndex = 2;
            tblnput.KeyPress += tblnput_KeyPress;
            // 
            // tClock
            // 
            tClock.Interval = 25000;
            tClock.Tick += tClock_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, роботаToolStripMenuItem, довідкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новийToolStripMenuItem, toolStripSeparator1, відкритиToolStripMenuItem, toolStripSeparator2, зберегтиToolStripMenuItem, зберегтиЯкToolStripMenuItem, toolStripSeparator3, вихідToolStripMenuItem, файлToolStripMenuItem1 });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(51, 20);
            файлToolStripMenuItem.Text = "Файл ";
            // 
            // новийToolStripMenuItem
            // 
            новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            новийToolStripMenuItem.ShortcutKeys = Keys.F9;
            новийToolStripMenuItem.Size = new Size(170, 22);
            новийToolStripMenuItem.Text = "Новий";
            новийToolStripMenuItem.Click += новийToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(167, 6);
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.ShortcutKeys = Keys.F10;
            відкритиToolStripMenuItem.Size = new Size(170, 22);
            відкритиToolStripMenuItem.Text = "Відкрити";
            відкритиToolStripMenuItem.Click += відкритиToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(167, 6);
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.ShortcutKeys = Keys.F11;
            зберегтиToolStripMenuItem.Size = new Size(170, 22);
            зберегтиToolStripMenuItem.Text = "Зберегти ";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            зберегтиЯкToolStripMenuItem.ShortcutKeys = Keys.F12;
            зберегтиЯкToolStripMenuItem.Size = new Size(170, 22);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як..";
            зберегтиЯкToolStripMenuItem.Click += зберегтиЯкToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(167, 6);
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.ShortcutKeys = Keys.F8;
            вихідToolStripMenuItem.Size = new Size(170, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // файлToolStripMenuItem1
            // 
            файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            файлToolStripMenuItem1.Size = new Size(170, 22);
            файлToolStripMenuItem1.Text = "Файл ";
            // 
            // роботаToolStripMenuItem
            // 
            роботаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пускToolStripMenuItem, проНакопичувачіToolStripMenuItem });
            роботаToolStripMenuItem.Name = "роботаToolStripMenuItem";
            роботаToolStripMenuItem.Size = new Size(58, 20);
            роботаToolStripMenuItem.Text = "Робота";
            // 
            // пускToolStripMenuItem
            // 
            пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            пускToolStripMenuItem.ShortcutKeys = Keys.F4;
            пускToolStripMenuItem.Size = new Size(178, 22);
            пускToolStripMenuItem.Text = "Пуск";
            пускToolStripMenuItem.Click += bStart_Click;
            // 
            // проНакопичувачіToolStripMenuItem
            // 
            проНакопичувачіToolStripMenuItem.Name = "проНакопичувачіToolStripMenuItem";
            проНакопичувачіToolStripMenuItem.Size = new Size(178, 22);
            проНакопичувачіToolStripMenuItem.Text = "Про накопичувачі ";
            проНакопичувачіToolStripMenuItem.Click += проНакопичувачіToolStripMenuItem_Click;
            // 
            // довідкаToolStripMenuItem
            // 
            довідкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { проПрограмуToolStripMenuItem });
            довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            довідкаToolStripMenuItem.Size = new Size(61, 20);
            довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(154, 22);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            проПрограмуToolStripMenuItem.Click += проПрограмуToolStripMenuItem_Click;
            // 
            // sfdSave
            // 
            sfdSave.DefaultExt = "Mos";
            sfdSave.Filter = "рабочие файли|*.Mos|Все файли|*.*";
            // 
            // ofdOpen
            // 
            ofdOpen.DefaultExt = "Mos";
            ofdOpen.FileName = "openFileDialog1";
            ofdOpen.Filter = "рабочие файли|*.Mos|Все файли|*.*";
            ofdOpen.FileOk += ofdOpen_FileOk;
            // 
            // dgwOpen
            // 
            dgwOpen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOpen.Location = new Point(0, 343);
            dgwOpen.Name = "dgwOpen";
            dgwOpen.RowTemplate.Height = 25;
            dgwOpen.Size = new Size(10, 12);
            dgwOpen.TabIndex = 4;
            // 
            // bSearch
            // 
            bSearch.Location = new Point(654, 71);
            bSearch.Name = "bSearch";
            bSearch.Size = new Size(75, 23);
            bSearch.TabIndex = 5;
            bSearch.Text = "Пошук";
            bSearch.UseVisualStyleBackColor = true;
            bSearch.Click += bSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(617, 109);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(146, 23);
            tbSearch.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(788, 411);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(dgwOpen);
            tabPage1.Controls.Add(statusStrip1);
            tabPage1.Controls.Add(bStart);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tblnput);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(780, 383);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ведення даних";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(3, 358);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(774, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(780, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Робота з файлами";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(780, 383);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Стек/Черга";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LightGray;
            splitContainer1.Panel1.Controls.Add(StackText);
            splitContainer1.Panel1.Controls.Add(LabelStack);
            splitContainer1.Panel1.Controls.Add(Stacktb);
            splitContainer1.Panel1.Controls.Add(Peek);
            splitContainer1.Panel1.Controls.Add(Pop);
            splitContainer1.Panel1.Controls.Add(Push);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Silver;
            splitContainer1.Panel2.Controls.Add(QueueText);
            splitContainer1.Panel2.Controls.Add(LabelQueue);
            splitContainer1.Panel2.Controls.Add(Queuetb);
            splitContainer1.Panel2.Controls.Add(Peek_q);
            splitContainer1.Panel2.Controls.Add(Dequeue);
            splitContainer1.Panel2.Controls.Add(Enqueue);
            splitContainer1.Size = new Size(780, 383);
            splitContainer1.SplitterDistance = 372;
            splitContainer1.TabIndex = 0;
            // 
            // StackText
            // 
            StackText.AutoSize = true;
            StackText.Location = new Point(158, 303);
            StackText.Name = "StackText";
            StackText.Size = new Size(38, 15);
            StackText.TabIndex = 5;
            StackText.Text = "label3";
            // 
            // LabelStack
            // 
            LabelStack.AutoSize = true;
            LabelStack.Location = new Point(158, 43);
            LabelStack.Name = "LabelStack";
            LabelStack.Size = new Size(32, 15);
            LabelStack.TabIndex = 4;
            LabelStack.Text = "Стек";
            // 
            // Stacktb
            // 
            Stacktb.Location = new Point(121, 96);
            Stacktb.Name = "Stacktb";
            Stacktb.Size = new Size(100, 23);
            Stacktb.TabIndex = 3;
            // 
            // Peek
            // 
            Peek.Location = new Point(254, 180);
            Peek.Name = "Peek";
            Peek.Size = new Size(75, 23);
            Peek.TabIndex = 2;
            Peek.Text = "Peek";
            Peek.UseVisualStyleBackColor = true;
            Peek.Click += Peek_Click;
            // 
            // Pop
            // 
            Pop.Location = new Point(136, 180);
            Pop.Name = "Pop";
            Pop.Size = new Size(75, 23);
            Pop.TabIndex = 1;
            Pop.Text = "Pop";
            Pop.UseVisualStyleBackColor = true;
            Pop.Click += Pop_Click;
            // 
            // Push
            // 
            Push.Location = new Point(20, 180);
            Push.Name = "Push";
            Push.Size = new Size(75, 23);
            Push.TabIndex = 0;
            Push.Text = "Push";
            Push.UseVisualStyleBackColor = true;
            Push.Click += Push_Click;
            // 
            // QueueText
            // 
            QueueText.AutoSize = true;
            QueueText.Location = new Point(179, 303);
            QueueText.Name = "QueueText";
            QueueText.Size = new Size(38, 15);
            QueueText.TabIndex = 5;
            QueueText.Text = "label3";
            // 
            // LabelQueue
            // 
            LabelQueue.AutoSize = true;
            LabelQueue.Location = new Point(179, 43);
            LabelQueue.Name = "LabelQueue";
            LabelQueue.Size = new Size(39, 15);
            LabelQueue.TabIndex = 4;
            LabelQueue.Text = "Черга";
            // 
            // Queuetb
            // 
            Queuetb.Location = new Point(150, 96);
            Queuetb.Name = "Queuetb";
            Queuetb.Size = new Size(100, 23);
            Queuetb.TabIndex = 3;
            // 
            // Peek_q
            // 
            Peek_q.Location = new Point(296, 180);
            Peek_q.Name = "Peek_q";
            Peek_q.Size = new Size(75, 23);
            Peek_q.TabIndex = 2;
            Peek_q.Text = "Peek_q";
            Peek_q.UseVisualStyleBackColor = true;
            Peek_q.Click += Peek_q_Click;
            // 
            // Dequeue
            // 
            Dequeue.Location = new Point(166, 180);
            Dequeue.Name = "Dequeue";
            Dequeue.Size = new Size(75, 23);
            Dequeue.TabIndex = 1;
            Dequeue.Text = "Dequeue";
            Dequeue.UseVisualStyleBackColor = true;
            Dequeue.Click += Dequeue_Click;
            // 
            // Enqueue
            // 
            Enqueue.Location = new Point(45, 180);
            Enqueue.Name = "Enqueue";
            Enqueue.Size = new Size(75, 23);
            Enqueue.TabIndex = 0;
            Enqueue.Text = "Enqueue";
            Enqueue.UseVisualStyleBackColor = true;
            Enqueue.Click += Enqueue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(tbSearch);
            Controls.Add(menuStrip1);
            Controls.Add(bSearch);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOpen).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bStart;
        private TextBox tblnput;
        private System.Windows.Forms.Timer tClock;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem новийToolStripMenuItem;
        private ToolStripMenuItem роботаToolStripMenuItem;
        private ToolStripMenuItem довідкаToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem пускToolStripMenuItem;
        private ToolStripMenuItem проНакопичувачіToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private SaveFileDialog sfdSave;
        private OpenFileDialog ofdOpen;
        private ToolStripMenuItem файлToolStripMenuItem1;
        private DataGridView dgwOpen;
        private Button bSearch;
        private TextBox tbSearch;
        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private StatusStrip statusStrip1;
        private TabPage tabPage3;
        private SplitContainer splitContainer1;
        private Label StackText;
        private Label LabelStack;
        private TextBox Stacktb;
        private Button Peek;
        private Button Pop;
        private Button Push;
        private Button Peek_q;
        private Button Dequeue;
        private Button Enqueue;
        private Label QueueText;
        private Label LabelQueue;
        private TextBox Queuetb;
    }
}
