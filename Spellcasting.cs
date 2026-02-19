
public static partial class SC
{
    public static void SCast(){

Console.WriteLine("Invoque a primeira palavra."); 
Valores.casting.Add(Console.ReadLine().ToUpper());

Console.WriteLine("Invoque a segunda palavra.");
Valores.casting.Add(Console.ReadLine().ToUpper());

Console.WriteLine("Invoque a terceira palavra.");
Valores.casting.Add(Console.ReadLine().ToUpper());
foreach (var cast in Valores.casting)
{
    Console.WriteLine($"\"{cast}\"");}

}}
