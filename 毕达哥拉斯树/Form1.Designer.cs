namespace 毕达哥拉斯树
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tby1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tby2 = new System.Windows.Forms.TextBox();
            this.tba = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(720, 9);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "重新绘制";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(58, 11);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 21);
            this.tbx1.TabIndex = 1;
            this.tbx1.Text = "390";
            // 
            // tby1
            // 
            this.tby1.Location = new System.Drawing.Point(195, 11);
            this.tby1.Name = "tby1";
            this.tby1.Size = new System.Drawing.Size(100, 21);
            this.tby1.TabIndex = 2;
            this.tby1.Text = "600";
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(340, 10);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 21);
            this.tbx2.TabIndex = 3;
            this.tbx2.Text = "540";
            // 
            // tby2
            // 
            this.tby2.Location = new System.Drawing.Point(458, 10);
            this.tby2.Name = "tby2";
            this.tby2.Size = new System.Drawing.Size(100, 21);
            this.tby2.TabIndex = 4;
            this.tby2.Text = "600";
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(587, 9);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(100, 21);
            this.tba.TabIndex = 5;
            this.tba.Text = "45";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tby1);
            this.panel1.Controls.Add(this.tba);
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.tby2);
            this.panel1.Controls.Add(this.tbx1);
            this.panel1.Controls.Add(this.tbx2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 619);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 43);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 662);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "毕达哥拉斯树";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tby1;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tby2;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.Panel panel1;
    }
}

