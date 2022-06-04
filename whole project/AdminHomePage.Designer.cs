namespace whole_project
{
    partial class AdminHomePage
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
            this.btn_addbank = new System.Windows.Forms.Button();
            this.btn_addbranch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_updata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addbank
            // 
            this.btn_addbank.Location = new System.Drawing.Point(83, 163);
            this.btn_addbank.Name = "btn_addbank";
            this.btn_addbank.Size = new System.Drawing.Size(148, 73);
            this.btn_addbank.TabIndex = 0;
            this.btn_addbank.Text = "Add Bank";
            this.btn_addbank.UseVisualStyleBackColor = true;
            this.btn_addbank.Click += new System.EventHandler(this.btn_addbank_Click);
            // 
            // btn_addbranch
            // 
            this.btn_addbranch.Location = new System.Drawing.Point(323, 163);
            this.btn_addbranch.Name = "btn_addbranch";
            this.btn_addbranch.Size = new System.Drawing.Size(140, 72);
            this.btn_addbranch.TabIndex = 1;
            this.btn_addbranch.Text = "Add Branch";
            this.btn_addbranch.UseVisualStyleBackColor = true;
            this.btn_addbranch.Click += new System.EventHandler(this.btn_addbranch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "showing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_updata
            // 
            this.btn_updata.Location = new System.Drawing.Point(323, 283);
            this.btn_updata.Name = "btn_updata";
            this.btn_updata.Size = new System.Drawing.Size(140, 56);
            this.btn_updata.TabIndex = 3;
            this.btn_updata.Text = "updata info";
            this.btn_updata.UseVisualStyleBackColor = true;
            this.btn_updata.Click += new System.EventHandler(this.btn_updata_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_updata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addbranch);
            this.Controls.Add(this.btn_addbank);
            this.Name = "AdminHomePage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addbank;
        private System.Windows.Forms.Button btn_addbranch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_updata;
    }
}