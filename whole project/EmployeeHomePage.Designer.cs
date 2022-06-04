namespace whole_project
{
    partial class EmployeeHomePage
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
            this.btn_addCus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addCus
            // 
            this.btn_addCus.Location = new System.Drawing.Point(64, 185);
            this.btn_addCus.Name = "btn_addCus";
            this.btn_addCus.Size = new System.Drawing.Size(152, 57);
            this.btn_addCus.TabIndex = 0;
            this.btn_addCus.Text = "Add Customer";
            this.btn_addCus.UseVisualStyleBackColor = true;
            this.btn_addCus.Click += new System.EventHandler(this.btn_addCus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Take a loan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 185);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(145, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "showing";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmployeeHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addCus);
            this.Name = "EmployeeHomePage";
            this.Text = "EmployeeHomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addCus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}