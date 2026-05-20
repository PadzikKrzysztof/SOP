namespace SOP_Administration.Forms.Doctor.Avability
{
    partial class AvabilityForm
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
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "yyyy.MM.dd - HH:mm";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(12, 32);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(250, 27);
            dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "yyyy.MM.dd - HH:mm";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(12, 85);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(250, 27);
            dateTimePickerEnd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 2;
            label1.Text = "Od";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 3;
            label2.Text = "Do";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 118);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(250, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Zapisz";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // AvabilityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 175);
            Controls.Add(buttonSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Name = "AvabilityForm";
            Text = "Dostępność";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label label1;
        private Label label2;
        private Button buttonSave;
    }
}