namespace WinBookForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Hello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(74, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 384);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Hello
            // 
            this.Btn_Hello.Location = new System.Drawing.Point(1027, 53);
            this.Btn_Hello.Name = "Btn_Hello";
            this.Btn_Hello.Size = new System.Drawing.Size(174, 70);
            this.Btn_Hello.TabIndex = 1;
            this.Btn_Hello.Text = "Hello";
            this.Btn_Hello.UseVisualStyleBackColor = true;
            this.Btn_Hello.Click += new System.EventHandler(this.Btn_Hello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 561);
            this.Controls.Add(this.Btn_Hello);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Hello;
    }
}

