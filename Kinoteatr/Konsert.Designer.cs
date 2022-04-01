
namespace Kinoteatr
{
    partial class Konsert
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
            this.kondertNameTxt = new System.Windows.Forms.Label();
            this.biletSoniTxt = new System.Windows.Forms.Label();
            this.sotilganBiletlarTxt = new System.Windows.Forms.Label();
            this.vaqtitxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // kondertNameTxt
            // 
            this.kondertNameTxt.AutoSize = true;
            this.kondertNameTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kondertNameTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.kondertNameTxt.Location = new System.Drawing.Point(12, 9);
            this.kondertNameTxt.Name = "kondertNameTxt";
            this.kondertNameTxt.Size = new System.Drawing.Size(196, 36);
            this.kondertNameTxt.TabIndex = 0;
            this.kondertNameTxt.Text = "Konset Nomi:";
            // 
            // biletSoniTxt
            // 
            this.biletSoniTxt.AutoSize = true;
            this.biletSoniTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biletSoniTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.biletSoniTxt.Location = new System.Drawing.Point(12, 70);
            this.biletSoniTxt.Name = "biletSoniTxt";
            this.biletSoniTxt.Size = new System.Drawing.Size(179, 36);
            this.biletSoniTxt.TabIndex = 1;
            this.biletSoniTxt.Text = "Biletlar Soni:";
            // 
            // sotilganBiletlarTxt
            // 
            this.sotilganBiletlarTxt.AutoSize = true;
            this.sotilganBiletlarTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sotilganBiletlarTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sotilganBiletlarTxt.Location = new System.Drawing.Point(12, 170);
            this.sotilganBiletlarTxt.Name = "sotilganBiletlarTxt";
            this.sotilganBiletlarTxt.Size = new System.Drawing.Size(229, 36);
            this.sotilganBiletlarTxt.TabIndex = 2;
            this.sotilganBiletlarTxt.Text = "Sotilgan Biletlar:";
            // 
            // vaqtitxt
            // 
            this.vaqtitxt.AutoSize = true;
            this.vaqtitxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vaqtitxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.vaqtitxt.Location = new System.Drawing.Point(12, 123);
            this.vaqtitxt.Name = "vaqtitxt";
            this.vaqtitxt.Size = new System.Drawing.Size(91, 36);
            this.vaqtitxt.TabIndex = 3;
            this.vaqtitxt.Text = "Vaqti:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "sotmoqchi bo\'lgan bilet raqamini kiriting:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(18, 416);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(190, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(18, 209);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(528, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Sotilgan biletlar mavjud emas!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "sotish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Konsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vaqtitxt);
            this.Controls.Add(this.sotilganBiletlarTxt);
            this.Controls.Add(this.biletSoniTxt);
            this.Controls.Add(this.kondertNameTxt);
            this.Name = "Konsert";
            this.Text = "Konsert";
            this.Load += new System.EventHandler(this.Konsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kondertNameTxt;
        private System.Windows.Forms.Label biletSoniTxt;
        private System.Windows.Forms.Label sotilganBiletlarTxt;
        private System.Windows.Forms.Label vaqtitxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}