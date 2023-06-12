using System;
using Nautilus;

namespace M500ParserWinForms
{
    public class Parser
    {
        /*
         * This is using the IDScan.net dlplib library via NuGet.
         * https://docs.idscan.net/idparsing/dotnet.html
         * 
         * https://docs.idscan.net/idparsing/dotnet_nuget.html
         */
        private readonly DriverLicense driverLicense = new DriverLicense();
        private readonly DlplibLicenseStatus licStatus = DriverLicense.GetDlpLibLicenseStatus();

        public void Parse(String dataString)
        {
            driverLicense.ExtractInfo(dataString);
        }//end method parse

        public string GetLicExp()
        {

            string s = licStatus.ExpirationDate.ToString();
            return s;
        }//end getLicExp

        public String GetParsedName()
        {

            return driverLicense.FullName;
        }//end getParsedName

        public String GetParsedIDNumber()
        {
            return driverLicense.LicenseNumber;
        }//end getParsedIDNumber

        public String GetParsedAddress1()
        {
            return driverLicense.Address1;
        }//end getParsedAddress1

        public String GetParsedAddress2()
        {
            return driverLicense.Address2;
        }//end getParsedAddress2

        public String GetParsedCity()
        {
            return driverLicense.City;
        }//end getParsedCity

        public String GetParsedState()
        {
            return driverLicense.JurisdictionCode;
        }//end getParsedState

        public String GetParsedZIP()
        {
            return driverLicense.PostalCode;
        }//end getParsedZIP

        public String GetParsedDOB()
        {
            return driverLicense.Birthdate;
        }//end GetParsedDOB

        public String GetParsedExpirationDate()
        {
            return driverLicense.ExpirationDate;
        }//end GetParsedExpirationDate

        public String GetValidationLevel()
        {

            int i = (int)driverLicense.ValidationConfidence;
            return i.ToString();
        }//end GetValidationLevel

        public string GetCodes()
        {
            string full = "";
            if (driverLicense.ValidationCodes != null)
                foreach (string s in driverLicense.ValidationCodes)
                {
                    full += s;
                    full += Environment.NewLine;
                }
            return full;
        }//end getCodes


    }//end class Parser
}
