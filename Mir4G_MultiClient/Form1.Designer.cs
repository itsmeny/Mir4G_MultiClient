
namespace Mir4G_MultiClient
{
    partial class Form1
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
            this.refresh_btn = new System.Windows.Forms.Button();
            this.processView = new System.Windows.Forms.ListView();
            this.pid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.win_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.file_arguments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.file_path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.เรยกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ปดToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new_client_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.client_idx = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(857, 12);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 1;
            this.refresh_btn.Text = "+ รีเฟรช";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // processView
            // 
            this.processView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pid,
            this.win_title,
            this.file_arguments,
            this.file_path});
            this.processView.ContextMenuStrip = this.menu;
            this.processView.FullRowSelect = true;
            this.processView.GridLines = true;
            this.processView.HideSelection = false;
            this.processView.Location = new System.Drawing.Point(12, 41);
            this.processView.MultiSelect = false;
            this.processView.Name = "processView";
            this.processView.Size = new System.Drawing.Size(1001, 245);
            this.processView.TabIndex = 2;
            this.processView.UseCompatibleStateImageBehavior = false;
            this.processView.View = System.Windows.Forms.View.Details;
            // 
            // pid
            // 
            this.pid.Text = "Process Id";
            this.pid.Width = 100;
            // 
            // win_title
            // 
            this.win_title.Text = "Window Title";
            this.win_title.Width = 90;
            // 
            // file_arguments
            // 
            this.file_arguments.Text = "File Path";
            this.file_arguments.Width = 400;
            // 
            // file_path
            // 
            this.file_path.Text = "Arguments";
            this.file_path.Width = 400;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เรยกToolStripMenuItem,
            this.ปดToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(134, 48);
            this.menu.Opening += new System.ComponentModel.CancelEventHandler(this.menu_Opening);
            // 
            // เรยกToolStripMenuItem
            // 
            this.เรยกToolStripMenuItem.Name = "เรยกToolStripMenuItem";
            this.เรยกToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.เรยกToolStripMenuItem.Text = "เรียกหน้าจอนี้";
            this.เรยกToolStripMenuItem.Click += new System.EventHandler(this.เรยกToolStripMenuItem_Click);
            // 
            // ปดToolStripMenuItem
            // 
            this.ปดToolStripMenuItem.Name = "ปดToolStripMenuItem";
            this.ปดToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ปดToolStripMenuItem.Text = "ปิดหน้าจอนี้";
            this.ปดToolStripMenuItem.Click += new System.EventHandler(this.ปดToolStripMenuItem_Click);
            // 
            // new_client_btn
            // 
            this.new_client_btn.Location = new System.Drawing.Point(938, 12);
            this.new_client_btn.Name = "new_client_btn";
            this.new_client_btn.Size = new System.Drawing.Size(75, 23);
            this.new_client_btn.TabIndex = 5;
            this.new_client_btn.Text = "+ เพิ่มจอ";
            this.new_client_btn.UseVisualStyleBackColor = true;
            this.new_client_btn.Click += new System.EventHandler(this.new_client_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ClientIndex: ";
            // 
            // client_idx
            // 
            this.client_idx.Location = new System.Drawing.Point(73, 12);
            this.client_idx.Name = "client_idx";
            this.client_idx.Size = new System.Drawing.Size(57, 20);
            this.client_idx.TabIndex = 8;
            this.client_idx.Text = "0";
            this.client_idx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 298);
            this.Controls.Add(this.client_idx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_client_btn);
            this.Controls.Add(this.processView);
            this.Controls.Add(this.refresh_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mir4G MultiClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.ListView processView;
        private System.Windows.Forms.ColumnHeader pid;
        private System.Windows.Forms.ColumnHeader win_title;
        private System.Windows.Forms.ColumnHeader file_path;
        private System.Windows.Forms.ColumnHeader file_arguments;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem เรยกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ปดToolStripMenuItem;
        private System.Windows.Forms.Button new_client_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox client_idx;
    }
}

