using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GistwayZenon;
using System.Collections;

namespace Proje_Asistanı_v1._0
{
    public partial class _09ProjeAtamaForm : Proje_Asistanı_v1._0._00AnaForm
    {


        #region Parameters

        int MüsaitFİşçisi, MüsaitTİşçisi;

        int ProjeNumarası2, GörevSüresi, İşçiSayısı;

        int GörevNumarası;

        int FUsta, Fİşçi, TUsta, Tİşçi;

        int ProjeNumarası, PersonelNumarası, ProjeGün, ÜcretToplam;
       
        DateTime ProjeBaşlangıç, ProjeBitiş,ProjeBaşlagıç2;

        DateTime EndüşükTarih, EnYüksekTarih;

        TimeSpan GünFark;

        int İşçiDöngü;

        string İşçiDöngüX;

        int ProjeNumarasıD, PersonelNumarasıD;

        DateTime GörevBaşlangıçD, GörevBitişD, ProjeBaşlangıçD;

        int GörevİsmiD;

        int ÜcretD;

        #endregion

        #region Definitions


        __01DataAccessLayer DAL = new __01DataAccessLayer();
        FormStatusLayer FSL = new FormStatusLayer();
        ObjectColor OC = new ObjectColor();
        ObjectSize OS = new ObjectSize();
        ObjectLocation OL = new ObjectLocation();
        FormInPanelOpen FIPO = new FormInPanelOpen();
        ObjectText OT = new ObjectText();

        ArrayList AtanacakProje = new ArrayList();
         

        #endregion

        public _09ProjeAtamaForm()
        {
            InitializeComponent();
        }

        private void _09ProjeAtamaForm_Load(object sender, EventArgs e)
        {
            //DAL.AtanacakProjeGün(N,GridAtanacakGün);

            DAL.ÜcretlendirmeVeri(GridÜcretlendirme);

            int Index4 = GridÜcretlendirme.Rows.Count;

            FUsta = Convert.ToInt32(GridÜcretlendirme.Rows[0].Cells["Ücret"].Value);
            Fİşçi = Convert.ToInt32(GridÜcretlendirme.Rows[1].Cells["Ücret"].Value);
            TUsta = Convert.ToInt32(GridÜcretlendirme.Rows[2].Cells["Ücret"].Value);
            Tİşçi = Convert.ToInt32(GridÜcretlendirme.Rows[3].Cells["Ücret"].Value);

            DAL.EDTSPBG(GridEnDüşükTarih);
            DAL.EYTSPBG(GridEnYüksekTarih);

            EndüşükTarih = Convert.ToDateTime(GridEnDüşükTarih.Rows[0].Cells["ProjeBaşlangıçTarihi"].Value);
            EnYüksekTarih = Convert.ToDateTime(GridEnYüksekTarih.Rows[0].Cells["ProjeBitişTarihi"].Value);
            ProjeBaşlagıç2 = EndüşükTarih;
            GünFark = EnYüksekTarih - EndüşükTarih;
            İşçiDöngüX = GünFark.Days.ToString();
            İşçiDöngü = Convert.ToInt32(İşçiDöngüX);
            ProjeBaşlangıçD = ProjeBaşlagıç2;

           

        }

        private void BtnAtanacakProjeGör_Click(object sender, EventArgs e)
        {
            DAL.AtanacakProjeGöster(DataGridAtama);

            int Index2 = DataGridAtama.Rows.Count;

            for (int i = 0; i < Index2 - 1; i++)
            {
                CheckedAtamaProje.Items.Add(DataGridAtama.Rows[i].Cells["ProjeNumarası"].Value.ToString());
            }

        }

        private void BtnAtanacakGörevler_Click(object sender, EventArgs e)
        {
            DAL.AtanacakGörevGöster(N,GridGörevAtama);
        }

