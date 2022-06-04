namespace whole_project
{
    partial class chosse
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
            this.btn_emp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_adm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_emp
            // 
            this.btn_emp.Location = new System.Drawing.Point(207, 203);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.Size = new System.Drawing.Size(121, 66);
            this.btn_emp.TabIndex = 0;
            this.btn_emp.Text = "employee";
            this.btn_emp.UseVisualStyleBackColor = true;
            this.btn_emp.Click += new System.EventHandler(this.btn_emp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Do you want to sign up as customer or employee";
            // 
            // btn_adm
            // 
            this.btn_adm.Location = new System.Drawing.Point(364, 203);
            this.btn_adm.Name = "btn_adm";
            this.btn_adm.Size = new System.Drawing.Size(113, 66);
            this.btn_adm.TabIndex = 2;
            this.btn_adm.Text = "admin";
            this.btn_adm.UseVisualStyleBackColor = true;
            this.btn_adm.Click += new System.EventHandler(this.btn_adm_Click);
            // 
            // chosse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_adm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_emp);
            this.Name = "chosse";
            this.Text = "chosse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adm;
    }
}