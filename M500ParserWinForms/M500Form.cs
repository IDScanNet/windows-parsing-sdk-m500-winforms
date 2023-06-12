using M500.api;
using Nautilus;
using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
namespace M500ParserWinForms
{
    public partial class M500Form : Form
    {
        public CM500api m_M500 = new CM500api();
        private M500Reader_About m500Reader_About;
        private readonly string logDir = @"your-default-directory-here";

        private const int EV_MID_SEN = 1;           //Card is at the middle sensor and a scan is about to begin
        private const int EV_MS_RDY = 2;           //stripe data ready
        private const int EV_BC_RDY = 4;            //Barcode Reader ready
        private const int EV_RGB_RDY = 5;           // RGB image ready
        private const int EV_IR_RDY = 6;           //IRimage ready
        private const int EV_UV_RDY = 7;            //UV image ready
        private const int EV_EJECTED = 8;          //document removed from reader naturally (no overwrite on device butto or programtically
        private const int EV_CANCEL = 9;
        private const int EV_USB_ON = 10;          //communication with M500
        private const int EV_USB_OFF = 11;         //cannot communicate with M500
        private const int EV_CARD_IN = 20;          // A card has been inserted(first sensor)
        private const int EV_CARD_OUT = 21;         // A card has been ejected
        private const int EV_DOOR_OPEN = 24;        // Door opened
        private const int EV_DOOR_CLOSE = 25;       // Door closed
        private const int EV_EJECT_BUT = 26;        //pressing eject button on device
        private const int EV_CARD_JAM = 29;         // A card jam was detected

        private const int EV_ERR_FW_VER = -1;        // Error – firmware is not the correct version
        private const int EV_ERR_BC_VER = -2;      //– SD2.DLL barcode deocoder is not the correct version
        private const int EV_ERR_SER_NUM = -3;     // – Serial Number is invalid, possible flash corruption
        private const int EV_ERR_AFE_REG = -4;     //– AFE registers are invalid, images may be saturated
        private const int EV_ERR_FW_UPGR = -5;     //– firmware was not the correct version but was automaticaly updated

        //6 img
        public Bitmap m500bmRGBFront;
        public Bitmap m500bmRGBBack;
        public Bitmap m500bmIRFront;
        public Bitmap m500bmIRBack;
        public Bitmap m500bmUVFront;
        public Bitmap m500bmUVBack;

        //switch states
        int m_UserBeep = 0;
        int m_LED = 0;
        readonly Parser p = new Parser();
        public M500Form()
        {
            InitializeComponent();
        }

        private void M500_Load(object sender, EventArgs e)
        {
            m500Reader_About = new M500Reader_About(m_M500);
            //set inital log directory to log folder
            m_M500.SetLogDir(logDir);
            dirTextbox.Text = logDir;
        }//end M500_Load


