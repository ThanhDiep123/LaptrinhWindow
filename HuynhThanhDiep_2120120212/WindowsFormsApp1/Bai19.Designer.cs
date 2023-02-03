
namespace WindowsFormsApp1
{
    partial class Bai19
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
            this.tbmanhanvien = new System.Windows.Forms.TextBox();
            this.tbtennhanvien = new System.Windows.Forms.TextBox();
            this.btFile = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ảnh 3x4";
            // 
            // tbmanhanvien
            // 
            this.tbmanhanvien.Location = new System.Drawing.Point(124, 56);
            this.tbmanhanvien.Name = "tbmanhanvien";
            this.tbmanhanvien.Size = new System.Drawing.Size(330, 22);
            this.tbmanhanvien.TabIndex = 3;
            // 
            // tbtennhanvien
            // 
            this.tbtennhanvien.Location = new System.Drawing.Point(124, 125);
            this.tbtennhanvien.Name = "tbtennhanvien";
            this.tbtennhanvien.Size = new System.Drawing.Size(486, 22);
            this.tbtennhanvien.TabIndex = 4;
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(404, 268);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(164, 62);
            this.btFile.TabIndex = 6;
            this.btFile.Text = "Chọn ảnh";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(124, 198);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(196, 240);
            this.pbImage.TabIndex = 8;
            this.pbImage.TabStop = false;
            // 
            // Bai19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.tbtennhanvien);
            this.Controls.Add(this.tbmanhanvien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai19";
            this.Text = "Bai19";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmanhanvien;
        private System.Windows.Forms.TextBox tbtennhanvien;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.PictureBox pbImage;
    }
}