using Guna.UI2.WinForms;
using LogbookMenuWF.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogbookMenuWF
{
    public partial class Form1 : Form
    {
        StudentUC std1 = new StudentUC();
        StudentUC std2 = new StudentUC();
        StudentUC std3 = new StudentUC();
        StudentUC std4 = new StudentUC();
        StudentUC std5 = new StudentUC();
        StudentUC std6 = new StudentUC();
        StudentUC std7 = new StudentUC();
        StudentUC std8 = new StudentUC();
        public Form1()
        {
            InitializeComponent();
            List<StudentUC> studentUCs = new List<StudentUC>() { std1, std2, std3, std4, std5, std6, std7, std8 };
            studentUCs.ForEach(std => std.ParentForm = this);
            panel3.Location = new Point(28, 128);
        }

        private void Btn_Pen_Click(object sender, EventArgs e)
        {
            if (rtb_SubjectLesson.Visible)
            {
                panel1.Size = new Size(1280, 756);
                panel3.Location = new Point(28, 128);
                rtb_SubjectLesson.Visible = false;
                btn_SubjectLessonSave.Visible = false;
                btn_SubjectLessonRefusal.Visible = false;
                btn_AddMaterial.Location = new Point(1066, 28);
                panel2.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Location = new Point(10, uc.Location.Y - 62));
            }
            else
            {
                panel1.Size = new Size(1280, 820);
                panel3.Location = new Point(28, 188);
                rtb_SubjectLesson.Visible = true;
                btn_SubjectLessonSave.Visible = true;
                btn_SubjectLessonRefusal.Visible = true;
                btn_AddMaterial.Location = new Point(1066, 89);
                btn_SubjectLessonSave.Location = new Point(1066, 28);
                btn_SubjectLessonRefusal.Location = new Point(1066, 58);
                panel2.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Location = new Point(10, uc.Location.Y + 62));
            }
        }
        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is Guna2CustomRadioButton rb)
            {
                if (rb.Checked == true)
                {
                    btn_AddMaterial.Enabled = true;
                    btn_Pen.Enabled = true;
                    pb_Pen.Visible = false;
                    rb_EveryoneCame.Enabled = true;
                    panel2.Controls.OfType<StudentUC>().ToList().ForEach(std =>
                    {
                        std.rb_NotCome.Enabled = true;
                        std.rb_stdCame.Enabled = true;
                        std.rb_stdLate.Enabled = true;
                    });
                }
            }
        }
        private void Btn_SubjectLessonSave_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(1280, 756);
            panel2.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Location = new Point(10, uc.Location.Y - 62));
            panel3.Location = new Point(28, 128);
            lbl_SubjectLesson.Text = rtb_SubjectLesson.Text;
            if (rtb_SubjectLesson.Text != string.Empty)
            {
                lbl_SubjectLesson.Location = new Point(907, 5);
                btn_Pen.Location = new Point(910 + 8 * lbl_SubjectLesson.Text.Length, 2);
            }
            else
            {
                btn_Pen.Location = new Point(910, 2);
            }
            rtb_SubjectLesson.Visible = false;
            btn_SubjectLessonSave.Visible = false;
            btn_SubjectLessonRefusal.Visible = false;
            btn_AddMaterial.Location = new Point(1066, 28);
        }
        private void Btn_SubjectLessonRefusal_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(1280, 756);
            panel2.Controls.OfType<UserControl>().ToList().ForEach(uc => uc.Location = new Point(10, uc.Location.Y - 62));
            panel3.Location = new Point(28, 128);
            rtb_SubjectLesson.Visible = false;
            btn_SubjectLessonSave.Visible = false;
            btn_SubjectLessonRefusal.Visible = false;
            btn_AddMaterial.Location = new Point(1066, 28);
            rtb_SubjectLesson.ResetText();
        }
        private void Btn_AddMaterial_Click(object sender, EventArgs e) => MessageBox.Show("Material added", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        private void Form1_Load(object sender, EventArgs e)
        {
            int num = 70;
            std1.lbl_StdNum.Text = "1";
            std1.lbl_StudInfo.Text = "Cəfərli Nicat Rasim";
            std1.lbl_LastAccessDate.Text = new DateTime(2021, 08, 02).ToShortDateString();
            std1.pb_ImageBig.Image = Resources.NIcat;

            std2.lbl_StdNum.Text = "2";
            std2.lbl_StudInfo.Text = "Əliyev Əmiraslan İsa";
            std2.lbl_LastAccessDate.Text = new DateTime(2021, 08, 02).ToShortDateString();
            std2.pb_ImageBig.Image = Resources.Emiraslan;

            std3.lbl_StdNum.Text = "3";
            std3.lbl_StudInfo.Text = "Həsənzadə İlqar İlham";
            std3.lbl_LastAccessDate.Text = new DateTime(2021, 08, 02).ToShortDateString();
            std3.pb_ImageBig.Image = Resources.İlqar;

            std4.lbl_StdNum.Text = "4";
            std4.lbl_StudInfo.Text = "İdayatov Kənan İlqar";
            std4.lbl_LastAccessDate.Text = new DateTime(2021, 08, 02).ToShortDateString();
            std4.pb_ImageBig.Image = Resources.Kenan;

            std5.lbl_StdNum.Text = "5";
            std5.lbl_StudInfo.Text = "Nəbili Nəbi Elçin";
            std5.lbl_LastAccessDate.Text = new DateTime(2021, 08, 02).ToShortDateString();
            std5.pb_ImageBig.Image = Resources.Nebi;

            std6.lbl_StdNum.Text = "6";
            std6.lbl_StudInfo.Text = "Rüstəmov Yusif Habil";
            std6.lbl_LastAccessDate.Text = new DateTime(2021, 07, 26).ToShortDateString();
            std6.pb_ImageBig.Image = Resources.Yusif;

            std7.lbl_StdNum.Text = "7";
            std7.lbl_StudInfo.Text = "Vahabzadə Zahid Yusif";
            std7.lbl_LastAccessDate.Text = new DateTime(2021, 08, 02).ToShortDateString();
            std7.pb_ImageBig.Image = Resources.Zahid;

            std8.lbl_StdNum.Text = "8";
            std8.lbl_StudInfo.Text = "Vəlizadə Emin Elnur";
            std8.lbl_LastAccessDate.Text = new DateTime(2021, 08, 02).ToShortDateString();
            std8.pb_ImageBig.Image = Resources.Emin;

            panel2.Controls.Add(std1);
            panel2.Controls.Add(std2);
            panel2.Controls.Add(std3);
            panel2.Controls.Add(std4);
            panel2.Controls.Add(std5);
            panel2.Controls.Add(std6);
            panel2.Controls.Add(std7);
            panel2.Controls.Add(std8);
            panel2.Controls.OfType<StudentUC>().ToList().ForEach(uc =>
            {
                uc.Location = new Point(10, num + 62);
                num += 68;
            });
        }
        private void Rb_EveryoneCame_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_EveryoneCame.Checked)
            {
                panel2.Controls.OfType<StudentUC>().ToList().ForEach(uc =>
                {
                    uc.rb_stdCame.Checked = true;
                    uc.cb_ClassWork.Enabled = true;
                    uc.cb_InspectionWork.Enabled = true;
                });
            }
        }
    }
}
