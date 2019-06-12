#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  frmClassifier.cs
// 
// CREATED IN 6:45 PM (06/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using System;
using System.Collections.Specialized;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Crawler.BaseClass;
using Crawler.LOGIC;
using Crawler.Properties;

namespace Crawler.UI
{
    public partial class frmClassifier : Form
    {
        private readonly string _iniFile;

        public frmClassifier(string iniFile)
        {
            InitializeComponent();
            _iniFile = iniFile;
        }

        private void frmClassifier_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private new void Refresh()
        {
            lstRules.Items.Clear();
            var resultList = new StringCollection();
            var iINIString = File.ReadAllText(_iniFile);
            try
            {
                var regexObj = new Regex(@"\[[^]\r\n]+\]");
                Match matchResult = regexObj.Match(iINIString);
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
            var iTemp = new clsSmartRule[resultList.Count];
            for (int i = 0; i < resultList.Count; i++)
            {
                var iTempRule = new clsSmartRule {Website = resultList[i].Replace("[", "")};
                iTempRule.Website = iTempRule.Website.Replace("]", "");
                iTempRule.PathBelongToMobile = clsINI.ReadIniData(iTempRule.Website, "MOBILEURL", "", _iniFile);
                var iTempRaw = new ListViewItem {Text = iTempRule.Website};
                iTempRaw.SubItems.Add(iTempRule.PathBelongToMobile);
                lstRules.Items.Add(iTempRaw);
                iTemp[i] = iTempRule;
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            var iNewRule = new clsSmartRule {Website = txtWebsite.Text, PathBelongToMobile = txtRules.Text};
            clsINI.WriteIniData(iNewRule.Website, "MOBILEURL", iNewRule.PathBelongToMobile, _iniFile);
            txtRules.Text = "";
            txtWebsite.Text = "";
            MessageBox.Show(Resources.frmClassifier_cmdAdd_Click_Rule_Added,
                            Resources.frmClassifier_cmdAdd_Click_Classifer, MessageBoxButtons.OK);
            Refresh();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstRules.SelectedItems[0].Text != "")
                {
                    clsFileStorer.DeleteLineinFile(_iniFile, lstRules.SelectedItems[0].Index);
                    Refresh();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}