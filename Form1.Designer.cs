﻿namespace WindowsFormsApp1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.blot_defect_button = new System.Windows.Forms.Button();
            this.vertical_defect_button = new System.Windows.Forms.Button();
            this.horizontal_defect_button = new System.Windows.Forms.Button();
            this.ETC_defect_button = new System.Windows.Forms.Button();
            this.dark_defect_button = new System.Windows.Forms.Button();
            this.bright_defect_button = new System.Windows.Forms.Button();
            this.s_grade_button = new System.Windows.Forms.Button();
            this.e_grade_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.origin_image_Box = new System.Windows.Forms.PictureBox();
            this.virtual_image_Box = new System.Windows.Forms.PictureBox();
            this.result_image_Box = new System.Windows.Forms.PictureBox();
            this.defect_Listview = new System.Windows.Forms.ListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.login_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.origin_image_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtual_image_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_image_Box)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.blot_defect_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.vertical_defect_button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.horizontal_defect_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ETC_defect_button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dark_defect_button, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bright_defect_button, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.s_grade_button, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.e_grade_button, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1331, 685);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // blot_defect_button
            // 
            this.blot_defect_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blot_defect_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blot_defect_button.Location = new System.Drawing.Point(3, 3);
            this.blot_defect_button.Name = "blot_defect_button";
            this.blot_defect_button.Size = new System.Drawing.Size(178, 103);
            this.blot_defect_button.TabIndex = 0;
            this.blot_defect_button.Text = "污渍mura";
            this.blot_defect_button.UseVisualStyleBackColor = true;
            // 
            // vertical_defect_button
            // 
            this.vertical_defect_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vertical_defect_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.vertical_defect_button.Location = new System.Drawing.Point(187, 3);
            this.vertical_defect_button.Name = "vertical_defect_button";
            this.vertical_defect_button.Size = new System.Drawing.Size(179, 103);
            this.vertical_defect_button.TabIndex = 1;
            this.vertical_defect_button.Text = "竖-条纹";
            this.vertical_defect_button.UseVisualStyleBackColor = true;
            // 
            // horizontal_defect_button
            // 
            this.horizontal_defect_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontal_defect_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.horizontal_defect_button.Location = new System.Drawing.Point(372, 3);
            this.horizontal_defect_button.Name = "horizontal_defect_button";
            this.horizontal_defect_button.Size = new System.Drawing.Size(180, 103);
            this.horizontal_defect_button.TabIndex = 2;
            this.horizontal_defect_button.Text = "横-条纹";
            this.horizontal_defect_button.UseVisualStyleBackColor = true;
            // 
            // ETC_defect_button
            // 
            this.ETC_defect_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ETC_defect_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.ETC_defect_button.Location = new System.Drawing.Point(3, 112);
            this.ETC_defect_button.Name = "ETC_defect_button";
            this.ETC_defect_button.Size = new System.Drawing.Size(178, 103);
            this.ETC_defect_button.TabIndex = 3;
            this.ETC_defect_button.Text = "ETC";
            this.ETC_defect_button.UseVisualStyleBackColor = true;
            // 
            // dark_defect_button
            // 
            this.dark_defect_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dark_defect_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.dark_defect_button.Location = new System.Drawing.Point(187, 112);
            this.dark_defect_button.Name = "dark_defect_button";
            this.dark_defect_button.Size = new System.Drawing.Size(179, 103);
            this.dark_defect_button.TabIndex = 4;
            this.dark_defect_button.Text = "暗团";
            this.dark_defect_button.UseVisualStyleBackColor = true;
            // 
            // bright_defect_button
            // 
            this.bright_defect_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bright_defect_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.bright_defect_button.Location = new System.Drawing.Point(372, 112);
            this.bright_defect_button.Name = "bright_defect_button";
            this.bright_defect_button.Size = new System.Drawing.Size(180, 103);
            this.bright_defect_button.TabIndex = 5;
            this.bright_defect_button.Text = "亮团";
            this.bright_defect_button.UseVisualStyleBackColor = true;
            // 
            // s_grade_button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.s_grade_button, 2);
            this.s_grade_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s_grade_button.Font = new System.Drawing.Font("微软雅黑", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.s_grade_button.ForeColor = System.Drawing.Color.ForestGreen;
            this.s_grade_button.Location = new System.Drawing.Point(187, 221);
            this.s_grade_button.Name = "s_grade_button";
            this.s_grade_button.Size = new System.Drawing.Size(365, 103);
            this.s_grade_button.TabIndex = 6;
            this.s_grade_button.Text = "S";
            this.s_grade_button.UseVisualStyleBackColor = true;
            this.s_grade_button.Click += new System.EventHandler(this.button7_Click);
            // 
            // e_grade_button
            // 
            this.e_grade_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.e_grade_button.Font = new System.Drawing.Font("微软雅黑", 26F, System.Drawing.FontStyle.Bold);
            this.e_grade_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.e_grade_button.Location = new System.Drawing.Point(3, 221);
            this.e_grade_button.Name = "e_grade_button";
            this.e_grade_button.Size = new System.Drawing.Size(178, 103);
            this.e_grade_button.TabIndex = 7;
            this.e_grade_button.Text = "E";
            this.e_grade_button.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.43757F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.56243F));
            this.tableLayoutPanel2.Controls.Add(this.origin_image_Box, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.virtual_image_Box, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.result_image_Box, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1874, 667);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // origin_image_Box
            // 
            this.origin_image_Box.BackColor = System.Drawing.Color.Black;
            this.origin_image_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.origin_image_Box.Location = new System.Drawing.Point(3, 3);
            this.origin_image_Box.Name = "origin_image_Box";
            this.tableLayoutPanel2.SetRowSpan(this.origin_image_Box, 2);
            this.origin_image_Box.Size = new System.Drawing.Size(1314, 661);
            this.origin_image_Box.TabIndex = 0;
            this.origin_image_Box.TabStop = false;
            // 
            // virtual_image_Box
            // 
            this.virtual_image_Box.BackColor = System.Drawing.Color.DarkGreen;
            this.virtual_image_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.virtual_image_Box.Location = new System.Drawing.Point(1323, 3);
            this.virtual_image_Box.Name = "virtual_image_Box";
            this.virtual_image_Box.Size = new System.Drawing.Size(548, 327);
            this.virtual_image_Box.TabIndex = 1;
            this.virtual_image_Box.TabStop = false;
            // 
            // result_image_Box
            // 
            this.result_image_Box.BackColor = System.Drawing.SystemColors.Info;
            this.result_image_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_image_Box.Location = new System.Drawing.Point(1323, 336);
            this.result_image_Box.Name = "result_image_Box";
            this.result_image_Box.Size = new System.Drawing.Size(548, 328);
            this.result_image_Box.TabIndex = 2;
            this.result_image_Box.TabStop = false;
            // 
            // defect_Listview
            // 
            this.defect_Listview.HideSelection = false;
            this.defect_Listview.Location = new System.Drawing.Point(167, 685);
            this.defect_Listview.Name = "defect_Listview";
            this.defect_Listview.Size = new System.Drawing.Size(1162, 324);
            this.defect_Listview.TabIndex = 3;
            this.defect_Listview.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.progressBar1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.login_button, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(15, 688);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(146, 321);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 282);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(140, 36);
            this.progressBar1.TabIndex = 0;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.SandyBrown;
            this.login_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.login_button.Location = new System.Drawing.Point(3, 189);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(140, 87);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "用户登录";
            this.login_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.defect_Listview);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.origin_image_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtual_image_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_image_Box)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button blot_defect_button;
        private System.Windows.Forms.Button vertical_defect_button;
        private System.Windows.Forms.Button horizontal_defect_button;
        private System.Windows.Forms.Button ETC_defect_button;
        private System.Windows.Forms.Button dark_defect_button;
        private System.Windows.Forms.Button bright_defect_button;
        private System.Windows.Forms.Button s_grade_button;
        private System.Windows.Forms.Button e_grade_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox origin_image_Box;
        private System.Windows.Forms.PictureBox virtual_image_Box;
        private System.Windows.Forms.PictureBox result_image_Box;
        private System.Windows.Forms.ListView defect_Listview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button login_button;
    }
}
