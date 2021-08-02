
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_password = new System.Windows.Forms.Label();
            this.t_password = new System.Windows.Forms.TextBox();
            this.l_gmail = new System.Windows.Forms.Label();
            this.t_id = new System.Windows.Forms.TextBox();
            this.l_userList = new System.Windows.Forms.ListBox();
            this.r_text = new System.Windows.Forms.RichTextBox();
            this.t_mailName = new System.Windows.Forms.TextBox();
            this.l_mailName = new System.Windows.Forms.Label();
            this.t_subject = new System.Windows.Forms.TextBox();
            this.l_subject = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.b_attach = new System.Windows.Forms.Button();
            this.l_attachList = new System.Windows.Forms.ListBox();
            this.b_deleteAttach = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_send = new System.Windows.Forms.Button();
            this.b_ready = new System.Windows.Forms.Button();
            this.t_addUser = new System.Windows.Forms.TextBox();
            this.b_addUser = new System.Windows.Forms.Button();
            this.b_deleteUser = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.b_clip = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_password);
            this.groupBox1.Controls.Add(this.t_password);
            this.groupBox1.Controls.Add(this.l_gmail);
            this.groupBox1.Controls.Add(this.t_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "전송자 정보";
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
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(5, 72);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(102, 21);
            this.t_password.TabIndex = 7;
            // 
            // l_gmail
            // 
            this.l_gmail.Font = new System.Drawing.Font("굴림", 11F);
            this.l_gmail.Location = new System.Drawing.Point(113, 24);
            this.l_gmail.Name = "l_gmail";
            this.l_gmail.Size = new System.Drawing.Size(87, 18);
            this.l_gmail.TabIndex = 1;
            this.l_gmail.Text = "@gmail.com";
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(7, 21);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(100, 21);
            this.t_id.TabIndex = 0;
            // 
            // l_userList
            // 
            this.l_userList.FormattingEnabled = true;
            this.l_userList.ItemHeight = 12;
            this.l_userList.Location = new System.Drawing.Point(6, 20);
            this.l_userList.Name = "l_userList";
            this.l_userList.Size = new System.Drawing.Size(219, 304);
            this.l_userList.TabIndex = 1;
            // 
            // r_text
            // 
            this.r_text.Location = new System.Drawing.Point(6, 20);
            this.r_text.Name = "r_text";
            this.r_text.Size = new System.Drawing.Size(388, 304);
            this.r_text.TabIndex = 2;
            this.r_text.Text = "";
            // 
            // t_mailName
            // 
            this.t_mailName.Location = new System.Drawing.Point(6, 35);
            this.t_mailName.Name = "t_mailName";
            this.t_mailName.Size = new System.Drawing.Size(194, 21);
            this.t_mailName.TabIndex = 2;
            // 
            // l_mailName
            // 
            this.l_mailName.AutoSize = true;
            this.l_mailName.Location = new System.Drawing.Point(6, 20);
            this.l_mailName.Name = "l_mailName";
            this.l_mailName.Size = new System.Drawing.Size(57, 12);
            this.l_mailName.TabIndex = 3;
            this.l_mailName.Text = "메일 이름";
            // 
            // t_subject
            // 
            this.t_subject.Location = new System.Drawing.Point(6, 80);
            this.t_subject.Name = "t_subject";
            this.t_subject.Size = new System.Drawing.Size(194, 21);
            this.t_subject.TabIndex = 4;
            // 
            // l_subject
            // 
            this.l_subject.AutoSize = true;
            this.l_subject.Location = new System.Drawing.Point(7, 65);
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
            this.b_deleteAttach.Click += new System.EventHandler(this.b_deleteAttach_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_send);
            this.groupBox2.Controls.Add(this.b_ready);
            this.groupBox2.Controls.Add(this.l_attachList);
            this.groupBox2.Controls.Add(this.b_attach);
            this.groupBox2.Controls.Add(this.b_deleteAttach);
            this.groupBox2.Location = new System.Drawing.Point(12, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 147);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // b_send
            // 
            this.b_send.Enabled = false;
            this.b_send.Location = new System.Drawing.Point(739, 108);
            this.b_send.Name = "b_send";
            this.b_send.Size = new System.Drawing.Size(105, 23);
            this.b_send.TabIndex = 11;
            this.b_send.Text = "전송!";
            this.b_send.UseVisualStyleBackColor = true;
            this.b_send.Click += new System.EventHandler(this.b_send_Click);
            // 
            // b_ready
            // 
            this.b_ready.Location = new System.Drawing.Point(739, 79);
            this.b_ready.Name = "b_ready";
            this.b_ready.Size = new System.Drawing.Size(105, 23);
            this.b_ready.TabIndex = 10;
            this.b_ready.Text = "전송 준비";
            this.b_ready.UseVisualStyleBackColor = true;
            this.b_ready.Click += new System.EventHandler(this.b_ready_Click);
            // 
            // t_addUser
            // 
            this.t_addUser.Location = new System.Drawing.Point(5, 19);
            this.t_addUser.Name = "t_addUser";
            this.t_addUser.Size = new System.Drawing.Size(195, 21);
            this.t_addUser.TabIndex = 14;
            // 
            // b_addUser
            // 
            this.b_addUser.Location = new System.Drawing.Point(5, 46);
            this.b_addUser.Name = "b_addUser";
            this.b_addUser.Size = new System.Drawing.Size(96, 23);
            this.b_addUser.TabIndex = 15;
            this.b_addUser.Text = "수동 추가";
            this.b_addUser.UseVisualStyleBackColor = true;
            this.b_addUser.Click += new System.EventHandler(this.b_addUser_Click);
            // 
            // b_deleteUser
            // 
            this.b_deleteUser.Location = new System.Drawing.Point(104, 46);
            this.b_deleteUser.Name = "b_deleteUser";
            this.b_deleteUser.Size = new System.Drawing.Size(96, 23);
            this.b_deleteUser.TabIndex = 16;
            this.b_deleteUser.Text = "선택 삭제";
            this.b_deleteUser.UseVisualStyleBackColor = true;
            this.b_deleteUser.Click += new System.EventHandler(this.b_deleteUser_Click);
            // 
            // b_clip
            // 
            this.b_clip.Location = new System.Drawing.Point(5, 75);
            this.b_clip.Name = "b_clip";
            this.b_clip.Size = new System.Drawing.Size(96, 23);
            this.b_clip.TabIndex = 17;
            this.b_clip.Text = "복사된 목록";
            this.b_clip.UseVisualStyleBackColor = true;
            this.b_clip.Click += new System.EventHandler(this.b_clip_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.t_addUser);
            this.groupBox3.Controls.Add(this.b_clip);
            this.groupBox3.Controls.Add(this.b_addUser);
            this.groupBox3.Controls.Add(this.b_deleteUser);
            this.groupBox3.Location = new System.Drawing.Point(12, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 107);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "수신자 목록 관리";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.t_mailName);
            this.groupBox4.Controls.Add(this.l_mailName);
            this.groupBox4.Controls.Add(this.t_subject);
            this.groupBox4.Controls.Add(this.l_subject);
            this.groupBox4.Location = new System.Drawing.Point(12, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 114);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.l_userList);
            this.groupBox5.Location = new System.Drawing.Point(225, 57);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(231, 337);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "수신자 목록";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.r_text);
            this.groupBox6.Location = new System.Drawing.Point(462, 57);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(407, 337);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "본문";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 31);
            this.panel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(838, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "_";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "제작자 이메일 : denofevil.soft@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(860, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "케이티 스탬프휘슬 : 이메일 대량 전송기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "이 프로그램을 처음 써본다면 날 눌러요!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "목록 초기화";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(882, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "케이티 스탬프휘슬 : 이메일 전송기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.TextBox t_password;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_addUser;
        private System.Windows.Forms.Button b_addUser;
        private System.Windows.Forms.Button b_deleteUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button b_clip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button b_send;
        private System.Windows.Forms.Button b_ready;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

