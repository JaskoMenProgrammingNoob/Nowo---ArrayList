using System.Collections;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        int n = 6;
        ArrayList lista = new ArrayList();
        lista.Add(20); lista.Add(-15); lista.Add(67); lista.Add(12); lista.Add(-95); lista.Add(34);
        Console.WriteLine("Lista nieposortowana: ");
        for (int i = 0; i < lista.Count; i++)
        {

            Console.WriteLine($"{lista[i], 8}");


        }
        lista.Sort();
        Console.WriteLine("Lista posortowana: ");
        for (int i = 0; i < lista.Count; i++)
        {

            Console.WriteLine($"{lista[i],8}");

        }
        lista.RemoveAt(1);
        Console.WriteLine("Po usunięcia 2 liczby: ");
        for (int i = 0; i < lista.Count; i++)
        {

            Console.WriteLine($"{lista[i],8}");

        }
        lista.Add(25);
        lista.Sort();
        Console.WriteLine("Po dodaniu liczby i sortowaniu: ");
        for (int i = 0; i < lista.Count; i++)
        {

            Console.WriteLine($"{lista[i],8}");

        }
    }






}