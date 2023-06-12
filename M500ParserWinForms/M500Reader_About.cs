using System;
using System.Collections.Generic;
using System.Text;
using M500.api;
using M500;

namespace M500ParserWinForms
{
    public class M500Reader_About
    {
        //class variables
        private readonly CM500api m500API;
        private M500_VER mv;

        public M500Reader_About(CM500api m500Instance)
        {
            m500API= m500Instance;
            mv = new M500_VER();
        }//end M500Reader_About constructor
            public string GetLogDirectory()
            {   
                 return m500API.GetLogDir(); 
            }//end method GetLogDirectory
            public void SetLogDirectory(string logDirectory)
            {
                /*
                 * Page 20 of M500 Documentation
                 * 
                 * void SetLogDir(LOG_DIR) [Optional]
                 * 
                 * Call this function before Init() to override the default log directory. By default if this function is not called 
                 * the M500DLL will create the M500DLL.LOG file in the same directory it is running in. Pass this function the 
                 * string of the desired log directory. To disable logging pass the string “null”
                 *
                 */
                    m500API.SetLogDir(logDirectory +"/");
            }//end SetLogDirectory
        public M500_VER GetVerData()
            {
            /*
             * Page 21 of M500 Documentation
             * 
             * void GetVer(out M500_VER ver)
             * 
             * Gets the E-Seek serial number (EsSerNum), Silicon serial number (DsSerNum), DLL version, Barcode 
             * decoder version, firmware version, and hardware version as defined by the M500_VER structure.
             * 
             * The members of the M500_VER structure that may be of intrest to the developer are:
             *
                 *ulong EsSerNum; // E-Seek serial number
                 *byte DllMajor; // DLL version number
                 *byte DllMinor;
                 *byte DllBuild;
                 *byte FwMajor; // Firmware version number
                 *byte FwMinor;
                 *byte FwBuild; // Always zero
             */

                m500API.GetVer(out mv);
                return mv;
            }//end GetVerData
            
            public string GetDLLVer()
            {
                string dll = ("M500 DLL Version: " +mv.DllMajor+"."+mv.DllMinor+"." +mv.DllBuild);
                return dll;
            }//end GetDLLVer

            public string GetFWVer()
            {
                string fw = ("M500 FW Version: " + mv.FwMajor + "." + mv.FwMinor + "." + mv.FwBuild);
                return fw;
            }//end GetFWVer

            public string GetSN()
            {
                string sn = ("M500 SN: " +mv.EsSerNum);
                return sn;
            
            }//end GetSN

            public string GetBCDecoderVer()
            {

                //Version of barcode decoder for trackstrings

                string bcd = "BC Decoder Ver: " + mv.BcMajor + "." + mv.BcMinor;
                return bcd;
            }//end GetBCDecoderVer
    }//end class m500
}//end namespace
