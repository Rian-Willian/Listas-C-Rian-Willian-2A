// Lista de Vetor e For 

//1 

/*
string[] nomes = {"Rian", "Nicolle", "Sula"};

for  (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}
*/

//2

/*
string[] itens = { "Poção", "Arco", "Espada", "Machado" };

Console.WriteLine("Primeiro item é: " + itens[0]);
Console.WriteLine("Segundo item é: " + itens[1]);
Console.WriteLine("Terceiro item é: " + itens[2]);
Console.WriteLine("Quarto item é: " + itens[3]);
*/

//3

/*
string[] itens = { "Poção", "Arco", "Espada", "Machado", "Carne" };

Console.WriteLine("Invetário: ");

for (int i = 0; i < itens.Length; i++)
{
    Console.WriteLine(itens[i]);
}
*/

//4

/*
string[] fases = { "Floresta", "Caverna", "Castelo", "Laboratório" };

for  (int i = 0; i < fases.Length; i++)
{
    Console.WriteLine((i+1) + " - " + fases[i]);
}
*/

//5

/*
int[] pontos = { 100, 250, 300, 150, 400 };

for (int i = 0; i < pontos.Length; i++)
{
    Console.WriteLine("Fase " + (i+1) + ": " + pontos[i]);
}
*/

//6

/*
int[] pontos = { 100, 250, 300, 150, 400 };
int total = 0;

for (int i = 0; i < pontos.Length; i++)
{
    total = total + pontos[i];
}

Console.WriteLine("Pontuação total: " + total);
*/

//7

/*
int[] partidas = { 80, 120, 60, 200, 150 };

int maior = partidas[0];

for (int i = 1; i < partidas.Length; i++)
{
    if (partidas[i] > maior)
    {
        maior = partidas[i];
    }
}

Console.WriteLine("Maior pontuação: " + maior);
*/

//8

/*
string[] inventario = { "Poção", "Mapa", "Chave", "Cristal" };

bool encontrou = false;

Console.WriteLine("== Inventário ==");

for (int i = 0; i < inventario.Length; i++)
{
    Console.WriteLine(inventario[i]);
}

Console.WriteLine("\nDigite o nome de um item.");

string item = Console.ReadLine();

for  (int i = 0; i < inventario.Length; i++)
{
    if (inventario[i] == item)
    {
        encontrou = true;
    }
}

if (encontrou)
{
    Console.WriteLine("Item encontrado!");
}
else
{
    Console.WriteLine("Item não encontrado!");
}
*/

//9

/*
string[] inimigos = { "Slime", "Morcego", "Goblin", "Esqueleto" };

Console.WriteLine("Inimigos encontrados:");

for(int i = 0; i < inimigos.Length; i++)
{
    Console.WriteLine("Um " + inimigos[i] + " apareceu!");
}

Console.WriteLine("Total de inimigos: " + inimigos.Length);
*/

//10 

/*
string[] nomes = { "Luna", "Kai", "Mika" };
int[] vidas = { 100, 80, 50 };

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i] + " - Vida: " + vidas[i]);

    if (vidas[i] >= 70)
    {
        Console.WriteLine(" - Saudável");
    }
    else
    {
        Console.WriteLine(" - Ferido");
    }
}
*/