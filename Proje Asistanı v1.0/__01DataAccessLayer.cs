using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Proje_Asistanı_v1._0
{
    public class __01DataAccessLayer
    {

        #region Definitions

        ___00ProjeAsistanıDataContext PDB = new ___00ProjeAsistanıDataContext();

        #endregion


        #region Select İşlemleri

        #region Giriş Kontrol 

        public string GirisKontrol(string X1, string X2, ref string X3)
        {
            PDB.SP_Giris(X1, X2, ref X3).ToString();
            return X3;
        }

        #endregion

        #region Yönetici Bilgilerini Alma

        public void YoneticiBilgisi(string X1, string X2, ref string X3, ref string X4, ref string X5, ref string X6)
        {
            PDB.SP_YoneticiBilgisi(X1, X2, ref X3, ref X4, ref X5, ref X6);
        }

        #endregion

        #region Ücretlendirme Bilgilerini Alma

        public ComboBox ÜcretlendirmeVeri(ComboBox CMB)
        {
            CMB.DataSource = PDB.SP_ÜcretlendirmeData();
            return CMB;
        
        }

        #region Ücretlendirme Bilgilerini Alma

        public void ÜcretlendirmeVeri(DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_ÜcretlendirmeData();
        }

        #endregion
        
        #endregion

        #region Yetenek Bilgilerini Alma

        public DataGridView YetenekVeri(DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_YetenekData();
            return DGV;
        
        }

        public ComboBox YetenekVeri(ComboBox CMB)
        {
            CMB.DataSource = PDB.SP_YetenekData();
            return CMB;
        
        }

        #endregion

        #region Yetenek No Bilgisini Getir

        public void YetenekNoGetir(string X1, ref string X2)
        {
            PDB.SP_YetenekNoGetir(X1, ref X2);
        }

        #endregion

        #region İşçi Türü No Getir

        public void IsciTuruNoGetir(string X1, ref string X2)
        {
            PDB.SP_IsciTürüNo(X1, ref X2);
        }

        #endregion

        #region Personel Bilgisi Getir

        public DataGridView PersonelBilgisiGetir(DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_PersonelBilgisi();
            return DGV;
        
        }

        #endregion

        #region Proje Detay Bilgisi Getir

        public DataGridView ProjeDetayData(int X1, DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_ProjeDetayData(X1);
            return DGV;
        }

        #endregion

        #region Olumlu İşçi Sayısı Getir

        public void OlumluİşçiSayısıGetir(int X1, ref string X2)
        {
            PDB.SP_OlumluİşçiSayısı(X1,ref X2);
        }

        #endregion

        #region Atanacak Proje

        public void AtanacakProjeGöster(DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_AtanacakProje();
        }

        #endregion

        #region Atanacak Görevler

        public void AtanacakGörevGöster(string X1, DataGridView DGV)
        {
            DGV.DataSource=PDB.SP_AtanacakGörevler(X1);
        }

        #endregion

        #region ProjeUstaGöster

        public void ProjeUstaGöster(string X1, DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_ProjeUstaGöster(X1);
        }

        #endregion

        #region Atanacak Proje Gün

        public void AtanacakProjeGün(string X1,DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_AtanacakProjeGün(X1);
        }

        #endregion

        #region Müsait Firma Ustası

        public void MüsaitFirmaUstası(string X1, DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_MüsaitFirmaUstaları(X1);
        }

        #endregion

        #region Müsait Taşeron Ustası

        public void MüsaitTaşeronUstası(string X1, DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_MüsaitTaşeronUstaları(X1);
        }

        #endregion

        #region En Düşük Tarih Sıralı Proje Bilgi Getir

        public void EDTSPBG(DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_EnDüşükTarih();
        
        }

        #endregion

        #region En Yüksek Tarih Sıralı Proje Bilgi Getir

        public void EYTSPBG(DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_EnYüksekTarih();
        }

        #endregion

        #region Müsait Firma İşçisi

        public void MüsaitFirmaİşçisi(string X2, DataGridView DGV,int X1)
        {
            DGV.DataSource = PDB.SP_MüsaitFirmaİşçisi(X1,X2);
        }

        #region Müsait Taşeron İşçisi

        public void MüsaitTaşeronİşçisi(string X2, DataGridView DGV, int X1)
        {
            DGV.DataSource = PDB.SP_MüsaitTaşeronİşçisi(X1,X2);
        }

        #endregion

        #endregion

        #region  GörevDağılımı Tüm Veriler

        public void GörevDağılımıTümVeriler(DataGridView DGV)
        {
           DGV.DataSource = PDB.SP_GörevDağılımıGetir();
        }

        #endregion

        #region Ücret Toplamı Getir Proje Bazlı

        public void ÜcretToplamıProjeBazlı(int X1, ref string X2)
        {
            PDB.SP_GörevDağılımıProjeBazlı(X1, ref X2);
        }

        #endregion

        #region Proje İşçi Toplam Ücret

        public void ProjeİşçiToplamÜcret(int X1, ref string X2)
        {
            PDB.SP_ProjeİşçiToplamÜcret(X1, ref X2);
        }

        #endregion

        #region Proje İşçi Toplam Ücret

        public void ProjeUstaToplamÜcret(int X1, ref string X2)
        {
            PDB.SP_ProjeUstaToplamÜcret(X1, ref X2);
        }

        #endregion

        #region Proje Sayısı

        public void ProjeSayısı(ref string X1, ref string X2, ref string X3)
        {
            PDB.SP_ProjeSayısı(ref X1, ref X2, ref X3);
        }

        #endregion

        #region Personel Yetenek Bilgisi Getir

        public void PersonelYetenekGetir(int X1, DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_PersonelYetenekGetir(X1);
        }

        #endregion

        #endregion

        #region Insert İşlemleri

        #region PersonelYetenek Ekle

        public void PersonelYetenekEkle(int X1, int X2)
        {
            PDB.SP_PersonelYetenekEkle(X1, X2);
        }

        #endregion

        #region Personel Bilgisi Ekle

        public void PersonelBilgisiEkle(int X1, string X2, string X3, int X4,int X5, DateTime X6, DateTime X7, int X8)
        {
            PDB.SP_PersonelBilgisiEkle(X1, X2, X3, X4, X5, X6, X7, X8);
        }

        #endregion

        #region Görev Dağılım Ekle

        public void GörevDağılımEkle(int X1, int X2, int X3, DateTime X4, DateTime X5, int X6)
        {
            PDB.SP_GörevDağılımıEkle(X1, X2, X3, X4, X5, X6);
        }

        #endregion

        #region Proje Bilgisi Ekle

        public void ProjeBilgisiEkle(int X1, string X2, DateTime X3, DateTime X4,int X5,int X6)
        {
            PDB.SP_ProjeBilgisiEkle(X1, X2, X3, X4, X5,X6);
        }

        #endregion

        #region Proje Detay Bilgisi Ekle


        public void ProjeDetayEkle(int X1, int X2, int X3, int X4, DateTime X5, DateTime X6,int X7)
        {
            PDB.SP_ProjeDetayEkle(X1, X2, X3, X4, X5, X6,X7);

        }

        #endregion


        #region Proje Usta Ata

        public void ProjeUstaEkle(int X1, int X2, int X3, int X4)
        {
            PDB.SP_ProjeUstaAta(X1, X2, X3, X4);
        }

        #endregion
        #endregion

        #region Update İşlemleri

        #region PersonelBilgisiGüncelle

        public void PersonelBilgisiGüncelle(int X1, DateTime X2, DateTime X3)
        {
            PDB.SP_PersonelDurumGüncelle(X1, X2, X3);
        }

        #endregion

        #region Personel Bilgisi Güncelle 2

        public void PersonelGüncelle(int X1, string X2, string X3, int X4)
        {
            PDB.SP_PersonelBilgisiGüncelle(X1, X2, X3, X4);
        }

        #endregion

        #region Personel Durum Güncelle

        public void PersonelDurumGüncelle(string X1)
        {
            PDB.SP_PersonelDurumGüncelle2(X1);

        }


        #endregion

        #endregion

        #region Silme İşlemleri

        public void YetenekSil(int X1)
        {
            PDB.SP_PersonelYetenekSil(X1);
        }

        #endregion

        public void PersonelSil(int X1)

        {
            PDB.SP_PersonelSil(X1);

        }



        #region ÜcretBİrimi

        public void ÜcretBilgisiGetir(DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_ÜcretBilgisiGetir();
        }

        public void ÜcretBirimiEkle(int X1, string X2, int X3)
        {
            PDB.SP_ÜcretBirimiEkle(X1, X2, X3);
        
        }

        public void ÜcretBİrimiGüncelle(int X1, string X2, int X3)
        {
            PDB.SP_ÜcretBirimiGüncelle(X1, X2, X3);
        }

        public void ÜcretBirimiSil(int X1)
        {
            PDB.SP_ÜcretBirimiSil(X1);
        }
        #endregion

        #region Proje Bilgi

        public void ProjeBilgiGüncelle(int X1, string X2, DateTime X3, DateTime X4, int X5)
        {
            PDB.SP_ProjeBilgiGüncelle(X1, X2, X3, X4, X5);
        }

        public void ProjeBilgiSil(int X1)
        {
            PDB.SP_ProjeBilgiSil(X1);
        }

        public void ProjeBilgiGetir(DataGridView DGV)
        {
            DGV.DataSource = PDB.SP_ProjeBilgiGetir();
         
        }

        #endregion

        #region Proje Detay

        public void ProjeDetaySil(int X1, int X2)
        {
            PDB.SP_ProjeDetaySil(X1, X2);
        
        }

        public void ProjeDetayGüncelle(int X1, int X2, int X3, int X4, DateTime X5, DateTime X6)
        {
            PDB.SP_ProjeDetayGüncelle(X1, X2, X3, X4, X5, X6);
        }


        #endregion


        public void ProjeBilgiŞart(string X1, DataGridView DGV)
        {
            DGV.DataSource= PDB.SP_ProjeBilgiŞart(X1);
        
        }

        public void PersonelDurumuX(int X1, DateTime X2, DataGridView DGV)
        {
           DGV.DataSource= PDB.SP_PersonelDurumuX(X1, X2);
        }

        public void Temizle()
        {
            PDB.Deneme();
        }
    }
}
