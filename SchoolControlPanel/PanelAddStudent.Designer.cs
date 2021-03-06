﻿namespace SchoolControlPanel
{
    partial class PanelAddStudent
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
            this.text_box_student_first_name = new System.Windows.Forms.TextBox();
            this.label_student_first_name = new System.Windows.Forms.Label();
            this.label_student_last_name = new System.Windows.Forms.Label();
            this.text_box_student_last_name = new System.Windows.Forms.TextBox();
            this.label_student_third_name = new System.Windows.Forms.Label();
            this.text_box_student_third_name = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.PanelAddTeacherErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PanelAddTeacherErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // text_box_student_first_name
            // 
            this.text_box_student_first_name.Location = new System.Drawing.Point(206, 29);
            this.text_box_student_first_name.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_student_first_name.Name = "text_box_student_first_name";
            this.text_box_student_first_name.Size = new System.Drawing.Size(282, 31);
            this.text_box_student_first_name.TabIndex = 0;
            // 
            // label_student_first_name
            // 
            this.label_student_first_name.AutoSize = true;
            this.label_student_first_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_student_first_name.Location = new System.Drawing.Point(17, 34);
            this.label_student_first_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_student_first_name.Name = "label_student_first_name";
            this.label_student_first_name.Size = new System.Drawing.Size(176, 26);
            this.label_student_first_name.TabIndex = 1;
            this.label_student_first_name.Text = "Student first name:";
            // 
            // label_student_last_name
            // 
            this.label_student_last_name.AutoSize = true;
            this.label_student_last_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_student_last_name.Location = new System.Drawing.Point(17, 75);
            this.label_student_last_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_student_last_name.Name = "label_student_last_name";
            this.label_student_last_name.Size = new System.Drawing.Size(173, 26);
            this.label_student_last_name.TabIndex = 2;
            this.label_student_last_name.Text = "Student last name:";
            // 
            // text_box_student_last_name
            // 
            this.text_box_student_last_name.Location = new System.Drawing.Point(206, 70);
            this.text_box_student_last_name.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_student_last_name.Name = "text_box_student_last_name";
            this.text_box_student_last_name.Size = new System.Drawing.Size(282, 31);
            this.text_box_student_last_name.TabIndex = 3;
            // 
            // label_student_third_name
            // 
            this.label_student_third_name.AutoSize = true;
            this.label_student_third_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_student_third_name.Location = new System.Drawing.Point(14, 116);
            this.label_student_third_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_student_third_name.Name = "label_student_third_name";
            this.label_student_third_name.Size = new System.Drawing.Size(184, 26);
            this.label_student_third_name.TabIndex = 4;
            this.label_student_third_name.Text = "Student third name:";
            // 
            // text_box_student_third_name
            // 
            this.text_box_student_third_name.Location = new System.Drawing.Point(206, 111);
            this.text_box_student_third_name.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_student_third_name.Name = "text_box_student_third_name";
            this.text_box_student_third_name.Size = new System.Drawing.Size(282, 31);
            this.text_box_student_third_name.TabIndex = 5;
            // 
            // button_confirm
            // 
            this.button_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirm.Location = new System.Drawing.Point(116, 157);
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
            this.button_cancel.Location = new System.Drawing.Point(232, 157);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 40);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Close";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // PanelAddTeacherErrorProvider
            // 
            this.PanelAddTeacherErrorProvider.ContainerControl = this;
            // 
            // PanelAddStudent
            // 
            this.AcceptButton = this.button_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(509, 215);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.text_box_student_third_name);
            this.Controls.Add(this.label_student_third_name);
            this.Controls.Add(this.text_box_student_last_name);
            this.Controls.Add(this.label_student_last_name);
            this.Controls.Add(this.label_student_first_name);
            this.Controls.Add(this.text_box_student_first_name);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PanelAddStudent";
            this.Text = "Add Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelAddStudent_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PanelAddTeacherErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_box_student_first_name;
        private System.Windows.Forms.Label label_student_first_name;
        private System.Windows.Forms.Label label_student_last_name;
        private System.Windows.Forms.TextBox text_box_student_last_name;
        private System.Windows.Forms.Label label_student_third_name;
        private System.Windows.Forms.TextBox text_box_student_third_name;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ErrorProvider PanelAddTeacherErrorProvider;
    }
}