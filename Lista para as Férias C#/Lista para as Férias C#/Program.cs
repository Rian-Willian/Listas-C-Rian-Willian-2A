
// Lista de Atividades - Sistema de Jogos em C#

//1
/*
string nome = "";
string classe = "";
string[] atributos = {"Força", "Velocidade", "Inteligência"};
int[] atributosMago = { 5, 4, 10};
int[] atributosGuerreiro = { 10, 5, 3 };
int[] atributosAssassino = { 7, 10, 5 };

int opcao  = 0;

while (opcao != 3)
{
    Console.WriteLine("1 - Escolha seu nome.");
    Console.WriteLine();
    Console.WriteLine("2 - Escolha sua classe.");
    Console.WriteLine();
    Console.WriteLine("3 - Terminar.");
    Console.WriteLine();
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (opcao == 1)
    {
        Console.WriteLine("Qual é o seu nome?");
        Console.WriteLine();
        nome = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Sejá bem vindo(a) " + nome);
        Console.WriteLine();
    }
    else if (opcao == 2)
    {
        Console.WriteLine("Qual é a sua classe?");
        Console.WriteLine();
        Console.WriteLine("Mago, " +
            "\n\nGuerreiro, " +
            "\n\nAssassino");
        Console.WriteLine();
        classe = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Você será um grande " + classe);
        Console.WriteLine();

        if (classe == "Mago")
        {
            Console.WriteLine("Seus atributos são focados em Inteligência, porém sua Velocidade e Força são baixos.");
            Console.WriteLine();
            Console.WriteLine(atributos[0] + " " + atributosMago[0]);
            Console.WriteLine();
            Console.WriteLine(atributos[1] + " " + atributosMago[1]);
            Console.WriteLine();
            Console.WriteLine(atributos[2] + " " + atributosMago[2]);
            Console.WriteLine();
        }
        else if (classe == "Guerreiro")
        {
            Console.WriteLine("Seus atributos são focados em Força, porém sua Velocidade e Inteligência são baixos.");
            Console.WriteLine();
            Console.WriteLine(atributos[0] + " " + atributosGuerreiro[0]);
            Console.WriteLine();
            Console.WriteLine(atributos[1] + " " + atributosGuerreiro[1]);
            Console.WriteLine();
            Console.WriteLine(atributos[2] + " " + atributosGuerreiro[2]);
            Console.WriteLine();
        }
        else if (classe == "Assassino")
        {
            Console.WriteLine("Seus atributos são focados em Velocidade, sua Inteligência e Força são medianos.");
            Console.WriteLine();
            Console.WriteLine(atributos[0] + " " + atributosAssassino[0]);
            Console.WriteLine();
            Console.WriteLine(atributos[1] + " " + atributosAssassino[1]);
            Console.WriteLine();
            Console.WriteLine(atributos[2] + " " + atributosAssassino[2]);
            Console.WriteLine();
        }
        
    }
}
Console.WriteLine("Você acabou a criação de personagem!");
Console.WriteLine();
Console.WriteLine("Está livre para explorar!");
Console.WriteLine();
*/

//2
/*
int fase = 0;

Console.WriteLine("Escolha uma fase. Cada uma tem uma dificuldade, escolha com sabedoria.");
Console.WriteLine();
Console.WriteLine("Fase 1 - Floresta [Fácil]" +
    "\n\nFase 2 - Caverna de Cristal [Normal]" +
    "\n\nFase 3 - Vulcão [Díficl]" +
    "\n\nFase 4 - Inferno [Impossível]" +
    "\n\n(Escreva o número da fase para selecionar!!!)");
Console.WriteLine();
fase = int.Parse(Console.ReadLine());
Console.WriteLine();

switch (fase)
{
    case 1:
        Console.WriteLine("Você entrou na Floresta" +
            "\n\nUma floresta densa e antiga, onde árvores gigantes bloqueiam a luz do sol. O silêncio é interrompido apenas pelo canto de criaturas misteriosas e pelo farfalhar das folhas, escondendo perigos e segredos.");
        break;

    case 2:
        Console.WriteLine("Você entrou na Caverna de Cristal" +
            "\n\nUma caverna iluminada por enormes cristais reluzentes que refletem luzes coloridas pelas paredes. Sua beleza esconde armadilhas naturais e seres que protegem os tesouros do local.");
        break;

    case 3:
        Console.WriteLine("Você entrou na Vulção" +
            "\n\nUm vulcão ativo tomado por rios de lava e fumaça sufocante. O calor intenso torna cada passo um desafio, enquanto criaturas resistentes ao fogo guardam o caminho até seu coração.");
        break;

    case 4:
        Console.WriteLine("Você entrou no Inferno" +
            "\n\nUm reino de fogo eterno, cinzas e sofrimento. Entre rios de lava e fortalezas sombrias, demônios e almas condenadas vagam sob um céu vermelho, onde apenas os mais fortes conseguem sobreviver.");
        break;

    default: Console.WriteLine("Opção Inválida");
        break;
}
*/

