namespace AttributDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit();
            Console.WriteLine(fruit.type);
            Console.WriteLine(fruit.weight);
            
            Fruit fruit2 = new Fruit();
            fruit2.type = "Orange";
            fruit2.weight = 0.13;

            Console.WriteLine(fruit2.type);
            Console.WriteLine(fruit2.weight);

            Cat cat = new Cat();
            Console.WriteLine("Det var en gång en katt som var " + cat.color);
            cat.legs = 4;

            Console.WriteLine("Katten har nu " + cat.legs + "ben.");

            Console.WriteLine("Katten möter räven, och äter upp ett ben.");
            cat.legs = cat.legs - 1;
            Console.WriteLine("Katten har nu " + cat.legs + " ben.");

            Console.WriteLine("Katten blir hungrig");
            cat.hungry = true;

            if(cat.hungry)
            {
                Console.WriteLine("Katten fåt mat");
                cat.hungry = false;
            }

            if(cat.hungry == false)
            {
                Console.WriteLine("katten är mätt, men har bara " + cat.legs + " ben.");
            }
        }
    }
}
