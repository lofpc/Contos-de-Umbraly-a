public static partial class RNG //Sistema de RNG 
{public static void RNGando() 
{Valores.dado = new Random(); Valores.número = Valores.dado.Next(1, 21); //counter serve como sistema de pity
if (Valores.número < 10) {Valores.counter = Valores.counter + 1;}

if (Valores.counter == 2) {Valores.número = Valores.dado.Next (10, 21);} Console.WriteLine($"Seu resultado é: {Valores.número}");}}