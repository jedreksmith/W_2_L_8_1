namespace Ex_w_2_l_8_1;


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program sprawdza ile jest liczb pierwszych od 0 do 100");

        int suma = 0, ile = 0;

        int k = 0;

        for (int i = 1; i < 100; i++)
        {
            for (int j = 1; j < 100; j++)
            {
                if (i % j == 0 )
                    suma += 1;     
            }
            
            Console.WriteLine("Liczba " + i + "  ma " + suma + " dzielników");

            if (suma == 2)
            {
                k++;
            Console.WriteLine(k + " Liczba " + i + "  jest pierwsza "); }

            suma = 0;
        }
        Console.WriteLine("Są " + k + "  liczby pierwsze ");
    }
}

     

