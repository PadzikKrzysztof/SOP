namespace SOP_Administration.Forms
{
    partial class DoctorForm
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
            availabilityETOBindingSource = new BindingSource(components);
            doctorControl1 = new SOP_Administration.Colntrols.DoctorControl();
            ((System.ComponentModel.ISupportInitialize)availabilityETOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // availabilityETOBindingSource
            // 
            availabilityETOBindingSource.DataSource = typeof(SOP_ETOLibrary.AvailabilityETO);
            // 
            // doctorControl1
            // 
            doctorControl1.Dock = DockStyle.Fill;
            doctorControl1.Location = new Point(0, 0);
            doctorControl1.Name = "doctorControl1";
            doctorControl1.Size = new Size(800, 450);
            doctorControl1.TabIndex = 0;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(doctorControl1);
            Name = "DoctorForm";
            Text = "Nowy Doktor";
            ((System.ComponentModel.ISupportInitialize)availabilityETOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource availabilityETOBindingSource;
        private Colntrols.DoctorControl doctorControl1;
    }
}