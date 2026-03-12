using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.Json;
using System.Xml;
using jogo;
using Microsoft.Win32.SafeHandles;

public static partial class Olhotexto
{
    public static void Checkolhofalse()
    {
        Console.WriteLine("Muitas passagens permeam as paredes..."); Console.ReadKey();
        Console.WriteLine("Talvez você deva voltar quando conseguir algo..."); Console.ReadKey(); Console.Clear();
    }

    public static void Checkolhotrue()
    {
        Console.WriteLine("\"Seu olho esquerdo recém implantado queima, como se estivesse sangrando chamas...\"");
        Console.WriteLine("\"Algumas passagens possuem um brilho azul leve e você sente uma sombra terrível sobra outras\""); Console.ReadKey();
        Console.WriteLine("Eu prefiro ir pelas brilhantes");
    }

    public static void Floresta()
    {   Console.Clear();
        Console.WriteLine("\"Você se encontra no meio da floresta. Isso lhe traz certa familiaridade\"");Console.ReadKey();
        if (Valores.javali == 1)
        {Valores.javali = 0; Valores.listapassagens.Add("FLORESTA");
        Console.WriteLine("\"De repente, um javali negro avança em sua direção. O que você faz?\"");
        Console.WriteLine("1 - Atacá-lo (CD: 17)"); Console.WriteLine("2 - Esquivar (CD: 16)"); Console.WriteLine("3 - Invocar magia simples");
        switch(Console.ReadLine())
            {
                case "1":
                Console.Clear();
                Valores.CDteste = 17;
                D20s.dadofor();
                switch(Valores.sucesso)
                    {
                        case false:
                        Console.WriteLine("\"O javali consegue te atacar a tempo, te derrubando ao chão antes de fugir...\""); Console.ReadKey();
                        Valores.Vida = Valores.Vida - 1;
                        Programa.Morte.Morrando();
                        break;

                        case true:
                        Console.WriteLine("\"Você esmaga a cabeça do javali em baixo do seu pé...\"");Console.ReadKey();
                        Console.WriteLine("\"Ele está morto...\"");
                        Console.WriteLine("\"Deseja devorar ele?\"");
                        Console.WriteLine("S - Sim\nN - Não");
                        switch (Console.ReadLine().ToUpper())
                            {
                                case "S":
                                Console.WriteLine("\"Você devora a carne enrijecida...\"");
                                Console.WriteLine("\"Ela tem um gosto amargo e textura de couro.\"");Console.ReadKey();
                                Console.WriteLine("\"Algo começa a mudar dentro de você... Algum tipo de selvageria inata, despertada.\"");Console.ReadKey();
                                Valores.Vida++;
                                Valores.pontostats[2]--;
                                dano.Definhamento.DefMen();
                                break;

                                default:
                                Console.WriteLine("É melhor não.");Console.ReadKey();
                                break;
                            }
                        break;
                    }
                break;

                case "2":
                Console.Clear();
                Valores.CDteste = 16;
                D20s.dadovel();
                switch(Valores.sucesso)
                    {
                        case false:
                        Console.WriteLine("\"O javali consegue te atacar a tempo, te derrubando ao chão antes de fugir...\""); Console.ReadKey();
                        Valores.Vida = Valores.Vida - 1;
                        Programa.Morte.Morrando();
                        break;
                        
                        case true:
                        Console.WriteLine("\"Você consegue rapidamente desviar do javali.\"");
                        Console.WriteLine("\"Ele corre para outro lugar da floresta, procurando uma refeição mais fácil para caçar.\"");Console.ReadKey();
                        break;    
                    }
                break;

                case "3":
                Console.Clear();
                Console.WriteLine("Invoque uma palavra mágica");
                switch(Console.ReadLine().ToUpper())
                {
                    case "IXYBIL":
                    Console.WriteLine("Uma criatura simples. Avança quando consegue e tenta fugir quando não dá mais..."); Console.ReadKey();
                    Console.WriteLine("\"Você ainda é atingido.\""); Console.ReadKey();
                    Valores.Vida--;
                    Programa.Morte.Morrando();
                    SC.CastTrade();    
                    break;

                    case "FOL'HO":
                    Console.WriteLine("\"O javali negro é incinerado.\""); Console.ReadKey();
                    Valores.pontostats[3]++;
                    SC.CastTrade();
                    break;

                    default:
                    Console.WriteLine("\"O javali consegue te atacar a tempo, te derrubando ao chão antes de fugir...\""); Console.ReadKey();
                    break;
                }
                break;
            }
        }
        Console.WriteLine("Não há mais nada para fazer aqui."); Console.ReadKey();
    }

