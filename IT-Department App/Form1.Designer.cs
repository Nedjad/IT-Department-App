namespace IT_Department_App
{
    partial class authWindows
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authWindows));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.authLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.enterButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authLabel.Location = new System.Drawing.Point(208, 5);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(135, 25);
            this.authLabel.TabIndex = 1;
            this.authLabel.Text = "Авторизация";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(139, 45);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(63, 21);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passLabel.Location = new System.Drawing.Point(139, 77);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(74, 21);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Пароль:";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(256, 47);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(133, 23);
            this.loginBox.TabIndex = 4;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(256, 79);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(133, 23);
            this.passBox.TabIndex = 5;
            // 
            // enterButon
            // 
            this.enterButon.Location = new System.Drawing.Point(256, 112);
            this.enterButon.Name = "enterButon";
            this.enterButon.Size = new System.Drawing.Size(133, 28);
            this.enterButon.TabIndex = 6;
            this.enterButon.Text = "Войти";
            this.enterButon.UseVisualStyleBackColor = true;
            this.enterButon.Click += new System.EventHandler(this.enterButon_Click);
            // 
            // authWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(450, 152);
            this.Controls.Add(this.enterButon);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.authLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "authWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label authLabel;
        private Label loginLabel;
        private Label passLabel;
        private Button enterButon;
        public TextBox loginBox;
        public TextBox passBox;
    }
}