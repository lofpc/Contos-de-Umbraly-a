using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

namespace dano;

public static partial class Definhamento
{
    public static string ReceberDano = Valores.ReceberDano;
    public static void DefFor()
    {
        if (Valores.pontostats [0] <= 0)
        {
            Console.WriteLine($"{ReceberDano} {Valores.stats[0]}"); Console.ReadKey();
            Valores.Vida = Valores.Vida - 1;
            jogo.Programa.Morte.Morrando();
        }
    }
    
    public static void DefVel()
    {
        if (Valores.pontostats [1] <= 0)
        {
            Console.WriteLine($"{ReceberDano} {Valores.stats[1]}"); Console.ReadKey();
            Valores.Vida = Valores.Vida - 1;
            jogo.Programa.Morte.Morrando();
        }
    }

    public static void DefMen()
    {
        if (Valores.pontostats [2] <= 0)
        {
            Console.WriteLine($"{ReceberDano} {Valores.stats[2]}"); Console.ReadKey();
            Valores.Vida = Valores.Vida - 1;
            jogo.Programa.Morte.Morrando();
        }
    }

    public static void DefObs()
    {
        if (Valores.pontostats [3] <= 0)
        {
            Console.WriteLine($"{ReceberDano} {Valores.stats[3]}"); Console.ReadKey();
            Valores.Vida = Valores.Vida - 1;
            jogo.Programa.Morte.Morrando();
        }
    }
}