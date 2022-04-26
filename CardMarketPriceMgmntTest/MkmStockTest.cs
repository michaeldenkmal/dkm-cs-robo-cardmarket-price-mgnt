using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardMarketPriceMgmnt;
using System;

namespace CardMarketPriceMgmntTest
{
    [TestClass]
    public class MkmStockTest
    {
        [TestMethod]
        public void test_downloadStock()
        {
            int max_art_num = 300000;
            string stockDownLoadFolder = @"D:\projekte\csharp\dkm-cs-robo-cardmarket-price-mgnt\CardMarketPriceMgmntTest\files\stock";
            MkmStock_h.downloadAllStocks(RoboAppKeyConst.cardMarkAppToken, EnRootApiUrl.production, stockDownLoadFolder, 1, max_art_num);
        }
    }
}
