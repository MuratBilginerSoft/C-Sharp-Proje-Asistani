namespace Proje_Asistanı_v1._0
{
    partial class _00AnaForm
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
            this.PanelGövde = new System.Windows.Forms.Panel();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.LblDurum = new System.Windows.Forms.Label();
            this.PanelBanner = new System.Windows.Forms.Panel();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.PanelGövde.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.PanelBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelGövde
            // 
            this.PanelGövde.BackColor = System.Drawing.SystemColors.Control;
            this.PanelGövde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelGövde.Controls.Add(this.PanelFooter);
            this.PanelGövde.Controls.Add(this.PanelBanner);
            this.PanelGövde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGövde.Location = new System.Drawing.Point(0, 0);
            this.PanelGövde.Name = "PanelGövde";
            this.PanelGövde.Size = new System.Drawing.Size(1156, 618);
            this.PanelGövde.TabIndex = 0;
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.Transparent;
            this.PanelFooter.Controls.Add(this.LblDurum);
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(0, 582);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(1156, 36);
            this.PanelFooter.TabIndex = 2;
            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDurum.ForeColor = System.Drawing.Color.Black;
            this.LblDurum.Location = new System.Drawing.Point(9, 8);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(47, 21);
            this.LblDurum.TabIndex = 0;
            this.LblDurum.Text = "Hazır";
            // 
            // PanelBanner
            // 
            this.PanelBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelBanner.BackColor = System.Drawing.Color.Transparent;
            this.PanelBanner.Controls.Add(this.PicClose);
            this.PanelBanner.Location = new System.Drawing.Point(224, 0);
            this.PanelBanner.Name = "PanelBanner";
            this.PanelBanner.Size = new System.Drawing.Size(929, 49);
            this.PanelBanner.TabIndex = 1;
            // 
            // PicClose
            // 
            this.PicClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PicClose.Image = global::Proje_Asistanı_v1._0.Properties.Resources.appbar_close__2_;
            this.PicClose.Location = new System.Drawing.Point(898, 9);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(25, 25);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClose.TabIndex = 3;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.PicClose_Click);
            // 
            // _00AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 618);
            this.Controls.Add(this.PanelGövde);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_00AnaForm";
            this.Text = "_00AnaForm";
            this.Load += new System.EventHandler(this._00AnaForm_Load);
            this.PanelGövde.ResumeLayout(false);
            this.PanelFooter.ResumeLayout(false);
            this.PanelFooter.PerformLayout();
            this.PanelBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel PanelGövde;
        protected System.Windows.Forms.Panel PanelFooter;
        protected System.Windows.Forms.Panel PanelBanner;
        protected System.Windows.Forms.PictureBox PicClose;
        protected System.Windows.Forms.Label LblDurum;
    }
}