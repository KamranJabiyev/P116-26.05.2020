using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStructEnum
{
    class Program
    {
        public enum Weekdays { Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday};
        public enum ErrorExp { NotFound=404,Server=500 };
        static void Main(string[] args)
        {
            #region Struct
            //Area area1 = new Area();
            //area1.X = 10;
            //Area area2 = area1;
            //area2.X = 100;

            //Console.WriteLine(area1.X);
            //Console.WriteLine(area2.X);
            //int a;
            //Area area;
            //area.X = 10;
            //area.Y = 100;
            //area.MyProperty = 1000;
            //Console.WriteLine(area.GetArea());
            //Console.WriteLine(area.X);
            #endregion

            #region Enum
            //Console.WriteLine(Weekdays.Sunday);
            //int day = 7;
            //switch (day)
            //{
            //    case (int)Weekdays.Saturday:
            //        Console.WriteLine("Istirahet ele 2 gun");
            //        break;
            //    case (int)Weekdays.Sunday:
            //        Console.WriteLine("Istirahetin son gunu");
            //        break;
            //    default:
            //        Console.WriteLine("Ishlemelisen");
            //        break;
            //}
            //foreach (var item in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine((int)item);
            //}
            #endregion
        }
    }
    #region Struct
    //Struct -complex value type
    //new keywordu olmadan da bir object yaradila biler,amma ancaq field-lere el chatacaq
    //bosh constructor istifade ede bilmersen!!! Yalniz static bosh const olur!!!
    //constructor-da butun field ve propert-ler assigned olunmalidir!!!
    //miras alib -miras vere bilmir!!!
    //yalniz interface-lerden miras alir
    //interface ICalculate
    //{
    //    int GetArea();
    //}
    //struct Area:ICalculate
    //{
    //    public int X;
    //    public int Y;
    //    public int MyProperty { get; set; }
    //    static Area()
    //    {
    //        Console.WriteLine("Bir defe ishleyecek");
    //    }
    //    public Area(int x,int y,int mypro)
    //    {
    //        X = x;
    //        Y = y;
    //        MyProperty=mypro;
    //    }

    //    public int GetArea()
    //    {
    //        return X*Y;
    //    }
    //}
    #endregion

    #region Interface
    //interface - public ve internal ola biler.
    //field ishlene bilmez
    //members- access modifiers ishledilmir.
    //c# 8.0 versiyaya qeder methodlarin body-i olmur.
    //I can yanashmasi ile ishledilir.
    //1 class bi neche interface-den miras ala biler
    //instance almaq olmur


    //interface IEatable
    //{
    //    int MyProperty { get; set; }
    //    void Eat();
    //}
    //interface IRunable
    //{
    //    void Run();
    //    int Sum(int x, int y);
    //}

    //class Test
    //{

    //}

    //class Human : Test, IRunable, IEatable
    //{
    //    public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public void Eat()
    //    {
    //        Console.WriteLine("Eat as Human");
    //    }

    //    public void Run()
    //    {
    //        Console.WriteLine("Run as Human"); ;
    //    }

    //    public int Sum(int x, int y)
    //    {
    //        return x + y;
    //    }
    //}

    //class Animal : IRunable
    //{
    //    public void Run()
    //    {
    //        Console.WriteLine("Run as Animal");
    //    }

    //    public int Sum(int x, int y)
    //    {
    //        return x + y;
    //    }
    //}
    #endregion

}
