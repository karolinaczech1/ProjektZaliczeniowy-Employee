using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    public partial class EditEmployee : Form
    {
        private MainForm mainForm;
       
        public EditEmployee(MainForm main)
        {
            InitializeComponent();
            mainForm = main;           

            GetCompanies();

            //wczytanie danych pracownika
            txtBoxName.Text = mainForm.dgvEmployee.Rows[mainForm.dgvEmployee.CurrentRow.Index].Cells[1].Value.ToString();
            txtBoxLastName.Text = mainForm.dgvEmployee.Rows[mainForm.dgvEmployee.CurrentRow.Index].Cells[2].Value.ToString();
            
            if(mainForm.dgvEmployee.Rows[mainForm.dgvEmployee.CurrentRow.Index].Cells[3].Value == null) //jeśli pracownik nie ma przypisanej firmy
            {
                checkBoxIfCompany.Checked = true;             
            }
            else //jeśli pracownik ma przypisaną firmę
            {
                checkBoxIfCompany.Checked = false;
                comboBoxCompany.SelectedItem = mainForm.dgvEmployee.Rows[mainForm.dgvEmployee.CurrentRow.Index].Cells[3].Value.ToString();
            }

        }

        public mainEntities db = new mainEntities();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text != string.Empty && txtBoxLastName.Text != string.Empty)  //sprawdzenie, czy wpisano imie i nazwisko
            {
                string name = txtBoxName.Text;
                string lastName = txtBoxLastName.Text;

                //znalezienie id edytowanego pracownika
                long id = Convert.ToInt64(mainForm.dgvEmployee.Rows[mainForm.dgvEmployee.CurrentRow.Index].Cells[0].Value);
               

                //EDYCJA PRACOWNIKA BEZ FIRMY
                if (checkBoxIfCompany.Checked == true)
                {
                    EditEmployeeWithoutCompany(id, name, lastName);
                }
                //edycja pracownika z firmą
                else
                {
                    //EDYCJA PRACOWNIKA Z FIRMĄ WYBRANĄ Z ISTNIEJĄCYCH (z comboboxa)
                    if (checkBoxNewCompany.Checked == false)
                    {
                        if (comboBoxCompany.SelectedItem != null)   //sprawdzenie, czy wybrano firmę z istniejących
                        {
                            EditEmploeeWithCompany(id, name, lastName);
                        }
                    }
                    //EDYCJA PRACOWNIKA WRAZ Z DODANIEM NOWEJ FIRMY
                    else
                    {
                        if (txtBoxNewCompany.Text != string.Empty)   //sprawdzenie, czy uzytkownik wpisal nazwe nowej firmy
                        {
                            EditEmployeeAndAddCompany(id, name, lastName);
                        }
                    }
                }

            }
        }

        //edycja pracownika wraz z utworzeniem nowej firmy
        public void EditEmployeeAndAddCompany(long id, string name, string lastName)
        {
            List<Company> addedCompany = new List<Company>();
            string companyName = txtBoxNewCompany.Text;


            if (mainForm.isCompanyExist(companyName) == false)   //sprawdzenie, czy wpisana nazwa firmy na pewno nie istnieje
            {
                //dodanie nowej firmy
                long newCompanyId;
                if (db.Company.Count() > 0) newCompanyId = db.Company.Max(c => c.Id) + 1;
                else newCompanyId = 1;
                var newCompany = new Company
                {
                    Id = newCompanyId,
                    CompanyName = companyName,
                };
                db.Company.Add(newCompany);
                db.SaveChanges();

                //edycja pracownika z nową firmą
                addedCompany = (from c in db.Company where c.CompanyName == companyName select c).ToList();
                var selectedEmployee = db.Employee.Find(id);
                selectedEmployee.Name = name;
                selectedEmployee.LastName = lastName;
                selectedEmployee.CompanyId = addedCompany[0].Id;
                db.SaveChanges();
                mainForm.DisplayCompany();
                this.Close();
            }
            else  //jeśli dodawana firma już istnieje
            {
                MessageBox.Show("Firma " + companyName + " już istnieje - wybierz z listy");
                checkBoxNewCompany.Checked = false;
                comboBoxCompany.SelectedItem = companyName;
            }
        }

        //edycja pracownika z firmą(wybraną z comboboxa)
        public void EditEmploeeWithCompany(long id, string name, string lastName)
        {
            List<Company> company = new List<Company>();
            string selectedCompany = comboBoxCompany.SelectedItem.ToString();
            company = (from c in db.Company where c.CompanyName == selectedCompany select c).ToList();

            var selectedEmployee = db.Employee.Find(id);
            selectedEmployee.Name = name;
            selectedEmployee.LastName = lastName;
            selectedEmployee.CompanyId = company[0].Id;
            db.SaveChanges();
            this.Close();
        }

        //edycja pracownika bez firmy
        public void EditEmployeeWithoutCompany(long id, string name, string lastName)
        {         
            var selectedEmployee = db.Employee.Find(id);
            selectedEmployee.Name = name;
            selectedEmployee.LastName = lastName;
            selectedEmployee.CompanyId = null;
            db.SaveChanges();
            this.Close();
        }


        //checkbox "brak firmy" - zmiana zaznaczenia
        private void checkBoxIfCompany_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxIfCompany.Checked == true)
            {
                comboBoxCompany.Hide();
                txtBoxNewCompany.Hide();
                labelCompany.Hide();
                checkBoxNewCompany.Hide();
            }
            else
            {
                comboBoxCompany.Show();
                txtBoxNewCompany.Show();
                labelCompany.Show();
                checkBoxNewCompany.Show();
            }
        }

        //wczytanie firm do comboboxa
        public void GetCompanies()
        {
            List<string> companies = new List<string>();
            companies = (from c in db.Company select c.CompanyName).ToList();
            comboBoxCompany.DataSource = companies;
            comboBoxCompany.Refresh();
        }

       
    }
}
