namespace ApplicationFeedbackSystem
{
    partial class HrScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.feedbackPrint = new System.Drawing.Printing.PrintDocument();
            this.logoutPanel2 = new System.Windows.Forms.Panel();
            this.cancelLogOutButton = new System.Windows.Forms.Button();
            this.cLogOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCompleteFeedback = new ApplicationFeedbackSystem.PanelGradientColor();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelGradientColor9 = new ApplicationFeedbackSystem.labelGradientColor();
            this.labelGradientColor10 = new ApplicationFeedbackSystem.labelGradientColor();
            this.panelFeedback = new ApplicationFeedbackSystem.PanelGradientColor();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelGradientColor7 = new ApplicationFeedbackSystem.labelGradientColor();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelGradientColor5 = new ApplicationFeedbackSystem.labelGradientColor();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelGradientColor6 = new ApplicationFeedbackSystem.labelGradientColor();
            this.labelGradientColor4 = new ApplicationFeedbackSystem.labelGradientColor();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelGradientColor3 = new ApplicationFeedbackSystem.labelGradientColor();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelGradientColor2 = new ApplicationFeedbackSystem.labelGradientColor();
            this.eFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.labelGradientColor1 = new ApplicationFeedbackSystem.labelGradientColor();
            this.labelGradientColor38 = new ApplicationFeedbackSystem.labelGradientColor();
            this.labelGradientColor8 = new ApplicationFeedbackSystem.labelGradientColor();
            this.PanelViewTemplate = new ApplicationFeedbackSystem.PanelGradientColor();
            this.labelTemplateList = new ApplicationFeedbackSystem.labelGradientColor();
            this.LabelViewTemplate = new ApplicationFeedbackSystem.labelGradientColor();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelAdminRight = new ApplicationFeedbackSystem.PanelGradientColor();
            this.panelAdminBtn = new ApplicationFeedbackSystem.PanelGradientColor();
            this.displayBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.panelFeedCompleteBtn = new ApplicationFeedbackSystem.PanelGradientColor();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelCreateTemplateBtn = new ApplicationFeedbackSystem.PanelGradientColor();
            this.displayBtn2 = new System.Windows.Forms.Button();
            this.logOutBtn2 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new ApplicationFeedbackSystem.PictureBoxGradientColor();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.file_name_data = new System.Windows.Forms.DataGridViewButtonColumn();
            this.email_data = new System.Windows.Forms.DataGridViewButtonColumn();
            this.logoutPanel2.SuspendLayout();
            this.panelCompleteFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFeedback.SuspendLayout();
            this.PanelViewTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panelAdminRight.SuspendLayout();
            this.panelAdminBtn.SuspendLayout();
            this.panelFeedCompleteBtn.SuspendLayout();
            this.panelCreateTemplateBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // feedbackPrint
            // 
            this.feedbackPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.feedbackPrint_PrintPage);
            // 
            // logoutPanel2
            // 
            this.logoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.logoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoutPanel2.Controls.Add(this.cancelLogOutButton);
            this.logoutPanel2.Controls.Add(this.cLogOutButton);
            this.logoutPanel2.Controls.Add(this.label1);
            this.logoutPanel2.Location = new System.Drawing.Point(130, 0);
            this.logoutPanel2.Name = "logoutPanel2";
            this.logoutPanel2.Size = new System.Drawing.Size(262, 117);
            this.logoutPanel2.TabIndex = 71;
            // 
            // cancelLogOutButton
            // 
            this.cancelLogOutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelLogOutButton.ForeColor = System.Drawing.Color.Black;
            this.cancelLogOutButton.Location = new System.Drawing.Point(158, 56);
            this.cancelLogOutButton.Name = "cancelLogOutButton";
            this.cancelLogOutButton.Size = new System.Drawing.Size(75, 26);
            this.cancelLogOutButton.TabIndex = 2;
            this.cancelLogOutButton.Text = "Cancel";
            this.cancelLogOutButton.UseVisualStyleBackColor = true;
            this.cancelLogOutButton.Click += new System.EventHandler(this.cancelLogOutButton_Click);
            // 
            // cLogOutButton
            // 
            this.cLogOutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLogOutButton.ForeColor = System.Drawing.Color.Black;
            this.cLogOutButton.Location = new System.Drawing.Point(26, 56);
            this.cLogOutButton.Name = "cLogOutButton";
            this.cLogOutButton.Size = new System.Drawing.Size(75, 26);
            this.cLogOutButton.TabIndex = 1;
            this.cLogOutButton.Text = "Log out";
            this.cLogOutButton.UseVisualStyleBackColor = true;
            this.cLogOutButton.Click += new System.EventHandler(this.cLogOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure ?";
            // 
            // panelCompleteFeedback
            // 
            this.panelCompleteFeedback.ColorBottom = System.Drawing.Color.Empty;
            this.panelCompleteFeedback.ColorTop = System.Drawing.Color.Empty;
            this.panelCompleteFeedback.Controls.Add(this.dataGridView1);
            this.panelCompleteFeedback.Controls.Add(this.labelGradientColor9);
            this.panelCompleteFeedback.Controls.Add(this.labelGradientColor10);
            this.panelCompleteFeedback.Location = new System.Drawing.Point(398, 116);
            this.panelCompleteFeedback.Name = "panelCompleteFeedback";
            this.panelCompleteFeedback.Size = new System.Drawing.Size(866, 561);
            this.panelCompleteFeedback.TabIndex = 70;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Aqua;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.file_name_data,
            this.email_data});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(1, 140);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(866, 421);
            this.dataGridView1.TabIndex = 11;
            // 
            // labelGradientColor9
            // 
            this.labelGradientColor9.BackColor = System.Drawing.Color.White;
            this.labelGradientColor9.ColorBottom = System.Drawing.Color.Indigo;
            this.labelGradientColor9.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelGradientColor9.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGradientColor9.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradientColor9.ForeColor = System.Drawing.Color.White;
            this.labelGradientColor9.Location = new System.Drawing.Point(0, 85);
            this.labelGradientColor9.Name = "labelGradientColor9";
            this.labelGradientColor9.Size = new System.Drawing.Size(866, 55);
            this.labelGradientColor9.TabIndex = 10;
            this.labelGradientColor9.Text = "Feedback List";
            this.labelGradientColor9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGradientColor10
            // 
            this.labelGradientColor10.ColorBottom = System.Drawing.Color.Gainsboro;
            this.labelGradientColor10.ColorTop = System.Drawing.SystemColors.Control;
            this.labelGradientColor10.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGradientColor10.Font = new System.Drawing.Font("Century Schoolbook", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradientColor10.Location = new System.Drawing.Point(0, 0);
            this.labelGradientColor10.Name = "labelGradientColor10";
            this.labelGradientColor10.Size = new System.Drawing.Size(866, 85);
            this.labelGradientColor10.TabIndex = 6;
            this.labelGradientColor10.Text = "Complete Feedback List";
            this.labelGradientColor10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFeedback
            // 
            this.panelFeedback.ColorBottom = System.Drawing.Color.Empty;
            this.panelFeedback.ColorTop = System.Drawing.Color.Empty;
            this.panelFeedback.Controls.Add(this.textBox4);
            this.panelFeedback.Controls.Add(this.labelGradientColor7);
            this.panelFeedback.Controls.Add(this.textBox3);
            this.panelFeedback.Controls.Add(this.labelGradientColor5);
            this.panelFeedback.Controls.Add(this.textBox5);
            this.panelFeedback.Controls.Add(this.labelGradientColor6);
            this.panelFeedback.Controls.Add(this.labelGradientColor4);
            this.panelFeedback.Controls.Add(this.textBox2);
            this.panelFeedback.Controls.Add(this.labelGradientColor3);
            this.panelFeedback.Controls.Add(this.textBox1);
            this.panelFeedback.Controls.Add(this.labelGradientColor2);
            this.panelFeedback.Controls.Add(this.eFirstNameTextBox);
            this.panelFeedback.Controls.Add(this.labelGradientColor1);
            this.panelFeedback.Controls.Add(this.labelGradientColor38);
            this.panelFeedback.Controls.Add(this.labelGradientColor8);
            this.panelFeedback.Location = new System.Drawing.Point(671, 33);
            this.panelFeedback.Name = "panelFeedback";
            this.panelFeedback.Size = new System.Drawing.Size(872, 561);
            this.panelFeedback.TabIndex = 68;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(604, 508);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(220, 32);
            this.textBox4.TabIndex = 89;
            // 
            // labelGradientColor7
            // 
            this.labelGradientColor7.ColorBottom = System.Drawing.Color.Empty;
            this.labelGradientColor7.ColorTop = System.Drawing.Color.Empty;
            this.labelGradientColor7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradientColor7.ForeColor = System.Drawing.Color.Black;
            this.labelGradientColor7.Location = new System.Drawing.Point(450, 506);
            this.labelGradientColor7.Name = "labelGradientColor7";
            this.labelGradientColor7.Size = new System.Drawing.Size(121, 28);
            this.labelGradientColor7.TabIndex = 88;
            this.labelGradientColor7.Text = "Interviewer:";
            this.labelGradientColor7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(604, 476);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 32);
            this.textBox3.TabIndex = 87;
            // 
            // labelGradientColor5
            // 
            this.labelGradientColor5.ColorBottom = System.Drawing.Color.Empty;
            this.labelGradientColor5.ColorTop = System.Drawing.Color.Empty;
            this.labelGradientColor5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradientColor5.ForeColor = System.Drawing.Color.Black;
            this.labelGradientColor5.Location = new System.Drawing.Point(425, 478);
            this.labelGradientColor5.Name = "labelGradientColor5";
            this.labelGradientColor5.Size = new System.Drawing.Size(174, 28);
            this.labelGradientColor5.TabIndex = 86;
            this.labelGradientColor5.Text = "Feedback Type:";
            this.labelGradientColor5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(41, 316);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(783, 142);
            this.textBox5.TabIndex = 85;
            // 
            // labelGradientColor6
            // 
            this.labelGradientColor6.ColorBottom = System.Drawing.Color.Empty;
            this.labelGradientColor6.ColorTop = System.Drawing.Color.Empty;
            this.labelGradientColor6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradientColor6.ForeColor = System.Drawing.Color.Black;
            this.labelGradientColor6.Location = new System.Drawing.Point(36, 273);
            this.labelGradientColor6.Name = "labelGradientColor6";
            this.labelGradientColor6.Size = new System.Drawing.Size(423, 41);
            this.labelGradientColor6.TabIndex = 84;
            this.labelGradientColor6.Text = "Describe Your Feedback:";
            this.labelGradientColor6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGradientColor4
            // 
            this.labelGradientColor4.ColorBottom = System.Drawing.Color.Indigo;
            this.labelGradientColor4.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelGradientColor4.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradientColor4.ForeColor = System.Drawing.Color.White;
            this.labelGradientColor4.Location = new System.Drawing.Point(0, 84);
            this.labelGradientColor4.Name = "labelGradientColor4";
            this.labelGradientColor4.Size = new System.Drawing.Size(866, 44);
            this.labelGradientColor4.TabIndex = 83;
            this.labelGradientColor4.Text = "Interviewee Details";
            this.labelGradientColor4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(604, 172);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 32);
            this.textBox2.TabIndex = 79;
            // 
            // labelGradientColor3
            // 
            this.labelGradientColor3.ColorBottom = System.Drawing.Color.Empty;
            this.labelGradientColor3.ColorTop = System.Drawing.Color.Empty;
            this.labelGradientColor3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradientColor3.ForeColor = System.Drawing.Color.Black;
            this.labelGradientColor3.Location = new System.Drawing.Point(600, 142);
            this.labelGradientColor3.Name = "labelGradientColor3";
            this.labelGradientColor3.Size = new System.Drawing.Size(89, 28);
            this.labelGradientColor3.TabIndex = 78;
            this.labelGradientColor3.Text = "Email";
            this.labelGradientColor3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(326, 172);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 32);
            this.textBox1.TabIndex = 77;
            // 
            // labelGradientColor2
            // 
            this.labelGradientColor2.ColorBottom = System.Drawing.Color.Empty;
            this.labelGradientColor2.ColorTop = System.Drawing.Color.Empty;
            this.labelGradientColor2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradientColor2.ForeColor = System.Drawing.Color.Black;
            this.labelGradientColor2.Location = new System.Drawing.Point(322, 142);
            this.labelGradientColor2.Name = "labelGradientColor2";
            this.labelGradientColor2.Size = new System.Drawing.Size(137, 28);
            this.labelGradientColor2.TabIndex = 76;
            this.labelGradientColor2.Text = "Interviewee";
            this.labelGradientColor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eFirstNameTextBox
            // 
            this.eFirstNameTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eFirstNameTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.eFirstNameTextBox.Location = new System.Drawing.Point(41, 172);
            this.eFirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.eFirstNameTextBox.Multiline = true;
            this.eFirstNameTextBox.Name = "eFirstNameTextBox";
            this.eFirstNameTextBox.Size = new System.Drawing.Size(220, 32);
            this.eFirstNameTextBox.TabIndex = 75;
            this.eFirstNameTextBox.TextChanged += new System.EventHandler(this.eFirstNameTextBox_TextChanged);
            // 
            // labelGradientColor1
            // 
            this.labelGradientColor1.ColorBottom = System.Drawing.Color.Empty;
            this.labelGradientColor1.ColorTop = System.Drawing.Color.Empty;
            this.labelGradientColor1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradientColor1.ForeColor = System.Drawing.Color.Black;
            this.labelGradientColor1.Location = new System.Drawing.Point(37, 142);
            this.labelGradientColor1.Name = "labelGradientColor1";
            this.labelGradientColor1.Size = new System.Drawing.Size(89, 28);
            this.labelGradientColor1.TabIndex = 74;
            this.labelGradientColor1.Text = "Code";
            this.labelGradientColor1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGradientColor38
            // 
            this.labelGradientColor38.ColorBottom = System.Drawing.Color.Indigo;
            this.labelGradientColor38.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelGradientColor38.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradientColor38.ForeColor = System.Drawing.Color.White;
            this.labelGradientColor38.Location = new System.Drawing.Point(0, 229);
            this.labelGradientColor38.Name = "labelGradientColor38";
            this.labelGradientColor38.Size = new System.Drawing.Size(866, 44);
            this.labelGradientColor38.TabIndex = 65;
            this.labelGradientColor38.Text = "Please Leave Your Comments at the Description Bellow:";
            this.labelGradientColor38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGradientColor8
            // 
            this.labelGradientColor8.ColorBottom = System.Drawing.Color.Gainsboro;
            this.labelGradientColor8.ColorTop = System.Drawing.SystemColors.Control;
            this.labelGradientColor8.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGradientColor8.Font = new System.Drawing.Font("Century Schoolbook", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradientColor8.Location = new System.Drawing.Point(0, 0);
            this.labelGradientColor8.Name = "labelGradientColor8";
            this.labelGradientColor8.Size = new System.Drawing.Size(872, 85);
            this.labelGradientColor8.TabIndex = 6;
            this.labelGradientColor8.Text = "Feedback";
            this.labelGradientColor8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelViewTemplate
            // 
            this.PanelViewTemplate.ColorBottom = System.Drawing.Color.Empty;
            this.PanelViewTemplate.ColorTop = System.Drawing.Color.Empty;
            this.PanelViewTemplate.Controls.Add(this.labelTemplateList);
            this.PanelViewTemplate.Controls.Add(this.LabelViewTemplate);
            this.PanelViewTemplate.Controls.Add(this.dgvList);
            this.PanelViewTemplate.Location = new System.Drawing.Point(138, 350);
            this.PanelViewTemplate.Name = "PanelViewTemplate";
            this.PanelViewTemplate.Size = new System.Drawing.Size(866, 561);
            this.PanelViewTemplate.TabIndex = 67;
            // 
            // labelTemplateList
            // 
            this.labelTemplateList.BackColor = System.Drawing.Color.White;
            this.labelTemplateList.ColorBottom = System.Drawing.Color.Indigo;
            this.labelTemplateList.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelTemplateList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTemplateList.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemplateList.ForeColor = System.Drawing.Color.White;
            this.labelTemplateList.Location = new System.Drawing.Point(0, 85);
            this.labelTemplateList.Name = "labelTemplateList";
            this.labelTemplateList.Size = new System.Drawing.Size(866, 55);
            this.labelTemplateList.TabIndex = 8;
            this.labelTemplateList.Text = "Template List";
            this.labelTemplateList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelViewTemplate
            // 
            this.LabelViewTemplate.ColorBottom = System.Drawing.Color.Gainsboro;
            this.LabelViewTemplate.ColorTop = System.Drawing.SystemColors.Control;
            this.LabelViewTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelViewTemplate.Font = new System.Drawing.Font("Century Schoolbook", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelViewTemplate.Location = new System.Drawing.Point(0, 0);
            this.LabelViewTemplate.Name = "LabelViewTemplate";
            this.LabelViewTemplate.Size = new System.Drawing.Size(866, 85);
            this.LabelViewTemplate.TabIndex = 6;
            this.LabelViewTemplate.Text = "View Template";
            this.LabelViewTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvList.Location = new System.Drawing.Point(1, 139);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 40;
            this.dgvList.Size = new System.Drawing.Size(866, 420);
            this.dgvList.TabIndex = 7;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // panelAdminRight
            // 
            this.panelAdminRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelAdminRight.ColorBottom = System.Drawing.Color.Empty;
            this.panelAdminRight.ColorTop = System.Drawing.Color.Empty;
            this.panelAdminRight.Controls.Add(this.panelAdminBtn);
            this.panelAdminRight.Controls.Add(this.panelFeedCompleteBtn);
            this.panelAdminRight.Controls.Add(this.panelCreateTemplateBtn);
            this.panelAdminRight.Controls.Add(this.pictureBoxLogo);
            this.panelAdminRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminRight.Location = new System.Drawing.Point(0, 0);
            this.panelAdminRight.Name = "panelAdminRight";
            this.panelAdminRight.Size = new System.Drawing.Size(124, 561);
            this.panelAdminRight.TabIndex = 1;
            // 
            // panelAdminBtn
            // 
            this.panelAdminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelAdminBtn.ColorBottom = System.Drawing.Color.Empty;
            this.panelAdminBtn.ColorTop = System.Drawing.Color.Empty;
            this.panelAdminBtn.Controls.Add(this.displayBtn);
            this.panelAdminBtn.Controls.Add(this.logoutBtn);
            this.panelAdminBtn.Controls.Add(this.editBtn);
            this.panelAdminBtn.Controls.Add(this.createBtn);
            this.panelAdminBtn.Location = new System.Drawing.Point(83, 143);
            this.panelAdminBtn.Name = "panelAdminBtn";
            this.panelAdminBtn.Size = new System.Drawing.Size(116, 430);
            this.panelAdminBtn.TabIndex = 2;
            // 
            // displayBtn
            // 
            this.displayBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBtn.Location = new System.Drawing.Point(8, 156);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(103, 45);
            this.displayBtn.TabIndex = 3;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(8, 374);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(88, 45);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "LogOut";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(8, 87);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(103, 46);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Complete\r\nFeedback";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(8, 18);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(103, 45);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Feedback";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // panelFeedCompleteBtn
            // 
            this.panelFeedCompleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelFeedCompleteBtn.ColorBottom = System.Drawing.Color.Empty;
            this.panelFeedCompleteBtn.ColorTop = System.Drawing.Color.Empty;
            this.panelFeedCompleteBtn.Controls.Add(this.button4);
            this.panelFeedCompleteBtn.Controls.Add(this.button1);
            this.panelFeedCompleteBtn.Controls.Add(this.button2);
            this.panelFeedCompleteBtn.Controls.Add(this.button3);
            this.panelFeedCompleteBtn.Location = new System.Drawing.Point(42, 271);
            this.panelFeedCompleteBtn.Name = "panelFeedCompleteBtn";
            this.panelFeedCompleteBtn.Size = new System.Drawing.Size(114, 430);
            this.panelFeedCompleteBtn.TabIndex = 71;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(15, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(15, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 0;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelCreateTemplateBtn
            // 
            this.panelCreateTemplateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelCreateTemplateBtn.ColorBottom = System.Drawing.Color.Empty;
            this.panelCreateTemplateBtn.ColorTop = System.Drawing.Color.Empty;
            this.panelCreateTemplateBtn.Controls.Add(this.displayBtn2);
            this.panelCreateTemplateBtn.Controls.Add(this.logOutBtn2);
            this.panelCreateTemplateBtn.Controls.Add(this.backBtn);
            this.panelCreateTemplateBtn.Controls.Add(this.ClearBtn);
            this.panelCreateTemplateBtn.Location = new System.Drawing.Point(18, 177);
            this.panelCreateTemplateBtn.Name = "panelCreateTemplateBtn";
            this.panelCreateTemplateBtn.Size = new System.Drawing.Size(114, 430);
            this.panelCreateTemplateBtn.TabIndex = 1;
            // 
            // displayBtn2
            // 
            this.displayBtn2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBtn2.Location = new System.Drawing.Point(14, 183);
            this.displayBtn2.Name = "displayBtn2";
            this.displayBtn2.Size = new System.Drawing.Size(75, 45);
            this.displayBtn2.TabIndex = 3;
            this.displayBtn2.Text = "Display";
            this.displayBtn2.UseVisualStyleBackColor = true;
            this.displayBtn2.Click += new System.EventHandler(this.displayBtn2_Click);
            // 
            // logOutBtn2
            // 
            this.logOutBtn2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn2.Location = new System.Drawing.Point(14, 372);
            this.logOutBtn2.Name = "logOutBtn2";
            this.logOutBtn2.Size = new System.Drawing.Size(86, 45);
            this.logOutBtn2.TabIndex = 2;
            this.logOutBtn2.Text = "LogOut";
            this.logOutBtn2.UseVisualStyleBackColor = true;
            this.logOutBtn2.Click += new System.EventHandler(this.logOutBtn2_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(14, 91);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 45);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(14, 21);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 45);
            this.ClearBtn.TabIndex = 0;
            this.ClearBtn.Text = "Send";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pictureBoxLogo.ColorBottom = System.Drawing.Color.Empty;
            this.pictureBoxLogo.ColorTop = System.Drawing.Color.Empty;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Image = global::ApplicationFeedbackSystem.Properties.Resources.Capture1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(124, 113);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            this.chk.Width = 50;
            // 
            // file_name_data
            // 
            this.file_name_data.DataPropertyName = "file_name";
            this.file_name_data.HeaderText = "File Name";
            this.file_name_data.Name = "file_name_data";
            this.file_name_data.Width = 250;
            // 
            // email_data
            // 
            this.email_data.DataPropertyName = "email";
            this.email_data.HeaderText = "Email";
            this.email_data.Name = "email_data";
            this.email_data.Width = 520;
            // 
            // HrScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 561);
            this.Controls.Add(this.panelCompleteFeedback);
            this.Controls.Add(this.panelFeedback);
            this.Controls.Add(this.logoutPanel2);
            this.Controls.Add(this.PanelViewTemplate);
            this.Controls.Add(this.panelAdminRight);
            this.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HrScreen";
            this.Text = "HrScreen";
            this.Load += new System.EventHandler(this.HrScreen_Load);
            this.logoutPanel2.ResumeLayout(false);
            this.logoutPanel2.PerformLayout();
            this.panelCompleteFeedback.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFeedback.ResumeLayout(false);
            this.panelFeedback.PerformLayout();
            this.PanelViewTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panelAdminRight.ResumeLayout(false);
            this.panelAdminBtn.ResumeLayout(false);
            this.panelFeedCompleteBtn.ResumeLayout(false);
            this.panelCreateTemplateBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelGradientColor panelAdminRight;
        private PanelGradientColor panelCreateTemplateBtn;
        private System.Windows.Forms.Button logOutBtn2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button ClearBtn;
        private PanelGradientColor panelAdminBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button createBtn;
        private PictureBoxGradientColor pictureBoxLogo;
        private PanelGradientColor PanelViewTemplate;
        private labelGradientColor labelTemplateList;
        private labelGradientColor LabelViewTemplate;
        private System.Windows.Forms.DataGridView dgvList;
        private PanelGradientColor panelFeedback;
        private System.Windows.Forms.TextBox textBox4;
        private labelGradientColor labelGradientColor7;
        private System.Windows.Forms.TextBox textBox3;
        private labelGradientColor labelGradientColor5;
        private System.Windows.Forms.TextBox textBox5;
        private labelGradientColor labelGradientColor6;
        private labelGradientColor labelGradientColor4;
        private System.Windows.Forms.TextBox textBox2;
        private labelGradientColor labelGradientColor3;
        private System.Windows.Forms.TextBox textBox1;
        private labelGradientColor labelGradientColor2;
        private System.Windows.Forms.TextBox eFirstNameTextBox;
        private labelGradientColor labelGradientColor1;
        private labelGradientColor labelGradientColor38;
        private labelGradientColor labelGradientColor8;
        private PanelGradientColor panelCompleteFeedback;
        private System.Windows.Forms.DataGridView dataGridView1;
        private labelGradientColor labelGradientColor9;
        private labelGradientColor labelGradientColor10;
        private PanelGradientColor panelFeedCompleteBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel logoutPanel2;
        private System.Windows.Forms.Button cancelLogOutButton;
        private System.Windows.Forms.Button cLogOutButton;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument feedbackPrint;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button displayBtn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewButtonColumn file_name_data;
        private System.Windows.Forms.DataGridViewButtonColumn email_data;
    }
}