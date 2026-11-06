string[] songs = new string[100];
int kolichestvo = 0;
int choice = -1;

while (choice != 0)
{
    Console.WriteLine("МОЯ МУЗЫКА");
    Console.WriteLine("1. Добавить песню");
    Console.WriteLine("2. Посмотреть все песни");
    Console.WriteLine("3. Количество песен");
    Console.WriteLine("4. Найти песню");
    Console.WriteLine("5. Очистить список");
    Console.WriteLine("6. Последняя песня");
    Console.WriteLine("0. Выход");

    Console.Write("Выберите действие: ");
    choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        AddSong();
    }
    else if (choice == 2)
    {
        ShowSongs();
    }
    else if (choice == 3)
    {
        Console.WriteLine($"Количество песен: {kolichestvo}");
    }
    else if (choice == 4)
    {
        FindSong();
    }
    else if (choice == 5)
    {
        kolichestvo = 0;
        Console.WriteLine("Список очищен!");
    }
    else if (choice == 6)
    {
        if (kolichestvo > 0)
        {
            Console.WriteLine(songs[kolichestvo - 1]);
        }
        else
        {
            Console.WriteLine("Список пуст.");
        }
    }
}


void AddSong()
{
    Console.Write("Введите название песни: ");
    songs[kolichestvo] = Console.ReadLine();
    kolichestvo++;

    Console.WriteLine("Песня добавлена!");
}


void ShowSongs()
{
    if (kolichestvo == 0)
    {
        Console.WriteLine("Список пуст.");
    }

    for (int i = 0; i < kolichestvo; i++)
    {
        Console.WriteLine(songs[i]);
    }
}


void FindSong()
{
    Console.Write("Введите название песни: ");
    string name = Console.ReadLine();
    for (int i = 0; i < kolichestvo; i++)
    {
        if (songs[i] == name)
        {
            Console.WriteLine($"Песня {name} найдена в плейлисте!");
        }
        else
        {
            Console.WriteLine("Песня не найдена.");
        }
    }
}