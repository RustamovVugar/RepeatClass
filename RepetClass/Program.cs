using RepetClass.Models;
using Service;
using Service.Helpers.Extension;
using Service.Services;
using Service.Services.Interfaces;
using System;

namespace RepetClass
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Homework
            //AccountController account = new AccountController();
            //account.Login();

            //int num = 4;
            //if (num < 0)
            //{
            //    Console.WriteLine("Duzgun eded daxil edin");
            //    return;
            //}
            //Console.WriteLine(num.CalculateFactorial()); 
            #endregion

            //int num1 = 50;
            //byte num2 = (byte)num1;
            //Console.WriteLine(num2);


            //Eagle eagel = new Eagle();
            //Animal animal1 = eagle1;
            // Animal animal2 = new Eagle();

            //int a = 5;
            //object b = a;
            //int c = (int)b

            //string a = "50";
            //object b = a;

            //string c = b.ToString(); 
            //Console.WriteLine(b);
            //string age = "30";
            //int result = int.Parse(age);
            //Console.WriteLine(result);

            //Eagle eagle1 = new Eagle();
            //Animal eagle2 = new Eagle();


            //Shark shark3 = (Shark)shark2;

            //Animal[] animals = { eagle1, eagle2, shark1, shark2 };
            //foreach (var item in animals)
            //{
            //    Console.WriteLine(item.Name);
            //}


            Animal shark1 = new Shark();
            Animal eagle1 = new Eagle();

            object[] objects = { 1, 2, "P414", shark1, eagle1 };

            foreach (var item in objects)
            {
                Animal animal = item as Animal;
                bool isCast = animal == null ? true : false;
                if (isCast)
                {
                    string result = animal.Name ?? "jhdjsfs";
                    Console.WriteLine(result);
                }



                //if (animal == null)
                //{
                //    Console.WriteLine("Cant casting");
                //}
                //else
                //{
                //    animal.Name = "Test2";
                //    Console.WriteLine(animal.Name);
                //}




                //if(item is Animal t)
                //{
                //    t.Name = "test";
                //    Console.WriteLine(t.Name);
                //}
                //else
                //{
                //    Console.WriteLine("Cant casting");
                //}
            }


        }


    }
}
