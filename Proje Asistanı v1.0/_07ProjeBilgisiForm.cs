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
    public partial class _07ProjeBilgisiForm : Proje_Asistanı_v1._0._00AnaForm
    {
        string Ücret1S, Ücret2S;
        int Ücretİşçi, ÜcretUsta;

        #region Definitions


        __01DataAccessLayer DAL = new __01DataAccessLayer();
        FormStatusLayer FSL = new FormStatusLayer();
        ObjectColor OC = new ObjectColor();
        ObjectSize OS = new ObjectSize();
        ObjectLocation OL = new ObjectLocation();
        FormInPanelOpen FIPO = new FormInPanelOpen();
        ObjectText OT = new ObjectText();

       

        #endregion

        public _07ProjeBilgisiForm()
        {
            InitializeComponent();
        }

        private void BtnÜcretGöster_Click(object sender, EventArgs e)
        {
            try
            {
                int ProjeID = int.Parse(TextProjeNo.Text);

                DAL.ProjeİşçiToplamÜcret(ProjeID, ref Ücret1S);
                DAL.ProjeUstaToplamÜcret(ProjeID, ref Ücret2S);

                Ücretİşçi = Convert.ToInt32(Ücret1S);
                ÜcretUsta = Convert.ToInt32(Ücret2S);

                LblProjeNo.Text = ProjeID.ToString();
                LblİşçiÜcret.Text = Ücretİşçi + " TL";
                LblUstaÜcret.Text = ÜcretUsta + " TL";

                int Toplam = ÜcretUsta + Ücretİşçi;

                LblToplamÜcret.Text = Toplam + " TL";
            }
            catch (Exception)
            {
                
                throw;
            }
           


        
        }

        private void _07ProjeBilgisiForm_Load(object sender, EventArgs e)
        {

        }

    }
}