//3
/*
string[] inventario = { "Espada", "Arco", "Poção de Vida", "Armadura", "Capacete", "Calças", "Pão" };


Console.WriteLine("--INVENTÁRIO--");

foreach (string item in inventario)
{
    Console.WriteLine("- " + item);
}

Console.WriteLine("Qual item você deseja?");

string procurar  = Console.ReadLine();

bool encontrado = false;

foreach  (string item in inventario)
{
    if (procurar == "Espada")
    {
        encontrado = true;
    }
    else if (procurar == "Arco")
    {
        encontrado = true;
    }
    else if (procurar == "Poção de Vida")
    {
        encontrado = true;
    }
    else if (procurar == "Armadura")
    {
        encontrado = true;
    }
    else if (procurar == "Capacete")
    {
        encontrado = true;
    }
    else if (procurar == "Calças")
    {
        encontrado = true;
    }
    else if (procurar == "Pão")
    {
        encontrado = true;
    }
    else
    {
        encontrado = false;
    }
}

if (encontrado == true)
{
    Console.WriteLine("Este item existe no seu inventário.");
}
else
{
    Console.WriteLine("Este item não existe no seu inventário.");
}
*/

//4
/*
string[] loja = { "Espada", "Arco", "Machado", "Picareta", "Poção de Vida", "Poção de Velocidade" };
int[] precos = { 100, 70, 120, 80, 25, 20 };

int moedas = 100;

Console.WriteLine("---LOJA---");
Console.WriteLine("Moedas: "+ moedas);
Console.WriteLine();

for (int i = 0; i < loja.Length; i++)
{
    Console.WriteLine((i + 1) + " - " + loja[i] + " - " + precos[i] + " moedas");
}

Console.WriteLine("\nEscolha um item (1, 2, 3, 4, 5 ou 6)");

int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        if (moedas >= precos[0])
        {
            moedas = moedas - precos[0];
            Console.WriteLine("Você comprou um(a) " + loja[0] + "!");
        }
        else
        {
            Console.WriteLine("Moedas insuficientes!");
        }
        break;
    case 2:
        if (moedas >= precos[1])
        {
            moedas = moedas - precos[1];
            Console.WriteLine("Você comprou um(a) " + loja[1] + "!");
        }
        else
        {
            Console.WriteLine("Moedas insuficientes!");
        }
        break;
    case 3:
        if (moedas >= precos[2])
        {
            moedas = moedas - precos[2];
            Console.WriteLine("Você comprou um(a) " + loja[2] + "!");
        }
        else
        {
            Console.WriteLine("Moedas insuficientes!");
        }
        break;
    case 4:
        if (moedas >= precos[3])
        {
            moedas = moedas - precos[3];
            Console.WriteLine("Você comprou um(a) " + loja[3] + "!");
        }
        else
        {
            Console.WriteLine("Moedas insuficientes!");
        }
        break;
    case 5:
        if (moedas >= precos[4])
        {
            moedas = moedas - precos[4];
            Console.WriteLine("Você comprou um(a) " + loja[4] + "!");
        }
        else
        {
            Console.WriteLine("Moedas insuficientes!");
        }
        break;
    case 6:
        if (moedas >= precos[5])
        {
            moedas = moedas - precos[5];
            Console.WriteLine("Você comprou um(a) " + loja[5] + "!");
        }
        else
        {
            Console.WriteLine("Moedas insuficientes!");
        }
        break;
    default: Console.WriteLine("Opção inválida!");
            break;
}

Console.WriteLine("Saldo restante: " + moedas + " moedas");
*/

