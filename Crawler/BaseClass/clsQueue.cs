#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  clsQueue.cs
// 
// CREATED IN 7:19 PM (04/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using System;
using System.Collections;

namespace Crawler.BaseClass
{
    public class clsQueue
    {
        private Queue _iQueue = new Queue();

        public Queue UrlQUEUE
        {
            get { return _iQueue; }
            set { _iQueue = value; }
        }

        public void AddURL(clsURL URL)
        {
            _iQueue.Enqueue(URL);
        }

        public clsURL VisitedURL()
        {
            if (_iQueue.Count > 0)
            {
                return (clsURL)_iQueue.Dequeue();
            }
            return null;
        }

        public int GetQueueNumber()
        {
            return _iQueue.Count;
        }

        public bool CheckVisited(clsURL URL)
        {
            return _iQueue.Contains(URL);
        }

        public clsURL[] CopyFromQueue()
        {
            Object[] iTemp = _iQueue.ToArray();
            var iResult = new clsURL[iTemp.Length];
            for (int i = 0; i < iTemp.Length; i++)
            {
                iResult[i] = (clsURL) iTemp[i];
            }

            return iResult;
        }
    }
}