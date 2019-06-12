#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  clsDownloader.cs
// 
// CREATED IN 10:57 PM (03/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using System;
using System.IO;
using System.Net;
using Crawler.BaseClass;
using Crawler.LOGIC;

namespace Crawler
{
    public class clsDownloader
    {
        public enum DownloadUA
        {
            MozillaFirefox,
            MSIE,
            Chrome
        }

        public static string Download(clsURL url, DownloadUA iUA, string StoragePath)
        {
            var client = new WebClient();
            string iReturn;
            string iUAString = "";
            switch (iUA)
            {
                case DownloadUA.Chrome:
                    iUAString = "";
                    break;
                case DownloadUA.MSIE:
                    iUAString = "";
                    break;
                case DownloadUA.MozillaFirefox:
                    iUAString = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";
                    break;
            }

            client.Headers.Add("user-agent", iUAString);
            try
            {
                Stream _data = client.OpenRead(url.URL);
                var _reader = new StreamReader(_data);
                iReturn = _reader.ReadToEnd();
                if (_data != null)
                {
                    _data.Close();
                    _reader.Close();
                }
            }
            catch (Exception)
            {
                return null;
            }

            if (!url.URL.ToLower().Contains("robots.txt"))
            {
                byte[] toEncodeAsBytes
                    = System.Text.Encoding.ASCII.GetBytes(url.URL);
                var iFileName = Convert.ToBase64String(toEncodeAsBytes);

                if (url.IsMobile)
                {
                    //Save to Mobile
                    

                    url.FileSave = StoragePath + "Mobile\\" + iFileName;
                    clsFileStorer.StoreinFile(iReturn, StoragePath + "Mobile\\" + iFileName);
                }
                else
                {
                    url.FileSave = StoragePath + "NonMobile\\" + iFileName;
                    //Save to NonMobile
                    clsFileStorer.StoreinFile(iReturn, StoragePath + "NonMobile\\" + iFileName);
                }
            }


            return iReturn;
        }
    }
}