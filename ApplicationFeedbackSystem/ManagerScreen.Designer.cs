namespace ApplicationFeedbackSystem
{
    partial class ManagerScreen
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
            this.managerBtnPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.managerBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // managerBtnPanel
            // 
            this.managerBtnPanel.Controls.Add(this.button5);
            this.managerBtnPanel.Controls.Add(this.button6);
            this.managerBtnPanel.Location = new System.Drawing.Point(1, 71);
            this.managerBtnPanel.Name = "managerBtnPanel";
            this.managerBtnPanel.Size = new System.Drawing.Size(104, 382);
            this.managerBtnPanel.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 21);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 49);
            this.button5.TabIndex = 9;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 328);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 42);
            this.button6.TabIndex = 7;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.managerBtnPanel);
            this.Name = "ManagerScreen";
            this.Text = "ManagerScreen";
            this.managerBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel managerBtnPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}