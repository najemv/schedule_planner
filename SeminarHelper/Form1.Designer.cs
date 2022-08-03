
namespace SeminarHelper
{
    partial class Application
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.tableGrid = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSubjectList = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.trackBarScore = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNamesUpdate = new System.Windows.Forms.Button();
            this.textBoxNames = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.trackBar10 = new System.Windows.Forms.TrackBar();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOverrideNo = new System.Windows.Forms.RadioButton();
            this.btnOverrideYes = new System.Windows.Forms.RadioButton();
            this.labelCurrentIndex = new System.Windows.Forms.Label();
            this.labelMaxIndex = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCurrentSeminars = new System.Windows.Forms.Button();
            this.btnISLoad = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.checkBoxOpenWindows = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowTable
            // 
            this.btnShowTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowTable.Location = new System.Drawing.Point(1116, 406);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(114, 23);
            this.btnShowTable.TabIndex = 1;
            this.btnShowTable.Text = "Vyčistit";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // tableGrid
            // 
            this.tableGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.tableGrid.Location = new System.Drawing.Point(12, 12);
            this.tableGrid.Name = "tableGrid";
            this.tableGrid.ReadOnly = true;
            this.tableGrid.RowHeadersWidth = 100;
            this.tableGrid.RowTemplate.Height = 25;
            this.tableGrid.Size = new System.Drawing.Size(1218, 388);
            this.tableGrid.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(328, 344);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Vyhledat předměty";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(732, 406);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(29, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(702, 406);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(24, 23);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnSubjectList
            // 
            this.btnSubjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubjectList.Location = new System.Drawing.Point(949, 406);
            this.btnSubjectList.Name = "btnSubjectList";
            this.btnSubjectList.Size = new System.Drawing.Size(161, 23);
            this.btnSubjectList.TabIndex = 6;
            this.btnSubjectList.Text = "Ukaž Všechny Předměty";
            this.btnSubjectList.UseVisualStyleBackColor = true;
            this.btnSubjectList.Click += new System.EventHandler(this.btnSubjectList_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(1116, 750);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Přihlásit";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(1116, 474);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(114, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Načíst ze souboru";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1116, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Uložit do souboru";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Překryv s přednáškami:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.textBoxScore);
            this.groupBox1.Controls.Add(this.trackBarScore);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnNamesUpdate);
            this.groupBox1.Controls.Add(this.textBoxNames);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.trackBar10);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.trackBar9);
            this.groupBox1.Controls.Add(this.trackBar8);
            this.groupBox1.Controls.Add(this.trackBar7);
            this.groupBox1.Controls.Add(this.trackBar6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.trackBar5);
            this.groupBox1.Controls.Add(this.trackBar4);
            this.groupBox1.Controls.Add(this.trackBar3);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnOverrideNo);
            this.groupBox1.Controls.Add(this.btnOverrideYes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 373);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtry";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(203, 295);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.ReadOnly = true;
            this.textBoxScore.Size = new System.Drawing.Size(31, 23);
            this.textBoxScore.TabIndex = 44;
            this.textBoxScore.Text = "2";
            // 
            // trackBarScore
            // 
            this.trackBarScore.Location = new System.Drawing.Point(92, 295);
            this.trackBarScore.Maximum = 50;
            this.trackBarScore.Minimum = 10;
            this.trackBarScore.Name = "trackBarScore";
            this.trackBarScore.Size = new System.Drawing.Size(104, 45);
            this.trackBarScore.TabIndex = 43;
            this.trackBarScore.Value = 20;
            this.trackBarScore.Scroll += new System.EventHandler(this.trackBarScore_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Hodnocení:";
            // 
            // btnNamesUpdate
            // 
            this.btnNamesUpdate.Location = new System.Drawing.Point(319, 255);
            this.btnNamesUpdate.Name = "btnNamesUpdate";
            this.btnNamesUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnNamesUpdate.TabIndex = 41;
            this.btnNamesUpdate.Text = "Aktualizovat";
            this.btnNamesUpdate.UseVisualStyleBackColor = true;
            this.btnNamesUpdate.Click += new System.EventHandler(this.btnNamesUpdate_Click);
            // 
            // textBoxNames
            // 
            this.textBoxNames.Location = new System.Drawing.Point(104, 255);
            this.textBoxNames.Name = "textBoxNames";
            this.textBoxNames.Size = new System.Drawing.Size(209, 23);
            this.textBoxNames.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Oblíbení cvičící:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(352, 196);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(30, 23);
            this.textBox10.TabIndex = 38;
            this.textBox10.Text = "20";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(352, 159);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(30, 23);
            this.textBox9.TabIndex = 37;
            this.textBox9.Text = "20";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(352, 124);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(30, 23);
            this.textBox8.TabIndex = 36;
            this.textBox8.Text = "20";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(352, 89);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(30, 23);
            this.textBox7.TabIndex = 35;
            this.textBox7.Text = "20";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(352, 55);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(30, 23);
            this.textBox6.TabIndex = 34;
            this.textBox6.Text = "20";
            // 
            // trackBar10
            // 
            this.trackBar10.Location = new System.Drawing.Point(242, 196);
            this.trackBar10.Maximum = 24;
            this.trackBar10.Name = "trackBar10";
            this.trackBar10.Size = new System.Drawing.Size(104, 45);
            this.trackBar10.TabIndex = 33;
            this.trackBar10.Value = 20;
            this.trackBar10.Scroll += new System.EventHandler(this.trackBar10_Scroll);
            // 
            // trackBar9
            // 
            this.trackBar9.Location = new System.Drawing.Point(242, 159);
            this.trackBar9.Maximum = 24;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Size = new System.Drawing.Size(104, 45);
            this.trackBar9.TabIndex = 32;
            this.trackBar9.Value = 20;
            this.trackBar9.Scroll += new System.EventHandler(this.trackBar9_Scroll);
            // 
            // trackBar8
            // 
            this.trackBar8.Location = new System.Drawing.Point(242, 124);
            this.trackBar8.Maximum = 24;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(104, 45);
            this.trackBar8.TabIndex = 31;
            this.trackBar8.Value = 20;
            this.trackBar8.Scroll += new System.EventHandler(this.trackBar8_Scroll);
            // 
            // trackBar7
            // 
            this.trackBar7.Location = new System.Drawing.Point(242, 89);
            this.trackBar7.Maximum = 24;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(104, 45);
            this.trackBar7.TabIndex = 30;
            this.trackBar7.Value = 20;
            this.trackBar7.Scroll += new System.EventHandler(this.trackBar7_Scroll);
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(242, 55);
            this.trackBar6.Maximum = 24;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(104, 45);
            this.trackBar6.TabIndex = 29;
            this.trackBar6.Value = 20;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(188, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(30, 23);
            this.textBox5.TabIndex = 28;
            this.textBox5.Text = "8";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(188, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(30, 23);
            this.textBox4.TabIndex = 27;
            this.textBox4.Text = "8";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(30, 23);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = "8";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(30, 23);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "8";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(30, 23);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "8";
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(78, 196);
            this.trackBar5.Maximum = 24;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(104, 45);
            this.trackBar5.TabIndex = 23;
            this.trackBar5.Value = 8;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(78, 159);
            this.trackBar4.Maximum = 24;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 45);
            this.trackBar4.TabIndex = 22;
            this.trackBar4.Value = 8;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(78, 124);
            this.trackBar3.Maximum = 24;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 21;
            this.trackBar3.Value = 8;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(78, 89);
            this.trackBar2.Maximum = 24;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 20;
            this.trackBar2.Value = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(78, 55);
            this.trackBar1.Maximum = 24;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pátek    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Čtvrtek  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Středa    :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Úterý      :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pondělí  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Čas:";
            // 
            // btnOverrideNo
            // 
            this.btnOverrideNo.AutoSize = true;
            this.btnOverrideNo.Checked = true;
            this.btnOverrideNo.Location = new System.Drawing.Point(194, 19);
            this.btnOverrideNo.Name = "btnOverrideNo";
            this.btnOverrideNo.Size = new System.Drawing.Size(40, 19);
            this.btnOverrideNo.TabIndex = 12;
            this.btnOverrideNo.TabStop = true;
            this.btnOverrideNo.Text = "Ne";
            this.btnOverrideNo.UseVisualStyleBackColor = true;
            this.btnOverrideNo.CheckedChanged += new System.EventHandler(this.btnOverrideNo_CheckedChanged);
            // 
            // btnOverrideYes
            // 
            this.btnOverrideYes.AutoSize = true;
            this.btnOverrideYes.Location = new System.Drawing.Point(141, 19);
            this.btnOverrideYes.Name = "btnOverrideYes";
            this.btnOverrideYes.Size = new System.Drawing.Size(47, 19);
            this.btnOverrideYes.TabIndex = 11;
            this.btnOverrideYes.Text = "Ano";
            this.btnOverrideYes.UseVisualStyleBackColor = true;
            this.btnOverrideYes.CheckedChanged += new System.EventHandler(this.btnOverrideYes_CheckedChanged);
            // 
            // labelCurrentIndex
            // 
            this.labelCurrentIndex.AutoSize = true;
            this.labelCurrentIndex.Location = new System.Drawing.Point(790, 410);
            this.labelCurrentIndex.Name = "labelCurrentIndex";
            this.labelCurrentIndex.Size = new System.Drawing.Size(13, 15);
            this.labelCurrentIndex.TabIndex = 12;
            this.labelCurrentIndex.Text = "0";
            // 
            // labelMaxIndex
            // 
            this.labelMaxIndex.AutoSize = true;
            this.labelMaxIndex.Location = new System.Drawing.Point(827, 410);
            this.labelMaxIndex.Name = "labelMaxIndex";
            this.labelMaxIndex.Size = new System.Drawing.Size(13, 15);
            this.labelMaxIndex.TabIndex = 13;
            this.labelMaxIndex.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(809, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "/";
            // 
            // btnCurrentSeminars
            // 
            this.btnCurrentSeminars.Location = new System.Drawing.Point(430, 406);
            this.btnCurrentSeminars.Name = "btnCurrentSeminars";
            this.btnCurrentSeminars.Size = new System.Drawing.Size(129, 23);
            this.btnCurrentSeminars.TabIndex = 15;
            this.btnCurrentSeminars.Text = "Aktuální semináře";
            this.btnCurrentSeminars.UseVisualStyleBackColor = true;
            this.btnCurrentSeminars.Click += new System.EventHandler(this.btnCurrentSeminars_Click);
            // 
            // btnISLoad
            // 
            this.btnISLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnISLoad.Location = new System.Drawing.Point(1116, 532);
            this.btnISLoad.Name = "btnISLoad";
            this.btnISLoad.Size = new System.Drawing.Size(114, 23);
            this.btnISLoad.TabIndex = 16;
            this.btnISLoad.Text = "Načíst z ISu";
            this.btnISLoad.UseVisualStyleBackColor = true;
            this.btnISLoad.Click += new System.EventHandler(this.btnISLoad_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Location = new System.Drawing.Point(603, 750);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegister.Location = new System.Drawing.Point(809, 750);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Zapsat";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // checkBoxOpenWindows
            // 
            this.checkBoxOpenWindows.AutoSize = true;
            this.checkBoxOpenWindows.Checked = true;
            this.checkBoxOpenWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpenWindows.Location = new System.Drawing.Point(506, 753);
            this.checkBoxOpenWindows.Name = "checkBoxOpenWindows";
            this.checkBoxOpenWindows.Size = new System.Drawing.Size(91, 19);
            this.checkBoxOpenWindows.TabIndex = 20;
            this.checkBoxOpenWindows.Text = "Otevřít okna";
            this.checkBoxOpenWindows.UseVisualStyleBackColor = true;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 791);
            this.Controls.Add(this.checkBoxOpenWindows);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnISLoad);
            this.Controls.Add(this.btnCurrentSeminars);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelMaxIndex);
            this.Controls.Add(this.labelCurrentIndex);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSubjectList);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tableGrid);
            this.Controls.Add(this.btnShowTable);
            this.MinimumSize = new System.Drawing.Size(1200, 830);
            this.Name = "Application";
            this.Text = "Aplikace";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.DataGridView tableGrid;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSubjectList;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnOverrideNo;
        private System.Windows.Forms.RadioButton btnOverrideYes;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TrackBar trackBar10;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxNames;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCurrentIndex;
        private System.Windows.Forms.Label labelMaxIndex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNamesUpdate;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.TrackBar trackBarScore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCurrentSeminars;
        private System.Windows.Forms.Button btnISLoad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox checkBoxOpenWindows;
    }
}

