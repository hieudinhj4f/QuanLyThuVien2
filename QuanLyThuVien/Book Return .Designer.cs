namespace QuanLyThuVien
{
    partial class Book_Return
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
            this.dtg_tra = new System.Windows.Forms.DataGridView();
            this.lb_ngaymuon = new System.Windows.Forms.Label();
            this.dtp_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_trove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_tra)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_tra
            // 
            this.dtg_tra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_tra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_tra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_tra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_tra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_tra.Location = new System.Drawing.Point(66, 37);
            this.dtg_tra.Name = "dtg_tra";
            this.dtg_tra.RowHeadersWidth = 51;
            this.dtg_tra.RowTemplate.Height = 24;
            this.dtg_tra.Size = new System.Drawing.Size(833, 344);
            this.dtg_tra.TabIndex = 1;
            // 
            // lb_ngaymuon
            // 
            this.lb_ngaymuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_ngaymuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaymuon.Location = new System.Drawing.Point(61, 405);
            this.lb_ngaymuon.Name = "lb_ngaymuon";
            this.lb_ngaymuon.Size = new System.Drawing.Size(166, 43);
            this.lb_ngaymuon.TabIndex = 6;
            this.lb_ngaymuon.Text = "Ngày trả:";
            // 
            // dtp_ngaytra
            // 
            this.dtp_ngaytra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtp_ngaytra.CustomFormat = "yyyy-MM-dd";
            this.dtp_ngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaytra.Location = new System.Drawing.Point(201, 405);
            this.dtp_ngaytra.Name = "dtp_ngaytra";
            this.dtp_ngaytra.Size = new System.Drawing.Size(179, 36);
            this.dtp_ngaytra.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(741, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Trả sách";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_trove
            // 
            this.btn_trove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_trove.Location = new System.Drawing.Point(358, 464);
            this.btn_trove.Name = "btn_trove";
            this.btn_trove.Size = new System.Drawing.Size(158, 48);
            this.btn_trove.TabIndex = 10;
            this.btn_trove.Text = "Trở về";
            this.btn_trove.UseVisualStyleBackColor = true;
            this.btn_trove.Click += new System.EventHandler(this.btn_trove_Click);
            // 
            // Book_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 559);
            this.Controls.Add(this.btn_trove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtp_ngaytra);
            this.Controls.Add(this.lb_ngaymuon);
            this.Controls.Add(this.dtg_tra);
            this.Name = "Book_Return";
            this.Text = "Book_Return";
            this.Load += new System.EventHandler(this.Book_Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_tra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_tra;
        private System.Windows.Forms.Label lb_ngaymuon;
        private System.Windows.Forms.DateTimePicker dtp_ngaytra;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_trove;
    }
}