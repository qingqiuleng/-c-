namespace myWarehouse
{
    partial class FormMain
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
            this.Exit = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelAcount = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(67, 317);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 30);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(390, 317);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(100, 30);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "登录";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 7;
            // 
            // labelAcount
            // 
            this.labelAcount.AutoSize = true;
            this.labelAcount.Location = new System.Drawing.Point(196, 86);
            this.labelAcount.Name = "labelAcount";
            this.labelAcount.Size = new System.Drawing.Size(41, 12);
            this.labelAcount.TabIndex = 8;
            this.labelAcount.Text = "账号：";
            this.labelAcount.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(196, 157);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(41, 12);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "密码：";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 448);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelAcount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Exit);
            this.Name = "FormMain";
            this.Text = "水产批发仓库管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelAcount;
        private System.Windows.Forms.Label labelPassword;
    }
}

