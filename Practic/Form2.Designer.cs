namespace Practic
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.activeb = new System.Windows.Forms.Button();
            this.installedb = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.close = new System.Windows.Forms.Button();
            this.prog = new System.Windows.Forms.Label();
            this.active = new System.Windows.Forms.ListBox();
            this.installed = new System.Windows.Forms.ListBox();
            this.reload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activeb
            // 
            this.activeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.activeb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.activeb.Location = new System.Drawing.Point(13, 13);
            this.activeb.Name = "activeb";
            this.activeb.Size = new System.Drawing.Size(162, 23);
            this.activeb.TabIndex = 0;
            this.activeb.Text = "Запущенные";
            this.activeb.UseVisualStyleBackColor = true;
            this.activeb.Click += new System.EventHandler(this.activeb_Click);
            // 
            // installedb
            // 
            this.installedb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.installedb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.installedb.Location = new System.Drawing.Point(181, 12);
            this.installedb.Name = "installedb";
            this.installedb.Size = new System.Drawing.Size(148, 23);
            this.installedb.TabIndex = 1;
            this.installedb.Text = "Установленные";
            this.installedb.UseVisualStyleBackColor = true;
            this.installedb.Click += new System.EventHandler(this.installedb_Click);
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.close.Location = new System.Drawing.Point(266, 387);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(63, 21);
            this.close.TabIndex = 2;
            this.close.Text = "Назад";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // prog
            // 
            this.prog.AutoSize = true;
            this.prog.Location = new System.Drawing.Point(21, 391);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(54, 13);
            this.prog.TabIndex = 4;
            this.prog.Text = "Programm";
            this.prog.Click += new System.EventHandler(this.prog_Click);
            // 
            // active
            // 
            this.active.FormattingEnabled = true;
            this.active.Location = new System.Drawing.Point(13, 42);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(316, 329);
            this.active.TabIndex = 5;
            // 
            // installed
            // 
            this.installed.FormattingEnabled = true;
            this.installed.Location = new System.Drawing.Point(13, 42);
            this.installed.Name = "installed";
            this.installed.Size = new System.Drawing.Size(316, 329);
            this.installed.TabIndex = 6;
            this.installed.Visible = false;
            // 
            // reload
            // 
            this.reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reload.Location = new System.Drawing.Point(197, 387);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(63, 21);
            this.reload.TabIndex = 7;
            this.reload.Text = "Обновить";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(341, 420);
            this.ControlBox = false;
            this.Controls.Add(this.reload);
            this.Controls.Add(this.installed);
            this.Controls.Add(this.active);
            this.Controls.Add(this.prog);
            this.Controls.Add(this.close);
            this.Controls.Add(this.installedb);
            this.Controls.Add(this.activeb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Список программ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button activeb;
        private System.Windows.Forms.Button installedb;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label prog;
        private System.Windows.Forms.ListBox active;
        private System.Windows.Forms.ListBox installed;
        private System.Windows.Forms.Button reload;
    }
}