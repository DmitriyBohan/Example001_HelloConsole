﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "аня") 
{
    Console.WriteLine("Ура,это же Аня!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
