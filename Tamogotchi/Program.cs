class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите имя вашего Тамагочи:");
        string name = Console.ReadLine();
        Tamagotchi tamagotchi = new Tamagotchi(name);

        while (tamagotchi.IsAlive())
        {
            tamagotchi.Hunger++;
            tamagotchi.Tiredness++;
            tamagotchi.Happiness--;

            if (tamagotchi.Hunger >= 10 || tamagotchi.Tiredness >= 10)
            {
                tamagotchi.Health--;
            }

            tamagotchi.CheckStatus();

            if (!tamagotchi.IsAlive())
            {
                Console.WriteLine($"{tamagotchi.Name} умер. Игра окончена.");
                break;
            }

            Console.WriteLine("Что вы хотите сделать? (кормить, играть, спать, лечить, проверить статус)");
            string action = Console.ReadLine().ToLower();

            switch (action)
            {
                case "кормить":
                    tamagotchi.Feed();
                    break;
                case "играть":
                    tamagotchi.Play();
                    break;
                case "спать":
                    tamagotchi.Sleep();
                    break;
                case "лечить":
                    tamagotchi.Heal();
                    break;
                case "проверить статус":
                    tamagotchi.CheckStatus();
                    break;
                default:
                    Console.WriteLine("Неверное действие. Попробуйте еще раз.");
                    break;
            }
        }
    }
}