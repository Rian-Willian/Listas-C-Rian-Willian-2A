

//LISTA DE REVISÃO C#

//2
/*
Console.WriteLine("===Aventuras do Baiano===");
Console.WriteLine("Genêro: Aventura");
Console.WriteLine("Local: Bahia");
Console.WriteLine("Personagem Principal: Baiano");
Console.WriteLine("Objetivo: Coletar Acarajés e Aprender Capoeira");
Console.WriteLine("Seja bem vindo meu pivete, explore a vasta Bahia e descubra novos segredos !!!");

//4

Console.WriteLine("Qual é seu nome?");
string nome = Console.ReadLine();
Console.WriteLine("Qual é sua classe?");
string classe = Console.ReadLine();
Console.WriteLine("Qual é o nome do mundo?");
string nomeMundo = Console.ReadLine();
Console.WriteLine("Qual é seu objetivo?");
string objetivo = Console.ReadLine();

Console.WriteLine(nome + ", " + "da classe " + classe + ", " + "entrou no mundo " + nomeMundo + ".");
Console.WriteLine("Sua missão é " + objetivo);

//6

string nome = "Luna";
string classe = "Maga";

int vida = 100;
int energia = 80;
int moedas = 25;

float velocidade = 5.5f;

bool temChave = false;

Console.WriteLine("====FICHA====");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Classe: " + classe);
Console.WriteLine("Vida: " + vida);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Moedas: " + moedas);
Console.WriteLine("Velocidade: " + velocidade);
Console.WriteLine("Tem chave: " + temChave);

//8

Console.WriteLine("Qual é sua quantidade de vida?");
int vida = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é sua quantidade de energia?");
int energia = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é sua quantidade de força?");
int forca = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é sua quantidade de defesa?");
int defesa = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é sua quantidade de moedas?");
int moedas = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é seu nível?");
int nivel = int.Parse(Console.ReadLine());

Console.WriteLine("====FICHA====");
Console.WriteLine("Vida: " + vida);
Console.WriteLine("Energia: " + energia);
Console.WriteLine("Força: " + forca);
Console.WriteLine("Defesa: " + defesa);
Console.WriteLine("Moedas: " + moedas);
Console.WriteLine("Nível: " + nivel);

//10

Console.WriteLine("Qual é a sua vida inicial?");
int vida = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto de dano você recebeu?");
int danoRecebido = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto de cura você recebeu?");
int cura = int.Parse(Console.ReadLine());

Console.WriteLine("Quantos pontos um inimigo dar após sua derrota?");
int pontosInimigo = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é a sua vida inicial?");
int quantidadeInimigos = int.Parse(Console.ReadLine());

int vidaFinal = vida - danoRecebido;
int vidaCura = vida - cura;
int pontuacaoTotal = pontosInimigo * quantidadeInimigos;
int pontuacaoBonus = pontuacaoTotal * 2;

Console.WriteLine("Vida após o dano: " + vidaFinal);
Console.WriteLine("Vida após cura: " + vidaCura);
Console.WriteLine("Pontuação Total: " + pontuacaoTotal);
Console.WriteLine("Pontuação Bonus: " + pontuacaoBonus);

//12

Console.WriteLine("Quanto de energia você tem?");
int energia = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto de energia custa sua habilidade?");
int custo  = int.Parse(Console.ReadLine());

int energiaFinal = energia - custo;

if (energia >= custo)
{
    Console.WriteLine("Você pode usar a habilidade.");
    Console.WriteLine("Energia restante: " + energiaFinal);
}
else
{
    Console.WriteLine("Você não pode usar a habilidade.");
}

//14

Console.WriteLine("Quanto de saúde você possui?");
int saude = int.Parse(Console.ReadLine());

if (saude >= 100)
{
    Console.WriteLine("Saudável");
}
else if (saude >= 70)
{
    Console.WriteLine("Ferido");
}
else if (saude > 0)
{
    Console.WriteLine("Estado Crítico");
}
else  if (saude <= 0)
{
    Console.WriteLine("Derrotado");
}

//16

Console.WriteLine("Quanto de energia você tem?");
int energia = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto de nível você tem?");
int nivel = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto de vida você tem?");
int vida = int.Parse(Console.ReadLine());

Console.WriteLine("Você possui um item especial?");
string itemEspecial = Console.ReadLine();

if(itemEspecial == "Sim")
{
    bool temItem = true;
}
else
{
    bool temItem = false;
}

if (energia >= 50 && nivel >= 5 && vida >= 50 || itemEspecial == "Sim")
{
    Console.WriteLine("Você consegue usar a habilidade.");
}
else
{
    Console.WriteLine("Você não possui os requisitos para usar a habilidade especial.");
}

//18

Console.WriteLine("1 - Guerreiro");
Console.WriteLine("2 - Arqueiro");
Console.WriteLine("3 - Mago");
Console.WriteLine("4 - Assassino");

Console.WriteLine("Qual classe você deseja? (Escreva o número correspondente.)");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Nome: Guerreiro");
        Console.WriteLine("Vida Inicial: 120");
        Console.WriteLine("Energia Inicial: 80");
        Console.WriteLine("Força Inicial: 50");
        Console.WriteLine("Habilidade Principal: Berserker");
        break;
    case 2:
        Console.WriteLine("Nome: Arqueiro");
        Console.WriteLine("Vida Inicial: 80");
        Console.WriteLine("Energia Inicial: 120");
        Console.WriteLine("Força Inicial: 30");
        Console.WriteLine("Habilidade Principal: Sniper");
        break;
    case 3:
        Console.WriteLine("Nome: Mago");
        Console.WriteLine("Vida Inicial: 50");
        Console.WriteLine("Energia Inicial: 200");
        Console.WriteLine("Força Inicial: 60");
        Console.WriteLine("Habilidade Principal: Infinity");
        break;
    case 4:
        Console.WriteLine("Nome: Assassino");
        Console.WriteLine("Vida Inicial: 150");
        Console.WriteLine("Energia Inicial: 50");
        Console.WriteLine("Força Inicial: 80");
        Console.WriteLine("Habilidade Principal: Sombra");
        break;
    default: Console.WriteLine("Escolheu errado");
        break;
}

//20

Console.WriteLine("1 - Explorar");
Console.WriteLine("2 - Descansar");
Console.WriteLine("3 - Visualizar status");
Console.WriteLine("4 - Sair");

Console.Write("Escolha uma opção: ");

int opcao = int.Parse(Console.ReadLine());

while (opcao != 4)
{
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Explorar caverna concluido.");
            break;
        case 2:
            Console.WriteLine("Descansar no hotel.");
            break;
        case 3:
            Console.WriteLine("Visualização de status bem sucedida.");
            break;
        default: 
            Console.WriteLine("Escolheu errado.");
            break;
    }
    Console.WriteLine();
    Console.WriteLine("1 - Explorar");
    Console.WriteLine("2 - Descansar");
    Console.WriteLine("3 - Visualizar status");
    Console.WriteLine("4 - Sair");

    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine());
}

Console.WriteLine("Você saiu do jogo!");

//22

Console.WriteLine("===BAÚ ALEATÓRIO===");

Random random = new Random();

int itens = random.Next(1,7);

if (itens == 1)
{
    Console.WriteLine("Você ganhou moedas.");
}
else if (itens == 2)
{
    Console.WriteLine("Você ganhou poções.");
}
else if (itens == 3)
{
    Console.WriteLine("Você ganhou uma arma.");
}
else if (itens == 4)
{
    Console.WriteLine("Você caiu na armadilha.");
}
else
{
    Console.WriteLine("Você não ganhou recompensa.");
}

//24

Random random = new Random();

int pontos = 0;

for (int onda = 1; onda <= 5; onda++)
{
    Console.WriteLine("Onda: " + onda);
    int inimigos = random.Next(1, 11);
    Console.WriteLine("A quantidade de inimigos dessa onde é: " + inimigos);
    pontos = pontos + 10;
    int pontoFinal = pontos * inimigos;
    Console.WriteLine("A quantidade de pontos que você tem nessa rodada foi: " + pontoFinal);

}

//26

string[] personagens = { "Rian" , "Nicolle" , "Sula" , "Valentina"};
int[] vidas = { 100 , 120 , 50 , 40};
int[] forcas = { 50, 10, 40, 30 };
int[] energias = { 120, 100, 70, 50};

Console.WriteLine("Nome: " + personagens[0] + 
    "\nVida: " + vidas[0] + "\nForça: " + forcas[0] + 
    "\nEnergia: " + energias[0]);

Console.WriteLine("Nome: " + personagens[1] +
    "\nVida: " + vidas[1] + "\nForça: " + forcas[1] +
    "\nEnergia: " + energias[1]);

Console.WriteLine("Nome: " + personagens[2] +
    "\nVida: " + vidas[2] + "\nForça: " + forcas[2] +
    "\nEnergia: " + energias[2]);

Console.WriteLine("Nome: " + personagens[3] +
    "\nVida: " + vidas[3] + "\nForça: " + forcas[3] +
    "\nEnergia: " + energias[3]);
*/
//28