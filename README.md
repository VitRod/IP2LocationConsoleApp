 You need  to  download a  module IP2Location.IPGeolocation from NuGet Package Manager. Then you need to download IPdatabase file with extention BIN from internet. 
 I have  downloaded it and added it to my  project. It is file "sample.bin.db25". In the  code  you need to write path to the file  with extention BIN. 
 You can download BIN file with IP database  on this site  https://www.ip2location.com/development-libraries/ip2location/nuget
 Then you should write  some  IP address in the code. But it should not  contain three numbers before dot (like  this 145.356.598.693),  cuz  in my  project
 there is free version of  database. If you want to use all kinds  of IP addresses you need to buy  subscription.  And  then start your application.
  
 
  
 The result  that must be:
  
  IP2Location GeoLocation Results:
===========================================
IP Address: 8.12.10.32
IP Number: 135006752
Provider: Viirtue LLC
Country Code: US
Country Name: United States of America
Region: Texas
City: Dallas
Latitude: 32,78306
Longitude: -96,80667
Postal Code: 75201
ISP Name: Viirtue LLC
Domain Name: viirtue.com
Time Zone: -05:00
Net Speed: T1
IDD Code: 1
Area Code: 214/469/972
Weather Station Code: USTX0327
Weather Station Name: Dallas
MCC: -
MNC: -
Mobile Brand: -
Elevation: 129
Usage Type: COM
 
 
