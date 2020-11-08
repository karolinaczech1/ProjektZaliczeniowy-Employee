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
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            //SPRAWDZENIE, CZY WPISANO IMIE i NAZWISKO
            if (txtBoxName.Text != string.Empty && txtBoxName.Text != string.Empty)
            {
                string name = txtBoxName.Text;
                string lastName = txtBoxLastName.Text;
                
                //SPRAWDZENIE, CZY UŻYTKOWNIK CHCE DODAC FIRME DLA PRACOWNIKA
                if(checkBoxIfCompany.Checked == true)
                {
                    var newEmployee = new Employee
                    {
                        Id = db.Employee.Count() + 1,
                        Name = name,
                        LastName = lastName,
                        CompanyId = null
                    };
                    db.Employee.Add(newEmployee);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    //SPRAWDZENIE, CZY UŻYTKOWNIK CHCE WYBRAC FIRME Z ISTNIEJACYCH, CZY DODAC NOWĄ
                    if(checkBoxNewCompany.Checked == false)
                    {
                        //sprawdzenie, czy wybrano firmę z istniejących
                        if(comboBoxCompany.SelectedItem != null)
                        {
                            List<Company> company = new List<Company>();
                            string selectedCompany = comboBoxCompany.SelectedItem.ToString();
                            company = (from c in db.Company where c.CompanyName == selectedCompany select c).ToList();

                            var newEmployee = new Employee
                            {
                                Id = db.Employee.Count() + 1,
                                Name = name,
                                LastName = lastName,
                                CompanyId = company[0].Id
                            };
                            db.Employee.Add(newEmployee);
                            db.SaveChanges();
                            this.Close();
                        }
                        
                    }
                    else  //dodanie dodatkowo nowej firmy do bazy
                    {
                        //sprawdzenie, czy uzytkownik wpisal nazwe nowej firmy
                        if(txtBoxNewCompany.Text != string.Empty)
                        {
                            List<Company> addedCompany = new List<Company>();
                            string companyName = txtBoxNewCompany.Text;

                            //DODAWANIE NOWEJ FIRMY
                            //sprawdzenie, czy wpisana nazwa firmy na pewno nie istnieje
                            if (mainForm.isCompanyExist(companyName) == false)
                            {
                                var newCompany = new Company
                                {
                                    Id = db.Company.Count() + 1,
                                    CompanyName = companyName,
                                };
                                db.Company.Add(newCompany);
                                db.SaveChanges();


                                addedCompany = (from c in db.Company where c.CompanyName == companyName select c).ToList();
                                var newEmployee = new Employee
                                {
                                    Id = db.Employee.Count() + 1,
                                    Name = name,
                                    LastName = lastName,
                                    CompanyId = addedCompany[0].Id
                                };
                                db.Employee.Add(newEmployee);
                                db.SaveChanges();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Firma " + companyName + " już istnieje - wybierz z listy");
                                checkBoxNewCompany.Checked = false;
                                comboBoxCompany.SelectedItem = companyName;
                            }
                        }
                    }
                }

            }

        }

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

        //chceckbox - czy uzytkownik chce dodac nową firmę
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
