using Microsoft.Data.SqlClient;
using System.Data;
using System.IO;

namespace 转一转校园二手物品交易系统
{
    public partial class FrmPublishGoods : FrmBase
    {
        private byte[]? _selectedImage;

        public FrmPublishGoods()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FrmPublishGoods_Load(object sender, EventArgs e)
        {
            BeginInvoke(() =>
            {
                DataTable dt = SQLHelper.Query("SELECT category_id, category_name FROM categories");
                LoadComboBox(cbo_Category, dt, "category_name", "category_id");
            });
        }

        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(dlg.FileName);
                    if (fi.Length > 3 * 1024 * 1024)
                    {
                        ShowError("图片大小不能超过 3MB");
                        return;
                    }

                    _selectedImage = File.ReadAllBytes(dlg.FileName);
                    using (MemoryStream ms = new MemoryStream(_selectedImage))
                        pic_Goods.Image = Image.FromStream(ms);
                }
            }
        }

        private void btn_Publish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_GoodsTitle.Text) ||
                cbo_Category.SelectedValue == null ||
                nud_Price.Value <= 0)
            {
                ShowError("请填写完整信息");
                return;
            }

            string sql = @"INSERT INTO goods 
    (title, price, category_id, seller_id, description, image_url)
    VALUES (@t, @p, @c, @s, @d, @img)";

            SqlParameter[] ps = {
                new SqlParameter("@t", txt_GoodsTitle.Text),
                new SqlParameter("@p", nud_Price.Value),
                new SqlParameter("@c", cbo_Category.SelectedValue),
                new SqlParameter("@s", Program.CurrentUserId),
                new SqlParameter("@d", rtb_Desc.Text),
                new SqlParameter("@img", SqlDbType.VarBinary, -1)
                    { Value = (object?)_selectedImage ?? DBNull.Value }
            };

            SQLHelper.Exec(sql, ps);
            ShowTip("发布成功");
            this.Close();
        }
    }
}
