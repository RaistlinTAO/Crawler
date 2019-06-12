#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  clsARFF.cs
// 
// CREATED IN 8:07 PM (06/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using System.Collections.Generic;
using Crawler.BaseClass;

namespace Crawler.LOGIC
{
    public class clsARFF
    {
        public static void WriteARFF(clsURL[] iURL, string Path)
        {
            //Firstly, generate the Head of ARFF
            string iTemp = ARFFHead() + ARFAttributes();
            //Then generate the data part
            iTemp += ARFFDataPart(iURL);
            //Write to file
            clsFileStorer.StoreinFile(iTemp, Path);
        }

        private static string ARFFDataPart(IEnumerable<clsURL> URL)
        {
            string iTemp = "";
            foreach (clsURL clsUrl in URL)
            {
                if (clsUrl.FileSave != "NETWORK ERROR")
                {
                    iTemp += "\"" + clsUrl.URL + "\"," + clsFileStorer.CheckFileSize(clsUrl.FileSave) + "," +
                         clsParse.GetSecondLabelFromURL(clsUrl.URL) + ",\"" + clsUrl.FileSave +
                         "\"," + GetMobileString(clsUrl) + "\r\n";
                }
                else
                {
                    iTemp += "\"" + clsUrl.URL + "\",0" + "," +
                         clsParse.GetSecondLabelFromURL(clsUrl.URL) + ",\"" + "NOT AVAILABLE" +
                         "\"," + GetMobileString(clsUrl) + "\r\n";
                }
                
            }
            return iTemp;
        }

        private static string GetMobileString(clsURL iURL)
        {
            return iURL.IsMobile ? "Mobile" : "NotMobile";
        }

        private static string ARFFHead()
        {
            return " % 1. Title: Crawler Database\r\n" +
                   " % \r\n" +
                   " % 2. Sources: \r\n" +
                   " %      (a) Creator: Chen Chen (s3361039) with Xu Song (s3289486) \r\n" +
                   " %      (c) Date: June, 2013 \r\n" +
                   " % \r\n" +
                   " @RELATION Crawler\r\n";
        }

        private static string ARFAttributes()
        {
            return " @ATTRIBUTE URL string\r\n" +
                   " @ATTRIBUTE Length numeric\r\n" +
                   " @ATTRIBUTE Lable string\r\n" +
                   " @ATTRIBUTE StoreFile string\r\n" +
                   " @ATTRIBUTE class        {Mobile,NotMobile} \r\n" +
                   " @DATA\r\n";
        }
    }
}