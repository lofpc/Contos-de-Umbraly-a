using System.Security.Cryptography.X509Certificates;
using jogo;

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
            Console.WriteLine($"Seu resultado foi: {Valores.número} + {Valores.pontostats[0]}");
            Console.WriteLine("Sucesso");
            Valores.sucesso = true;
        }
        else if (Valores.número + Valores.pontostats[0] < Valores.CDteste)
        {
            Console.WriteLine($"Seu resultado foi: {Valores.número} + {Valores.pontostats[0]}");
            Console.WriteLine("Fracasso...");
            Valores.sucesso = false;
        }
    }

    public static void dadovel()
    {
        RNG.RNGando();
        if (Valores.número + Valores.pontostats[1] >= Valores.CDteste)
        {
            Console.WriteLine($"Seu resultado foi: {Valores.número} + {Valores.pontostats[1]}");
            Console.WriteLine("Sucesso");
            Valores.sucesso = true;
        }
        else if (Valores.número + Valores.pontostats[1] < Valores.CDteste)
        {
            Console.WriteLine($"Seu resultado foi: {Valores.número} + {Valores.pontostats[1]}");
            Console.WriteLine("Fracasso...");
            Valores.sucesso = false;
        }
    }

    public static void dadomen()
    {
        RNG.RNGando();
        if (Valores.número + Valores.pontostats[2] >= Valores.CDteste)
        {
            Console.WriteLine($"Seu resultado foi: {Valores.número} + {Valores.pontostats[2]}");
            Console.WriteLine("Sucesso");
            Valores.sucesso = true;
        }
        else if (Valores.número + Valores.pontostats[2] < Valores.CDteste)
        {
            Console.WriteLine($"Seu resultado foi: {Valores.número} + {Valores.pontostats[2]}");
            Console.WriteLine("Fracasso...");
            Valores.sucesso = false;
        }
    }

    public static void dadoobs()
    {
        RNG.RNGando();
        if (Valores.número + Valores.pontostats[3] >= Valores.CDteste)
        {
            Console.WriteLine($"Seu resultado foi: {Valores.número} + {Valores.pontostats[3]}");
            Console.WriteLine("Sucesso");
            Valores.sucesso = true;
        }
        
        else if (Valores.número + Valores.pontostats[3] < Valores.CDteste)
        {
            Console.WriteLine($"Seu resultado foi: {Valores.número} + {Valores.pontostats[3]}");
            Console.WriteLine("Fracasso...");
            Valores.sucesso = false;
        }
    }

    public static void dadopassagens()
    {
        Valores.númeropassagem = Valores.dadopass.Next(1, 6);
        switch(Valores.númeropassagem)
        {
            case 1:
            switch (Valores.passagensvalor)
                {
                    case 1:
                    Olhotexto.Floresta();
                    break;

                    case 2:
                    Olhotexto.Queda();
                    break;
                }
            break;

            case 2:
            switch (Valores.passagensvalor)
                {
                    case 1:
                    Olhotexto.enterro();
                    break;

                    case 2:
                    Olhotexto.Forja();
                    break;
                }
            break;

            case 3:
            switch (Valores.passagensvalor)
                {
                    case 1:
                    Olhotexto.casa();
                    break;

                    case 2:
                    Olhotexto.Luar();
                    break;
                }
            break;

            case 4:
            switch (Valores.passagensvalor)
                {
                    case 1:
                    Olhotexto.Sombras();
                    break;

                    case 2:
                    Olhotexto.Mausoléu();
                    break;
                }
            break;

            case 5:
            switch (Valores.passagensvalor)
                {
                    case 1:
                    Olhotexto.vidente();    
                    break;

                    case 2:
                    Olhotexto.LUGAR();
                    break;
                }
            break;
        }
    }
}