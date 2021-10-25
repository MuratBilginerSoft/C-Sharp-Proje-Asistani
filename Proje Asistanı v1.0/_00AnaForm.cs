using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GistwayZenon;
using System.Runtime.InteropServices;

namespace Proje_Asistanı_v1._0
{
    public partial class _00AnaForm : Form
    {

        #region DLL Import

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        #region For Oval Shape Form

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        #endregion

        #endregion

        #region Definition

        FormStatusLayer FSL = new FormStatusLayer();

        #endregion

        public _00AnaForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 20, 20));
            InitializeComponent();
        }

        private void _00AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            FSL.FormClose(this);
        }
    }
}
