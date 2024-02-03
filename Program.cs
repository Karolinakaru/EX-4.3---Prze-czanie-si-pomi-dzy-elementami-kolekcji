internal class Program
{
    static void Main(string[] args)
    {
        // tablica jednowymiarowa z cyframi od 1 do 100
        //sumuje parzyste i nieparzyste- pętla foreach
        int[] table = new int[100];
        int sumEven = 0;
        int sumOdd = 0;
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = i + 1;// wyświetlanie tablicy 1-100
            //Console.WriteLine(table[i]);
        }
        foreach (int number in table)
        {
            if (number % 2 == 0)
            {
                sumEven += number;

            }
            else
            {
                sumOdd += number;
            }
        }
        Console.WriteLine($"Sum of even numbers is: {sumEven}, sum od odd numbers is: {sumOdd}");
        Console.ReadLine();
    }
}