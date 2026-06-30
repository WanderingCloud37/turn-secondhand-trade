namespace 转一转校园二手物品交易系统
{
    partial class FrmGoodslist
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lbl_Search = new Label();
            txt_Search = new TextBox();
            lbl_Category = new Label();
            cbo_Category = new ComboBox();
            btn_Search = new Button();
            btn_Refresh = new Button();
            dgv_Goods = new DataGridView();
            goods_id = new DataGridViewTextBoxColumn();
            col_image = new DataGridViewImageColumn();
            商品名 = new DataGridViewTextBoxColumn();
            价格 = new DataGridViewTextBoxColumn();
            分类 = new DataGridViewTextBoxColumn();
            卖家 = new DataGridViewTextBoxColumn();
            状态 = new DataGridViewTextBoxColumn();
            btn_Prev = new Button();
            lbl_PageInfo = new Label();
            btn_Next = new Button();
            btn_ViewDetail = new Button();
            pnl_SearchBar = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_Goods).BeginInit();
            pnl_SearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Search
            // 
            lbl_Search.AutoSize = true;
            lbl_Search.Location = new Point(30, 20);
            lbl_Search.Name = "lbl_Search";
            lbl_Search.Size = new Size(44, 17);
            lbl_Search.TabIndex = 0;
            lbl_Search.Text = "搜索：";
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(80, 17);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(200, 23);
            txt_Search.TabIndex = 1;
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize = true;
            lbl_Category.Location = new Point(30, 48);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new Size(44, 17);
            lbl_Category.TabIndex = 9;
            lbl_Category.Text = "分类：";
            // 
            // cbo_Category
            // 
            cbo_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Category.FormattingEnabled = true;
            cbo_Category.Location = new Point(80, 45);
            cbo_Category.Name = "cbo_Category";
            cbo_Category.Size = new Size(161, 25);
            cbo_Category.TabIndex = 10;
            cbo_Category.SelectedIndexChanged += cbo_Category_SelectedIndexChanged;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(300, 17);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(75, 23);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "搜索";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_Refresh
            // 
            btn_Refresh.Location = new Point(390, 17);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(75, 23);
            btn_Refresh.TabIndex = 3;
            btn_Refresh.Text = "全部";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // dgv_Goods
            // 
            dgv_Goods.AllowUserToAddRows = false;
            dgv_Goods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Goods.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_Goods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_Goods.ColumnHeadersHeight = 30;
            dgv_Goods.Columns.AddRange(new DataGridViewColumn[] { goods_id, col_image, 商品名, 价格, 分类, 卖家, 状态 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgv_Goods.DefaultCellStyle = dataGridViewCellStyle7;
            dgv_Goods.Dock = DockStyle.Fill;
            dgv_Goods.Location = new Point(0, 74);
            dgv_Goods.Name = "dgv_Goods";
            dgv_Goods.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgv_Goods.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgv_Goods.RowHeadersVisible = false;
            dgv_Goods.RowHeadersWidth = 62;
            dgv_Goods.RowTemplate.Height = 60;
            dgv_Goods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Goods.Size = new Size(533, 400);
            dgv_Goods.TabIndex = 4;
            dgv_Goods.CellContentClick += dgv_Goods_CellContentClick;
            dgv_Goods.CellDoubleClick += dgv_Goods_CellDoubleClick;
            // 
            // goods_id
            // 
            goods_id.DataPropertyName = "goods_id";
            dataGridViewCellStyle6.Format = "0000";
            goods_id.DefaultCellStyle = dataGridViewCellStyle6;
            goods_id.FillWeight = 100F;
            goods_id.HeaderText = "商品 ID";
            goods_id.MinimumWidth = 8;
            goods_id.Name = "goods_id";
            goods_id.ReadOnly = true;
            // 
            // col_image
            // 
            col_image.FillWeight = 180F;
            col_image.HeaderText = "图片";
            col_image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            col_image.MinimumWidth = 8;
            col_image.Name = "col_image";
            col_image.ReadOnly = true;
            // 
            // 商品名
            // 
            商品名.DataPropertyName = "商品名";
            商品名.FillWeight = 250F;
            商品名.HeaderText = "商品名";
            商品名.MinimumWidth = 8;
            商品名.Name = "商品名";
            商品名.ReadOnly = true;
            // 
            // 价格
            // 
            价格.DataPropertyName = "价格";
            价格.FillWeight = 80F;
            价格.HeaderText = "价格";
            价格.MinimumWidth = 8;
            价格.Name = "价格";
            价格.ReadOnly = true;
            // 
            // 分类
            // 
            分类.DataPropertyName = "分类";
            分类.HeaderText = "分类";
            分类.MinimumWidth = 8;
            分类.Name = "分类";
            分类.ReadOnly = true;
            // 
            // 卖家
            // 
            卖家.DataPropertyName = "卖家";
            卖家.HeaderText = "卖家";
            卖家.MinimumWidth = 8;
            卖家.Name = "卖家";
            卖家.ReadOnly = true;
            // 
            // 状态
            // 
            状态.DataPropertyName = "状态";
            状态.FillWeight = 80F;
            状态.HeaderText = "状态";
            状态.MinimumWidth = 8;
            状态.Name = "状态";
            状态.ReadOnly = true;
            // 
            // btn_Prev
            // 
            btn_Prev.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Prev.Location = new Point(319, 443);
            btn_Prev.Name = "btn_Prev";
            btn_Prev.Size = new Size(65, 25);
            btn_Prev.TabIndex = 5;
            btn_Prev.Text = "上一页";
            btn_Prev.UseVisualStyleBackColor = true;
            btn_Prev.Click += btn_Prev_Click;
            // 
            // lbl_PageInfo
            // 
            lbl_PageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_PageInfo.AutoSize = true;
            lbl_PageInfo.Location = new Point(390, 448);
            lbl_PageInfo.Name = "lbl_PageInfo";
            lbl_PageInfo.Size = new Size(59, 17);
            lbl_PageInfo.TabIndex = 6;
            lbl_PageInfo.Text = "第 1/1 页";
            lbl_PageInfo.Click += lbl_PageInfo_Click;
            // 
            // btn_Next
            // 
            btn_Next.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Next.Location = new Point(452, 443);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(65, 25);
            btn_Next.TabIndex = 7;
            btn_Next.Text = "下一页";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_ViewDetail
            // 
            btn_ViewDetail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_ViewDetail.BackColor = SystemColors.ActiveCaption;
            btn_ViewDetail.Location = new Point(216, 441);
            btn_ViewDetail.Name = "btn_ViewDetail";
            btn_ViewDetail.Size = new Size(100, 30);
            btn_ViewDetail.TabIndex = 8;
            btn_ViewDetail.Text = "查看详情";
            btn_ViewDetail.UseVisualStyleBackColor = false;
            btn_ViewDetail.Click += btn_ViewDetail_Click;
            // 
            // pnl_SearchBar
            // 
            pnl_SearchBar.Controls.Add(btn_Refresh);
            pnl_SearchBar.Controls.Add(btn_Search);
            pnl_SearchBar.Controls.Add(txt_Search);
            pnl_SearchBar.Controls.Add(lbl_Category);
            pnl_SearchBar.Controls.Add(cbo_Category);
            pnl_SearchBar.Controls.Add(lbl_Search);
            pnl_SearchBar.Dock = DockStyle.Top;
            pnl_SearchBar.Location = new Point(0, 0);
            pnl_SearchBar.Margin = new Padding(2);
            pnl_SearchBar.Name = "pnl_SearchBar";
            pnl_SearchBar.Size = new Size(533, 74);
            pnl_SearchBar.TabIndex = 11;
            // 
            // FrmGoodslist
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 527);
            Controls.Add(btn_ViewDetail);
            Controls.Add(btn_Next);
            Controls.Add(lbl_PageInfo);
            Controls.Add(btn_Prev);
            Controls.Add(dgv_Goods);
            Controls.Add(pnl_SearchBar);
            Name = "FrmGoodslist";
            Text = "Form1";
            Load += FrmGoodslist_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Goods).EndInit();
            pnl_SearchBar.ResumeLayout(false);
            pnl_SearchBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Search;
        private TextBox txt_Search;
        private Label lbl_Category;
        private ComboBox cbo_Category;
        private Panel pnl_SearchBar;
        private Button btn_Search;
        private Button btn_Refresh;
        private DataGridView dgv_Goods;
        private Button btn_ViewDetail;
        private Button btn_Prev;
        private Label lbl_PageInfo;
        private Button btn_Next;
        private DataGridViewImageColumn col_image;
        private DataGridViewTextBoxColumn goods_id;
        private DataGridViewTextBoxColumn 商品名;
        private DataGridViewTextBoxColumn 价格;
        private DataGridViewTextBoxColumn 分类;
        private DataGridViewTextBoxColumn 卖家;
        private DataGridViewTextBoxColumn 状态;
    }
}
