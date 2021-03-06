﻿namespace SchoolControlPanel
{
    partial class PanelAddMark
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
            this.components = new System.ComponentModel.Container();
            this.text_mark = new System.Windows.Forms.TextBox();
            this.label_mark = new System.Windows.Forms.Label();
            this.label_lesson_number = new System.Windows.Forms.Label();
            this.text_lesson_number = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_student = new System.Windows.Forms.Label();
            this.listbox_student = new System.Windows.Forms.ListBox();
            this.listbox_subject = new System.Windows.Forms.ListBox();
            this.label_subject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // text_mark
            // 
            this.text_mark.Location = new System.Drawing.Point(203, 310);
            this.text_mark.Margin = new System.Windows.Forms.Padding(5);
            this.text_mark.Name = "text_mark";
            this.text_mark.Size = new System.Drawing.Size(282, 31);
            this.text_mark.TabIndex = 0;
            // 
            // label_mark
            // 
            this.label_mark.AutoSize = true;
            this.label_mark.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mark.Location = new System.Drawing.Point(14, 315);
            this.label_mark.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_mark.Name = "label_mark";
            this.label_mark.Size = new System.Drawing.Size(63, 26);
            this.label_mark.TabIndex = 1;
            this.label_mark.Text = "Mark:";
            // 
            // label_lesson_number
            // 
            this.label_lesson_number.AutoSize = true;
            this.label_lesson_number.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_lesson_number.Location = new System.Drawing.Point(14, 356);
            this.label_lesson_number.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_lesson_number.Name = "label_lesson_number";
            this.label_lesson_number.Size = new System.Drawing.Size(147, 26);
            this.label_lesson_number.TabIndex = 2;
            this.label_lesson_number.Text = "Lesson number:";
            // 
            // text_lesson_number
            // 
            this.text_lesson_number.Location = new System.Drawing.Point(203, 351);
            this.text_lesson_number.Margin = new System.Windows.Forms.Padding(5);
            this.text_lesson_number.Name = "text_lesson_number";
            this.text_lesson_number.Size = new System.Drawing.Size(282, 31);
            this.text_lesson_number.TabIndex = 3;
            // 
            // button_confirm
            // 
            this.button_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirm.Location = new System.Drawing.Point(111, 422);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(100, 40);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "Add";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(227, 422);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 40);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Close";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label_student
            // 
            this.label_student.AutoSize = true;
            this.label_student.Location = new System.Drawing.Point(19, 13);
            this.label_student.Name = "label_student";
            this.label_student.Size = new System.Drawing.Size(75, 23);
            this.label_student.TabIndex = 8;
            this.label_student.Text = "Student:";
            // 
            // listbox_student
            // 
            this.listbox_student.FormattingEnabled = true;
            this.listbox_student.HorizontalScrollbar = true;
            this.listbox_student.ItemHeight = 23;
            this.listbox_student.Location = new System.Drawing.Point(23, 50);
            this.listbox_student.Name = "listbox_student";
            this.listbox_student.Size = new System.Drawing.Size(462, 96);
            this.listbox_student.TabIndex = 9;
            // 
            // listbox_subject
            // 
            this.listbox_subject.FormattingEnabled = true;
            this.listbox_subject.ItemHeight = 23;
            this.listbox_subject.Location = new System.Drawing.Point(23, 189);
            this.listbox_subject.Name = "listbox_subject";
            this.listbox_subject.Size = new System.Drawing.Size(462, 96);
            this.listbox_subject.TabIndex = 11;
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Location = new System.Drawing.Point(19, 152);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(72, 23);
            this.label_subject.TabIndex = 10;
            this.label_subject.Text = "Subject:";
            // 
            // PanelAddMark
            // 
            this.AcceptButton = this.button_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(509, 471);
            this.Controls.Add(this.listbox_subject);
            this.Controls.Add(this.label_subject);
            this.Controls.Add(this.listbox_student);
            this.Controls.Add(this.label_student);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.text_lesson_number);
            this.Controls.Add(this.label_lesson_number);
            this.Controls.Add(this.label_mark);
            this.Controls.Add(this.text_mark);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PanelAddMark";
            this.Text = "Add Mark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelAddStudent_FormClosing);
            this.Load += new System.EventHandler(this.PanelAddMark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_mark;
        private System.Windows.Forms.Label label_mark;
        private System.Windows.Forms.Label label_lesson_number;
        private System.Windows.Forms.TextBox text_lesson_number;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListBox listbox_subject;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.ListBox listbox_student;
        private System.Windows.Forms.Label label_student;
    }
}