    public static void Sombras()
    {switch(Valores.listapassagens.Contains("SOMBRAS"))
        {
            case false:
            Valores.listapassagens.Add("SOMBRAS");
            break;
        }Console.Clear();
        Console.WriteLine("\"Você se encontra no meio de um lugar escuro, salvo por um poste de gás brilhando uma chama roxa.\"");
        Console.WriteLine("\"Não há mais nada para fazer aqui.\""); Console.ReadKey();
        Console.WriteLine("Tem um homem embaixo do poste");Console.ReadKey();
        Console.WriteLine("Será que eu deveria me aproximar dele? Ele me dá um sentimento estranho, especialmente aquele chapéu."); 
        Console.WriteLine("S - Sim\nN - Não");
        switch(Console.ReadLine().ToUpper())
        {
            case "S":
            Console.WriteLine("Eu sinto um medo constante afetar meu ser.");
            Valores.pontostats[2]--;
            dano.Definhamento.DefMen();
            Console.WriteLine("O homem se vira."); Console.ReadKey();
            switch(Valores.Vida)
                {
                    case 1:
                    Console.WriteLine("\"Se você está chegando ao fim verdadeiro, você deveria buscar algo para comer.\""); Console.ReadKey();
                    break;

                    case 2:
                    Console.WriteLine("\"Eles são a ambição, e as mais perigosas são as que vem de dentro.\""); Console.ReadKey();
                    break;

                    case 3:
                    Console.WriteLine("\"Cuidado com os olhos que te observam do escuro.\""); Console.ReadKey();
                    break;

                    case 4:
                    Console.WriteLine("\"Aquelas que tudo comem são as maiores e mais sombrias delas.\""); Console.ReadKey();
                    break;

                    default:
                    Console.WriteLine("\"Quanto mais arriscado o caminho, maior a chance do seu fim, e da fuga de alguém. Mas não você.\""); Console.ReadKey();
                    break;
                }
            Console.WriteLine("O Homem e o seu poste agora estão na mesma distância de antes."); Console.ReadKey();
            Console.WriteLine("Esse lugar não faz bem pra minha mente."); Console.ReadKey();
            break;

            default:
            Console.WriteLine("Ele me dá arrepios. É melhor eu sair daqui.");
            break;
        }
    }

    public static void enterro()
    {   do{switch(Valores.listapassagens.Contains("ENTERRO"))
        {
            case false:
            Valores.listapassagens.Add("ENTERRO");
            break;
        }
        Valores.ficar = 1; Console.Clear();
        Console.WriteLine("\"Você se encontra numa cúpula de pedra. O piso circular é cercado por água corrente aos lados.\"");
        Console.WriteLine("\"Duas estruturas elevadas se estendem pouco acima do chão.\"");
        Console.WriteLine("\"O que você deseja fazer?\"");

        Console.WriteLine("1 - Analisar a estrutura\n2 - Retornar");
        switch(Console.ReadLine())
            {
                case "1":
                Console.WriteLine("\"Você encontra algo similar a túmulos...\""); Console.ReadKey();
                Console.WriteLine("\"Os nomes estão apagados, mas um símbolo estranho permanece.\"");  Console.ReadKey();
                Console.WriteLine("Meu olho está queimando... Talvez eu possa tirar algum conhecimento disso.");
                switch(Console.ReadLine().ToUpper())
                    {
                        case "IXYBIL":
                        Console.WriteLine("O símbolo dos Filhos do Crepúsculo está desenhado com alguma magia nos túmulos");
                        Console.WriteLine("Ele parece estar lá contra a vontade dos mortos.");
                        Console.WriteLine("Eles há muito tempo abandonaram seu caminho."); Console.ReadKey();
                        Console.WriteLine("Eu sinto algo me observar da água..."); Console.ReadKey();
                        SC.CastTrade();
                        break;
                    }
                break;

                case "2":
                Console.WriteLine("\"Você decide sair daqui.\""); Console.ReadKey();
                Valores.ficar = 2;
                break;
            }
        }while (Valores.ficar == 1);
    }

