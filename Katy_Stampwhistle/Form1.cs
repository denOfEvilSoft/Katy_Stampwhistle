﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;

namespace Katy_Stampwhistle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MailMessage mail = new MailMessage();

        private void b_attach_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = "";
            fileName = openFileDialog.FileName;
            l_attachList.Items.Add(fileName);
        }

        private void b_addUser_Click(object sender, EventArgs e)
        {
            l_userList.Items.Add(t_addUser.Text);
            t_addUser.Text = "";
        }

        private void b_deleteUser_Click(object sender, EventArgs e)
        {
            var selectIndex = l_userList.SelectedIndex;
            l_userList.Items.RemoveAt(selectIndex);
        }

        private void b_clip_Click(object sender, EventArgs e)
        {
            string set = Clipboard.GetText();
            char cheak;
            int start = 0;
            string combine = "";

            for (int index = 0; index < set.Length - 2; index++)
            {
                cheak = set[index];
                if (cheak.ToString() == "\n")
                {
                    for (; start < index - 1; start++)
                    {
                        combine += set[start];
                    }
                    l_userList.Items.Add(combine);
                    combine = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_deleteAttach_Click(object sender, EventArgs e)
        {
            var selectIndex = l_attachList.SelectedIndex;
            l_attachList.Items.RemoveAt(selectIndex);
        }

        private void b_send_Click(object sender, EventArgs e)
        {
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential(t_id.Text, t_password.Text);
            smtpServer.EnableSsl = true;

            for (int index = 0; index < l_attachList.Items.Count; index++)
            {
                mail.Attachments.Add(new Attachment(l_attachList.Items.IndexOf(index).ToString()));
            }
            for(int index = 0; index < l_userList.Items.Count; index++)
            {
                mail.To.Add(l_userList.Items.IndexOf(index).ToString());
                smtpServer.Send(mail);
                mail.To.Clear();
            }
            mail.To.Clear();
            mail.Attachments.Clear();
            MessageBox.Show("전송 완료!");
        }

        private void b_ready_Click(object sender, EventArgs e)
        {
            if(b_ready.Text.ToString() == "전송 준비")
            {
                b_ready.Text = "준비 완료!";
                t_id.Enabled = false;
                t_password.Enabled = false;
                t_mailName.Enabled = false;
                t_subject.Enabled = false;
                t_addUser.Enabled = false;

                b_addUser.Enabled = false;
                b_deleteUser.Enabled = false;
                b_clip.Enabled = false;
                
                l_userList.Enabled = false;
                r_text.Enabled = false;

                l_attachList.Enabled = false;
                b_attach.Enabled = false;
                b_deleteAttach.Enabled = false;

                b_send.Enabled = true;

                mail.From = new MailAddress(t_id.Text + "@gmail.com", t_mailName.Text, System.Text.Encoding.UTF8);
                mail.Subject = t_subject.Text.ToString();
                mail.Body = r_text.Text;
            }
            else
            {
                b_ready.Text = "전송 준비";
                t_id.Enabled = true;
                t_password.Enabled = true;
                t_mailName.Enabled = true;
                t_subject.Enabled = true;
                t_addUser.Enabled = true;

                b_addUser.Enabled = true;
                b_deleteUser.Enabled = true;
                b_clip.Enabled = true;

                l_userList.Enabled = true;
                r_text.Enabled = true;

                l_attachList.Enabled = true;
                b_attach.Enabled = true;
                b_deleteAttach.Enabled = true;

                b_send.Enabled = false;
            }
        }
    }
}
