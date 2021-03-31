using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace o_linux_cmd
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            Lab_Version.Text = "版本：V" + Application.ProductVersion.Substring(0, 5);
        }

        private void Llab_Proj1_Click(object sender, EventArgs e)
        {
            
        }

        private void Llab_Proj1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jaywcjlove/linux-command");
        }

        private void Llab_Proj2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/lunet-io/markdig");
        }

        private void Llab_Proj3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JamesNK/Newtonsoft.Json");
        }

        private void Llab_Proj0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://man.linuxde.net");
        }
    }
}
