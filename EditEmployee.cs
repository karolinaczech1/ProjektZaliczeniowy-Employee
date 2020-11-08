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
        }
    }
}
