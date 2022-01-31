namespace Diagnostic_Center
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.Totallist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            this.saveinvoicebutton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.delidate = new System.Windows.Forms.DateTimePicker();
            this.deldate = new System.Windows.Forms.Label();
            this.Patphone = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.patientName = new System.Windows.Forms.TextBox();
            this.refby = new System.Windows.Forms.ComboBox();
            this.Referedby = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.patientid = new System.Windows.Forms.ComboBox();
            this.PatName = new System.Windows.Forms.Label();
            this.Patid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testid = new System.Windows.Forms.Label();
            this.testname = new System.Windows.Forms.Label();
            this.TestNameBox = new System.Windows.Forms.TextBox();
            this.TestNameID = new System.Windows.Forms.ComboBox();
            this.Addtest = new System.Windows.Forms.Button();
            this.totalcost = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Totallist)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Totallist
            // 
            this.Totallist.BackgroundColor = System.Drawing.Color.White;
            this.Totallist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Totallist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Totallist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Totallist.Location = new System.Drawing.Point(177, 419);
            this.Totallist.Name = "Totallist";
            this.Totallist.ReadOnly = true;
            this.Totallist.RowTemplate.Height = 30;
            this.Totallist.RowTemplate.ReadOnly = true;
            this.Totallist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Totallist.Size = new System.Drawing.Size(746, 159);
            this.Totallist.TabIndex = 22;
            this.Totallist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Doctorslist_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cost";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(444, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 26);
            this.label14.TabIndex = 21;
            this.label14.Text = "Test List";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.PowderBlue;
            this.Print.Location = new System.Drawing.Point(507, 273);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 19;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // saveinvoicebutton
            // 
            this.saveinvoicebutton.BackColor = System.Drawing.Color.PowderBlue;
            this.saveinvoicebutton.Location = new System.Drawing.Point(396, 273);
            this.saveinvoicebutton.Name = "saveinvoicebutton";
            this.saveinvoicebutton.Size = new System.Drawing.Size(100, 23);
            this.saveinvoicebutton.TabIndex = 17;
            this.saveinvoicebutton.Text = "Save Invoice";
            this.saveinvoicebutton.UseVisualStyleBackColor = false;
            this.saveinvoicebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.delidate);
            this.panel4.Controls.Add(this.deldate);
            this.panel4.Controls.Add(this.Patphone);
            this.panel4.Controls.Add(this.phone);
            this.panel4.Controls.Add(this.patientName);
            this.panel4.Controls.Add(this.refby);
            this.panel4.Controls.Add(this.Referedby);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.patientid);
            this.panel4.Controls.Add(this.PatName);
            this.panel4.Controls.Add(this.Patid);
            this.panel4.Location = new System.Drawing.Point(177, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 215);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // delidate
            // 
            this.delidate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.delidate.Location = new System.Drawing.Point(415, 166);
            this.delidate.Name = "delidate";
            this.delidate.Size = new System.Drawing.Size(152, 20);
            this.delidate.TabIndex = 19;
            // 
            // deldate
            // 
            this.deldate.AutoSize = true;
            this.deldate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deldate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deldate.Location = new System.Drawing.Point(397, 133);
            this.deldate.Name = "deldate";
            this.deldate.Size = new System.Drawing.Size(97, 19);
            this.deldate.TabIndex = 18;
            this.deldate.Text = "Delivery Date";
            // 
            // Patphone
            // 
            this.Patphone.Enabled = false;
            this.Patphone.Location = new System.Drawing.Point(501, 98);
            this.Patphone.Name = "Patphone";
            this.Patphone.Size = new System.Drawing.Size(138, 20);
            this.Patphone.TabIndex = 17;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phone.Location = new System.Drawing.Point(497, 58);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(49, 19);
            this.phone.TabIndex = 16;
            this.phone.Text = "Phone";
            // 
            // patientName
            // 
            this.patientName.Enabled = false;
            this.patientName.Location = new System.Drawing.Point(314, 98);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(138, 20);
            this.patientName.TabIndex = 15;
            // 
            // refby
            // 
            this.refby.FormattingEnabled = true;
            this.refby.Items.AddRange(new object[] {
            "Cardiologist",
            "Allergist",
            "Dermotologist",
            "Neurologist",
            "Anesthesiologist",
            "Podiatrist",
            "Urologist"});
            this.refby.Location = new System.Drawing.Point(218, 165);
            this.refby.Name = "refby";
            this.refby.Size = new System.Drawing.Size(148, 21);
            this.refby.TabIndex = 14;
            this.refby.Text = "Doctors";
            // 
            // Referedby
            // 
            this.Referedby.AutoSize = true;
            this.Referedby.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Referedby.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Referedby.Location = new System.Drawing.Point(197, 133);
            this.Referedby.Name = "Referedby";
            this.Referedby.Size = new System.Drawing.Size(80, 19);
            this.Referedby.TabIndex = 13;
            this.Referedby.Text = "Refered By";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(262, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 26);
            this.label13.TabIndex = 8;
            this.label13.Text = "Doctors Details";
            // 
            // patientid
            // 
            this.patientid.FormattingEnabled = true;
            this.patientid.Items.AddRange(new object[] {
            "Cardiologist",
            "Allergist",
            "Dermotologist",
            "Neurologist",
            "Anesthesiologist",
            "Podiatrist",
            "Urologist"});
            this.patientid.Location = new System.Drawing.Point(129, 97);
            this.patientid.Name = "patientid";
            this.patientid.Size = new System.Drawing.Size(148, 21);
            this.patientid.TabIndex = 9;
            this.patientid.Text = "ID";
            this.patientid.SelectionChangeCommitted += new System.EventHandler(this.patientid_SelectionChangeCommitted);
            // 
            // PatName
            // 
            this.PatName.AutoSize = true;
            this.PatName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PatName.Location = new System.Drawing.Point(291, 58);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(97, 19);
            this.PatName.TabIndex = 2;
            this.PatName.Text = "Patient Name";
            // 
            // Patid
            // 
            this.Patid.AutoSize = true;
            this.Patid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Patid.Location = new System.Drawing.Point(125, 69);
            this.Patid.Name = "Patid";
            this.Patid.Size = new System.Drawing.Size(69, 19);
            this.Patid.TabIndex = 1;
            this.Patid.Text = "PatientID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(439, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Test Invoice";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Location = new System.Drawing.Point(156, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 15);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctors";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 606);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(36, 424);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 2);
            this.panel3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Logout";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(34, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dashboard";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(34, 442);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(74, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(34, 333);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(74, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(30, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Test Invoice";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(42, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tests";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(42, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Patients";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // testid
            // 
            this.testid.AutoSize = true;
            this.testid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.testid.Location = new System.Drawing.Point(230, 348);
            this.testid.Name = "testid";
            this.testid.Size = new System.Drawing.Size(50, 19);
            this.testid.TabIndex = 20;
            this.testid.Text = "TestID";
            // 
            // testname
            // 
            this.testname.AutoSize = true;
            this.testname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.testname.Location = new System.Drawing.Point(422, 346);
            this.testname.Name = "testname";
            this.testname.Size = new System.Drawing.Size(74, 19);
            this.testname.TabIndex = 20;
            this.testname.Text = "TestName";
            this.testname.Click += new System.EventHandler(this.label17_Click);
            // 
            // TestNameBox
            // 
            this.TestNameBox.Location = new System.Drawing.Point(428, 383);
            this.TestNameBox.Name = "TestNameBox";
            this.TestNameBox.Size = new System.Drawing.Size(138, 20);
            this.TestNameBox.TabIndex = 20;
            // 
            // TestNameID
            // 
            this.TestNameID.FormattingEnabled = true;
            this.TestNameID.Items.AddRange(new object[] {
            "Cardiologist",
            "Allergist",
            "Dermotologist",
            "Neurologist",
            "Anesthesiologist",
            "Podiatrist",
            "Urologist"});
            this.TestNameID.Location = new System.Drawing.Point(234, 383);
            this.TestNameID.Name = "TestNameID";
            this.TestNameID.Size = new System.Drawing.Size(148, 21);
            this.TestNameID.TabIndex = 20;
            this.TestNameID.SelectionChangeCommitted += new System.EventHandler(this.TestNameID_SelectionChangeCommitted);
            // 
            // Addtest
            // 
            this.Addtest.BackColor = System.Drawing.Color.PowderBlue;
            this.Addtest.Location = new System.Drawing.Point(610, 380);
            this.Addtest.Name = "Addtest";
            this.Addtest.Size = new System.Drawing.Size(75, 23);
            this.Addtest.TabIndex = 23;
            this.Addtest.Text = "Add Test";
            this.Addtest.UseVisualStyleBackColor = false;
            this.Addtest.Click += new System.EventHandler(this.Addtest_Click);
            // 
            // totalcost
            // 
            this.totalcost.AutoSize = true;
            this.totalcost.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcost.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalcost.Location = new System.Drawing.Point(487, 581);
            this.totalcost.Name = "totalcost";
            this.totalcost.Size = new System.Drawing.Size(53, 26);
            this.totalcost.TabIndex = 24;
            this.totalcost.Text = "Total";
            this.totalcost.Click += new System.EventHandler(this.label18_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(958, 616);
            this.Controls.Add(this.totalcost);
            this.Controls.Add(this.Addtest);
            this.Controls.Add(this.TestNameID);
            this.Controls.Add(this.TestNameBox);
            this.Controls.Add(this.testname);
            this.Controls.Add(this.testid);
            this.Controls.Add(this.Totallist);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.saveinvoicebutton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.Totallist)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Totallist;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button saveinvoicebutton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox patientid;
        private System.Windows.Forms.Label PatName;
        private System.Windows.Forms.Label Patid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker delidate;
        private System.Windows.Forms.Label deldate;
        private System.Windows.Forms.TextBox Patphone;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox patientName;
        private System.Windows.Forms.ComboBox refby;
        private System.Windows.Forms.Label Referedby;
        private System.Windows.Forms.Label testid;
        private System.Windows.Forms.Label testname;
        private System.Windows.Forms.TextBox TestNameBox;
        private System.Windows.Forms.ComboBox TestNameID;
        private System.Windows.Forms.Button Addtest;
        private System.Windows.Forms.Label totalcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}