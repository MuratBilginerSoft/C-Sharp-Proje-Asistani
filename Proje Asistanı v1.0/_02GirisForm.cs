using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GistwayZenon;

namespace Proje_Asistanı_v1._0
{
    public partial class _02GirisForm : Proje_Asistanı_v1._0._00AnaForm
    {
        #region Parameters

        int Result = 0;

        string UserName, Password;

        string P1;

        static public string PersonelNo, Names, Authority, Picture;

        #endregion

        #region Definitions

        FormStatusLayer FSL = new FormStatusLayer();
        ObjectColor OC = new ObjectColor();
        ObjectSize OS = new ObjectSize();
        ObjectLocation OL = new ObjectLocation();

        __01DataAccessLayer DAL = new __01DataAccessLayer();

        ObjectText OT = new ObjectText();

        #endregion

        #region Form İşlemleri

        public _02GirisForm()
        {
            InitializeComponent();
        }

        private void _02GirisForm_Load(object sender, EventArgs e)
        {
            FSL.FormMaximize(this);
            TimerSaat.Start();
        }

        private void TimerSaat_Tick(object sender, EventArgs e)
        {
            LblSaat.Text = DateTime.Now.ToLongTimeString();
            LblTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void PicEye_MouseHover(object sender, EventArgs e)
        {
            TextPassword.PasswordChar = '\0';
            OC.ObjectXChangeColor((PictureBox)sender, Color.Yellow);    
        }

        private void PicEye_MouseLeave(object sender, EventArgs e)
        {
            TextPassword.PasswordChar = '*';
            OC.ObjectXNormalChange((PictureBox)sender, Color.White);
        }

        private void _02GirisForm_Shown(object sender, EventArgs e)
        {
            //TextUserName.Clear();
            //TextPassword.Clear();
        }

        private void PicMinus_Click(object sender, EventArgs e)
        {
            FSL.FormMinimize(this);
        }

        private void TextUserName_TextChanged(object sender, EventArgs e)
        {
            OC.ObjectXChangeColor(PanelFooter, Color.Transparent);
            OT.ObjectTextChangedX(LblDurum, "Status");
        }

        #endregion

        private void BtnLoginX_Click(object sender, EventArgs e)
        {
            //try
            //{
                UserName = TextUserName.Text;
                Password = TextPassword.Text;

                Result = 0;

                Result = int.Parse(DAL.GirisKontrol(UserName, Password, ref P1));

                DAL.YoneticiBilgisi(UserName, Password, ref PersonelNo, ref Names, ref Authority, ref Picture);


                if (Result > 0)
                {
                    TimerSaat.Stop();

                    _03AdminForm AdminFormX = new _03AdminForm();
                    FSL.FormShowAndHide(this, AdminFormX);
                }

                else
                {
                    OC.ObjectXChangeColor(PanelFooter, Color.DeepSkyBlue);
                    OT.ObjectTextChangedX(LblDurum, "Kullanıcı Adınız veya Şifreniz Yanlıştır");

                    //TextUserName.Clear();
                    //TextPassword.Clear();
                }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
    }
}
