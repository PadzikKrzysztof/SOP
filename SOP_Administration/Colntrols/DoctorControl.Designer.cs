namespace SOP_Administration.Colntrols
{
    partial class DoctorControl
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
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            label2 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            textBoxPhone = new TextBox();
            labelPhone = new Label();
            textBoxPassword = new TextBox();
            label5 = new Label();
            comboBoxSpecialization = new ComboBox();
            label6 = new Label();
            buttonSave = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayTimeStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayTimeEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doctorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            availabilityETOBindingSource = new BindingSource(components);
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonVisits = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)availabilityETOBindingSource).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(3, 23);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(151, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(3, 76);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(151, 27);
            textBoxSurname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Nazwisko";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(3, 129);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(151, 27);
            textBoxEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 106);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(3, 182);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(151, 27);
            textBoxPhone.TabIndex = 7;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(3, 159);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(58, 20);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "Telefon";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(3, 235);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(151, 27);
            textBoxPassword.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 212);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 8;
            label5.Text = "Hasło";
            // 
            // comboBoxSpecialization
            // 
            comboBoxSpecialization.FormattingEnabled = true;
            comboBoxSpecialization.Location = new Point(3, 288);
            comboBoxSpecialization.Name = "comboBoxSpecialization";
            comboBoxSpecialization.Size = new Size(151, 28);
            comboBoxSpecialization.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 265);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 11;
            label6.Text = "Specjalizacja";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(3, 357);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(151, 29);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Zapisz";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.625F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBoxName);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textBoxSurname);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(textBoxEmail);
            flowLayoutPanel1.Controls.Add(labelPhone);
            flowLayoutPanel1.Controls.Add(textBoxPhone);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(textBoxPassword);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(comboBoxSpecialization);
            flowLayoutPanel1.Controls.Add(buttonVisits);
            flowLayoutPanel1.Controls.Add(buttonSave);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(181, 444);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataGridView, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(190, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 74.3243256F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.6756763F));
            tableLayoutPanel2.Size = new Size(607, 444);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, dayTimeStartDataGridViewTextBoxColumn, dayTimeEndDataGridViewTextBoxColumn, doctorDataGridViewTextBoxColumn });
            dataGridView.DataSource = availabilityETOBindingSource;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(601, 324);
            dataGridView.TabIndex = 2;
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
            // dayTimeStartDataGridViewTextBoxColumn
            // 
            dayTimeStartDataGridViewTextBoxColumn.DataPropertyName = "DayTimeStart";
            dayTimeStartDataGridViewTextBoxColumn.HeaderText = "Początek";
            dayTimeStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            dayTimeStartDataGridViewTextBoxColumn.Name = "dayTimeStartDataGridViewTextBoxColumn";
            dayTimeStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // dayTimeEndDataGridViewTextBoxColumn
            // 
            dayTimeEndDataGridViewTextBoxColumn.DataPropertyName = "DayTimeEnd";
            dayTimeEndDataGridViewTextBoxColumn.HeaderText = "Koniec";
            dayTimeEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            dayTimeEndDataGridViewTextBoxColumn.Name = "dayTimeEndDataGridViewTextBoxColumn";
            dayTimeEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            doctorDataGridViewTextBoxColumn.MinimumWidth = 6;
            doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            doctorDataGridViewTextBoxColumn.Visible = false;
            doctorDataGridViewTextBoxColumn.Width = 125;
            // 
            // availabilityETOBindingSource
            // 
            availabilityETOBindingSource.DataSource = typeof(SOP_ETOLibrary.AvailabilityETO);
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonAdd);
            flowLayoutPanel2.Controls.Add(buttonEdit);
            flowLayoutPanel2.Controls.Add(buttonDelete);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 333);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(601, 108);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(210, 105);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(219, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(194, 99);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edytuj";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(419, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(176, 99);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Usuń";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonVisits
            // 
            buttonVisits.Location = new Point(3, 322);
            buttonVisits.Name = "buttonVisits";
            buttonVisits.Size = new Size(151, 29);
            buttonVisits.TabIndex = 13;
            buttonVisits.Text = "Wizyty";
            buttonVisits.UseVisualStyleBackColor = true;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "DoctorForm";
            Text = "Nowy Doktor";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)availabilityETOBindingSource).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label3;
        private TextBox textBoxPhone;
        private Label labelPhone;
        private TextBox textBoxPassword;
        private Label label5;
        private ComboBox comboBoxSpecialization;
        private Label label6;
        private Button buttonSave;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private BindingSource availabilityETOBindingSource;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayTimeStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayTimeEndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonVisits;
    }
}