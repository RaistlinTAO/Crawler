#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  clsURL.cs
// 
// CREATED IN 7:19 PM (04/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

namespace Crawler.BaseClass
{
    public class clsURL
    {
        public string URL { get; set; }

        public bool IsMobile { get; set; }

        public string FileSave { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as clsURL);
        }

        public bool Equals(clsURL other)
        {
            return (other.URL == URL);
        }
    }
}