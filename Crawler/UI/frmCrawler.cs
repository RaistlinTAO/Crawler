#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  frmCrawler.cs
// 
// CREATED IN 12:05 AM (03/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Crawler.BaseClass;
using Crawler.LOGIC;
using Crawler.Properties;

namespace Crawler.UI
{
    public partial class frmCrawler : Form
    {
        private static int _iPoliteness = 10;
        //Time, in seconds, that the crawler must wait before attempting to fetch another page from the same 

        //host. If this item is not specified, your program should use a default delay of 10 seconds.
        private static int _iMaxPages = 20;
        //Limit the total number of pages that your crawler will fetch and store. If this option is not specified, 

        //your program should use a default maximum of 20 pages.
        private static String _iSeedPage;

        private static String _iWebSite;

        private static clsSmartRule[] _iRules;

        //private static int _iMaxThreads = 10;

        private readonly clsQueue iFinishedQueue = new clsQueue();
        private readonly clsQueue iQueue = new clsQueue();

        private StringCollection iRobot = new StringCollection();

        public frmCrawler(string[] args)
        {
            for (var i = 0; i < args.Length; i++)
            {
                if (args[i] == ("-politeness"))
                {
                    _iPoliteness = int.Parse(args[i + 1]);
                }
                if (args[i] == ("-maxpages"))
                {
                    _iMaxPages = int.Parse(args[i + 1]);
                }
                if (args[i] == ("-maxthreads"))
                {
                    //_iMaxThreads = int.Parse(args[i + 1]);
                }
            }
            if (clsParse.CheckURL(args[args.Length - 1]))
            {
                _iSeedPage = args[args.Length - 1];
            }
            else
            {
                Close();
            }
            try
            {
                clsFileStorer.DeleteFolder(Application.StartupPath + "\\storage");
            }
            catch (Exception)
            {
                //
            }


            InitializeComponent();
            cmdStart.Enabled = false;
            ReCreateSetting();
            var iSeedURL = new clsURL {URL = _iSeedPage};
            iQueue.AddURL(iSeedURL);
            _iWebSite = clsParse.GetHostFromUrl(_iSeedPage);
            AddLog("WebSite Host: " + _iWebSite);
        }


        private void ParseRobot()
        {
            var iTemp = new clsURL {URL = clsParse.GetHostFromUrl(_iSeedPage) + "/robots.txt"};
            //iTemp.IsMobile = true;
            iRobot = clsParse.ParseRobot(clsDownloader.Download(iTemp,
                                                                clsDownloader.DownloadUA.MozillaFirefox,
                                                                Application.StartupPath +
                                                                Resources.frmCrawler_ReCreateSetting__storage_));
        }


        private void StartCrawlerJob()
        {
            AddLog("Start Crawler!");

            Directory.CreateDirectory(Application.StartupPath + Resources.frmCrawler_ReCreateSetting__storage_);
            Directory.CreateDirectory(Application.StartupPath + "\\storage\\Mobile");
            Directory.CreateDirectory(Application.StartupPath + "\\storage\\NonMobile");
            AddLog("Webpages download directory created.");

            for (var i = 0; i < _iMaxPages; i++)
            {
                var iURL = iQueue.VisitedURL();

                if (iURL == null)
                {
                    AddLog("No more unvisited URL in the queue!");
                    return;
                }

                //Check classification model to judge Mobile or not
                var isMobile = false;
                foreach (clsSmartRule iRule in _iRules)
                {
                    if (iURL.URL.ToLower().Contains(iRule.PathBelongToMobile.ToLower()))
                    {
                        isMobile = true;
                    }
                }

                iURL.IsMobile = isMobile;
                //txtNextURL.Text = iURL.URL;
                txtCurrentURL.Text = iURL.URL;
                //FetchWebpage(iURL);
                AddLog("Fetching " + iURL.URL);
                FetchWebDelegate dn = FetchWebpage;

                IAsyncResult iar = dn.BeginInvoke(iURL, null, null);

                while (iar.IsCompleted == false)
                {
                    Application.DoEvents();
                }

                dn.EndInvoke(iar);
                if (iURL.FileSave != null)
                {
                    txtCurrentStorage.Text = iURL.FileSave;
                    AddLog("Stored: " + iURL.FileSave);
                    txtStoredNum.Text = iFinishedQueue.GetQueueNumber().ToString(CultureInfo.InvariantCulture);
                    
                }
                else
                {
                    iURL.FileSave = "NETWORK ERROR";
                    txtCurrentStorage.Text = "Network problem: Can't read webpage";
                    AddLog("Network problem: Can't read webpage: " + iURL.URL);
                }
                //Show Queue Number in UI
                txtQueueNum.Text = iQueue.GetQueueNumber().ToString(CultureInfo.InvariantCulture);
                txtVisitedNum.Text = iFinishedQueue.GetQueueNumber().ToString(CultureInfo.InvariantCulture);
                
                //Application.DoEvents();
            }
        }

