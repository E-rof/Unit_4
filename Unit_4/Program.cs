//4.5

    (string Name, string Surname, string Login, double LogLength, bool Pet, double Age, string [] FavColors) User;
for (int k = 0; k < 3; k++)
{
    Console.WriteLine("Введите имя");

    User.Name = Console.ReadLine();

    Console.WriteLine("Введите фамилию");

    User.Surname = Console.ReadLine();

    Console.WriteLine("Введите логин");

    User.Login = Console.ReadLine();

    User.LogLength = User.Login.Length;


    Console.WriteLine("Есть ли у вас животные? Да или Нет");

    string answer = Console.ReadLine();

    if (answer == "Да")
        User.Pet = true;
    else
        User.Pet = false;

    Console.WriteLine("Введите возраст пользователя");
    User.Age = double.Parse(Console.ReadLine());

    User.FavColors = new string[3];

    Console.WriteLine("Введите три любимых цвета пользователя");

    for (int i = 0; i < 3; i++)
    {
        User.FavColors[i] = Console.ReadLine();

    }
}
