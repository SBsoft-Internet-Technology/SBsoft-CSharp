namespace PayServer
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripBreakLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTipsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Product = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.RefreshProductsBtn = new System.Windows.Forms.Button();
            this.ApplyProductsBtn = new System.Windows.Forms.Button();
            this.DeleteProductsBTN = new System.Windows.Forms.Button();
            this.AddProductsBTN = new System.Windows.Forms.Button();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.Settings = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusTimeLabel,
            this.toolStripBreakLabel,
            this.toolStripTipsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(893, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusTimeLabel
            // 
            this.toolStripStatusTimeLabel.Name = "toolStripStatusTimeLabel";
            this.toolStripStatusTimeLabel.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusTimeLabel.Text = "当前时间：114514";
            // 
            // toolStripBreakLabel
            // 
            this.toolStripBreakLabel.Name = "toolStripBreakLabel";
            this.toolStripBreakLabel.Size = new System.Drawing.Size(24, 17);
            this.toolStripBreakLabel.Text = "    ";
            this.toolStripBreakLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripTipsLabel
            // 
            this.toolStripTipsLabel.Name = "toolStripTipsLabel";
            this.toolStripTipsLabel.Size = new System.Drawing.Size(131, 17);
            this.toolStripTipsLabel.Text = "toolStripStatusLabel2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.Product);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 464);
            this.tabControl1.TabIndex = 3;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(4, 26);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(885, 434);
            this.Home.TabIndex = 0;
            this.Home.Text = "主页";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.Product.Controls.Add(this.button1);
            this.Product.Controls.Add(this.RefreshProductsBtn);
            this.Product.Controls.Add(this.ApplyProductsBtn);
            this.Product.Controls.Add(this.DeleteProductsBTN);
            this.Product.Controls.Add(this.AddProductsBTN);
            this.Product.Controls.Add(this.ProductDataGridView);
            this.Product.Location = new System.Drawing.Point(4, 26);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(885, 434);
            this.Product.TabIndex = 1;
            this.Product.Text = "商品管理";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "类别管理";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RefreshProductsBtn
            // 
            this.RefreshProductsBtn.Location = new System.Drawing.Point(560, 386);
            this.RefreshProductsBtn.Name = "RefreshProductsBtn";
            this.RefreshProductsBtn.Size = new System.Drawing.Size(158, 45);
            this.RefreshProductsBtn.TabIndex = 4;
            this.RefreshProductsBtn.Text = "刷新";
            this.RefreshProductsBtn.UseVisualStyleBackColor = true;
            this.RefreshProductsBtn.Click += new System.EventHandler(this.RefreshProductsBtn_Click);
            // 
            // ApplyProductsBtn
            // 
            this.ApplyProductsBtn.Location = new System.Drawing.Point(724, 386);
            this.ApplyProductsBtn.Name = "ApplyProductsBtn";
            this.ApplyProductsBtn.Size = new System.Drawing.Size(158, 45);
            this.ApplyProductsBtn.TabIndex = 3;
            this.ApplyProductsBtn.Text = "应用";
            this.ApplyProductsBtn.UseVisualStyleBackColor = true;
            this.ApplyProductsBtn.Click += new System.EventHandler(this.ApplyProductsBtn_Click);
            // 
            // DeleteProductsBTN
            // 
            this.DeleteProductsBTN.Location = new System.Drawing.Point(167, 386);
            this.DeleteProductsBTN.Name = "DeleteProductsBTN";
            this.DeleteProductsBTN.Size = new System.Drawing.Size(158, 45);
            this.DeleteProductsBTN.TabIndex = 2;
            this.DeleteProductsBTN.Text = "删除商品";
            this.DeleteProductsBTN.UseVisualStyleBackColor = true;
            this.DeleteProductsBTN.Click += new System.EventHandler(this.DeleteProductsBTN_Click);
            // 
            // AddProductsBTN
            // 
            this.AddProductsBTN.Location = new System.Drawing.Point(3, 386);
            this.AddProductsBTN.Name = "AddProductsBTN";
            this.AddProductsBTN.Size = new System.Drawing.Size(158, 45);
            this.AddProductsBTN.TabIndex = 1;
            this.AddProductsBTN.Text = "添加商品";
            this.AddProductsBTN.UseVisualStyleBackColor = true;
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.RowTemplate.Height = 23;
            this.ProductDataGridView.Size = new System.Drawing.Size(885, 383);
            this.ProductDataGridView.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 26);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(885, 434);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "设置";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Store Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTimeLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Button DeleteProductsBTN;
        private System.Windows.Forms.Button AddProductsBTN;
        private System.Windows.Forms.Button ApplyProductsBtn;
        private System.Windows.Forms.Button RefreshProductsBtn;
        public System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripBreakLabel;
        public System.Windows.Forms.ToolStripStatusLabel toolStripTipsLabel;
    }
}

