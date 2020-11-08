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
    public partial class EditCompany : Form
    {
        private MainForm mainForm;
        public EditCompany(MainForm main)
        {
            InitializeComponent();
            mainForm = main;

            txtCompany.Text = mainForm.dgvCompany.Rows[mainForm.dgvCompany.CurrentRow.Index].Cells[1].Value.ToString();
        }

        public mainEntities db = new mainEntities();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(mainForm.dgvCompany.Rows[mainForm.dgvCompany.CurrentRow.Index].Cells[0].Value); //wyznaczenie id zaznaczonej firmy
            var selectedCompany = db.Company.Find(id);
            selectedCompany.CompanyName = txtCompany.Text;
            db.SaveChanges();
            this.Close();
        }
    }
}
