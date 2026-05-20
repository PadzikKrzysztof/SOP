namespace SOP_Administration.Forms
{
    partial class NewPatientForm
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
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            label2 = new Label();
            textBoxPesel = new TextBox();
            label3 = new Label();
            buttonSave = new Button();
            textBoxPassword = new TextBox();
            label4 = new Label();
            textBoxEmail = new TextBox();
            label5 = new Label();
            textBoxPhone = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 32);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(776, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(12, 91);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(776, 27);
            textBoxSurname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Nazwisko";
            // 
            // textBoxPesel
            // 
            textBoxPesel.Location = new Point(12, 154);
            textBoxPesel.Name = "textBoxPesel";
            textBoxPesel.Size = new Size(776, 27);
            textBoxPesel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "PESEL";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 385);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(776, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Zapisz";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 337);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(776, 27);
            textBoxPassword.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 301);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 7;
            label4.Text = "Hasło";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 218);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(776, 27);
            textBoxEmail.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(13, 271);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(776, 27);
            textBoxPhone.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 248);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 11;
            label6.Text = "Telefon";
            // 
            // NewPatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(textBoxPhone);
            Controls.Add(label6);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(textBoxPassword);
            Controls.Add(label4);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPesel);
            Controls.Add(label3);
            Controls.Add(textBoxSurname);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "NewPatientForm";
            Text = "Nowy Pacjent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Label label2;
        private TextBox textBoxPesel;
        private Label label3;
        private Button buttonSave;
        private TextBox textBoxPassword;
        private Label label4;
        private TextBox textBoxEmail;
        private Label label5;
        private TextBox textBoxPhone;
        private Label label6;
    }
}