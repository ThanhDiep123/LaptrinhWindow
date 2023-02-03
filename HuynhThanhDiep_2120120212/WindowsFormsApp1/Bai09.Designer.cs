
namespace WindowsFormsApp1
{
    partial class Bai09
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btThaot = new System.Windows.Forms.Button();
            this.txtSox = new System.Windows.Forms.TextBox();
            this.txtSoy = new System.Windows.Forms.TextBox();
            this.tbKetqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(35, 354);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(91, 39);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(285, 354);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(91, 39);
            this.btCong.TabIndex = 4;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(428, 354);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(91, 39);
            this.btNhan.TabIndex = 5;
            this.btNhan.Text = "Nhân";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btThaot
            // 
            this.btThaot.Location = new System.Drawing.Point(576, 354);
            this.btThaot.Name = "btThaot";
            this.btThaot.Size = new System.Drawing.Size(91, 39);
            this.btThaot.TabIndex = 6;
            this.btThaot.Text = "Thoát";
            this.btThaot.UseVisualStyleBackColor = true;
            this.btThaot.Click += new System.EventHandler(this.btThaot_Click);
            // 
            // txtSox
            // 
            this.txtSox.Location = new System.Drawing.Point(102, 47);
            this.txtSox.Name = "txtSox";
            this.txtSox.Size = new System.Drawing.Size(564, 22);
            this.txtSox.TabIndex = 7;
            // 
            // txtSoy
            // 
            this.txtSoy.Location = new System.Drawing.Point(102, 112);
            this.txtSoy.Name = "txtSoy";
            this.txtSoy.Size = new System.Drawing.Size(564, 22);
            this.txtSoy.TabIndex = 8;
            // 
            // tbKetqua
            // 
            this.tbKetqua.Location = new System.Drawing.Point(102, 170);
            this.tbKetqua.Multiline = true;
            this.tbKetqua.Name = "tbKetqua";
            this.tbKetqua.Size = new System.Drawing.Size(565, 164);
            this.tbKetqua.TabIndex = 10;
            // 
            // Bai09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKetqua);
            this.Controls.Add(this.txtSoy);
            this.Controls.Add(this.txtSox);
            this.Controls.Add(this.btThaot);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai09";
            this.Text = "Bai09";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btThaot;
        private System.Windows.Forms.TextBox txtSox;
        private System.Windows.Forms.TextBox txtSoy;
        private System.Windows.Forms.TextBox tbKetqua;
    }
}