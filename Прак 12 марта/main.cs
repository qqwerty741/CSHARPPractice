using System.Runtime.InteropServices.Marshalling;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal_like_a_cat = new Cat(1);
            Cat cat_like_a_cat = new Cat(2);

            Console.WriteLine();

            animal_like_a_cat.Voice();
            cat_like_a_cat.Voice();
            ((Animal)cat_like_a_cat).Voice();
            
            Console.WriteLine();

            animal_like_a_cat.Print();
            cat_like_a_cat.Print();
            ((Animal)cat_like_a_cat).Print();

            Console.WriteLine();

            animal_like_a_cat.Color();
            cat_like_a_cat.Color();
            ((Animal)cat_like_a_cat).Color();

            Console.WriteLine();

            Console.WriteLine(animal_like_a_cat.Type);
            Console.WriteLine(cat_like_a_cat.Type);
            Console.WriteLine(((Animal)cat_like_a_cat).Type);
        }

        public abstract class Animal
        {
            private int _id;

            public abstract string Type { get; }

            public Animal(int id) => _id = id;

            public abstract void Voice();
            
            public void Color()
            {
                Console.WriteLine("IDK smth about color");
            }

            public virtual void Print()
            {
                Console.WriteLine($"Animal id is:{_id, 3}");
            }
        }

        public class Cat : Animal
        {

            public Cat(int id) : base(id)
            {
                Console.WriteLine("I create new Cat is like cat");
            }

            public override string Type => "Cat";

            public override void Voice()
            {
                Console.WriteLine("Meow");
            }
            public new void Color()
            {
                Console.WriteLine("Color is lice cat's color");
            }
        }
    }
}
