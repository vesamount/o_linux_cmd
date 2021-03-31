namespace o_linux_cmd
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Lab_Header = new System.Windows.Forms.Label();
            this.Pic_Icon = new System.Windows.Forms.PictureBox();
            this.Pic_Close = new System.Windows.Forms.PictureBox();
            this.dragControl1 = new o_linux_cmd.DragControl();
            this.dragControl2 = new o_linux_cmd.DragControl();
            this.Grp_Basic = new System.Windows.Forms.GroupBox();
            this.Chk_CloseTray = new System.Windows.Forms.CheckBox();
            this.Chk_MinTray = new System.Windows.Forms.CheckBox();
            this.Chk_AutoStart = new System.Windows.Forms.CheckBox();
            this.Grp_Update = new System.Windows.Forms.GroupBox();
            this.Lab_LastTime = new System.Windows.Forms.Label();
            this.Lab_LastCheck = new System.Windows.Forms.Label();
            this.Llab_Home = new System.Windows.Forms.LinkLabel();
            this.Lab_VisitHome = new System.Windows.Forms.Label();
            this.Rad_Never = new System.Windows.Forms.RadioButton();
            this.Rad_Month = new System.Windows.Forms.RadioButton();
            this.Rad_Week = new System.Windows.Forms.RadioButton();
            this.Lab_Cycle = new System.Windows.Forms.Label();
            this.Rad_Day = new System.Windows.Forms.RadioButton();
            this.Btn_GotoUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Close)).BeginInit();
            this.Grp_Basic.SuspendLayout();
            this.Grp_Update.SuspendLayout();
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
            this.Lab_Header.Text = "软件设置";
            // 
            // Pic_Icon
            // 
            this.Pic_Icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pic_Icon.Image = global::o_linux_cmd.Properties.Resources.Set_96px;
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
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.Panel_Header;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.Lab_Header;
            // 
            // Grp_Basic
            // 
            this.Grp_Basic.Controls.Add(this.Chk_CloseTray);
            this.Grp_Basic.Controls.Add(this.Chk_MinTray);
            this.Grp_Basic.Controls.Add(this.Chk_AutoStart);
            this.Grp_Basic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grp_Basic.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Grp_Basic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Grp_Basic.Location = new System.Drawing.Point(41, 36);
            this.Grp_Basic.Name = "Grp_Basic";
            this.Grp_Basic.Size = new System.Drawing.Size(419, 110);
            this.Grp_Basic.TabIndex = 15;
            this.Grp_Basic.TabStop = false;
            this.Grp_Basic.Text = "基本";
            // 
            // Chk_CloseTray
            // 
            this.Chk_CloseTray.AutoSize = true;
            this.Chk_CloseTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chk_CloseTray.Location = new System.Drawing.Point(18, 78);
            this.Chk_CloseTray.Name = "Chk_CloseTray";
            this.Chk_CloseTray.Size = new System.Drawing.Size(106, 25);
            this.Chk_CloseTray.TabIndex = 2;
            this.Chk_CloseTray.Text = "关闭至托盘";
            this.Chk_CloseTray.UseVisualStyleBackColor = true;
            this.Chk_CloseTray.CheckedChanged += new System.EventHandler(this.Chk_CloseTray_CheckedChanged);
            // 
            // Chk_MinTray
            // 
            this.Chk_MinTray.AutoSize = true;
            this.Chk_MinTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chk_MinTray.Location = new System.Drawing.Point(18, 49);
            this.Chk_MinTray.Name = "Chk_MinTray";
            this.Chk_MinTray.Size = new System.Drawing.Size(122, 25);
            this.Chk_MinTray.TabIndex = 1;
            this.Chk_MinTray.Text = "最小化至托盘";
            this.Chk_MinTray.UseVisualStyleBackColor = true;
            this.Chk_MinTray.CheckedChanged += new System.EventHandler(this.Chk_MinTray_CheckedChanged);
            // 
            // Chk_AutoStart
            // 
            this.Chk_AutoStart.AutoSize = true;
            this.Chk_AutoStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chk_AutoStart.Location = new System.Drawing.Point(18, 20);
            this.Chk_AutoStart.Name = "Chk_AutoStart";
            this.Chk_AutoStart.Size = new System.Drawing.Size(106, 25);
            this.Chk_AutoStart.TabIndex = 0;
            this.Chk_AutoStart.Text = "开机自启动";
            this.Chk_AutoStart.UseVisualStyleBackColor = true;
            this.Chk_AutoStart.CheckedChanged += new System.EventHandler(this.Chk_AutoStart_CheckedChanged);
            // 
            // Grp_Update
            // 
            this.Grp_Update.Controls.Add(this.Lab_LastTime);
            this.Grp_Update.Controls.Add(this.Lab_LastCheck);
            this.Grp_Update.Controls.Add(this.Llab_Home);
            this.Grp_Update.Controls.Add(this.Lab_VisitHome);
            this.Grp_Update.Controls.Add(this.Rad_Never);
            this.Grp_Update.Controls.Add(this.Rad_Month);
            this.Grp_Update.Controls.Add(this.Rad_Week);
            this.Grp_Update.Controls.Add(this.Lab_Cycle);
            this.Grp_Update.Controls.Add(this.Rad_Day);
            this.Grp_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grp_Update.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Grp_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Grp_Update.Location = new System.Drawing.Point(41, 150);
            this.Grp_Update.Name = "Grp_Update";
            this.Grp_Update.Size = new System.Drawing.Size(419, 110);
            this.Grp_Update.TabIndex = 16;
            this.Grp_Update.TabStop = false;
            this.Grp_Update.Text = "更新";
            // 
            // Lab_LastTime
            // 
            this.Lab_LastTime.AutoSize = true;
            this.Lab_LastTime.Location = new System.Drawing.Point(115, 49);
            this.Lab_LastTime.Name = "Lab_LastTime";
            this.Lab_LastTime.Size = new System.Drawing.Size(163, 21);
            this.Lab_LastTime.TabIndex = 11;
            this.Lab_LastTime.Text = "2018-10-08 15:54:36";
            // 
            // Lab_LastCheck
            // 
            this.Lab_LastCheck.AutoSize = true;
            this.Lab_LastCheck.Location = new System.Drawing.Point(14, 49);
            this.Lab_LastCheck.Name = "Lab_LastCheck";
            this.Lab_LastCheck.Size = new System.Drawing.Size(90, 21);
            this.Lab_LastCheck.TabIndex = 10;
            this.Lab_LastCheck.Text = "上次检查：";
            // 
            // Llab_Home
            // 
            this.Llab_Home.AutoSize = true;
            this.Llab_Home.Location = new System.Drawing.Point(115, 78);
            this.Llab_Home.Name = "Llab_Home";
            this.Llab_Home.Size = new System.Drawing.Size(154, 21);
            this.Llab_Home.TabIndex = 9;
            this.Llab_Home.TabStop = true;
            this.Llab_Home.Text = "www.ifreehub.com";
            this.Llab_Home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llab_Home_LinkClicked);
            // 
            // Lab_VisitHome
            // 
            this.Lab_VisitHome.AutoSize = true;
            this.Lab_VisitHome.Location = new System.Drawing.Point(14, 78);
            this.Lab_VisitHome.Name = "Lab_VisitHome";
            this.Lab_VisitHome.Size = new System.Drawing.Size(90, 21);
            this.Lab_VisitHome.TabIndex = 8;
            this.Lab_VisitHome.Text = "访问主页：";
            // 
            // Rad_Never
            // 
            this.Rad_Never.AutoSize = true;
            this.Rad_Never.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rad_Never.Location = new System.Drawing.Point(310, 18);
            this.Rad_Never.Name = "Rad_Never";
            this.Rad_Never.Size = new System.Drawing.Size(59, 25);
            this.Rad_Never.TabIndex = 7;
            this.Rad_Never.Text = "从不";
            this.Rad_Never.UseVisualStyleBackColor = true;
            this.Rad_Never.CheckedChanged += new System.EventHandler(this.Rad_Never_CheckedChanged);
            // 
            // Rad_Month
            // 
            this.Rad_Month.AutoSize = true;
            this.Rad_Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rad_Month.Location = new System.Drawing.Point(245, 18);
            this.Rad_Month.Name = "Rad_Month";
            this.Rad_Month.Size = new System.Drawing.Size(59, 25);
            this.Rad_Month.TabIndex = 6;
            this.Rad_Month.Text = "每月";
            this.Rad_Month.UseVisualStyleBackColor = true;
            this.Rad_Month.CheckedChanged += new System.EventHandler(this.Rad_Month_CheckedChanged);
            // 
            // Rad_Week
            // 
            this.Rad_Week.AutoSize = true;
            this.Rad_Week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rad_Week.Location = new System.Drawing.Point(180, 18);
            this.Rad_Week.Name = "Rad_Week";
            this.Rad_Week.Size = new System.Drawing.Size(59, 25);
            this.Rad_Week.TabIndex = 5;
            this.Rad_Week.Text = "每周";
            this.Rad_Week.UseVisualStyleBackColor = true;
            this.Rad_Week.CheckedChanged += new System.EventHandler(this.Rad_Week_CheckedChanged);
            // 
            // Lab_Cycle
            // 
            this.Lab_Cycle.AutoSize = true;
            this.Lab_Cycle.Location = new System.Drawing.Point(14, 20);
            this.Lab_Cycle.Name = "Lab_Cycle";
            this.Lab_Cycle.Size = new System.Drawing.Size(90, 21);
            this.Lab_Cycle.TabIndex = 4;
            this.Lab_Cycle.Text = "检查周期：";
            // 
            // Rad_Day
            // 
            this.Rad_Day.AutoSize = true;
            this.Rad_Day.Checked = true;
            this.Rad_Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rad_Day.Location = new System.Drawing.Point(115, 18);
            this.Rad_Day.Name = "Rad_Day";
            this.Rad_Day.Size = new System.Drawing.Size(59, 25);
            this.Rad_Day.TabIndex = 3;
            this.Rad_Day.TabStop = true;
            this.Rad_Day.Text = "每天";
            this.Rad_Day.UseVisualStyleBackColor = true;
            this.Rad_Day.CheckedChanged += new System.EventHandler(this.Rad_Day_CheckedChanged);
            // 
            // Btn_GotoUpdate
            // 
            this.Btn_GotoUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_GotoUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_GotoUpdate.Enabled = false;
            this.Btn_GotoUpdate.FlatAppearance.BorderSize = 0;
            this.Btn_GotoUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GotoUpdate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GotoUpdate.ForeColor = System.Drawing.Color.White;
            this.Btn_GotoUpdate.Location = new System.Drawing.Point(254, 271);
            this.Btn_GotoUpdate.Name = "Btn_GotoUpdate";
            this.Btn_GotoUpdate.Size = new System.Drawing.Size(100, 36);
            this.Btn_GotoUpdate.TabIndex = 19;
            this.Btn_GotoUpdate.Text = "应用";
            this.Btn_GotoUpdate.UseVisualStyleBackColor = false;
            this.Btn_GotoUpdate.Click += new System.EventHandler(this.Btn_GotoUpdate_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(360, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(500, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_GotoUpdate);
            this.Controls.Add(this.Grp_Update);
            this.Controls.Add(this.Grp_Basic);
            this.Controls.Add(this.Panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Donate";
            this.Load += new System.EventHandler(this.Option_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Close)).EndInit();
            this.Grp_Basic.ResumeLayout(false);
            this.Grp_Basic.PerformLayout();
            this.Grp_Update.ResumeLayout(false);
            this.Grp_Update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.PictureBox Pic_Close;
        private System.Windows.Forms.PictureBox Pic_Icon;
        private System.Windows.Forms.Label Lab_Header;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private System.Windows.Forms.GroupBox Grp_Basic;
        private System.Windows.Forms.CheckBox Chk_CloseTray;
        private System.Windows.Forms.CheckBox Chk_MinTray;
        private System.Windows.Forms.CheckBox Chk_AutoStart;
        private System.Windows.Forms.GroupBox Grp_Update;
        private System.Windows.Forms.RadioButton Rad_Never;
        private System.Windows.Forms.RadioButton Rad_Month;
        private System.Windows.Forms.RadioButton Rad_Week;
        private System.Windows.Forms.Label Lab_Cycle;
        private System.Windows.Forms.RadioButton Rad_Day;
        private System.Windows.Forms.LinkLabel Llab_Home;
        private System.Windows.Forms.Label Lab_VisitHome;
        private System.Windows.Forms.Label Lab_LastTime;
        private System.Windows.Forms.Label Lab_LastCheck;
        private System.Windows.Forms.Button Btn_GotoUpdate;
        private System.Windows.Forms.Button button1;
    }
}