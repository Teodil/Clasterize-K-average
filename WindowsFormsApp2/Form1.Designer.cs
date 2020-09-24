namespace WindowsFormsApp2
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
            this.Generate = new System.Windows.Forms.Button();
            this.AnalizeBTN = new System.Windows.Forms.Button();
            this.PointAmount = new System.Windows.Forms.TextBox();
            this.ClasterAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartPoint = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.StartClasterLabel = new System.Windows.Forms.Label();
            this.StartClasterCoard = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(473, 12);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(136, 44);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Сгенерировать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // AnalizeBTN
            // 
            this.AnalizeBTN.Location = new System.Drawing.Point(833, 10);
            this.AnalizeBTN.Name = "AnalizeBTN";
            this.AnalizeBTN.Size = new System.Drawing.Size(94, 44);
            this.AnalizeBTN.TabIndex = 2;
            this.AnalizeBTN.Text = "Кластаризация";
            this.AnalizeBTN.UseVisualStyleBackColor = true;
            this.AnalizeBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // PointAmount
            // 
            this.PointAmount.Location = new System.Drawing.Point(615, 12);
            this.PointAmount.Name = "PointAmount";
            this.PointAmount.Size = new System.Drawing.Size(100, 20);
            this.PointAmount.TabIndex = 3;
            // 
            // ClasterAmount
            // 
            this.ClasterAmount.Location = new System.Drawing.Point(615, 38);
            this.ClasterAmount.Name = "ClasterAmount";
            this.ClasterAmount.Size = new System.Drawing.Size(100, 20);
            this.ClasterAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во наблюдений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во кластеров";
            // 
            // StartPoint
            // 
            this.StartPoint.AutoSize = true;
            this.StartPoint.Location = new System.Drawing.Point(470, 89);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(13, 13);
            this.StartPoint.TabIndex = 7;
            this.StartPoint.Text = "1";
            this.StartPoint.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // ClearBTN
            // 
            this.ClearBTN.Location = new System.Drawing.Point(933, 10);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(94, 44);
            this.ClearBTN.TabIndex = 9;
            this.ClearBTN.Text = "Очистить";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // StartClasterLabel
            // 
            this.StartClasterLabel.AutoSize = true;
            this.StartClasterLabel.Location = new System.Drawing.Point(85, 468);
            this.StartClasterLabel.Name = "StartClasterLabel";
            this.StartClasterLabel.Size = new System.Drawing.Size(58, 13);
            this.StartClasterLabel.TabIndex = 10;
            this.StartClasterLabel.Text = "Кластер 1";
            this.StartClasterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartClasterLabel.Visible = false;
            // 
            // StartClasterCoard
            // 
            this.StartClasterCoard.Location = new System.Drawing.Point(12, 484);
            this.StartClasterCoard.Name = "StartClasterCoard";
            this.StartClasterCoard.Size = new System.Drawing.Size(100, 20);
            this.StartClasterCoard.TabIndex = 11;
            this.StartClasterCoard.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 686);
            this.Controls.Add(this.StartClasterCoard);
            this.Controls.Add(this.StartClasterLabel);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StartPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClasterAmount);
            this.Controls.Add(this.PointAmount);
            this.Controls.Add(this.AnalizeBTN);
            this.Controls.Add(this.Generate);
            this.Name = "Form1";
            this.Text = "Кластаризатор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button AnalizeBTN;
        private System.Windows.Forms.TextBox PointAmount;
        private System.Windows.Forms.TextBox ClasterAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StartPoint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.Label StartClasterLabel;
        private System.Windows.Forms.TextBox StartClasterCoard;
    }
}

