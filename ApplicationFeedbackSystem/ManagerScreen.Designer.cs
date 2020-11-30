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
            this.test2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test2Button
            // 
            this.test2Button.Location = new System.Drawing.Point(335, 173);
            this.test2Button.Name = "test2Button";
            this.test2Button.Size = new System.Drawing.Size(75, 23);
            this.test2Button.TabIndex = 0;
            this.test2Button.Text = "Try Me";
            this.test2Button.UseVisualStyleBackColor = true;
            this.test2Button.Click += new System.EventHandler(this.test2Button_Click);
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test2Button);
            this.Name = "ManagerScreen";
            this.Text = "ManagerScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test2Button;
    }
}