        private void BtnUstaAta_Click(object sender, EventArgs e)
        {
            try
            {
                AtanacakProje.Clear();

                DAL.AtanacakProjeGün(N,GridProjeUsta);
                DAL.AtanacakProjeGün(N,GridAtanacakGün);

                int Index1 = GridAtanacakGün.Rows.Count;

                for (int i = 0; i < Index1 - 1; i++)
                {
                    AtanacakProje.Add(GridAtanacakGün.Rows[i].Cells["ProjeNumarası"].Value);
                }

                int Index5 = Index1 - 1;

                for (int i = 0; i < Index1 - 1; i++)
                {
                    DAL.MüsaitFirmaUstası(N,GridFirmaUsta);
                    DAL.MüsaitTaşeronUstası(N,GridTaşeronUsta);

                    int Index2 = GridFirmaUsta.Rows.Count; // 3
                    int Index3 = GridTaşeronUsta.Rows.Count; // 3


                    if (Index2 >= Index5)
                    {
                        ProjeNumarası = Convert.ToInt32(AtanacakProje[i].ToString());
                        PersonelNumarası = Convert.ToInt32(GridFirmaUsta.Rows[0].Cells["PersonelNumarası"].Value);
                        ProjeGün = Convert.ToInt32(GridAtanacakGün.Rows[i].Cells["ProjeGün"].Value);
                        ÜcretToplam = FUsta * ProjeGün;

                        ProjeBaşlangıç = Convert.ToDateTime(GridAtanacakGün.Rows[i].Cells["ProjeBaşlangıçTarihi"].Value);
                        ProjeBitiş = Convert.ToDateTime(GridAtanacakGün.Rows[i].Cells["ProjeBitişTarihi"].Value);
                        DAL.ProjeUstaEkle(ProjeNumarası, PersonelNumarası, ProjeGün, ÜcretToplam);

                        DAL.PersonelBilgisiGüncelle(PersonelNumarası, ProjeBaşlangıç, ProjeBitiş);


                        Index5--;
                    }

                    else
                    {
                        ProjeNumarası = Convert.ToInt32(AtanacakProje[i].ToString());
                        PersonelNumarası = Convert.ToInt32(GridTaşeronUsta.Rows[0].Cells["PersonelNumarası"].Value);
                        ProjeGün = Convert.ToInt32(GridAtanacakGün.Rows[i].Cells["ProjeGün"].Value);
                        ÜcretToplam = TUsta * ProjeGün;

                        ProjeBaşlangıç = Convert.ToDateTime(GridAtanacakGün.Rows[i].Cells["ProjeBaşlangıçTarihi"].Value);
                        ProjeBitiş = Convert.ToDateTime(GridAtanacakGün.Rows[i].Cells["ProjeBitişTarihi"].Value);
                        DAL.ProjeUstaEkle(ProjeNumarası, PersonelNumarası, ProjeGün, ÜcretToplam);

                        DAL.PersonelBilgisiGüncelle(PersonelNumarası, ProjeBaşlangıç, ProjeBitiş);
                    } 

                }

                DAL.ProjeUstaGöster(N,GridProjeUsta);
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }

           

        }

      

