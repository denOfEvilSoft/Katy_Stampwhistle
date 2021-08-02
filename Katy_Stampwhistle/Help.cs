using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katy_Stampwhistle
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://denofevil.tistory.com/4");
            }catch(Exception ex)
            {
                MessageBox.Show("링크 이동중 문제 발생!", "" ,MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
