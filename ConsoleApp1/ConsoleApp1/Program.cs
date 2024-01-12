using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        List<Iroda> lista = new();
        List<int> lista2Even = new();
        List<int> lista2Odd = new();

        using (var sr = new StreamReader(@"..\..\..\src\irodahaz.txt"))
        {
            var numbers = sr.ReadLine().Split(" ").Skip(2).Select(int.Parse).ToList();
            lista2Even = numbers.Where(n => n % 2 == 0).ToList();
            lista2Odd = numbers.Where(n => n % 2 != 0).ToList();

            sr.ReadLine(); // Skip a line
            while (!sr.EndOfStream)
            {
                lista.Add(new Iroda(sr.ReadLine()));
                sr.ReadLine(); // Skip a line
            }
        }

        

        Console.WriteLine("\n\nIroda objects in lista with associated numbers:");
        foreach (Iroda da in lista)
        {
            Console.Write($"{da.kód}, {da.kezdet}: ");
            foreach (var number in da.irodak)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine(); // Move to the next line for the next Iroda object
        }
    }
}
