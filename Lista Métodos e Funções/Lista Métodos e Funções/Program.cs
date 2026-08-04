

//Lista de Metodos e Funções 

//1
/*
void ApresentaçãoInicial()
{
    Console.WriteLine("==== PROGRAMAÇÃO NO CONSOLE ====");
    Console.WriteLine("Este jogo é para testar Métodos e Funções");
    Console.WriteLine("O objetivo principal é testar meus conhecimentos");
    Console.WriteLine("=========" +
        "\nPROGRAMAÇÃO NO CONSOLE" +
        "\n=========");
    Console.WriteLine("Boa Sorte!");
}

ApresentaçãoInicial();

//2

void MostrarCena(string personagem, string classe, string fala)
{
    Console.WriteLine(personagem + " (" + classe + "): " + fala);
}
MostrarCena("Arthur","Guerreiro", "Vamos para a batalha!");
MostrarCena("Luna", "Arqueira", "Estou pronta!");
MostrarCena("Kai", "Mago", "Usarei minha magia!");

//3

void LeituraDeDados(out string nome, out string classe, out int vida, out int energia, out int forca, out int moedas)
{
    Console.Write("Nome: ");
    nome = Console.ReadLine();

    Console.Write("Classe: ");
    classe = Console.ReadLine();

    Console.Write("Vida: ");
    vida = int.Parse(Console.ReadLine());

    Console.Write("Energia: ");
    energia = int.Parse(Console.ReadLine());

    Console.Write("Força: ");
    forca = int.Parse(Console.ReadLine());

    Console.Write("Moedas: ");
    moedas = int.Parse(Console.ReadLine());
}

int CalcularPontos(int vida, int moedas)
{
    return vida * moedas;
}

void MostrarFicha(string nome, string classe, int vida, int energia, int forca, int moedas, int pontos)
{
    Console.WriteLine("\n===== FICHA DO PERSONAGEM =====");
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Classe: " + classe);
    Console.WriteLine("Vida: " + vida);
    Console.WriteLine("Energia: " + energia);
    Console.WriteLine("Força: " + forca);
    Console.WriteLine("Moedas: " + moedas);
    Console.WriteLine("Pontuação: " + pontos);
}

string nome, classe;
int vida, energia, forca, moedas;

LeituraDeDados(out nome, out classe, out vida, out energia, out forca, out moedas);

int pontos = CalcularPontos(vida, moedas);

MostrarFicha(nome, classe, vida, energia, forca, moedas, pontos);

//4
Console.WriteLine("Digite o valor do seu ataque.");
int ataque = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da sua defesa.");
int defesa = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do seu ataque bonus.");
int bonus = int.Parse(Console.ReadLine());

int CalcularDano(int ataque,int defesa,int bonus)
{
    int dano = ataque - defesa + bonus;

    if (dano < 0)
    {
        dano = 0;
    }

    return dano;
}

int dano = CalcularDano(ataque, defesa, bonus);

Console.WriteLine("Dano final: " + dano);



//5

Console.WriteLine("Digite sua vida atual.");
int vidaAtual = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de cura que você recebeu.");
int cura = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da sua vida máxima.");
int vidaMax = int.Parse(Console.ReadLine());

int CalcularVida (int vidaAtual, int cura, int vidaMax)
{
    vidaMax = vidaAtual + cura;

    if (vidaMax > vidaMax)
    {
        vidaMax = vidaMax;
    }

    return vidaMax;
}

vidaMax = CalcularVida(vidaAtual, cura, vidaMax);

Console.WriteLine("Vida final: " + vidaMax);
*/
//6