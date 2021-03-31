namespace o_linux_cmd
{
    partial class Check_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_Update));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Lab_Header = new System.Windows.Forms.Label();
            this.Pic_Icon = new System.Windows.Forms.PictureBox();
            this.Pic_Close = new System.Windows.Forms.PictureBox();
            this.Lab_Tips = new System.Windows.Forms.Label();
            this.Btn_GotoUpdate = new System.Windows.Forms.Button();
            this.Btn_Skip = new System.Windows.Forms.Button();
            this.dragControl1 = new o_linux_cmd.DragControl();
            this.dragControl2 = new o_linux_cmd.DragControl();
            this.Lab_LatestVersion = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Close)).BeginInit();
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
            this.Panel_Header.Size = new System.Drawing.Size(417, 35);
            this.Panel_Header.TabIndex = 0;
            // 
            // Lab_Header
            // 
            this.Lab_Header.AutoSize = true;
            this.Lab_Header.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Header.ForeColor = System.Drawing.Color.White;
            this.Lab_Header.Location = new System.Drawing.Point(164, 4);
            this.Lab_Header.Name = "Lab_Header";
            this.Lab_Header.Size = new System.Drawing.Size(88, 26);
            this.Lab_Header.TabIndex = 11;
            this.Lab_Header.Text = "更新提示";
            // 
            // Pic_Icon
            // 
            this.Pic_Icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pic_Icon.Image = global::o_linux_cmd.Properties.Resources.Update_96px;
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
            this.Pic_Close.Location = new System.Drawing.Point(382, 0);
            this.Pic_Close.Name = "Pic_Close";
            this.Pic_Close.Size = new System.Drawing.Size(35, 35);
            this.Pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Close.TabIndex = 9;
            this.Pic_Close.TabStop = false;
            this.Pic_Close.Click += new System.EventHandler(this.Pic_Close_Click);
            // 
            // Lab_Tips
            // 
            this.Lab_Tips.AutoSize = true;
            this.Lab_Tips.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Tips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_Tips.Location = new System.Drawing.Point(135, 52);
            this.Lab_Tips.Name = "Lab_Tips";
            this.Lab_Tips.Size = new System.Drawing.Size(172, 27);
            this.Lab_Tips.TabIndex = 14;
            this.Lab_Tips.Text = "有新版本更新啦！";
            // 
            // Btn_GotoUpdate
            // 
            this.Btn_GotoUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_GotoUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_GotoUpdate.FlatAppearance.BorderSize = 0;
            this.Btn_GotoUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GotoUpdate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GotoUpdate.ForeColor = System.Drawing.Color.White;
            this.Btn_GotoUpdate.Location = new System.Drawing.Point(36, 128);
            this.Btn_GotoUpdate.Name = "Btn_GotoUpdate";
            this.Btn_GotoUpdate.Size = new System.Drawing.Size(160, 36);
            this.Btn_GotoUpdate.TabIndex = 18;
            this.Btn_GotoUpdate.Text = "前往更新";
            this.Btn_GotoUpdate.UseVisualStyleBackColor = false;
            this.Btn_GotoUpdate.Click += new System.EventHandler(this.Btn_GotoUpdate_Click);
            // 
            // Btn_Skip
            // 
            this.Btn_Skip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Skip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Skip.FlatAppearance.BorderSize = 0;
            this.Btn_Skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Skip.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Skip.ForeColor = System.Drawing.Color.White;
            this.Btn_Skip.Location = new System.Drawing.Point(226, 128);
            this.Btn_Skip.Name = "Btn_Skip";
            this.Btn_Skip.Size = new System.Drawing.Size(160, 36);
            this.Btn_Skip.TabIndex = 19;
            this.Btn_Skip.Text = "跳过当前版本";
            this.Btn_Skip.UseVisualStyleBackColor = false;
            this.Btn_Skip.Click += new System.EventHandler(this.Btn_Skip_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.Panel_Header;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.Lab_Header;
            // 
            // Lab_LatestVersion
            // 
            this.Lab_LatestVersion.AutoSize = true;
            this.Lab_LatestVersion.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_LatestVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_LatestVersion.Location = new System.Drawing.Point(149, 90);
            this.Lab_LatestVersion.Name = "Lab_LatestVersion";
            this.Lab_LatestVersion.Size = new System.Drawing.Size(118, 19);
            this.Lab_LatestVersion.TabIndex = 20;
            this.Lab_LatestVersion.Text = "最新版本: V1.0.2";
            // 
            // Check_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(417, 180);
            this.Controls.Add(this.Lab_LatestVersion);
            this.Controls.Add(this.Btn_Skip);
            this.Controls.Add(this.Btn_GotoUpdate);
            this.Controls.Add(this.Lab_Tips);
            this.Controls.Add(this.Panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Check_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Donate";
            this.Load += new System.EventHandler(this.Update_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.PictureBox Pic_Close;
        private System.Windows.Forms.PictureBox Pic_Icon;
        private System.Windows.Forms.Label Lab_Header;
        private System.Windows.Forms.Label Lab_Tips;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private System.Windows.Forms.Button Btn_GotoUpdate;
        private System.Windows.Forms.Button Btn_Skip;
        private System.Windows.Forms.Label Lab_LatestVersion;
    }
}