namespace QuanLyThuVien
{
    partial class Book_Borrow
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
            this.button3 = new System.Windows.Forms.Button();
            this.dtp_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtg_muon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_muon)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(340, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 38);
            this.button3.TabIndex = 11;
            this.button3.Text = "Thêm vào giỏ hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtp_ngaytra
            // 
            this.dtp_ngaytra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtp_ngaytra.CustomFormat = "yyyy-MM-dd";
            this.dtp_ngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaytra.Location = new System.Drawing.Point(222, 291);
            this.dtp_ngaytra.Name = "dtp_ngaytra";
            this.dtp_ngaytra.Size = new System.Drawing.Size(179, 36);
            this.dtp_ngaytra.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ngày trả:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(119, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Trở về";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(558, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mượn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtg_muon
            // 
            this.dtg_muon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_muon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_muon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_muon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_muon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_muon.Location = new System.Drawing.Point(53, 24);
            this.dtg_muon.Name = "dtg_muon";
            this.dtg_muon.RowHeadersWidth = 51;
            this.dtg_muon.RowTemplate.Height = 24;
            this.dtg_muon.Size = new System.Drawing.Size(697, 249);
            this.dtg_muon.TabIndex = 6;
            // 
            // Book_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtp_ngaytra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtg_muon);
            this.Name = "Book_Borrow";
            this.Text = "Book_Borrow";
            this.Load += new System.EventHandler(this.Book_Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_muon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtp_ngaytra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtg_muon;
    }
}