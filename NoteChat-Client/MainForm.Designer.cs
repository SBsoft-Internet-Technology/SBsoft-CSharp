namespace NoteChat_Client
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MessageRtxt = new System.Windows.Forms.RichTextBox();
            this.SendMessageRTxt = new System.Windows.Forms.RichTextBox();
            this.SendMessageBtn = new System.Windows.Forms.Button();
            this.OnlineListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.RefreshListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(713, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MessageRtxt
            // 
            this.MessageRtxt.Location = new System.Drawing.Point(2, 1);
            this.MessageRtxt.Name = "MessageRtxt";
            this.MessageRtxt.ReadOnly = true;
            this.MessageRtxt.Size = new System.Drawing.Size(570, 384);
            this.MessageRtxt.TabIndex = 1;
            this.MessageRtxt.Text = "";
            // 
            // SendMessageRTxt
            // 
            this.SendMessageRTxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendMessageRTxt.Location = new System.Drawing.Point(2, 391);
            this.SendMessageRTxt.MaxLength = 100;
            this.SendMessageRTxt.Multiline = false;
            this.SendMessageRTxt.Name = "SendMessageRTxt";
            this.SendMessageRTxt.Size = new System.Drawing.Size(497, 32);
            this.SendMessageRTxt.TabIndex = 2;
            this.SendMessageRTxt.Text = "在这里输入消息";
            this.SendMessageRTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendMessageRTxt_KeyDown);
            this.SendMessageRTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SendMessageRTxt_KeyPress);
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.Location = new System.Drawing.Point(498, 391);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(74, 30);
            this.SendMessageBtn.TabIndex = 3;
            this.SendMessageBtn.Text = "发送";
            this.SendMessageBtn.UseVisualStyleBackColor = true;
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // OnlineListBox
            // 
            this.OnlineListBox.FormattingEnabled = true;
            this.OnlineListBox.ItemHeight = 17;
            this.OnlineListBox.Location = new System.Drawing.Point(573, 19);
            this.OnlineListBox.Name = "OnlineListBox";
            this.OnlineListBox.Size = new System.Drawing.Size(139, 344);
            this.OnlineListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "在线列表：";
            // 
            // MenuBtn
            // 
            this.MenuBtn.Location = new System.Drawing.Point(573, 391);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(139, 29);
            this.MenuBtn.TabIndex = 6;
            this.MenuBtn.Text = "菜单";
            this.MenuBtn.UseVisualStyleBackColor = true;
            // 
            // RefreshListBox
            // 
            this.RefreshListBox.Location = new System.Drawing.Point(573, 363);
            this.RefreshListBox.Name = "RefreshListBox";
            this.RefreshListBox.Size = new System.Drawing.Size(140, 22);
            this.RefreshListBox.TabIndex = 7;
            this.RefreshListBox.Text = "刷新";
            this.RefreshListBox.UseVisualStyleBackColor = true;
            this.RefreshListBox.Click += new System.EventHandler(this.RefreshListBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 446);
            this.Controls.Add(this.RefreshListBox);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OnlineListBox);
            this.Controls.Add(this.SendMessageBtn);
            this.Controls.Add(this.SendMessageRTxt);
            this.Controls.Add(this.MessageRtxt);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox MessageRtxt;
        private System.Windows.Forms.RichTextBox SendMessageRTxt;
        private System.Windows.Forms.Button SendMessageBtn;
        private System.Windows.Forms.ListBox OnlineListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button RefreshListBox;
    }
}