using Markdig;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace o_linux_cmd
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        /// <summary>
        /// resize window
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        void Fuzzy_Result_Show(List<Suggest_Cmd> list)
        {
            FileStream fsw = new FileStream(Application.StartupPath + @"\result_list.html", FileMode.Create);
            StreamWriter sw = new StreamWriter(fsw, Encoding.UTF8);
            StringBuilder SB_Tmp = new StringBuilder();
            SB_Tmp.Append("<link href=\"./data/markdown.css\" rel=\"stylesheet\" type=\"text/css\"/>\n\n");
            SB_Tmp.Append("<div><ul>");
            if (list.Count == 0)
            {
                SB_Tmp.Append("<p style=\"text-align:center\"><img src=\"./image/Sorry.png\" height=\"250\" width=\"250\" /></p>");
                SB_Tmp.Append("<p style=\"text-align:center\"><strong>Sorry!!!无对应查询结果。</strong></p>");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    SB_Tmp.Append("<li><strong>");
                    SB_Tmp.Append(list[i].command);
                    SB_Tmp.Append("</strong>");
                    SB_Tmp.Append("-" + list[i].describe);
                    SB_Tmp.Append("<p></p></li>");
                }
            }
            
            SB_Tmp.Append("</ul></div>");
            sw.Write(SB_Tmp.ToString());
            sw.Close();
            fsw.Close();

            WebBro.Navigate(Application.StartupPath + @"\result_list.html");
        }

        bool collapse_flag = true;//是否折叠标志 true：折叠 false：展开
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            //Panel_Menu.Visible = false;
            if (Text_Search.Text == "")
            {
                //MessageBox.Show("请输入需要查询的命令");
                return;
            }
            collapse_flag = true;
            timer1.Start();
            Btn_Search_Clear();

            List<Suggest_Cmd> tmp_list = new List<Suggest_Cmd>();
            for (int i = 0; i < List_Cmd.Count; i++)
            {
                if (List_Cmd[i].Equals(Text_Search.Text))
                {
                    Accurate_Result_Show(List_Cmd[i]);
                    return;
                }
                int cmd_index = List_Cmd[i].IndexOf(Text_Search.Text);
                if (cmd_index > -1)
                {
                    Suggest_Cmd tmp_suggest = new Suggest_Cmd();
                    tmp_suggest.command = List_Cmd[i];
                    tmp_suggest.describe = List_Cmd_Desc[i];
                    tmp_list.Add(tmp_suggest);
                    //MessageBox.Show(List_Cmd[i]+ "-" + List_Cmd_Desc[i]);

                }
            }
            tmp_list = SimilarDegree_Sort(tmp_list);

            Fuzzy_Result_Show(tmp_list);

            //WebBro.Navigate(Application.StartupPath + "/tmp.html");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (collapse_flag == true)
            {
                if (Panel_Search.Location.Y <= -160)
                {
                    timer1.Stop();
                    Llab_Copy_Right.Visible = false;
                    Pic_Small_Logo.Visible = true;
                    Panel_Web.Visible = true;
                    return;

                }
                Panel_Search.Location = new Point(Panel_Search.Location.X, Panel_Search.Location.Y - 5);
            }
            else 
            {
                if (Panel_Search.Location.Y >= 40)
                {
                    timer1.Stop();
                    Llab_Copy_Right.Visible = true;
                    Pic_Small_Logo.Visible = false;
                    return;
                }
                Panel_Search.Location = new Point(Panel_Search.Location.X, Panel_Search.Location.Y + 5);
            }
        }

        private void Pic_Close_Click(object sender, EventArgs e)
        {
            if (app.Default.Close_Tray_Config)
            {
                Old_State = this.WindowState;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                return;
            }
            else 
            {
                notifyIcon1.Dispose();
                File.Delete(Application.StartupPath + @"\tmp.html");
                File.Delete(Application.StartupPath + @"\result_list.html");
                System.Environment.Exit(0);
            }
        }

        private void Pic_Small_Logo_Click(object sender, EventArgs e)
        {
            //Panel_Menu.Visible = false;
            collapse_flag = false;
            Panel_Web.Visible = false;
            Pic_Small_Logo.Visible = false;
            timer1.Start();
        }

        private void Llab_Copy_Right_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ifreehub.com");
        }

        private void Pic_Max_Nor_Click(object sender, EventArgs e)
        {
            //Panel_Menu.Visible = false;
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                Pic_Max_Nor.Image = Properties.Resources.Max_Windows;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                Pic_Max_Nor.Image = Properties.Resources.Normal_Windows;
            }
        }
        FormWindowState Old_State = FormWindowState.Normal;
        private void Pic_Min_Click(object sender, EventArgs e)
        {
            //Panel_Menu.Visible = false;
            Old_State = this.WindowState;
            this.WindowState = FormWindowState.Minimized;
            if (app.Default.Min_Tray_Config)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void Pic_Icon_Click(object sender, EventArgs e)
        {
            Panel_Menu.Visible = true;
            timer3.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        List<string> List_Cmd = new List<string>();
        List<string> List_Cmd_Desc = new List<string>();
        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            timer2.Stop();
            timer2.Start();
        }
        public static UpdateHelper.check_value ckvl;
        string server_url = "http://www.ifreehub.com/olcservice/";

        public string GetHardDiskSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
                string sHardDiskSerialNumber = "";
                foreach (ManagementObject mo in searcher.Get())
                {
                    sHardDiskSerialNumber = mo["SerialNumber"].ToString().Trim();
                    break;
                }
                return sHardDiskSerialNumber;
            }
            catch
            {
                return "";
            }
        }


        void Upload_Hardware_Info(string url)
        {
            Task upload_info = new Task(() =>
            {
                
                var postUrl = url + "hardinfo_record.php";
                string postData = "HardDiskSN=" + GetHardDiskSerialNumber();
                HttpWebRequestHelper.HttpPostRequestAsync(postUrl, postData);

            });
            upload_info.Start();
        }

        void Start_Check_Version()
        {
            short check_cycle_days = 0;
            switch (app.Default.Update_Cycle_Config)//获取周期查询天数
            {
                case 0:
                    check_cycle_days = 0;
                    return;
                case 1:
                    check_cycle_days = 1;
                    break;
                case 2:
                    check_cycle_days = 7;
                    break;
                case 3:
                    check_cycle_days = 30;
                    break;
            }
            DateTime CurrentDateTime = DateTime.Now;
            DateTime LastDateTime = Convert.ToDateTime(app.Default.Last_Time_Config);

            DateTime LastDateTime_Cycle = LastDateTime.AddDays(check_cycle_days);

            if (CurrentDateTime.CompareTo(LastDateTime_Cycle) >= 0)
            {

                Task check_version = new Task(() =>
                {
                    UpdateHelper.check_value ret_update = UpdateHelper.check_update(server_url);
                    if ((ret_update.valid == true) && (app.Default.Skip_Version_Config != ret_update.version) && (ret_update.version != Application.ProductVersion.Substring(0, 5)))
                    {
                        ckvl.version = ret_update.version;
                        ckvl.link = ret_update.link;
                        app.Default.Last_Time_Config = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
                        app.Default.Save();
                        Check_Update ckup = new Check_Update();
                        ckup.ShowDialog();
                    }
                    else
                    {
                        return;
                    }

                });
                check_version.Start();
            }
            else 
            {
                //MessageBox.Show("skip update cycle " + check_cycle_days);
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Lab_Header.Text = "O-LinuxCmd V" + Application.ProductVersion.Substring(0, 5);
            FileStream fs = new FileStream(Application.StartupPath + @"\data\data.json", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            JObject obj = JObject.Parse(sr.ReadToEnd());
            foreach (KeyValuePair<string, JToken> item in obj)
            {
                string key = item.Key;
                dynamic json = Newtonsoft.Json.Linq.JToken.Parse(item.Value.ToString()) as dynamic;
                List_Cmd.Add(key);
                List_Cmd_Desc.Add(json.d.ToString());
            }
            fs.Close();
            sr.Close();
            Upload_Hardware_Info(server_url);
            Start_Check_Version();
        }

        

        void Add_Search_Result()
        {
 
        }

        public class Suggest_Cmd
        {
            public string command { get; set; }
            public string describe { get; set; }
        }
        List<Suggest_Cmd> SimilarDegree_Sort(List<Suggest_Cmd> list)
        {
            Suggest_Cmd m;
            for (int i = 0; i < list.Count; ++i)
            {

                for (int j = 0; j < list.Count - i - 1; ++j)
                {
                    if (list[j].command.Length >= list[j + 1].command.Length)
                    //if (tmp_list[j].CompareTo(tmp_list[j + 1]) >= 0)
                    {
                        m = list[j];

                        list[j] = list[j + 1];

                        list[j + 1] = m;
                    }
                }
            }
            return list;
        }

        List<Button> Btn_Search_list = new List<Button>();

        void Btn_Search_Clear()
        {
            foreach (Button tmp in Btn_Search_list)
            {
                Panel_Suggest.Controls.Remove(tmp);
            }
            Panel_Suggest.Height = 0;
            Panel_Search.Height = 248;
        }


        void Btn_Accurate_Result_Show(object sender, EventArgs e)
        {
            string command;
            Button tmp_send_btn = (Button)sender;
            command = tmp_send_btn.Name;
            Accurate_Result_Show(command);
        }

        void Accurate_Result_Show(string command)
        {
            FileStream fsr = new FileStream(Application.StartupPath + @"\data\command\" + command + @".md", FileMode.Open);
            StreamReader sr = new StreamReader(fsr, Encoding.UTF8);
            StringBuilder SB_Tmp = new StringBuilder();
            SB_Tmp.Append("<link href=\"./data/markdown.css\" rel=\"stylesheet\" type=\"text/css\"/>\n\n");
            SB_Tmp.Append(sr.ReadToEnd());
            sr.Close();
            fsr.Close();

            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            var result = Markdown.ToHtml(SB_Tmp.ToString(), pipeline);
            FileStream fsw = new FileStream(Application.StartupPath + @"\tmp.html", FileMode.Create);
            StreamWriter sw = new StreamWriter(fsw, Encoding.UTF8);
            sw.Write(result);
            sw.Close();
            fsw.Close();

            collapse_flag = true;
            timer1.Start();
            Btn_Search_Clear();
            WebBro.Navigate(Application.StartupPath + @"\tmp.html");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            
            List<Suggest_Cmd> tmp_list = new List<Suggest_Cmd>();
            if (Text_Search.Text != "")
            {
                for (int i = 0; i < List_Cmd.Count; i++)
                {
                    int cmd_index = List_Cmd[i].IndexOf(Text_Search.Text);
                    if (cmd_index > -1)
                    {
                        Suggest_Cmd tmp_suggest = new Suggest_Cmd();
                        tmp_suggest.command = List_Cmd[i];
                        tmp_suggest.describe = List_Cmd_Desc[i];
                        tmp_list.Add(tmp_suggest);
                        //MessageBox.Show(List_Cmd[i]+ "-" + List_Cmd_Desc[i]);

                    }
                }
                tmp_list = SimilarDegree_Sort(tmp_list);
                foreach (Button tmp in Btn_Search_list)
                {
                    Panel_Suggest.Controls.Remove(tmp);
                }
                for (int i = 0; i < (tmp_list.Count < 4 ? tmp_list.Count : 4); i++)
                {
                    //MessageBox.Show(tmp_list[i].command);
                    Button Btn_Suggest = new Button();
                    Btn_Suggest.Name = tmp_list[i].command;// "Btn_Suggest_" + i;
                    Btn_Suggest.Text = tmp_list[i].command + "-" + tmp_list[i].describe;
                    Btn_Suggest.Font = new Font("Consolas", 10.5f);
                    Btn_Suggest.BackColor = Color.White;
                    Btn_Suggest.FlatStyle = FlatStyle.Flat;
                    Btn_Suggest.FlatAppearance.BorderSize = 0;
                    Btn_Suggest.TextAlign = ContentAlignment.MiddleLeft;
                    Btn_Suggest.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    Btn_Suggest.Width = Panel_Search.Width - 5;
                    Btn_Suggest.Height = 25;
                    Btn_Suggest.TabStop = false;
                    Btn_Suggest.Location = new Point(2, 4 + i * 27);
                    //Panel_Suggest.Width = Panel_Search.Width;
                    Panel_Suggest.Height = 4 + (i + 1) * 27 + 4;
                    Panel_Search.Height = 260 + (i + 1) * 27;
                    Btn_Suggest.Click += new System.EventHandler(Btn_Accurate_Result_Show);
                    Panel_Suggest.Controls.Add(Btn_Suggest);
                    Btn_Search_list.Add(Btn_Suggest);
                }
            }
            else 
            {
                Btn_Search_Clear();
            }
        }

        private void Main_Form_Click(object sender, EventArgs e)
        {
            //Panel_Menu.Visible = false;
        }

        private void Panel_Search_Click(object sender, EventArgs e)
        {
            //Panel_Menu.Visible = false;
        }

        private void Panel_Web_Click(object sender, EventArgs e)
        {
            //Panel_Menu.Visible = false;
        }

        private void Pic_BigLogo_Click(object sender, EventArgs e)
        {
            //Panel_Menu.Visible = false;
        }

        private void Text_Search_Click(object sender, EventArgs e)
        {
            //Panel_Menu.Visible = false;
        }

        private void Panel_Header_Click(object sender, EventArgs e)
        {
            //Panel_Menu.Visible = false;
        }

        private void Btn_Donate_Click(object sender, EventArgs e)
        {
            Panel_Menu.Visible = false;
            Donate Donate_Form = new Donate();
            Donate_Form.ShowDialog();
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            Panel_Menu.Visible = false;
            About About_Form = new About();
            About_Form.ShowDialog();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Panel_Menu.Visible = false;
            Update Update_Form = new Update();
            Update_Form.ShowDialog();
        }

        private void Btn_Set_Click(object sender, EventArgs e)
        {
            Panel_Menu.Visible = false;
            Option Option_Form = new Option();
            Option_Form.ShowDialog();
        }

        private void Btn_Chat_Click(object sender, EventArgs e)
        {
            Panel_Menu.Visible = false;
            Chat Chat_Form = new Chat();
            Chat_Form.ShowDialog();
        }

        private void Text_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))//回车响应
            {
                Btn_Search_Click(sender, e);
                e.Handled = true;
                //MessageBox.Show("enter");
            }
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {
                this.WindowState = Old_State;//System.Windows.Forms.FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
            else
            {
                this.Activate();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(Application.StartupPath + @"\tmp.html");
            File.Delete(Application.StartupPath + @"\result_list.html");
            notifyIcon1.Dispose();
            System.Environment.Exit(0);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About About_Form = new About();
            About_Form.ShowDialog();
        }

        private void oLinuxCmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
            else
            {
                this.Activate();
            }
        }

        private void WebBro_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Panel_Menu.Visible = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (((Control.MousePosition.X < (Panel_Menu.Location.X + this.Location.X))
                || (Control.MousePosition.X > (Panel_Menu.Location.X + this.Location.X + Panel_Menu.Width)) 
                || (Control.MousePosition.Y < (Panel_Menu.Location.Y + this.Location.Y))
                || (Control.MousePosition.Y > (Panel_Menu.Location.Y + this.Location.Y + Panel_Menu.Height))) 
                && (Control.MouseButtons == MouseButtons.Left))
            {
                timer3.Stop();
                Panel_Menu.Visible = false;
            }               
        }

        private void Pic_Donate_Click(object sender, EventArgs e)
        {
            Panel_Menu.Visible = false;
            Donate Donate_Form = new Donate();
            Donate_Form.ShowDialog();
        }
    }
}
