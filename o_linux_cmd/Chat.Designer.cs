namespace o_linux_cmd
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Lab_Header = new System.Windows.Forms.Label();
            this.Pic_Icon = new System.Windows.Forms.PictureBox();
            this.Pic_Close = new System.Windows.Forms.PictureBox();
            this.Lab_Name = new System.Windows.Forms.Label();
            this.Lab_Mail = new System.Windows.Forms.Label();
            this.Lab_Talk = new System.Windows.Forms.Label();
            this.dragControl1 = new o_linux_cmd.DragControl();
            this.dragControl2 = new o_linux_cmd.DragControl();
            this.Text_Data = new System.Windows.Forms.TextBox();
            this.Text_Name = new System.Windows.Forms.TextBox();
            this.Text_Mail = new System.Windows.Forms.TextBox();
            this.Text_Code = new System.Windows.Forms.TextBox();
            this.Lab_Code = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
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
            this.Lab_Header.Text = "交流反馈";
            // 
            // Pic_Icon
            // 
            this.Pic_Icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pic_Icon.Image = global::o_linux_cmd.Properties.Resources.Chat_96px;
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
            // Lab_Name
            // 
            this.Lab_Name.AutoSize = true;
            this.Lab_Name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_Name.Location = new System.Drawing.Point(7, 238);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(46, 21);
            this.Lab_Name.TabIndex = 12;
            this.Lab_Name.Text = "昵称:";
            // 
            // Lab_Mail
            // 
            this.Lab_Mail.AutoSize = true;
            this.Lab_Mail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_Mail.Location = new System.Drawing.Point(119, 238);
            this.Lab_Mail.Name = "Lab_Mail";
            this.Lab_Mail.Size = new System.Drawing.Size(46, 21);
            this.Lab_Mail.TabIndex = 13;
            this.Lab_Mail.Text = "邮箱:";
            // 
            // Lab_Talk
            // 
            this.Lab_Talk.AutoSize = true;
            this.Lab_Talk.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Talk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Lab_Talk.Location = new System.Drawing.Point(9, 45);
            this.Lab_Talk.Name = "Lab_Talk";
            this.Lab_Talk.Size = new System.Drawing.Size(461, 22);
            this.Lab_Talk.TabIndex = 14;
            this.Lab_Talk.Text = "有什么BUG和建议尽管反馈，我反正是不会改的啦，哈哈哈哈！";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.Panel_Header;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.Lab_Header;
            // 
            // Text_Data
            // 
            this.Text_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Data.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_Data.Location = new System.Drawing.Point(9, 76);
            this.Text_Data.Multiline = true;
            this.Text_Data.Name = "Text_Data";
            this.Text_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_Data.Size = new System.Drawing.Size(483, 154);
            this.Text_Data.TabIndex = 15;
            // 
            // Text_Name
            // 
            this.Text_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_Name.Location = new System.Drawing.Point(55, 237);
            this.Text_Name.MaxLength = 20;
            this.Text_Name.Name = "Text_Name";
            this.Text_Name.Size = new System.Drawing.Size(56, 23);
            this.Text_Name.TabIndex = 16;
            // 
            // Text_Mail
            // 
            this.Text_Mail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_Mail.Location = new System.Drawing.Point(166, 237);
            this.Text_Mail.MaxLength = 50;
            this.Text_Mail.Name = "Text_Mail";
            this.Text_Mail.Size = new System.Drawing.Size(130, 23);
            this.Text_Mail.TabIndex = 17;
            // 
            // Text_Code
            // 
            this.Text_Code.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Code.Location = new System.Drawing.Point(361, 237);
            this.Text_Code.MaxLength = 4;
            this.Text_Code.Name = "Text_Code";
            this.Text_Code.Size = new System.Drawing.Size(62, 22);
            this.Text_Code.TabIndex = 18;
            // 
            // Lab_Code
            // 
            this.Lab_Code.AutoSize = true;
            this.Lab_Code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lab_Code.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lab_Code.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Code.ForeColor = System.Drawing.Color.OldLace;
            this.Lab_Code.Image = global::o_linux_cmd.Properties.Resources.Code_Back;
            this.Lab_Code.Location = new System.Drawing.Point(310, 238);
            this.Lab_Code.Name = "Lab_Code";
            this.Lab_Code.Size = new System.Drawing.Size(46, 21);
            this.Lab_Code.TabIndex = 21;
            this.Lab_Code.Text = "1234";
            this.Lab_Code.Click += new System.EventHandler(this.Lab_Code_Click);
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Submit.FlatAppearance.BorderSize = 0;
            this.Btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Submit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Submit.ForeColor = System.Drawing.Color.White;
            this.Btn_Submit.Location = new System.Drawing.Point(429, 235);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(60, 27);
            this.Btn_Submit.TabIndex = 22;
            this.Btn_Submit.Text = "提交";
            this.Btn_Submit.UseVisualStyleBackColor = false;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(500, 266);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Lab_Code);
            this.Controls.Add(this.Text_Code);
            this.Controls.Add(this.Text_Mail);
            this.Controls.Add(this.Text_Name);
            this.Controls.Add(this.Text_Data);
            this.Controls.Add(this.Lab_Talk);
            this.Controls.Add(this.Lab_Mail);
            this.Controls.Add(this.Lab_Name);
            this.Controls.Add(this.Panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Donate";
            this.Load += new System.EventHandler(this.Chat_Load);
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
        private System.Windows.Forms.Label Lab_Name;
        private System.Windows.Forms.Label Lab_Mail;
        private System.Windows.Forms.Label Lab_Talk;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private System.Windows.Forms.TextBox Text_Data;
        private System.Windows.Forms.TextBox Text_Name;
        private System.Windows.Forms.TextBox Text_Mail;
        private System.Windows.Forms.TextBox Text_Code;
        private System.Windows.Forms.Label Lab_Code;
        private System.Windows.Forms.Button Btn_Submit;
    }
}