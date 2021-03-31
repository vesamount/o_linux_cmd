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
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
        }

        private void Pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string[] message = { "吃个包子", "吃碗拌面", "喝杯豆浆", "吃碗豆腐花", "吃根油条", "吃个烧饼", "喝碗米粥", "吃个茶叶蛋", "喝杯咖啡", "吃碗扁肉" };

        private void Donate_Load(object sender, EventArgs e)
        {
            int index = DateTime.Now.Second % 10;
            Lab_Talk.Text = "嘿！亲爱的朋友，如果觉得好用，不妨请我 " + message[index] + " 吧！";
        }
    }
}
