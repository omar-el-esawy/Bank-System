namespace whole_project
{
    partial class updataAdmin
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
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_updata = new System.Windows.Forms.Button();
            this.wholeprojectDataSet1 = new whole_project.wholeprojectDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wholeprojectDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(54, 442);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(117, 46);
            this.bt_save.TabIndex = 0;
            this.bt_save.Text = "save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_updata
            // 
            this.bt_updata.Location = new System.Drawing.Point(223, 442);
            this.bt_updata.Name = "bt_updata";
            this.bt_updata.Size = new System.Drawing.Size(117, 45);
            this.bt_updata.TabIndex = 1;
            this.bt_updata.Text = "updata";
            this.bt_updata.UseVisualStyleBackColor = true;
            this.bt_updata.Click += new System.EventHandler(this.bt_updata_Click);
            // 
            // wholeprojectDataSet1
            // 
            this.wholeprojectDataSet1.DataSetName = "wholeprojectDataSet";
            this.wholeprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "phone ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Updata up new user";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(151, 343);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(429, 24);
            this.txt_phone.TabIndex = 29;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(151, 245);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(429, 24);
            this.txt_password.TabIndex = 30;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(151, 96);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(429, 24);
            this.txt_name.TabIndex = 32;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(151, 302);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(429, 24);
            this.txt_address.TabIndex = 33;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(151, 169);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(429, 24);
            this.txt_userName.TabIndex = 34;
            // 
            // updataAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.bt_updata);
            this.Controls.Add(this.bt_save);
            this.Name = "updataAdmin";
            this.Text = "updataInfo";
            ((System.ComponentModel.ISupportInitialize)(this.wholeprojectDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_updata;
        private wholeprojectDataSet wholeprojectDataSet1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_userName;
    }
}