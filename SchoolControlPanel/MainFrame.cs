﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolControlPanel
{
    public partial class MainFrame : Form
    {


        public MainFrame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (schoolEntities contextDB = new schoolEntities())
            {
                MessageBox.Show("Connection established!", "Success!");
            }
        }

        private void button_add_teacher_Click(object sender, EventArgs e)
        {
            PanelAddTeacher panelAddTeacher = new PanelAddTeacher();
            panelAddTeacher.Show(this);
        }

        private void button_add_classroom_Click(object sender, EventArgs e)
        {
            PanelAddClassroom panelAddClassroom = new PanelAddClassroom();
            panelAddClassroom.Show(this);
        }

        private void button_add_subject_Click(object sender, EventArgs e)
        {
            PanelAddSubject panelAddSubject = new PanelAddSubject();
            panelAddSubject.Show(this);
        }

        private void button_add_learning_program_Click(object sender, EventArgs e)
        {
            PanelAddLearningProgram panelAddLearningProgram = new PanelAddLearningProgram();
            panelAddLearningProgram.Show(this);
        }

        private void button_add_student_group_Click(object sender, EventArgs e)
        {
            PanelAddStudentGroup panelAddStudentGroup = new PanelAddStudentGroup();
            panelAddStudentGroup.Show(this);
        }

        private void button_add_student_Click(object sender, EventArgs e)
        {
            PanelAddStudent panelAddStudent = new PanelAddStudent();
            panelAddStudent.Show(this);
        }

        private void button_add_mark_Click(object sender, EventArgs e)
        {
            PanelAddMark mark = new PanelAddMark();
            mark.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelDiary diary = new PanelDiary();
            diary.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelChangeMark panel = new PanelChangeMark();
            panel.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelDeleteMark pa = new PanelDeleteMark();
            pa.Show(this);
        }
    }
}
