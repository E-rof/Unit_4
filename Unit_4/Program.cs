//4.4.5
(string Name, string Type, double Age, int NameCount) Pet;
Pet.NameCount = 0;
Console.WriteLine("Enter Name");
Pet.Name = Console.ReadLine();
Console.WriteLine("Enter Type");
Pet.Type = Console.ReadLine();
Console.WriteLine("Enter Age");
Pet.Age = Convert.ToDouble(Console.ReadLine());
Pet.NameCount ++;
Console.WriteLine("NameCount: " + Pet.NameCount);
Console.WriteLine("Name: " + Pet.Name);
Console.WriteLine("Type: " + Pet.Type);
Console.WriteLine("Age: " + Pet.Age);
Console.ReadKey();