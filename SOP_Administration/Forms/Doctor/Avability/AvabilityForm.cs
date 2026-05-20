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

namespace SOP_Administration.Forms.Doctor.Avability
{
    public partial class AvabilityForm : Form
    {
        public DoctorETO DoctorETO;
        public int AvabilityID;
        public AvabilityForm()
        {
            InitializeComponent();
        }

        public void LoadData(DoctorETO doctor, int avabilityID = 0)
        {
            DoctorETO = doctor;
            AvabilityID = avabilityID;
            if (avabilityID == 0)
            {
                dateTimePickerStart.Value = DateTime.Now;
                dateTimePickerEnd.Value = DateTime.Now;
            }
            else
            {
                var availabilityETO = doctor.Availabilites.First(x => x.ID == avabilityID);
                dateTimePickerStart.Value = availabilityETO.DayTimeStart;
                dateTimePickerEnd.Value = availabilityETO.DayTimeEnd;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (var availability in DoctorETO.Availabilites)
            {
                if (availability.ID != AvabilityID)
                {
                    continue;
                }

                availability.DayTimeStart = dateTimePickerStart.Value;
                availability.DayTimeEnd = dateTimePickerEnd.Value;
            }

            SOP_Administration.Models.Doctor.Put(DoctorETO);

            Close();
        }
    }
}
