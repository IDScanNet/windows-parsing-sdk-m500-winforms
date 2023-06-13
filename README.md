# windows-parsing-sdk-m500-winforms
This is a sample app using our Parsing SDK with the M500 Scanner.



1.)To use the parsing SDK, you must get the dlplib.lic license file in the same directory as the IDScanNet.dlplib.dll
  - Parsing SDK : https://docs.idscan.net/idparsing/dotnet.html
  - This is using our NuGet Package https://docs.idscan.net/idparsing/dotnet_nuget.html
2.) The M500api dll is a wrapper for SD2.dll and M500dll.dll and all 3 must be in the same directory at runtime.
    - The M500 SDK can be retrieved here. http://e-seek.us/e-seek-M500.html

3.) It is reccomended to change default log directory to the "logs" directory. this can be done in M500Form.cs.
  - You can also manually overwrite the default log directory within the sample settings.
