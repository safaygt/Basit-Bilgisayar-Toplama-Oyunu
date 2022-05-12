
namespace DönemÖdevi
{
    partial class bestScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bestScores));
            this.txt_enler = new System.Windows.Forms.TextBox();
            this.btn_oku = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_enler
            // 
            this.txt_enler.Enabled = false;
            this.txt_enler.Location = new System.Drawing.Point(331, 71);
            this.txt_enler.Multiline = true;
            this.txt_enler.Name = "txt_enler";
            this.txt_enler.Size = new System.Drawing.Size(340, 256);
            this.txt_enler.TabIndex = 0;
            // 
            // btn_oku
            // 
            this.btn_oku.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oku.Location = new System.Drawing.Point(106, 133);
            this.btn_oku.Name = "btn_oku";
            this.btn_oku.Size = new System.Drawing.Size(108, 43);
            this.btn_oku.TabIndex = 1;
            this.btn_oku.Text = "Görüntüle";
            this.btn_oku.UseVisualStyleBackColor = true;
            this.btn_oku.Click += new System.EventHandler(this.btn_oku_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.Location = new System.Drawing.Point(106, 222);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(108, 44);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // bestScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_oku);
            this.Controls.Add(this.txt_enler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bestScores";
            this.Text = "bestScores";
            this.Load += new System.EventHandler(this.bestScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_enler;
        private System.Windows.Forms.Button btn_oku;
        private System.Windows.Forms.Button btn_update;
    }
}