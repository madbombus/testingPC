using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;


namespace TestCPU
{
    class Tests
    {
        // Тест хеширования по алгоритму SHA1
        public string HashTest()
        {
            byte[] data = new byte[15000];
            byte[] result;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            SHA1 sha = new SHA1CryptoServiceProvider();
            for (int i=0; i<100000; i++)
                result = sha.ComputeHash(data);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

            return elapsedTime;
        }

        // Тест шифрования по алгоритму AES
        public string CriptTest()
        {
            // Здесь будет код
            return "0";
        }

        // Тест архивирования 
        public string CompressTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            
            string startPath = @"c:\example\start";
            FastZip zip = new FastZip();
            zip.CreateZip("my.zip", "toZip", true, null);


            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

            return elapsedTime;
        }

        // Тест обработки изображения 
        public string ImageTest()
        {
            // Здесь будет код
            return "0";
        }
    }
}
