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

        private void b_attach_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = openFileDialog.FileName;
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
            string combine = "";
            char [] cheak = new char[4];

            int start = 0;

            for(int index = 0; index < set.Length - 3; index++)
            {
                cheak[0] = set[index];
                cheak[1] = set[index + 1];
                cheak[2] = set[index + 2];
                cheak[3] = set[index + 3];
                if(Convert.ToString(cheak) == ".com")
                {
                    for (; start < index + 3; start++)
                    {
                        combine += set[start];
                    }
                    l_userList.Items.Add(combine);
                    start++;
                }
            }
        }
    }
}
