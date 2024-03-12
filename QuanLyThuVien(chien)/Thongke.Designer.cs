namespace QuanLyThuVien
{
    partial class Thongke
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
            this.btnTop10 = new System.Windows.Forms.Button();
            this.btnTreHan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTop10
            // 
            this.btnTop10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10.Location = new System.Drawing.Point(131, 50);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(330, 109);
            this.btnTop10.TabIndex = 0;
            this.btnTop10.Text = "Top 10 sách được mượn nhiều nhất";
            this.btnTop10.UseVisualStyleBackColor = true;
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // btnTreHan
            // 
            this.btnTreHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreHan.Location = new System.Drawing.Point(582, 50);
            this.btnTreHan.Name = "btnTreHan";
            this.btnTreHan.Size = new System.Drawing.Size(330, 109);
            this.btnTreHan.TabIndex = 1;
            this.btnTreHan.Text = "Trễ hạn";
            this.btnTreHan.UseVisualStyleBackColor = true;
            this.btnTreHan.Click += new System.EventHandler(this.btnTreHan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 374);
            this.dataGridView1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(693, 625);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 89);
            this.button3.TabIndex = 3;
            this.button3.Text = "Quay lại";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 726);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTreHan);
            this.Controls.Add(this.btnTop10);
            this.Name = "Thongke";
            this.Text = "Thongke";
            this.Load += new System.EventHandler(this.Thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Button btnTreHan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
    }
}