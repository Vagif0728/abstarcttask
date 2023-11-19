namespace Task_Abstract_cals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Basket = new Fruit[]
       {
            new Apple { Price = 10d, Sort = "Yawil", VitaminA = 100, VitaminB = 50 },
            new Pineapple { Price = 40d, Sort = "Morris", VitaminE = 80, VitaminD = 30 },
            new Orange { Price = 15d, Sort = "Jaffa", VitaminC = 200 }
       };

            foreach (var fruit in Basket)
            {
                Type fruitType = fruit.GetType();
                Console.Write($"{fruitType.Name} tipinde obyektde {nameof(fruit.Price)}, {nameof(fruit.Sort)}");

                if (fruitType == typeof(Apple))
                {
                    Console.Write($", {nameof(Apple.VitaminA)}, {nameof(Apple.VitaminB)}");
                }
                else if (fruitType == typeof(Pineapple))
                {
                    Console.Write($", {nameof(Pineapple.VitaminE)}, {nameof(Pineapple.VitaminD)}");
                }
                else if (fruitType == typeof(Orange))
                {
                    Console.Write($", {nameof(Orange.VitaminC)}");
                }

                Console.WriteLine(" deyerleri:");

                foreach (var property in fruitType.GetProperties())
                {
                    Console.WriteLine($"{property.Name}: {property.GetValue(fruit)}");
                }

                Console.WriteLine();
            }
        }
    }
    
}