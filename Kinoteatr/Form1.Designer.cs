
namespace Kinoteatr
{
    partial class Kinoteatr
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.newKonsertBtn = new System.Windows.Forms.Button();
            this.deleteKonsertBtn = new System.Windows.Forms.Button();
            this.kinoteatrTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yaratilgan konsertlar";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 35;
            this.listBox1.Location = new System.Drawing.Point(18, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 354);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // newKonsertBtn
            // 
            this.newKonsertBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.newKonsertBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newKonsertBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.newKonsertBtn.Location = new System.Drawing.Point(336, 171);
            this.newKonsertBtn.Name = "newKonsertBtn";
            this.newKonsertBtn.Size = new System.Drawing.Size(323, 143);
            this.newKonsertBtn.TabIndex = 2;
            this.newKonsertBtn.Text = "Yangi konsert yaratish";
            this.newKonsertBtn.UseVisualStyleBackColor = false;
            this.newKonsertBtn.Click += new System.EventHandler(this.newKonsertBtn_Click);
            // 
            // deleteKonsertBtn
            // 
            this.deleteKonsertBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteKonsertBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteKonsertBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteKonsertBtn.Location = new System.Drawing.Point(336, 379);
            this.deleteKonsertBtn.Name = "deleteKonsertBtn";
            this.deleteKonsertBtn.Size = new System.Drawing.Size(323, 146);
            this.deleteKonsertBtn.TabIndex = 3;
            this.deleteKonsertBtn.Text = "Tanlangan konsertni\r\no\'chirish";
            this.deleteKonsertBtn.UseVisualStyleBackColor = false;
            this.deleteKonsertBtn.Click += new System.EventHandler(this.deleteKonsertBtn_Click);
            // 
            // kinoteatrTxt
            // 
            this.kinoteatrTxt.AutoSize = true;
            this.kinoteatrTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kinoteatrTxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.kinoteatrTxt.Location = new System.Drawing.Point(153, 9);
            this.kinoteatrTxt.Name = "kinoteatrTxt";
            this.kinoteatrTxt.Size = new System.Drawing.Size(369, 78);
            this.kinoteatrTxt.TabIndex = 4;
            this.kinoteatrTxt.Text = "KINOTEATR";
            // 
            // Kinoteatr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 537);
            this.Controls.Add(this.kinoteatrTxt);
            this.Controls.Add(this.deleteKonsertBtn);
            this.Controls.Add(this.newKonsertBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Kinoteatr";
            this.Text = "Kinoteatr";
            this.Load += new System.EventHandler(this.Kinoteatr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button newKonsertBtn;
        private System.Windows.Forms.Button deleteKonsertBtn;
        private System.Windows.Forms.Label kinoteatrTxt;
    }
}

