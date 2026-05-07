using SOP_Administration.Forms;
using SOP_Administration.HttpConnection;
using SOP_Administration.Models;
using SOP_ETOLibrary;

namespace SOP_Administration
{
    public partial class FormSOP : Form
    {
        public FormSOP()
        {
            InitializeComponent();
            HttpHandler handler = new HttpHandler();
            RefreshData();
        }

        private void RefreshData()
        {
            dataGridView1.DataSource = Patient.GetList();
        }

        //
        private void buttonNewPatient_Click(object sender, EventArgs e)
        {
            var form = new NewPatientForm();
            form.ShowDialog();
            RefreshData();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var form = new PatientEditForm();
            form.LoadData((PatientETO)dataGridView1.Rows[e.RowIndex].DataBoundItem);
            form.ShowDialog();
        }
    }
}
