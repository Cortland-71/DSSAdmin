using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS3FormApplicaiton
{
    class Backup
    {
        //public string date = DateTime.Now.ToString("dd_MM_yyyy@hh-mm-ss");

        ////Creates all backups for jisseki file and currency file.
        //public void CreateBackups(string jissekiPath, string currencyPath)
        //{
        //    IOSystem ioSystemObj = new IOSystem();

        //    MakeJissekiBackup(jissekiPath);
        //    string latestCurrencyFile = ioSystemObj.FindLatestFile(currencyPath).ToString();
        //    MakeCurrencyBackup(currencyPath + latestCurrencyFile);
        //}

        ////Creates backup of latest currency file to Currencybackup
        //private void MakeCurrencyBackup(string latestCurrencyFile)
        //{
        //    File.Copy(latestCurrencyFile, $@"\\yganas01\YDrive\Drop\DSS\CurrencyBackup\CurrencyBackup-{date}.CSV");
        //}

        ////Creates backup of jisseki file to JissekiBackup
        //private void MakeJissekiBackup(string latestJissekiFile)
        //{
        //    File.Copy(latestJissekiFile, $@"\\yganas01\YDrive\Drop\DSS\JISSEKIbackup\JissekiBackup-{date}.CSV");
        //}
    }
}
