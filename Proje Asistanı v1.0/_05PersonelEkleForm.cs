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
    public partial class _05PersonelEkleForm : Proje_Asistanı_v1._0._00AnaForm
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

        #region Parameters

        int Index1 = 0, Index2=0, Index3=0, Index4=0;

        int PersonelNo, YetenekNo, İşçiTürü,Durum,Yorgunluk;

        string PersonelNoX, YetenekNoX, İşçiTürüNoX,PersonelAdi, PersonelSoyadi;

        DateTime İşBaşlangıç = Convert.ToDateTime("01.01.1975");
        DateTime İşBitiş = Convert.ToDateTime("01.01.1975");

        #endregion

        public _05PersonelEkleForm()
        {
            InitializeComponent();
        }

        private void _05PersonelEkleForm_Load(object sender, EventArgs e)
        {
            ComboIsciTuru.DataSource = DAL.ÜcretlendirmeVeri(ComboIsciTuru).DataSource;

            Index1=ComboIsciTuru.Items.Count;

            ComboIsciTuru.DisplayMember = "İşçiStatü";

            DAL.YetenekVeri(DataGridYetenek);

            Index2 = DataGridYetenek.Rows.Count;

            for (int i = 0; i < Index2-1; i++)
            {
                CheckListYetenek.Items.Add(DataGridYetenek.Rows[i].Cells["YetenekAdi"].Value.ToString());
            }


            DAL.PersonelBilgisiGetir(DataGridPersonel);

            DAL.ÜcretBilgisiGetir(DataGridÜcretlendirme);

        }

        private void BtnPersonelEkleX_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelNo = int.Parse(TextPersonelNo.Text);
                PersonelAdi = TextPersonelAdi.Text;
                PersonelSoyadi = TextPersonelSoyadi.Text;

                İşBaşlangıç = Convert.ToDateTime("01.01.1975");
                İşBitiş = Convert.ToDateTime("01.01.1975");

                Durum = 0;

                Yorgunluk = 0;

                Index3 = CheckListYetenek.CheckedItems.Count;

                for (int i = 0; i < Index3; i++)
                {
                    DAL.YetenekNoGetir(CheckListYetenek.CheckedItems[i].ToString(), ref YetenekNoX);
                    YetenekNo = int.Parse(YetenekNoX);
                    DAL.PersonelYetenekEkle(PersonelNo, YetenekNo);
                }


                DAL.IsciTuruNoGetir(ComboIsciTuru.Text, ref İşçiTürüNoX);
                İşçiTürü = Convert.ToInt32(İşçiTürüNoX);

                DAL.PersonelBilgisiEkle(PersonelNo, PersonelAdi, PersonelSoyadi, İşçiTürü, Durum, İşBaşlangıç, İşBitiş, Yorgunluk);

                OC.ObjectXChangeColor(PanelFooter, Color.DeepSkyBlue);
                OT.ObjectTextChangedX(LblDurum, "Personel Kaydedilmiştir");

                DAL.PersonelBilgisiGetir(DataGridPersonel);
            }
            catch (Exception)
            {
                OC.ObjectXChangeColor(PanelFooter, Color.Red);
                OT.ObjectTextChangedX(LblDurum, "Personel Kaydedilemedi!!!");
            }
        }

        private void BtnPersonelGüncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                DAL.YetenekSil(Convert.ToInt32(TextPersonelNo.Text));

                Index3 = CheckListYetenek.CheckedItems.Count;

                for (int i = 0; i < Index3; i++)
                {

                    DAL.YetenekNoGetir(CheckListYetenek.CheckedItems[i].ToString(), ref YetenekNoX);
                    YetenekNo = int.Parse(YetenekNoX);
                    DAL.PersonelYetenekEkle(Convert.ToInt32(TextPersonelNo.Text), YetenekNo);
                }

                int d1 = 0;

                if (ComboIsciTuru.Text == "Firmanın Ustası")
                {
                    d1 = 1;
                }

                else if (ComboIsciTuru.Text == "Firmanın İşcisi")
                {
                    d1 = 2;
                }

                else if (ComboIsciTuru.Text == "Taşeron Usta")
                {
                    d1 = 3;
                }

                else if (ComboIsciTuru.Text == "Taşeron İşçi")
                {
                    d1 = 4;
                }

                DAL.PersonelGüncelle(Convert.ToInt32(TextPersonelNo.Text), TextPersonelAdi.Text, TextPersonelSoyadi.Text, d1);

                MessageBox.Show("Güncelleme İşlemi Başarılı");

                DAL.PersonelBilgisiGetir(DataGridPersonel);
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme İşlemi Başarılı Olamadı");
            }
        }

        private void BtnPersonelSil_Click_1(object sender, EventArgs e)
        {
            DAL.PersonelSil(Convert.ToInt32(TextPersonelNo.Text));
            DAL.YetenekSil(Convert.ToInt32(TextPersonelNo.Text));
            DAL.PersonelBilgisiGetir(DataGridPersonel);
        }

        private void DataGridPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < CheckListYetenek.Items.Count - 1; i++)
            {
                CheckListYetenek.SetItemChecked(i, false);
            }


            DAL.PersonelYetenekGetir(Convert.ToInt32(DataGridPersonel.CurrentRow.Cells[0].Value.ToString()), DataGridYetenek2);

            TextPersonelNo.Text = DataGridPersonel.CurrentRow.Cells[0].Value.ToString();
            TextPersonelAdi.Text = DataGridPersonel.CurrentRow.Cells[1].Value.ToString();
            TextPersonelSoyadi.Text = DataGridPersonel.CurrentRow.Cells[2].Value.ToString();
            ComboIsciTuru.Text = "";
            ComboIsciTuru.SelectedText = DataGridPersonel.CurrentRow.Cells[3].Value.ToString();

            int XX = DataGridYetenek2.Rows.Count;

            for (int i = 0; i < XX - 1; i++)
            {
                CheckListYetenek.SetItemChecked(Convert.ToInt32(DataGridYetenek2.Rows[i].Cells[0].Value) - 1, true);
            }
        }

        private void DataGridÜcretlendirme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextÜcretNo.Text = DataGridÜcretlendirme.CurrentRow.Cells[0].Value.ToString();
            TextStatü.Text = DataGridÜcretlendirme.CurrentRow.Cells[1].Value.ToString();
            TextÜcret.Text = DataGridÜcretlendirme.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                DAL.ÜcretBirimiEkle(Convert.ToInt32(TextÜcretNo.Text), TextStatü.Text, Convert.ToInt32(TextÜcret.Text));
                MessageBox.Show("Ekleme İşlemi Başarılı");

                DAL.ÜcretBilgisiGetir(DataGridÜcretlendirme);
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme İşlemi Başarılı Değil");
               
            }
           

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                DAL.ÜcretBİrimiGüncelle(Convert.ToInt32(TextÜcretNo.Text), TextStatü.Text, Convert.ToInt32(TextÜcret.Text));
                MessageBox.Show("Güncelleme İşlemi Başarılı");

                DAL.ÜcretBilgisiGetir(DataGridÜcretlendirme);
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme İşlemi Başarılı Değil");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                DAL.ÜcretBirimiSil(Convert.ToInt32(TextÜcretNo.Text));
                MessageBox.Show("Başarıyla Silindi");

                DAL.ÜcretBilgisiGetir(DataGridÜcretlendirme);
            }
            catch (Exception)
            {

                MessageBox.Show("Silme İşlemi Gerçekleştirilemedi");
            }
           
        }
    }
}
