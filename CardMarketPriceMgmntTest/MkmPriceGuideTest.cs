using CardMarketPriceMgmnt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CardMarketPriceMgmntTest
{
    [TestClass]
    public class MkmPriceGuideTest
    {
        [TestMethod]
        public void test_DownLoadFile()
        {
            var resultFolder = @"D:\projekte\csharp\dkm-cs-robo-cardmarket-price-mgnt\CardMarketPriceMgmntTest\files\price_guide";

            MkmPriceGuide_h.downLoadPriceGuide(RoboAppKeyConst.cardMarkAppToken, EnRootApiUrl.production, resultFolder);

        }
    }
}