 public static void casa()
    {Console.Clear();
        switch(Valores.listapassagens.Contains("CASA"))
        {
            case false:
            Valores.listapassagens.Add("CASA");
            break;
        }
        if (Valores.tontura == true)
        {
        Console.WriteLine("\"Você se encontra em uma casa vazia.\""); Console.ReadKey();
        Console.WriteLine("\"Todas as janelas estão trancadas e escuridão completa permanece fora delas, de forma quase palpável.\""); Console.ReadKey();
        Console.WriteLine("De repente você começa a ouvir uma música suave e atordoante tocando, como se ela estivesse te guiando mais fundo nessa casa em meio ao vazio.");
        Console.WriteLine("O que você deseja fazer?"); Console.WriteLine("1 - Seguir em frente\n2 - Resistir (Mental CD: 17)\n3 - Prestar atenção na letra (Observação CD: 20)");
        switch(Console.ReadLine())
            {
                case "1":
                Valores.pontostats[2]--;
                dano.Definhamento.DefMen();
                Console.WriteLine("Você segue perdido na embriaguez da canção, andando até o seu destino."); Console.ReadKey();
                break;

                case "2":
                Console.WriteLine("Você tenta invocar sua força interior para resistir a doce tentação do não pensar."); Console.ReadKey();
                Valores.CDteste = 17;
                D20s.dadomen();
                switch(Valores.sucesso)
                    {
                        case false:
                        Console.WriteLine("O que você estava fazendo mesmo?"); Console.ReadKey();
                        Valores.pontostats[3]--;
                        dano.Definhamento.DefObs();
                        Valores.pontostats[2]--;
                        dano.Definhamento.DefMen();
                        Console.WriteLine("Você sente uma tontura forte vindo de dentro de você."); Console.ReadKey();
                        break;

                        case true:
                        Valores.tontura = false;
                        Console.WriteLine("\"Você consegue recobrar boa parte da sua consciência.\""); Console.ReadKey();
                        Console.WriteLine("\"A canção não está mais ecoando em sua cabeça e você nota que está em um lugar diferente de antes. Você sente algo mudar em você.\""); Console.ReadKey();
                        break;
                    }
                break;

                case "3":
                Console.WriteLine("\"Você começa a focar na letra e pegar trechos da música cantada.\""); Console.ReadKey();
                Valores.CDteste = 20;
                D20s.dadoobs();
                switch(Valores.sucesso)
                {case false:
                Console.WriteLine("O que você estava fazendo mesmo?"); Console.ReadKey();
                Valores.pontostats[3]--;
                dano.Definhamento.DefObs();
                Valores.pontostats[2]--;
                dano.Definhamento.DefMen();
                Console.WriteLine("Você sente uma tontura forte vindo de dentro de você."); Console.ReadKey();
                break;

                case true:
                Valores.tontura = false;
                Console.WriteLine("\"Algo sobre uma princesa, buscando um cavaleiro?\""); Console.ReadKey();
                Console.WriteLine("\"A canção doce da voz é traída pelo tom profundo que segue por trás dela, sempre cantando em harmônia, mas escondido por trás da fachada gentil.\"");
                Console.WriteLine("\"Você sente o perigo oculto, mas é seduzido pelo possível saber, da mesma forma\""); Console.ReadKey();
                break;
                }
                
                break;
            }
            Console.Clear();
            Console.WriteLine("\"A música cessa, substituida por uma voz de tom leve.\"");
            Console.WriteLine("\"Ao mesmo tempo um símbolo começa a se formar em sua mente, algo beirando a visão e o pensamento.\""); Console.ReadKey();
            switch (Valores.tontura)
            {
                case true:
                Console.WriteLine("\"Inscreva minha runa na porta...\""); 
                Console.WriteLine("Quando eu parei na frente dessa porta de madeira?"); Console.ReadKey();
                Console.WriteLine("\"Inscreva na porta de traz de seu próprio ser.\"");
                Console.WriteLine("Eu devo seguir essas instruções"); Console.ReadKey();
                Console.WriteLine("\"De repente a voz outrora medida começa a gargalhar, uma bocarra é formada de sombras e pula em você arrancando uma parte do seu ser.\""); Console.ReadKey();
                Valores.Vida--;
                Programa.Morte.Morrando();
                break;

                case false:
                Console.WriteLine("Aqui está o foco da música, uma porta de madeira."); Console.ReadKey();
                Console.WriteLine("\"O tom da voz é pesado.\""); Console.ReadKey();
                Console.WriteLine("\"VOCÊ SABE O QUE ESTÁ ACONTECENDO AQUI NÃO É?\""); Console.ReadKey();
                Console.WriteLine("\"DESENHE MINHA RUNA, EU COMPENSAREI. MUITA FOME.\""); Console.ReadKey();
                do{Valores.ficar = 0;
                Console.WriteLine("O que fazer?\n1 - Desenhar a runa.\n2 - abrir a porta");
                switch(Console.ReadLine())
                {
                    case "1":
                    if (Programa.Conhecido.sabedorias.Contains("Phyzze, Sopro"))
                    {Console.WriteLine("\"NADA MAIS A DAR. ACEITO DOAÇÃO.\"");
                    Console.WriteLine("\"De repente a voz começa a gargalhar, uma bocarra é formada de sombras e pula em você arrancando uma parte do seu ser.\""); Console.ReadKey();
                    Valores.Vida--;
                    Programa.Morte.Morrando();
                    break;}
                    Console.WriteLine("Tudo bem.");
                    Console.WriteLine("\"Após você desenhar a runa, a criatura levanta a voz.\""); Console.ReadKey();
                    Console.WriteLine("\"IRÁ DOER.\""); Console.ReadKey(); 
                    Console.WriteLine("\"De repente a voz começa a gargalhar, uma bocarra é formada de sombras e pula em você arrancando uma parte do seu ser.\"");
                    Valores.Vida--;
                    Programa.Morte.Morrando();
                    Console.WriteLine("\"Ela também inscreve um feitiço dentro de sua mente.\""); Console.ReadKey();
                    Livros.Vento();
                    Programa.Conhecido.sabedorias.Add("Phyzze, Sopro");
                    Console.WriteLine("Novo conhecimento obtido."); Console.ReadKey();
                    break;

                    case "2":
                    Console.WriteLine("Você decide ignorar a voz e abrir a porta."); Console.ReadKey();
                    Console.WriteLine("\"VOLTE. FOME.\""); Console.ReadKey();
                    break;

                    default:
                    Valores.ficar = 1;
                    break;
                }
                } while(Valores.ficar == 1);
                break;
            }
            Console.WriteLine("\"Você acorda no chão na frente das passagens. Mas esse tal sonho foi tão real quanto todo o resto.\"");
            Console.WriteLine("\"Vale mesmo voltar pra lá?\""); Console.ReadKey();
        }
    }

