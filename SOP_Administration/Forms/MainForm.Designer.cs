namespace SOP_Administration
{
    partial class FormSOP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPagePatients = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonNewPatient = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnSurname = new DataGridViewTextBoxColumn();
            ColumnPESEL = new DataGridViewTextBoxColumn();
            tabControlMain = new TabControl();
            buttonEdit = new Button();
            buttonRefresh = new Button();
            tabPagePatients.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabPagePatients
            // 
            tabPagePatients.Controls.Add(flowLayoutPanel2);
            tabPagePatients.Controls.Add(flowLayoutPanel1);
            tabPagePatients.Location = new Point(4, 29);
            tabPagePatients.Name = "tabPagePatients";
            tabPagePatients.Padding = new Padding(3);
            tabPagePatients.Size = new Size(792, 417);
            tabPagePatients.TabIndex = 0;
            tabPagePatients.Text = "Pacjeńci";
            tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel2.Controls.Add(buttonNewPatient);
            flowLayoutPanel2.Controls.Add(buttonEdit);
            flowLayoutPanel2.Controls.Add(buttonRefresh);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(206, 411);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // buttonNewPatient
            // 
            buttonNewPatient.Location = new Point(3, 3);
            buttonNewPatient.Name = "buttonNewPatient";
            buttonNewPatient.Size = new Size(201, 29);
            buttonNewPatient.TabIndex = 0;
            buttonNewPatient.Text = "Nowy Pacjent";
            buttonNewPatient.UseVisualStyleBackColor = true;
            buttonNewPatient.Click += buttonNewPatient_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(242, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(547, 411);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnSurname, ColumnPESEL });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(539, 406);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // ColumnName
            // 
            ColumnName.DataPropertyName = "Name";
            ColumnName.HeaderText = "Imię";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 125;
            // 
            // ColumnSurname
            // 
            ColumnSurname.DataPropertyName = "Surname";
            ColumnSurname.HeaderText = "Nazwisko";
            ColumnSurname.MinimumWidth = 6;
            ColumnSurname.Name = "ColumnSurname";
            ColumnSurname.Width = 125;
            // 
            // ColumnPESEL
            // 
            ColumnPESEL.DataPropertyName = "PESEL";
            ColumnPESEL.HeaderText = "PESEL";
            ColumnPESEL.MinimumWidth = 6;
            ColumnPESEL.Name = "ColumnPESEL";
            ColumnPESEL.Width = 125;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPagePatients);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(800, 450);
            tabControlMain.TabIndex = 0;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(3, 38);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(201, 29);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edytuj Pacjenta";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(3, 73);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(201, 29);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Odświerz";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // FormSOP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            Name = "FormSOP";
            Text = "SOP";
            tabPagePatients.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPagePatients;
        private TabControl tabControlMain;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private Button buttonNewPatient;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnSurname;
        private DataGridViewTextBoxColumn ColumnPESEL;
        private Button buttonEdit;
        private Button buttonRefresh;
    }
}
