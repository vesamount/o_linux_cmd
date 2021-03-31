using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace o_linux_cmd
{
    public partial class Check_Update : Form
    {
        string update_url = "";
        public Check_Update()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            Lab_LatestVersion.Text = "最新版本: V" + Main_Form.ckvl.version;
            update_url = Main_Form.ckvl.link;
        }

        private void Btn_GotoUpdate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(update_url);
            this.Close();
        }

        private void Btn_Skip_Click(object sender, EventArgs e)
        {
            app.Default.Skip_Version_Config = Main_Form.ckvl.version;
            app.Default.Save();
            this.Close();
        }
    }
}
