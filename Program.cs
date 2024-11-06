// See https://aka.ms/new-console-template for more information
using ConsoleAppThread;
Console.WriteLine("Hello world");
Thread thread = new Thread(new ThreadStart(OurClass.Display));
Console.WriteLine("Thread Details");
Console.WriteLine("Background : \t"+thread.IsBackground);
Console.WriteLine("Name:\t"+thread.Name);
Console.WriteLine("State:\t"+thread.ThreadState);
Console.WriteLine("Is Alive? \t"+ thread.IsAlive);
thread.Start();
