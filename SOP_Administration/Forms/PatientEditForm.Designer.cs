namespace SOP_Administration.Forms
{
    partial class PatientEditForm
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
            dataGridView = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientFileETOBindingSource = new BindingSource(components);
            buttonNewPatientFile = new Button();
            buttonSave = new Button();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPesel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridViewVisit = new DataGridView();
            iDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Doctor = new DataGridViewTextBoxColumn();
            visitsBindingSource = new BindingSource(components);
            dataGridViewLAbTest = new DataGridView();
            iDDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            specificDataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            labTestsBindingSource = new BindingSource(components);
            buttonAddVisit = new Button();
            buttonEditVisit = new Button();
            buttonDeleteVisit = new Button();
            buttonDeleteTest = new Button();
            buttonEditTest = new Button();
            buttonAddTest = new Button();
            buttonRefresh = new Button();
            buttonEditFile = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientFileETOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVisit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLAbTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)labTestsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridView.DataSource = patientFileETOBindingSource;
            dataGridView.Location = new Point(272, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(541, 457);
            dataGridView.TabIndex = 0;
            dataGridView.Click += dataGridView_Click;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Visible = false;
            iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Opis";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientFileETOBindingSource
            // 
            patientFileETOBindingSource.DataSource = typeof(SOP_ETOLibrary.PatientFileETO);
            // 
            // buttonNewPatientFile
            // 
            buttonNewPatientFile.Location = new Point(272, 476);
            buttonNewPatientFile.Name = "buttonNewPatientFile";
            buttonNewPatientFile.Size = new Size(541, 29);
            buttonNewPatientFile.TabIndex = 1;
            buttonNewPatientFile.Text = "Dodaj kartotekę";
            buttonNewPatientFile.UseVisualStyleBackColor = true;
            buttonNewPatientFile.Click += buttonNewPatientFile_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 208);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(254, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Zapisz";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 34);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(254, 27);
            textBoxName.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(12, 87);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(254, 27);
            textBoxSurname.TabIndex = 5;
            // 
            // textBoxPesel
            // 
            textBoxPesel.Location = new Point(12, 140);
            textBoxPesel.Name = "textBoxPesel";
            textBoxPesel.Size = new Size(254, 27);
            textBoxPesel.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 7;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 8;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 9;
            label3.Text = "Pesel";
            // 
            // dataGridViewVisit
            // 
            dataGridViewVisit.AutoGenerateColumns = false;
            dataGridViewVisit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVisit.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn1, dayDataGridViewTextBoxColumn, Doctor });
            dataGridViewVisit.DataSource = visitsBindingSource;
            dataGridViewVisit.Location = new Point(819, 11);
            dataGridViewVisit.Name = "dataGridViewVisit";
            dataGridViewVisit.RowHeadersWidth = 51;
            dataGridViewVisit.Size = new Size(405, 458);
            dataGridViewVisit.TabIndex = 10;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            iDDataGridViewTextBoxColumn1.Visible = false;
            iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            dayDataGridViewTextBoxColumn.HeaderText = "Day";
            dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            dayDataGridViewTextBoxColumn.Width = 125;
            // 
            // Doctor
            // 
            Doctor.DataPropertyName = "Doctor";
            Doctor.HeaderText = "Doctor";
            Doctor.MinimumWidth = 6;
            Doctor.Name = "Doctor";
            Doctor.Width = 125;
            // 
            // visitsBindingSource
            // 
            visitsBindingSource.DataMember = "Visits";
            visitsBindingSource.DataSource = patientFileETOBindingSource;
            // 
            // dataGridViewLAbTest
            // 
            dataGridViewLAbTest.AutoGenerateColumns = false;
            dataGridViewLAbTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLAbTest.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn2, nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn1, specificDataDataGridViewTextBoxColumn });
            dataGridViewLAbTest.DataSource = labTestsBindingSource;
            dataGridViewLAbTest.Location = new Point(1230, 12);
            dataGridViewLAbTest.Name = "dataGridViewLAbTest";
            dataGridViewLAbTest.RowHeadersWidth = 51;
            dataGridViewLAbTest.Size = new Size(469, 458);
            dataGridViewLAbTest.TabIndex = 11;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            iDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            iDDataGridViewTextBoxColumn2.Visible = false;
            iDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Nazwa";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Opis";
            descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            descriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // specificDataDataGridViewTextBoxColumn
            // 
            specificDataDataGridViewTextBoxColumn.DataPropertyName = "SpecificData";
            specificDataDataGridViewTextBoxColumn.HeaderText = "SpecificData";
            specificDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            specificDataDataGridViewTextBoxColumn.Name = "specificDataDataGridViewTextBoxColumn";
            specificDataDataGridViewTextBoxColumn.Visible = false;
            specificDataDataGridViewTextBoxColumn.Width = 125;
            // 
            // labTestsBindingSource
            // 
            labTestsBindingSource.DataMember = "LabTests";
            labTestsBindingSource.DataSource = patientFileETOBindingSource;
            // 
            // buttonAddVisit
            // 
            buttonAddVisit.Location = new Point(819, 475);
            buttonAddVisit.Name = "buttonAddVisit";
            buttonAddVisit.Size = new Size(405, 29);
            buttonAddVisit.TabIndex = 12;
            buttonAddVisit.Text = "Dodaj Wizytę";
            buttonAddVisit.UseVisualStyleBackColor = true;
            buttonAddVisit.Click += buttonAddVisit_Click;
            // 
            // buttonEditVisit
            // 
            buttonEditVisit.Location = new Point(819, 510);
            buttonEditVisit.Name = "buttonEditVisit";
            buttonEditVisit.Size = new Size(405, 29);
            buttonEditVisit.TabIndex = 13;
            buttonEditVisit.Text = "Otwórz wizytę";
            buttonEditVisit.UseVisualStyleBackColor = true;
            buttonEditVisit.Click += buttonEditVisit_Click;
            // 
            // buttonDeleteVisit
            // 
            buttonDeleteVisit.Location = new Point(819, 545);
            buttonDeleteVisit.Name = "buttonDeleteVisit";
            buttonDeleteVisit.Size = new Size(405, 29);
            buttonDeleteVisit.TabIndex = 14;
            buttonDeleteVisit.Text = "Usuń Wizytę";
            buttonDeleteVisit.UseVisualStyleBackColor = true;
            buttonDeleteVisit.Click += buttonDeleteVisit_Click;
            // 
            // buttonDeleteTest
            // 
            buttonDeleteTest.Location = new Point(1230, 546);
            buttonDeleteTest.Name = "buttonDeleteTest";
            buttonDeleteTest.Size = new Size(469, 29);
            buttonDeleteTest.TabIndex = 17;
            buttonDeleteTest.Text = "Usuń Badanie";
            buttonDeleteTest.UseVisualStyleBackColor = true;
            buttonDeleteTest.Click += buttonDeleteTest_Click;
            // 
            // buttonEditTest
            // 
            buttonEditTest.Location = new Point(1230, 511);
            buttonEditTest.Name = "buttonEditTest";
            buttonEditTest.Size = new Size(469, 29);
            buttonEditTest.TabIndex = 16;
            buttonEditTest.Text = "Otwórz Badanie";
            buttonEditTest.UseVisualStyleBackColor = true;
            buttonEditTest.Click += buttonEditTest_Click;
            // 
            // buttonAddTest
            // 
            buttonAddTest.Location = new Point(1230, 476);
            buttonAddTest.Name = "buttonAddTest";
            buttonAddTest.Size = new Size(469, 29);
            buttonAddTest.TabIndex = 15;
            buttonAddTest.Text = "Dodaj Badanie";
            buttonAddTest.UseVisualStyleBackColor = true;
            buttonAddTest.Click += buttonAddTest_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(12, 173);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(254, 29);
            buttonRefresh.TabIndex = 18;
            buttonRefresh.Text = "Odświerz";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonEditFile
            // 
            buttonEditFile.Location = new Point(272, 510);
            buttonEditFile.Name = "buttonEditFile";
            buttonEditFile.Size = new Size(541, 29);
            buttonEditFile.TabIndex = 19;
            buttonEditFile.Text = "Edytuj kartotekę";
            buttonEditFile.UseVisualStyleBackColor = true;
            buttonEditFile.Click += buttonEditFile_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(272, 544);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(541, 29);
            buttonDelete.TabIndex = 20;
            buttonDelete.Text = "Usuń kartotekę";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // PatientEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1711, 585);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEditFile);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonDeleteTest);
            Controls.Add(buttonEditTest);
            Controls.Add(buttonAddTest);
            Controls.Add(buttonDeleteVisit);
            Controls.Add(buttonEditVisit);
            Controls.Add(buttonAddVisit);
            Controls.Add(dataGridViewLAbTest);
            Controls.Add(dataGridViewVisit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPesel);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(buttonSave);
            Controls.Add(buttonNewPatientFile);
            Controls.Add(dataGridView);
            Name = "PatientEditForm";
            Text = "PatientEditForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientFileETOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVisit).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLAbTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)labTestsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button buttonNewPatientFile;
        private Button buttonSave;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPesel;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource patientFileETOBindingSource;
        private DataGridView dataGridViewVisit;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private BindingSource visitsBindingSource;
        private DataGridView dataGridViewLAbTest;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn specificDataDataGridViewTextBoxColumn;
        private BindingSource labTestsBindingSource;
        private Button buttonAddVisit;
        private Button buttonEditVisit;
        private Button buttonDeleteVisit;
        private Button buttonDeleteTest;
        private Button buttonEditTest;
        private Button buttonAddTest;
        private DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private Button buttonRefresh;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Doctor;
        private Button buttonEditFile;
        private Button buttonDelete;
    }
}