//using System;

//namespace Lambdas
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

using System;

public class Program
{
    delegate int del(int i);

    public static void Main()
    {
        AnotherMain();

        Func<int, int> g = x => x + 3;
        int p = g(7);
        Console.WriteLine("sample 1 : " + p);

        del myDelegate = x => x * x;
        int j = myDelegate(5);
        Console.WriteLine("sample 2 : " + p);

        Func<int> f = () => 20; 
        Console.WriteLine("sample 3 : "+f());

        Func<int> f1= () => Cal();
        Console.WriteLine("sample 4 : "+f1());

        Action<int> ff = x => { Cal(x); };
        ff(3);

        Action<string> myDel = n =>
        {
         string s = n + " " + "World";
         Console.WriteLine("sample 6 : "+s);
        };
            myDel("Hello");
    }

    private static int Cal()
    {
        return 3 + 2;
    }

    static int Cal(int x)
    {
        int result = x * 5;
        Console.WriteLine("sample 5 : "+result);
        //Action void return type so need to write in method
        return result;
    }

    delegate double delegateDouble(double d);

    public static void AnotherMain()
    {

        int someVal = 7;

        delegateDouble myDelegate = x => x + x;
        Console.WriteLine("Lambda myDelegate = {0}", myDelegate(10));


        // delegate f points to lambda
        Func<int, int> f = x => x + someVal;

        Console.WriteLine("Lambda f = {0}", f(3));

    	Func<int, int, int> g = (x, y) => x + y + someVal;

    Console.WriteLine("Lambda g = {0}", g(2, 2));

    	Func<int, int, double> multi = (a, b) => a * b;
    Console.WriteLine($"Result is = { multi(25,2)}");
    }
}
