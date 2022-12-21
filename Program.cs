using System;
using System.Text.RegularExpressions;
public class Torres
{
    public static void Hanoi(int ntorre, int inicio, int final, int auxiliar, int[] torre1, int[] torre2, int[] torre3, int con)
    {
        if (ntorre > 0)
        {
            Hanoi(ntorre - 1, inicio, auxiliar, final, torre1, torre2, torre3, con);
            Mover(ntorre, inicio, final, torre1, torre2, torre3, con);
            Hanoi(ntorre - 1, auxiliar, final, inicio, torre1, torre2, torre3, con);
        }
    }
    public static void Mover(int ntorre, int inicio, int final, int[] torre1, int[] torre2, int[] torre3, int con)
    {
        int reserva;
        if (inicio == 1)
        {
            reserva = torre1[ntorre];
            torre1[ntorre] = 0;
            if (final == 2) { torre2[ntorre] = reserva; }
            if (final == 3) { torre3[ntorre] = reserva; }
        } if (inicio == 2)
        {
            reserva = torre2[ntorre];
            torre2[ntorre] = 0;
            if (final == 1) { torre1[ntorre] = reserva; }
            if (final == 3) { torre3[ntorre] = reserva; }
        } if (inicio == 3)
        {
            reserva = torre3[ntorre];
            torre3[ntorre] = 0;
            if (final == 1) { torre1[ntorre] = reserva; }
            if (final == 2) { torre2[ntorre] = reserva; }
        } Escribir(con, torre1, torre2, torre3);
    }
    public static void Escribir(int con, int[] torre1, int[] torre2, int[] torre3)
    {
        Console.Write("A: ");
        for (int i = 1; i <= con; i++)
        {
            Console.Write("{0} ", torre1[i]);
        } Console.Write("- B: ");
        for (int o = 1; o <= con; o++)
        {
            Console.Write("{0} ", torre2[o]);
        } Console.Write("- C: ");
        for (int u = 1; u <= con; u++)
        {
            Console.Write("{0} ", torre3[u]);
        } Console.WriteLine("\n");
    }
    public static void Main()
    {
        bool error = true; int ntorre = 0, objetivo = 0;
        while (error == true)
        {
            try
            {
                Console.Write("¿Cuantos discos quiere que tenga la torre (2-9)? ");
                ntorre = Convert.ToInt32(Console.ReadLine());
                error = false;
            } catch (FormatException)
            {
                Console.WriteLine("Formato inválido\n");
                error = true;
            } if ((ntorre < 2) || (ntorre > 9))
            {
                Console.WriteLine("Valor inválido\n");
                error = true;
            }
        } error = true;
        while (error == true)
        {
            try
            {
                Console.Write("\n¿Cual es la torre objetivo (2-3)? ");
                objetivo = Convert.ToInt32(Console.ReadLine());
                error = false;
            } catch (FormatException)
            {
                Console.WriteLine("\nFormato inválido");
                error = true;
            } if ((objetivo < 2) || (objetivo > 3))
            {
                Console.WriteLine("\nValor inválido");
                error = true;
            }
        } Console.WriteLine();
        int con = ntorre;
        int[] torre1 = new int[ntorre + 1];
        int[] torre2 = new int[ntorre + 1];
        int[] torre3 = new int[ntorre + 1];
        for (int n = 1; n <= ntorre; n++)
        {
            torre1[n] = n;
            torre2[n] = 0;
            torre3[n] = 0;
        }
        Escribir(con, torre1, torre2, torre3);
        if (objetivo == 2)
        {
            Hanoi(ntorre, 1, 2, 3, torre1, torre2, torre3, con);
        } if (objetivo == 3)
        {
            Hanoi(ntorre, 1, 3, 2, torre1, torre2, torre3, con);
        }
    }
}