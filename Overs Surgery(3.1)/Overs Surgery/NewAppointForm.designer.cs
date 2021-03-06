﻿namespace UI_Appoinment
{
    partial class FormAppointHome
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
            this.ButtonAppointSubmit = new System.Windows.Forms.Button();
            this.LabelAppointPatientName = new System.Windows.Forms.Label();
            this.LabelAppointGPName = new System.Windows.Forms.Label();
            this.AppointDateTime = new System.Windows.Forms.DateTimePicker();
            this.LabelAppointDateTime = new System.Windows.Forms.Label();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.LabelPatientComment = new System.Windows.Forms.Label();
            this.RichTextBoxPatientComments = new System.Windows.Forms.RichTextBox();
            this.GpNurseComboBox = new System.Windows.Forms.ComboBox();
            this.PatientComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonAppointSubmit
            // 
            this.ButtonAppointSubmit.Location = new System.Drawing.Point(154, 454);
            this.ButtonAppointSubmit.Name = "ButtonAppointSubmit";
            this.ButtonAppointSubmit.Size = new System.Drawing.Size(75, 23);
            this.ButtonAppointSubmit.TabIndex = 0;
            this.ButtonAppointSubmit.Text = "Submit";
            this.ButtonAppointSubmit.UseVisualStyleBackColor = true;
            this.ButtonAppointSubmit.Click += new System.EventHandler(this.ButtonAppointSubmit_Click_1);
            // 
            // LabelAppointPatientName
            // 
            this.LabelAppointPatientName.AutoSize = true;
            this.LabelAppointPatientName.Location = new System.Drawing.Point(122, 89);
            this.LabelAppointPatientName.Name = "LabelAppointPatientName";
            this.LabelAppointPatientName.Size = new System.Drawing.Size(54, 13);
            this.LabelAppointPatientName.TabIndex = 5;
            this.LabelAppointPatientName.Text = "Patient ID";
            this.LabelAppointPatientName.Click += new System.EventHandler(this.LabelAppointPatientName_Click);
            // 
            // LabelAppointGPName
            // 
            this.LabelAppointGPName.AutoSize = true;
            this.LabelAppointGPName.Location = new System.Drawing.Point(122, 141);
            this.LabelAppointGPName.Name = "LabelAppointGPName";
            this.LabelAppointGPName.Size = new System.Drawing.Size(69, 13);
            this.LabelAppointGPName.TabIndex = 6;
            this.LabelAppointGPName.Text = "GP/Nurse ID";
            this.LabelAppointGPName.Click += new System.EventHandler(this.LabelAppointGPName_Click);
            // 
            // AppointDateTime
            // 
            this.AppointDateTime.Location = new System.Drawing.Point(12, 248);
            this.AppointDateTime.Name = "AppointDateTime";
            this.AppointDateTime.Size = new System.Drawing.Size(200, 20);
            this.AppointDateTime.TabIndex = 7;
            this.AppointDateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // LabelAppointDateTime
            // 
            this.LabelAppointDateTime.AutoSize = true;
            this.LabelAppointDateTime.Location = new System.Drawing.Point(12, 232);
            this.LabelAppointDateTime.Name = "LabelAppointDateTime";
            this.LabelAppointDateTime.Size = new System.Drawing.Size(136, 13);
            this.LabelAppointDateTime.TabIndex = 8;
            this.LabelAppointDateTime.Text = "Appoinment Date and Time";
            // 
            // ButtonHome
            // 
            this.ButtonHome.Location = new System.Drawing.Point(12, 13);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(146, 23);
            this.ButtonHome.TabIndex = 11;
            this.ButtonHome.Text = "Appointment Home Page";
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // LabelPatientComment
            // 
            this.LabelPatientComment.AutoSize = true;
            this.LabelPatientComment.Location = new System.Drawing.Point(12, 282);
            this.LabelPatientComment.Name = "LabelPatientComment";
            this.LabelPatientComment.Size = new System.Drawing.Size(92, 13);
            this.LabelPatientComment.TabIndex = 19;
            this.LabelPatientComment.Text = "Patient Comments";
            // 
            // RichTextBoxPatientComments
            // 
            this.RichTextBoxPatientComments.Location = new System.Drawing.Point(12, 298);
            this.RichTextBoxPatientComments.Name = "RichTextBoxPatientComments";
            this.RichTextBoxPatientComments.Size = new System.Drawing.Size(349, 128);
            this.RichTextBoxPatientComments.TabIndex = 20;
            this.RichTextBoxPatientComments.Text = "";
            // 
            // GpNurseComboBox
            // 
            this.GpNurseComboBox.FormattingEnabled = true;
            this.GpNurseComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.GpNurseComboBox.Location = new System.Drawing.Point(94, 168);
            this.GpNurseComboBox.Name = "GpNurseComboBox";
            this.GpNurseComboBox.Size = new System.Drawing.Size(121, 21);
            this.GpNurseComboBox.TabIndex = 22;
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.FormattingEnabled = true;
            this.PatientComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PatientComboBox.Location = new System.Drawing.Point(94, 105);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(121, 21);
            this.PatientComboBox.TabIndex = 23;
            // 
            // FormAppointHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 517);
            this.Controls.Add(this.PatientComboBox);
            this.Controls.Add(this.GpNurseComboBox);
            this.Controls.Add(this.RichTextBoxPatientComments);
            this.Controls.Add(this.LabelPatientComment);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.LabelAppointDateTime);
            this.Controls.Add(this.AppointDateTime);
            this.Controls.Add(this.LabelAppointGPName);
            this.Controls.Add(this.LabelAppointPatientName);
            this.Controls.Add(this.ButtonAppointSubmit);
            this.Name = "FormAppointHome";
            this.Text = "New Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAppointSubmit;
        private System.Windows.Forms.Label LabelAppointPatientName;
        private System.Windows.Forms.Label LabelAppointGPName;
        private System.Windows.Forms.DateTimePicker AppointDateTime;
        private System.Windows.Forms.Label LabelAppointDateTime;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Label LabelPatientComment;
        private System.Windows.Forms.RichTextBox RichTextBoxPatientComments;
        private System.Windows.Forms.ComboBox GpNurseComboBox;
        private System.Windows.Forms.ComboBox PatientComboBox;
    }
}