    public static void vidente()
    {
        switch(Valores.listapassagens.Contains("VIDENTE"))
        {
            case false:
            Valores.listapassagens.Add("VIDENTE");
            break;
        }
        Console.WriteLine("\"Você se encontra numa sala escura de madeira, estantes vazias preenchem as paredes, e no meio há uma lâmpada de teto fraca, iluminando uma boneca.\""); Console.ReadKey();
        Console.WriteLine("\"A boneca aparenta ser algum tipo de marionete, com suas linhas subindo infinitamente à escuridão, tal qual a haste da lâmpada e adornada com um vestido simples, porém elegante.\"");
        Console.WriteLine("\"Um pote cinza e de cheiro metálico está preso à mão da boneca, que permanece estendida para frente, como se pedisse algo.\""); Console.ReadKey();
        Valores.CDteste = 15;
        D20s.dadoobs();
        switch(Valores.sucesso)
        {
            case true:
            Console.WriteLine("Você percebe que entalhado nas costas da boneca e pingando uma substância avermelhada há uma assinatura escrito Ara & Matri."); Console.ReadKey();
            break;
        }
        Console.WriteLine("O que eu deveria fazer?\n1 - Tocar no pote\n2 - Sair");
        switch(Console.ReadLine())
        {
            case "1":
            Console.WriteLine("\"Quando você toca no pote, a boneca rapidamente se mexe, puxando um cinzel afiado e perfurando sua mão.\""); Console.ReadKey();
            Valores.Vida--;
            Programa.Morte.Morrando();
            Console.WriteLine("\"Ela começa a falar, como se tivesse uma caixa de som presa dentro do corpo atormentado pelo tempo.\"");Console.ReadKey();
            Console.WriteLine("\"Não se deve aceitar preços altos demais para se pagar.\"");
            Console.WriteLine("\"Seu futuro inevitavelmente é se tornar...\""); Console.ReadKey();
            Console.WriteLine("\"Cinzas.\"");Console.ReadKey();
            break;

            default:
            Console.WriteLine("É melhor eu sair, essa boneca é estranha."); Console.ReadKey();
            break;
        }
        Console.WriteLine("Eu estou de volta aqui... O que era aquilo?"); Console.ReadKey();
    }

}