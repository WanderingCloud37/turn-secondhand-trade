using Microsoft.Data.SqlClient;
using System.Data;

namespace 转一转校园二手物品交易系统
{
    public partial class FrmGoodsDetail : FrmBase
    {
        private int _goodsId;
        private int _sellerId;

        public FrmGoodsDetail(int goodsId)
        {
            InitializeComponent();
            _goodsId = goodsId;
        }

        private void FrmGoodsDetail_Load(object sender, EventArgs e)
        {
            string sql = @"
                SELECT g.*, c.category_name, u.username AS seller_name
                FROM goods g
                JOIN categories c ON g.category_id = c.category_id
                JOIN users u ON g.seller_id = u.user_id
                WHERE g.goods_id = @id";

            DataTable dt = SQLHelper.Query(sql, new[] { new SqlParameter("@id", _goodsId) });

            if (dt.Rows.Count == 0)
            {
                ShowError("商品不存在");
                this.Close();
                return;
            }

            DataRow row = dt.Rows[0];

            _sellerId = Convert.ToInt32(row["seller_id"]);
            lbl_Title.Text = row["title"].ToString();
            lbl_Price.Text = "￥" + Convert.ToDecimal(row["price"]).ToString("F2");
            lbl_Seller.Text = "卖家：" + row["seller_name"];
            lbl_Category.Text = "分类：" + row["category_name"];
            lbl_Time.Text = "发布时间：" + Convert.ToDateTime(row["created_time"]).ToString("yyyy-MM-dd");
            rtb_Desc.Text = row["description"]?.ToString() ?? "";

            byte[]? imgData = row["image_url"] as byte[];
            if (imgData != null && imgData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    pic_Goods.Image = Image.FromStream(ms);
                }
            }

            if (_sellerId == Program.CurrentUserId)
            {
                btn_Order.Enabled = false;
                btn_Order.Text = "不能购买自己的商品";
            }
            else if (row["status"].ToString() != "在售")
            {
                btn_Order.Enabled = false;
                btn_Order.Text = "该商品已售出";
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            if (!ShowConfirm("确认购买该商品？"))
                return;

            var (ok, msg) = SQLHelper.TryPlaceOrder(_goodsId, Program.CurrentUserId, _sellerId);
            if (ok)
                ShowTip(msg);
            else
                ShowError(msg);
            this.Close();
        }
    }
}