        public void OnNewEvent(int iEvent)
        {

            switch (iEvent)
            {

                case EV_MID_SEN:
                    Invoke(new MethodInvoker(EvMidSen));
                    break;
                //dataStrings
                case EV_BC_RDY:
                    Invoke(new MethodInvoker(EvBarcodeReady));
                    break;
                case EV_MS_RDY:
                    Invoke(new MethodInvoker(EvMagstripeReady));
                    break;
                // 6 img
                case EV_RGB_RDY:
                    Invoke(new MethodInvoker(EvRGBRdy));
                    break;
                case EV_IR_RDY:
                    Invoke(new MethodInvoker(EvIRRdy));
                    break;
                case EV_UV_RDY:
                    Invoke(new MethodInvoker(EvUVRdy));
                    break;
                //ejected via physical button or natural ejection from reader.
                case EV_EJECTED:
                    Invoke(new MethodInvoker(EvEjected));
                    break;
                case EV_CANCEL:
                    Invoke(new MethodInvoker(EvCancel));
                    break;
                case EV_EJECT_BUT:
                    Invoke(new MethodInvoker(EvEjectBtn));
                    break;
                //Card insertion/jamming
                case EV_CARD_IN:
                    Invoke(new MethodInvoker(EvCardIn));
                    break;
                case EV_CARD_OUT:
                    Invoke(new MethodInvoker(EvCardOut));
                    break;
                case EV_CARD_JAM:
                    Invoke(new MethodInvoker(EvCardJam));
                    break;
                //usb plugged in?
                case EV_USB_ON:
                    Invoke(new MethodInvoker(EvUSBON));
                    break;
                case EV_USB_OFF:
                    Invoke(new MethodInvoker(EvUSBOFF));
                    break;
                //door
                case EV_DOOR_OPEN:
                    Invoke(new MethodInvoker(EvDoorOpen));
                    break;
                case EV_DOOR_CLOSE:
                    Invoke(new MethodInvoker(EvDoorClosed));
                    break;

                //errors
                case EV_ERR_FW_VER:
                    Invoke(new MethodInvoker(EvFWVersion));
                    break;
                case EV_ERR_BC_VER:
                    Invoke(new MethodInvoker(EvBcVerError));
                    break;
                case EV_ERR_SER_NUM:
                    Invoke(new MethodInvoker(EvSerialNum));
                    break;
                case EV_ERR_FW_UPGR:
                    Invoke(new MethodInvoker(EvFwForceUpg));
                    break;
                case EV_ERR_AFE_REG:
                    Invoke(new MethodInvoker(EvAfeReg));
                    break;



            }//end switch

        }//end OnNewEvent


        private void EvMidSen()
        {
            eventTextBox.AppendText("Document detected in sensor.");
            eventTextBox.AppendText(Environment.NewLine);

            PDFLabelText.ForeColor = Color.Black;
            RGBFrontLabel.ForeColor = Color.Black;
            RGBBackLabel.ForeColor = Color.Black;
            IRFrontLabel.ForeColor = Color.Black;
            IRBackLabel.ForeColor = Color.Black;
            UVBackLabel.ForeColor = Color.Black;
            UVFrontLabel.ForeColor = Color.Black;

        }//end evMidSen

        private void EvBarcodeReady()
        {
            eventTextBox.AppendText("Barcode Data Ready.");
            eventTextBox.AppendText(Environment.NewLine);

            m_M500.UpdateBcData();
            UpdateBarcode();

        }//end evBarcodeReady

        private void EvMagstripeReady()
        {
            eventTextBox.AppendText("Magstripe Data Ready");
            eventTextBox.AppendText(Environment.NewLine);
            m_M500.UpdateMag();
            UpdateMagstripe();
        }//end evBarcodeReady

        private void EvRGBRdy()
        {
            eventTextBox.AppendText("Getting RGB Images.");
            eventTextBox.AppendText(Environment.NewLine);

            m_M500.UpdateRgb();
            FmUpdateRGB();
            RGBFrontLabel.ForeColor = Color.Green;
            RGBBackLabel.ForeColor = Color.Green;

        }//end EvRGBRdy

        private void EvIRRdy()
        {
            eventTextBox.AppendText("Getting IR Images.");
            eventTextBox.AppendText(Environment.NewLine);

            m_M500.UpdateIr();
            FmUpdateIr();

            IRFrontLabel.ForeColor = Color.Green;
            IRBackLabel.ForeColor = Color.Green;
        }//end EvIRRdy

        private void EvUVRdy()
        {

            eventTextBox.AppendText("Getting UV Images.");
            eventTextBox.AppendText(Environment.NewLine);

            m_M500.UpdateUv();
            FmUpdateUv();

            UVFrontLabel.ForeColor = Color.Green;
            UVBackLabel.ForeColor = Color.Green;
        }//end EvUVRdy

