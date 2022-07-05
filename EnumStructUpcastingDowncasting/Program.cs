using EnumStructUpcastingDowncasting.Models;
using System;

namespace EnumStructUpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Params
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            GetElements(1, 2, 3, 4, 5, 6);
            #endregion
            #region nullable
            //Test test = new Test();
            //Console.WriteLine(test.Number);

            //string name = null ;
            //int? age = null;


            ////var result = age == null ? 55 : 60;

            //var result = age ?? 60;

            //Console.WriteLine(result);

            //Test testt = null;
            //Console.WriteLine(test.Word.ToString());
            #endregion
            #region struct
            //Test test = new Test();

            //Console.WriteLine(test.Num);
            Test2 test2 = new Test2(5);
            #endregion

            #region upcasting
            //Eagle eagle1 = new Eagle();

            //Eagle eagle3 = new Eagle();
            //Shark shark1 = new Shark();
            //animal shark2 = new Shark();
            //animal eagle2 = eagle1;
            //animal[] animals = { eagle1, eagle2, eagle3, shark1, shark2 };
            //foreach (var item in animals)
            //{
            //    item.Eat();
            //}
            #endregion
            #region downcasting
            //int m = 500;
            //byte n = (byte)m;
            //Console.WriteLine(n);
            Shark shark1 = new Shark();
            animal shark2 = new Shark();
            Shark shark3 =(Shark) shark2;

            object[] objects = { 2, 5, "Salam" , shark3 };

            foreach (var item in objects)
            {
                if (item is Shark)
                {
                    ((Shark)item).Weight = 500;
                    Console.WriteLine(((Shark)item).Weight);
                }
            }
            #endregion
        }
        #region struct
        struct Test
        {
            public int Num { get; set; }
        }
        class Test1 
        {
            
        }
        class Test2
        {
            public int MyProperty { get; set; } = 66;

            public Test2()
            {
                Console.WriteLine("bosh");
            }
            public Test2(int b)
            {
                Console.WriteLine("dolu");
            }
        }
        struct Test3
        {

        }
        interface ITest 
        {

        }
        #endregion
        #region Params
        public static void GetElements(params int[] nums)
        {
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
        #endregion


        #region enum
        static void CheckRole(int roleId)
        {
            switch (roleId)
            {
                case (int)Roles.SuperAdmin:
                    Console.WriteLine("Super Admin");
                    break;
                case (int)Roles.Admin:
                    Console.WriteLine("Admin");
                    break;
                case (int)Roles.Member:
                    Console.WriteLine("member");
                    break;
            }
        }
        #endregion
        #region nullable
    }
    class Test
    {
        public int? Number { get; set; }

        public string Word { get; set; }
    }
    #endregion
    #region enum
    public enum Roles
    {
        SuperAdmin,
        Admin,
        Member
    }
    #endregion



}
