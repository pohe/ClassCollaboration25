// See https://aka.ms/new-console-template for more information
using ClassCollaboration25;
using System.Net.Http.Headers;


Console.WriteLine("Hello, World!");



Wheel w1 = null;
w1 = new Wheel(100, 2025, "Winther");
w1 = new Wheel(200, 2024, "Summer");
Car c = new Car("Volvo", w1);
c.Start();
Wheel w2 = new Wheel(300, 2023, "Winther");
c.ChangeWheels(w2);
Console.WriteLine(c.CalCo2Emission());


Console.WriteLine(c.ToString());
//Console.WriteLine(w1);

//Engine e1 = new Engine(200, "Gasoline");

//Console.WriteLine(e1);


//NavigationSystem navi = new NavigationSystem("Google navigation", "Atai", "GPR", 100);