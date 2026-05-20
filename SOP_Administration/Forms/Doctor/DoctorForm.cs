using SOP_Administration.Forms.Doctor.Avability;
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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        { 
            InitializeComponent();
        }

        public void LoadData(DoctorETO doctorETO = null, bool isForm = true)
        { 
            doctorControl1.LoadData(doctorETO, isForm);
        }
    }
}
