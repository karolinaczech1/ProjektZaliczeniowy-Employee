namespace ProjektZaliczeniowy
{
    partial class EditEmployee
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
            this.checkBoxIfCompany = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxNewCompany = new System.Windows.Forms.CheckBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labalName = new System.Windows.Forms.Label();
            this.txtBoxNewCompany = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPesel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxIfCompany
            // 
            this.checkBoxIfCompany.AutoSize = true;
            this.checkBoxIfCompany.Location = new System.Drawing.Point(58, 191);
            this.checkBoxIfCompany.Name = "checkBoxIfCompany";
            this.checkBoxIfCompany.Size = new System.Drawing.Size(97, 21);
            this.checkBoxIfCompany.TabIndex = 19;
            this.checkBoxIfCompany.Text = "Brak Firmy";
            this.checkBoxIfCompany.UseVisualStyleBackColor = true;
            this.checkBoxIfCompany.CheckedChanged += new System.EventHandler(this.checkBoxIfCompany_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(131, 345);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 34);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "ZAPISZ";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxNewCompany
            // 
            this.checkBoxNewCompany.AutoSize = true;
            this.checkBoxNewCompany.Location = new System.Drawing.Point(110, 270);
            this.checkBoxNewCompany.Name = "checkBoxNewCompany";
            this.checkBoxNewCompany.Size = new System.Drawing.Size(137, 21);
            this.checkBoxNewCompany.TabIndex = 17;
            this.checkBoxNewCompany.Text = "dodaj nową firmę";
            this.checkBoxNewCompany.UseVisualStyleBackColor = true;
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(110, 218);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(174, 24);
            this.comboBoxCompany.TabIndex = 16;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(55, 221);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(49, 17);
            this.labelCompany.TabIndex = 15;
            this.labelCompany.Text = "FIRMA";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(23, 104);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(81, 17);
            this.labelLastName.TabIndex = 14;
            this.labelLastName.Text = "NAZWISKO";
            // 
            // labalName
            // 
            this.labalName.AutoSize = true;
            this.labalName.Location = new System.Drawing.Point(70, 71);
            this.labalName.Name = "labalName";
            this.labalName.Size = new System.Drawing.Size(34, 17);
            this.labalName.TabIndex = 13;
            this.labalName.Text = "IMIE";
            // 
            // txtBoxNewCompany
            // 
            this.txtBoxNewCompany.Location = new System.Drawing.Point(110, 297);
            this.txtBoxNewCompany.Name = "txtBoxNewCompany";
            this.txtBoxNewCompany.Size = new System.Drawing.Size(174, 22);
            this.txtBoxNewCompany.TabIndex = 12;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(110, 101);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(174, 22);
            this.txtBoxLastName.TabIndex = 11;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(110, 66);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(174, 22);
            this.txtBoxName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "PESEL";
            // 
            // txtBoxPesel
            // 
            this.txtBoxPesel.Enabled = false;
            this.txtBoxPesel.Location = new System.Drawing.Point(110, 141);
            this.txtBoxPesel.Name = "txtBoxPesel";
            this.txtBoxPesel.Size = new System.Drawing.Size(174, 22);
            this.txtBoxPesel.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Enabled = false;
            this.txtBoxId.Location = new System.Drawing.Point(110, 31);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(174, 22);
            this.txtBoxId.TabIndex = 22;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPesel);
            this.Controls.Add(this.checkBoxIfCompany);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxNewCompany);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labalName);
            this.Controls.Add(this.txtBoxNewCompany);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxName);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIfCompany;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxNewCompany;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labalName;
        private System.Windows.Forms.TextBox txtBoxNewCompany;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPesel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxId;
    }
}