namespace Proje_Asistanı_v1._0
{
    partial class _02GirisForm
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
            this.PicLogoAna = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnLoginX = new DevComponents.DotNetBar.ButtonX();
            this.TextUserName = new System.Windows.Forms.TextBox();
            this.PicEye = new System.Windows.Forms.PictureBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.PicUser = new System.Windows.Forms.PictureBox();
            this.PicKey = new System.Windows.Forms.PictureBox();
            this.LblTarih = new System.Windows.Forms.Label();
            this.LblSaat = new System.Windows.Forms.Label();
            this.PicMinus = new System.Windows.Forms.PictureBox();
            this.TimerSaat = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PanelGövde.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.PanelBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoAna)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMinus)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelGövde
            // 
            this.PanelGövde.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelGövde.BackgroundImage = global::Proje_Asistanı_v1._0.Properties.Resources._01_Arka_Plan;
            this.PanelGövde.Controls.Add(this.label1);
            this.PanelGövde.Controls.Add(this.LblTarih);
            this.PanelGövde.Controls.Add(this.LblSaat);
            this.PanelGövde.Controls.Add(this.panel3);
            this.PanelGövde.Controls.Add(this.PicLogoAna);
            this.PanelGövde.Controls.SetChildIndex(this.PanelBanner, 0);
            this.PanelGövde.Controls.SetChildIndex(this.PanelFooter, 0);
            this.PanelGövde.Controls.SetChildIndex(this.PicLogoAna, 0);
            this.PanelGövde.Controls.SetChildIndex(this.panel3, 0);
            this.PanelGövde.Controls.SetChildIndex(this.LblSaat, 0);
            this.PanelGövde.Controls.SetChildIndex(this.LblTarih, 0);
            this.PanelGövde.Controls.SetChildIndex(this.label1, 0);
            // 
            // PanelBanner
            // 
            this.PanelBanner.Controls.Add(this.PicMinus);
            this.PanelBanner.Location = new System.Drawing.Point(227, 0);
            this.PanelBanner.Size = new System.Drawing.Size(926, 49);
            this.PanelBanner.Controls.SetChildIndex(this.PicClose, 0);
            this.PanelBanner.Controls.SetChildIndex(this.PicMinus, 0);
            // 
            // PicClose
            // 
            this.PicClose.Location = new System.Drawing.Point(895, 12);
            // 
            // PicLogoAna
            // 
            this.PicLogoAna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicLogoAna.BackColor = System.Drawing.Color.Transparent;
            this.PicLogoAna.Image = global::Proje_Asistanı_v1._0.Properties.Resources._02_Proje_Asistanı_Logo;
            this.PicLogoAna.Location = new System.Drawing.Point(378, 105);
            this.PicLogoAna.Name = "PicLogoAna";
            this.PicLogoAna.Size = new System.Drawing.Size(401, 153);
            this.PicLogoAna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogoAna.TabIndex = 38;
            this.PicLogoAna.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.BtnLoginX);
            this.panel3.Controls.Add(this.TextUserName);
            this.panel3.Controls.Add(this.PicEye);
            this.panel3.Controls.Add(this.TextPassword);
            this.panel3.Controls.Add(this.PicUser);
            this.panel3.Controls.Add(this.PicKey);
            this.panel3.Location = new System.Drawing.Point(378, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 206);
            this.panel3.TabIndex = 39;
            // 
            // BtnLoginX
            // 
            this.BtnLoginX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnLoginX.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnLoginX.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLoginX.Location = new System.Drawing.Point(103, 130);
            this.BtnLoginX.Name = "BtnLoginX";
            this.BtnLoginX.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.BtnLoginX.Size = new System.Drawing.Size(244, 45);
            this.BtnLoginX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnLoginX.TabIndex = 18;
            this.BtnLoginX.Text = "GİRİŞ";
            this.BtnLoginX.TextColor = System.Drawing.Color.Black;
            this.BtnLoginX.Click += new System.EventHandler(this.BtnLoginX_Click);
            // 
            // TextUserName
            // 
            this.TextUserName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextUserName.Location = new System.Drawing.Point(103, 26);
            this.TextUserName.Multiline = true;
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(245, 40);
            this.TextUserName.TabIndex = 14;
            this.TextUserName.Text = "Murat Bilginer";
            this.TextUserName.TextChanged += new System.EventHandler(this.TextUserName_TextChanged);
            // 
            // PicEye
            // 
            this.PicEye.BackColor = System.Drawing.Color.White;
            this.PicEye.Image = global::Proje_Asistanı_v1._0.Properties.Resources._06_Göz;
            this.PicEye.Location = new System.Drawing.Point(311, 74);
            this.PicEye.Name = "PicEye";
            this.PicEye.Size = new System.Drawing.Size(35, 35);
            this.PicEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicEye.TabIndex = 17;
            this.PicEye.TabStop = false;
            this.PicEye.MouseLeave += new System.EventHandler(this.PicEye_MouseLeave);
            this.PicEye.MouseHover += new System.EventHandler(this.PicEye_MouseHover);
            // 
            // TextPassword
            // 
            this.TextPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextPassword.Location = new System.Drawing.Point(103, 72);
            this.TextPassword.Multiline = true;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(245, 40);
            this.TextPassword.TabIndex = 16;
            this.TextPassword.Text = "12345";
            this.TextPassword.TextChanged += new System.EventHandler(this.TextUserName_TextChanged);
            // 
            // PicUser
            // 
            this.PicUser.BackColor = System.Drawing.Color.Transparent;
            this.PicUser.Image = global::Proje_Asistanı_v1._0.Properties.Resources._04_User;
            this.PicUser.Location = new System.Drawing.Point(52, 26);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(45, 40);
            this.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUser.TabIndex = 11;
            this.PicUser.TabStop = false;
            // 
            // PicKey
            // 
            this.PicKey.BackColor = System.Drawing.Color.Transparent;
            this.PicKey.Image = global::Proje_Asistanı_v1._0.Properties.Resources._05_Kilit;
            this.PicKey.Location = new System.Drawing.Point(52, 72);
            this.PicKey.Name = "PicKey";
            this.PicKey.Size = new System.Drawing.Size(45, 40);
            this.PicKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicKey.TabIndex = 13;
            this.PicKey.TabStop = false;
            // 
            // LblTarih
            // 
            this.LblTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTarih.AutoSize = true;
            this.LblTarih.BackColor = System.Drawing.Color.Transparent;
            this.LblTarih.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTarih.ForeColor = System.Drawing.Color.Black;
            this.LblTarih.Location = new System.Drawing.Point(12, 504);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(213, 58);
            this.LblTarih.TabIndex = 41;
            this.LblTarih.Text = "00:00:00";
            // 
            // LblSaat
            // 
            this.LblSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblSaat.AutoSize = true;
            this.LblSaat.BackColor = System.Drawing.Color.Transparent;
            this.LblSaat.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSaat.ForeColor = System.Drawing.Color.Black;
            this.LblSaat.Location = new System.Drawing.Point(12, 432);
            this.LblSaat.Name = "LblSaat";
            this.LblSaat.Size = new System.Drawing.Size(213, 58);
            this.LblSaat.TabIndex = 40;
            this.LblSaat.Text = "00:00:00";
            // 
            // PicMinus
            // 
            this.PicMinus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMinus.BackColor = System.Drawing.Color.Transparent;
            this.PicMinus.Image = global::Proje_Asistanı_v1._0.Properties.Resources.appbar_minus__2_;
            this.PicMinus.Location = new System.Drawing.Point(864, 12);
            this.PicMinus.Name = "PicMinus";
            this.PicMinus.Size = new System.Drawing.Size(25, 25);
            this.PicMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMinus.TabIndex = 42;
            this.PicMinus.TabStop = false;
            this.PicMinus.Click += new System.EventHandler(this.PicMinus_Click);
            // 
            // TimerSaat
            // 
            this.TimerSaat.Tick += new System.EventHandler(this.TimerSaat_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "GİRİŞ PANELİ";
            // 
            // _02GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1156, 618);
            this.Name = "_02GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this._02GirisForm_Load);
            this.Shown += new System.EventHandler(this._02GirisForm_Shown);
            this.PanelGövde.ResumeLayout(false);
            this.PanelGövde.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            this.PanelFooter.PerformLayout();
            this.PanelBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoAna)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMinus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogoAna;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextUserName;
        private System.Windows.Forms.PictureBox PicEye;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.PictureBox PicUser;
        private System.Windows.Forms.PictureBox PicKey;
        private System.Windows.Forms.Label LblTarih;
        private System.Windows.Forms.Label LblSaat;
        private System.Windows.Forms.PictureBox PicMinus;
        private System.Windows.Forms.Timer TimerSaat;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX BtnLoginX;
    }
}
