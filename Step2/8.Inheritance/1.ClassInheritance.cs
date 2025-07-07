
using System;

namespace Family
{
    class Father
    {
        public string Name { get; set; }

        //public Father(string name)
        //{
        //    Name = name;
        //    Console.WriteLine($"name paramter is is {name}");
        //}
        public Father()
        {
            Name = "Alice";
            Console.WriteLine($"name paramter is is {Name}");
        }

        public Father(string name)
        {
            Console.WriteLine($"Hello my kid name is {name}");
        }



        public void ShowMessage()
        {
            Console.WriteLine($"Hello, I am {Name}, the Father.");
        }
    }

    class Mother
    {
        ///
    }

    class Child : Father
    {
        public Child()
        {
            Console.WriteLine($"From Child Class and myfather name is {Name}");
        }

        public Child(string kidName) : base(kidName)
        {
            {
                Console.WriteLine($"After my father decided now my name is {kidName}");
            }
        }

        public string[] myClassFreinds()
        {
            return new string[] { "Ram", "Raki" };
        }
    }

    class Program
    {
        static void Main()
        {
            //Child child = new Child();
            Child child = new Child("Jurnior Alice");
            child.myClassFreinds(); //ownmembers
            child.ShowMessage();   //parent


            Father father = new Father();
            //father.myclass

        }
    }


}