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
            dataGridView1 = new DataGridView();
            buttonNewPatientFile = new Button();
            buttonSave = new Button();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPesel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(516, 426);
            dataGridView1.TabIndex = 0;
            // 
            // buttonNewPatientFile
            // 
            buttonNewPatientFile.Location = new Point(12, 195);
            buttonNewPatientFile.Name = "buttonNewPatientFile";
            buttonNewPatientFile.Size = new Size(254, 29);
            buttonNewPatientFile.TabIndex = 1;
            buttonNewPatientFile.Text = "Dodaj kartotekę";
            buttonNewPatientFile.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 409);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(254, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Zapisz";
            buttonSave.UseVisualStyleBackColor = true;
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
            // PatientEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPesel);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(buttonSave);
            Controls.Add(buttonNewPatientFile);
            Controls.Add(dataGridView1);
            Name = "PatientEditForm";
            Text = "PatientEditForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonNewPatientFile;
        private Button buttonSave;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPesel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}