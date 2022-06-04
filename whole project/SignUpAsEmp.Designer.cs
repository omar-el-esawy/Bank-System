namespace whole_project
{
    partial class SignUpAsEmp
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeprojectDataSet = new whole_project.wholeprojectDataSet();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_ssn = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new whole_project.wholeprojectDataSetTableAdapters.customerTableAdapter();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeprojectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "phone ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "SSN ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Signing up new user";
            // 
            // txt_phone
            // 
            this.txt_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "phone", true));
            this.txt_phone.Location = new System.Drawing.Point(163, 392);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(429, 24);
            this.txt_phone.TabIndex = 15;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.wholeprojectDataSet;
            // 
            // wholeprojectDataSet
            // 
            this.wholeprojectDataSet.DataSetName = "wholeprojectDataSet";
            this.wholeprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_password
            // 
            this.txt_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "password", true));
            this.txt_password.Location = new System.Drawing.Point(163, 234);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(429, 24);
            this.txt_password.TabIndex = 16;
            // 
            // txt_ssn
            // 
            this.txt_ssn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "SSN", true));
            this.txt_ssn.Location = new System.Drawing.Point(163, 298);
            this.txt_ssn.Name = "txt_ssn";
            this.txt_ssn.Size = new System.Drawing.Size(429, 24);
            this.txt_ssn.TabIndex = 17;
            // 
            // txt_name
            // 
            this.txt_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name", true));
            this.txt_name.Location = new System.Drawing.Point(163, 85);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(429, 24);
            this.txt_name.TabIndex = 18;
            // 
            // txt_address
            // 
            this.txt_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address", true));
            this.txt_address.Location = new System.Drawing.Point(163, 351);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(429, 24);
            this.txt_address.TabIndex = 19;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // txt_userName
            // 
            this.txt_userName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "username", true));
            this.txt_userName.Location = new System.Drawing.Point(163, 158);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(429, 24);
            this.txt_userName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "User name";
            // 
            // SignUpAsEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_ssn);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_userName);
            this.Name = "SignUpAsEmp";
            this.Text = "SignUpAsEmp";
            this.Load += new System.EventHandler(this.SignUpAsEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeprojectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_ssn;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private wholeprojectDataSet wholeprojectDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private wholeprojectDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label label2;
    }
}