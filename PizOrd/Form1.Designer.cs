namespace PizOrd
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.downButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.comboBoxSelP = new System.Windows.Forms.ComboBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showPizButton = new System.Windows.Forms.Button();
            this.orderPizButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPiz = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPiz)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(171)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.downButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 27);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // downButton
            // 
            this.downButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downButton.Location = new System.Drawing.Point(307, 0);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 27);
            this.downButton.TabIndex = 1;
            this.downButton.Text = "---";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            this.downButton.MouseLeave += new System.EventHandler(this.downButton_MouseLeave);
            this.downButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.downButton_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(382, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 27);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.closeButton_MouseMove);
            // 
            // comboBoxSelP
            // 
            this.comboBoxSelP.AutoCompleteCustomSource.AddRange(new string[] {
            "Сырная",
            "Мясная",
            "Сананасами",
            "Вчерашняя"});
            this.comboBoxSelP.FormattingEnabled = true;
            this.comboBoxSelP.Items.AddRange(new object[] {
            "Грибная",
            "Сырная",
            "Вчерашняя",
            "Сананасами"});
            this.comboBoxSelP.Location = new System.Drawing.Point(56, 413);
            this.comboBoxSelP.Name = "comboBoxSelP";
            this.comboBoxSelP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelP.TabIndex = 1;
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(56, 505);
            this.adressTextBox.Multiline = true;
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(100, 50);
            this.adressTextBox.TabIndex = 2;
            this.adressTextBox.Click += new System.EventHandler(this.adressTextBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(56, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "P";
            // 
            // showPizButton
            // 
            this.showPizButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPizButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPizButton.Location = new System.Drawing.Point(316, 413);
            this.showPizButton.Name = "showPizButton";
            this.showPizButton.Size = new System.Drawing.Size(112, 29);
            this.showPizButton.TabIndex = 5;
            this.showPizButton.Text = "show pizza";
            this.showPizButton.UseVisualStyleBackColor = true;
            this.showPizButton.Click += new System.EventHandler(this.showPizButton_Click);
            this.showPizButton.MouseLeave += new System.EventHandler(this.showPizButton_MouseLeave);
            this.showPizButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.showPizButton_MouseMove);
            // 
            // orderPizButton
            // 
            this.orderPizButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderPizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderPizButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderPizButton.Location = new System.Drawing.Point(299, 526);
            this.orderPizButton.Name = "orderPizButton";
            this.orderPizButton.Size = new System.Drawing.Size(112, 29);
            this.orderPizButton.TabIndex = 6;
            this.orderPizButton.Text = "order pizza";
            this.orderPizButton.UseVisualStyleBackColor = true;
            this.orderPizButton.Click += new System.EventHandler(this.orderPizButton_Click);
            this.orderPizButton.MouseLeave += new System.EventHandler(this.orderPizButton_MouseLeave);
            this.orderPizButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.orderPizButton_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Input your adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(15)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(130, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(15)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(93, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "i";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(72)))), ((int)(((byte)(15)))));
            this.label7.Location = new System.Drawing.Point(204, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 38);
            this.label7.TabIndex = 15;
            this.label7.Text = "a";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.label8.Location = new System.Drawing.Point(167, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 38);
            this.label8.TabIndex = 16;
            this.label8.Text = "z";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PizOrd.Properties.Resources.arrow21;
            this.pictureBox2.Location = new System.Drawing.Point(183, 407);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizOrd.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(162, 505);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPiz
            // 
            this.pictureBoxPiz.Image = global::PizOrd.Properties.Resources.mainLa;
            this.pictureBoxPiz.Location = new System.Drawing.Point(56, 88);
            this.pictureBoxPiz.Name = "pictureBoxPiz";
            this.pictureBoxPiz.Size = new System.Drawing.Size(345, 306);
            this.pictureBoxPiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPiz.TabIndex = 7;
            this.pictureBoxPiz.TabStop = false;
            this.pictureBoxPiz.Click += new System.EventHandler(this.pictureBoxPiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(209)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(457, 596);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxPiz);
            this.Controls.Add(this.orderPizButton);
            this.Controls.Add(this.showPizButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.comboBoxSelP);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion





        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox comboBoxSelP;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showPizButton;
        private System.Windows.Forms.Button orderPizButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxPiz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

