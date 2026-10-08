namespace bt_8_10_3
{
    partial class Form1
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
            gbNhapLieu = new GroupBox();
            lblMaVT = new Label();
            txtMaVT = new TextBox();
            lblTenVT = new Label();
            txtTenVT = new TextBox();
            lblDVT = new Label();
            cboDVT = new ComboBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnXoaToanBo = new Button();

            gbDanhSach = new GroupBox();
            lsvVatTu = new ListView();
            colMaVT = new ColumnHeader();
            colTenVT = new ColumnHeader();
            colDVT = new ColumnHeader();
            colDonGia = new ColumnHeader();

            gbNhapLieu.SuspendLayout();
            gbDanhSach.SuspendLayout();
            SuspendLayout();

            // 
            // gbNhapLieu
            // 
            gbNhapLieu.Controls.Add(lblMaVT);
            gbNhapLieu.Controls.Add(txtMaVT);
            gbNhapLieu.Controls.Add(lblTenVT);
            gbNhapLieu.Controls.Add(txtTenVT);
            gbNhapLieu.Controls.Add(lblDVT);
            gbNhapLieu.Controls.Add(cboDVT);
            gbNhapLieu.Controls.Add(lblDonGia);
            gbNhapLieu.Controls.Add(txtDonGia);
            gbNhapLieu.Controls.Add(btnThem);
            gbNhapLieu.Controls.Add(btnCapNhat);
            gbNhapLieu.Controls.Add(btnXoa);
            gbNhapLieu.Controls.Add(btnXoaToanBo);
            gbNhapLieu.Location = new Point(20, 20);
            gbNhapLieu.Name = "gbNhapLieu";
            gbNhapLieu.Size = new Size(330, 400);
            gbNhapLieu.TabIndex = 0;
            gbNhapLieu.TabStop = false;
            gbNhapLieu.Text = "Thông tin vật tư";

            // lblMaVT
            lblMaVT.AutoSize = true;
            lblMaVT.Location = new Point(20, 40);
            lblMaVT.Name = "lblMaVT";
            lblMaVT.Size = new Size(71, 20);
            lblMaVT.Text = "Mã vật tư:";

            // txtMaVT
            txtMaVT.Location = new Point(120, 37);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(180, 27);

            // lblTenVT
            lblTenVT.AutoSize = true;
            lblTenVT.Location = new Point(20, 90);
            lblTenVT.Name = "lblTenVT";
            lblTenVT.Size = new Size(73, 20);
            lblTenVT.Text = "Tên vật tư:";

            // txtTenVT
            txtTenVT.Location = new Point(120, 87);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(180, 27);

            // lblDVT
            lblDVT.AutoSize = true;
            lblDVT.Location = new Point(20, 140);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new Size(84, 20);
            lblDVT.Text = "Đơn vị tính:";

            // cboDVT
            cboDVT.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDVT.FormattingEnabled = true;
            cboDVT.Location = new Point(120, 137);
            cboDVT.Name = "cboDVT";
            cboDVT.Size = new Size(180, 28);

            // lblDonGia
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(20, 190);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(99, 20);
            lblDonGia.Text = "Đơn giá nhập:";

            // txtDonGia
            txtDonGia.Location = new Point(120, 187);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(180, 27);

            // btnThem
            btnThem.Location = new Point(20, 250);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(130, 40);
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // btnCapNhat
            btnCapNhat.Location = new Point(170, 250);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(130, 40);
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;

            // btnXoa
            btnXoa.Location = new Point(20, 310);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 40);
            btnXoa.Text = "Xóa dòng";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // btnXoaToanBo
            btnXoaToanBo.Location = new Point(170, 310);
            btnXoaToanBo.Name = "btnXoaToanBo";
            btnXoaToanBo.Size = new Size(130, 40);
            btnXoaToanBo.Text = "Xóa toàn bộ";
            btnXoaToanBo.UseVisualStyleBackColor = true;
            btnXoaToanBo.Click += btnXoaToanBo_Click;

            // 
            // gbDanhSach
            // 
            gbDanhSach.Controls.Add(lsvVatTu);
            gbDanhSach.Location = new Point(370, 20);
            gbDanhSach.Name = "gbDanhSach";
            gbDanhSach.Size = new Size(550, 400);
            gbDanhSach.TabIndex = 1;
            gbDanhSach.TabStop = false;
            gbDanhSach.Text = "Danh sách vật tư";

            // 
            // lsvVatTu
            // 
            lsvVatTu.Columns.AddRange(new ColumnHeader[] { colMaVT, colTenVT, colDVT, colDonGia });
            lsvVatTu.FullRowSelect = true;
            lsvVatTu.GridLines = true;
            lsvVatTu.Location = new Point(15, 30);
            lsvVatTu.Name = "lsvVatTu";
            lsvVatTu.Size = new Size(520, 350);
            lsvVatTu.TabIndex = 0;
            lsvVatTu.UseCompatibleStateImageBehavior = false;
            lsvVatTu.View = View.Details;
            lsvVatTu.SelectedIndexChanged += lsvVatTu_SelectedIndexChanged;

            // colMaVT
            colMaVT.Text = "Mã VT";
            colMaVT.Width = 90;

            // colTenVT
            colTenVT.Text = "Tên VT";
            colTenVT.Width = 180;

            // colDVT
            colDVT.Text = "Đơn vị tính";
            colDVT.Width = 100;

            // colDonGia
            colDonGia.Text = "Đơn giá";
            colDonGia.Width = 130;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 440);
            Controls.Add(gbDanhSach);
            Controls.Add(gbNhapLieu);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh mục Vật tư / Linh kiện";
            Load += Form1_Load;
            gbNhapLieu.ResumeLayout(false);
            gbNhapLieu.PerformLayout();
            gbDanhSach.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbNhapLieu;
        private Label lblMaVT;
        private TextBox txtMaVT;
        private Label lblTenVT;
        private TextBox txtTenVT;
        private Label lblDVT;
        private ComboBox cboDVT;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnXoaToanBo;

        private GroupBox gbDanhSach;
        private ListView lsvVatTu;
        private ColumnHeader colMaVT;
        private ColumnHeader colTenVT;
        private ColumnHeader colDVT;
        private ColumnHeader colDonGia;
    }
}