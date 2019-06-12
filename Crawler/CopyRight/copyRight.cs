#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  copyRight.cs
// 
// CREATED IN 9:11 PM (05/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using System.Text;

namespace Crawler.CopyRight
{
    public class copyRight
    {
        public static string CopyRightInfo()
        {
            var LoL = new byte[49];
            LoL[0] = 0x43;
            LoL[1] = 0x6f;
            LoL[2] = 0x64;
            LoL[3] = 0x65;
            LoL[4] = 0x20;
            LoL[5] = 0x42;
            LoL[6] = 0x79;
            LoL[7] = 0x20;
            LoL[8] = 0x43;
            LoL[9] = 0x68;
            LoL[10] = 0x65;
            LoL[11] = 0x6e;
            LoL[12] = 0x20;
            LoL[13] = 0x43;
            LoL[14] = 0x68;
            LoL[15] = 0x65;
            LoL[16] = 0x6e;
            LoL[17] = 0x20;
            LoL[18] = 0x28;
            LoL[19] = 0x73;
            LoL[20] = 0x33;
            LoL[21] = 0x33;
            LoL[22] = 0x36;
            LoL[23] = 0x31;
            LoL[24] = 0x30;
            LoL[25] = 0x33;
            LoL[26] = 0x39;
            LoL[27] = 0x29;
            LoL[28] = 0x20;
            LoL[29] = 0x26;
            LoL[30] = 0x20;
            LoL[31] = 0x58;
            LoL[32] = 0x75;
            LoL[33] = 0x20;
            LoL[34] = 0x53;
            LoL[35] = 0x6f;
            LoL[36] = 0x6e;
            LoL[37] = 0x67;
            LoL[38] = 0x20;
            LoL[39] = 0x28;
            LoL[40] = 0x73;
            LoL[41] = 0x33;
            LoL[42] = 0x32;
            LoL[43] = 0x38;
            LoL[44] = 0x39;
            LoL[45] = 0x34;
            LoL[46] = 0x38;
            LoL[47] = 0x36;
            LoL[48] = 0x29;

            return Encoding.UTF8.GetString(LoL);
        }
    }
}