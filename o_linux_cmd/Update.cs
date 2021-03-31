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
    public partial class Update : Form
    {
        string update_url = "";
        string server_url = "http://www.ifreehub.com/olcservice/";
        public Update()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        UpdateHelper.check_value ret_update;
        private void Update_Load(object sender, EventArgs e)
        {
            Lab_CurVersion.Text = "当前版本：V" + Application.ProductVersion.Substring(0, 5);
            Task check_version = new Task(() =>
            {
                ret_update = UpdateHelper.check_update(server_url);
                if (ret_update.valid == true)
                {
                    Lab_LatestVersion.Text = "最新版本：V" + ret_update.version;
                    update_url = ret_update.link;
                    Text_Update.Text = ret_update.feature;
                    if (ret_update.version != Application.ProductVersion.Substring(0, 5))
                    {
                        Btn_GotoUpdate.Enabled = true;
                        Btn_Skip.Enabled = true;
                    }
                    app.Default.Last_Time_Config = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
                    app.Default.Save();
                }
                else
                {
                    Lab_LatestVersion.Text = "最新版本：啊哦！更新检查失败！";
                    Text_Update.Text = "可能的原因：\r\n1.当前网络状态异常；\r\n2.打开的姿势不对；\r\n3.作者的服务器断供；\r\n4.其他未知原因。";
                }
                
            });
            check_version.Start();

            //check_update(server_url);
            
        }

        private void Btn_GotoUpdate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(update_url);
        }

        private void Btn_Skip_Click(object sender, EventArgs e)
        {
            app.Default.Skip_Version_Config = ret_update.version;
            app.Default.Save();
        }
    }
}
