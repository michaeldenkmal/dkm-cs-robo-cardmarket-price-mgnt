using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CardMarketPriceMgmnt
{
    public static class CardMarketUtil
    {

        public static void saveJsonFile(string json, string filePath)
        {
            File.WriteAllText(filePath, json, Encoding.UTF8);            
        }

        public static void saveBase64BinJsonValueToFile(string base64BinJsonValue, string fileName)
        {
            var buffer =Convert.FromBase64String(base64BinJsonValue);
            File.WriteAllBytes(fileName, buffer);
        }
    }
}
