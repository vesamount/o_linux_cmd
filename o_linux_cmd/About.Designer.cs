namespace o_linux_cmd
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Lab_Header = new System.Windows.Forms.Label();
            this.Pic_Icon = new System.Windows.Forms.PictureBox();
            this.Pic_Close = new System.Windows.Forms.PictureBox();
            this.Lab_AppName = new System.Windows.Forms.Label();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            this.dragControl1 = new o_linux_cmd.DragControl();
            this.dragControl2 = new o_linux_cmd.DragControl();
            this.Lab_Version = new System.Windows.Forms.Label();
            this.Lab_Author = new System.Windows.Forms.Label();
            this.Lab_Contact = new System.Windows.Forms.Label();
            this.Lab_Thanks = new System.Windows.Forms.Label();
            this.Llab_Proj1 = new System.Windows.Forms.LinkLabel();
            this.Llab_Proj2 = new System.Windows.Forms.LinkLabel();
            this.Llab_Proj3 = new System.Windows.Forms.LinkLabel();
            this.Llab_Proj0 = new System.Windows.Forms.LinkLabel();
            this.Panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
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
            this.Lab_Header.Location = new System.Drawing.Point(206, 4);
            this.Lab_Header.Name = "Lab_Header";
            this.Lab_Header.Size = new System.Drawing.Size(88, 26);
            this.Lab_Header.TabIndex = 11;
            this.Lab_Header.Text = "关于我们";
            // 
            // Pic_Icon
            // 
            this.Pic_Icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pic_Icon.Image = global::o_linux_cmd.Properties.Resources.About_96px;
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
            // Lab_AppName
            // 
            this.Lab_AppName.AutoSize = true;
            this.Lab_AppName.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_AppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_AppName.Location = new System.Drawing.Point(166, 49);
            this.Lab_AppName.Name = "Lab_AppName";
            this.Lab_AppName.Size = new System.Drawing.Size(316, 56);
            this.Lab_AppName.TabIndex = 14;
            this.Lab_AppName.Text = "O-LinuxCmd";
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.Image = global::o_linux_cmd.Properties.Resources.icon;
            this.Pic_Logo.Location = new System.Drawing.Point(45, 45);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(111, 96);
            this.Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Logo.TabIndex = 1;
            this.Pic_Logo.TabStop = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.Panel_Header;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.Lab_Header;
            // 
            // Lab_Version
            // 
            this.Lab_Version.AutoSize = true;
            this.Lab_Version.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_Version.Location = new System.Drawing.Point(166, 113);
            this.Lab_Version.Name = "Lab_Version";
            this.Lab_Version.Size = new System.Drawing.Size(58, 22);
            this.Lab_Version.TabIndex = 15;
            this.Lab_Version.Text = "版本：";
            // 
            // Lab_Author
            // 
            this.Lab_Author.AutoSize = true;
            this.Lab_Author.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_Author.Location = new System.Drawing.Point(166, 139);
            this.Lab_Author.Name = "Lab_Author";
            this.Lab_Author.Size = new System.Drawing.Size(141, 22);
            this.Lab_Author.TabIndex = 16;
            this.Lab_Author.Text = "作者：Gustav Ou";
            // 
            // Lab_Contact
            // 
            this.Lab_Contact.AutoSize = true;
            this.Lab_Contact.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_Contact.Location = new System.Drawing.Point(166, 165);
            this.Lab_Contact.Name = "Lab_Contact";
            this.Lab_Contact.Size = new System.Drawing.Size(248, 22);
            this.Lab_Contact.TabIndex = 17;
            this.Lab_Contact.Text = "联系：chinafjnpoqc@163.com";
            // 
            // Lab_Thanks
            // 
            this.Lab_Thanks.AutoSize = true;
            this.Lab_Thanks.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Thanks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_Thanks.Location = new System.Drawing.Point(213, 199);
            this.Lab_Thanks.Name = "Lab_Thanks";
            this.Lab_Thanks.Size = new System.Drawing.Size(74, 22);
            this.Lab_Thanks.TabIndex = 18;
            this.Lab_Thanks.Text = "特别感谢";
            // 
            // Llab_Proj1
            // 
            this.Llab_Proj1.AutoSize = true;
            this.Llab_Proj1.Location = new System.Drawing.Point(140, 247);
            this.Llab_Proj1.Name = "Llab_Proj1";
            this.Llab_Proj1.Size = new System.Drawing.Size(221, 12);
            this.Llab_Proj1.TabIndex = 19;
            this.Llab_Proj1.TabStop = true;
            this.Llab_Proj1.Text = "Linu-Command : Linux命令数据采集项目";
            this.Llab_Proj1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llab_Proj1_LinkClicked);
            this.Llab_Proj1.Click += new System.EventHandler(this.Llab_Proj1_Click);
            // 
            // Llab_Proj2
            // 
            this.Llab_Proj2.AutoSize = true;
            this.Llab_Proj2.Location = new System.Drawing.Point(170, 268);
            this.Llab_Proj2.Name = "Llab_Proj2";
            this.Llab_Proj2.Size = new System.Drawing.Size(161, 12);
            this.Llab_Proj2.TabIndex = 20;
            this.Llab_Proj2.TabStop = true;
            this.Llab_Proj2.Text = "Markdig : markdown解析项目";
            this.Llab_Proj2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llab_Proj2_LinkClicked);
            // 
            // Llab_Proj3
            // 
            this.Llab_Proj3.AutoSize = true;
            this.Llab_Proj3.Location = new System.Drawing.Point(122, 289);
            this.Llab_Proj3.Name = "Llab_Proj3";
            this.Llab_Proj3.Size = new System.Drawing.Size(257, 12);
            this.Llab_Proj3.TabIndex = 21;
            this.Llab_Proj3.TabStop = true;
            this.Llab_Proj3.Text = "Newtonsoft.Json : json序列化、反序列化项目";
            this.Llab_Proj3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llab_Proj3_LinkClicked);
            // 
            // Llab_Proj0
            // 
            this.Llab_Proj0.AutoSize = true;
            this.Llab_Proj0.Location = new System.Drawing.Point(137, 226);
            this.Llab_Proj0.Name = "Llab_Proj0";
            this.Llab_Proj0.Size = new System.Drawing.Size(227, 12);
            this.Llab_Proj0.TabIndex = 22;
            this.Llab_Proj0.TabStop = true;
            this.Llab_Proj0.Text = "man.linuxde.net : Linux命令主要数据源";
            this.Llab_Proj0.VisitedLinkColor = System.Drawing.Color.Blue;
            this.Llab_Proj0.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llab_Proj0_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(500, 323);
            this.Controls.Add(this.Llab_Proj0);
            this.Controls.Add(this.Llab_Proj3);
            this.Controls.Add(this.Llab_Proj2);
            this.Controls.Add(this.Llab_Proj1);
            this.Controls.Add(this.Lab_Thanks);
            this.Controls.Add(this.Lab_Contact);
            this.Controls.Add(this.Lab_Author);
            this.Controls.Add(this.Lab_Version);
            this.Controls.Add(this.Lab_AppName);
            this.Controls.Add(this.Pic_Logo);
            this.Controls.Add(this.Panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Donate";
            this.Load += new System.EventHandler(this.About_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.PictureBox Pic_Close;
        private System.Windows.Forms.PictureBox Pic_Icon;
        private System.Windows.Forms.Label Lab_Header;
        private System.Windows.Forms.PictureBox Pic_Logo;
        private System.Windows.Forms.Label Lab_AppName;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private System.Windows.Forms.Label Lab_Version;
        private System.Windows.Forms.Label Lab_Author;
        private System.Windows.Forms.Label Lab_Contact;
        private System.Windows.Forms.Label Lab_Thanks;
        private System.Windows.Forms.LinkLabel Llab_Proj1;
        private System.Windows.Forms.LinkLabel Llab_Proj2;
        private System.Windows.Forms.LinkLabel Llab_Proj3;
        private System.Windows.Forms.LinkLabel Llab_Proj0;
    }
}