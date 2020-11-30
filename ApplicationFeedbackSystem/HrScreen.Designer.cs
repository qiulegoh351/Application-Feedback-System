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
            this.test1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test1Button
            // 
            this.test1Button.Location = new System.Drawing.Point(343, 203);
            this.test1Button.Name = "test1Button";
            this.test1Button.Size = new System.Drawing.Size(75, 23);
            this.test1Button.TabIndex = 0;
            this.test1Button.Text = "Try Me";
            this.test1Button.UseVisualStyleBackColor = true;
            this.test1Button.Click += new System.EventHandler(this.test1Button_Click);
            // 
            // HrScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test1Button);
            this.Name = "HrScreen";
            this.Text = "HrScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test1Button;
    }
}