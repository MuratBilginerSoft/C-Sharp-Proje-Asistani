using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GistwayZenon;


namespace Proje_Asistanı_v1._0
{
    public partial class _03AdminForm : Proje_Asistanı_v1._0._00AnaForm
    {
        #region Definitions

       
        __01DataAccessLayer DAL = new __01DataAccessLayer();
        FormStatusLayer FSL = new FormStatusLayer();
        ObjectColor OC = new ObjectColor();
        ObjectSize OS = new ObjectSize();
        ObjectLocation OL = new ObjectLocation();
        FormInPanelOpen FIPO = new FormInPanelOpen();
        ObjectText OT = new ObjectText();

        #endregion

        public _03AdminForm()
        {
            InitializeComponent();
        }

        private void _03AdminForm_Load(object sender, EventArgs e)
        {
            TimerSaat.Start();
            FSL.FormMaximize(this);

            #region Yönetici Bilgileri Yazdırma

            PicAdminPic.BackgroundImage= Image.FromFile(_02GirisForm.Picture);
            LblAdminName.Text = _02GirisForm.Names;

            #endregion
        }

        private void TimerSaat_Tick(object sender, EventArgs e)
        {
            LblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void PanelAnaSayfa_Click(object sender, EventArgs e)
        {
            _04AnaSayfaForm AnaSayfaFormX = new _04AnaSayfaForm();
            FIPO.FormInPanelOpenX(PanelForm, AnaSayfaFormX);
            OT.ObjectTextChangedX(LblDurum, "Ana Sayfa");
        }

        private void PanelPersonelEkle_Click(object sender, EventArgs e)
        {
            _05PersonelEkleForm PersonelEkleX = new _05PersonelEkleForm();
            FIPO.FormInPanelOpenX(PanelForm, PersonelEkleX);
            OT.ObjectTextChangedX(LblDurum, "Personel Ekle");
        }

        private void PanelPersonelBilgisi_Click(object sender, EventArgs e)
        {
            _06PersonelBilgisiForm PersonelBilgisiFormX = new _06PersonelBilgisiForm();
            FIPO.FormInPanelOpenX(PanelForm, PersonelBilgisiFormX);
            OT.ObjectTextChangedX(LblDurum, "Personel Bilgisi");
        }

        private void PanelProjeBilgisi_Click(object sender, EventArgs e)
        {
            _07ProjeBilgisiForm ProjeBilgisiFormX = new _07ProjeBilgisiForm();
            FIPO.FormInPanelOpenX(PanelForm, ProjeBilgisiFormX);
            OT.ObjectTextChangedX(LblDurum, "Proje Bilgisi");
        }

        private void PanelProjeEkle_Click(object sender, EventArgs e)
        {
            _08ProjeEkleForm ProjeEkleFormX = new _08ProjeEkleForm();
            FIPO.FormInPanelOpenX(PanelForm, ProjeEkleFormX);
            OT.ObjectTextChangedX(LblDurum, "Proje Ekle");
        }

        private void PanelProjeAtama_Click(object sender, EventArgs e)
        {
            _09ProjeAtamaForm ProjeAtamaFormX = new _09ProjeAtamaForm();
            FIPO.FormInPanelOpenX(PanelForm, ProjeAtamaFormX);
            OT.ObjectTextChangedX(LblDurum, "Proje Atama");
        }

        
    }
}
