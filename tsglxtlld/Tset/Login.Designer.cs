
namespace Tset
{
    partial class Login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username_lab = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_lab = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_lab
            // 
            this.username_lab.AllowDrop = true;
            this.username_lab.AutoSize = true;
            this.username_lab.BackColor = System.Drawing.Color.Transparent;
            this.username_lab.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username_lab.Location = new System.Drawing.Point(272, 97);
            this.username_lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_lab.Name = "username_lab";
            this.username_lab.Size = new System.Drawing.Size(75, 19);
            this.username_lab.TabIndex = 0;
            this.username_lab.Text = "label1";
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(393, 94);
            this.username_tb.Margin = new System.Windows.Forms.Padding(4);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(239, 28);
            this.username_tb.TabIndex = 1;
            // 
            // password_lab
            // 
            this.password_lab.AutoSize = true;
            this.password_lab.BackColor = System.Drawing.Color.Transparent;
            this.password_lab.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password_lab.Location = new System.Drawing.Point(272, 185);
            this.password_lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_lab.Name = "password_lab";
            this.password_lab.Size = new System.Drawing.Size(75, 19);
            this.password_lab.TabIndex = 2;
            this.password_lab.Text = "label1";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(393, 176);
            this.password_tb.Margin = new System.Windows.Forms.Padding(4);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(239, 28);
            this.password_tb.TabIndex = 3;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.button.Location = new System.Drawing.Point(276, 297);
            this.button.Margin = new System.Windows.Forms.Padding(4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(119, 37);
            this.button.TabIndex = 4;
            this.button.Text = "button1";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(567, 297);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(276, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // user_type
            // 
            this.user_type.FormattingEnabled = true;
            this.user_type.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.user_type.Location = new System.Drawing.Point(393, 247);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(121, 26);
            this.user_type.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(418, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(413, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "注 册";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.password_lab);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.username_lab);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_lab;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label password_lab;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox user_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

