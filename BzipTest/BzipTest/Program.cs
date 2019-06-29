using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BzipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\users\\mhatmaker\\test.bz2";
            var bz = new BzipWriter(path);

            int iterations = 1000000;
            Console.WriteLine("Performing {0:#,###,###} writelines to compressed file...", iterations);
            for (int i = 0; i < iterations; ++i)
            {
                string addTextToFile = string.Format("{0}  Here is another log entry (iteration {1})", DateTime.Now, i);
                bz.WriteLine(addTextToFile);
            }

            bz.Close();
        }

    } // END OF CLASS Program
} // END OF NAMESPACE
