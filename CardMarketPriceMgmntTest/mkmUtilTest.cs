using CardMarketPriceMgmnt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CardMarketPriceMgmntTest
{
    [TestClass]
    public class mkmUtilTest
    {
        [TestMethod]
        public void test_saveBase64BinJsonValueToFile()
        {
            string base64JsonValueFilePath = @"D:\projekte\csharp\dkm-cs-robo-cardmarket-price-mgnt\CardMarketPriceMgmntTest\files\base64JsonValue.txt";
            string gzipOutPath = @"D:\projekte\csharp\dkm-cs-robo-cardmarket-price-mgnt\CardMarketPriceMgmntTest\files\base64JsonValue.gzip";
            string value =File.ReadAllText(base64JsonValueFilePath);
            CardMarketUtil.saveBase64BinJsonValueToFile(value, gzipOutPath);
        }
    }
}
