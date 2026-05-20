namespace SOP_Administration.Forms
{
    partial class EditVisitForm
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
            dateTimePicker = new DateTimePicker();
            comboBoxDoctor = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "yyyy.MM.dd - HH:mm";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(12, 32);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 0;
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(12, 85);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(250, 28);
            comboBoxDoctor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Godzina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Lekarz";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 135);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(250, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Zapisz";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // EditVisitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 176);
            Controls.Add(buttonSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxDoctor);
            Controls.Add(dateTimePicker);
            Name = "EditVisitForm";
            Text = "Edytuj Wizytę";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxDoctor;
        private Label label1;
        private Label label2;
        private Button buttonSave;
    }
}