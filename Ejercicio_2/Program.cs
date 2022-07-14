


Console.WriteLine("\n------------Lenguajes de Programación------------------");
Console.WriteLine("\n---Qual es tu lenguaje de programación favorito: ------");
Console.WriteLine("-------------------------1-Javascript--------------------");
Console.WriteLine("-------------------------2-C# .NET-----------------------");
Console.WriteLine("-------------------------3-Python------------------------");
Console.WriteLine("-------------------------4-Java--------------------------");
Console.WriteLine("-------------------------5-TypeScript--------------------");
Console.WriteLine("-------------------------6-Pascal------------------------");
Console.WriteLine("-------------------------7-Kotlin------------------------");
Console.WriteLine("-------------------------8-Otra--------------------------");

int escojer = Convert.ToInt32(Console.ReadLine());


switch (escojer)
{
    case 1:

        Console.WriteLine("Tú eligiste: Javascript");
        break;
    case 2:
        Console.WriteLine("Tú elegiste: C# .NET");
        break;
    case 3:
        Console.WriteLine("Tú elegiste: Python");
        break;
    case 4:
        Console.WriteLine("Tú elegiste: Java");
        break;
    case 5:
        Console.WriteLine("Tú elegiste: TypeScript");
        break;
    case 6:
        Console.WriteLine("Tú elegiste: Pascal");
        break;
    case 7:
        Console.WriteLine("Tú elegiste Kotlin");
        break;
    case 8:
        Console.WriteLine("Tú elegiste una lenguaje que no se encuentra en nuestra lista");
        break;


}



