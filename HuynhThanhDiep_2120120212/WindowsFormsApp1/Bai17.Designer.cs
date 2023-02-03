
namespace WindowsFormsApp1
{
    partial class Bai17
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
            this.btSelect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbSong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách bài hát";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách bài hát ưa thích";
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(361, 159);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(61, 61);
            this.btSelect.TabIndex = 4;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 61);
            this.button2.TabIndex = 5;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btSelectAll
            // 
            this.btSelectAll.Location = new System.Drawing.Point(361, 315);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(61, 61);
            this.btSelectAll.TabIndex = 6;
            this.btSelectAll.Text = ">>";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 61);
            this.button4.TabIndex = 7;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbSong
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.ItemHeight = 16;
            this.lbSong.Items.AddRange(new object[] {
            "Giất mơ chapi",
            "Em của ngày hôm qua - Son Tùng M_TP",
            "Cristiano Ronaldo",
            "Đi tìm lời ru mặt trời",
            "Đôi mắt Pleiku",
            "Cô gái miền tây"});
            this.lbSong.Location = new System.Drawing.Point(55, 96);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(294, 436);
            this.lbSong.TabIndex = 8;
            this.lbSong.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSong_MouseDoubleClick);
            // 
            // lbFavorite
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.ItemHeight = 16;
            this.lbFavorite.Location = new System.Drawing.Point(445, 96);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(297, 436);
            this.lbFavorite.TabIndex = 9;
            // 
            // Bai17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 571);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbSong);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai17";
            this.Text = "Bai17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
    }
}