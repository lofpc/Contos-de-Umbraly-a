public partial class Valores //Fonte para pegar e modificar valores.
{public static int pontos = 5; public static int mudança = 0; public static int Vida = 3;
public static string Nome = (""); public static bool Testedesorte = true; public static Random dado = new Random();
public static int número = dado.Next(1, 21); public static string ReceberDano = "Sua vida desceu em 1 devido à falta de";
public static List<string> stats = new List<string> {$"Força","Velocidade","Mental","Observação"}; public static List<int> pontostats = [1, 1, 1, 1]; 
public static int maior = pontostats.Max(); public static int menor = pontostats.Min(); public static int Run = 10; public static int fé = 0;public static int counter = 0; public static int amnr = 0;
public static int ksy = 0; public static int aqua = 0; public static int revelação = 0; public static int ampliado = 0; public static int tochas = 0; public static int cálice = 0;public static List<string> casting = new List<string> {$""}; public static string MudançaBruta;
public static int fogando = 0;}  