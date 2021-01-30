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
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
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
            this.txtBoxSearchCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSearchCompany = new System.Windows.Forms.ComboBox();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(12, 33);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(218, 22);
            this.txtBoxSearch.TabIndex = 1;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
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
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
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
            // txtBoxSearchCompany
            // 
            this.txtBoxSearchCompany.Location = new System.Drawing.Point(626, 30);
            this.txtBoxSearchCompany.Name = "txtBoxSearchCompany";
            this.txtBoxSearchCompany.Size = new System.Drawing.Size(158, 22);
            this.txtBoxSearchCompany.TabIndex = 15;
            this.txtBoxSearchCompany.TextChanged += new System.EventHandler(this.txtBoxSearchCompany_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(790, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "szukaj w";
            // 
            // comboBoxSearchCompany
            // 
            this.comboBoxSearchCompany.FormattingEnabled = true;
            this.comboBoxSearchCompany.Location = new System.Drawing.Point(857, 30);
            this.comboBoxSearchCompany.Name = "comboBoxSearchCompany";
            this.comboBoxSearchCompany.Size = new System.Drawing.Size(161, 24);
            this.comboBoxSearchCompany.TabIndex = 17;
            this.comboBoxSearchCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchCompany_SelectedIndexChanged);
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancelSearch.Location = new System.Drawing.Point(470, 18);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(102, 47);
            this.btnCancelSearch.TabIndex = 18;
            this.btnCancelSearch.Text = "Anuluj wyszukiwanie";
            this.btnCancelSearch.UseVisualStyleBackColor = true;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1070, 455);
            this.Controls.Add(this.btnCancelSearch);
            this.Controls.Add(this.comboBoxSearchCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSearchCompany);
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
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonEditCompan;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonAddCompany;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonDeleteCompan;
        private System.Windows.Forms.TextBox txtBoxCompanyName;
        private System.Windows.Forms.Label labelCompanyName;
        public System.Windows.Forms.DataGridView dgvCompany;
        public System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox txtBoxSearchCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSearchCompany;
        private System.Windows.Forms.Button btnCancelSearch;
    }
}

