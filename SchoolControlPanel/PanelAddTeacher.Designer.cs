﻿namespace SchoolControlPanel
{
    partial class PanelAddTeacher
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
            this.text_box_teacher_first_name = new System.Windows.Forms.TextBox();
            this.label_teacher_first_name = new System.Windows.Forms.Label();
            this.label_teacher_last_name = new System.Windows.Forms.Label();
            this.text_box_teacher_last_name = new System.Windows.Forms.TextBox();
            this.label_teacher_third_name = new System.Windows.Forms.Label();
            this.text_box_teacher_third_name = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_box_teacher_first_name
            // 
            this.text_box_teacher_first_name.Location = new System.Drawing.Point(108, 60);
            this.text_box_teacher_first_name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.text_box_teacher_first_name.Name = "text_box_teacher_first_name";
            this.text_box_teacher_first_name.Size = new System.Drawing.Size(282, 31);
            this.text_box_teacher_first_name.TabIndex = 0;
            this.text_box_teacher_first_name.TextChanged += new System.EventHandler(this.text_box_teacher_name_TextChanged);
            // 
            // label_teacher_first_name
            // 
            this.label_teacher_first_name.AutoSize = true;
            this.label_teacher_first_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_teacher_first_name.Location = new System.Drawing.Point(103, 29);
            this.label_teacher_first_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_teacher_first_name.Name = "label_teacher_first_name";
            this.label_teacher_first_name.Size = new System.Drawing.Size(174, 26);
            this.label_teacher_first_name.TabIndex = 1;
            this.label_teacher_first_name.Text = "Teacher first name:";
            // 
            // label_teacher_last_name
            // 
            this.label_teacher_last_name.AutoSize = true;
            this.label_teacher_last_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_teacher_last_name.Location = new System.Drawing.Point(103, 96);
            this.label_teacher_last_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_teacher_last_name.Name = "label_teacher_last_name";
            this.label_teacher_last_name.Size = new System.Drawing.Size(171, 26);
            this.label_teacher_last_name.TabIndex = 2;
            this.label_teacher_last_name.Text = "Teacher last name:";
            this.label_teacher_last_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_box_teacher_last_name
            // 
            this.text_box_teacher_last_name.Location = new System.Drawing.Point(108, 127);
            this.text_box_teacher_last_name.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_teacher_last_name.Name = "text_box_teacher_last_name";
            this.text_box_teacher_last_name.Size = new System.Drawing.Size(282, 31);
            this.text_box_teacher_last_name.TabIndex = 3;
            // 
            // label_teacher_third_name
            // 
            this.label_teacher_third_name.AutoSize = true;
            this.label_teacher_third_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_teacher_third_name.Location = new System.Drawing.Point(103, 163);
            this.label_teacher_third_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_teacher_third_name.Name = "label_teacher_third_name";
            this.label_teacher_third_name.Size = new System.Drawing.Size(182, 26);
            this.label_teacher_third_name.TabIndex = 4;
            this.label_teacher_third_name.Text = "Teacher third name:";
            // 
            // text_box_teacher_third_name
            // 
            this.text_box_teacher_third_name.Location = new System.Drawing.Point(108, 194);
            this.text_box_teacher_third_name.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_teacher_third_name.Name = "text_box_teacher_third_name";
            this.text_box_teacher_third_name.Size = new System.Drawing.Size(282, 31);
            this.text_box_teacher_third_name.TabIndex = 5;
            // 
            // button_confirm
            // 
            this.button_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirm.Location = new System.Drawing.Point(125, 259);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(100, 40);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "Add";
            this.button_confirm.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(243, 259);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 40);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Close";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // PanelAddTeacher
            // 
            this.AcceptButton = this.button_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.text_box_teacher_third_name);
            this.Controls.Add(this.label_teacher_third_name);
            this.Controls.Add(this.text_box_teacher_last_name);
            this.Controls.Add(this.label_teacher_last_name);
            this.Controls.Add(this.label_teacher_first_name);
            this.Controls.Add(this.text_box_teacher_first_name);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "PanelAddTeacher";
            this.Text = "Add Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_box_teacher_first_name;
        private System.Windows.Forms.Label label_teacher_first_name;
        private System.Windows.Forms.Label label_teacher_last_name;
        private System.Windows.Forms.TextBox text_box_teacher_last_name;
        private System.Windows.Forms.Label label_teacher_third_name;
        private System.Windows.Forms.TextBox text_box_teacher_third_name;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
    }
}