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
            this.completeFeedPanel = new System.Windows.Forms.Panel();
            this.technicalFeedPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label53 = new System.Windows.Forms.Label();
            this.interviewFeedPanel = new System.Windows.Forms.Panel();
            this.label52 = new System.Windows.Forms.Label();
            this.cvFeedbackPanel = new System.Windows.Forms.Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.technicalInterButton = new System.Windows.Forms.Button();
            this.interviewButton = new System.Windows.Forms.Button();
            this.cvButton = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.sendBtnPanel = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.hrBtnPanel = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.feedbackPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.completeFeedPanel.SuspendLayout();
            this.technicalFeedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.interviewFeedPanel.SuspendLayout();
            this.cvFeedbackPanel.SuspendLayout();
            this.sendBtnPanel.SuspendLayout();
            this.hrBtnPanel.SuspendLayout();
            this.feedbackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // completeFeedPanel
            // 
            this.completeFeedPanel.Controls.Add(this.technicalFeedPanel);
            this.completeFeedPanel.Controls.Add(this.interviewFeedPanel);
            this.completeFeedPanel.Controls.Add(this.cvFeedbackPanel);
            this.completeFeedPanel.Controls.Add(this.technicalInterButton);
            this.completeFeedPanel.Controls.Add(this.interviewButton);
            this.completeFeedPanel.Controls.Add(this.cvButton);
            this.completeFeedPanel.Controls.Add(this.label69);
            this.completeFeedPanel.Location = new System.Drawing.Point(190, 1);
            this.completeFeedPanel.Margin = new System.Windows.Forms.Padding(2);
            this.completeFeedPanel.Name = "completeFeedPanel";
            this.completeFeedPanel.Size = new System.Drawing.Size(534, 433);
            this.completeFeedPanel.TabIndex = 57;
            // 
            // technicalFeedPanel
            // 
            this.technicalFeedPanel.Controls.Add(this.dataGridView1);
            this.technicalFeedPanel.Controls.Add(this.label53);
            this.technicalFeedPanel.Location = new System.Drawing.Point(95, 100);
            this.technicalFeedPanel.Margin = new System.Windows.Forms.Padding(2);
            this.technicalFeedPanel.Name = "technicalFeedPanel";
            this.technicalFeedPanel.Size = new System.Drawing.Size(437, 289);
            this.technicalFeedPanel.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(27, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(360, 184);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "File Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // label53
            // 
            this.label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(10, 12);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(189, 39);
            this.label53.TabIndex = 0;
            this.label53.Text = "Technical Interview Feedback";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interviewFeedPanel
            // 
            this.interviewFeedPanel.Controls.Add(this.label52);
            this.interviewFeedPanel.Location = new System.Drawing.Point(32, 107);
            this.interviewFeedPanel.Margin = new System.Windows.Forms.Padding(2);
            this.interviewFeedPanel.Name = "interviewFeedPanel";
            this.interviewFeedPanel.Size = new System.Drawing.Size(406, 282);
            this.interviewFeedPanel.TabIndex = 22;
            // 
            // label52
            // 
            this.label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(16, 12);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(120, 39);
            this.label52.TabIndex = 0;
            this.label52.Text = "Interview Feedback";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cvFeedbackPanel
            // 
            this.cvFeedbackPanel.Controls.Add(this.label51);
            this.cvFeedbackPanel.Location = new System.Drawing.Point(22, 124);
            this.cvFeedbackPanel.Margin = new System.Windows.Forms.Padding(2);
            this.cvFeedbackPanel.Name = "cvFeedbackPanel";
            this.cvFeedbackPanel.Size = new System.Drawing.Size(398, 282);
            this.cvFeedbackPanel.TabIndex = 21;
            // 
            // label51
            // 
            this.label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(18, 12);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(119, 23);
            this.label51.TabIndex = 0;
            this.label51.Text = "CV Feedback";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // technicalInterButton
            // 
            this.technicalInterButton.BackColor = System.Drawing.Color.White;
            this.technicalInterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicalInterButton.Location = new System.Drawing.Point(164, 75);
            this.technicalInterButton.Margin = new System.Windows.Forms.Padding(2);
            this.technicalInterButton.Name = "technicalInterButton";
            this.technicalInterButton.Size = new System.Drawing.Size(122, 21);
            this.technicalInterButton.TabIndex = 20;
            this.technicalInterButton.Text = "Technical Interview";
            this.technicalInterButton.UseVisualStyleBackColor = false;
            // 
            // interviewButton
            // 
            this.interviewButton.BackColor = System.Drawing.Color.White;
            this.interviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interviewButton.Location = new System.Drawing.Point(80, 76);
            this.interviewButton.Margin = new System.Windows.Forms.Padding(2);
            this.interviewButton.Name = "interviewButton";
            this.interviewButton.Size = new System.Drawing.Size(55, 21);
            this.interviewButton.TabIndex = 19;
            this.interviewButton.Text = "Interview";
            this.interviewButton.UseVisualStyleBackColor = false;
            // 
            // cvButton
            // 
            this.cvButton.BackColor = System.Drawing.Color.White;
            this.cvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvButton.Location = new System.Drawing.Point(22, 76);
            this.cvButton.Margin = new System.Windows.Forms.Padding(2);
            this.cvButton.Name = "cvButton";
            this.cvButton.Size = new System.Drawing.Size(42, 21);
            this.cvButton.TabIndex = 18;
            this.cvButton.Text = "CV";
            this.cvButton.UseVisualStyleBackColor = false;
            // 
            // label69
            // 
            this.label69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label69.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label69.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(0, 0);
            this.label69.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(439, 60);
            this.label69.TabIndex = 17;
            this.label69.Text = "Complete Feedback List";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sendBtnPanel
            // 
            this.sendBtnPanel.Controls.Add(this.button15);
            this.sendBtnPanel.Controls.Add(this.Send);
            this.sendBtnPanel.Controls.Add(this.button19);
            this.sendBtnPanel.Location = new System.Drawing.Point(2, 120);
            this.sendBtnPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendBtnPanel.Name = "sendBtnPanel";
            this.sendBtnPanel.Size = new System.Drawing.Size(78, 310);
            this.sendBtnPanel.TabIndex = 58;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(14, 70);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 40);
            this.button15.TabIndex = 16;
            this.button15.Text = "Back";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(14, 15);
            this.Send.Margin = new System.Windows.Forms.Padding(2);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(50, 40);
            this.Send.TabIndex = 10;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(8, 266);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(61, 34);
            this.button19.TabIndex = 7;
            this.button19.Text = "Log Out";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // hrBtnPanel
            // 
            this.hrBtnPanel.Controls.Add(this.button10);
            this.hrBtnPanel.Controls.Add(this.button4);
            this.hrBtnPanel.Controls.Add(this.button8);
            this.hrBtnPanel.Location = new System.Drawing.Point(45, 80);
            this.hrBtnPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hrBtnPanel.Name = "hrBtnPanel";
            this.hrBtnPanel.Size = new System.Drawing.Size(78, 310);
            this.hrBtnPanel.TabIndex = 59;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(8, 67);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 41);
            this.button10.TabIndex = 14;
            this.button10.Text = "Complete Feedback";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(8, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "Feedback";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(8, 266);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 34);
            this.button8.TabIndex = 7;
            this.button8.Text = "Log Out";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // feedbackPanel
            // 
            this.feedbackPanel.Controls.Add(this.label12);
            this.feedbackPanel.Controls.Add(this.label11);
            this.feedbackPanel.Controls.Add(this.label10);
            this.feedbackPanel.Controls.Add(this.label9);
            this.feedbackPanel.Controls.Add(this.richTextBox1);
            this.feedbackPanel.Controls.Add(this.label8);
            this.feedbackPanel.Controls.Add(this.checkBox3);
            this.feedbackPanel.Controls.Add(this.checkBox2);
            this.feedbackPanel.Controls.Add(this.checkBox1);
            this.feedbackPanel.Controls.Add(this.label7);
            this.feedbackPanel.Controls.Add(this.label6);
            this.feedbackPanel.Controls.Add(this.label5);
            this.feedbackPanel.Controls.Add(this.label4);
            this.feedbackPanel.Controls.Add(this.label3);
            this.feedbackPanel.Controls.Add(this.label2);
            this.feedbackPanel.Controls.Add(this.label13);
            this.feedbackPanel.Location = new System.Drawing.Point(127, 146);
            this.feedbackPanel.Margin = new System.Windows.Forms.Padding(2);
            this.feedbackPanel.Name = "feedbackPanel";
            this.feedbackPanel.Size = new System.Drawing.Size(439, 418);
            this.feedbackPanel.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(278, 392);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 15);
            this.label12.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(278, 368);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(198, 389);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Interviewer : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(196, 368);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Feedback Type :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(48, 224);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(327, 132);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Describe Your Feedback :";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(314, 167);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(91, 21);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Questions";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(198, 167);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Suggestion";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(74, 167);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Comments";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interviewee :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 2);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(439, 60);
            this.label13.TabIndex = 0;
            this.label13.Text = "Feedback";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HrScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.feedbackPanel);
            this.Controls.Add(this.hrBtnPanel);
            this.Controls.Add(this.sendBtnPanel);
            this.Controls.Add(this.completeFeedPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HrScreen";
            this.Text = "HrScreen";
            this.completeFeedPanel.ResumeLayout(false);
            this.technicalFeedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.interviewFeedPanel.ResumeLayout(false);
            this.cvFeedbackPanel.ResumeLayout(false);
            this.sendBtnPanel.ResumeLayout(false);
            this.hrBtnPanel.ResumeLayout(false);
            this.feedbackPanel.ResumeLayout(false);
            this.feedbackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel completeFeedPanel;
        private System.Windows.Forms.Panel technicalFeedPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Panel interviewFeedPanel;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Panel cvFeedbackPanel;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button technicalInterButton;
        private System.Windows.Forms.Button interviewButton;
        private System.Windows.Forms.Button cvButton;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Panel sendBtnPanel;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Panel hrBtnPanel;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel feedbackPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
    }
}