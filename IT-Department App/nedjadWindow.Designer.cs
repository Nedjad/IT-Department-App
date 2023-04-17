namespace IT_Department_App
{
    partial class workSozWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workSozWindow));
            this.techBase = new System.Windows.Forms.DataGridView();
            this.priceLabel = new System.Windows.Forms.Label();
            this.radioButton101 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton105 = new System.Windows.Forms.RadioButton();
            this.radioButton01 = new System.Windows.Forms.RadioButton();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchInvNumber = new System.Windows.Forms.TextBox();
            this.searchName = new System.Windows.Forms.TextBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.addName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.techBase)).BeginInit();
            this.SuspendLayout();
            // 
            // techBase
            // 
            this.techBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.techBase.Location = new System.Drawing.Point(12, 36);
            this.techBase.Name = "techBase";
            this.techBase.RowTemplate.Height = 25;
            this.techBase.Size = new System.Drawing.Size(776, 201);
            this.techBase.TabIndex = 1;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(12, 9);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(49, 21);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Счёт:";
            // 
            // radioButton101
            // 
            this.radioButton101.AutoSize = true;
            this.radioButton101.Location = new System.Drawing.Point(67, 12);
            this.radioButton101.Name = "radioButton101";
            this.radioButton101.Size = new System.Drawing.Size(43, 19);
            this.radioButton101.TabIndex = 3;
            this.radioButton101.TabStop = true;
            this.radioButton101.Text = "101";
            this.radioButton101.UseVisualStyleBackColor = true;
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new System.Drawing.Point(116, 12);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(37, 19);
            this.radioButton21.TabIndex = 4;
            this.radioButton21.TabStop = true;
            this.radioButton21.Text = "21";
            this.radioButton21.UseVisualStyleBackColor = true;
            // 
            // radioButton105
            // 
            this.radioButton105.AutoSize = true;
            this.radioButton105.Location = new System.Drawing.Point(159, 12);
            this.radioButton105.Name = "radioButton105";
            this.radioButton105.Size = new System.Drawing.Size(43, 19);
            this.radioButton105.TabIndex = 5;
            this.radioButton105.TabStop = true;
            this.radioButton105.Text = "105";
            this.radioButton105.UseVisualStyleBackColor = true;
            // 
            // radioButton01
            // 
            this.radioButton01.AutoSize = true;
            this.radioButton01.Location = new System.Drawing.Point(208, 12);
            this.radioButton01.Name = "radioButton01";
            this.radioButton01.Size = new System.Drawing.Size(37, 19);
            this.radioButton01.TabIndex = 6;
            this.radioButton01.TabStop = true;
            this.radioButton01.Text = "01";
            this.radioButton01.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(14, 250);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(67, 21);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Поиск: ";
            // 
            // searchInvNumber
            // 
            this.searchInvNumber.Location = new System.Drawing.Point(86, 250);
            this.searchInvNumber.Name = "searchInvNumber";
            this.searchInvNumber.Size = new System.Drawing.Size(127, 23);
            this.searchInvNumber.TabIndex = 8;
            this.searchInvNumber.Text = "Инвентарный номер";
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(236, 250);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(180, 23);
            this.searchName.TabIndex = 9;
            this.searchName.Text = "Наименование";
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addLabel.Location = new System.Drawing.Point(794, 36);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(137, 19);
            this.addLabel.TabIndex = 10;
            this.addLabel.Text = "Добавить позицию:";
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(802, 72);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(129, 23);
            this.addName.TabIndex = 11;
            this.addName.Text = "Наименование";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(802, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Инвентарный номер";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(802, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 23);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Количество";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(802, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 23);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Цена за штуку";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(802, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 23);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "Итоговая стоимость";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(802, 217);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 23);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = "Расположение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // workSozWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(953, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.searchInvNumber);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.radioButton01);
            this.Controls.Add(this.radioButton105);
            this.Controls.Add(this.radioButton21);
            this.Controls.Add(this.radioButton101);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.techBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "workSozWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рабочая область:  Мешанович Н.М.";
            ((System.ComponentModel.ISupportInitialize)(this.techBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label priceLabel;
        private RadioButton radioButton101;
        private RadioButton radioButton21;
        private RadioButton radioButton105;
        private RadioButton radioButton01;
        private Label searchLabel;
        private TextBox searchInvNumber;
        private TextBox searchName;
        private Label addLabel;
        private TextBox addName;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private DataGridView techBase;
    }
}