using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
//para meu eu do futuro e qualquer um que tentar ler esse código depois. As coisas tavam muito grandes e eu reduzi em troca de legibilidade. Ainda dá, com esforço. Desculpa.
//procurar dps uma forma melhor de loopar só a tela de status, deve ter. Se alguém ler isso, aceito sugestões, só sou lerdo.
namespace jogo;class Programa

{


public static class Morte //Sistema de morte
{public static void Morrando()
{if (Valores.Vida < 1) {Console.WriteLine("Você Morreu");Console.ReadKey(); Environment.Exit(0);}}}

public static class Conhecido
    {
        public static List <string> sabedorias = new List<string> {$""};
    }
public static void Main (string [] args)
{string Nome = Valores.Nome; int mudança = Valores.mudança; int Pontos = Valores.pontos;
int Vida = Valores.Vida; bool Testedesorte = Valores.Testedesorte; Random dado = Valores.dado;
int número = Valores.número; string ReceberDano = Valores.ReceberDano; List<string> stats = Valores.stats;
List<int> pontostats = Valores.pontostats; int S = 2; //valores que serão usados
        
        Console.WriteLine("Place holder:Placeholder de Placeholder"); //Título
        
        Console.WriteLine("Aperte qualquer tecla pra continuar"); Console.ReadKey(); Console.WriteLine("\n \"Bem-vindo...\"");
        
        Console.WriteLine("\"Qual seria seu nome?\""); Nome = Console.ReadLine(); //se não tá quebrado n tem pq consertar... não ainda ao menos :P
        //ok quando eu uso o debugger quebra. n sei pq nem como consertar, por via das dúvidas roda sem ele ou direto do prompt

        Console.WriteLine($"Então você é {Nome}..."); Console.WriteLine("\"Um nome estranho... Certamente não daqui...\"");
        Console.WriteLine("Você pouco a pouco se lembra de sua forma...");
        do {TelaStats.Statando();} while (Valores.pontos > 0);

        Console.WriteLine("Sua forma se manifesta lentamente..."); Console.WriteLine($"\"Entendo {Nome}... É assim que você se parece.\"");
        Console.WriteLine("\"Poucos ainda tem esse poder aqui... essa ambição..."); Console.ReadKey();

        Console.WriteLine("\"Como o responsável por sua introdução devo lhe informar como esse mundo funciona");
        Console.WriteLine("\"Tudo aqui é baseado em sorte... Embora há coisas que podem alterar o destino, os Status\"");
        Console.WriteLine($"\"Por exemplo {Nome}, no seu caso seu Status Força é {Valores.pontostats[0]} e seu Mental é {Valores.pontostats[2]}");
        Console.WriteLine($"\"Mas, há tambem coisas fora de nosso controle. Leis imutáveis da natureza... Por exemplo sua Vida que sempre começa em {Vida}\"");
        Console.WriteLine($"\"Gostaria de testar sua sorte?\" (S = sim/N = não)"); /* teste de sorte */ 
        
        do {switch(Console.ReadLine().ToUpper())
        {case "S":Console.WriteLine($"\"seu resultado foi: {número}\"");Console.WriteLine("\"Gostaria de tentar novamente?\"");número = dado.Next(1, 21);break;
        case "N":Console.WriteLine($"\"Muito bem...\"");Testedesorte = false;break;
        default:Console.WriteLine("Inválido(Pf colabora comigo)");break;}} while (Testedesorte);

        Console.WriteLine("\"Está pronto para iniciar?\""); Console.WriteLine("\"Não que você tenha opção...\""); Console.ReadKey();
        
        /* primeira escolha */ do {S = 0;
        Console.WriteLine("\t \nVocê acorda em meio a uma floresta escura. Névoa envolve seu corpo e luz roxa fria passa pelas árvores negras..."); Console.WriteLine("\t O que você faz?(Favor responder com números)");
        Console.WriteLine("\n1 - Respirar fundo e tentar se localizar"); Console.WriteLine("\n2 - Olhar dentre as árvores para tentar se localizar (Mental CD: 14)");
        Console.WriteLine("\n3 - Procurar por comida ao redor (Observação CD:10)"); Console.WriteLine("\n4 - Status");
        
        switch (Console.ReadLine())
        {case "1":
            Console.WriteLine("Você sente o ar gélido entrar seu nariz e pulmões e um sentimento de leveza? Algo muda dentro de você");
            Valores.pontostats[2] = Valores.pontostats[2] - 1;
            Valores.pontostats[3] = Valores.pontostats[3] + 1;
                if (Valores.pontostats[2] <= 0)
                {Console.WriteLine($"{ReceberDano} {Valores.stats[2]}");
                Valores.Vida = Valores.Vida - 1;
                Morte.Morrando();}break;

            case "2":
                RNG.RNGando();
                int CD = Valores.número;
                if (CD + Valores.pontostats[2] >= 14)
                {Console.WriteLine($"{CD}+{Valores.pontostats[2]}: Sucesso");
                Console.WriteLine("Você consegue ver a luz com maior clareza após se concentrar e limpar a mente");
                Console.WriteLine("Você sente algo mudar dentro de você...");
                Valores.pontostats[3] = Valores.pontostats[3] + 1;}
                else if (CD + Valores.pontostats[2] < 14)
                {Console.WriteLine($"{CD}+{Valores.pontostats[2]}: Fracasso...");
                Console.WriteLine("Você não consegue pensar direito...");
                Console.WriteLine("A cada suspiro de névoa você sente uma parte sua ser perdida");
                Valores.pontostats[2] = Valores.pontostats[2] - 1;
                    if (Valores.pontostats[2] <= 0)
                        {Valores.Vida = Valores.Vida - 1;
                        Console.WriteLine($"{ReceberDano} {Valores.stats[2]}");
                        Morte.Morrando();}}break;

            case "3":
            RNG.RNGando();
            CD = Valores.número;
            if (CD + Valores.pontostats[3] >= 10)
                    {Console.WriteLine($"{CD}+{Valores.pontostats[3]}: Sucesso");
                    Console.WriteLine("Você encontra uma massa amorfa de gosma e muco, para seu cérebro esfomeado parece uma janta digna de um REI..."); Console.ReadKey();
                    Console.WriteLine("Você sente algo mudar dentro de você... Um súbito invigoramento..."); Console.ReadKey();
                    Valores.Vida = Valores.Vida + 1;}
            else if (CD + Valores.pontostats[3] < 10)
                    {Console.WriteLine($"{CD}+{Valores.pontostats[3]}: Fracasso...");
                    Console.WriteLine("Você vaga por horas sem encontrar nada para comer... Em seu estupor você decide comer a névoa ao seu redor..."); Console.ReadKey();
                    Console.WriteLine("Ela possui um gosto familiar... Memórias?"); Console.ReadKey();
                    Console.WriteLine("Você sente como se uma parte sua fosse perdida...");Valores.pontostats[2] = Valores.pontostats[2] - 1;
                    if(Valores.pontostats[2] < 1)
                        {Valores.Vida = Valores.Vida-1; Console.WriteLine($"{ReceberDano} {stats[2]}"); Morte.Morrando();} 
                    }break;
            case "4": S = 2; TelaStats.Statando();break;
            default: S = 2; break;} }while(S > 1);

            Console.WriteLine("Enquanto você vaga pela floresta, sua mente vaga junto... Os desenhos no tronco das árvores negras, eles sempre estiveram lá? \nSuas marcações brilhantes em branco reluzem o que aparenta ser uma face..."); Console.ReadKey();
            Console.WriteLine("Ao olhar melhor você vê os rostos começarem a mexer e sussurrar em uma cacofonia dissonante..."); Console.ReadKey();
            Console.WriteLine("\t \n\"Você está perdido jovem?\" / \"Ele precisa de ajuda...\" / \"Sozinho... Tão sozinho...\""); Console.ReadKey();
            Console.WriteLine("Enquanto elas falam um leve fio de névoa entra coberto de impurezas roxas dentro de suas rachaduras e sai com a cor pálida de antes..."); Console.ReadKey();
            Console.WriteLine("\t \n\"Respire fundo... \" / \"Se acalme...\" / \"Nós queremos apenas o melhor...\""); Console.ReadKey();
            Console.WriteLine("Pouco a pouco a floresta se parte levando a dois caminhos... Um a sua frente é iluminado pelo luar... Enquanto o da direita carrega um brilho sedutor..."); Console.ReadKey();
            Console.WriteLine("\t \n\"Siga a direita...\" / \"Confie em nós...\" / \"Bestas são imparciais...\""); Console.ReadKey();
            RNG.RNGando();int CD2 = Valores.número;
            if(CD2 + pontostats[2] >= 16){
            Console.WriteLine("\t \nPouco a pouco você se lembra de um trecho de uma canção antiga... \"Evite, evite, as mentiras de lá. A floresta tentará...~\"");}
            do{S = 0; Console.WriteLine("O que gostaria de fazer?"); //Escolha de caminho (1)
                Console.WriteLine("1 - Seguir o caminho da Lua"); Console.WriteLine("2 - Seguir o caminho do Húbris");
                Console.WriteLine("3 - Respirar fundo"); Console.WriteLine("4 - Status");
            switch(Console.ReadLine()){
                case "1":
                Console.WriteLine("Você escolhe seguir em frente, ignorando o conselho das árvores"); Console.ReadKey(); Console.WriteLine("Pouco a pouco enquanto você segue a roxa luz do luar, a névoa se dissipa..."); Console.ReadKey();
                Console.WriteLine("\t\nLentamente, as árvores se partem para revelar uma cidade de tijolos..."); Console.WriteLine("\t\nA cidade é relativamente movimentada com sombras e silhuetas andando pelas ruas e gesticulando como se conversassem entre si");
                Console.WriteLine("\t\nVocê mal tem tempo de olhar ao seu redor quando uma luz roxa brilhante te cega... No centro da cidade um tipo de castelo ou monumento se ergue de forma orgulhosa. Em seu topo, um altar, segurando uma estrela ofuscante...");
                int S2 = 0;
                do{Console.WriteLine("O que gostaria de fazer?"); S2 = 0; //Escolha de caminho (2)
                Console.WriteLine("1 - Ir em direção ao monumento");
                Console.WriteLine("2 - Tentar interagir com uma das sombras");
                Console.WriteLine("3 - Procurar ajuda");
                Console.WriteLine("4 - Status");

                switch (Console.ReadLine()){
                case "1":
                Console.WriteLine("Você entra no monumento... embora o exterior aparente ser impecável, o interior dele é decrépito, com um cheiro de mofo e poeira pairando no ar");RNG.RNGando(); CD2 = Valores.número; if (CD2+pontostats[3] >= 13)
                {Console.WriteLine("Há muito tempo que algo não encosta aqui, na cidade inteira inclusive..."); Console.ReadKey();} Console.WriteLine("Uma enorme escadaria em espiral se apresenta diante de você. Enquanto você escala ela você percebe o chão começar a vacilar..."); Console.WriteLine("Não há tempo de pensar... escolha rápido"); Console.WriteLine("1 - Pular com toda minha força (Força CD:16) \n2 - Correr com toda minha Velocidade(Velocidade CD: 16) \n3 = Esperar um milagre(Mental CD: 18 Arriscado)");
                 /*Escolha Rápida Monumento*/   switch (Console.ReadLine()){
                    case "1":
                    RNG.RNGando();
                    CD2 = Valores.número;
                    if (CD2+Valores.pontostats[0] >= 16)
                    {Console.WriteLine($"{CD2}+{Valores.pontostats[0]}: Sucesso"); Console.WriteLine("Você pula com toda sua força");}
                    else if (CD2+Valores.pontostats[0] < 16) 
                    {Console.WriteLine($"{CD2}+{Valores.pontostats[0]}: Fracasso...");
                    Console.WriteLine("Você consegue pular até a plataforma mas cai de forma brusca, por sorte você se defende do impacto. Infelizmente, você defende com a cabeça..."); Console.WriteLine("Você se sente gravemente ferido...");
                    Valores.Vida = Valores.Vida - 2;
                    Morte.Morrando();}
                    break;

                    case "2":
                    RNG.RNGando();
                    CD2 = Valores.número;
                    if (CD2+Valores.pontostats[1] >= 16)
                    {Console.WriteLine($"{CD2}+{Valores.pontostats[1]}: Sucesso"); Console.WriteLine("Você corre com toda sua velocidade");}
                    else if (CD2+Valores.pontostats[1] < 16) 
                    {Console.WriteLine($"{CD2}+{Valores.pontostats[1]}: Fracasso...");
                    Console.WriteLine("Você consegue correr até a plataforma mas cai de forma brusca, por sorte você se defende do impacto. Infelizmente, você defende com a cabeça...");
                    Console.WriteLine("Você se sente gravemente ferido...");
                    Valores.Vida = Valores.Vida - 2;
                    Morte.Morrando();}
                    break;

                    case "3":
                    RNG.RNGando();
                    CD2 = Valores.número;
                    if (CD2+Valores.pontostats[2] >= 18)
                    {Console.WriteLine($"{CD2}+{Valores.pontostats[2]}: Sucesso"); Console.WriteLine("Sua vontade sobrepõe o mundo, segurando a escadaria no lugar"); Valores.fé = Valores.fé + 1;}
                    else if (CD2+Valores.pontostats[2] < 18) 
                    {Console.WriteLine($"{CD2}+{Valores.pontostats[2]}: Fracasso...");
                    Console.WriteLine("Você cai de uma altura gigantesca... O que você esperava?");
                    Valores.Vida = 0;
                    Morte.Morrando();}
                    break;
                    
                    default:
                    Console.WriteLine("Você não pensa a tempo e cai"); Valores.Vida = 0; Morte.Morrando();
                    break;} //PAREI AQUI 24/01/2026 
                Console.WriteLine("\t\tApós muito esforço, você chegou a câmara superior. O cheiro de poeira reminescente é substituido por uma mistura de ar noturno gélido e lavanda..."); Console.WriteLine("\t\tUm portão imponente bloqueia seu caminho..."); Console.ReadKey();
                Console.WriteLine("Ao abrir as portas você se depara com as costas de uma jovem de pele pálida. A silhueta ajoelhada dela é envolta em cabelos pretos e longos. Descansando contra a perna dela, uma espada longa e curva.");
                Console.WriteLine("Você está tão perto... O que você faz?");
                int S3 = 0;
                do{S3 = 0;
                Console.WriteLine("1 - Matar ela antes que ela te perceba (Força CD:16. Arriscado)\n2 = Correr até o outro lado da sala (Velocidade CD:17. Arriscado)\n3 - Conversar com ela\n4 - Status"); //parei aqui 24/01/26 11:30.
                switch (Console.ReadLine())
                {case "1":
                RNG.RNGando();
                CD2 = Valores.número;
                if (CD2+Valores.pontostats[0] >= 16)
                {Console.WriteLine("Sucesso..."); Console.WriteLine("Você rapidamente se aproxima por trás, a figura tenta virar a tempo mas é fútil. Com um rápido movimento você quebra o pescoço dela"); Console.ReadKey(); Console.WriteLine("Por que você fez isso?");}
                
                else if (CD2+Valores.pontostats[0] < 16)
                {Console.WriteLine("Morte..."); 
                Console.WriteLine("Você é lento demais. A mulher rapidamente se vira junta com sua espada.\nRapidamente, você deixa de ser... Uma morte completamente piedosa.");Valores.Vida = 0;
                Morte.Morrando();}
                break;
                
                case "2":
                if (CD2+Valores.pontostats[1] >= 17)
                {Console.WriteLine("Sucesso...");
                Console.WriteLine("Você corre rapidamente. Quando a mulher percebe ela tenta gritar:\"Esper-\"mas você ignora. As portas se fecham atrás de você");}

                else if (CD2+Valores.pontostats[1] < 17)
                {Console.WriteLine("Morte...");
                Console.WriteLine("Você é lento demais. A mulher rapidamente se vira junta com sua espada.\nRapidamente, você deixa de ser... Uma morte completamente piedosa.");Valores.Vida = 0;
                Morte.Morrando();}
                break;
                
                case "3":
                Valores.fé = Valores.fé + 1;
                Console.WriteLine("Você puxa a atenção da jovem que se levanta lentamente e segura sua espada");Console.ReadKey();
                Console.WriteLine("\"Parado.\""); Console.WriteLine("O tom frio dela é apenas ampliado pelo ar da sala e brilho de sua lâmina");
                Console.WriteLine("\"Antes de você entrar eu gostaria de perguntar sobre suas intenções\"");Console.ReadKey(); Console.WriteLine("Você se explica para a mulher, que mantém uma expressão solene e imutável em seu rosto pálido..."); Console.ReadKey();
                Console.WriteLine("\"Entendo, você busca audiência e ajuda da Estrela da Compaixão... Pois bem.\"");
                Console.WriteLine("Ela abaixa a espada que brandia e se posiciona ao lado da parede. Abrindo caminho para o próximo portão"); Console.ReadKey();
                if(Valores.fé == 2) {Console.WriteLine("\"Acho que vale a pena lhe informar...\" A mulher interrompe \"Se você almeja mais... Você está pronto...\"");}  break;

                case "4": TelaStats.Statando(); S3=2; break;

                default: S3 = 2; break;}}while (S3 > 1);
                
                Console.WriteLine("Ao atravessar o portão um brilho cegante te atinge."); Console.ReadKey();
                Console.WriteLine("Quando você finalmente consegue abrir os olhos, você vê uma silhueta negra de uma mulher com as pernas cruzadas e braços abertos, tais quais asas.");
                Console.WriteLine("Você está diante da Estrela da Compaixão...");
                Console.WriteLine("1 - Se ajoelhar.");
                switch(Console.ReadLine())
                {case "1":
                Console.WriteLine("Você cai de joelhos, a pressão dentro de sua cabeça é forte demais...");
                break;
                
                default:
                Console.WriteLine("Você cai de joelhos, a pressão dentro de sua cabeça é forte demais...");
                break;}
                Console.WriteLine("\"Você não é daqui. Veio de longe. Viu meu reino decaído. Banido do sol...\""); Console.ReadKey();
                Console.WriteLine("\"Um lugar triste. Vazio. Apenas sombras.\""); Console.ReadKey();
                Console.WriteLine("A corrente de ideias não para de entrar em sua cabeça...");
                Console.WriteLine("\"Você deseja abrigo? Posso lhe dar. Junte se a nós. Dentre as sombras...\""); Console.ReadKey();
                do{S3 = 0;
                Console.WriteLine("O que você deseja?"); Console.WriteLine("1 - Aceite a maior piedade.\n2 - Lutar contra o destino.");
                switch(Console.ReadLine())
                {case "1":
                Console.WriteLine("\"Pois bem...\"");
                Console.WriteLine("Uma luz roxa te envolve..."); Console.ReadKey();
                Console.WriteLine("Você sente sua forma se desfazendo... \"Sem corpo você não pode ser julgado...\"");Console.ReadKey();
                Console.WriteLine("Você sente sua voz se esvaindo... \"Sem voz não há como haver conflito...\"");Console.ReadKey();
                Console.WriteLine("Você sente sua vontade se amenizar... \"Sem ambição não há como tomar dos outros...\"");Console.ReadKey();
                Console.WriteLine("Você sente sua negatividade ser arrancada... \"Sem raiva. Sem guerra. Sem tristeza...\"");Console.ReadKey();
                Console.WriteLine("\"Considere isso a maior compaixão com os fracos...\"");Console.ReadKey();
                Console.WriteLine("Você se une aos seus iguais nas ruas de Umbraly'a... Antes um ser de potencial infinito, reduzido a uma mera sombra...");
                Console.WriteLine("Final A:Paz Absoluta");
                Console.WriteLine("Mas seria esse mesmo um final feliz?");Console.ReadKey();
                Environment.Exit(0);
                break;
                
                case "2":
                if (Valores.fé < 2)
                {Console.WriteLine("É impossível...");
                S3 = 2;}

                else if (Valores.fé >= 2)
                {Console.WriteLine("\"Você deseja lutar contra o destino?\"");Console.ReadKey();
                Console.WriteLine("\"É impossível. A NOSSA natureza é definida no momento em que NÓS nascemos...\"");Console.ReadKey();
                Console.WriteLine("\"A não ser claro, que você queira tomar meu lugar?\"");Console.ReadKey();
                Console.WriteLine("\"Pois bem...\"");Console.ReadKey();
                Console.WriteLine("A figura dentro da luz desaparece em penas negras...");Console.ReadKey();
                Console.WriteLine("A estrela outrora brilhante e púrpura se abre como um abraço ardente...");Console.ReadKey();
                Console.WriteLine("Ao entrar nela, você sente seu corpo inteiro queimar... Uma sonolência toma conta de seu ser e você se agarra à uma fagulha de fé");Console.ReadKey();
                Console.WriteLine("Seus membros são esticados na mesma forma da Deusa. Seus cabelos jorram sangue e se solidificam em fios negros longos. Seus braços criam ossos no formato de asas."); Console.ReadKey();
                Console.WriteLine("As sombras abaixo recuperam suas formas. Elas se sentem em paz e resolvem seus problemas."); Console.ReadKey();
                Console.WriteLine("Aqueles que foram banidos do sol finalmente sentem ele bater na pele."); Console.ReadKey();
                Console.WriteLine("Os conflitos internos das facções desse lugar se encerram e elas se unem em prol do novo mundo."); Console.ReadKey();
                Console.WriteLine("Você criou um paraíso perfeito. Um que você nunca poderá tocar. Um que não lembrará de seu sacrifício");Console.ReadKey();
                Console.WriteLine("Você permanece em agonia até o fim dos tempos, quando as estrelas queimam, o vazio expande e sua consciência fulgaz finalmente descansa");Console.ReadKey();
                Console.WriteLine("Final S:Compaixão Verdadeira");
                Console.WriteLine("Mas seria esse mesmo um final feliz?");Console.ReadKey();
                Console.WriteLine("Uma última ideia ecoa na sua cabeça...");
                Console.WriteLine("Abyssa, esse poder deve ser útil um dia...");
                Environment.Exit(0);}
                break;

                default:
                S3 = 2;
                Console.WriteLine("inválido");
                break;
                }
                
                }while (S3 > 1);

                
                break;

                case "2":
                Console.WriteLine("Você se aproxima da figura sem que ela lhe perceba. Não que seja difícil, todas elas são indeferentes a você, você não é um DELES ainda..."); Console.ReadKey(); Console.WriteLine("Ao tocar ela você sente algo frio e gosmento e derrepente sua consciência se esvai. Você sente como se tivessem devorando seu corpo. Consumindo ele por inteiro"); Console.ReadKey(); Console.WriteLine("A sombra se esvai, agora tendo algum tipo de ambição"); Console.ReadKey(); Console.WriteLine("Você sente partes de si sendo perdidas rapidamente... Sua vida... O quão seguro seria repetir isso?"); Valores.Vida = Valores.Vida - 1; Morte.Morrando();
                Valores.pontostats[2] = Valores.pontostats[2] + 2; S2 = 3; break;

                case "3": //continuar rota das bruxas dps
                Console.WriteLine("Ao olhar ao redor, algo se destaca dentre as muitas silhuetas, sombras e \"desformas\" que caminham nas ruas..."); Console.ReadKey();
                Console.WriteLine("Uma mulher caminha pela rua, sua capa move como o vento contrastando o brilho da estrela com o preto de seu chapéu. Ela porta consigo um grimório com uma marcação de chamas");
                RNG.RNGando();
                CD2 = Valores.número;
                if (CD2+Valores.pontostats[3] >= 15)
                {Console.WriteLine("Você conhece o tipo dela. Bruxa. Sempre com soluções, obrigações e contratos...");}
                Console.WriteLine("Você chama a atenção da mulher em busca de ajuda");Console.ReadKey();
                Console.WriteLine("\"Entendo, você não é daqui... Não há muito que eu possa fazer, mas eu conheço alguém que pode te ajudar a voltar ao seu lar...\""); Console.ReadKey(); Console.WriteLine("Contanto que ela se interesse, claro"); Console.ReadKey();
                Console.WriteLine("Você e a jovem bruxa andam por vários corredores sinuosos, hora subindo, hora descendo e hora desafiando a física mundana, você chega ao seu destino..."); Console.ReadKey();
                RNG.RNGando();
                CD2 = Valores.número;
                do{S2 = 2;
                Console.WriteLine("Uma grande sala de pedra com duas tochas está perante você. A bruxa desaparece antes que você possa ver e livros permeam a sala.");
                Console.WriteLine("\t\tO que você deseja fazer?");
                Console.WriteLine("1 - Olhar os livros da direita\n2 - Olhar os livros da esquerda\n3 - Examinar as tochas\n4 - Status\n5 - Conhecimento");
                switch(Console.ReadLine())
                                {
                                    case "1": //livros direita
                                    Console.WriteLine("Diante de você há três livros espalhados no chão."); Console.WriteLine("1 - Amnr\n2 - Ksyrra\n3 - Leis da Floresta");
                                    switch(Console.ReadLine())
                                        {
                                            case "1": //amnr
                                            Livros.Purificar(); 
                                            if(Valores.amnr < 1)
                                            {Conhecido.sabedorias.Add("Amnr, Purificar");
                                            Valores.amnr = 1;
                                            Console.WriteLine("Novo Conhecimento obtido");}
                                            break;

                                            case "2": //ksyrra
                                            Livros.Inversão();
                                            if(Valores.ksy < 1)
                                            {Conhecido.sabedorias.Add("Ksyrra, Inversão");
                                            Valores.ksy = 1;
                                            Console.WriteLine("Novo Conhecimento obtido");}
                                            break;

                                            case "3": //Floresta
                                            Livros.Floresta();
                                            break;
                                        }break;
                                    case "2": //livros esquerda
                                            {
                                                if (Valores.aqua < 1)
                                                {Valores.aqua = 1;
                                                if (CD2+Valores.pontostats[3] >= 15)
                                                {Console.WriteLine("Você encontra um livro adicional escondido nas sombras."); Console.ReadKey();
                                                Console.WriteLine("Um cheiro húmido e velho sai dele, suas páginas frágeis com uso repetido, e ele aparenta ser muito mais velho do que você"); Console.ReadKey();
                                                Livros.Água();
                                                Conhecido.sabedorias.Add("Haga, Água");}}

                                                Console.WriteLine("Você encontra dois livros no chão num canto escuro"); Console.ReadKey();Console.WriteLine("1 - Ixybil\n2 - Bufur");
                                                switch(Console.ReadLine())
                                                {
                                                    case "1": //Ixybil
                                                    Livros.Compreensão();
                                                    if(Valores.revelação < 1) //com certeza tem como otimizar isso de alguma forma mas se eu ficar nisso eu n acabo isso nunca
                                                    {Conhecido.sabedorias.Add("Ixybil, Compreensão"); Valores.revelação = 1; Console.WriteLine("Novo Conhecimento obtido");}
                                                    break;

                                                    case "2": //Bufur
                                                    Livros.Ampliar();
                                                    if (Valores.ampliado < 1)
                                                    {Conhecido.sabedorias.Add("Bufur, Ampliação"); Valores.ampliado = 1; Console.WriteLine("Novo Conhecimento obtido");}
                                                    break;
                                                }
                                                
                                                break;
                                            }

                                    case "3": //tochas
                                            {
                                                if (Valores.tochas == 0)
                                                {Console.WriteLine("Você se aproxima das duas tochas, elas tem o formato de uma pira, entre elas há um altar com uma inscrição em alto-relevo");
                                                Console.WriteLine("\"Eis aqui o primeiro teste, o cálice é uma oferenda e componente, quando as tochas acenderem você estará mais próximo das cinzas\"");
                                                Console.WriteLine("\"Para usar magia, convoque as 3 palavras chaves corretas e ela será convocada em troca, se usada na hora errada nenhum efeito surgirá\"");
                                                Console.WriteLine("Você percebe que de fato tem um cálice dourado em cima do altar");
                                                if (Valores.cálice == 1)
                                                {Console.WriteLine("O cálice tem um resíduo vermelho dentro dele... Deve ser possível purificá-lo.");}
                                                Console.WriteLine("O que você deseja fazer?"); Console.WriteLine("1 - Dar vitalidade ao cálice\n2 - Convocar Magia\n3 - Retornar");
                                                switch (Console.ReadLine())
                                                {case "1":
                                                if (Valores.cálice == 0)
                                                {Valores.Vida = Valores.Vida - 1;
                                                Morte.Morrando();
                                                Console.WriteLine("Você decide preencher o cálice com vitalidade, você não chega nem perto, no entanto um resíduo vermelho fica no fundo do cálice");
                                                Valores.cálice = 1;}

                                                if (Valores.cálice == 1)
                                                {Console.WriteLine("Já há algo no cálice");}
                                                break;
                                                
                                                case "2":
                                                SC.SCast();
                                                if (Valores.casting.Contains("HAGA") && Valores.casting.Contains("BUFUR") && Valores.casting.Contains("KSSYRA"))
                                                {Console.WriteLine("Sucesso");
                                                Livros.Fogo();} //continuar dps e lembrar de adicionar o aprendizado do fogo!!!!!!!!!!!1!
                                                break;
                                                }
                                                
                                                }
                                                break;
                                            }

                                    case "4": //status
                                            {
                                                TelaStats.Statando();
                                                break;
                                            }

                                    case "5": //Conhecimento
                                            {
                                                Console.WriteLine("\tConhecimentos:");
                                                foreach (var sabedoria in Conhecido.sabedorias)
                                                {
                                                    Console.WriteLine($"{sabedoria}");
                                                }
                                                break;
                                            }
                                }}while(S2 > 1);
                
                break;

                case "4": S2 = 3; TelaStats.Statando(); break;

                default: S2 = 3; break;}}while(S2 > 2);

                break;

                case "2":
                Console.WriteLine("WIP");
                break;

                case "3":
                S = 2;
                Console.WriteLine("Você respira fundo e sente a névoa adentrar seu corpo novamente..."); Console.ReadKey();
                Console.WriteLine("Você sente uma tontura forte e uma revelação"); Console.ReadKey(); Console.WriteLine("Essa névoa está comendo minha mente, não está?"); Console.ReadKey();
                Valores.pontostats[2] = Valores.pontostats[2] - 1;
                Valores.pontostats[3] = Valores.pontostats[3] + 1;
                Console.WriteLine("Coisas mudam dentro de você");
                if (Valores.pontostats[2] < 1)
                {Valores.Vida = Valores.Vida-1;
                Console.WriteLine($"{ReceberDano} {stats[2]}");
                Morte.Morrando();}
                break;

                case "4": S = 2; TelaStats.Statando(); break;

                default: S = 2; break;} }while(S>1);
        
        Console.WriteLine("\t \t \tFIM DE JOGO.");}}
    

