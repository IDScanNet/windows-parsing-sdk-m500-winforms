namespace M500ParserWinForms
{
    partial class M500Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            aboutButton = new System.Windows.Forms.Button();
            AboutTab = new System.Windows.Forms.TabControl();
            aboutPage = new System.Windows.Forms.TabPage();
            licFileTextBox = new System.Windows.Forms.TextBox();
            licFileLabel = new System.Windows.Forms.Label();
            eventLabel = new System.Windows.Forms.Label();
            eventTextBox = new System.Windows.Forms.TextBox();
            settingsPage = new System.Windows.Forms.TabPage();
            initButton = new System.Windows.Forms.Button();
            logDirLabel = new System.Windows.Forms.Label();
            unlockButton = new System.Windows.Forms.Button();
            lockButton = new System.Windows.Forms.Button();
            ejectButton = new System.Windows.Forms.Button();
            LEDTextBox = new System.Windows.Forms.TextBox();
            LEDButton = new System.Windows.Forms.Button();
            beeptextbox = new System.Windows.Forms.TextBox();
            beepBtn = new System.Windows.Forms.Button();
            dirTextbox = new System.Windows.Forms.TextBox();
            dirButton = new System.Windows.Forms.Button();
            imagePage = new System.Windows.Forms.TabPage();
            IRFrontUserImage = new UserImage();
            IRBackUserImage = new UserImage();
            IRBackLabel = new System.Windows.Forms.Label();
            IRFrontLabel = new System.Windows.Forms.Label();
            UVBackLabel = new System.Windows.Forms.Label();
            UVBackUserImage = new UserImage();
            RGBBackUserImage = new UserImage();
            RGBBackLabel = new System.Windows.Forms.Label();
            UVFrontLabel = new System.Windows.Forms.Label();
            UVFrontUserImage = new UserImage();
            RGBFrontLabel = new System.Windows.Forms.Label();
            RGBFrontUserImage = new UserImage();
            dataStringsPage = new System.Windows.Forms.TabPage();
            valCodesTextBoxMAG = new System.Windows.Forms.TextBox();
            valCodesTextBoxPDF = new System.Windows.Forms.TextBox();
            zipTextBoxMAG = new System.Windows.Forms.TextBox();
            stateTextBoxMAG = new System.Windows.Forms.TextBox();
            valLevelTextBoxMAG = new System.Windows.Forms.TextBox();
            expDateTextBoxMAG = new System.Windows.Forms.TextBox();
            cityTextBoxMAG = new System.Windows.Forms.TextBox();
            DOBTextBoxMAG = new System.Windows.Forms.TextBox();
            address2TextBoxMAG = new System.Windows.Forms.TextBox();
            address1TextBoxMAG = new System.Windows.Forms.TextBox();
            IDNumberTextBoxMAG = new System.Windows.Forms.TextBox();
            nameTextBoxMAG = new System.Windows.Forms.TextBox();
            ZIPTextBoxPDF = new System.Windows.Forms.TextBox();
            StateTextBoxPDF = new System.Windows.Forms.TextBox();
            valLevelTextBoxPDF = new System.Windows.Forms.TextBox();
            expDateTextBoxPDF = new System.Windows.Forms.TextBox();
            CityTextBoxPDF = new System.Windows.Forms.TextBox();
            DOBTextBoxPDF = new System.Windows.Forms.TextBox();
            address2TextBoxPDF = new System.Windows.Forms.TextBox();
            address1TextBoxPDF = new System.Windows.Forms.TextBox();
            IDNumberTextBoxPDF = new System.Windows.Forms.TextBox();
            nameTextBoxPDF = new System.Windows.Forms.TextBox();
            valCodesLabelMAG = new System.Windows.Forms.Label();
            valCodesLabelPDF = new System.Windows.Forms.Label();
            valLevelLabelMAG = new System.Windows.Forms.Label();
            valScoreLabelPDF = new System.Windows.Forms.Label();
            expDateLabelMAG = new System.Windows.Forms.Label();
            expDateLabelPDF = new System.Windows.Forms.Label();
            dobLabelMAG = new System.Windows.Forms.Label();
            dobLabelPDF = new System.Windows.Forms.Label();
            cszLabelMAG = new System.Windows.Forms.Label();
            cszLabelPDF = new System.Windows.Forms.Label();
            adress2LabelMAG = new System.Windows.Forms.Label();
            address2LabelPDF = new System.Windows.Forms.Label();
            address1LabelMAG = new System.Windows.Forms.Label();
            address1LabelPDF = new System.Windows.Forms.Label();
            IDNumberMAG = new System.Windows.Forms.Label();
            IDNumberPDF = new System.Windows.Forms.Label();
            nameLabelMAG = new System.Windows.Forms.Label();
            nameLabelPDF = new System.Windows.Forms.Label();
            pdf417TextBox = new System.Windows.Forms.TextBox();
            magstripeTrack3TextBox = new System.Windows.Forms.TextBox();
            magstripeTrack2TextBox = new System.Windows.Forms.TextBox();
            magstripeTrack1TextBox = new System.Windows.Forms.TextBox();
            magTrack3Label = new System.Windows.Forms.Label();
            magTrack2Label = new System.Windows.Forms.Label();
            OneDBarcodeText = new System.Windows.Forms.Label();
            magTrack1Label = new System.Windows.Forms.Label();
            PDFLabelText = new System.Windows.Forms.Label();
            fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            AboutTab.SuspendLayout();
            aboutPage.SuspendLayout();
            settingsPage.SuspendLayout();
            imagePage.SuspendLayout();
            dataStringsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // aboutButton
            // 
            aboutButton.Location = new System.Drawing.Point(7, 6);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new System.Drawing.Size(110, 23);
            aboutButton.TabIndex = 0;
            aboutButton.Text = "About M500";
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += AboutButton_Click;
            // 
            // AboutTab
            // 
            AboutTab.Controls.Add(aboutPage);
            AboutTab.Controls.Add(settingsPage);
            AboutTab.Controls.Add(imagePage);
            AboutTab.Controls.Add(dataStringsPage);
            AboutTab.Location = new System.Drawing.Point(1, 1);
            AboutTab.Name = "AboutTab";
            AboutTab.SelectedIndex = 0;
            AboutTab.Size = new System.Drawing.Size(1264, 678);
            AboutTab.TabIndex = 2;
            // 
            // aboutPage
            // 
            aboutPage.Controls.Add(licFileTextBox);
            aboutPage.Controls.Add(licFileLabel);
            aboutPage.Controls.Add(eventLabel);
            aboutPage.Controls.Add(eventTextBox);
            aboutPage.Controls.Add(aboutButton);
            aboutPage.Location = new System.Drawing.Point(4, 24);
            aboutPage.Name = "aboutPage";
            aboutPage.Padding = new System.Windows.Forms.Padding(3);
            aboutPage.Size = new System.Drawing.Size(1256, 650);
            aboutPage.TabIndex = 0;
            aboutPage.Text = "About";
            aboutPage.UseVisualStyleBackColor = true;
            // 
            // licFileTextBox
            // 
            licFileTextBox.Location = new System.Drawing.Point(155, 35);
            licFileTextBox.Name = "licFileTextBox";
            licFileTextBox.ReadOnly = true;
            licFileTextBox.Size = new System.Drawing.Size(159, 23);
            licFileTextBox.TabIndex = 53;
            // 
            // licFileLabel
            // 
            licFileLabel.AutoSize = true;
            licFileLabel.Location = new System.Drawing.Point(7, 38);
            licFileLabel.Name = "licFileLabel";
            licFileLabel.Size = new System.Drawing.Size(142, 15);
            licFileLabel.TabIndex = 52;
            licFileLabel.Text = "Parser License File Expires";
            // 
            // eventLabel
            // 
            eventLabel.AutoSize = true;
            eventLabel.Location = new System.Drawing.Point(7, 67);
            eventLabel.Name = "eventLabel";
            eventLabel.Size = new System.Drawing.Size(41, 15);
            eventLabel.TabIndex = 3;
            eventLabel.Text = "Events";
            // 
            // eventTextBox
            // 
            eventTextBox.AcceptsReturn = true;
            eventTextBox.Location = new System.Drawing.Point(7, 85);
            eventTextBox.Multiline = true;
            eventTextBox.Name = "eventTextBox";
            eventTextBox.ReadOnly = true;
            eventTextBox.Size = new System.Drawing.Size(307, 545);
            eventTextBox.TabIndex = 2;
            // 
            // settingsPage
            // 
            settingsPage.Controls.Add(initButton);
            settingsPage.Controls.Add(logDirLabel);
            settingsPage.Controls.Add(unlockButton);
            settingsPage.Controls.Add(lockButton);
            settingsPage.Controls.Add(ejectButton);
            settingsPage.Controls.Add(LEDTextBox);
            settingsPage.Controls.Add(LEDButton);
            settingsPage.Controls.Add(beeptextbox);
            settingsPage.Controls.Add(beepBtn);
            settingsPage.Controls.Add(dirTextbox);
            settingsPage.Controls.Add(dirButton);
            settingsPage.Location = new System.Drawing.Point(4, 24);
            settingsPage.Name = "settingsPage";
            settingsPage.Padding = new System.Windows.Forms.Padding(3);
            settingsPage.Size = new System.Drawing.Size(1256, 650);
            settingsPage.TabIndex = 1;
            settingsPage.Text = "Settings";
            settingsPage.UseVisualStyleBackColor = true;
            // 
            // initButton
            // 
            initButton.Location = new System.Drawing.Point(7, 35);
            initButton.Name = "initButton";
            initButton.Size = new System.Drawing.Size(109, 23);
            initButton.TabIndex = 14;
            initButton.Text = "Initialize M500";
            initButton.UseVisualStyleBackColor = true;
            initButton.Click += InitButton_Click;
            // 
            // logDirLabel
            // 
            logDirLabel.AutoSize = true;
            logDirLabel.Location = new System.Drawing.Point(413, 9);
            logDirLabel.Name = "logDirLabel";
            logDirLabel.Size = new System.Drawing.Size(524, 15);
            logDirLabel.TabIndex = 13;
            logDirLabel.Text = "Must be set before Initialize M500 if you require logging. Change default directory in M500Form.cs";
            // 
            // unlockButton
            // 
            unlockButton.Location = new System.Drawing.Point(7, 182);
            unlockButton.Name = "unlockButton";
            unlockButton.Size = new System.Drawing.Size(110, 23);
            unlockButton.TabIndex = 11;
            unlockButton.Text = "Unlock M500";
            unlockButton.UseVisualStyleBackColor = true;
            unlockButton.Click += UnlockButton_Click;
            // 
            // lockButton
            // 
            lockButton.BackColor = System.Drawing.Color.Transparent;
            lockButton.Location = new System.Drawing.Point(7, 153);
            lockButton.Name = "lockButton";
            lockButton.Size = new System.Drawing.Size(110, 23);
            lockButton.TabIndex = 10;
            lockButton.Text = "Lock M500";
            lockButton.UseVisualStyleBackColor = false;
            lockButton.Click += LockButton_Click;
            // 
            // ejectButton
            // 
            ejectButton.Location = new System.Drawing.Point(7, 124);
            ejectButton.Name = "ejectButton";
            ejectButton.Size = new System.Drawing.Size(110, 23);
            ejectButton.TabIndex = 9;
            ejectButton.Text = "Eject Document";
            ejectButton.UseVisualStyleBackColor = true;
            ejectButton.Click += EjectButton_Click;
            // 
            // LEDTextBox
            // 
            LEDTextBox.Location = new System.Drawing.Point(123, 96);
            LEDTextBox.Name = "LEDTextBox";
            LEDTextBox.ReadOnly = true;
            LEDTextBox.Size = new System.Drawing.Size(288, 23);
            LEDTextBox.TabIndex = 8;
            LEDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LEDButton
            // 
            LEDButton.Location = new System.Drawing.Point(7, 95);
            LEDButton.Name = "LEDButton";
            LEDButton.Size = new System.Drawing.Size(110, 23);
            LEDButton.TabIndex = 7;
            LEDButton.Text = "LED";
            LEDButton.UseVisualStyleBackColor = true;
            LEDButton.Click += LEDButton_Click;
            // 
            // beeptextbox
            // 
            beeptextbox.Location = new System.Drawing.Point(123, 64);
            beeptextbox.Name = "beeptextbox";
            beeptextbox.ReadOnly = true;
            beeptextbox.Size = new System.Drawing.Size(288, 23);
            beeptextbox.TabIndex = 6;
            beeptextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // beepBtn
            // 
            beepBtn.Location = new System.Drawing.Point(6, 64);
            beepBtn.Name = "beepBtn";
            beepBtn.Size = new System.Drawing.Size(110, 24);
            beepBtn.TabIndex = 5;
            beepBtn.Text = "Beep";
            beepBtn.UseVisualStyleBackColor = true;
            beepBtn.Click += BeepButton_Click;
            // 
            // dirTextbox
            // 
            dirTextbox.Location = new System.Drawing.Point(119, 6);
            dirTextbox.Name = "dirTextbox";
            dirTextbox.ReadOnly = true;
            dirTextbox.Size = new System.Drawing.Size(288, 23);
            dirTextbox.TabIndex = 4;
            dirTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dirButton
            // 
            dirButton.Location = new System.Drawing.Point(7, 6);
            dirButton.Name = "dirButton";
            dirButton.Size = new System.Drawing.Size(110, 23);
            dirButton.TabIndex = 3;
            dirButton.Text = "Set Log Directory";
            dirButton.UseVisualStyleBackColor = true;
            dirButton.Click += DirButton_Click;
            // 
            // imagePage
            // 
            imagePage.Controls.Add(IRFrontUserImage);
            imagePage.Controls.Add(IRBackUserImage);
            imagePage.Controls.Add(IRBackLabel);
            imagePage.Controls.Add(IRFrontLabel);
            imagePage.Controls.Add(UVBackLabel);
            imagePage.Controls.Add(UVBackUserImage);
            imagePage.Controls.Add(RGBBackUserImage);
            imagePage.Controls.Add(RGBBackLabel);
            imagePage.Controls.Add(UVFrontLabel);
            imagePage.Controls.Add(UVFrontUserImage);
            imagePage.Controls.Add(RGBFrontLabel);
            imagePage.Controls.Add(RGBFrontUserImage);
            imagePage.Location = new System.Drawing.Point(4, 24);
            imagePage.Name = "imagePage";
            imagePage.Padding = new System.Windows.Forms.Padding(3);
            imagePage.Size = new System.Drawing.Size(1256, 650);
            imagePage.TabIndex = 2;
            imagePage.Text = "Images";
            imagePage.UseVisualStyleBackColor = true;
            // 
            // IRFrontUserImage
            // 
            IRFrontUserImage.BackColor = System.Drawing.Color.Gray;
            IRFrontUserImage.BitmapImage = null;
            IRFrontUserImage.Location = new System.Drawing.Point(428, 30);
            IRFrontUserImage.Name = "IRFrontUserImage";
            IRFrontUserImage.Size = new System.Drawing.Size(400, 250);
            IRFrontUserImage.TabIndex = 14;
            // 
            // IRBackUserImage
            // 
            IRBackUserImage.BackColor = System.Drawing.Color.Gray;
            IRBackUserImage.BitmapImage = null;
            IRBackUserImage.Location = new System.Drawing.Point(428, 349);
            IRBackUserImage.Name = "IRBackUserImage";
            IRBackUserImage.Size = new System.Drawing.Size(400, 250);
            IRBackUserImage.TabIndex = 13;
            // 
            // IRBackLabel
            // 
            IRBackLabel.AutoSize = true;
            IRBackLabel.Location = new System.Drawing.Point(428, 328);
            IRBackLabel.Name = "IRBackLabel";
            IRBackLabel.Size = new System.Drawing.Size(45, 15);
            IRBackLabel.TabIndex = 11;
            IRBackLabel.Text = "IR Back";
            IRBackLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // IRFrontLabel
            // 
            IRFrontLabel.AutoSize = true;
            IRFrontLabel.Location = new System.Drawing.Point(428, 12);
            IRFrontLabel.Name = "IRFrontLabel";
            IRFrontLabel.Size = new System.Drawing.Size(48, 15);
            IRFrontLabel.TabIndex = 10;
            IRFrontLabel.Text = "IR Front";
            // 
            // UVBackLabel
            // 
            UVBackLabel.AutoSize = true;
            UVBackLabel.Location = new System.Drawing.Point(847, 328);
            UVBackLabel.Name = "UVBackLabel";
            UVBackLabel.Size = new System.Drawing.Size(50, 15);
            UVBackLabel.TabIndex = 9;
            UVBackLabel.Text = "UV Back";
            // 
            // UVBackUserImage
            // 
            UVBackUserImage.BackColor = System.Drawing.Color.Gray;
            UVBackUserImage.BitmapImage = null;
            UVBackUserImage.Location = new System.Drawing.Point(847, 349);
            UVBackUserImage.Name = "UVBackUserImage";
            UVBackUserImage.Size = new System.Drawing.Size(400, 250);
            UVBackUserImage.TabIndex = 8;
            // 
            // RGBBackUserImage
            // 
            RGBBackUserImage.BackColor = System.Drawing.Color.Gray;
            RGBBackUserImage.BitmapImage = null;
            RGBBackUserImage.Location = new System.Drawing.Point(7, 349);
            RGBBackUserImage.Name = "RGBBackUserImage";
            RGBBackUserImage.Size = new System.Drawing.Size(400, 250);
            RGBBackUserImage.TabIndex = 7;
            // 
            // RGBBackLabel
            // 
            RGBBackLabel.AutoSize = true;
            RGBBackLabel.Location = new System.Drawing.Point(7, 328);
            RGBBackLabel.Name = "RGBBackLabel";
            RGBBackLabel.Size = new System.Drawing.Size(57, 15);
            RGBBackLabel.TabIndex = 6;
            RGBBackLabel.Text = "RGB Back";
            // 
            // UVFrontLabel
            // 
            UVFrontLabel.AutoSize = true;
            UVFrontLabel.Location = new System.Drawing.Point(847, 12);
            UVFrontLabel.Name = "UVFrontLabel";
            UVFrontLabel.Size = new System.Drawing.Size(53, 15);
            UVFrontLabel.TabIndex = 5;
            UVFrontLabel.Text = "UV Front";
            // 
            // UVFrontUserImage
            // 
            UVFrontUserImage.BackColor = System.Drawing.Color.Gray;
            UVFrontUserImage.BitmapImage = null;
            UVFrontUserImage.Location = new System.Drawing.Point(847, 30);
            UVFrontUserImage.Name = "UVFrontUserImage";
            UVFrontUserImage.Size = new System.Drawing.Size(400, 250);
            UVFrontUserImage.TabIndex = 12;
            // 
            // RGBFrontLabel
            // 
            RGBFrontLabel.AutoSize = true;
            RGBFrontLabel.Location = new System.Drawing.Point(7, 12);
            RGBFrontLabel.Name = "RGBFrontLabel";
            RGBFrontLabel.Size = new System.Drawing.Size(60, 15);
            RGBFrontLabel.TabIndex = 3;
            RGBFrontLabel.Text = "RGB Front";
            // 
            // RGBFrontUserImage
            // 
            RGBFrontUserImage.BackColor = System.Drawing.Color.Gray;
            RGBFrontUserImage.BitmapImage = null;
            RGBFrontUserImage.Location = new System.Drawing.Point(7, 30);
            RGBFrontUserImage.Name = "RGBFrontUserImage";
            RGBFrontUserImage.Size = new System.Drawing.Size(400, 250);
            RGBFrontUserImage.TabIndex = 2;
            // 
            // dataStringsPage
            // 
            dataStringsPage.Controls.Add(valCodesTextBoxMAG);
            dataStringsPage.Controls.Add(valCodesTextBoxPDF);
            dataStringsPage.Controls.Add(zipTextBoxMAG);
            dataStringsPage.Controls.Add(stateTextBoxMAG);
            dataStringsPage.Controls.Add(valLevelTextBoxMAG);
            dataStringsPage.Controls.Add(expDateTextBoxMAG);
            dataStringsPage.Controls.Add(cityTextBoxMAG);
            dataStringsPage.Controls.Add(DOBTextBoxMAG);
            dataStringsPage.Controls.Add(address2TextBoxMAG);
            dataStringsPage.Controls.Add(address1TextBoxMAG);
            dataStringsPage.Controls.Add(IDNumberTextBoxMAG);
            dataStringsPage.Controls.Add(nameTextBoxMAG);
            dataStringsPage.Controls.Add(ZIPTextBoxPDF);
            dataStringsPage.Controls.Add(StateTextBoxPDF);
            dataStringsPage.Controls.Add(valLevelTextBoxPDF);
            dataStringsPage.Controls.Add(expDateTextBoxPDF);
            dataStringsPage.Controls.Add(CityTextBoxPDF);
            dataStringsPage.Controls.Add(DOBTextBoxPDF);
            dataStringsPage.Controls.Add(address2TextBoxPDF);
            dataStringsPage.Controls.Add(address1TextBoxPDF);
            dataStringsPage.Controls.Add(IDNumberTextBoxPDF);
            dataStringsPage.Controls.Add(nameTextBoxPDF);
            dataStringsPage.Controls.Add(valCodesLabelMAG);
            dataStringsPage.Controls.Add(valCodesLabelPDF);
            dataStringsPage.Controls.Add(valLevelLabelMAG);
            dataStringsPage.Controls.Add(valScoreLabelPDF);
            dataStringsPage.Controls.Add(expDateLabelMAG);
            dataStringsPage.Controls.Add(expDateLabelPDF);
            dataStringsPage.Controls.Add(dobLabelMAG);
            dataStringsPage.Controls.Add(dobLabelPDF);
            dataStringsPage.Controls.Add(cszLabelMAG);
            dataStringsPage.Controls.Add(cszLabelPDF);
            dataStringsPage.Controls.Add(adress2LabelMAG);
            dataStringsPage.Controls.Add(address2LabelPDF);
            dataStringsPage.Controls.Add(address1LabelMAG);
            dataStringsPage.Controls.Add(address1LabelPDF);
            dataStringsPage.Controls.Add(IDNumberMAG);
            dataStringsPage.Controls.Add(IDNumberPDF);
            dataStringsPage.Controls.Add(nameLabelMAG);
            dataStringsPage.Controls.Add(nameLabelPDF);
            dataStringsPage.Controls.Add(pdf417TextBox);
            dataStringsPage.Controls.Add(magstripeTrack3TextBox);
            dataStringsPage.Controls.Add(magstripeTrack2TextBox);
            dataStringsPage.Controls.Add(magstripeTrack1TextBox);
            dataStringsPage.Controls.Add(magTrack3Label);
            dataStringsPage.Controls.Add(magTrack2Label);
            dataStringsPage.Controls.Add(OneDBarcodeText);
            dataStringsPage.Controls.Add(magTrack1Label);
            dataStringsPage.Controls.Add(PDFLabelText);
            dataStringsPage.Location = new System.Drawing.Point(4, 24);
            dataStringsPage.Name = "dataStringsPage";
            dataStringsPage.Padding = new System.Windows.Forms.Padding(3);
            dataStringsPage.Size = new System.Drawing.Size(1256, 650);
            dataStringsPage.TabIndex = 3;
            dataStringsPage.Text = "Data Strings";
            dataStringsPage.UseVisualStyleBackColor = true;
            // 
            // valCodesTextBoxMAG
            // 
            valCodesTextBoxMAG.Location = new System.Drawing.Point(563, 523);
            valCodesTextBoxMAG.Multiline = true;
            valCodesTextBoxMAG.Name = "valCodesTextBoxMAG";
            valCodesTextBoxMAG.ReadOnly = true;
            valCodesTextBoxMAG.Size = new System.Drawing.Size(454, 121);
            valCodesTextBoxMAG.TabIndex = 49;
            // 
            // valCodesTextBoxPDF
            // 
            valCodesTextBoxPDF.Location = new System.Drawing.Point(10, 523);
            valCodesTextBoxPDF.Multiline = true;
            valCodesTextBoxPDF.Name = "valCodesTextBoxPDF";
            valCodesTextBoxPDF.ReadOnly = true;
            valCodesTextBoxPDF.Size = new System.Drawing.Size(484, 121);
            valCodesTextBoxPDF.TabIndex = 48;
            // 
            // zipTextBoxMAG
            // 
            zipTextBoxMAG.Location = new System.Drawing.Point(911, 415);
            zipTextBoxMAG.Name = "zipTextBoxMAG";
            zipTextBoxMAG.ReadOnly = true;
            zipTextBoxMAG.Size = new System.Drawing.Size(106, 23);
            zipTextBoxMAG.TabIndex = 47;
            // 
            // stateTextBoxMAG
            // 
            stateTextBoxMAG.Location = new System.Drawing.Point(874, 416);
            stateTextBoxMAG.Name = "stateTextBoxMAG";
            stateTextBoxMAG.ReadOnly = true;
            stateTextBoxMAG.Size = new System.Drawing.Size(31, 23);
            stateTextBoxMAG.TabIndex = 46;
            // 
            // valLevelTextBoxMAG
            // 
            valLevelTextBoxMAG.Location = new System.Drawing.Point(665, 473);
            valLevelTextBoxMAG.Name = "valLevelTextBoxMAG";
            valLevelTextBoxMAG.ReadOnly = true;
            valLevelTextBoxMAG.Size = new System.Drawing.Size(352, 23);
            valLevelTextBoxMAG.TabIndex = 45;
            // 
            // expDateTextBoxMAG
            // 
            expDateTextBoxMAG.Location = new System.Drawing.Point(665, 444);
            expDateTextBoxMAG.Name = "expDateTextBoxMAG";
            expDateTextBoxMAG.ReadOnly = true;
            expDateTextBoxMAG.Size = new System.Drawing.Size(352, 23);
            expDateTextBoxMAG.TabIndex = 44;
            // 
            // cityTextBoxMAG
            // 
            cityTextBoxMAG.Location = new System.Drawing.Point(665, 416);
            cityTextBoxMAG.Name = "cityTextBoxMAG";
            cityTextBoxMAG.ReadOnly = true;
            cityTextBoxMAG.Size = new System.Drawing.Size(203, 23);
            cityTextBoxMAG.TabIndex = 43;
            // 
            // DOBTextBoxMAG
            // 
            DOBTextBoxMAG.Location = new System.Drawing.Point(665, 387);
            DOBTextBoxMAG.Name = "DOBTextBoxMAG";
            DOBTextBoxMAG.ReadOnly = true;
            DOBTextBoxMAG.Size = new System.Drawing.Size(352, 23);
            DOBTextBoxMAG.TabIndex = 42;
            // 
            // address2TextBoxMAG
            // 
            address2TextBoxMAG.Location = new System.Drawing.Point(665, 358);
            address2TextBoxMAG.Name = "address2TextBoxMAG";
            address2TextBoxMAG.ReadOnly = true;
            address2TextBoxMAG.Size = new System.Drawing.Size(352, 23);
            address2TextBoxMAG.TabIndex = 41;
            // 
            // address1TextBoxMAG
            // 
            address1TextBoxMAG.Location = new System.Drawing.Point(665, 329);
            address1TextBoxMAG.Name = "address1TextBoxMAG";
            address1TextBoxMAG.ReadOnly = true;
            address1TextBoxMAG.Size = new System.Drawing.Size(352, 23);
            address1TextBoxMAG.TabIndex = 40;
            // 
            // IDNumberTextBoxMAG
            // 
            IDNumberTextBoxMAG.Location = new System.Drawing.Point(665, 300);
            IDNumberTextBoxMAG.Name = "IDNumberTextBoxMAG";
            IDNumberTextBoxMAG.ReadOnly = true;
            IDNumberTextBoxMAG.Size = new System.Drawing.Size(352, 23);
            IDNumberTextBoxMAG.TabIndex = 39;
            // 
            // nameTextBoxMAG
            // 
            nameTextBoxMAG.Location = new System.Drawing.Point(665, 271);
            nameTextBoxMAG.Name = "nameTextBoxMAG";
            nameTextBoxMAG.ReadOnly = true;
            nameTextBoxMAG.Size = new System.Drawing.Size(352, 23);
            nameTextBoxMAG.TabIndex = 38;
            // 
            // ZIPTextBoxPDF
            // 
            ZIPTextBoxPDF.Location = new System.Drawing.Point(388, 415);
            ZIPTextBoxPDF.Name = "ZIPTextBoxPDF";
            ZIPTextBoxPDF.ReadOnly = true;
            ZIPTextBoxPDF.Size = new System.Drawing.Size(106, 23);
            ZIPTextBoxPDF.TabIndex = 37;
            // 
            // StateTextBoxPDF
            // 
            StateTextBoxPDF.Location = new System.Drawing.Point(351, 415);
            StateTextBoxPDF.Name = "StateTextBoxPDF";
            StateTextBoxPDF.ReadOnly = true;
            StateTextBoxPDF.Size = new System.Drawing.Size(31, 23);
            StateTextBoxPDF.TabIndex = 36;
            // 
            // valLevelTextBoxPDF
            // 
            valLevelTextBoxPDF.Location = new System.Drawing.Point(142, 473);
            valLevelTextBoxPDF.Name = "valLevelTextBoxPDF";
            valLevelTextBoxPDF.ReadOnly = true;
            valLevelTextBoxPDF.Size = new System.Drawing.Size(352, 23);
            valLevelTextBoxPDF.TabIndex = 35;
            // 
            // expDateTextBoxPDF
            // 
            expDateTextBoxPDF.Location = new System.Drawing.Point(142, 444);
            expDateTextBoxPDF.Name = "expDateTextBoxPDF";
            expDateTextBoxPDF.ReadOnly = true;
            expDateTextBoxPDF.Size = new System.Drawing.Size(352, 23);
            expDateTextBoxPDF.TabIndex = 34;
            // 
            // CityTextBoxPDF
            // 
            CityTextBoxPDF.Location = new System.Drawing.Point(142, 416);
            CityTextBoxPDF.Name = "CityTextBoxPDF";
            CityTextBoxPDF.ReadOnly = true;
            CityTextBoxPDF.Size = new System.Drawing.Size(203, 23);
            CityTextBoxPDF.TabIndex = 33;
            // 
            // DOBTextBoxPDF
            // 
            DOBTextBoxPDF.Location = new System.Drawing.Point(142, 387);
            DOBTextBoxPDF.Name = "DOBTextBoxPDF";
            DOBTextBoxPDF.ReadOnly = true;
            DOBTextBoxPDF.Size = new System.Drawing.Size(352, 23);
            DOBTextBoxPDF.TabIndex = 32;
            // 
            // address2TextBoxPDF
            // 
            address2TextBoxPDF.Location = new System.Drawing.Point(142, 358);
            address2TextBoxPDF.Name = "address2TextBoxPDF";
            address2TextBoxPDF.ReadOnly = true;
            address2TextBoxPDF.Size = new System.Drawing.Size(352, 23);
            address2TextBoxPDF.TabIndex = 31;
            // 
            // address1TextBoxPDF
            // 
            address1TextBoxPDF.Location = new System.Drawing.Point(142, 329);
            address1TextBoxPDF.Name = "address1TextBoxPDF";
            address1TextBoxPDF.ReadOnly = true;
            address1TextBoxPDF.Size = new System.Drawing.Size(352, 23);
            address1TextBoxPDF.TabIndex = 30;
            // 
            // IDNumberTextBoxPDF
            // 
            IDNumberTextBoxPDF.Location = new System.Drawing.Point(142, 300);
            IDNumberTextBoxPDF.Name = "IDNumberTextBoxPDF";
            IDNumberTextBoxPDF.ReadOnly = true;
            IDNumberTextBoxPDF.Size = new System.Drawing.Size(352, 23);
            IDNumberTextBoxPDF.TabIndex = 29;
            // 
            // nameTextBoxPDF
            // 
            nameTextBoxPDF.Location = new System.Drawing.Point(142, 271);
            nameTextBoxPDF.Name = "nameTextBoxPDF";
            nameTextBoxPDF.ReadOnly = true;
            nameTextBoxPDF.Size = new System.Drawing.Size(352, 23);
            nameTextBoxPDF.TabIndex = 28;
            // 
            // valCodesLabelMAG
            // 
            valCodesLabelMAG.AutoSize = true;
            valCodesLabelMAG.Location = new System.Drawing.Point(564, 505);
            valCodesLabelMAG.Name = "valCodesLabelMAG";
            valCodesLabelMAG.Size = new System.Drawing.Size(95, 15);
            valCodesLabelMAG.TabIndex = 27;
            valCodesLabelMAG.Text = "Validation Codes";
            // 
            // valCodesLabelPDF
            // 
            valCodesLabelPDF.AutoSize = true;
            valCodesLabelPDF.Location = new System.Drawing.Point(10, 505);
            valCodesLabelPDF.Name = "valCodesLabelPDF";
            valCodesLabelPDF.Size = new System.Drawing.Size(95, 15);
            valCodesLabelPDF.TabIndex = 26;
            valCodesLabelPDF.Text = "Validation Codes";
            // 
            // valLevelLabelMAG
            // 
            valLevelLabelMAG.AutoSize = true;
            valLevelLabelMAG.Location = new System.Drawing.Point(563, 481);
            valLevelLabelMAG.Name = "valLevelLabelMAG";
            valLevelLabelMAG.Size = new System.Drawing.Size(89, 15);
            valLevelLabelMAG.TabIndex = 25;
            valLevelLabelMAG.Text = "Validation Level";
            // 
            // valScoreLabelPDF
            // 
            valScoreLabelPDF.AutoSize = true;
            valScoreLabelPDF.Location = new System.Drawing.Point(10, 481);
            valScoreLabelPDF.Name = "valScoreLabelPDF";
            valScoreLabelPDF.Size = new System.Drawing.Size(89, 15);
            valScoreLabelPDF.TabIndex = 24;
            valScoreLabelPDF.Text = "Validation Level";
            // 
            // expDateLabelMAG
            // 
            expDateLabelMAG.AutoSize = true;
            expDateLabelMAG.Location = new System.Drawing.Point(563, 452);
            expDateLabelMAG.Name = "expDateLabelMAG";
            expDateLabelMAG.Size = new System.Drawing.Size(87, 15);
            expDateLabelMAG.TabIndex = 23;
            expDateLabelMAG.Text = "Expiration Date";
            // 
            // expDateLabelPDF
            // 
            expDateLabelPDF.AutoSize = true;
            expDateLabelPDF.Location = new System.Drawing.Point(10, 452);
            expDateLabelPDF.Name = "expDateLabelPDF";
            expDateLabelPDF.Size = new System.Drawing.Size(87, 15);
            expDateLabelPDF.TabIndex = 22;
            expDateLabelPDF.Text = "Expiration Date";
            // 
            // dobLabelMAG
            // 
            dobLabelMAG.AutoSize = true;
            dobLabelMAG.Location = new System.Drawing.Point(563, 390);
            dobLabelMAG.Name = "dobLabelMAG";
            dobLabelMAG.Size = new System.Drawing.Size(31, 15);
            dobLabelMAG.TabIndex = 21;
            dobLabelMAG.Text = "DOB";
            // 
            // dobLabelPDF
            // 
            dobLabelPDF.AutoSize = true;
            dobLabelPDF.Location = new System.Drawing.Point(10, 395);
            dobLabelPDF.Name = "dobLabelPDF";
            dobLabelPDF.Size = new System.Drawing.Size(31, 15);
            dobLabelPDF.TabIndex = 20;
            dobLabelPDF.Text = "DOB";
            // 
            // cszLabelMAG
            // 
            cszLabelMAG.AutoSize = true;
            cszLabelMAG.Location = new System.Drawing.Point(563, 418);
            cszLabelMAG.Name = "cszLabelMAG";
            cszLabelMAG.Size = new System.Drawing.Size(93, 15);
            cszLabelMAG.TabIndex = 19;
            cszLabelMAG.Text = "City - State - ZIP";
            // 
            // cszLabelPDF
            // 
            cszLabelPDF.AutoSize = true;
            cszLabelPDF.Location = new System.Drawing.Point(7, 424);
            cszLabelPDF.Name = "cszLabelPDF";
            cszLabelPDF.Size = new System.Drawing.Size(93, 15);
            cszLabelPDF.TabIndex = 18;
            cszLabelPDF.Text = "City - State - ZIP";
            // 
            // adress2LabelMAG
            // 
            adress2LabelMAG.AutoSize = true;
            adress2LabelMAG.Location = new System.Drawing.Point(563, 366);
            adress2LabelMAG.Name = "adress2LabelMAG";
            adress2LabelMAG.Size = new System.Drawing.Size(58, 15);
            adress2LabelMAG.TabIndex = 17;
            adress2LabelMAG.Text = "Address 2";
            // 
            // address2LabelPDF
            // 
            address2LabelPDF.AutoSize = true;
            address2LabelPDF.Location = new System.Drawing.Point(10, 366);
            address2LabelPDF.Name = "address2LabelPDF";
            address2LabelPDF.Size = new System.Drawing.Size(58, 15);
            address2LabelPDF.TabIndex = 16;
            address2LabelPDF.Text = "Address 2";
            // 
            // address1LabelMAG
            // 
            address1LabelMAG.AutoSize = true;
            address1LabelMAG.Location = new System.Drawing.Point(563, 337);
            address1LabelMAG.Name = "address1LabelMAG";
            address1LabelMAG.Size = new System.Drawing.Size(58, 15);
            address1LabelMAG.TabIndex = 15;
            address1LabelMAG.Text = "Address 1";
            // 
            // address1LabelPDF
            // 
            address1LabelPDF.AutoSize = true;
            address1LabelPDF.Location = new System.Drawing.Point(10, 337);
            address1LabelPDF.Name = "address1LabelPDF";
            address1LabelPDF.Size = new System.Drawing.Size(58, 15);
            address1LabelPDF.TabIndex = 14;
            address1LabelPDF.Text = "Address 1";
            // 
            // IDNumberMAG
            // 
            IDNumberMAG.AutoSize = true;
            IDNumberMAG.Location = new System.Drawing.Point(563, 308);
            IDNumberMAG.Name = "IDNumberMAG";
            IDNumberMAG.Size = new System.Drawing.Size(28, 15);
            IDNumberMAG.TabIndex = 13;
            IDNumberMAG.Text = "ID #";
            // 
            // IDNumberPDF
            // 
            IDNumberPDF.AutoSize = true;
            IDNumberPDF.Location = new System.Drawing.Point(10, 308);
            IDNumberPDF.Name = "IDNumberPDF";
            IDNumberPDF.Size = new System.Drawing.Size(28, 15);
            IDNumberPDF.TabIndex = 12;
            IDNumberPDF.Text = "ID #";
            // 
            // nameLabelMAG
            // 
            nameLabelMAG.AutoSize = true;
            nameLabelMAG.Location = new System.Drawing.Point(563, 279);
            nameLabelMAG.Name = "nameLabelMAG";
            nameLabelMAG.Size = new System.Drawing.Size(39, 15);
            nameLabelMAG.TabIndex = 11;
            nameLabelMAG.Text = "Name";
            // 
            // nameLabelPDF
            // 
            nameLabelPDF.AutoSize = true;
            nameLabelPDF.Location = new System.Drawing.Point(10, 279);
            nameLabelPDF.Name = "nameLabelPDF";
            nameLabelPDF.Size = new System.Drawing.Size(39, 15);
            nameLabelPDF.TabIndex = 10;
            nameLabelPDF.Text = "Name";
            // 
            // pdf417TextBox
            // 
            pdf417TextBox.AcceptsReturn = true;
            pdf417TextBox.Location = new System.Drawing.Point(7, 33);
            pdf417TextBox.Multiline = true;
            pdf417TextBox.Name = "pdf417TextBox";
            pdf417TextBox.ReadOnly = true;
            pdf417TextBox.Size = new System.Drawing.Size(487, 225);
            pdf417TextBox.TabIndex = 9;
            // 
            // magstripeTrack3TextBox
            // 
            magstripeTrack3TextBox.Location = new System.Drawing.Point(665, 78);
            magstripeTrack3TextBox.Name = "magstripeTrack3TextBox";
            magstripeTrack3TextBox.ReadOnly = true;
            magstripeTrack3TextBox.Size = new System.Drawing.Size(352, 23);
            magstripeTrack3TextBox.TabIndex = 8;
            // 
            // magstripeTrack2TextBox
            // 
            magstripeTrack2TextBox.Location = new System.Drawing.Point(665, 49);
            magstripeTrack2TextBox.Name = "magstripeTrack2TextBox";
            magstripeTrack2TextBox.ReadOnly = true;
            magstripeTrack2TextBox.Size = new System.Drawing.Size(352, 23);
            magstripeTrack2TextBox.TabIndex = 7;
            // 
            // magstripeTrack1TextBox
            // 
            magstripeTrack1TextBox.Location = new System.Drawing.Point(665, 19);
            magstripeTrack1TextBox.Name = "magstripeTrack1TextBox";
            magstripeTrack1TextBox.ReadOnly = true;
            magstripeTrack1TextBox.Size = new System.Drawing.Size(352, 23);
            magstripeTrack1TextBox.TabIndex = 6;
            // 
            // magTrack3Label
            // 
            magTrack3Label.AutoSize = true;
            magTrack3Label.Location = new System.Drawing.Point(560, 83);
            magTrack3Label.Name = "magTrack3Label";
            magTrack3Label.Size = new System.Drawing.Size(99, 15);
            magTrack3Label.TabIndex = 5;
            magTrack3Label.Text = "Magstripe Track 3";
            // 
            // magTrack2Label
            // 
            magTrack2Label.AutoSize = true;
            magTrack2Label.Location = new System.Drawing.Point(560, 52);
            magTrack2Label.Name = "magTrack2Label";
            magTrack2Label.Size = new System.Drawing.Size(99, 15);
            magTrack2Label.TabIndex = 4;
            magTrack2Label.Text = "Magstripe Track 2";
            // 
            // OneDBarcodeText
            // 
            OneDBarcodeText.AutoSize = true;
            OneDBarcodeText.Location = new System.Drawing.Point(563, 30);
            OneDBarcodeText.Name = "OneDBarcodeText";
            OneDBarcodeText.Size = new System.Drawing.Size(0, 15);
            OneDBarcodeText.TabIndex = 3;
            // 
            // magTrack1Label
            // 
            magTrack1Label.AutoSize = true;
            magTrack1Label.Location = new System.Drawing.Point(560, 22);
            magTrack1Label.Name = "magTrack1Label";
            magTrack1Label.Size = new System.Drawing.Size(99, 15);
            magTrack1Label.TabIndex = 2;
            magTrack1Label.Text = "Magstripe Track 1";
            // 
            // PDFLabelText
            // 
            PDFLabelText.AutoSize = true;
            PDFLabelText.Location = new System.Drawing.Point(7, 15);
            PDFLabelText.Name = "PDFLabelText";
            PDFLabelText.Size = new System.Drawing.Size(46, 15);
            PDFLabelText.TabIndex = 1;
            PDFLabelText.Text = "PDF417";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // M500Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(AboutTab);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "M500Form";
            Text = "M500";
            Load += M500_Load;
            AboutTab.ResumeLayout(false);
            aboutPage.ResumeLayout(false);
            aboutPage.PerformLayout();
            settingsPage.ResumeLayout(false);
            settingsPage.PerformLayout();
            imagePage.ResumeLayout(false);
            imagePage.PerformLayout();
            dataStringsPage.ResumeLayout(false);
            dataStringsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.TabControl AboutTab;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.TextBox dirTextbox;
        private System.Windows.Forms.Button dirButton;
        private System.Windows.Forms.TabPage imagePage;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button beepBtn;
        private System.Windows.Forms.TextBox beeptextbox;
        private System.Windows.Forms.TextBox LEDTextBox;
        private System.Windows.Forms.Button LEDButton;
        private System.Windows.Forms.Button ejectButton;
        private UserImage RGBFrontUserImage;
        private System.Windows.Forms.Button lockButton;
        private System.Windows.Forms.Button unlockButton;
        private System.Windows.Forms.Label logDirLabel;
        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.Label RGBFrontLabel;
        private System.Windows.Forms.Label UVFrontLabel;
        private UserImage UVFrontUserImage;
        private UserImage RGBBackUserImage;
        private System.Windows.Forms.Label RGBBackLabel;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.Label IRBackLabel;
        private System.Windows.Forms.Label IRFrontLabel;
        private System.Windows.Forms.Label UVBackLabel;
        private UserImage UVBackUserImage;
        private UserImage IRFrontUserImage;
        private UserImage IRBackUserImage;
        private System.Windows.Forms.TabPage dataStringsPage;
        private System.Windows.Forms.Label PDFLabelText;
        private System.Windows.Forms.Label magTrack1Label;
        private System.Windows.Forms.Label OneDBarcodeText;
        private System.Windows.Forms.Label magTrack3Label;
        private System.Windows.Forms.Label magTrack2Label;
        private System.Windows.Forms.TextBox magstripeTrack2TextBox;
        private System.Windows.Forms.TextBox magstripeTrack1TextBox;
        private System.Windows.Forms.TextBox magstripeTrack3TextBox;
        private System.Windows.Forms.TextBox pdf417TextBox;
        private System.Windows.Forms.Label IDNumberPDF;
        private System.Windows.Forms.Label nameLabelMAG;
        private System.Windows.Forms.Label nameLabelPDF;
        private System.Windows.Forms.Label IDNumberMAG;
        private System.Windows.Forms.Label address1LabelMAG;
        private System.Windows.Forms.Label address1LabelPDF;
        private System.Windows.Forms.Label address2LabelPDF;
        private System.Windows.Forms.Label adress2LabelMAG;
        private System.Windows.Forms.Label cszLabelMAG;
        private System.Windows.Forms.Label cszLabelPDF;
        private System.Windows.Forms.Label dobLabelPDF;
        private System.Windows.Forms.Label dobLabelMAG;
        private System.Windows.Forms.Label expDateLabelPDF;
        private System.Windows.Forms.Label expDateLabelMAG;
        private System.Windows.Forms.Label valScoreLabelPDF;
        private System.Windows.Forms.Label valLevelLabelMAG;
        private System.Windows.Forms.Label valCodesLabelMAG;
        private System.Windows.Forms.Label valCodesLabelPDF;
        private System.Windows.Forms.TextBox valLevelTextBoxPDF;
        private System.Windows.Forms.TextBox expDateTextBoxPDF;
        private System.Windows.Forms.TextBox CityTextBoxPDF;
        private System.Windows.Forms.TextBox DOBTextBoxPDF;
        private System.Windows.Forms.TextBox address2TextBoxPDF;
        private System.Windows.Forms.TextBox address1TextBoxPDF;
        private System.Windows.Forms.TextBox IDNumberTextBoxPDF;
        private System.Windows.Forms.TextBox nameTextBoxPDF;
        private System.Windows.Forms.TextBox ZIPTextBoxPDF;
        private System.Windows.Forms.TextBox StateTextBoxPDF;
        private System.Windows.Forms.TextBox zipTextBoxMAG;
        private System.Windows.Forms.TextBox stateTextBoxMAG;
        private System.Windows.Forms.TextBox valLevelTextBoxMAG;
        private System.Windows.Forms.TextBox expDateTextBoxMAG;
        private System.Windows.Forms.TextBox cityTextBoxMAG;
        private System.Windows.Forms.TextBox DOBTextBoxMAG;
        private System.Windows.Forms.TextBox address2TextBoxMAG;
        private System.Windows.Forms.TextBox address1TextBoxMAG;
        private System.Windows.Forms.TextBox IDNumberTextBoxMAG;
        private System.Windows.Forms.TextBox nameTextBoxMAG;
        private System.Windows.Forms.TextBox valCodesTextBoxPDF;
        private System.Windows.Forms.TextBox valCodesTextBoxMAG;
        private System.Windows.Forms.TextBox licFileTextBox;
        private System.Windows.Forms.Label licFileLabel;
    }
}
