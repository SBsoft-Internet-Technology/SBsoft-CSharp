namespace NoteChat_Client
{
    partial class StartForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ServerIPTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerPortTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IsSecretCbx = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SecretTxt = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ServerIPTxt
            // 
            this.ServerIPTxt.Location = new System.Drawing.Point(72, 121);
            this.ServerIPTxt.Name = "ServerIPTxt";
            this.ServerIPTxt.Size = new System.Drawing.Size(297, 23);
            this.ServerIPTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "服务器IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口：";
            // 
            // ServerPortTxt
            // 
            this.ServerPortTxt.Location = new System.Drawing.Point(425, 121);
            this.ServerPortTxt.Name = "ServerPortTxt";
            this.ServerPortTxt.Size = new System.Drawing.Size(109, 23);
            this.ServerPortTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(258, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "NoteChat-1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(314, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "连接到服务器";
            // 
            // IsSecretCbx
            // 
            this.IsSecretCbx.AutoSize = true;
            this.IsSecretCbx.Location = new System.Drawing.Point(12, 166);
            this.IsSecretCbx.Name = "IsSecretCbx";
            this.IsSecretCbx.Size = new System.Drawing.Size(111, 21);
            this.IsSecretCbx.TabIndex = 9;
            this.IsSecretCbx.Text = "通信是否加密？";
            this.IsSecretCbx.UseVisualStyleBackColor = true;
            this.IsSecretCbx.CheckedChanged += new System.EventHandler(this.IsSecretCbx_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "密钥：";
            // 
            // SecretTxt
            // 
            this.SecretTxt.Enabled = false;
            this.SecretTxt.Location = new System.Drawing.Point(190, 166);
            this.SecretTxt.Name = "SecretTxt";
            this.SecretTxt.Size = new System.Drawing.Size(313, 23);
            this.SecretTxt.TabIndex = 11;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectBtn.Location = new System.Drawing.Point(139, 232);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(279, 74);
            this.ConnectBtn.TabIndex = 12;
            this.ConnectBtn.Text = "Link Start!";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::NoteChat_Client.Properties.Resources.SBsoft;
            this.pictureBox1.Image = global::NoteChat_Client.Properties.Resources.SBsoft;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "用户名：";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(196, 199);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(221, 23);
            this.UsernameTxt.TabIndex = 14;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 315);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.SecretTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IsSecretCbx);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerPortTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerIPTxt);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.Text = "连接到服务器";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ServerIPTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServerPortTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox IsSecretCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SecretTxt;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UsernameTxt;
    }
}

