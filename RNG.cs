public static partial class RNG //Sistema de RNG 
{public static void RNGando() 
{Valores.dado = new Random(); Valores.número = Valores.dado.Next(1, 21); //counter serve como sistema de pity
if (Valores.número < 10) {Valores.counter = Valores.counter + 1;;}


if (Valores.counter == 2) {Valores.número = Valores.dado.Next (10, 21); ;};}}

public static partial class D20s
{
    public static void dadofor()
    {
        RNG.RNGando();
        if (Valores.número + Valores.pontostats[0] >= Valores.CDteste)
        {
            Console.WriteLine($"{Valores.número + Valores.pontostats[0]}");
            Console.WriteLine("Sucesso");
        }
        else if (Valores.número + Valores.pontostats[0] < Valores.CDteste)
        {
            Console.WriteLine($"{Valores.número + Valores.pontostats[0]}");
            Console.WriteLine("Fracasso...");
        }
    }

    public static void dadovel()
    {
        RNG.RNGando();
        if (Valores.número + Valores.pontostats[1] >= Valores.CDteste)
        {
            Console.WriteLine($"{Valores.número + Valores.pontostats[1]}");
            Console.WriteLine("Sucesso");
        }
        else if (Valores.número + Valores.pontostats[1] < Valores.CDteste)
        {
            Console.WriteLine($"{Valores.número + Valores.pontostats[1]}");
            Console.WriteLine("Fracasso...");
        }
    }

    public static void dadomen()
    {
        RNG.RNGando();
        if (Valores.número + Valores.pontostats[2] >= Valores.CDteste)
        {
            Console.WriteLine($"{Valores.número + Valores.pontostats[2]}");
            Console.WriteLine("Sucesso");
        }
        else if (Valores.número + Valores.pontostats[2] < Valores.CDteste)
        {
            Console.WriteLine($"{Valores.número + Valores.pontostats[2]}");
            Console.WriteLine("Fracasso...");
        }
    }

    public static void dadoobs()
    {
        RNG.RNGando();
        if (Valores.número + Valores.pontostats[3] >= Valores.CDteste)
        {
            Console.WriteLine($"{Valores.número + Valores.pontostats[3]}");
            Console.WriteLine("Sucesso");
        }
        
        else if (Valores.número + Valores.pontostats[3] < Valores.CDteste)
        {
            Console.WriteLine($"{Valores.número + Valores.pontostats[3]}");
            Console.WriteLine("Fracasso...");
        }
    }
}