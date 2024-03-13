namespace QuanLyThuVien
{
    partial class Book_Late
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
            this.dtg_sachMuon = new System.Windows.Forms.DataGridView();
            this.btn_troVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_sachMuon
            // 
            this.dtg_sachMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_sachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_sachMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_sachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_sachMuon.Location = new System.Drawing.Point(55, 28);
            this.dtg_sachMuon.Name = "dtg_sachMuon";
            this.dtg_sachMuon.RowHeadersWidth = 51;
            this.dtg_sachMuon.Size = new System.Drawing.Size(902, 330);
            this.dtg_sachMuon.TabIndex = 0;
            // 
            // btn_troVe
            // 
            this.btn_troVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_troVe.Location = new System.Drawing.Point(836, 381);
            this.btn_troVe.Name = "btn_troVe";
            this.btn_troVe.Size = new System.Drawing.Size(121, 47);
            this.btn_troVe.TabIndex = 1;
            this.btn_troVe.Text = "Trở về";
            this.btn_troVe.UseVisualStyleBackColor = true;
            // 
            // Book_Late
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.btn_troVe);
            this.Controls.Add(this.dtg_sachMuon);
            this.Name = "Book_Late";
            this.Text = "Sách nộp muộn";
            this.Load += new System.EventHandler(this.Book_Late_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sachMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_sachMuon;
        private System.Windows.Forms.Button btn_troVe;
    }
}