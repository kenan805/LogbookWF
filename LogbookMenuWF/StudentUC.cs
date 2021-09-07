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
    public partial class StudentUC : UserControl
    {
        public new Form1 ParentForm { get; set; }
        public StudentUC()
        {
            InitializeComponent();
        }
        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2CustomRadioButton rb)
            {
                if (rb.Checked)
                {
                    pb_AddComment.Visible = false;
                    cb_ClassWork.Enabled = true;
                    cb_InspectionWork.Enabled = true;
                    pb_Diamond1.Visible = false;
                    pb_Diamond2.Visible = false;
                    pb_Diamond3.Visible = false;
                    btn_Diamond1.Visible = true;
                    btn_Diamond2.Visible = true;
                    btn_Diamond3.Visible = true;
                    btn_Diamond1.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond2.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond3.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond1.Text = "1";
                    btn_Diamond2.Text = "1";
                    btn_Diamond3.Text = "1";
                }
            }
        }
        private void Rb_NotCome_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_NotCome.Checked == true)
            {
                pb_AddComment.Visible = false;
                cb_ClassWork.Enabled = false;
                cb_InspectionWork.Enabled = false;
                cb_ClassWork.StartIndex = 0;
                cb_InspectionWork.StartIndex = 0;
                btn_Diamond1.Visible = false;
                btn_Diamond2.Visible = false;
                btn_Diamond3.Visible = false;
                pb_Diamond1.Visible = true;
                pb_Diamond2.Visible = true;
                pb_Diamond3.Visible = true;
                if (btn_Diamond1.Text == "2" && btn_Diamond2.Text == "1" && btn_Diamond3.Text == "1")
                    ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 1).ToString();
                else if (btn_Diamond1.Text == "2" && btn_Diamond2.Text == "2" && btn_Diamond3.Text == "1")
                    ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 2).ToString();
                else if (btn_Diamond1.Text == "2" && btn_Diamond2.Text == "2" && btn_Diamond3.Text == "2")
                    ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 3).ToString();
                cb_ClassWork.FillColor = Color.White;
                cb_InspectionWork.FillColor = Color.White;
            }
        }
        private void Btn_AddComment_Click(object sender, EventArgs e)
        {
            btn_AddComment.Visible = false;
            tb_AddComment.Visible = true;
            btn_CommentOkay.Visible = true;
            btn_CommentNot.Visible = true;
        }
        private void Btn_CommentOkay_Click(object sender, EventArgs e)
        {
            if (tb_AddComment.Text != string.Empty)
            {
                lbl_Comment.Text = DateTime.Now.ToShortDateString() + ": " + tb_AddComment.Text;
                lbl_Comment.Visible = true;
                tb_AddComment.Visible = false;
                btn_CommentOkay.Visible = false;
                btn_CommentNot.Visible = false;
                btn_CommentReset.Visible = true;
            }
            else
            {
                btn_AddComment.Visible = true;
                tb_AddComment.Visible = false;
                btn_CommentOkay.Visible = false;
                btn_CommentNot.Visible = false;
                btn_CommentReset.Visible = false;
            }
        }
        private void Btn_CommentNot_Click(object sender, EventArgs e)
        {
            if (tb_AddComment.Text == string.Empty)
            {
                if (lbl_Comment.Text != null)
                {
                    lbl_Comment.Visible = true;
                    tb_AddComment.Visible = false;
                    btn_CommentOkay.Visible = false;
                    btn_CommentNot.Visible = false;
                }
                else
                {
                    tb_AddComment.ResetText();
                    btn_AddComment.Visible = true;
                    tb_AddComment.Visible = false;
                    btn_CommentOkay.Visible = false;
                    btn_CommentNot.Visible = false;
                }
            }
            else
            {
                if (lbl_Comment.Text != null)
                {
                    tb_AddComment.ResetText();
                    lbl_Comment.Visible = true;
                    tb_AddComment.Visible = false;
                    btn_CommentOkay.Visible = false;
                    btn_CommentNot.Visible = false;
                }
                else
                {
                    tb_AddComment.ResetText();
                    btn_AddComment.Visible = true;
                    tb_AddComment.Visible = false;
                    btn_CommentOkay.Visible = false;
                    btn_CommentNot.Visible = false;
                }
            }
        }
        private void Btn_CommentReset_Click(object sender, EventArgs e)
        {
            lbl_Comment.Visible = false;
            Btn_AddComment_Click(sender, e);
        }
        private void Btn_Diamond1_Click(object sender, EventArgs e)
        {
            if (btn_Diamond1.Text == "1")
            {
                if (ParentForm.lbl_DiamondCount.Text != "0")
                {
                    ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) - 1).ToString();
                    btn_Diamond1.BackgroundImage = Resources.gem_stone_48px;
                    btn_Diamond2.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond3.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond1.Text = "2";
                }
            }
            else if (btn_Diamond1.Text == "2")
            {
                if (btn_Diamond2.Text == "1" && btn_Diamond3.Text == "1")
                {
                    ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 1).ToString();
                    btn_Diamond1.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond1.Text = "1";
                }
                else if (btn_Diamond2.Text == "2" && btn_Diamond3.Text == "1")
                {
                    ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 1).ToString();
                    btn_Diamond2.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond3.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond2.Text = "1";
                }
                else if (btn_Diamond2.Text == "2" && btn_Diamond3.Text == "2")
                {
                    ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 2).ToString();
                    btn_Diamond2.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond3.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond2.Text = "1";
                    btn_Diamond3.Text = "1";
                }
            }

        }
        private void Btn_Diamond2_Click(object sender, EventArgs e)
        {
            if (btn_Diamond2.Text == "1")
            {
                if (ParentForm.lbl_DiamondCount.Text != "0" && ParentForm.lbl_DiamondCount.Text != "1")
                {
                    if (btn_Diamond1.Text == "1")
                    {
                        ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) - 2).ToString();
                        btn_Diamond1.BackgroundImage = Resources.gem_stone_48px;
                        btn_Diamond1.Text = "2";
                        btn_Diamond2.BackgroundImage = Resources.gem_stone_48px;
                        btn_Diamond2.Text = "2";
                    }
                    else if (btn_Diamond1.Text == "2")
                    {
                        ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) - 1).ToString();
                        btn_Diamond2.BackgroundImage = Resources.gem_stone_48px;
                        btn_Diamond2.Text = "2";
                    }
                }
            }
            else if (btn_Diamond2.Text == "2")
            {
                if (btn_Diamond3.Text == "1")
                {
                    ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 2).ToString();
                    btn_Diamond1.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond1.Text = "1";
                    btn_Diamond2.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond2.Text = "1";
                }

                else if (btn_Diamond3.Text == "2")
                {
                    ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 1).ToString();
                    btn_Diamond1.BackgroundImage = Resources.gem_stone_48px;
                    btn_Diamond1.Text = "2";
                    btn_Diamond2.BackgroundImage = Resources.gem_stone_48px;
                    btn_Diamond2.Text = "2";
                    btn_Diamond3.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                    btn_Diamond3.Text = "1";
                }
            }
        }
        private void Btn_Diamond3_Click(object sender, EventArgs e)
        {
            if (btn_Diamond3.Text == "1")
            {
                if (ParentForm.lbl_DiamondCount.Text != "0" && ParentForm.lbl_DiamondCount.Text != "1" && ParentForm.lbl_DiamondCount.Text != "2")
                {
                    if (btn_Diamond1.Text == "1" && btn_Diamond2.Text == "1")
                    {
                        ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) - 3).ToString();
                        btn_Diamond1.BackgroundImage = Resources.gem_stone_48px;
                        btn_Diamond1.Text = "2";
                        btn_Diamond2.BackgroundImage = Resources.gem_stone_48px;
                        btn_Diamond2.Text = "2";
                        btn_Diamond3.BackgroundImage = Resources.gem_stone_48px;
                        btn_Diamond3.Text = "2";
                    }
                    else if (btn_Diamond1.Text == "2" && btn_Diamond2.Text == "2")
                    {
                        ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) - 1).ToString();
                        btn_Diamond3.BackgroundImage = Resources.gem_stone_48px;
                        btn_Diamond3.Text = "2";
                    }
                    else if (btn_Diamond1.Text == "2" && btn_Diamond2.Text == "1")
                    {
                        ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) - 2).ToString();
                        btn_Diamond2.BackgroundImage = Resources.gem_stone_48px;
                        btn_Diamond2.Text = "2";
                        btn_Diamond3.BackgroundImage = Resources.gem_stone_48px;
                        btn_Diamond3.Text = "2";
                    }
                }
            }
            else if (btn_Diamond3.Text == "2")
            {
                ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 3).ToString();
                btn_Diamond1.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                btn_Diamond1.Text = "1";
                btn_Diamond2.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                btn_Diamond2.Text = "1";
                btn_Diamond3.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                btn_Diamond3.Text = "1";
            }
        }
        private void Btn_DeleteAllDiamond_Click(object sender, EventArgs e)
        {
            if (btn_Diamond1.Text == "2" && btn_Diamond2.Text == "2" && btn_Diamond3.Text == "2")
            {
                ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 3).ToString();
                btn_Diamond1.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                btn_Diamond1.Text = "1";
                btn_Diamond2.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                btn_Diamond2.Text = "1";
                btn_Diamond3.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                btn_Diamond3.Text = "1";
            }
            else if (btn_Diamond1.Text == "2" && btn_Diamond2.Text == "2" && btn_Diamond3.Text == "1")
            {
                ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 2).ToString();
                btn_Diamond1.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                btn_Diamond1.Text = "1";
                btn_Diamond2.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                btn_Diamond2.Text = "1";
            }
            else if (btn_Diamond1.Text == "2" && btn_Diamond2.Text == "1" && btn_Diamond3.Text == "1")
            {
                ParentForm.lbl_DiamondCount.Text = (int.Parse(ParentForm.lbl_DiamondCount.Text) + 1).ToString();
                btn_Diamond1.BackgroundImage = Resources.icons8_gem_stone_100px_11;
                btn_Diamond1.Text = "1";
            }
        }
        private void Pb_std_MouseLeave(object sender, EventArgs e) => pb_ImageBig.Visible = false;
        private void Pb_std_MouseMove(object sender, MouseEventArgs e) => pb_ImageBig.Visible = true;
        private void Cb_InspectionWork_SelectedIndexChanged(object sender, EventArgs e) => cb_InspectionWork.FillColor = Color.FromArgb(190, 197, 234);
        private void Cb_ClassWork_SelectedIndexChanged(object sender, EventArgs e) => cb_ClassWork.FillColor = Color.FromArgb(174, 221, 145);
    }
}
