

//Lista de Metodos e Funções 

//1

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
