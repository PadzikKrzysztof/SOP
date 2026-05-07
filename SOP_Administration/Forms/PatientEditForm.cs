using SOP_Administration.Models;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOP_Administration.Forms
{
    public partial class PatientEditForm : Form
    {
        public PatientETO Patient { get; set; }

        public PatientEditForm()
        {
            InitializeComponent();
        }

        public void LoadData(PatientETO patient)
        {
            Patient = patient;
            textBoxName.Text = Patient.Name;
            textBoxSurname.Text = Patient.Surname;
            textBoxPesel.Text = Patient.PESEL.ToString();
            dataGridView1.DataSource = Patient.PatientFiles;
        }
    }
}
