using System;

namespace ConsoleApp1
{
    class Program
    {
        static Func<int, int, int, int> add = (a, b, c) => a + b + c;

        int a = add(1, 2, 3);
        int b1 = add(1, 2, 3);

        static int b = 1;
        static int c = 2;

        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Dog d1 = new Dog();

            a1 = d1;
            d1 = (Dog) a1;

            Genre g = new Genre();
            int x = 1;
            int y = 2;

            Program.b = Program.c;
            x = y;

            int num;
            changeNum(out num);

            Console.WriteLine(num);
            Console.ReadLine();
        }

        public static void changeNum(out int x)
        {
            x = 23;
        }

    }

    public class Animal
    {
        private string name;
        private string color;
    }

    public class Dog : Animal
    {
        private string name;
        private string breed;
    }

    public class Genre
    {
        private string name; // This is the backing field
        public string Name   // This is your property
        {
            get => name;
            set => name = value;
        }
    }
}