        private void EvEjected()
        {
            eventTextBox.AppendText("Document released from reader.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EVejected

        private void EvCancel()
        {
            eventTextBox.AppendText("Scan aborted.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EVejected


        private void EvEjectBtn()
        {
            eventTextBox.AppendText("Document eject via device button.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EvEjectBtn

        private void EvCardIn()
        {
            eventTextBox.AppendText("Document card in.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EvCardIn

        private void EvCardOut()
        {
            eventTextBox.AppendText("Document card out.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EvCardOut

        private void EvCardJam()
        {
            m_M500.UserBeep(E_BEEP.BEEP_LONG);

            MessageBox.Show("Card Jam detected. Please try eject document.", "M500", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            eventTextBox.AppendText("Card Jam.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EvCardJam

        //usb plug
        private void EvUSBON()
        {
            eventTextBox.AppendText("USB is plugged in.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EvUSBON

        private void EvUSBOFF()
        {
            eventTextBox.AppendText("USB is NOT plugged in.");
            eventTextBox.AppendText(Environment.NewLine);

            MessageBox.Show("USB not detected. Please plug in USB cable.", "M500", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }//end EvUSBON

        //door
        private void EvDoorOpen()
        {
            eventTextBox.AppendText("M500 Door has been opened.");
            eventTextBox.AppendText(Environment.NewLine);

        }//end EvDoorOpen

        private void EvDoorClosed()
        {
            eventTextBox.AppendText("M500 Door has been closed.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EvDoorOpen


        //errors
        private void EvFWVersion()
        {
            MessageBox.Show("Firmware Vermismtach.", "Forced update.", MessageBoxButtons.OK);
            eventTextBox.AppendText("Firmware Verison Error Detected.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EvFwVersion


        private void EvBcVerError()
        {
            MessageBox.Show("Update SD2.dll to the correct version.", "M500 wrong barcode decoder version.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            eventTextBox.AppendText("Barcode Decode Verison Error Detected.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EvBcVerError

        private void EvSerialNum()
        {
            MessageBox.Show("Invalid Serial Number.", "M500", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            eventTextBox.AppendText("Serial Number Error Detected.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EvSerialNum

        private void EvFwForceUpg()
        {
            MessageBox.Show("Upgrading M500 firmware...", "Forced update.", MessageBoxButtons.OK);
            eventTextBox.AppendText("Firmware Force Upgrade Error Detected.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EvFwForceUpg
        private void EvAfeReg()
        {
            MessageBox.Show("Invalid AFE register settings.", "M500", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            eventTextBox.AppendText("AFE Register Settings Error Detected.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EvAfeReg

        private void ApplyPDFTextBoxes()
        {
            nameTextBoxPDF.Text = p.GetParsedName();
            IDNumberTextBoxPDF.Text = p.GetParsedIDNumber();
            address1TextBoxPDF.Text = p.GetParsedAddress1();
            address2TextBoxPDF.Text = p.GetParsedAddress2();
            DOBTextBoxPDF.Text = p.GetParsedDOB();
            CityTextBoxPDF.Text = p.GetParsedCity();
            StateTextBoxPDF.Text = p.GetParsedState();
            ZIPTextBoxPDF.Text = p.GetParsedZIP();
            expDateTextBoxPDF.Text = p.GetParsedExpirationDate();
            valCodesTextBoxPDF.Text = p.GetCodes();
            valLevelTextBoxPDF.Text = p.GetValidationLevel();
        }//end method ApplyPDFTextboxes

        private void ApplyMAGTextBoxes()
        {
            nameTextBoxMAG.Text = p.GetParsedName();
            IDNumberTextBoxMAG.Text = p.GetParsedIDNumber();
            address1TextBoxMAG.Text = p.GetParsedAddress1();
            address2TextBoxMAG.Text = p.GetParsedAddress2();
            DOBTextBoxMAG.Text = p.GetParsedDOB();
            cityTextBoxMAG.Text = p.GetParsedCity();
            stateTextBoxMAG.Text = p.GetParsedState();
            zipTextBoxMAG.Text = p.GetParsedZIP();
            expDateTextBoxMAG.Text = p.GetParsedExpirationDate();
            valCodesTextBoxMAG.Text = p.GetCodes();
            valLevelTextBoxMAG.Text = p.GetValidationLevel();

        }//end method ApplyMAGTextboxes

        private static string OrientString(int iOrient)
        {

            /*
            * Page 25 of M500 Documentation
            * 
            * If the PDF417 barcode is found the iOrient element will 
            *The iOrient element has four enumerated values of the card orinetation and zero for unknown.
            *0 = Unknown orientation
            *1 = Normal orientation (Front of card is on the right).
            *2 = Front on the right but upside down.
            *3 = Front is on the left.
            *4 = Front is on the left and upside down
            *
            */
            if (iOrient == 1) { return "Normal. Front of Card is on the right."; }
            else if (iOrient == 2) { return "Front on the right but upside down."; }
            else if (iOrient == 3) { return "Front is on the left."; }
            else if (iOrient == 4) { return "Front is on the left and upside down"; }
            else { return " "; }
        }//end OrientString
        private void UpdateBarcode()
        {
            eventTextBox.AppendText("Orientation of Document : " + OrientString(m_M500.m_BC.iOrient));
            eventTextBox.AppendText(Environment.NewLine);

            string pdf = Encoding.ASCII.GetString(m_M500.m_Data.aryP417);
            pdf417TextBox.Text = pdf;
            p.Parse(pdf);

            ApplyPDFTextBoxes();
        }//end UpdateBarcode

        private void UpdateMagstripe()
        {
            string t1 = Encoding.ASCII.GetString(m_M500.m_Data.aryT1);
            string t2 = Encoding.ASCII.GetString(m_M500.m_Data.aryT2);
            string t3 = Encoding.ASCII.GetString(m_M500.m_Data.aryT3);

            magstripeTrack1TextBox.Text = t1;
            magstripeTrack2TextBox.Text = t2;
            magstripeTrack3TextBox.Text = t3;

            p.Parse(t1 + t2 + t3);
            ApplyMAGTextBoxes();
        }//end UpdateMagstripe
         //About Page
        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m500Reader_About.GetDLLVer() + "\n" + m500Reader_About.GetFWVer() + "\n" + m500Reader_About.GetSN() + "\n" + m500Reader_About.GetBCDecoderVer());

        }//end AboutButton_Click

        private void AboutParserButton_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docs.idscan.net/idparsing/dotnet.html");
        }//end aboutParserButton_Click
        //Setings Page
        private void DirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true
            };
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                m500Reader_About.SetLogDirectory(folderDlg.SelectedPath);
                dirTextbox.Text = m500Reader_About.GetLogDirectory();

                eventTextBox.AppendText("Log Directory changed to: " + m500Reader_About.GetLogDirectory());
                eventTextBox.AppendText(Environment.NewLine);
            }
        }//end DirButton_Click

        private void InitButton_Click(object sender, EventArgs e)
        {
            eventTextBox.AppendText("M500 Initialized.");
            eventTextBox.AppendText(Environment.NewLine);

            m_M500.Init();
            Thread.Sleep(500);

            m_M500.RegCB(OnNewEvent);
            m_M500.UserBeep(E_BEEP.BEEP_1);
            m500Reader_About.GetVerData();
            initButton.Enabled = false;
            dirButton.Enabled = false;
            licFileTextBox.Text = p.GetLicExp();

        }//end InitButton_Click

        private void BeepButton_Click(object sender, EventArgs e)
        {
            switch (m_UserBeep)
            {
                case 0:
                    m_M500.UserBeep(E_BEEP.BEEP_1); m_UserBeep = 1;
                    eventTextBox.AppendText("BEEP_1.");
                    eventTextBox.AppendText(Environment.NewLine);
                    beeptextbox.Text = ("BEEP_1.");
                    break;
                case 1:
                    m_M500.UserBeep(E_BEEP.BEEP_2); m_UserBeep = 2;
                    eventTextBox.AppendText("BEEP_2.");
                    eventTextBox.AppendText(Environment.NewLine);
                    beeptextbox.Text = ("BEEP_2.");

                    break;
                case 2:
                    m_M500.UserBeep(E_BEEP.BEEP_3); m_UserBeep = 3;
                    eventTextBox.AppendText("BEEP_3.");
                    eventTextBox.AppendText(Environment.NewLine);
                    beeptextbox.Text = ("BEEP_3.");

                    break;
                case 3:
                    m_M500.UserBeep(E_BEEP.BEEP_4); m_UserBeep = 4;
                    eventTextBox.AppendText("BEEP_4.");
                    eventTextBox.AppendText(Environment.NewLine);
                    beeptextbox.Text = ("BEEP_4.");

                    break;
                case 4:
                    m_M500.UserBeep(E_BEEP.BEEP_SHORT); m_UserBeep = 5;
                    eventTextBox.AppendText("BEEP_SHORT.");
                    eventTextBox.AppendText(Environment.NewLine);
                    beeptextbox.Text = ("BEEP_SHORT.");

                    break;
                default:
                    m_M500.UserBeep(E_BEEP.BEEP_LONG); m_UserBeep = 0;
                    eventTextBox.AppendText("BEEP_LONG.");
                    eventTextBox.AppendText(Environment.NewLine);
                    beeptextbox.Text = ("BEEP_LONG.");
                    break;
            }//end switch

        }//end BeepButton_Click

        private void LEDButton_Click(object sender, EventArgs e)
        {

            switch (m_LED)
            {
                case 0:
                    m_M500.UserLED(E_LED.LED_USR1_ON); m_LED = 1;
                    eventTextBox.AppendText("LED_USR1_ON (Blue).");
                    eventTextBox.AppendText(Environment.NewLine);
                    LEDTextBox.Text = ("LED_USR1_ON (Blue).");
                    break;
                case 1:
                    m_M500.UserLED(E_LED.LED_USR2_ON); m_LED = 2;
                    eventTextBox.AppendText("LED_USR2_ON (White).");
                    eventTextBox.AppendText(Environment.NewLine);
                    LEDTextBox.Text = ("LED_USR2_ON (White).");

                    break;
                case 2:
                    m_M500.UserLED(E_LED.LED_USR1_BLINK); m_LED = 3;
                    eventTextBox.AppendText("LED_USR1_BLINK (Blink Blue).");
                    eventTextBox.AppendText(Environment.NewLine);
                    LEDTextBox.Text = ("LED_USR1_BLINK (Blink Blue).");

                    break;
                case 3:
                    m_M500.UserLED(E_LED.LED_USR2_BLINK); m_LED = 4;
                    eventTextBox.AppendText("LED_USR2_BLINK (Blink White).");
                    eventTextBox.AppendText(Environment.NewLine);
                    LEDTextBox.Text = ("LED_USR2_BLINK (Blink White).");

                    break;
                default:
                    m_M500.UserLED(E_LED.LED_USR_OFF); m_LED = 0;
                    eventTextBox.AppendText("LED_USR_OFF (Off).");
                    eventTextBox.AppendText(Environment.NewLine);
                    LEDTextBox.Text = ("LED_USR_OFF (Off).");
                    break;
            }
        }//end LEDButton_Click

        private void EjectButton_Click(object sender, EventArgs e)
        {
            m_M500.EjectCard();
            eventTextBox.AppendText("Document Eject via Program Button.");
            eventTextBox.AppendText(Environment.NewLine);
        }//end EjectButton_Click

        private void LockButton_Click(object sender, EventArgs e)
        {
            m_M500.LogIn(false);
            eventTextBox.AppendText("M500 LogIn: LOCKED.");
            eventTextBox.AppendText(Environment.NewLine);
            lockButton.BackColor = Color.Red;
            lockButton.ForeColor = Color.White;

            unlockButton.BackColor = Color.Transparent;
            unlockButton.ForeColor = Color.Black;
        }//end LockButton_Click

        private void UnlockButton_Click(object sender, EventArgs e)
        {
            m_M500.LogIn(true);
            eventTextBox.AppendText("M500 LogIn: UNLOCKED.");
            eventTextBox.AppendText(Environment.NewLine);
            lockButton.BackColor = Color.Transparent;
            lockButton.ForeColor = Color.Black;

            unlockButton.BackColor = Color.Green;
            unlockButton.ForeColor = Color.White;
        }//end UnlockButton_Click


    }//end class Form1
}
