namespace ProjektZaliczeniowy
{
    partial class AddEmployeeForm
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxNewCompany = new System.Windows.Forms.TextBox();
            this.labalName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.checkBoxNewCompany = new System.Windows.Forms.CheckBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.checkBoxIfCompany = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(129, 49);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(174, 22);
            this.txtBoxName.TabIndex = 0;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(129, 84);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(174, 22);
            this.txtBoxLastName.TabIndex = 1;
            // 
            // txtBoxNewCompany
            // 
            this.txtBoxNewCompany.Location = new System.Drawing.Point(129, 232);
            this.txtBoxNewCompany.Name = "txtBoxNewCompany";
            this.txtBoxNewCompany.Size = new System.Drawing.Size(174, 22);
            this.txtBoxNewCompany.TabIndex = 2;
            // 
            // labalName
            // 
            this.labalName.AutoSize = true;
            this.labalName.Location = new System.Drawing.Point(89, 54);
            this.labalName.Name = "labalName";
            this.labalName.Size = new System.Drawing.Size(34, 17);
            this.labalName.TabIndex = 3;
            this.labalName.Text = "IMIE";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(42, 87);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(81, 17);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "NAZWISKO";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(74, 156);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(49, 17);
            this.labelCompany.TabIndex = 5;
            this.labelCompany.Text = "FIRMA";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(129, 153);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(174, 24);
            this.comboBoxCompany.TabIndex = 6;
            // 
            // checkBoxNewCompany
            // 
            this.checkBoxNewCompany.AutoSize = true;
            this.checkBoxNewCompany.Location = new System.Drawing.Point(129, 205);
            this.checkBoxNewCompany.Name = "checkBoxNewCompany";
            this.checkBoxNewCompany.Size = new System.Drawing.Size(137, 21);
            this.checkBoxNewCompany.TabIndex = 7;
            this.checkBoxNewCompany.Text = "dodaj nową firmę";
            this.checkBoxNewCompany.UseVisualStyleBackColor = true;
            this.checkBoxNewCompany.CheckedChanged += new System.EventHandler(this.checkBoxNewCompany_CheckedChanged);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(150, 284);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(116, 34);
            this.buttonAddEmployee.TabIndex = 8;
            this.buttonAddEmployee.Text = "DODAJ";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // checkBoxIfCompany
            // 
            this.checkBoxIfCompany.AutoSize = true;
            this.checkBoxIfCompany.Location = new System.Drawing.Point(77, 126);
            this.checkBoxIfCompany.Name = "checkBoxIfCompany";
            this.checkBoxIfCompany.Size = new System.Drawing.Size(97, 21);
            this.checkBoxIfCompany.TabIndex = 9;
            this.checkBoxIfCompany.Text = "Brak Firmy";
            this.checkBoxIfCompany.UseVisualStyleBackColor = true;
            this.checkBoxIfCompany.CheckedChanged += new System.EventHandler(this.checkBoxIfCompany_CheckedChanged);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 338);
            this.Controls.Add(this.checkBoxIfCompany);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.checkBoxNewCompany);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labalName);
            this.Controls.Add(this.txtBoxNewCompany);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxName);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxNewCompany;
        private System.Windows.Forms.Label labalName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.CheckBox checkBoxNewCompany;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.CheckBox checkBoxIfCompany;
    }
}