namespace QuanLyThuVien
{
    partial class Sach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SachGridView = new System.Windows.Forms.DataGridView();
            this.SachPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchingButton = new System.Windows.Forms.Button();
            this.SearchingBox = new System.Windows.Forms.RichTextBox();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IDsach = new System.Windows.Forms.Label();
            this.TenSACH = new System.Windows.Forms.Label();
            this.muonSachTableAdapter1 = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.MuonSachTableAdapter();
            this.IDSachBox = new System.Windows.Forms.RichTextBox();
            this.SACHBOX = new System.Windows.Forms.RichTextBox();
            this.TheLoaiBox = new System.Windows.Forms.RichTextBox();
            this.TheLoai = new System.Windows.Forms.Label();
            this.TacGiaBox = new System.Windows.Forms.RichTextBox();
            this.TacGia = new System.Windows.Forms.Label();
            this.GiaThueBox = new System.Windows.Forms.RichTextBox();
            this.GiaThue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SachGridView)).BeginInit();
            this.SachPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SachGridView
            // 
            this.SachGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SachGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SachGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SachGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SachGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SachGridView.Location = new System.Drawing.Point(0, 0);
            this.SachGridView.Name = "SachGridView";
            this.SachGridView.ReadOnly = true;
            this.SachGridView.RowHeadersVisible = false;
            this.SachGridView.RowHeadersWidth = 51;
            this.SachGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SachGridView.Size = new System.Drawing.Size(583, 728);
            this.SachGridView.TabIndex = 0;
            this.SachGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SachGridView_CellClick);
            // 
            // SachPanel
            // 
            this.SachPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SachPanel.AutoSize = true;
            this.SachPanel.Controls.Add(this.SachGridView);
            this.SachPanel.Location = new System.Drawing.Point(608, 3);
            this.SachPanel.Name = "SachPanel";
            this.SachPanel.Size = new System.Drawing.Size(583, 728);
            this.SachPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 106);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sách";
            // 
            // SearchingButton
            // 
            this.SearchingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchingButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchingButton.Location = new System.Drawing.Point(157, 147);
            this.SearchingButton.Name = "SearchingButton";
            this.SearchingButton.Size = new System.Drawing.Size(91, 40);
            this.SearchingButton.TabIndex = 3;
            this.SearchingButton.Text = "Tìm Kiếm ";
            this.SearchingButton.UseVisualStyleBackColor = false;
            this.SearchingButton.Click += new System.EventHandler(this.SearchingButton_Click);
            // 
            // SearchingBox
            // 
            this.SearchingBox.Location = new System.Drawing.Point(265, 147);
            this.SearchingBox.Name = "SearchingBox";
            this.SearchingBox.Size = new System.Drawing.Size(309, 40);
            this.SearchingBox.TabIndex = 4;
            this.SearchingBox.Text = "";
            // 
            // ADDbutton
            // 
            this.ADDbutton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDbutton.Location = new System.Drawing.Point(194, 658);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(111, 55);
            this.ADDbutton.TabIndex = 5;
            this.ADDbutton.Text = "Thêm";
            this.ADDbutton.UseVisualStyleBackColor = true;
            this.ADDbutton.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.EditButton.Location = new System.Drawing.Point(330, 658);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(111, 55);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Sửa\r\n";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(463, 658);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 55);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IDsach
            // 
            this.IDsach.AutoSize = true;
            this.IDsach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDsach.Location = new System.Drawing.Point(164, 245);
            this.IDsach.Name = "IDsach";
            this.IDsach.Size = new System.Drawing.Size(65, 20);
            this.IDsach.TabIndex = 9;
            this.IDsach.Text = "ID SÁCH";
            // 
            // TenSACH
            // 
            this.TenSACH.AutoSize = true;
            this.TenSACH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSACH.Location = new System.Drawing.Point(164, 314);
            this.TenSACH.Name = "TenSACH";
            this.TenSACH.Size = new System.Drawing.Size(76, 20);
            this.TenSACH.TabIndex = 10;
            this.TenSACH.Text = "TÊN SÁCH";
            // 
            // muonSachTableAdapter1
            // 
            this.muonSachTableAdapter1.ClearBeforeFill = true;
            // 
            // IDSachBox
            // 
            this.IDSachBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IDSachBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDSachBox.Cursor = System.Windows.Forms.Cursors.No;
            this.IDSachBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDSachBox.Location = new System.Drawing.Point(265, 234);
            this.IDSachBox.Multiline = false;
            this.IDSachBox.Name = "IDSachBox";
            this.IDSachBox.ReadOnly = true;
            this.IDSachBox.RightMargin = 15;
            this.IDSachBox.Size = new System.Drawing.Size(309, 40);
            this.IDSachBox.TabIndex = 11;
            this.IDSachBox.Text = "";
            // 
            // SACHBOX
            // 
            this.SACHBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SACHBOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SACHBOX.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SACHBOX.Location = new System.Drawing.Point(265, 312);
            this.SACHBOX.Multiline = false;
            this.SACHBOX.Name = "SACHBOX";
            this.SACHBOX.RightMargin = 15;
            this.SACHBOX.Size = new System.Drawing.Size(309, 40);
            this.SACHBOX.TabIndex = 12;
            this.SACHBOX.Text = "";
            // 
            // TheLoaiBox
            // 
            this.TheLoaiBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TheLoaiBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TheLoaiBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheLoaiBox.Location = new System.Drawing.Point(266, 379);
            this.TheLoaiBox.Multiline = false;
            this.TheLoaiBox.Name = "TheLoaiBox";
            this.TheLoaiBox.RightMargin = 15;
            this.TheLoaiBox.Size = new System.Drawing.Size(309, 40);
            this.TheLoaiBox.TabIndex = 14;
            this.TheLoaiBox.Text = "";
            // 
            // TheLoai
            // 
            this.TheLoai.AutoSize = true;
            this.TheLoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheLoai.Location = new System.Drawing.Point(165, 381);
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Size = new System.Drawing.Size(76, 23);
            this.TheLoai.TabIndex = 13;
            this.TheLoai.Text = "Thể Loại ";
            // 
            // TacGiaBox
            // 
            this.TacGiaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TacGiaBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TacGiaBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TacGiaBox.Location = new System.Drawing.Point(265, 448);
            this.TacGiaBox.Multiline = false;
            this.TacGiaBox.Name = "TacGiaBox";
            this.TacGiaBox.RightMargin = 15;
            this.TacGiaBox.Size = new System.Drawing.Size(309, 40);
            this.TacGiaBox.TabIndex = 16;
            this.TacGiaBox.Text = "";
            // 
            // TacGia
            // 
            this.TacGia.AutoSize = true;
            this.TacGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TacGia.Location = new System.Drawing.Point(164, 450);
            this.TacGia.Name = "TacGia";
            this.TacGia.Size = new System.Drawing.Size(70, 23);
            this.TacGia.TabIndex = 15;
            this.TacGia.Text = "Tác Giả ";
            // 
            // GiaThueBox
            // 
            this.GiaThueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GiaThueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GiaThueBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaThueBox.Location = new System.Drawing.Point(265, 521);
            this.GiaThueBox.Multiline = false;
            this.GiaThueBox.Name = "GiaThueBox";
            this.GiaThueBox.RightMargin = 15;
            this.GiaThueBox.Size = new System.Drawing.Size(309, 40);
            this.GiaThueBox.TabIndex = 18;
            this.GiaThueBox.Text = "";
            // 
            // GiaThue
            // 
            this.GiaThue.AutoSize = true;
            this.GiaThue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaThue.Location = new System.Drawing.Point(164, 523);
            this.GiaThue.Name = "GiaThue";
            this.GiaThue.Size = new System.Drawing.Size(75, 23);
            this.GiaThue.TabIndex = 17;
            this.GiaThue.Text = "Giá Thuê";
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GiaThueBox);
            this.Controls.Add(this.GiaThue);
            this.Controls.Add(this.TacGiaBox);
            this.Controls.Add(this.TacGia);
            this.Controls.Add(this.TheLoaiBox);
            this.Controls.Add(this.TheLoai);
            this.Controls.Add(this.SACHBOX);
            this.Controls.Add(this.IDSachBox);
            this.Controls.Add(this.TenSACH);
            this.Controls.Add(this.IDsach);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ADDbutton);
            this.Controls.Add(this.SearchingBox);
            this.Controls.Add(this.SearchingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SachPanel);
            this.Name = "Sach";
            this.Size = new System.Drawing.Size(1191, 734);
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SachGridView)).EndInit();
            this.SachPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SachGridView;
        private System.Windows.Forms.Panel SachPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchingButton;
        private System.Windows.Forms.RichTextBox SearchingBox;
        private System.Windows.Forms.Button ADDbutton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label IDsach;
        private System.Windows.Forms.Label TenSACH;
        private QuanLyThuVienDataSetTableAdapters.MuonSachTableAdapter muonSachTableAdapter1;
        private System.Windows.Forms.RichTextBox IDSachBox;
        private System.Windows.Forms.RichTextBox SACHBOX;
        private System.Windows.Forms.RichTextBox TheLoaiBox;
        private System.Windows.Forms.Label TheLoai;
        private System.Windows.Forms.RichTextBox TacGiaBox;
        private System.Windows.Forms.Label TacGia;
        private System.Windows.Forms.RichTextBox GiaThueBox;
        private System.Windows.Forms.Label GiaThue;
    }
}
