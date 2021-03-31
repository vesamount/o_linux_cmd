using Microsoft.Win32;
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
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void Pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_GotoUpdate_Click(object sender, EventArgs e)
        {
            app.Default.Auto_Start_Config = Chk_AutoStart.Checked == true ? true : false;
            app.Default.Min_Tray_Config = Chk_MinTray.Checked == true ? true : false;
            app.Default.Close_Tray_Config = Chk_CloseTray.Checked == true ? true : false;

            //保存更新周期
            if (Rad_Never.Checked == true) 
            {
                app.Default.Update_Cycle_Config = 0;
            }
            else if (Rad_Week.Checked == true)
            {
                app.Default.Update_Cycle_Config = 2;
            }
            else if (Rad_Month.Checked == true)
            {
                app.Default.Update_Cycle_Config = 3;
            }
            else
            {
                app.Default.Update_Cycle_Config = 1;
            }
            
            try
            {
                if (app.Default.Auto_Start_Config == true)
                {
                    //MessageBox.Show("start");
                    RegistryKey R_local = Registry.CurrentUser;//RegistryKey R_local = Registry.LocalMachine;//             
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.SetValue("O-LinuxCmd", Application.ExecutablePath);
                    R_run.Close();
                    R_local.Close();
                }
                else
                {
                    //MessageBox.Show("stop");
                    RegistryKey R_local = Registry.CurrentUser;//RegistryKey R_local = Registry.LocalMachine;      
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.DeleteValue("O-LinuxCmd", false);
                    R_run.Close();
                    R_local.Close();
                }
                //GlobalVariant.Instance.UserConfig.AutoStart = isAuto;      
            }
            catch (Exception)
            {
                //MessageBoxDlg dlg = new MessageBoxDlg();      
                //dlg.InitialData("您需要管理员权限修改", "提示", MessageBoxButtons.OK, MessageBoxDlgIcon.Error);       
                //dlg.ShowDialog();             
                MessageBox.Show("您需要管理员权限修改", "提示");
            }

            app.Default.Save();
            Btn_GotoUpdate.Enabled = false;
        }

        private void Option_Load(object sender, EventArgs e)
        {
            Chk_AutoStart.Checked = app.Default.Auto_Start_Config;
            Chk_MinTray.Checked = app.Default.Min_Tray_Config;
            Chk_CloseTray.Checked = app.Default.Close_Tray_Config;
            Lab_LastTime.Text =  app.Default.Last_Time_Config;

            switch (app.Default.Update_Cycle_Config)
            {
                case 0:
                    Rad_Never.Checked = true;
                    break;
                case 1:
                    Rad_Day.Checked = true;
                    break;
                case 2:
                    Rad_Week.Checked = true;
                    break;
                case 3:
                    Rad_Month.Checked = true;
                    break;
            }
            Btn_GotoUpdate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Llab_Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ifreehub.com");
        }

        private void Chk_AutoStart_CheckedChanged(object sender, EventArgs e)
        {
            Btn_GotoUpdate.Enabled = true;
        }

        private void Chk_MinTray_CheckedChanged(object sender, EventArgs e)
        {
            Btn_GotoUpdate.Enabled = true;
        }

        private void Chk_CloseTray_CheckedChanged(object sender, EventArgs e)
        {
            Btn_GotoUpdate.Enabled = true;
        }

        private void Rad_Day_CheckedChanged(object sender, EventArgs e)
        {
            Btn_GotoUpdate.Enabled = true;
        }

        private void Rad_Week_CheckedChanged(object sender, EventArgs e)
        {
            Btn_GotoUpdate.Enabled = true;
        }

        private void Rad_Month_CheckedChanged(object sender, EventArgs e)
        {
            Btn_GotoUpdate.Enabled = true;
        }

        private void Rad_Never_CheckedChanged(object sender, EventArgs e)
        {
            Btn_GotoUpdate.Enabled = true;
        }
    }
}
