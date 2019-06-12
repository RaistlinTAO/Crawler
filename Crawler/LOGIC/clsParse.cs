#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  clsParse.cs
// 
// CREATED IN 11:01 PM (03/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using System;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace Crawler.LOGIC
{
    public class clsParse
    {
        public static string GetSecondLabelFromURL(string URL)
        {
            try
            {
                //http://www.xxx.com/xxx/xxx/2xxx.html
                var iTemp = URL.Split('/');
                return iTemp[3];
            }
            catch (Exception)
            {
                return "Unknown";
            }
        }

        public static StringCollection CheckURLinHTML(string HTML)
        {
            var resultList = new StringCollection();
            try
            {
                var regexObj =
                    new Regex(
                        @"\b((?#protocol)https?|ftp)://((?#domain)[-A-Z0-9.]+)((?#file)/[-A-Z0-9+&@#/%=~_|!:,.;]*)?((?#parameters)\?[A-Z0-9+&@#/%=~_|!:,.;]*)?",
                        RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
                Match matchResult = regexObj.Match(HTML);
                while (matchResult.Success)
                {
                    resultList.Add(matchResult.Value);
                    matchResult = matchResult.NextMatch();
                }
            }
            catch (ArgumentException)
            {
                // Syntax error in the regular expression
            }

            return resultList;
        }

        public static bool CheckURL(string iURL)
        {
            try
            {
                return Regex.IsMatch(iURL,
                                     @"\b(https?)://[-A-Z0-9+&@#/%?=~_|$!:,.;]*[A-Z0-9+&@#/%=~_|$]",
                                     RegexOptions.IgnoreCase | RegexOptions.Multiline |
                                     RegexOptions.IgnorePatternWhitespace);
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public static string GetHostFromUrl(string iURL)
        {
            string resultString = null;
            try
            {
                resultString = Regex.Match(iURL,
                                           @"^
		[a-z][a-z0-9+\-.]*://               # Scheme
		([a-z0-9\-._~%!$&'()*+,;=]+@)?      # User
		(?<host>[a-z0-9\-._~%]+             # Named or IPv4 host
		|\[[a-z0-9\-._~%!$&'()*+,;=:]+\])   # IPv6+ host
		",
                                           RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace).Value;
            }
            catch (ArgumentException)
            {
                // Syntax error in the regular expression
            }

            return resultString;
        }

        public static bool CheckURLInsideWebSite(string URL, string Host)
        {
            return GetHostFromUrl(URL) == Host;
            //return URL.StartsWith(Host);
        }

        public static bool CheckMETA(string URL)
        {
            return true;
        }

        public static bool CheckRobotRule(string URL, StringCollection RobotRule)
        {
            try
            {
                foreach (var iRule in RobotRule)
                {
                    if (URL.Contains(iRule))
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return true;
            }

            return true;
        }

        public static StringCollection ParseRobot(string Robotstxt)
        {
            var resultList = new StringCollection();
            try
            {
                var regexObj = new Regex("Disallow: *.+");
                Match matchResult = regexObj.Match(Robotstxt);
                while (matchResult.Success)
                {
                    resultList.Add(matchResult.Value.Replace("Disallow: ", ""));
                    matchResult = matchResult.NextMatch();
                }
            }
            catch (ArgumentException)
            {
                // Syntax error in the regular expression
            }
            return resultList;
        }
    }
}