//5
/*
int vidaJ = 100;
int vidaI = 100;

int energiaJ = 100;
int energiaI = 100;

int danoLJ = 10;
int gastoLJ = 10;
int danoPJ = 25;
int gastoPJ = 20;

int danoLI = 10;
int gastoLI = 10;
int danoPI = 25;
int gastoPI = 20;

Random random = new Random();

while (vidaJ > 0 && vidaI > 0)
{
    Console.WriteLine("\n------------------------");
    Console.WriteLine("Vida do Jogador: " + vidaJ);
    Console.WriteLine("Vida do Inimigo: " + vidaI); 
    Console.WriteLine("Energia do Jogador: " + energiaJ);
    Console.WriteLine("Energia do Inimigo: " + energiaI);

    Console.WriteLine("\n1 - Ataque Leve");
    Console.WriteLine("2 - Ataque Pesado");

    Console.WriteLine();

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            if (energiaJ >= gastoLJ)
            {
                Console.WriteLine("Você usou Ataque Leve!");
                vidaI = vidaI - danoLJ;
                energiaJ = energiaJ - gastoLJ;
            }
            else
            {
                Console.WriteLine("Energia insuficiente!");
            }
            break;

        case 2:
            if (energiaJ >= gastoPJ)
            {
                Console.WriteLine("Você usou Ataque Pesado!");
                vidaI = vidaI - danoPJ;
                energiaJ = energiaJ - gastoPJ;
            }
            else
            {
                Console.WriteLine("Energia insuficiente!");
            }
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    if (vidaI <= 0)
    {
        break;
    }
    

    Console.WriteLine("\nVez do Inimigo!");

    int ataque = random.Next(1, 3);

    if (ataque == 1)
    {
        if(energiaI > gastoLI)
        {
            vidaJ = vidaJ - danoLI;
            energiaI = energiaI - gastoLI;
            Console.WriteLine("Inimigo usou Ataque Leve!");
        }
        else
        {
            Console.WriteLine("Energia Insuficiente");
        }
    }
    else
    {
        if (energiaI > gastoLI)
        {
            vidaJ = vidaJ - danoPI;
            energiaI = energiaI - gastoPI;
            Console.WriteLine("Inimigo usou Ataque Pesado!");
        }
        else
        {
            Console.WriteLine("Energia Insuficiente");
        }
    }
}

if (vidaJ > 0)
{
    Console.WriteLine("\nO Jogador venceu!");
}
else
{
    Console.WriteLine("\nO Inimigo venceu!");
}
*/
//6
/*
Random random = new Random();

int recompensa = random.Next(1, 5);

switch (recompensa)
{
    case 1:
        Console.WriteLine("Você recebeu uma Espada de Ferro!");
        break;

    case 2:
        Console.WriteLine("Você recebeu 100 moedas!");
        break;

    case 3:
        Console.WriteLine("Você ganhou 50 pontos de experiência!");
        break;

    case 4:
        Console.WriteLine("Sua vida aumentou em 20 pontos!");
        break;
}
*/

//7
/*
Random random = new Random();

int vida = 100;
int energia = 100;
int moedas = 50;
int coragem = 10;
int reputacao = 0;

Console.WriteLine("Você entrou em uma área misteriosa...");

int evento = random.Next(1, 6);

switch (evento)
{
    case 1:
        Console.WriteLine("Você encontrou um baú!");
        moedas += 30;
        break;

    case 2:
        Console.WriteLine("Um monstro apareceu e te atacou!");
        vida -= 20;
        break;

    case 3:
        Console.WriteLine("Você encontrou uma fonte de energia.");
        energia += 20;
        break;

    case 4:
        Console.WriteLine("Você ajudou um viajante perdido.");
        reputacao += 10;
        break;

    case 5:
        Console.WriteLine("Você enfrentou seus medos.");
        coragem += 5;
        break;
}

Console.WriteLine("\n=== Status do Personagem ===");
Console.WriteLine("Vida: " + vida);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Moedas: " + moedas);
Console.WriteLine("Coragem: " + coragem);
Console.WriteLine("Reputação: " + reputacao);
*/

//8

