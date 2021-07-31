
namespace Katy_Stampwhistle
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.l_gmail = new System.Windows.Forms.Label();
            this.l_userList = new System.Windows.Forms.ListBox();
            this.r_text = new System.Windows.Forms.RichTextBox();
            this.t_mailName = new System.Windows.Forms.TextBox();
            this.l_mailName = new System.Windows.Forms.Label();
            this.t_subject = new System.Windows.Forms.TextBox();
            this.l_subject = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.b_attach = new System.Windows.Forms.Button();
            this.l_password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.l_attachList = new System.Windows.Forms.ListBox();
            this.b_deleteAttach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_addUser = new System.Windows.Forms.TextBox();
            this.b_addUser = new System.Windows.Forms.Button();
            this.b_deleteUser = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.b_clip = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_password);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.l_gmail);
            this.groupBox1.Controls.Add(this.t_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "전송자 정보";
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(7, 21);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(100, 21);
            this.t_id.TabIndex = 0;
            // 
            // l_gmail
            // 
            this.l_gmail.Font = new System.Drawing.Font("굴림", 11F);
            this.l_gmail.Location = new System.Drawing.Point(113, 24);
            this.l_gmail.Name = "l_gmail";
            this.l_gmail.Size = new System.Drawing.Size(100, 18);
            this.l_gmail.TabIndex = 1;
            this.l_gmail.Text = "@gmail.com";
            // 
            // l_userList
            // 
            this.l_userList.FormattingEnabled = true;
            this.l_userList.ItemHeight = 12;
            this.l_userList.Location = new System.Drawing.Point(224, 33);
            this.l_userList.Name = "l_userList";
            this.l_userList.Size = new System.Drawing.Size(174, 256);
            this.l_userList.TabIndex = 1;
            // 
            // r_text
            // 
            this.r_text.Location = new System.Drawing.Point(404, 33);
            this.r_text.Name = "r_text";
            this.r_text.Size = new System.Drawing.Size(465, 256);
            this.r_text.TabIndex = 2;
            this.r_text.Text = "";
            // 
            // t_mailName
            // 
            this.t_mailName.Location = new System.Drawing.Point(12, 145);
            this.t_mailName.Name = "t_mailName";
            this.t_mailName.Size = new System.Drawing.Size(206, 21);
            this.t_mailName.TabIndex = 2;
            // 
            // l_mailName
            // 
            this.l_mailName.AutoSize = true;
            this.l_mailName.Location = new System.Drawing.Point(12, 130);
            this.l_mailName.Name = "l_mailName";
            this.l_mailName.Size = new System.Drawing.Size(57, 12);
            this.l_mailName.TabIndex = 3;
            this.l_mailName.Text = "메일 이름";
            // 
            // t_subject
            // 
            this.t_subject.Location = new System.Drawing.Point(12, 187);
            this.t_subject.Name = "t_subject";
            this.t_subject.Size = new System.Drawing.Size(206, 21);
            this.t_subject.TabIndex = 4;
            // 
            // l_subject
            // 
            this.l_subject.AutoSize = true;
            this.l_subject.Location = new System.Drawing.Point(13, 172);
            this.l_subject.Name = "l_subject";
            this.l_subject.Size = new System.Drawing.Size(29, 12);
            this.l_subject.TabIndex = 5;
            this.l_subject.Text = "제목";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Title = "케이티 스탬프휘슬 : 파일첨부";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // b_attach
            // 
            this.b_attach.Location = new System.Drawing.Point(740, 21);
            this.b_attach.Name = "b_attach";
            this.b_attach.Size = new System.Drawing.Size(104, 23);
            this.b_attach.TabIndex = 6;
            this.b_attach.Text = "파일 첨부";
            this.b_attach.UseVisualStyleBackColor = true;
            this.b_attach.Click += new System.EventHandler(this.b_attach_Click);
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Location = new System.Drawing.Point(5, 57);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(81, 12);
            this.l_password.TabIndex = 8;
            this.l_password.Text = "구글 비밀번호";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 21);
            this.textBox1.TabIndex = 7;
            // 
            // l_attachList
            // 
            this.l_attachList.FormattingEnabled = true;
            this.l_attachList.ItemHeight = 12;
            this.l_attachList.Location = new System.Drawing.Point(8, 20);
            this.l_attachList.Name = "l_attachList";
            this.l_attachList.Size = new System.Drawing.Size(726, 112);
            this.l_attachList.TabIndex = 3;
            // 
            // b_deleteAttach
            // 
            this.b_deleteAttach.Location = new System.Drawing.Point(739, 50);
            this.b_deleteAttach.Name = "b_deleteAttach";
            this.b_deleteAttach.Size = new System.Drawing.Size(105, 23);
            this.b_deleteAttach.TabIndex = 9;
            this.b_deleteAttach.Text = "선택 첨부 취소";
            this.b_deleteAttach.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "전송!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.l_attachList);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.b_attach);
            this.groupBox2.Controls.Add(this.b_deleteAttach);
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 147);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "파일 첨부, 전송";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "내용";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "받을 사람 목록";
            // 
            // t_addUser
            // 
            this.t_addUser.Location = new System.Drawing.Point(12, 224);
            this.t_addUser.Name = "t_addUser";
            this.t_addUser.Size = new System.Drawing.Size(100, 21);
            this.t_addUser.TabIndex = 14;
            // 
            // b_addUser
            // 
            this.b_addUser.Location = new System.Drawing.Point(34, 252);
            this.b_addUser.Name = "b_addUser";
            this.b_addUser.Size = new System.Drawing.Size(75, 23);
            this.b_addUser.TabIndex = 15;
            this.b_addUser.Text = "수동 추가";
            this.b_addUser.UseVisualStyleBackColor = true;
            this.b_addUser.Click += new System.EventHandler(this.b_addUser_Click);
            // 
            // b_deleteUser
            // 
            this.b_deleteUser.Location = new System.Drawing.Point(128, 252);
            this.b_deleteUser.Name = "b_deleteUser";
            this.b_deleteUser.Size = new System.Drawing.Size(75, 23);
            this.b_deleteUser.TabIndex = 16;
            this.b_deleteUser.Text = "대상 삭제";
            this.b_deleteUser.UseVisualStyleBackColor = true;
            this.b_deleteUser.Click += new System.EventHandler(this.b_deleteUser_Click);
            // 
            // b_clip
            // 
            this.b_clip.Location = new System.Drawing.Point(404, 470);
            this.b_clip.Name = "b_clip";
            this.b_clip.Size = new System.Drawing.Size(75, 23);
            this.b_clip.TabIndex = 17;
            this.b_clip.Text = "복사목록 추가";
            this.b_clip.UseVisualStyleBackColor = true;
            this.b_clip.Click += new System.EventHandler(this.b_clip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 584);
            this.Controls.Add(this.b_clip);
            this.Controls.Add(this.b_deleteUser);
            this.Controls.Add(this.b_addUser);
            this.Controls.Add(this.t_addUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.r_text);
            this.Controls.Add(this.l_subject);
            this.Controls.Add(this.l_userList);
            this.Controls.Add(this.t_subject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.l_mailName);
            this.Controls.Add(this.t_mailName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "케이티 스탬프휘슬 : 이메일 전송기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_attach;
        private System.Windows.Forms.Label l_subject;
        private System.Windows.Forms.TextBox t_subject;
        private System.Windows.Forms.Label l_mailName;
        private System.Windows.Forms.TextBox t_mailName;
        private System.Windows.Forms.Label l_gmail;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.ListBox l_userList;
        private System.Windows.Forms.RichTextBox r_text;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox l_attachList;
        private System.Windows.Forms.Button b_deleteAttach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_addUser;
        private System.Windows.Forms.Button b_addUser;
        private System.Windows.Forms.Button b_deleteUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button b_clip;
    }
}

