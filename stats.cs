public static partial class TelaStats{ //Sistema de Stats
public static void Statando(){int Vida = Valores.Vida; int Pontos = Valores.pontos;
List<int> pontostats = Valores.pontostats; List<string> stats = Valores.stats; int mudança = Valores.mudança; string MB = Valores.MudançaBruta;
        /* tela de stats */
        Console.WriteLine("\n Status: \n"); foreach (var stat in stats) {Console.WriteLine (stat);} //nome de cada status
        Console.WriteLine("\n Pontuações: \n"); foreach (var pontostat in pontostats) {Console.WriteLine (pontostat);} //valor de cada status
        Console.WriteLine ($"\n Sua vida atual é:{Vida} (Imutável, Inevitável.)"); //valor de vida (não pode ser aumentado pela tela)
        Console.Write("\n Pontos restantes: "); Console.Write($"{Pontos}"); //valor de pontos de aprimoramento
        Console.WriteLine("(Para acresentar seus status digite (nome do stat) ou Encerrar) (APENAS UM NÚMERO INTEIRO)"); //EU CONSERTEI O BUG DA LEPTOSPIROSE
switch(Console.ReadLine().ToUpper()){case $"FORÇA":
                Console.WriteLine("O quanto você deseja aumentar o stat de Força?");
                MB = Console.ReadLine();
                int.TryParse(MB, out mudança);
                    {if (mudança > Pontos) {Console.WriteLine("inválido");}
                    else if (mudança < 0) {Console.WriteLine("inválido");}
                    else if (Pontos >= mudança) {Valores.pontostats[0] = Valores.pontostats[0] + mudança; Valores.pontos = Valores.pontos - mudança;}} break;

                        case $"VELOCIDADE":
                Console.WriteLine("O quanto você deseja aumentar o stat de Velocidade?");
                MB = Console.ReadLine();
                int.TryParse(MB, out mudança);
                    {if (mudança > Pontos) {Console.WriteLine("inválido");} 
                    else if (mudança < 0) {Console.WriteLine("inválido");}
                    else if (Pontos >= mudança){Valores.pontostats[1] = Valores.pontostats[1] + mudança; Valores.pontos = Valores.pontos - mudança;}} break;

                case $"MENTAL":
                Console.WriteLine("O quanto você deseja aumentar o stat de Mental?");
                MB = Console.ReadLine();
                int.TryParse(MB, out mudança);
                    {if (mudança > Pontos) {Console.WriteLine("inválido");}
                    else if (mudança < 0) {Console.WriteLine("inválido");}
                    else if (Pontos >= mudança) {Valores.pontostats[2] = Valores.pontostats[2] + mudança; Valores.pontos = Valores.pontos - mudança;}}break;

                case $"OBSERVAÇÃO":
                Console.WriteLine("O quanto você deseja aumentar o stat de Observação?");
                MB = Console.ReadLine();
                int.TryParse(MB, out mudança);
                    {if (mudança > Pontos) {Console.WriteLine("inválido");}
                    else if (mudança < 0) {Console.WriteLine("inválido");}
                    else if (Pontos >= mudança) {Valores.pontostats[3] = Valores.pontostats[3] + mudança; Valores.pontos = Valores.pontos - mudança;}}break;

                default:Console.WriteLine("Inválido(Você quer uma conquista por testar meu código???)"); break;

                case $"Encerrar":
                Console.WriteLine("Isto irá encerrar a distribuição de status atual e você perderá seus pontos restantes (recomendado apenas para testes), está certo disso?(S = Sim/ N = Não)");
                switch(Console.ReadLine().ToUpper()) {case "S": Valores.pontos = 0; break; case "N": break;} break;}}}