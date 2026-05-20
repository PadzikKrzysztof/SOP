namespace SOP_Administration.Colntrols
{
    partial class DoctorListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonRefresh = new Button();
            buttonNew = new Button();
            buttonOpen = new Button();
            buttonDelete = new Button();
            dataGridView = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Employee = new DataGridViewTextBoxColumn();
            doctorBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(buttonRefresh);
            flowLayoutPanel1.Controls.Add(buttonNew);
            flowLayoutPanel1.Controls.Add(buttonOpen);
            flowLayoutPanel1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(213, 497);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(3, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(191, 29);
            buttonRefresh.TabIndex = 0;
            buttonRefresh.Text = "Odświerz";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click_1;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(3, 38);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(191, 29);
            buttonNew.TabIndex = 1;
            buttonNew.Text = "Nowy";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click_1;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(3, 73);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(191, 29);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Otwórz";
            buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(3, 108);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(191, 29);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Usuń";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, Employee });
            dataGridView.DataSource = doctorBindingSource;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(222, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(660, 497);
            dataGridView.TabIndex = 1;
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
            // Employee
            // 
            Employee.DataPropertyName = "Employee";
            Employee.HeaderText = "Imię i Nazwisko";
            Employee.MinimumWidth = 6;
            Employee.Name = "Employee";
            Employee.Width = 125;
            // 
            // doctorBindingSource
            // 
            doctorBindingSource.DataSource = typeof(SOP_ETOLibrary.DoctorETO);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.7549019F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.2450943F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(885, 503);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // DoctorListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DoctorListControl";
            Size = new Size(885, 503);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonRefresh;
        private Button buttonNew;
        private Button buttonOpen;
        private Button buttonDelete;
        private DataGridView dataGridView;
        private BindingSource doctorBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Employee;
    }
}