/*
int vida = 100;
int reputacao = 0;

Console.WriteLine("===== MISSÃO: RESGATAR O VIAJANTE =====");
Console.WriteLine("Um viajante foi capturado por bandidos.");
Console.WriteLine();

Console.WriteLine("Você deseja aceitar a missão?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Não");

int escolha = int.Parse(Console.ReadLine());

if (escolha == 2)
{
    Console.WriteLine("\nVocê recusou a missão.");
    Console.WriteLine("Missão Falhou!");
    return;
}

Console.WriteLine("\nVocê encontrou os bandidos.");
Console.WriteLine("O que deseja fazer?");
Console.WriteLine("1 - Atacar");
Console.WriteLine("2 - Conversar");

escolha = int.Parse(Console.ReadLine());

if (escolha == 1)
{
    Console.WriteLine("\nVocê derrotou os bandidos, mas se machucou.");
    vida -= 30;
    reputacao += 20;
}
else
{
    Console.WriteLine("\nVocê convenceu os bandidos a libertarem o viajante.");
    reputacao += 10;
}

Console.WriteLine("\n===== RESULTADO =====");

if (vida > 70)
{
    Console.WriteLine("Missão concluída com sucesso!");
}
else if (vida > 0)
{
    Console.WriteLine("Missão concluída parcialmente.");
}
else
{
    Console.WriteLine("Missão falhou.");
}

Console.WriteLine("Vida: " + vida);
Console.WriteLine("Reputação: " + reputacao);
*/

//9

/*
int confianca = 0;

Console.WriteLine("Um velho mago se aproxima.");

Console.WriteLine("1 - Cumprimentar");
Console.WriteLine("2 - Ignorar");
Console.WriteLine("3 - Ameaçar");

int resposta = int.Parse(Console.ReadLine());

switch (resposta)
{
    case 1:
        confianca += 20;
        Console.WriteLine("O mago sorriu.");
        break;

    case 2:
        Console.WriteLine("O mago ficou em silêncio.");
        break;

    case 3:
        confianca -= 20;
        Console.WriteLine("O mago ficou com medo.");
        break;
}

Console.WriteLine();

if (confianca >= 20)
{
    Console.WriteLine("O mago entregou um mapa secreto.");
}
else if (confianca >= 0)
{
    Console.WriteLine("O mago apenas desejou boa sorte.");
}
else
{
    Console.WriteLine("O mago foi embora irritado.");
}

Console.WriteLine("Confiança: " + confianca);
*/

//10

/*
int vida = 100;

Console.WriteLine("Você encontrou uma porta trancada.");
Console.WriteLine("A senha é um número de 4 dígitos.");

Console.Write("Digite a senha: ");
string senha = Console.ReadLine();

if (senha == "2580")
{
    Console.WriteLine("Senha correta!");
    Console.WriteLine("Você abriu a porta.");
}
else
{
    vida -= 20;

    Console.WriteLine("Senha incorreta!");
    Console.WriteLine("Você perdeu 20 de vida.");
}

Console.WriteLine("Vida restante: " + vida);
*/

//11

/*
Random random = new Random();

int vida = 100;
int moedas = 0;
int energia = 100;

int opcao = 0;

while (opcao != 4)
{
    Console.WriteLine("\n===== EXPLORAÇÃO =====");
    Console.WriteLine("1 - Explorar");
    Console.WriteLine("2 - Ver Status");
    Console.WriteLine("3 - Descansar");
    Console.WriteLine("4 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:

            int evento = random.Next(1, 5);

            switch (evento)
            {
                case 1:
                    Console.WriteLine("Você encontrou 20 moedas.");
                    moedas += 20;
                    break;

                case 2:
                    Console.WriteLine("Um lobo atacou.");
                    vida -= 15;
                    break;

                case 3:
                    Console.WriteLine("Você encontrou frutas.");
                    energia += 10;
                    break;

                case 4:
                    Console.WriteLine("Você encontrou um baú vazio.");
                    break;
            }

            break;

        case 2:

            Console.WriteLine("Vida: " + vida);
            Console.WriteLine("Energia: " + energia);
            Console.WriteLine("Moedas: " + moedas);

            break;

        case 3:

            energia += 20;

            if (energia > 100)
            {
                energia = 100;
            }

            Console.WriteLine("Você descansou.");

            break;

        case 4:

            Console.WriteLine("Você saiu da exploração.");

            break;
    }
}
*/

//12

/*
int vida = 100;
int vidaMax = 100;
int opcao = 0;

while (opcao != 4)
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1 - Sofrer dano");
    Console.WriteLine("2 - Curar");
    Console.WriteLine("3 - Ver vida");
    Console.WriteLine("4 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            vida -= 20;

            if (vida < 0)
            {
                vida = 0;
            }

            Console.WriteLine("Você perdeu 20 de vida.");
            break;

        case 2:
            vida += 30;

            if (vida > vidaMax)
            {
                vida = vidaMax;
            }

            Console.WriteLine("Você recuperou 30 de vida.");
            break;

        case 3:
            Console.WriteLine("Vida atual: " + vida + "/" + vidaMax);
            break;
    }
}

Console.WriteLine("Programa encerrado.");
*/

