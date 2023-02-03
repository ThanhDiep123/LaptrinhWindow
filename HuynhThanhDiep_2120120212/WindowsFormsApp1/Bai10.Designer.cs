
namespace WindowsFormsApp1
{
    partial class Bai10
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
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btCham = new System.Windows.Forms.Button();
            this.btBang = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(75, 165);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(153, 102);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(265, 165);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(153, 102);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(456, 165);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(153, 102);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(653, 165);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(153, 102);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(73, 306);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(153, 102);
            this.btCong.TabIndex = 5;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(265, 306);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(153, 102);
            this.btNhan.TabIndex = 6;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btCham
            // 
            this.btCham.Location = new System.Drawing.Point(456, 306);
            this.btCham.Name = "btCham";
            this.btCham.Size = new System.Drawing.Size(153, 102);
            this.btCham.TabIndex = 7;
            this.btCham.Text = ".";
            this.btCham.UseVisualStyleBackColor = true;
            // 
            // btBang
            // 
            this.btBang.Location = new System.Drawing.Point(653, 306);
            this.btBang.Name = "btBang";
            this.btBang.Size = new System.Drawing.Size(153, 102);
            this.btBang.TabIndex = 8;
            this.btBang.Text = "=";
            this.btBang.UseVisualStyleBackColor = true;
            this.btBang.Click += new System.EventHandler(this.btBang_Click);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(75, 55);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(736, 90);
            this.tbDisplay.TabIndex = 9;
            
            // 
            // Bai10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.btBang);
            this.Controls.Add(this.btCham);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Name = "Bai10";
            this.Text = "Bai10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btCham;
        private System.Windows.Forms.Button btBang;
        private System.Windows.Forms.TextBox tbDisplay;
    }
}