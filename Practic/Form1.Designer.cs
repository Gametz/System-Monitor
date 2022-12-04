namespace Practic
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
            this.reload = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updtime = new System.Windows.Forms.Label();
            this.biostime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proglist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reload
            // 
            this.reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reload.Location = new System.Drawing.Point(616, 373);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(88, 24);
            this.reload.TabIndex = 0;
            this.reload.Text = "Обновить";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.time.Location = new System.Drawing.Point(12, 328);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 16);
            this.time.TabIndex = 1;
            this.time.Text = "Время сеанса:";
            this.time.Click += new System.EventHandler(this.reload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Информация о системе";
            // 
            // updtime
            // 
            this.updtime.AutoSize = true;
            this.updtime.Location = new System.Drawing.Point(12, 416);
            this.updtime.Name = "updtime";
            this.updtime.Size = new System.Drawing.Size(106, 13);
            this.updtime.TabIndex = 4;
            this.updtime.Text = "Время обновления:";
            // 
            // biostime
            // 
            this.biostime.AutoSize = true;
            this.biostime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.biostime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biostime.Location = new System.Drawing.Point(12, 136);
            this.biostime.Name = "biostime";
            this.biostime.Size = new System.Drawing.Size(20, 16);
            this.biostime.TabIndex = 3;
            this.biostime.Text = "inf";
            this.biostime.Click += new System.EventHandler(this.biostime_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // proglist
            // 
            this.proglist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proglist.Location = new System.Drawing.Point(473, 373);
            this.proglist.Name = "proglist";
            this.proglist.Size = new System.Drawing.Size(117, 24);
            this.proglist.TabIndex = 6;
            this.proglist.Text = "Список программ";
            this.proglist.UseVisualStyleBackColor = true;
            this.proglist.Click += new System.EventHandler(this.proglist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(758, 438);
            this.Controls.Add(this.proglist);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updtime);
            this.Controls.Add(this.biostime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.reload);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Информация о системе";
            this.Load += new System.EventHandler(this.reload_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label updtime;
        private System.Windows.Forms.Label biostime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button proglist;
    }
}

