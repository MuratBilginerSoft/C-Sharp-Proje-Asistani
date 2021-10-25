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
    public partial class _08ProjeEkleForm : Proje_Asistanı_v1._0._00AnaForm
    {

        #region Parameters

        string ProjeGünS;
        TimeSpan ProjeGünT;
        int ProjeGünI;
        int Index1;
        string OlumluİşçiX;
        int Olumluİşçi;
        int ProjeNum,ProjeDurum,GörevDurumu;
        string ProjeAdı;
        DateTime ProjeBaslangic, ProjeBitis;

       
        int GünSayisi, İşçiSayisi;
        int GörevNumarası;

        DateTime GörevBaşlangıç, GörevBitiş;

        TimeSpan PlanlananGün;

        #endregion

        #region Definitions

        __01DataAccessLayer DAL = new __01DataAccessLayer();

        ObjectText OT = new ObjectText();
        ObjectColor OC = new ObjectColor();

        #endregion

        public _08ProjeEkleForm()
        {
            InitializeComponent();
        }

        private void BtnProjeEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                ProjeNum = int.Parse(TextProjeNum.Text);
                ProjeAdı = TextProjeAdı.Text;
                ProjeBaslangic = DateBaslangic.Value;
                ProjeBitis = DateBitis.Value;
                ProjeDurum = 0;

                ProjeGünT = ProjeBitis - ProjeBaslangic;
                ProjeGünS = ProjeGünT.Days.ToString();
                ProjeGünI = Convert.ToInt32(ProjeGünS);
                
                DAL.ProjeBilgisiEkle(ProjeNum, ProjeAdı, ProjeBaslangic, ProjeBitis, ProjeDurum, ProjeGünI);
               
                ProjeBaslangic = ProjeBaslangic.AddDays(-1);
                GroupProjeDetay.Visible = true;
                GroupListe.Visible = true;
                GroupProjeBilgi.Visible = true;

                TextProjeNum2.Text = TextProjeNum.Text;
                TextProjeAdi2.Text = TextProjeAdı.Text;

                ComboGörev.DataSource = DAL.YetenekVeri(ComboGörev).DataSource;
                ComboGörev.DisplayMember = "YetenekAdi";

                OC.ObjectXChangeColor(PanelFooter, Color.DeepSkyBlue);
                OC.ObjectXChangeColor(LblDurum, Color.Transparent);
                OT.ObjectTextChangedX(LblDurum, "Kayıt İşlemi Başarılı");

                PlanlananGün = ProjeBitis - ProjeBaslangic.AddDays(-1);

                LblPlanlanacakGün.Text = PlanlananGün.Days.ToString();


                if (PlanlananGün.Days > 0)
                {
                    ComboGörev.Enabled = true;
                    NumericGün.Enabled = true;
                    Numericİşçi.Enabled = true;
                }

                DAL.ProjeBilgiGetir(DataGridProje);
            }
            catch (Exception)
            {
                OC.ObjectXChangeColor(PanelFooter, Color.Red);
                OC.ObjectXChangeColor(LblDurum, Color.Transparent);
                OT.ObjectTextChangedX(LblDurum, "Kayır İşlemi Başarılı Değil");

            }
        }

        private void _08ProjeEkleForm_Load(object sender, EventArgs e)
        {
            GroupProjeDetay.Visible = false;
            GroupListe.Visible = false;
            GroupProjeBilgi.Visible = false;
        }

        private void BtnDetayEkle_Click_1(object sender, EventArgs e)
        {
            try
            {

                GörevNumarası = Convert.ToInt32(ComboGörev.SelectedIndex) + 1;
                GünSayisi = Convert.ToInt32(NumericGün.Value);
                İşçiSayisi = Convert.ToInt32(Numericİşçi.Value);
                GörevDurumu = 0;
                

                GörevBaşlangıç = ProjeBaslangic;
                GörevBitiş = ProjeBaslangic.AddDays(GünSayisi - 1);
                ProjeBaslangic = GörevBitiş.AddDays(1);
               
                DAL.ProjeDetayEkle(ProjeNum, GörevNumarası, GünSayisi, İşçiSayisi, GörevBaşlangıç, GörevBitiş, GörevDurumu);
               

                OC.ObjectXChangeColor(PanelFooter, Color.DeepSkyBlue);
                OC.ObjectXChangeColor(LblDurum, Color.Transparent);
                OT.ObjectTextChangedX(LblDurum, "Kayıt İşlemi Başarılı");

                DAL.ProjeDetayData(ProjeNum, GridProje);
               

                PlanlananGün = ProjeBitis - GörevBitiş;
                LblPlanlanacakGün.Text = PlanlananGün.Days.ToString();

                if (PlanlananGün.Days == 0)
                {
                    ComboGörev.Enabled = false;
                    NumericGün.Enabled = false;
                    Numericİşçi.Enabled = false;
                }

            }
            catch (Exception)
            {

                OC.ObjectXChangeColor(PanelFooter, Color.Red);
                OC.ObjectXChangeColor(LblDurum, Color.Transparent);
                OT.ObjectTextChangedX(LblDurum, "Kayır İşlemi Başarılı Değil");
            }
        }

        private void ComboGörev_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index1 = ComboGörev.SelectedIndex + 1;

            DAL.OlumluİşçiSayısıGetir(Index1, ref OlumluİşçiX);

            Olumluİşçi = Convert.ToInt32(OlumluİşçiX);

            LblYetenekGrubu.Text = ComboGörev.Text + " İşçi Sayısı";

            LblOlumluİşçi.Text = Olumluİşçi.ToString();

            if (Olumluİşçi == 0)
            {
                LblBilgi.Text = ComboGörev.Text + " İşini Yapabilecek Hiç İşçi Yok Öncelikle İşçi Kaydını Gerçekleştiriniz";
                NumericGün.Enabled = false;
                Numericİşçi.Enabled = false;

            }

            else
            {

                NumericGün.Maximum = Convert.ToInt32(PlanlananGün.Days);
                Numericİşçi.Maximum = Olumluİşçi;
                NumericGün.Enabled = true;
                Numericİşçi.Enabled = true;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                ProjeNum = int.Parse(TextProjeNum.Text);
                ProjeAdı = TextProjeAdı.Text;
                ProjeBaslangic = DateBaslangic.Value;
                ProjeBitis = DateBitis.Value;

                ProjeGünT = ProjeBitis - ProjeBaslangic;
                ProjeGünS = ProjeGünT.Days.ToString();
                ProjeGünI = Convert.ToInt32(ProjeGünS);

                DAL.ProjeBilgiGüncelle(ProjeNum, ProjeAdı, ProjeBaslangic, ProjeBitis, ProjeGünI);

                MessageBox.Show("Güncelleme İşlemi Başarılı");

                PlanlananGün = ProjeBitis - ProjeBaslangic.AddDays(-1);

                LblPlanlanacakGün.Text = PlanlananGün.Days.ToString();


                if (PlanlananGün.Days > 0)
                {
                    ComboGörev.Enabled = true;
                    NumericGün.Enabled = true;
                    Numericİşçi.Enabled = true;
                }

                DAL.ProjeBilgiGetir(DataGridProje);

                GroupProjeDetay.Visible = true;
                GroupListe.Visible = true;
                GroupProjeBilgi.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız");
            }
           

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                ProjeNum = int.Parse(TextProjeNum.Text);
                DAL.ProjeBilgiSil(ProjeNum);
                DAL.ProjeBilgiGetir(DataGridProje);

                GroupProjeDetay.Visible = true;
                GroupListe.Visible = true;
                GroupProjeBilgi.Visible = true;

                MessageBox.Show("Silme İşlemi Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Başarısız");
               
            }
           
        }

        private void DataGridProje_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextProjeNum.Text = DataGridProje.CurrentRow.Cells[0].Value.ToString();
            TextProjeAdı.Text = DataGridProje.CurrentRow.Cells[1].Value.ToString();
            DateBaslangic.Value = Convert.ToDateTime(DataGridProje.CurrentRow.Cells[2].Value);
            DateBitis.Value = Convert.ToDateTime(DataGridProje.CurrentRow.Cells[3].Value);

            ProjeNum = int.Parse(TextProjeNum.Text);
            ProjeAdı = TextProjeAdı.Text;
            ProjeBaslangic = DateBaslangic.Value;
            ProjeBitis = DateBitis.Value;

            PlanlananGün = ProjeBitis - ProjeBaslangic.AddDays(-1);

            LblPlanlanacakGün.Text = PlanlananGün.Days.ToString();

            DAL.ProjeDetayData(ProjeNum, GridProje);
        }

        private void GridProje_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NumericGün.Maximum = 10000;
            Numericİşçi.Maximum = 10000;
            TextProjeNum2.Text = GridProje.CurrentRow.Cells[0].Value.ToString();
            int ComGörev=Convert.ToInt32(GridProje.CurrentRow.Cells[1].Value);
            ComboGörev.SelectedItem = ComGörev-1;
            NumericGün.Value = Convert.ToInt32(GridProje.CurrentRow.Cells[2].Value);
            Numericİşçi.Value = Convert.ToInt32(GridProje.CurrentRow.Cells[3].Value);
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {
                int ProjeNum2 = Convert.ToInt32(TextProjeNum2.Text);
                int Görevİsmi2 = ComboGörev.SelectedIndex - 1;

                DAL.ProjeDetaySil(ProjeNum2, Görevİsmi2);

                MessageBox.Show("Silme İşlemi Başarılı");

                DAL.ProjeDetayData(ProjeNum2, GridProje);
            }
            catch (Exception)
            {

                MessageBox.Show("Silme İşlemi Başarılı Değil");
            }
           

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                ProjeNum=Convert.ToInt32(TextProjeNum2.Text);
                GörevNumarası = Convert.ToInt32(ComboGörev.SelectedIndex) + 1;
                GünSayisi = Convert.ToInt32(NumericGün.Value);
                İşçiSayisi = Convert.ToInt32(Numericİşçi.Value);

                GörevBaşlangıç = ProjeBaslangic;
                GörevBitiş = ProjeBaslangic.AddDays(GünSayisi - 1);
                ProjeBaslangic = GörevBitiş.AddDays(1);


                DAL.ProjeDetayGüncelle(ProjeNum, GörevNumarası, GünSayisi, İşçiSayisi, GörevBaşlangıç, GörevBitiş);

                MessageBox.Show("Güncelleme Başarılı");

                DAL.ProjeDetayData(ProjeNum, GridProje);
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme Başarısız");
            }
           

        }

       
      
    }
}
