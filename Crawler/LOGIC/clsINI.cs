#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  clsINI.cs
// 
// CREATED IN 12:14 AM (06/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Crawler.LOGIC
{
    public class clsINI
    {
        #region API函数声明

        [DllImport("kernel32")] //返回0表示失败，非0为成功
        private static extern long WritePrivateProfileString(string section, string key,
                                                             string val, string filePath);

        [DllImport("kernel32")] //返回取得字符串缓冲区的长度
        private static extern long GetPrivateProfileString(string section, string key,
                                                           string def, StringBuilder retVal, int size, string filePath);

        #endregion

        #region 读Ini文件

        public static string ReadIniData(string Section, string Key, string NoText, string iniFilePath)
        {
            if (File.Exists(iniFilePath))
            {
                var temp = new StringBuilder(1024);
                GetPrivateProfileString(Section, Key, NoText, temp, 1024, iniFilePath);
                return temp.ToString();
            }
            else
            {
                return String.Empty;
            }
        }

        #endregion

        #region 写Ini文件

        public static bool WriteIniData(string Section, string Key, string Value, string iniFilePath)
        {
            if (File.Exists(iniFilePath))
            {
                long OpStation = WritePrivateProfileString(Section, Key, Value, iniFilePath);
                return OpStation != 0;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}