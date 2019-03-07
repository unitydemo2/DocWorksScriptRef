using System;

delegate int NumberChanger(int n);
namespace DelegateAppl
{

    enum TestEnum
    {
        Hyderabad = 5,
        Banglore = 25
    }

    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            nc1((int)TestEnum.Banglore);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2((int)TestEnum.Hyderabad);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}