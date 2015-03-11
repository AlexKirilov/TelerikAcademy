﻿using System;
/*Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags
<a href="…">…</a> with corresponding tags [URL=…]…/URL].
Example:

input	output
<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
 <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
 Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>*/
namespace _15.Replace_Tags
{
    class ReplaceTags
    {
        static void Main()
        {
            Console.WriteLine("Text with tag < a href=...");
            string str = Console.ReadLine();

            //Default value
            if (str.Length < 5) { 
                str = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
                Console.WriteLine(str + "\n\n");
            }

            str = str.Replace("<a href=\"", "[URL=");
            str = str.Replace("\">", "]");
            str = str.Replace("</a>", "[/URL]");

            Console.WriteLine(str);
        }
    }
}
