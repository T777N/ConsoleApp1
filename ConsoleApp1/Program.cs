using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Task 1

//namespace task1
//{
//    class Point
//    {
//        public int X { get; set; }
//        public int Y { get; set; }
//        public Point()
//        {
//            X = default;
//            Y = default;
//        }
//        public Point(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }
//        public void Show()
//        {
//            Console.WriteLine($" - - - - Informations - - - - ");
//            Console.WriteLine($" X : {X} ");
//            Console.WriteLine($" Y : {Y} ");

//        }

//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Point p = new Point(10, 20);
//            p.Show();

//        }
//    }
//}

#endregion

#region Task 2

//class Counter
//{
//    public int Min { get; set; }
//    public int Max { get; set; }
//    public int CurrentData { get; set; }

//    public Counter()
//    {
//        Min = default;
//        Max = default;
//        CurrentData = Min;
//    }
//    public Counter(int min,int max)
//    {
//        Min = min;
//        Max = max;
//        CurrentData = Min;
//    }
//    public void Increment()
//    {
//        if (CurrentData != Max)
//        {

//        ++CurrentData;
//        }
//        else
//        {
//            CurrentData = Min;
//        }
//    }
//    public void Decrement()
//    {
//        if (CurrentData != Min)
//        {

//        --CurrentData;
//        }

//    }
//    public void GetCurrent()
//    {
//        Console.WriteLine($" Current data : {CurrentData} ");
//    }
//}

//class Program
//{

//static void Main(string[] args)
//{
//        Counter c = new Counter(5, 7);
//        c.Increment();
//        c.GetCurrent();
//        c.Decrement();
//        c.GetCurrent();
//}

//}
#endregion

#region Task 3
//class Fraction
//{
//    public double Add(double first,double second)
//    {
//        return first + second;
//    }
//    public double Minus(double first, double second)
//    {
//        return first-second;
//    }
//    public double Multiply(double first, double second)
//    {
//        return first * second;
//    }
//    public double Divide(double first, double second)
//    {
//        if (second != 0)
//        {
//            return first / second;
//        }
//        else
//        {
//            return -10000;
//        }
//    }
//    public bool Compare(double first, double second)
//    {
//        if (first > second)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
   
//    }

//}

//class Program
//{
//static void Main(string[] args)
//{
//        Fraction fraction = new Fraction();
//        Console.WriteLine($" Result : "+ fraction.Add(10, 5) ); 
//        Console.WriteLine($" Result : "+ fraction.Minus(10, 5) ); 
//        Console.WriteLine($" Result : "+ fraction.Multiply(10, 5) ); 
//        Console.WriteLine($" Result : "+ fraction.Divide(10, 5) ); 
//        Console.WriteLine($" Result : "+ fraction.Compare(10, 5) ); 
       
//}
//}
#endregion