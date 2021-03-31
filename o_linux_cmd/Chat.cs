using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace o_linux_cmd
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void Pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        static int Current_Code = 0;

        void Refresh_Code()
        {
            Random random = new Random(GetRandomSeed());
            Current_Code = random.Next(0, 9999);
            Lab_Code.Text = Current_Code.ToString().PadLeft(4, '0');
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            Refresh_Code();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (Text_Data.Text == "")
            {
                MessageBox.Show("请输入需要反馈的内容！");
                return;
            }
            if (Text_Name.Text == "")
            {
                MessageBox.Show("请输入昵称！");
                return;
            }

            if (Text_Mail.Text == "" || (Text_Mail.Text.IndexOf("@") <= -1))
            {
                MessageBox.Show("请输入正确的邮箱地址！");
                return;
            }

            if (Text_Code.Text.Length < 4)
            {
                MessageBox.Show("请输入正确的验证码！");
                return;
            }

            if (Text_Code.Text != Lab_Code.Text)
            {

                MessageBox.Show("验证码输入错误！");
                
            }
            else
            {
                var postUrl = "http://www.ifreehub.com/olcservice/bug_report.php";
                string postData = "data="+Text_Data.Text+"&name="+Text_Name.Text+"&mail="+Text_Mail.Text;
                HttpWebRequestHelper.HttpPostRequestAsync(postUrl, postData);
                MessageBox.Show("反馈已提交！");
            }
            Refresh_Code();
        }

        private void Lab_Code_Click(object sender, EventArgs e)
        {
            Refresh_Code();
        }
    }
}
