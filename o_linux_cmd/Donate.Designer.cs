namespace o_linux_cmd
{
    partial class Donate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donate));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Lab_Header = new System.Windows.Forms.Label();
            this.Pic_Icon = new System.Windows.Forms.PictureBox();
            this.Pic_Close = new System.Windows.Forms.PictureBox();
            this.Lab_Alipay = new System.Windows.Forms.Label();
            this.Lab_Wechatpay = new System.Windows.Forms.Label();
            this.Lab_Talk = new System.Windows.Forms.Label();
            this.Pic_Wechatpay = new System.Windows.Forms.PictureBox();
            this.Pic_Alipay = new System.Windows.Forms.PictureBox();
            this.dragControl1 = new o_linux_cmd.DragControl();
            this.dragControl2 = new o_linux_cmd.DragControl();
            this.Panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Wechatpay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Alipay)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Panel_Header.Controls.Add(this.Lab_Header);
            this.Panel_Header.Controls.Add(this.Pic_Icon);
            this.Panel_Header.Controls.Add(this.Pic_Close);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(500, 35);
            this.Panel_Header.TabIndex = 0;
            // 
            // Lab_Header
            // 
            this.Lab_Header.AutoSize = true;
            this.Lab_Header.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Header.ForeColor = System.Drawing.Color.White;
            this.Lab_Header.Location = new System.Drawing.Point(197, 4);
            this.Lab_Header.Name = "Lab_Header";
            this.Lab_Header.Size = new System.Drawing.Size(107, 26);
            this.Lab_Header.TabIndex = 11;
            this.Lab_Header.Text = "请他吃早餐";
            // 
            // Pic_Icon
            // 
            this.Pic_Icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pic_Icon.Image = global::o_linux_cmd.Properties.Resources.Donate_96px;
            this.Pic_Icon.Location = new System.Drawing.Point(0, 0);
            this.Pic_Icon.Name = "Pic_Icon";
            this.Pic_Icon.Size = new System.Drawing.Size(35, 35);
            this.Pic_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Icon.TabIndex = 10;
            this.Pic_Icon.TabStop = false;
            // 
            // Pic_Close
            // 
            this.Pic_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Close.Image = global::o_linux_cmd.Properties.Resources.Close_Windows;
            this.Pic_Close.Location = new System.Drawing.Point(465, 0);
            this.Pic_Close.Name = "Pic_Close";
            this.Pic_Close.Size = new System.Drawing.Size(35, 35);
            this.Pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Close.TabIndex = 9;
            this.Pic_Close.TabStop = false;
            this.Pic_Close.Click += new System.EventHandler(this.Pic_Close_Click);
            // 
            // Lab_Alipay
            // 
            this.Lab_Alipay.AutoSize = true;
            this.Lab_Alipay.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Alipay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_Alipay.Location = new System.Drawing.Point(99, 287);
            this.Lab_Alipay.Name = "Lab_Alipay";
            this.Lab_Alipay.Size = new System.Drawing.Size(69, 26);
            this.Lab_Alipay.TabIndex = 12;
            this.Lab_Alipay.Text = "支付宝";
            // 
            // Lab_Wechatpay
            // 
            this.Lab_Wechatpay.AutoSize = true;
            this.Lab_Wechatpay.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Wechatpay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_Wechatpay.Location = new System.Drawing.Point(342, 287);
            this.Lab_Wechatpay.Name = "Lab_Wechatpay";
            this.Lab_Wechatpay.Size = new System.Drawing.Size(50, 26);
            this.Lab_Wechatpay.TabIndex = 13;
            this.Lab_Wechatpay.Text = "微信";
            // 
            // Lab_Talk
            // 
            this.Lab_Talk.AutoSize = true;
            this.Lab_Talk.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Talk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_Talk.Location = new System.Drawing.Point(33, 48);
            this.Lab_Talk.Name = "Lab_Talk";
            this.Lab_Talk.Size = new System.Drawing.Size(410, 22);
            this.Lab_Talk.TabIndex = 14;
            this.Lab_Talk.Text = "嘿！亲爱的朋友，如果觉得好用，不妨请我吃个包子吧！";
            // 
            // Pic_Wechatpay
            // 
            this.Pic_Wechatpay.Image = global::o_linux_cmd.Properties.Resources.Wechatpay;
            this.Pic_Wechatpay.Location = new System.Drawing.Point(267, 81);
            this.Pic_Wechatpay.Name = "Pic_Wechatpay";
            this.Pic_Wechatpay.Size = new System.Drawing.Size(200, 200);
            this.Pic_Wechatpay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Wechatpay.TabIndex = 2;
            this.Pic_Wechatpay.TabStop = false;
            // 
            // Pic_Alipay
            // 
            this.Pic_Alipay.Image = global::o_linux_cmd.Properties.Resources.Alipay;
            this.Pic_Alipay.Location = new System.Drawing.Point(33, 81);
            this.Pic_Alipay.Name = "Pic_Alipay";
            this.Pic_Alipay.Size = new System.Drawing.Size(200, 200);
            this.Pic_Alipay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Alipay.TabIndex = 1;
            this.Pic_Alipay.TabStop = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.Panel_Header;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.Lab_Header;
            // 
            // Donate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(500, 323);
            this.Controls.Add(this.Lab_Talk);
            this.Controls.Add(this.Lab_Wechatpay);
            this.Controls.Add(this.Lab_Alipay);
            this.Controls.Add(this.Pic_Wechatpay);
            this.Controls.Add(this.Pic_Alipay);
            this.Controls.Add(this.Panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Donate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Donate";
            this.Load += new System.EventHandler(this.Donate_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Wechatpay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Alipay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.PictureBox Pic_Close;
        private System.Windows.Forms.PictureBox Pic_Icon;
        private System.Windows.Forms.Label Lab_Header;
        private System.Windows.Forms.PictureBox Pic_Alipay;
        private System.Windows.Forms.PictureBox Pic_Wechatpay;
        private System.Windows.Forms.Label Lab_Alipay;
        private System.Windows.Forms.Label Lab_Wechatpay;
        private System.Windows.Forms.Label Lab_Talk;
        private DragControl dragControl1;
        private DragControl dragControl2;
    }
}