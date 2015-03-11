using System;
using System.Net;
/*Problem 4. Download file

Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
 */

namespace _04.Download_file
{
    class Download
    {
        static void Main()
        {

            using (WebClient client = new WebClient())
            {
                try
                {
                    Console.WriteLine("Just a second the picture will be downloaded any moment");
                    //This picture is from websait TelerikAcademy. //This png was probably from the oldest
                    client.DownloadFile("http://telerikacademy.com/Content/Images/MetodiiNinjas.png", "MetodiiNinjas.png");
                    Console.WriteLine("Image was downloaded successfully in 'bin/Debug' directory of the project!");
                }

                catch (System.ArgumentNullException ex)
                {
                    Console.WriteLine("\n\n" + ex);
                }
                catch (System.Net.WebException wex)
                {
                    Console.WriteLine("\n\n" + wex);
                }
                catch (System.NotSupportedException nsex)
                {
                    Console.WriteLine("\n\n" + nsex);
                }
            }
        }
    }
}
