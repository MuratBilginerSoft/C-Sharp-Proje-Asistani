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
    public partial class _04AnaSayfaForm : Proje_Asistanı_v1._0._00AnaForm
    {
        __01DataAccessLayer DAL = new __01DataAccessLayer();
        FormStatusLayer FSL = new FormStatusLayer();
        ObjectColor OC = new ObjectColor();
        ObjectSize OS = new ObjectSize();
        ObjectLocation OL = new ObjectLocation();
        FormInPanelOpen FIPO = new FormInPanelOpen();
        ObjectText OT = new ObjectText();

        string X1, X2, X3;

        public _04AnaSayfaForm()
        {
            InitializeComponent();
        }

        private void _04AnaSayfaForm_Load(object sender, EventArgs e)
        {
            
            DAL.ProjeSayısı(ref X1, ref X2, ref X3);

            label3.Text = X1;

            label4.Text = X2;

            label6.Text = X3;

        }
    }
}
