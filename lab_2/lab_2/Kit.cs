using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2
{
    class Kit
    {
        
        public string raw1;
        public string raw2;

        public Kit()
        {
            raw1 = "Слава" + "\t";
            raw2 = "Українi" + "\t";
        }

        public Kit(string raw1, string raw2)
        {
            this.Raw1 = raw1;
            this.Raw2 = raw2;

        }

        public string Raw1 { get; set; }
        public string Raw2 { get; set; }


        //методи

        public void GetInfo()
        {
            Console.WriteLine($"рядок1: {raw1} рядок2: {raw2}");
        }

        public string Concatenatsiya()
        {
            string RawSum = raw1 + raw2;
            Console.WriteLine("конкатенацiя двох рядкiв: " + RawSum);
            return RawSum;
            
        }

        public string Vyrizannya()
        {
            int startIndex = 6;
            int length = 7;
            string RawSum = raw1 + raw2; ;
            string substring = RawSum.Substring(startIndex, length);
            Console.WriteLine("вирiзання пiдрядка: ");
            return substring;

        }

        public void Rivnist()
        {
            bool equal;
            if (raw1 == raw2)
            {
                equal = true;
            }
            else
            {
                equal = false;
            }
            Console.WriteLine("рiвнiсть рядкiв: " + equal);
            
        }

        public void NeRivnist()
        {
            bool noequal;
            if (raw1 != raw2)
            {
                noequal = true;
            }
            else
            {
                noequal = false;
            }
            Console.WriteLine("нерiвнiсть рядкiв: " + noequal);
            
        }

        public void Menshe()
        {
            
            int x = String.CompareOrdinal(raw1, raw2);

            if (x < 0)
            {
                Console.WriteLine(raw1 + "< " + raw2);
            }
            else if (x == 0)
            {
                Console.WriteLine(raw1 + "=" + raw2);
            }
            else
            {
                Console.WriteLine(raw1 + "<" + raw2);
            }

        }


        public void Bilshe()
        {
            int x = String.CompareOrdinal(raw2, raw1);
            if (x > 0)
            {
                Console.WriteLine(raw2 + "> " + raw1);
            }
            else if (x == 0)
            {
                Console.WriteLine(raw1 + "=" + raw2);
            }
            else
            {
                Console.WriteLine(raw1 + "<" + raw2);
            }

        }




    }
}
