#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  clsSmartRuleParser.cs
// 
// CREATED IN 5:25 PM (06/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using Crawler.BaseClass;

namespace Crawler.LOGIC
{
    public class clsSmartRuleParser
    {
        public static clsSmartRule[] GetRules(string Website, string RulesPath)
        {
            var iTemp = clsINI.ReadIniData(Website, "MOBILEURL", "", RulesPath).Split('.');

            var iReturn = new clsSmartRule[iTemp.Length];
            for (int i = 0; i < iTemp.Length; i++)
            {
                var iRuleTemp = new clsSmartRule {Website = Website, PathBelongToMobile = iTemp[i]};
                iReturn[i] = iRuleTemp;
            }
            return iReturn;
        }

        public static void SetRules(clsSmartRule Rule, string RulesPath)
        {
            clsINI.WriteIniData(Rule.Website, "MOBILEURL",
                                clsINI.ReadIniData(Rule.Website, "MOBILEURL", "", RulesPath) + "." +
                                Rule.PathBelongToMobile, RulesPath);
        }
    }
}