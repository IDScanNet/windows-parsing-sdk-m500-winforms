using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace M500ParserWinForms
{
    public partial class UserImage : UserControl
    {
         private Bitmap m_Bitmap = new Bitmap(2, 2);

        public Bitmap BitmapImage
        {
            get { return m_Bitmap; }
            set { m_Bitmap = value; }
        }

        public UserImage()
        {
            Init();
        }

        public void Init()
        {
            InitializeComponent();
            //Need to set style to double buffer so the image redrawing is smooth
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }


        /*********************************************************************
        * Override OnPaint so we can redraw the image
        * on the user control the way we want.
        ********************************************************************/
        protected override void OnPaint(PaintEventArgs e)
        {
            if (m_Bitmap == null)
            { return; }           
            Graphics g = e.Graphics;
            Rectangle rc = ClientRectangle;

            g.DrawImage(m_Bitmap, 0, 0, 400, 250);
           
        }

    }// class UsrImage
}
