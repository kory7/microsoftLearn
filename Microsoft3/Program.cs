// See https://aka.ms/new-console-template for more information
using Microsoft3;

Console.WriteLine("Hello, World!");

string letterA = " A";
string lettera = "a ";

string starbucksOrder = "Caramel macchiato and cold brew";
float ticket = 1000.10F;

Console.WriteLine(letterA.ToLower().Trim() == lettera.ToLower().Trim());
Console.WriteLine("Does the order contains cold brew? "+starbucksOrder.Contains("cold brew"));

Console.WriteLine($"The total is: ${ticket} with discount of: {(ticket > 1000 ? "$100" : "$50")}");


Random coin = new Random();

//coin.Next(100);

Console.WriteLine($"{ (coin.Next(100)>=50?"heads":"tails")}");

BusinessRule NewManager = new BusinessRule();

NewManager.Level = 60;
NewManager.Permission = "Admin";

NewManager.PermissionMessage();