        private void BtnİşçiAtama_Click_1(object sender, EventArgs e)
        {

            int Index6 = GridGörevAtama.Rows.Count; // 7

            for (int i = 0; i < İşçiDöngü; i++) // 19
            {

                ProjeNumarası2 = Convert.ToInt32(GridGörevAtama.Rows[0].Cells["ProjeNumarası"].Value);
                string ProjeNo = Convert.ToString(ProjeNumarası2);
                DAL.PersonelDurumGüncelle(ProjeNo[0].ToString());


                for (int j = 0; j < Index6 - 1; j++) // 6
                {

                    if (Convert.ToDateTime(GridGörevAtama.Rows[j].Cells["GörevBaslangic"].Value) <= ProjeBaşlagıç2 && ProjeBaşlagıç2 <= Convert.ToDateTime(GridGörevAtama.Rows[j].Cells["GorevBitis"].Value))
                    {
                        ProjeNumarası2 = Convert.ToInt32(GridGörevAtama.Rows[j].Cells["ProjeNumarası"].Value);
                        GörevNumarası = Convert.ToInt32(GridGörevAtama.Rows[j].Cells["Görevİsmi"].Value);
                        İşçiSayısı = Convert.ToInt32(GridGörevAtama.Rows[j].Cells["IsciSayisi"].Value); //3

                        for (int x = 0; x < İşçiSayısı; x++)
                        {
                            DAL.MüsaitFirmaİşçisi(N,GridMüsaitFirmaİşçisi, GörevNumarası);
                            DAL.MüsaitTaşeronİşçisi(N,GridMüsaitTaşeronİşçisi, GörevNumarası);

                            MüsaitFİşçisi = GridMüsaitFirmaİşçisi.Rows.Count;
                            MüsaitTİşçisi = GridMüsaitTaşeronİşçisi.Rows.Count;


                            if (MüsaitFİşçisi - 1 >= 1)
                            {
                                ProjeNumarasıD = ProjeNumarası2;
                                PersonelNumarasıD = Convert.ToInt32(GridMüsaitFirmaİşçisi.Rows[0].Cells["PersonelNumarası"].Value);
                                GörevİsmiD = GörevNumarası;
                                GörevBaşlangıçD = ProjeBaşlagıç2;
                                GörevBitişD = ProjeBaşlagıç2.AddDays(1);
                                ÜcretD = Fİşçi;

                                DAL.GörevDağılımEkle(ProjeNumarasıD, PersonelNumarasıD, GörevİsmiD, GörevBaşlangıçD, GörevBitişD, ÜcretD);

                                DAL.PersonelBilgisiGüncelle(PersonelNumarasıD, GörevBaşlangıçD, GörevBitişD);


                            }

                            else if (MüsaitTİşçisi - 1 >= 1)
                            {
                                ProjeNumarasıD = ProjeNumarası2;
                                PersonelNumarasıD = Convert.ToInt32(GridMüsaitTaşeronİşçisi.Rows[0].Cells["PersonelNumarası"].Value);
                                GörevİsmiD = GörevNumarası;
                                GörevBaşlangıçD = ProjeBaşlagıç2;
                                GörevBitişD = ProjeBaşlagıç2.AddDays(1);
                                ÜcretD = Tİşçi;

                                DAL.GörevDağılımEkle(ProjeNumarasıD, PersonelNumarasıD, GörevİsmiD, GörevBaşlangıçD, GörevBitişD, ÜcretD);

                                DAL.PersonelBilgisiGüncelle(PersonelNumarasıD, GörevBaşlangıçD, GörevBitişD);

                            }

                            else
                            {
                                MessageBox.Show("Yeterli Personel Yok " + i);
                                break;
                            }
                        }
                    }
                }

                ProjeBaşlagıç2 = ProjeBaşlagıç2.AddDays(1);
                //DAL.PersonelBilgisiGetir(GridPersonel);
               
            }

            DAL.GörevDağılımıTümVeriler(GridİşciAtama);
        }

        string N,N2="";

        int Z = 0;

        private void buttonX1_Click(object sender, EventArgs e)
        {
            int YY = CheckedAtamaProje.CheckedItems.Count;
           
            

            for ( Z = 0; Z <= YY-1; Z++)
            {
                N = CheckedAtamaProje.CheckedItems[Z].ToString()[0].ToString();

                if (Z!=0)
                {
                    if (N!=N2)
                    {
                        MessageBox.Show("Farklı Birimlere Ait Proje Seçtiniz");
                        BtnAtanacakGörevler.Enabled = false;
                        break;
                    }
                }

                N2 = N;
            }

            if (Z == YY)
            {
                DAL.ProjeBilgiŞart(N, GridAtanacakProje);
                BtnAtanacakGörevler.Enabled = true;
            }
            
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DAL.Temizle();
        }

    
    }
}
