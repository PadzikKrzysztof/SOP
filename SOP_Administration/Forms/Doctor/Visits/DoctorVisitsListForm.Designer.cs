namespace SOP_Administration.Forms.Doctor
{
    partial class DoctorVisitsListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            visitETOBindingSource = new BindingSource(components);
            availabilityETOBindingSource = new BindingSource(components);
            patientETOBindingSource = new BindingSource(components);
            doctorVisitBindingSource1 = new BindingSource(components);
            doctorVisitBindingSource = new BindingSource(components);
            dataGridView = new DataGridView();
            doctorVisitBindingSource2 = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientETODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientFileIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            visitIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)visitETOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)availabilityETOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientETOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorVisitBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorVisitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorVisitBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // visitETOBindingSource
            // 
            visitETOBindingSource.DataSource = typeof(SOP_ETOLibrary.VisitETO);
            // 
            // availabilityETOBindingSource
            // 
            availabilityETOBindingSource.DataSource = typeof(SOP_ETOLibrary.AvailabilityETO);
            // 
            // patientETOBindingSource
            // 
            patientETOBindingSource.DataSource = typeof(SOP_ETOLibrary.PatientETO);
            // 
            // doctorVisitBindingSource1
            // 
            doctorVisitBindingSource1.DataSource = typeof(Models.DoctorVisit);
            // 
            // doctorVisitBindingSource
            // 
            doctorVisitBindingSource.DataSource = typeof(Models.DoctorVisit);
            // 
            // dataGridView1
            // 
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, patientETODataGridViewTextBoxColumn, patientFileIDDataGridViewTextBoxColumn, visitIDDataGridViewTextBoxColumn, Column1 });
            dataGridView.DataSource = doctorVisitBindingSource2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView1";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(800, 450);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // doctorVisitBindingSource2
            // 
            doctorVisitBindingSource2.DataSource = typeof(Models.DoctorVisit);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Imię";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientETODataGridViewTextBoxColumn
            // 
            patientETODataGridViewTextBoxColumn.DataPropertyName = "PatientETO";
            patientETODataGridViewTextBoxColumn.HeaderText = "PatientETO";
            patientETODataGridViewTextBoxColumn.MinimumWidth = 6;
            patientETODataGridViewTextBoxColumn.Name = "patientETODataGridViewTextBoxColumn";
            patientETODataGridViewTextBoxColumn.Visible = false;
            patientETODataGridViewTextBoxColumn.Width = 125;
            // 
            // patientFileIDDataGridViewTextBoxColumn
            // 
            patientFileIDDataGridViewTextBoxColumn.DataPropertyName = "PatientFileID";
            patientFileIDDataGridViewTextBoxColumn.HeaderText = "PatientFileID";
            patientFileIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            patientFileIDDataGridViewTextBoxColumn.Name = "patientFileIDDataGridViewTextBoxColumn";
            patientFileIDDataGridViewTextBoxColumn.Visible = false;
            patientFileIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // visitIDDataGridViewTextBoxColumn
            // 
            visitIDDataGridViewTextBoxColumn.DataPropertyName = "VisitID";
            visitIDDataGridViewTextBoxColumn.HeaderText = "VisitID";
            visitIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            visitIDDataGridViewTextBoxColumn.Name = "visitIDDataGridViewTextBoxColumn";
            visitIDDataGridViewTextBoxColumn.Visible = false;
            visitIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Edytuj";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // DoctorVisitsListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Name = "DoctorVisitsListForm";
            Text = "Wizyty";
            ((System.ComponentModel.ISupportInitialize)visitETOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)availabilityETOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientETOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorVisitBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorVisitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorVisitBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource visitETOBindingSource;
        private BindingSource availabilityETOBindingSource;
        private BindingSource patientETOBindingSource;
        private BindingSource doctorVisitBindingSource;
        private BindingSource doctorVisitBindingSource1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientETODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientFileIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visitIDDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Column1;
        private BindingSource doctorVisitBindingSource2;
    }
}