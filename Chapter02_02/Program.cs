using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_02
{
    class Program
    {
        public int SumAll(params int[] aNumbers)
        {
            int i;
            int tmp = 0;
            for (i = 0; i < aNumbers.Length; i++)
            {
                tmp += aNumbers[i];
            }
            return (tmp);
        }
        public void SelectCard(int aNumber, string aShape)
        {
            Console.WriteLine("Shape:{0}, Number:{1}", aShape, aNumber % 13 + 1);
        }
        public void MakeCard(int aNumber,string aShape = "Diamond")
        {
            Console.WriteLine("shape:{0}, Number{1}", aShape, aNumber);
        }
        static void Main(string[] args)
        {
            Program tmpC = new Program();
            int total1 = tmpC.SumAll(1, 2);
            int total2 = tmpC.SumAll(1, 2, 3, 4, 5);
            int total3 = tmpC.SumAll(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine(total1);
            Console.WriteLine(total2);
            Console.WriteLine(total3);

            int[] param4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int total4 = tmpC.SumAll(param4);
            Console.WriteLine(total4);

            tmpC.SelectCard(10, "Diamond");
            tmpC.SelectCard(aNumber: 12, aShape: "Diamond");
            tmpC.SelectCard(aShape: "Heart", aNumber: 12);

            tmpC.MakeCard(7);
            tmpC.MakeCard(10, "Heart");

            CSmartPhone tmpSP1 = new CSmartPhone();
            CSmartPhone tmpSP2 = new CSamsungPhone();
            CSmartPhone tmpSP3 = new CLGPhone();

            Console.WriteLine(tmpSP1.GetMarket());
            Console.WriteLine(tmpSP2.GetMarket());
            Console.WriteLine(tmpSP3.GetMarket());

            Console.WriteLine(tmpSP1.GetButtonCount());
            Console.WriteLine(tmpSP2.GetButtonCount());
            Console.WriteLine(tmpSP3.GetButtonCount());

            if(tmpSP2 is CSamsungPhone)
            {
                CSamsungPhone tmpSP4 = (CSamsungPhone)tmpSP2;
                Console.WriteLine(tmpSP4.GetButtonCount());
            }

            CLGPhone tmpSP5 = tmpSP3 as CLGPhone; //==(CLGPhone)tmpSP3
            if(tmpSP5 != null)
            {
                Console.WriteLine(tmpSP5.GetButtonCount());
            }
            CSmartPhone tmpSP7 = new CSmartPhone();
            CSmartPhone tmpSP8 = new CSmartPhone();
            CSmartPhone tmpSP9;//new CSmartPhone();

            UseSmartPhone(tmpSP7);
            ChargeSmartPhone(ref tmpSP8); //생성한 채로 넘거야 한다
            MakeSmartPhone(out tmpSP9);

            Console.WriteLine(tmpSP7.theID);
            Console.WriteLine(tmpSP8.theID);
            Console.WriteLine(tmpSP9.theID);

        }
        static void UseSmartPhone(CSmartPhone aPhone)
        {
            aPhone.theID = "Use";
        }
        static void ChargeSmartPhone(ref CSmartPhone aPhone)
        {
            aPhone.theID = "Charge";
        }
        static void MakeSmartPhone(out CSmartPhone aPhone)
        {
            aPhone = new CSmartPhone(); //out은 무조건 생성을 해야된다
            aPhone.theID = "Make";
        }
    }
}
