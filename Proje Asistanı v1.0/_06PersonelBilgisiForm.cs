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
    public partial class _06PersonelBilgisiForm : Proje_Asistanı_v1._0._00AnaForm
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

        DateTime Tarih;

        public _06PersonelBilgisiForm()
        {
            InitializeComponent();
        }

        private void _06PersonelBilgisiForm_Load(object sender, EventArgs e)
        {
            DAL.PersonelBilgisiGetir(DataGridPersonel);
        }

        private void DataGridPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tarih = dateTimePicker1.Value;

            int PersonelNo = Convert.ToInt32(DataGridPersonel.CurrentRow.Cells[0].Value.ToString());
            LblPersonelNo.Text = DataGridPersonel.CurrentRow.Cells[0].Value.ToString();
            Lblİsim.Text = DataGridPersonel.CurrentRow.Cells[1].Value.ToString() + " " + DataGridPersonel.CurrentRow.Cells[2].Value.ToString();
            LblİşçiStatü.Text=DataGridPersonel.CurrentRow.Cells[3].Value.ToString();
            LblYorgunluk.Text = "% " + DataGridPersonel.CurrentRow.Cells[6].Value.ToString();
            LblÜcret.Text = DataGridPersonel.CurrentRow.Cells[4].Value.ToString() + " TL";

            DAL.PersonelDurumuX(PersonelNo, Tarih, DataGridPersonelX);

            int XXX = DataGridPersonelX.Rows.Count;

            if (XXX==1)
            {
                LblDurum2.Text = "MÜSAİT";
            }

            else if(XXX>1)
            {
                LblProjeİsmi.Text = DataGridPersonelX.Rows[0].Cells[0].Value.ToString();
                LblİşeBaşlangıç.Text = DataGridPersonelX.Rows[0].Cells[3].Value.ToString();
                LblİşBitiş.Text = DataGridPersonelX.Rows[0].Cells[4].Value.ToString();
                LblDurum2.Text = "ÇALIŞIYOR";
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Tarih = dateTimePicker1.Value;

            int PersonelNo = Convert.ToInt32(DataGridPersonel.CurrentRow.Cells[0].Value.ToString());
            LblPersonelNo.Text = DataGridPersonel.CurrentRow.Cells[0].Value.ToString();
            Lblİsim.Text = DataGridPersonel.CurrentRow.Cells[1].Value.ToString() + " " + DataGridPersonel.CurrentRow.Cells[2].Value.ToString();
            LblİşçiStatü.Text = DataGridPersonel.CurrentRow.Cells[3].Value.ToString();
            LblYorgunluk.Text = "% " + DataGridPersonel.CurrentRow.Cells[6].Value.ToString();
            LblÜcret.Text = DataGridPersonel.CurrentRow.Cells[4].Value.ToString() + " TL";

            DAL.PersonelDurumuX(PersonelNo, Tarih, DataGridPersonelX);

            int XXX = DataGridPersonelX.Rows.Count;

            if (XXX == 1)
            {
                LblProjeİsmi.Text = "";
                LblİşeBaşlangıç.Text = "";
                LblİşBitiş.Text = "";
                LblDurum2.Text = "MÜSAİT";

            }

            else if (XXX > 1)
            {
                LblProjeİsmi.Text = DataGridPersonelX.Rows[0].Cells[0].Value.ToString();
                LblİşeBaşlangıç.Text = DataGridPersonelX.Rows[0].Cells[4].Value.ToString();
                LblİşBitiş.Text = DataGridPersonelX.Rows[0].Cells[5].Value.ToString();
                LblDurum2.Text = "ÇALIŞIYOR";
            }
        }

       
    }
}
