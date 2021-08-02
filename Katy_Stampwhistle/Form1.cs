using System;
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
            if(t_addUser.Text == "")
            {
                MessageBox.Show("이메일을 입력해주세요!", "케이티 스탬프휘슬 : 이메일 전송기", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            l_userList.Items.Add(t_addUser.Text);
            t_addUser.Text = "";
        }

        private void b_deleteUser_Click(object sender, EventArgs e)
        {
            if(l_userList.SelectedIndex == -1)
            {
                MessageBox.Show("삭제할 수신자를 먼저 선택하세요!", "케이티 스탬프휘슬 : 이메일 전송기", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            var selectIndex = l_userList.SelectedIndex;
            l_userList.Items.RemoveAt(selectIndex);
        }

        private void b_clip_Click(object sender, EventArgs e)
        {
            if(Clipboard.GetText() == null)
            {
                MessageBox.Show("복사된게 없는거 같은데요!", "케이티 스탬프휘슬 : 이메일 전송기", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            string set = Clipboard.GetText();
            char cheak;
            int start = 0;
            string combine = "";

            bool firstLine = false;

            for (int index = 0; index < set.Length; index++)
            {
                cheak = set[index];
                if (cheak.ToString() == "\n" || index == set.Length - 1)
                {
                    for (; start <= index; start++)
                    {
                        if(firstLine == false)
                        {
                            firstLine = true;
                        }
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
            this.Cursor = Cursors.WaitCursor;
            wait w8 = new wait();
            w8.Show();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential(t_id.Text, t_password.Text);
            smtpServer.EnableSsl = true;
            try
            {
                for (int index = 0; index < l_attachList.Items.Count; index++)
                {
                    Attachment attach = new Attachment(l_attachList.Items[index].ToString());
                    mail.Attachments.Add(attach);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("파일 첨부에 문제가 있어요. 경로에 파일이 있나요?\n\n" + ex, "케이티 스탬프휘슬 : 이메일 전송기", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {
                for(int index = 0; index < l_userList.Items.Count; index++)
                {
                    mail.To.Add(l_userList.Items[index].ToString());
                    smtpServer.Send(mail);
                    mail.To.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("수신자를 추가하는 도중, 아니면 이메일 전송 중에 문제가 생겼어요.\n수신자 이메일을 확인해볼래요?\n아니면 인터넷을 확인해봐요.\n구글 계정 설정은 하셨나요?\n비밀번호나 아이디가 틀렸을 수도 있어요!", "케이티 스탬프휘슬 : 이메일 전송기", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                w8.Close();
                this.Cursor = Cursors.Default;
                mail.To.Clear();
                mail.Attachments.Clear();
                return;
            }
            mail.To.Clear();
            mail.Attachments.Clear();
            this.Cursor = Cursors.Default;
            w8.Close();
            MessageBox.Show("전송 완료!");
        }

        private void b_ready_Click(object sender, EventArgs e)
        {
            if(t_id.Text == "" || t_password.Text == "" || t_mailName.Text == "" || t_subject.Text == "")
            {
                MessageBox.Show("정말 준비된거 맞아요?", "케이티 스탬프휘슬 : 이메일 전송기", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if(b_ready.Text.ToString() == "전송 준비")
            {
                b_ready.Text = "수정";
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

                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
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

        private void label3_Click(object sender, EventArgs e)
        {
            exit qui8 = new exit();
            qui8.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Help hp = new Help();
            hp.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l_userList.Items.Clear();
        }
    }
}
