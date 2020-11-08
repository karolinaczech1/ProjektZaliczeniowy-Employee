namespace ProjektZaliczeniowy
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.dataGridCompany = new System.Windows.Forms.DataGridView();
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.buttonEditCompan = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonAddCompany = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteCompan = new System.Windows.Forms.Button();
            this.dgvCompany = new System.Windows.Forms.DataGridView();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.txtBoxCompanyName = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.AllowUserToAddRows = false;
            this.dataGridEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.lastname,
            this.company});
            this.dataGridEmployee.Location = new System.Drawing.Point(12, 433);
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.ReadOnly = true;
            this.dataGridEmployee.RowHeadersWidth = 51;
            this.dataGridEmployee.RowTemplate.Height = 24;
            this.dataGridEmployee.Size = new System.Drawing.Size(578, 251);
            this.dataGridEmployee.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 75;
            // 
            // name
            // 
            this.name.HeaderText = "Imie";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Nazwisko";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            this.lastname.Width = 125;
            // 
            // company
            // 
            this.company.HeaderText = "Firma";
            this.company.MinimumWidth = 6;
            this.company.Name = "company";
            this.company.ReadOnly = true;
            this.company.Width = 200;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(12, 33);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(218, 22);
            this.txtBoxSearch.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(236, 33);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(61, 17);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "szukaj w";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(303, 30);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(161, 24);
            this.comboBoxSearch.TabIndex = 3;
            // 
            // dataGridCompany
            // 
            this.dataGridCompany.AllowUserToAddRows = false;
            this.dataGridCompany.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyId,
            this.ComanyName});
            this.dataGridCompany.Location = new System.Drawing.Point(626, 433);
            this.dataGridCompany.Name = "dataGridCompany";
            this.dataGridCompany.ReadOnly = true;
            this.dataGridCompany.RowHeadersWidth = 51;
            this.dataGridCompany.RowTemplate.Height = 24;
            this.dataGridCompany.Size = new System.Drawing.Size(332, 251);
            this.dataGridCompany.TabIndex = 4;
            // 
            // CompanyId
            // 
            this.CompanyId.HeaderText = "ID";
            this.CompanyId.MinimumWidth = 10;
            this.CompanyId.Name = "CompanyId";
            this.CompanyId.ReadOnly = true;
            this.CompanyId.Width = 75;
            // 
            // ComanyName
            // 
            this.ComanyName.HeaderText = "Nazwa Firmy";
            this.ComanyName.MinimumWidth = 50;
            this.ComanyName.Name = "ComanyName";
            this.ComanyName.ReadOnly = true;
            this.ComanyName.Width = 200;
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Location = new System.Drawing.Point(12, 348);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(84, 28);
            this.buttonEditEmployee.TabIndex = 5;
            this.buttonEditEmployee.Text = "Edytuj";
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // buttonEditCompan
            // 
            this.buttonEditCompan.Location = new System.Drawing.Point(626, 348);
            this.buttonEditCompan.Name = "buttonEditCompan";
            this.buttonEditCompan.Size = new System.Drawing.Size(86, 28);
            this.buttonEditCompan.TabIndex = 6;
            this.buttonEditCompan.Text = "Edytuj";
            this.buttonEditCompan.UseVisualStyleBackColor = true;
            this.buttonEditCompan.Click += new System.EventHandler(this.buttonEditCompan_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(102, 348);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(138, 28);
            this.buttonAddEmployee.TabIndex = 7;
            this.buttonAddEmployee.Text = "Dodaj pracownika";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonAddCompany
            // 
            this.buttonAddCompany.Location = new System.Drawing.Point(810, 382);
            this.buttonAddCompany.Name = "buttonAddCompany";
            this.buttonAddCompany.Size = new System.Drawing.Size(138, 28);
            this.buttonAddCompany.TabIndex = 8;
            this.buttonAddCompany.Text = "Dodaj firmę";
            this.buttonAddCompany.UseVisualStyleBackColor = true;
            this.buttonAddCompany.Click += new System.EventHandler(this.buttonAddCompany_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(12, 382);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(84, 28);
            this.buttonDeleteEmployee.TabIndex = 9;
            this.buttonDeleteEmployee.Text = "Usuń";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonDeleteCompan
            // 
            this.buttonDeleteCompan.Location = new System.Drawing.Point(626, 382);
            this.buttonDeleteCompan.Name = "buttonDeleteCompan";
            this.buttonDeleteCompan.Size = new System.Drawing.Size(84, 28);
            this.buttonDeleteCompan.TabIndex = 10;
            this.buttonDeleteCompan.Text = "Usuń";
            this.buttonDeleteCompan.UseVisualStyleBackColor = true;
            this.buttonDeleteCompan.Click += new System.EventHandler(this.buttonDeleteCompan_Click);
            // 
            // dgvCompany
            // 
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Location = new System.Drawing.Point(626, 77);
            this.dgvCompany.MultiSelect = false;
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.ReadOnly = true;
            this.dgvCompany.RowHeadersWidth = 51;
            this.dgvCompany.RowTemplate.Height = 24;
            this.dgvCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompany.Size = new System.Drawing.Size(332, 251);
            this.dgvCompany.TabIndex = 11;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 77);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(578, 251);
            this.dgvEmployee.TabIndex = 12;
            // 
            // txtBoxCompanyName
            // 
            this.txtBoxCompanyName.Location = new System.Drawing.Point(810, 354);
            this.txtBoxCompanyName.Name = "txtBoxCompanyName";
            this.txtBoxCompanyName.Size = new System.Drawing.Size(138, 22);
            this.txtBoxCompanyName.TabIndex = 13;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(807, 334);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(82, 17);
            this.labelCompanyName.TabIndex = 14;
            this.labelCompanyName.Text = "nazwa firmy";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1087, 686);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.txtBoxCompanyName);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.dgvCompany);
            this.Controls.Add(this.buttonDeleteCompan);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonAddCompany);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonEditCompan);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.dataGridCompany);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.dataGridEmployee);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridEmployee;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.DataGridView dataGridCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComanyName;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonEditCompan;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonAddCompany;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonDeleteCompan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.TextBox txtBoxCompanyName;
        private System.Windows.Forms.Label labelCompanyName;
        public System.Windows.Forms.DataGridView dgvCompany;
        public System.Windows.Forms.DataGridView dgvEmployee;
    }
}

