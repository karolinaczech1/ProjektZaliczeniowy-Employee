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
   
    public partial class AddEmployeeForm : Form
    {
        private MainForm mainForm;
        public AddEmployeeForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;

            txtBoxNewCompany.Hide();

            GetCompanies();

        }

        public mainEntities db = new mainEntities();

        //przycisk do dodawania pracownika
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            
            if (txtBoxName.Text != string.Empty && txtBoxLastName.Text != string.Empty)  //sprawdzenie, czy wpisano imie i nazwisko
            {
                string name = txtBoxName.Text;
                string lastName = txtBoxLastName.Text;

                //wyzanczenie id dla dodawanego pracownika
                long id;
                if (db.Employee.Count() > 0) id = db.Employee.Max(em => em.Id) + 1;
                else id = 1;

                //DODAWANIE PRACOWNIKA BEZ FIRMY
                if (checkBoxIfCompany.Checked == true)
                {
                    AddEmployeeWithoutCompany(id, name, lastName);               
                }
                //dodawanie pracownika z firmą
                else
                {
                    //DODAWANIE PRACOWNIKA Z FIRMĄ WYBRANĄ Z ISTNIEJĄCYCH (z comboboxa)
                    if(checkBoxNewCompany.Checked == false)
                    {                      
                        if(comboBoxCompany.SelectedItem != null)   //sprawdzenie, czy wybrano firmę z istniejących
                        {

                            AddEmployeeWithCompany(id, name, lastName);
                            
                        }                     
                    }
                    //DODAWANIE PRACOWNIKA WRAZ Z DODANIEM NOWEJ FIRMY
                    else 
                    {                      
                        if(txtBoxNewCompany.Text != string.Empty)   //sprawdzenie, czy uzytkownik wpisal nazwe nowej firmy
                        {
                            AddEmployeeAndCompany(id, name,  lastName);                        
                        }
                    }
                }

            }

        }



        //dodawanie pracownika bez firmy
        public void AddEmployeeWithoutCompany(long id, string name, string lastName)
        {
            var newEmployee = new Employee
            {
                Id = id,
                Name = name,
                LastName = lastName,
                CompanyId = null
            };

            db.Employee.Add(newEmployee);
            db.SaveChanges();
            this.Close();
        }

        //dodawanie pracownika z firmą (wybraną z comboboxa)
        public void AddEmployeeWithCompany(long id, string name, string lastName)
        {
            List<Company> company = new List<Company>();
            string selectedCompany = comboBoxCompany.SelectedItem.ToString();
            company = (from c in db.Company where c.CompanyName == selectedCompany select c).ToList();

            var newEmployee = new Employee
            {
                Id = id,
                Name = name,
                LastName = lastName,
                CompanyId = company[0].Id
            };
            db.Employee.Add(newEmployee);
            db.SaveChanges();
            this.Close();
        }

        //dodawanie pracownika wraz z utworzeniem nowej firmy
        public void AddEmployeeAndCompany(long id, string name, string lastName)
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

                //dodnie pracownika z nową firmą
                addedCompany = (from c in db.Company where c.CompanyName == companyName select c).ToList();
                var newEmployee = new Employee
                {
                    Id = id,
                    Name = name,
                    LastName = lastName,
                    CompanyId = addedCompany[0].Id
                };
                db.Employee.Add(newEmployee);
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





        //wprowadzenie wszystkich firm do comboboxa
        public void GetCompanies()
        {
            List<string> companies = new List<string>();
            companies = (from c in db.Company select c.CompanyName).ToList();
            comboBoxCompany.DataSource = companies;
            comboBoxCompany.Refresh();
        }


        //chceckbox - czy uzytkownik chce dodac firmę dla pracownika
        private void checkBoxIfCompany_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxIfCompany.Checked == true)
            {
                labelCompany.Hide();
                comboBoxCompany.Hide();
                checkBoxNewCompany.Hide();
            }
            else
            {
                labelCompany.Show();
                comboBoxCompany.Show();
                checkBoxNewCompany.Show();
            }
        }

        //chceckbox - czy uzytkownik chce dodac nową firmę podczas dodawania pracownika
        private void checkBoxNewCompany_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxNewCompany.Checked == true)
            {
                txtBoxNewCompany.Show();
            }
            else
            {
                txtBoxNewCompany.Hide();
            }
        }
    }
}
