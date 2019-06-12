#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  frmShow.cs
// 
// CREATED IN 6:38 PM (06/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using System;
using System.Globalization;
using System.Windows.Forms;
using Crawler.BaseClass;

namespace Crawler.UI
{
    public partial class frmShow : Form
    {
        private readonly string _SeedURL;
        private readonly string _Website;
        private readonly clsURL[] _iFinishedQueue;
        private readonly clsURL[] _iQueue;

        public frmShow(clsURL[] Queue, clsURL[] FinishedQueue, string Website, string SeedURL)
        {
            InitializeComponent();
            _iQueue = Queue;
            _iFinishedQueue = FinishedQueue;
            _Website = Website;
            _SeedURL = SeedURL;
        }

        private void frmShow_Load(object sender, EventArgs e)
        {
            txtWebSite.Text = _Website;
            txtSeedURL.Text = _SeedURL;
            int iQueueNum = _iQueue.Length;
            int iFinishedQueueNum = _iFinishedQueue.Length;
            txtQueueNum.Text = iQueueNum.ToString(CultureInfo.InvariantCulture);

            txtFinishedQueue.Text = iFinishedQueueNum.ToString(CultureInfo.InvariantCulture);

            for (int i = 0; i < iFinishedQueueNum; i++)
            {
                var iRawItem = new ListViewItem();
                var iTemp = _iFinishedQueue[i];
                iRawItem.Text = iTemp.URL;
                iRawItem.SubItems.Add(iTemp.IsMobile ? "True" : "False");
                iRawItem.SubItems.Add(iTemp.FileSave);

                lsvFinished.Items.Add(iRawItem);
            }

            for (int i = 0; i < iQueueNum; i++)
            {
                var iRawItem = new ListViewItem();
                var iTemp = _iQueue[i];
                iRawItem.Text = iTemp.URL;
                lsvQueue.Items.Add(iRawItem);
            }
        }
    }
}