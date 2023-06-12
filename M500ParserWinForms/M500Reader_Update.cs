using System.Windows.Forms;

namespace M500ParserWinForms
{
    public partial class M500Form : Form
    {

        void SetBMPointers()
        {
            m500bmRGBFront = m_M500.m_Images.m_600RtBmp;
            m500bmRGBBack = m_M500.m_Images.m_600LtBmp;
            
            m500bmIRFront = m_M500.m_Images.m_IrRtBmp;
            m500bmIRBack = m_M500.m_Images.m_IrLtBmp;

            m500bmUVFront = m_M500.m_Images.m_UvRtBmp;
            m500bmUVBack = m_M500.m_Images.m_UvLtBmp;


            RGBFrontUserImage.BitmapImage = m500bmRGBFront;
            RGBBackUserImage.BitmapImage = m500bmRGBBack;

            IRFrontUserImage.BitmapImage = m500bmIRFront;
            IRBackUserImage.BitmapImage= m500bmIRBack;

            UVFrontUserImage.BitmapImage = m500bmUVFront;
            UVBackUserImage.BitmapImage = m500bmUVBack;
        }//end SetBMPointers
        void FmUpdateRGB()
        {
            SetBMPointers();
            RGBFrontUserImage.Invalidate();
            RGBBackUserImage.Invalidate();
        }//end FmUpdateRGB

        void FmUpdateIr()
        {
            SetBMPointers();
            
            IRFrontUserImage.Invalidate();
            IRBackUserImage.Invalidate();
        }//end FmUpdateIR

        void FmUpdateUv()
        {
            SetBMPointers();
            
            UVFrontUserImage.Invalidate();
            UVBackUserImage.Invalidate();
            
        }//end FmUpdateUV
    }
}
