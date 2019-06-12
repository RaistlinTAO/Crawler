#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  clsFileStorer.cs
// 
// CREATED IN 10:57 PM (03/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using System.IO;

namespace Crawler.LOGIC
{
    public class clsFileStorer
    {
        /// <summary>
        ///     Store String in to a FILE
        /// </summary>
        /// <param name="txtString">HTML String</param>
        /// <param name="FileName">File Name(including Path)</param>
        public static void StoreinFile(string txtString, string FileName)
        {
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
            }

            //File.Create(FileName);

            //System.IO.File.WriteAllText(FileName, txtString);

            StreamWriter streamw = File.CreateText(FileName);
            streamw.WriteLine(txtString);
            streamw.Close();
        }

        public static long CheckFileSize(string Path)
        {
            var f = new FileInfo(Path);
            return f.Length;
        }

        public static void DeleteFolder(string dir)
        {
            foreach (string f in Directory.GetFileSystemEntries(dir))
            {
                if (File.Exists(f))
                {
                    var fi = new FileInfo(f);
                    if (fi.Attributes.ToString().IndexOf("Readonly", System.StringComparison.Ordinal) != 1)
                    {
                        fi.Attributes = FileAttributes.Normal;
                    }
                    File.Delete(f);
                }
                else
                {
                    DeleteFolder(f);
                }
            }
            Directory.Delete(dir);
        }

        public static void DeleteLineinFile(string Path, int Index)
        {
            //Index means double line
            var iTemp = File.ReadAllLines(Path);
            var iResult = "";
            for (int i = 0; i < iTemp.Length; i++)
            {
                if (i != Index*2 && i != Index*2 + 1)
                {
                    iResult += iTemp[i]+"\r\n";
                }
            }
            StoreinFile(iResult.Replace("\r\n\r\n", "\r\n"), Path);
        }
    }
}