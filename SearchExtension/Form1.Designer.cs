namespace SearchExtension
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lczas = new System.Windows.Forms.Label();
            this.cbWybranaOpcjaSprawdzania = new System.Windows.Forms.ComboBox();
            this.lMinuty = new System.Windows.Forms.Label();
            this.lWykonujCo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nUDCoIleMinut = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tBExtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bEditExt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBEditExt = new System.Windows.Forms.TextBox();
            this.bAddExt = new System.Windows.Forms.Button();
            this.bDeleteRecords = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.tBAddExt = new System.Windows.Forms.TextBox();
            this.cBGodzina = new System.Windows.Forms.ComboBox();
            this.cBMinuta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tBPath = new System.Windows.Forms.TextBox();
            this.cBSekunda = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.konfiguracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracjaKontaEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaEmailOdbiorcówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjaOAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikaUżytaWProjekcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bLoadPath = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bRun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIleMinut)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lczas);
            this.groupBox4.Location = new System.Drawing.Point(7, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 77);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktualny czas:";
            // 
            // lczas
            // 
            this.lczas.AutoSize = true;
            this.lczas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lczas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lczas.Location = new System.Drawing.Point(8, 28);
            this.lczas.Name = "lczas";
            this.lczas.Size = new System.Drawing.Size(79, 29);
            this.lczas.TabIndex = 8;
            this.lczas.Text = "label2";
            // 
            // cbWybranaOpcjaSprawdzania
            // 
            this.cbWybranaOpcjaSprawdzania.FormattingEnabled = true;
            this.cbWybranaOpcjaSprawdzania.Items.AddRange(new object[] {
            "O określonej godzinie",
            "Co określony czas"});
            this.cbWybranaOpcjaSprawdzania.Location = new System.Drawing.Point(6, 19);
            this.cbWybranaOpcjaSprawdzania.Name = "cbWybranaOpcjaSprawdzania";
            this.cbWybranaOpcjaSprawdzania.Size = new System.Drawing.Size(363, 21);
            this.cbWybranaOpcjaSprawdzania.TabIndex = 22;
            this.cbWybranaOpcjaSprawdzania.SelectedIndexChanged += new System.EventHandler(this.CbWybranaOpcjaSprawdzania_SelectedIndexChanged);
            // 
            // lMinuty
            // 
            this.lMinuty.AutoSize = true;
            this.lMinuty.Enabled = false;
            this.lMinuty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lMinuty.Location = new System.Drawing.Point(301, 106);
            this.lMinuty.Name = "lMinuty";
            this.lMinuty.Size = new System.Drawing.Size(33, 13);
            this.lMinuty.TabIndex = 21;
            this.lMinuty.Text = "Minut";
            // 
            // lWykonujCo
            // 
            this.lWykonujCo.AutoSize = true;
            this.lWykonujCo.Enabled = false;
            this.lWykonujCo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lWykonujCo.Location = new System.Drawing.Point(145, 104);
            this.lWykonujCo.Name = "lWykonujCo";
            this.lWykonujCo.Size = new System.Drawing.Size(67, 13);
            this.lWykonujCo.TabIndex = 20;
            this.lWykonujCo.Text = "Wykonuj co:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(301, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sekunda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(223, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Minuta:";
            // 
            // nUDCoIleMinut
            // 
            this.nUDCoIleMinut.Enabled = false;
            this.nUDCoIleMinut.Location = new System.Drawing.Point(229, 102);
            this.nUDCoIleMinut.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDCoIleMinut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCoIleMinut.Name = "nUDCoIleMinut";
            this.nUDCoIleMinut.Size = new System.Drawing.Size(62, 20);
            this.nUDCoIleMinut.TabIndex = 12;
            this.nUDCoIleMinut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(145, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Godzina:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.bDeleteRecords);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(390, 44);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(427, 254);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Menu szukania rozszerzeń plików";
            // 
            // tBExtId
            // 
            this.tBExtId.Enabled = false;
            this.tBExtId.Location = new System.Drawing.Point(34, 15);
            this.tBExtId.Name = "tBExtId";
            this.tBExtId.Size = new System.Drawing.Size(160, 20);
            this.tBExtId.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(9, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Id:";
            // 
            // bEditExt
            // 
            this.bEditExt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEditExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditExt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bEditExt.Location = new System.Drawing.Point(5, 67);
            this.bEditExt.Name = "bEditExt";
            this.bEditExt.Size = new System.Drawing.Size(189, 33);
            this.bEditExt.TabIndex = 37;
            this.bEditExt.Text = "Edytuj/Wpisz E-mail";
            this.bEditExt.UseVisualStyleBackColor = false;
            this.bEditExt.Click += new System.EventHandler(this.BEditExt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ext:";
            // 
            // tBEditExt
            // 
            this.tBEditExt.Enabled = false;
            this.tBEditExt.Location = new System.Drawing.Point(34, 41);
            this.tBEditExt.Name = "tBEditExt";
            this.tBEditExt.Size = new System.Drawing.Size(160, 20);
            this.tBEditExt.TabIndex = 35;
            this.tBEditExt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBEditExt_KeyDown);
            // 
            // bAddExt
            // 
            this.bAddExt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddExt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bAddExt.Location = new System.Drawing.Point(5, 45);
            this.bAddExt.Name = "bAddExt";
            this.bAddExt.Size = new System.Drawing.Size(189, 32);
            this.bAddExt.TabIndex = 34;
            this.bAddExt.Text = "Dodaj rozszerzenie";
            this.bAddExt.UseVisualStyleBackColor = false;
            this.bAddExt.Click += new System.EventHandler(this.BAddExt_Click);
            // 
            // bDeleteRecords
            // 
            this.bDeleteRecords.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDeleteRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteRecords.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bDeleteRecords.Location = new System.Drawing.Point(6, 214);
            this.bDeleteRecords.Name = "bDeleteRecords";
            this.bDeleteRecords.Size = new System.Drawing.Size(415, 34);
            this.bDeleteRecords.TabIndex = 26;
            this.bDeleteRecords.Text = "Usuń wszystkie rekordy";
            this.bDeleteRecords.UseVisualStyleBackColor = false;
            this.bDeleteRecords.Click += new System.EventHandler(this.BDeleteRecords_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(208, 190);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(4, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ext:";
            // 
            // tBAddExt
            // 
            this.tBAddExt.Location = new System.Drawing.Point(35, 17);
            this.tBAddExt.Name = "tBAddExt";
            this.tBAddExt.Size = new System.Drawing.Size(159, 20);
            this.tBAddExt.TabIndex = 29;
            this.tBAddExt.Text = "np: mp4";
            this.tBAddExt.Click += new System.EventHandler(this.TBAddExt_Click);
            this.tBAddExt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBAddExt_KeyDown);
            // 
            // cBGodzina
            // 
            this.cBGodzina.DisplayMember = "0";
            this.cBGodzina.DropDownHeight = 290;
            this.cBGodzina.Enabled = false;
            this.cBGodzina.FormattingEnabled = true;
            this.cBGodzina.IntegralHeight = false;
            this.cBGodzina.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cBGodzina.Location = new System.Drawing.Point(148, 66);
            this.cBGodzina.Name = "cBGodzina";
            this.cBGodzina.Size = new System.Drawing.Size(65, 21);
            this.cBGodzina.TabIndex = 14;
            // 
            // cBMinuta
            // 
            this.cBMinuta.DropDownHeight = 290;
            this.cBMinuta.Enabled = false;
            this.cBMinuta.FormattingEnabled = true;
            this.cBMinuta.IntegralHeight = false;
            this.cBMinuta.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cBMinuta.Location = new System.Drawing.Point(226, 66);
            this.cBMinuta.Name = "cBMinuta";
            this.cBMinuta.Size = new System.Drawing.Size(65, 21);
            this.cBMinuta.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(224, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Otwórz lokalizację:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(4, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ścieżka:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 108);
            this.listBox1.TabIndex = 1;
            // 
            // tBPath
            // 
            this.tBPath.Enabled = false;
            this.tBPath.Location = new System.Drawing.Point(6, 163);
            this.tBPath.Name = "tBPath";
            this.tBPath.Size = new System.Drawing.Size(313, 20);
            this.tBPath.TabIndex = 2;
            // 
            // cBSekunda
            // 
            this.cBSekunda.DropDownHeight = 290;
            this.cBSekunda.Enabled = false;
            this.cBSekunda.FormattingEnabled = true;
            this.cBSekunda.IntegralHeight = false;
            this.cBSekunda.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cBSekunda.Location = new System.Drawing.Point(304, 66);
            this.cBSekunda.Name = "cBSekunda";
            this.cBSekunda.Size = new System.Drawing.Size(65, 21);
            this.cBSekunda.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cbWybranaOpcjaSprawdzania);
            this.groupBox3.Controls.Add(this.lMinuty);
            this.groupBox3.Controls.Add(this.lWykonujCo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nUDCoIleMinut);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cBSekunda);
            this.groupBox3.Controls.Add(this.cBGodzina);
            this.groupBox3.Controls.Add(this.cBMinuta);
            this.groupBox3.Location = new System.Drawing.Point(4, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 132);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opcje - czas sprawdzania:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracjaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(821, 43);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // konfiguracjaToolStripMenuItem
            // 
            this.konfiguracjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracjaKontaEmailToolStripMenuItem,
            this.ListaEmailOdbiorcówToolStripMenuItem});
            this.konfiguracjaToolStripMenuItem.Image = global::SearchExtension.Properties.Resources.icons8_administrative_tools_35;
            this.konfiguracjaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.konfiguracjaToolStripMenuItem.Name = "konfiguracjaToolStripMenuItem";
            this.konfiguracjaToolStripMenuItem.Size = new System.Drawing.Size(85, 39);
            this.konfiguracjaToolStripMenuItem.Text = "Menu";
            // 
            // konfiguracjaKontaEmailToolStripMenuItem
            // 
            this.konfiguracjaKontaEmailToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.konfiguracjaKontaEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.konfiguracjaKontaEmailToolStripMenuItem.Name = "konfiguracjaKontaEmailToolStripMenuItem";
            this.konfiguracjaKontaEmailToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.konfiguracjaKontaEmailToolStripMenuItem.Text = "Konfiguracja konta E-mail - nadawca";
            this.konfiguracjaKontaEmailToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.konfiguracjaKontaEmailToolStripMenuItem.Click += new System.EventHandler(this.KonfiguracjaKontaEmailToolStripMenuItem_Click);
            // 
            // ListaEmailOdbiorcówToolStripMenuItem
            // 
            this.ListaEmailOdbiorcówToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ListaEmailOdbiorcówToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ListaEmailOdbiorcówToolStripMenuItem.Name = "ListaEmailOdbiorcówToolStripMenuItem";
            this.ListaEmailOdbiorcówToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.ListaEmailOdbiorcówToolStripMenuItem.Text = "Lista E-mail - odbiorcy";
            this.ListaEmailOdbiorcówToolStripMenuItem.Click += new System.EventHandler(this.ListaEmailOdbiorcówToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjaOAutorzeToolStripMenuItem,
            this.grafikaUżytaWProjekcieToolStripMenuItem});
            this.pomocToolStripMenuItem.Image = global::SearchExtension.Properties.Resources.icons8_information_35;
            this.pomocToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(111, 39);
            this.pomocToolStripMenuItem.Text = "Informacje";
            // 
            // informacjaOAutorzeToolStripMenuItem
            // 
            this.informacjaOAutorzeToolStripMenuItem.Name = "informacjaOAutorzeToolStripMenuItem";
            this.informacjaOAutorzeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.informacjaOAutorzeToolStripMenuItem.Text = "Informacja o autorze";
            this.informacjaOAutorzeToolStripMenuItem.Click += new System.EventHandler(this.InformacjaOAutorzeToolStripMenuItem_Click);
            // 
            // grafikaUżytaWProjekcieToolStripMenuItem
            // 
            this.grafikaUżytaWProjekcieToolStripMenuItem.Name = "grafikaUżytaWProjekcieToolStripMenuItem";
            this.grafikaUżytaWProjekcieToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.grafikaUżytaWProjekcieToolStripMenuItem.Text = "Grafika użyta w projekcie";
            this.grafikaUżytaWProjekcieToolStripMenuItem.Click += new System.EventHandler(this.GrafikaUżytaWProjekcieToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.tBPath);
            this.groupBox1.Controls.Add(this.bLoadPath);
            this.groupBox1.Location = new System.Drawing.Point(4, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 192);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podgląd listy profili:";
            // 
            // bLoadPath
            // 
            this.bLoadPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bLoadPath.BackgroundImage = global::SearchExtension.Properties.Resources.icons8_open_50_1_;
            this.bLoadPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLoadPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bLoadPath.Location = new System.Drawing.Point(324, 137);
            this.bLoadPath.Name = "bLoadPath";
            this.bLoadPath.Size = new System.Drawing.Size(49, 48);
            this.bLoadPath.TabIndex = 0;
            this.bLoadPath.UseVisualStyleBackColor = false;
            this.bLoadPath.Click += new System.EventHandler(this.BLoadPath_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(821, 22);
            this.statusStrip1.TabIndex = 45;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusLabel1.Text = "Status: Nie uruchomiony";
            // 
            // bRun
            // 
            this.bRun.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bRun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bRun.Location = new System.Drawing.Point(390, 303);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(427, 66);
            this.bRun.TabIndex = 46;
            this.bRun.Text = "Uruchom";
            this.bRun.UseVisualStyleBackColor = false;
            this.bRun.Click += new System.EventHandler(this.RRun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bAddExt);
            this.groupBox2.Controls.Add(this.tBAddExt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(220, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 84);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj rozszerzenie:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bEditExt);
            this.groupBox6.Controls.Add(this.tBExtId);
            this.groupBox6.Controls.Add(this.tBEditExt);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(221, 104);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 107);
            this.groupBox6.TabIndex = 50;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Edycja rozszerzenia:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(821, 395);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MD - Automatyczny monitoring danych - Rozszerzeń";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIleMinut)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lczas;
        private System.Windows.Forms.ComboBox cbWybranaOpcjaSprawdzania;
        private System.Windows.Forms.Label lMinuty;
        private System.Windows.Forms.Label lWykonujCo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUDCoIleMinut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tBExtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bEditExt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBEditExt;
        private System.Windows.Forms.Button bAddExt;
        private System.Windows.Forms.Button bDeleteRecords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBAddExt;
        private System.Windows.Forms.ComboBox cBGodzina;
        private System.Windows.Forms.ComboBox cBMinuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tBPath;
        private System.Windows.Forms.Button bLoadPath;
        private System.Windows.Forms.ComboBox cBSekunda;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaKontaEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListaEmailOdbiorcówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjaOAutorzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafikaUżytaWProjekcieToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

