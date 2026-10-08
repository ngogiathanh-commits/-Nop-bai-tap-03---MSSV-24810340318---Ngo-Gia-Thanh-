namespace bt_8_10_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDVT.Items.Clear();
            cboDVT.Items.AddRange(new string[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDVT.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maVT = txtMaVT.Text.Trim();
            string tenVT = txtTenVT.Text.Trim();
            string dvt = cboDVT.Text;
            string donGiaStr = txtDonGia.Text.Trim();

            
            if (string.IsNullOrEmpty(maVT) || string.IsNullOrEmpty(tenVT) || string.IsNullOrEmpty(donGiaStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!decimal.TryParse(donGiaStr, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá nhập phải là số hợp lệ và lớn hơn hoặc bằng 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
                return;
            }

            
            foreach (ListViewItem item in lsvVatTu.Items)
            {
                if (item.Text.Equals(maVT, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Mã vật tư '{maVT}' đã tồn tại trong danh sách!", "Cảnh báo trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaVT.Focus();
                    return;
                }
            }

            
            ListViewItem newItem = new ListViewItem(maVT);
            newItem.SubItems.Add(tenVT);
            newItem.SubItems.Add(dvt);
            newItem.SubItems.Add(donGia.ToString("#,##0")); 

            
            lsvVatTu.Items.Add(newItem);

            
            ResetInput();
        }

        private void lsvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvVatTu.SelectedItems[0];
                txtMaVT.Text = selectedItem.Text;
                txtTenVT.Text = selectedItem.SubItems[1].Text;
                cboDVT.Text = selectedItem.SubItems[2].Text;

                
                string donGiaRaw = selectedItem.SubItems[3].Text.Replace(".", "").Replace(",", "");
                txtDonGia.Text = donGiaRaw;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng vật tư trong bảng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maVT = txtMaVT.Text.Trim();
            string tenVT = txtTenVT.Text.Trim();
            string dvt = cboDVT.Text;
            string donGiaStr = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(maVT) || string.IsNullOrEmpty(tenVT) || string.IsNullOrEmpty(donGiaStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(donGiaStr, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá nhập phải là số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = lsvVatTu.SelectedItems[0];

            
            if (!selectedItem.Text.Equals(maVT, StringComparison.OrdinalIgnoreCase))
            {
                foreach (ListViewItem item in lsvVatTu.Items)
                {
                    if (item != selectedItem && item.Text.Equals(maVT, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($"Mã vật tư '{maVT}' bị trùng với vật tư khác trong bảng!", "Cảnh báo trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

           
            selectedItem.Text = maVT;
            selectedItem.SubItems[1].Text = tenVT;
            selectedItem.SubItems[2].Text = dvt;
            selectedItem.SubItems[3].Text = donGia.ToString("#,##0");

            MessageBox.Show("Cập nhật thông tin vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetInput();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng vật tư cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa vật tư đang chọn khỏi danh sách không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                lsvVatTu.Items.Remove(lsvVatTu.SelectedItems[0]);
                ResetInput();
            }
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.Items.Count == 0)
            {
                MessageBox.Show("Danh sách vật tư hiện đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa TOÀN BỘ danh sách vật tư không?",
                "Xác nhận xóa toàn bộ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                lsvVatTu.Items.Clear();
                ResetInput();
            }
        }

        
        private void ResetInput()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtDonGia.Clear();
            if (cboDVT.Items.Count > 0)
                cboDVT.SelectedIndex = 0;
            txtMaVT.Focus();
        }
    }
}
