Console.WriteLine("-------Выбор языка программирования----------");
Console.WriteLine("Хотите много зарабатывать? да/нет");
string answer1 = Console.ReadLine().ToLower();
if (answer1 == "да")
{
    Console.WriteLine("Вы тупой? да/нет");
    string answer2 = Console.ReadLine().ToLower();
    if (answer2 == "да")
    {
        Console.WriteLine("Очень? да/нет");
        string answer3 = Console.ReadLine().ToLower();
        if (answer3 == "да")
        {
            Console.WriteLine("У вас есть друзья? да/нет");
            string answer4 = Console.ReadLine().ToLower();
            if (answer4 == "да")
            {
                Console.WriteLine("Они тоже тупые? да/нет");
                string answer5 = Console.ReadLine().ToLower();
                if (answer5 == "да")
                {
                    Console.WriteLine("JavaScript");
                    break;
                }
                else if (answer5 == "нет")
                {
                    Console.WriteLine("Ruby");
                    break;
                }
            }
            else if (answer4 == "нет")
            {
                Console.WriteLine("PHP");
                break;
            }
        }
