// See https://aka.ms/new-console-template for more information
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("Hello, World!");

Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Enter your name:"); //Вывод

/*
string userName;
userName = Console.ReadLine();
*/

string userName = Console.ReadLine(); //Ввод

//Console.WriteLine("Hello" + ", " + userName + "!");
Console.WriteLine($"Hello, {userName}!");
