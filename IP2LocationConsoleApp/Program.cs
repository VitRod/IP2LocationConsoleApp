using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* You need  to  download a  module IP2Location.IPGeolocation from NuGet Package Manager. Then you need to download IPdatabase file with extention BIN from internet. 
 * I have  downloaded it and added it to my  project. It is file "sample.bin.db25". In the  code  you need to write path to the file  with extention BIN. 
 * You can download BIN file with IP database  on this site  https://www.ip2location.com/development-libraries/ip2location/nuget
 * Then you should write  some  IP address in the code. But it should not  contain three numbers before dot (like  this 145.356.598.693),  cuz  in my  project
 * there is free version of  database. If you want to use all kinds  of IP addresses you need to buy  subscription.  And  then start your application.
 * 
 * 
 * 
 * The result  that must be:
 * 
 * IP2Location GeoLocation Results:
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
 
 */

namespace IP2LocationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine(prog.QueryIP2Location("8.12.10.32"));

            Console.WriteLine("=================================================");
            //==================================================
            //Console.WriteLine(prog.QueryIP2Location("45.56.198.193"));

            Console.ReadLine();
        }

        

        private string QueryIP2Location(string strIPAddress)
        {
            IP2Location.IPResult oIPResult = new IP2Location.IPResult();
            IP2Location.Component oIP2Location = new IP2Location.Component();
            String result = String.Empty;

            try
            {
                if (strIPAddress != "")
                {

                    oIP2Location.IPDatabasePath = @"H:\Visual Studio IDE versions\WorkspaceCSharpProjects2022\IP2LocationConsoleApp\sample.bin.db25\IP-COUNTRY-REGION-CITY-LATITUDE-LONGITUDE-ZIPCODE-TIMEZONE-ISP-DOMAIN-NETSPEED-AREACODE-WEATHER-MOBILE-ELEVATION-USAGETYPE-ADDRESSTYPE-CATEGORY-SAMPLE.BIN";
                
                    oIPResult = oIP2Location.IPQuery(strIPAddress);

                    switch (oIPResult.Status.ToString())
                    {
                        case "OK":
                            result += "IP2Location GeoLocation Results:\n===========================================\n";
                            result += "IP Address: " + oIPResult.IPAddress + "\n";
                            result += "IP Number: " + oIPResult.IPNumber + "\n";
                            result += "Provider: " + oIPResult.InternetServiceProvider + "\n";
                            result += "Country Code: " + oIPResult.CountryShort + "\n";
                            result += "Country Name: " + oIPResult.CountryLong + "\n";
                            result += "Region: " + oIPResult.Region + "\n";
                            result += "City: " + oIPResult.City + "\n";
                            result += "Latitude: " + oIPResult.Latitude + "\n";
                            result += "Longitude: " + oIPResult.Longitude + "\n";
                            result += "Postal Code: " + oIPResult.ZipCode + "\n";
                          
                            result += "ISP Name: " + oIPResult.InternetServiceProvider + "\n";
                            result += "Domain Name: " + oIPResult.DomainName + "\n";
                            result += "Time Zone: " + oIPResult.TimeZone + "\n";
                            result += "Net Speed: " + oIPResult.NetSpeed + "\n";
                            result += "IDD Code: " + oIPResult.IDDCode + "\n";
                            result += "Area Code: " + oIPResult.AreaCode + "\n";
                            result += "Weather Station Code: " + oIPResult.WeatherStationCode + "\n";
                            result += "Weather Station Name: " + oIPResult.WeatherStationName + "\n";
                            result += "MCC: " + oIPResult.MCC + "\n";
                            result += "MNC: " + oIPResult.MNC + "\n";
                            result += "Mobile Brand: " + oIPResult.MobileBrand + "\n";
                            result += "Elevation: " + oIPResult.Elevation + "\n";
                            result += "Usage Type: " + oIPResult.UsageType + "\n";
                            break;
                        case "EMPTY_IP_ADDRESS":
                            result += "IP Address cannot be blank.";
                            break;
                        case "INVALID_IP_ADDRESS":
                            result += "Invalid IP Address.";
                            break;
                        case "MISSING_FILE":
                            result += "Invalid Database Path.";
                            break;
                    }
                }
                else
                {
                    result += "IP Address cannot be blank.";
                }
            }
            catch (Exception ex)
            {
                result += ex.Message;
            }
            finally
            {
                oIPResult = null;
                oIP2Location = null;
            }

            return result;
        }

       

    }
}