        public void FetchWebpage(clsURL URL)
        {
            var s =
                clsParse.CheckURLinHTML(clsDownloader.Download(URL, clsDownloader.DownloadUA.MozillaFirefox,
                                                               Application.StartupPath +
                                                               Resources.frmCrawler_ReCreateSetting__storage_));


            iFinishedQueue.AddURL(URL);

            try
            {
                if (s.Count != 0)
                {
                    foreach (var iURL in s)
                    {
                        //Check if the URL is suitable
                        if (CheckURL(iURL))
                        {
                            var iTempURL = new clsURL { URL = iURL };
                            iQueue.AddURL(iTempURL);
                        }
                    }
                    Thread.Sleep(_iPoliteness * 1000);
                }
                else
                {
                    MessageBox.Show("Network problem. Fetch error in: " + URL.URL);
                }
                
            }
            catch (Exception)
            {
                //Due to network problem the url could not fetched! especially the seed url
                MessageBox.Show("Network problem. Fetch error in: " + URL.URL);
            }
           
        }

        private bool CheckURL(string url)
        {
            //1. Check if is inside website
            //2. Check METE
            //3. Check ROBOT
            var iTemp = new clsURL {URL = url};
            //Use This to prevert "#comment" fragment
            var UrlContainHash = !url.Contains("#");
            var UrlContainEqual = !url.Contains("=");
            return (clsParse.CheckURLInsideWebSite(url, _iWebSite) && !iQueue.CheckVisited(iTemp) &&
                    !iFinishedQueue.CheckVisited(iTemp) && UrlContainHash && UrlContainEqual &&
                    clsParse.CheckRobotRule(url, iRobot));
        }

        private void AddLog(string Log)
        {
            lstLog.Items.Add(DateTime.Now.ToLongTimeString() + " -- " + Log);
            lstLog.SelectedIndex += 1;
        }

        private void ReCreateSetting()
        {
            AddLog("System Initialised");
            txtPoliteness.Text = _iPoliteness.ToString(CultureInfo.InvariantCulture);
            AddLog("Politeness value set to " + _iPoliteness);
            txtMaxpages.Text = _iMaxPages.ToString(CultureInfo.InvariantCulture);
            AddLog("Maxpages value set to " + _iMaxPages);
            //txtMaxThreads.Text = _iMaxThreads.ToString(CultureInfo.InvariantCulture);
            //AddLog("MaxThreads value set to " + _iMaxThreads);
            txtSeedURL.Text = _iSeedPage;
            AddLog("Seed URL value set to " + _iSeedPage);
            txtPosition.Text = Application.StartupPath + Resources.frmCrawler_ReCreateSetting__storage_;
        }


        private void cmdStart_Click(object sender, EventArgs e)
        {
            cmdStart.Enabled = false;
            cmdClassifier.Enabled = false;
            StartCrawlerJob();
            cmdStart.Enabled = true;
            AddLog("Crawler Finished");
            cmdShow.Enabled = true;
            cmdArff.Enabled = true;
            cmdClassifier.Enabled = true;
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            var iAbout = new frmAbout();
            iAbout.ShowDialog();
        }

        private void frmCrawler_Load(object sender, EventArgs e)
        {
            txtCopyRight.Text = CopyRight.copyRight.CopyRightInfo();
            ParseRobotDelegate dn = ParseRobot;

            IAsyncResult iar = dn.BeginInvoke(null, null);

            while (iar.IsCompleted == false)
            {
                Application.DoEvents();
            }

            dn.EndInvoke(iar);
            AddLog("Robots.txt in seed url:" + _iSeedPage + " Parsed!");

            _iRules = clsSmartRuleParser.GetRules(_iWebSite, Application.StartupPath + "\\SmartRules.bin");
            AddLog("Classification Model Smart Rules Parsed!");

            cmdStart.Enabled = true;
        }

        private void cmdArff_Click(object sender, EventArgs e)
        {
            //Convert FinishedQueue to Arff file
            var iTemp2 = iFinishedQueue.CopyFromQueue();

            WriteARFFDelegate dn = clsARFF.WriteARFF;

            IAsyncResult iar = dn.BeginInvoke(iTemp2, Application.StartupPath + "\\Crawlar.arff", null, null);

            while (iar.IsCompleted == false)
            {
                Application.DoEvents();
            }

            dn.EndInvoke(iar);

            //clsARFF.WriteARFF(iTemp2,Application.StartupPath+"\\Crawlar.arff");
            MessageBox.Show(Resources.frmCrawler_cmdArff_Click_ARFF_generated_, Application.ProductName,
                            MessageBoxButtons.OK);
            AddLog("Crawler Data ARFF File Generated in " + Application.StartupPath + "\\Crawlar.arff");
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            var iTemp = iQueue.CopyFromQueue();
            var iTemp2 = iFinishedQueue.CopyFromQueue();
            var iShown = new frmShow(iTemp, iTemp2, _iWebSite, _iSeedPage);
            iShown.ShowDialog();
        }

        private void cmdClassifier_Click(object sender, EventArgs e)
        {
            var iClassifier = new frmClassifier(Application.StartupPath + "\\SmartRules.bin");
            iClassifier.ShowDialog();
        }

        private delegate void FetchWebDelegate(clsURL iURL);

        private delegate void ParseRobotDelegate();

        private delegate void WriteARFFDelegate(clsURL[] iURL, string Path);
    }
}