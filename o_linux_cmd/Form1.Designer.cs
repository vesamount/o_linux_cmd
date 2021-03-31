namespace o_linux_cmd
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Pic_Icon = new System.Windows.Forms.PictureBox();
            this.Lab_Header = new System.Windows.Forms.Label();
            this.Pic_Min = new System.Windows.Forms.PictureBox();
            this.Pic_Close = new System.Windows.Forms.PictureBox();
            this.Pic_Max_Nor = new System.Windows.Forms.PictureBox();
            this.Panel_Search = new System.Windows.Forms.Panel();
            this.Panel_Suggest = new System.Windows.Forms.Panel();
            this.Pic_BigLogo = new System.Windows.Forms.PictureBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Text_Search = new System.Windows.Forms.TextBox();
            this.Llab_Copy_Right = new System.Windows.Forms.LinkLabel();
            this.Panel_Web = new System.Windows.Forms.Panel();
            this.WebBro = new System.Windows.Forms.WebBrowser();
            this.Panel_Separate = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oLinuxCmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Btn_About = new System.Windows.Forms.Button();
            this.Btn_Donate = new System.Windows.Forms.Button();
            this.Btn_Chat = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Set = new System.Windows.Forms.Button();
            this.Pic_Small_Logo = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.dragControl1 = new o_linux_cmd.DragControl();
            this.dragControl2 = new o_linux_cmd.DragControl();
            this.Pic_Donate = new System.Windows.Forms.PictureBox();
            this.Panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Max_Nor)).BeginInit();
            this.Panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_BigLogo)).BeginInit();
            this.Panel_Web.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.Panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Small_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Donate)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Panel_Header.Controls.Add(this.Pic_Donate);
            this.Panel_Header.Controls.Add(this.Pic_Icon);
            this.Panel_Header.Controls.Add(this.Lab_Header);
            this.Panel_Header.Controls.Add(this.Pic_Min);
            this.Panel_Header.Controls.Add(this.Pic_Close);
            this.Panel_Header.Controls.Add(this.Pic_Max_Nor);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(844, 35);
            this.Panel_Header.TabIndex = 0;
            this.Panel_Header.Click += new System.EventHandler(this.Panel_Header_Click);
            // 
            // Pic_Icon
            // 
            this.Pic_Icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Icon.Image = global::o_linux_cmd.Properties.Resources.Icon_40px;
            this.Pic_Icon.Location = new System.Drawing.Point(0, 0);
            this.Pic_Icon.Name = "Pic_Icon";
            this.Pic_Icon.Size = new System.Drawing.Size(35, 35);
            this.Pic_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Icon.TabIndex = 7;
            this.Pic_Icon.TabStop = false;
            this.Pic_Icon.Click += new System.EventHandler(this.Pic_Icon_Click);
            // 
            // Lab_Header
            // 
            this.Lab_Header.AutoSize = true;
            this.Lab_Header.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lab_Header.Location = new System.Drawing.Point(41, 6);
            this.Lab_Header.Name = "Lab_Header";
            this.Lab_Header.Size = new System.Drawing.Size(126, 23);
            this.Lab_Header.TabIndex = 9;
            this.Lab_Header.Text = "O-LinuxCmd";
            // 
            // Pic_Min
            // 
            this.Pic_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Min.Image = global::o_linux_cmd.Properties.Resources.Mini_Windows;
            this.Pic_Min.Location = new System.Drawing.Point(727, 0);
            this.Pic_Min.Name = "Pic_Min";
            this.Pic_Min.Size = new System.Drawing.Size(35, 35);
            this.Pic_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Min.TabIndex = 5;
            this.Pic_Min.TabStop = false;
            this.Pic_Min.Click += new System.EventHandler(this.Pic_Min_Click);
            // 
            // Pic_Close
            // 
            this.Pic_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Close.Image = global::o_linux_cmd.Properties.Resources.Close_Windows;
            this.Pic_Close.Location = new System.Drawing.Point(809, 0);
            this.Pic_Close.Name = "Pic_Close";
            this.Pic_Close.Size = new System.Drawing.Size(35, 35);
            this.Pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Close.TabIndex = 8;
            this.Pic_Close.TabStop = false;
            this.Pic_Close.Click += new System.EventHandler(this.Pic_Close_Click);
            // 
            // Pic_Max_Nor
            // 
            this.Pic_Max_Nor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_Max_Nor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Max_Nor.Image = global::o_linux_cmd.Properties.Resources.Max_Windows;
            this.Pic_Max_Nor.Location = new System.Drawing.Point(768, 0);
            this.Pic_Max_Nor.Name = "Pic_Max_Nor";
            this.Pic_Max_Nor.Size = new System.Drawing.Size(35, 35);
            this.Pic_Max_Nor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Max_Nor.TabIndex = 6;
            this.Pic_Max_Nor.TabStop = false;
            this.Pic_Max_Nor.Click += new System.EventHandler(this.Pic_Max_Nor_Click);
            // 
            // Panel_Search
            // 
            this.Panel_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Search.Controls.Add(this.Panel_Suggest);
            this.Panel_Search.Controls.Add(this.Pic_BigLogo);
            this.Panel_Search.Controls.Add(this.Btn_Search);
            this.Panel_Search.Controls.Add(this.Text_Search);
            this.Panel_Search.Location = new System.Drawing.Point(200, 41);
            this.Panel_Search.Name = "Panel_Search";
            this.Panel_Search.Size = new System.Drawing.Size(444, 367);
            this.Panel_Search.TabIndex = 4;
            this.Panel_Search.Click += new System.EventHandler(this.Panel_Search_Click);
            // 
            // Panel_Suggest
            // 
            this.Panel_Suggest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Suggest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Suggest.Location = new System.Drawing.Point(0, 250);
            this.Panel_Suggest.Name = "Panel_Suggest";
            this.Panel_Suggest.Size = new System.Drawing.Size(444, 0);
            this.Panel_Suggest.TabIndex = 3;
            // 
            // Pic_BigLogo
            // 
            this.Pic_BigLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_BigLogo.Image = global::o_linux_cmd.Properties.Resources.Logo;
            this.Pic_BigLogo.Location = new System.Drawing.Point(50, 4);
            this.Pic_BigLogo.Name = "Pic_BigLogo";
            this.Pic_BigLogo.Size = new System.Drawing.Size(344, 200);
            this.Pic_BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_BigLogo.TabIndex = 2;
            this.Pic_BigLogo.TabStop = false;
            this.Pic_BigLogo.Click += new System.EventHandler(this.Pic_BigLogo_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(349, 208);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(93, 36);
            this.Btn_Search.TabIndex = 0;
            this.Btn_Search.Text = "查询";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Text_Search
            // 
            this.Text_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_Search.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Search.Location = new System.Drawing.Point(2, 208);
            this.Text_Search.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.Text_Search.Name = "Text_Search";
            this.Text_Search.Size = new System.Drawing.Size(344, 36);
            this.Text_Search.TabIndex = 1;
            this.Text_Search.Click += new System.EventHandler(this.Text_Search_Click);
            this.Text_Search.TextChanged += new System.EventHandler(this.Text_Search_TextChanged);
            this.Text_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Search_KeyPress);
            // 
            // Llab_Copy_Right
            // 
            this.Llab_Copy_Right.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Llab_Copy_Right.AutoSize = true;
            this.Llab_Copy_Right.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llab_Copy_Right.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Llab_Copy_Right.Location = new System.Drawing.Point(316, 411);
            this.Llab_Copy_Right.Name = "Llab_Copy_Right";
            this.Llab_Copy_Right.Size = new System.Drawing.Size(206, 16);
            this.Llab_Copy_Right.TabIndex = 12;
            this.Llab_Copy_Right.TabStop = true;
            this.Llab_Copy_Right.Text = "©2018  Gustav.  All rights reserved.";
            this.Llab_Copy_Right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Llab_Copy_Right.VisitedLinkColor = System.Drawing.Color.Blue;
            this.Llab_Copy_Right.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llab_Copy_Right_LinkClicked);
            // 
            // Panel_Web
            // 
            this.Panel_Web.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Web.Controls.Add(this.WebBro);
            this.Panel_Web.Controls.Add(this.Panel_Separate);
            this.Panel_Web.Location = new System.Drawing.Point(0, 87);
            this.Panel_Web.Name = "Panel_Web";
            this.Panel_Web.Size = new System.Drawing.Size(844, 401);
            this.Panel_Web.TabIndex = 13;
            this.Panel_Web.Visible = false;
            this.Panel_Web.Click += new System.EventHandler(this.Panel_Web_Click);
            // 
            // WebBro
            // 
            this.WebBro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBro.Location = new System.Drawing.Point(0, 1);
            this.WebBro.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBro.Name = "WebBro";
            this.WebBro.Size = new System.Drawing.Size(844, 400);
            this.WebBro.TabIndex = 0;
            this.WebBro.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBro_DocumentCompleted);
            // 
            // Panel_Separate
            // 
            this.Panel_Separate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Panel_Separate.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Separate.Location = new System.Drawing.Point(0, 0);
            this.Panel_Separate.Name = "Panel_Separate";
            this.Panel_Separate.Size = new System.Drawing.Size(844, 1);
            this.Panel_Separate.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "O-LinuxCmd";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oLinuxCmdToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 70);
            // 
            // oLinuxCmdToolStripMenuItem
            // 
            this.oLinuxCmdToolStripMenuItem.Image = global::o_linux_cmd.Properties.Resources.icon;
            this.oLinuxCmdToolStripMenuItem.Name = "oLinuxCmdToolStripMenuItem";
            this.oLinuxCmdToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.oLinuxCmdToolStripMenuItem.Text = "O-LinuxCmd";
            this.oLinuxCmdToolStripMenuItem.Click += new System.EventHandler(this.oLinuxCmdToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Image = global::o_linux_cmd.Properties.Resources.About_20px;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = global::o_linux_cmd.Properties.Resources.Exit_20px;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackgroundImage = global::o_linux_cmd.Properties.Resources.Menu;
            this.Panel_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Menu.Controls.Add(this.Btn_About);
            this.Panel_Menu.Controls.Add(this.Btn_Donate);
            this.Panel_Menu.Controls.Add(this.Btn_Chat);
            this.Panel_Menu.Controls.Add(this.Btn_Update);
            this.Panel_Menu.Controls.Add(this.Btn_Set);
            this.Panel_Menu.Location = new System.Drawing.Point(15, 39);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(129, 166);
            this.Panel_Menu.TabIndex = 10;
            this.Panel_Menu.Visible = false;
            // 
            // Btn_About
            // 
            this.Btn_About.FlatAppearance.BorderSize = 0;
            this.Btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_About.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_About.Image = global::o_linux_cmd.Properties.Resources.About_20px;
            this.Btn_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_About.Location = new System.Drawing.Point(10, 130);
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.Size = new System.Drawing.Size(106, 23);
            this.Btn_About.TabIndex = 7;
            this.Btn_About.Text = "关于我们";
            this.Btn_About.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_About.UseVisualStyleBackColor = true;
            this.Btn_About.Click += new System.EventHandler(this.Btn_About_Click);
            // 
            // Btn_Donate
            // 
            this.Btn_Donate.FlatAppearance.BorderSize = 0;
            this.Btn_Donate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Donate.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Donate.Image = global::o_linux_cmd.Properties.Resources.Donate_20px;
            this.Btn_Donate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Donate.Location = new System.Drawing.Point(10, 100);
            this.Btn_Donate.Name = "Btn_Donate";
            this.Btn_Donate.Size = new System.Drawing.Size(106, 23);
            this.Btn_Donate.TabIndex = 6;
            this.Btn_Donate.Text = "捐赠我们";
            this.Btn_Donate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Donate.UseVisualStyleBackColor = true;
            this.Btn_Donate.Click += new System.EventHandler(this.Btn_Donate_Click);
            // 
            // Btn_Chat
            // 
            this.Btn_Chat.FlatAppearance.BorderSize = 0;
            this.Btn_Chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Chat.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Chat.Image = global::o_linux_cmd.Properties.Resources.Chat_20px;
            this.Btn_Chat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Chat.Location = new System.Drawing.Point(10, 70);
            this.Btn_Chat.Name = "Btn_Chat";
            this.Btn_Chat.Size = new System.Drawing.Size(106, 23);
            this.Btn_Chat.TabIndex = 5;
            this.Btn_Chat.Text = "交流反馈";
            this.Btn_Chat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Chat.UseVisualStyleBackColor = true;
            this.Btn_Chat.Click += new System.EventHandler(this.Btn_Chat_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Image = global::o_linux_cmd.Properties.Resources.Update_20px;
            this.Btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Update.Location = new System.Drawing.Point(10, 40);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(106, 23);
            this.Btn_Update.TabIndex = 4;
            this.Btn_Update.Text = "检查更新";
            this.Btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Set
            // 
            this.Btn_Set.FlatAppearance.BorderSize = 0;
            this.Btn_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Set.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Set.Image = global::o_linux_cmd.Properties.Resources.Set_20px;
            this.Btn_Set.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Set.Location = new System.Drawing.Point(10, 10);
            this.Btn_Set.Name = "Btn_Set";
            this.Btn_Set.Size = new System.Drawing.Size(106, 23);
            this.Btn_Set.TabIndex = 3;
            this.Btn_Set.Text = "软件设置";
            this.Btn_Set.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Set.UseVisualStyleBackColor = true;
            this.Btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // Pic_Small_Logo
            // 
            this.Pic_Small_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Small_Logo.Image = global::o_linux_cmd.Properties.Resources.Logo;
            this.Pic_Small_Logo.Location = new System.Drawing.Point(152, 40);
            this.Pic_Small_Logo.Name = "Pic_Small_Logo";
            this.Pic_Small_Logo.Size = new System.Drawing.Size(45, 45);
            this.Pic_Small_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Small_Logo.TabIndex = 9;
            this.Pic_Small_Logo.TabStop = false;
            this.Pic_Small_Logo.Visible = false;
            this.Pic_Small_Logo.Click += new System.EventHandler(this.Pic_Small_Logo_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.Panel_Header;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.Lab_Header;
            // 
            // Pic_Donate
            // 
            this.Pic_Donate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_Donate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Donate.Image = global::o_linux_cmd.Properties.Resources.Donate_96px;
            this.Pic_Donate.Location = new System.Drawing.Point(686, 0);
            this.Pic_Donate.Name = "Pic_Donate";
            this.Pic_Donate.Size = new System.Drawing.Size(35, 35);
            this.Pic_Donate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Donate.TabIndex = 10;
            this.Pic_Donate.TabStop = false;
            this.Pic_Donate.Click += new System.EventHandler(this.Pic_Donate_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 500);
            this.Controls.Add(this.Panel_Menu);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_Search);
            this.Controls.Add(this.Llab_Copy_Right);
            this.Controls.Add(this.Pic_Small_Logo);
            this.Controls.Add(this.Panel_Web);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(844, 500);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "O-LinuxCmd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Click += new System.EventHandler(this.Main_Form_Click);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Max_Nor)).EndInit();
            this.Panel_Search.ResumeLayout(false);
            this.Panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_BigLogo)).EndInit();
            this.Panel_Web.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Small_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Donate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.PictureBox Pic_Icon;
        private System.Windows.Forms.Label Lab_Header;
        private System.Windows.Forms.PictureBox Pic_Min;
        private System.Windows.Forms.PictureBox Pic_Close;
        private System.Windows.Forms.PictureBox Pic_Max_Nor;
        private System.Windows.Forms.Panel Panel_Search;
        private System.Windows.Forms.PictureBox Pic_BigLogo;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Text_Search;
        private System.Windows.Forms.PictureBox Pic_Small_Logo;
        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Button Btn_About;
        private System.Windows.Forms.Button Btn_Donate;
        private System.Windows.Forms.Button Btn_Chat;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Set;
        private System.Windows.Forms.LinkLabel Llab_Copy_Right;
        private System.Windows.Forms.Panel Panel_Web;
        private System.Windows.Forms.WebBrowser WebBro;
        private DragControl dragControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Panel_Separate;
        private System.Windows.Forms.Panel Panel_Suggest;
        private System.Windows.Forms.Timer timer2;
        private DragControl dragControl2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oLinuxCmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox Pic_Donate;
    }
}

