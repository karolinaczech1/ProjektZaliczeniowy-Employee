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

            //odnalezienie ścieżki do bazy danych 
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            String dir = System.IO.Path.GetDirectoryName(executable);
            string root = System.IO.Directory.GetParent(dir).FullName;
            root = root.Replace("bin", "");
            AppDomain.CurrentDomain.SetData("DataDirectory", root);

            DisplayEmployee();
            DisplayCompany();

            GetDgvEmloyeeColumns();
            comboBoxSearch.SelectedIndex = 0;
            GetDgvCompanyColumns();
            comboBoxSearchCompany.SelectedIndex = 1;

        }


        
        public mainEntities db = new mainEntities();



        


        //----------------------------------- DODAWANIE DANYCH ------------------------------------------------------- //

        //dodawanie nowego pracownika
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

            AddEmployeeForm NewEmployee = new AddEmployeeForm(this);
            NewEmployee.ShowDialog();  //otworzenie nowego okna
            DisplayEmployee();
           
       
        }
        //dodwanie nowej firmy
        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            if(txtBoxCompanyName.Text != string.Empty)
            {
                if (isCompanyExist(txtBoxCompanyName.Text) == false)
                {
                    //wyzanczenie id dla dodawanej firmy
                    long id;
                    if (db.Company.Count() > 0) id = db.Company.Max(c => c.Id) + 1;
                    else id = 1;
                    
                    var newCompany = new Company
                    {
                        Id = id,
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




        //----------------------------------------- USUWANIE DANYCH ------------------------------------------------ //


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



        //-------------------------------------- EDYCJA DANYCH ---------------------------------------------- //
        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            if(dgvEmployee.RowCount > 0)
            {              
                EditEmployee editEmployee = new EditEmployee(this);
                editEmployee.ShowDialog();
                DisplayEmployee();
            }
           
        }

        private void buttonEditCompan_Click(object sender, EventArgs e)
        {
            if (dgvCompany.RowCount > 0)
            {
                int currentRow = dgvCompany.CurrentRow.Index;
                EditCompany editCompany = new EditCompany(this);
                editCompany.ShowDialog();  //otworzenie nowego okna
                DisplayCompany();
                //dgvCompany.ClearSelection();
                //dgvCompany.Rows[currentRow].Selected = true;
                dgvCompany.CurrentCell = dgvCompany.Rows[currentRow].Cells[0];
            }

        }



        //-----------------------------------  WYSZUKIWANIE PRACOWNIKA  ---------------------------------------------//

        //wyszukiwanie podczas zmiany tekstu w textboxie do wszukiwania pracownika
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        //zmiana kolumny wyszukiwania
        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        //--------------------------WYSZUKIWANIE FIRMY -------------------------------------//

        //wyszukiwanie podczas zmiany tekstu w textboxie do wszukiwania firmy
        private void txtBoxSearchCompany_TextChanged(object sender, EventArgs e)
        {
            SearchCompany();
        }

        //zmiana kolumny wyszukiwania
        private void comboBoxSearchCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCompany();
        }







        //********************************************   FUNKCJE   *************************************************//




        //funkcja do wyszukiwania firmy
        public void SearchCompany()
        {
            if(txtBoxSearchCompany.Text == string.Empty)
            {
                DisplayCompany();
            }
            else
            {
                string searched = txtBoxSearchCompany.Text.ToUpper();

                if(comboBoxSearchCompany.SelectedIndex == 0)  //szukanie w kolumnie "Id Firmy"
                {
                    int id;
                    bool isNumeric = int.TryParse(searched, out id);
                    if (isNumeric == true)
                    {
                        BindingSource bs = new BindingSource();
                        bs.DataSource = (from co in db.Company
                                         where co.Id == id
                                         select new { co.Id, co.CompanyName } ).ToList();
                        dgvCompany.DataSource = bs;

                    }
                }
                else  //szukanie w kolumnie "Nazwa Firmy"
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = (from co in db.Company
                                     where co.CompanyName.ToUpper().Contains(searched)
                                     select new { co.Id, co.CompanyName }).ToList();
                    dgvCompany.DataSource = bs;
                }

                dgvCompany.Refresh();
                dgvCompany.Columns[0].HeaderText = "ID Firmy";
                dgvCompany.Columns[1].HeaderText = "Nazwa Firmy";

            }
        }

        //funkcja do wyszukiwania pracownika
        public void SearchEmployee()
        {
            if (txtBoxSearch.Text == string.Empty)
            {
                DisplayEmployee();
            }
            else
            {
                string searched = txtBoxSearch.Text.ToUpper();

                if (comboBoxSearch.SelectedIndex == 0)  //szukanie w kolumnie "ID Pracownika"
                {
                    int id;
                    bool isNumeric = int.TryParse(searched, out id);
                    if (isNumeric == true)
                    {
                        BindingSource bs = new BindingSource();
                        bs.DataSource = (from em in db.Employee
                                         where em.Id == id
                                         select new { em.Id, em.Name, em.LastName, em.Company.CompanyName }).ToList();
                        dgvEmployee.DataSource = bs;

                    }
                }
                else if (comboBoxSearch.SelectedIndex == 1)  //szukanie w kolumnie "Imie"
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = (from em in db.Employee
                                     where em.Name.ToUpper().Contains(searched)
                                     select new { em.Id, em.Name, em.LastName, em.Company.CompanyName }).ToList();
                    dgvEmployee.DataSource = bs;

                }
                else if (comboBoxSearch.SelectedIndex == 2)  //szukanie w kolumnie "Nazwisko"
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = (from em in db.Employee
                                     where em.LastName.ToUpper().Contains(searched)
                                     select new { em.Id, em.Name, em.LastName, em.Company.CompanyName }).ToList();
                    dgvEmployee.DataSource = bs;
                }
                else  //szukanie w kolumnie "Nazwa firmy"
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = (from em in db.Employee
                                     where em.Company.CompanyName.ToUpper().Contains(searched)
                                     select new { em.Id, em.Name, em.LastName, em.Company.CompanyName }).ToList();
                    dgvEmployee.DataSource = bs;
                }

                dgvEmployee.Refresh();
                dgvEmployee.Columns[0].HeaderText = "ID Pracownika";
                dgvEmployee.Columns[1].HeaderText = "Imie ";
                dgvEmployee.Columns[2].HeaderText = "Nazwisko ";
                dgvEmployee.Columns[3].HeaderText = "Nazwa Firmy";
            }
        }


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


        //wypełnienie comboboxa  kolumnami datagrid, będącego częścią wyszukiwania pracowników
        public void GetDgvEmloyeeColumns()
        {
            comboBoxSearch.Items.Clear();
            comboBoxSearch.Items.Add("ID Pracownika");
            comboBoxSearch.Items.Add("Imie");
            comboBoxSearch.Items.Add("Nazwisko");
            comboBoxSearch.Items.Add("Nazwa Firmy");
        }

        //wypełnienie comboboxa  kolumnami datagrid, będącego częścią wyszukiwania firm
        public void GetDgvCompanyColumns()
        {
            comboBoxSearchCompany.Items.Clear();
            comboBoxSearchCompany.Items.Add("ID Firmy");
            comboBoxSearchCompany.Items.Add("Nazwa Firmy");
        }


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
