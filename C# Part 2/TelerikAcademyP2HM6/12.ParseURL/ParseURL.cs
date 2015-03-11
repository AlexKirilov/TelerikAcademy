using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	Information
http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
[server] = telerikacademy.com 
[resource] = /Courses/Courses/Details/212*/
namespace _12.ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            Uri myUri = new Uri("http://telerikacademy.com/Courses/Courses/Details/212");
            
            //Get protocol part
            string protocol = myUri.Scheme;
            // Get host part (host name or address and port). Returns "server:8080".
            string hostpart = myUri.Authority;

            // Get path and query string parts. Returns "/func2/SubFunc2?query=somevalue".
            string pathpart = myUri.PathAndQuery;

            Console.WriteLine("The entered URL is: {0}\n", myUri);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server]   = {0}", hostpart);
            Console.WriteLine("[resource] = {0}", pathpart);
        }
    }
}