//13

/*
Console.WriteLine("O seu rank vai ser definido por sua quantidade de pontos.");
Console.WriteLine("--- Qual é o seu rank? ---");
Console.WriteLine("Quantos pontos você têm? (1 a 100)");
int pontos = int.Parse(Console.ReadLine());

if (pontos == 100)
{
    Console.WriteLine("Seu rank é lendário!");
}
else if(pontos >= 50)
{
    Console.WriteLine("Seu rank é épico!");
}
else if(pontos >= 0)
{
    Console.WriteLine("Seu rank é iniciante!");
}
else
{
    Console.WriteLine("Rank inexistente!");
}
*/

//14

/*
string[] inimigos =
{
    "Goblin",
    "Esqueleto",
    "Orc"
};

int vida = 100;

Console.WriteLine("Inimigos na sala:");

foreach (string inimigo in inimigos)
{
    Console.WriteLine("- " + inimigo);
}

Console.WriteLine("\n1 - Atacar");
Console.WriteLine("2 - Fugir");

int escolha = int.Parse(Console.ReadLine());

if (escolha == 1)
{
    vida -= 30;
    Console.WriteLine("Você derrotou os inimigos!");
}
else
{
    Console.WriteLine("Você fugiu da batalha.");
}

Console.WriteLine("Vida: " + vida);
*/

//15

/*
Random random = new Random();

int cristais = 0;

while (cristais < 20)
{
    int coleta = random.Next(1, 6);

    cristais += coleta;

    Console.WriteLine("Você encontrou " + coleta + " cristais.");
    Console.WriteLine("Total: " + cristais);
}

Console.WriteLine("Objetivo alcançado!");
*/

//16

/*
Random random = new Random();

int vida = 100;
int comida = 50;
int rodada = 1;

while (vida > 0 && rodada <= 10)
{
    Console.WriteLine("\nRodada " + rodada);

    int evento = random.Next(1, 4);

    switch (evento)
    {
        case 1:
            vida -= 15;
            Console.WriteLine("Um animal atacou.");
            break;

        case 2:
            comida += 10;
            Console.WriteLine("Você encontrou comida.");
            break;

        case 3:
            comida -= 10;
            Console.WriteLine("Você passou fome.");
            break;
    }

    if (comida <= 0)
    {
        vida -= 10;
    }

    Console.WriteLine("Vida: " + vida);
    Console.WriteLine("Comida: " + comida);

    rodada++;
}

if (vida > 0)
{
    Console.WriteLine("Você sobreviveu!");
}
else
{
    Console.WriteLine("Você morreu.");
}
*/

//17

/*
int coragem = 8;

Console.WriteLine("Escolha um caminho:");
Console.WriteLine("1 - Floresta");
Console.WriteLine("2 - Montanha");
Console.WriteLine("3 - Caverna");

int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("Você encontrou moedas.");
        break;

    case 2:
        if (coragem >= 10)
        {
            Console.WriteLine("Você atravessou a montanha.");
        }
        else
        {
            Console.WriteLine("Faltou coragem.");
        }
        break;

    case 3:
        Console.WriteLine("Você encontrou um tesouro.");
        break;
}
*/

//18

/*
Random random = new Random();

int moedas = 0;
int vida = 100;

int loot = random.Next(1, 5);

switch (loot)
{
    case 1:
        Console.WriteLine("Você encontrou uma espada.");
        break;

    case 2:
        moedas += 100;
        Console.WriteLine("Você encontrou 100 moedas.");
        break;

    case 3:
        vida += 20;
        Console.WriteLine("Você encontrou uma poção.");
        break;

    case 4:
        Console.WriteLine("Você encontrou uma armadura.");
        break;
}

Console.WriteLine("Vida: " + vida);
Console.WriteLine("Moedas: " + moedas);
*/

//19

/*
string nome1 = "Guerreiro";
int vida1 = 100;
int forca1 = 20;

string nome2 = "Mago";
int vida2 = 80;
int forca2 = 35;

Console.WriteLine(nome1);
Console.WriteLine("Vida: " + vida1);
Console.WriteLine("Força: " + forca1);

Console.WriteLine();

Console.WriteLine(nome2);
Console.WriteLine("Vida: " + vida2);
Console.WriteLine("Força: " + forca2);

Console.WriteLine();

if (forca1 > forca2)
{
    Console.WriteLine(nome1 + " é mais forte.");
}
else
{
    Console.WriteLine(nome2 + " é mais forte.");
} 
*/
