do
{
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
            else if (answer3 == "нет")
            {
                Console.WriteLine("Вы насмотрелись уроков ХАУДИ ХО? да/нет");
                string answer4 = Console.ReadLine().ToLower();
                if (answer4 == "да")
                {
                    Console.WriteLine("Python");
                    break;
                }
                else if (answer4 == "нет")
                {
                    Console.WriteLine("Вам нравиться Windows? да/нет");
                    string answer5 = Console.ReadLine().ToLower();
                    if (answer5 == "да")
                    {
                        Console.WriteLine("C#");
                        break;
                    }
                    else if (answer5 == "нет")
                    {
                        Console.WriteLine("Вы пи**р? да/нет");
                        string answer6 = Console.ReadLine().ToLower();
                        if (answer6 == "да")
                        {
                            Console.WriteLine("Swift");
                            break;
                        }
                        else if (answer6 == "нет")
                        {
                            Console.WriteLine("Perl");
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы ввели несуществующий ответ. Давайте начнем заново.");
                continue;
            }
        }
        else if (answer2 == "нет")
        {
            Console.WriteLine("Вы инженер? да/нет");
            string answer4 = Console.ReadLine().ToLower();
            if (answer4 == "да")
            {
                Console.WriteLine("Вам больше 50? да/нет");
                string answer5 = Console.ReadLine().ToLower();
                if (answer5 == "да")
                {
                    Console.WriteLine("Fortran");
                    break;
                }
                else if (answer5 == "нет")
                {
                    Console.WriteLine("MatLab");
                    break;
                }
            }
            else if (answer4 == "нет")
            {
                Console.WriteLine("У вас Есть ноги? да/нет");
                string answer5 = Console.ReadLine().ToLower();
                if (answer5 == "да")
                {
                    Console.WriteLine("А они вам нужны? да/нет");
                    string answer6 = Console.ReadLine().ToLower();
                    if (answer6 == "да")
                    {
                        Console.WriteLine("Java");
                        break;
                    }
                    else if (answer6 == "нет")
                    {
                        Console.WriteLine("С++");
                        break;
                    }
                }
                else if (answer5 == "нет")
                {
                    Console.WriteLine("С");
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы ввели несуществующий ответ. Давайте начнем заново.");
                continue;
            }
        }
    }
    else if (answer1 == "нет")
    {
        Console.WriteLine("Delphi");
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Вы ввели несуществующий ответ. Давайте начнем заново.");
        continue;
    }
} while (true);
