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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DisplayEmployee();
            DisplayCompany();
        }


        
        public mainEntities db = new mainEntities();

        //wyświetlanie danych z bazy dotyczących pracowników w dataGridView
        public void DisplayEmployee()
        {

            BindingSource bs = new BindingSource();
            var query = from e in db.Employee
                        select new { e.Id, e.Name, e.LastName, e.Company.CompanyName };
            bs.DataSource = query.ToList();
            dgvEmployee.DataSource = bs;
            dgvEmployee.Refresh();
            dgvEmployee.Columns[0].HeaderText = "ID Pracownika";
            dgvEmployee.Columns[1].HeaderText = "Imie ";
            dgvEmployee.Columns[2].HeaderText = "Nazwisko ";
            dgvEmployee.Columns[3].HeaderText = "Nazwa Firmy";

        }

        //wyświetlanie danych z bazy dotyczących firm w dataGridView
        public void DisplayCompany()
        {
           
            BindingSource bs = new BindingSource();
            var query = from c in db.Company
                        select new { c.Id, c.CompanyName };
            bs.DataSource = query.ToList();          
            dgvCompany.DataSource = bs;
            dgvCompany.Refresh();
            dgvCompany.Columns[0].HeaderText = "ID Firmy";
            dgvCompany.Columns[1].HeaderText = "Nazwa Firmy";

        }



        //---------------------------- DODAWANIE DANYCH -------------------------- //

        //dodawanie nowego pracownika
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

            AddEmployeeForm NewEmployee = new AddEmployeeForm(this);
            NewEmployee.ShowDialog();  //otworzenie nowego okna
            DisplayCompany();
            DisplayEmployee();
       
        }
        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            if(txtBoxCompanyName.Text != string.Empty)
            {
                if (isCompanyExist(txtBoxCompanyName.Text) == false)
                {
                    var newCompany = new Company
                    {
                        Id = db.Company.Count() + 1,
                        CompanyName = txtBoxCompanyName.Text
                    };
                    db.Company.Add(newCompany);
                    db.SaveChanges();
                    DisplayCompany();
                    txtBoxCompanyName.Text = string.Empty;
                }
                else MessageBox.Show("Ta firma już istnieje");
            }
        }




        //---------------------------- USUWANIE DANYCH -------------------------- //


        //Przycisk do usuwania wybranej firmy z bazy poprzez wybranie jej w datagrid
        private void buttonDeleteCompan_Click(object sender, EventArgs e)
        {
            if (dgvCompany.SelectedRows.Count == 1)
            {
                long id = Convert.ToInt32(dgvCompany.Rows[dgvCompany.CurrentRow.Index].Cells[0].Value); //wyznaczenie id zaznaczonej firmy
                var selectedCompany = db.Company.Find(id);

                //wyszukanie pracownikow, ktorzy mają przypisaną firmę, którą chcemy usunąć
                List<Employee> employeeWithDeletedCompany =  (from em in db.Employee
                                                              where em.CompanyId == id
                                                              select em).ToList();
               //zamiana przypisanej firmy na null
                for(int i=0; i<employeeWithDeletedCompany.Count; i++)
                {
                   // MessageBox.Show(employeeWithDeletedCompany[i].Name +" - " + employeeWithDeletedCompany[i].CompanyId.ToString());
                    var employee = db.Employee.Find(employeeWithDeletedCompany[i].Id);
                    employee.CompanyId = null;
                    db.SaveChanges();
                }
                DisplayEmployee();

                //usuniecie firmy
                db.Company.Remove(selectedCompany);
                db.SaveChanges();
                DisplayCompany();

            }
        }

        //Przycisk do usuwania wybranego pracownika poprzez wybranie go w datagrid
        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvEmployee.Rows[dgvEmployee.CurrentRow.Index].Cells[0].Value); //wyznaczenie id zaznaczonego pracownika
                var selectedEmployee = db.Employee.Find(id);
                db.Employee.Remove(selectedEmployee);
                db.SaveChanges();
                DisplayEmployee();

            }
        }

        //---------------------------- EDYCJA DANYCH -------------------------- //
        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditCompan_Click(object sender, EventArgs e)
        {
            int currentRow = dgvCompany.CurrentRow.Index;
            EditCompany editCompany = new EditCompany(this);
            editCompany.ShowDialog();  //otworzenie nowego okna
            DisplayCompany();
            //dgvCompany.ClearSelection();
            //dgvCompany.Rows[currentRow].Selected = true;
            dgvCompany.CurrentCell = dgvCompany.Rows[currentRow].Cells[0];

        }



        //---------------------------- SPRAWDZENIE CZY ISTNIEJE -------------------------- //

        //sprawdzenie, czy dana firma już jest w bazie
        public bool isCompanyExist(string companyName)
        {
            List<Company> companies = new List<Company>();
            companies = (from c in db.Company select c).ToList();

            for(int i=0; i<companies.Count; i++)
            {
                if (companies[i].CompanyName.Equals(companyName))
                {
                    return true;
                }
            }
            return false;

        }

       
    }
}
