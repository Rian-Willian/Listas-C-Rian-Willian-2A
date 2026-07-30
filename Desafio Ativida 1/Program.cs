
// Desafio 1 (Criar um jogo no console)
// RPG

Console.WriteLine(" Prazer em conhece-lo! Sou o Baiano e vou te acompanhar durante sua jornada.");
Console.WriteLine("\n Qual é o seu nome?");
Console.WriteLine("");
string nome = Console.ReadLine();
Console.WriteLine("\n Muito prazer em conhece-lo(a)" + nome);

int vida = 100;
int energia = 50;
int moedas = 0;
int lvl = 1;

Console.WriteLine("\n Hoje é o seu primeiro dia nesse novo mundo." +
    "\n\n Seus status iniciais são: Vida " + vida + " e Energia " + energia);
Console.WriteLine("\n E você começa sem moedas, ou seja seu saldo agora é de: Saldo " + moedas);
Console.WriteLine("\n Você está caminhado pela floresta, e se depara com um lobo." +
    "\n\n Ele aparenta ser mais forte, o que você quer fazer ?" +
    "\n\n ATACAR" +
    "\n\n RECUAR");
Console.WriteLine("");

string acao1 = Console.ReadLine();

if (acao1 == " ATACAR")
{
    Console.WriteLine("\n O lobo ficou com pena de você e deixou você viver, se retirando do local. Porém te causando muito dano.");
    int dano = 50;
    int vida1 = vida - dano;
    int perdaEnergia = 20;
    int energia1 = energia - perdaEnergia;
    Console.WriteLine("\n Status: Vida " + vida1 + " e Energia " + perdaEnergia);
    Console.WriteLine("\n Você ganhou pontos de experiência por ter sobrevivido a um inimigo forte.");
    int lvl2 = lvl + 1;
    Console.WriteLine("\n Você Subiu de nível!!! Agora voce é nível: " + lvl2);

}
else if (acao1 == " RECUAR")
{
    Console.WriteLine("\n Parabéns, você foi inteligente.");
    Console.WriteLine("\n Você não sofreu nenhum ferimento.");
    Console.WriteLine("\n Status Atuais: Vida " + vida + " e Energia" + energia);
}

Console.WriteLine("\n Essa foi a primeira escolha que você teve, daqui pra frente mais escolhas difíceis virão!");
Console.WriteLine("\n Você chegou na cidade inicial. Um estranho te aborda e pergunta qual classe você vai escolher, ele te da 3 opções:" +
    "\n\n Guerreiro" +
    "\n\n Mago" +
    "\n\n Arqueiro");
Console.WriteLine("");
string classe  = Console.ReadLine();

int vidaGuerreiro = 200;
int energiaGuerreiro = 100;
int vidaMago = 120;
int energiaMago = 250;
int vidaArqueiro = 150;
int energiaArqueiro = 200;

if (classe == " Guerreiro")
{
    Console.WriteLine("\n Boa escolha! Um lutador com maior quantidade de vida e maior defesa.");
    Console.WriteLine("\n Seus status tomaram um buff: Vida " + vidaGuerreiro + " e Energia " + energiaGuerreiro);
}else if (classe == " Mago")
{
    Console.WriteLine("\n Boa escolha! Um Lutador com menos vida, porém com a maior energia para usar seus feitiços.");
    Console.WriteLine("\n Seus status tomaram um buff: Vida " + vidaMago + " e Energia " + energiaMago);
}else if (classe == " Arqueiro")
{
    Console.WriteLine("\n Boa escolha! Um lutador que é o equilíbrio entre as classes");
    Console.WriteLine("\n Seus status tomaram um buff: Vida " + vidaArqueiro + " e Energia " + energiaArqueiro);
}

Console.WriteLine("\n Parabéns pela escolha, agora você é um(a) " + classe);
Console.WriteLine("\n Já que você escolheu sua classe, nada melhor do que escolher uma arma não é mesmo?");
int moedas1 = moedas + 100;
Console.WriteLine("\n O estranho de antes te deu algumas moedas para você comprar uma arma, seu saldo agora é: Saldo " + moedas1);
Console.WriteLine("\n Vamos para a loja de armas!");
Console.WriteLine("\n Chegamos, pergunte ao ferreiro qual armas que servem para sua classe.");
Console.WriteLine("\n O ferreiro perguntou qual era sua classe." +
    "\n\n Guerreiro" +
    "\n\n Mago" +
    "\n\n Arqueiro");
Console.WriteLine("");
string classeFerreiro = Console.ReadLine();

string armaGuerreiro1 = "Espada Leve";
string armaGuerreiro2 = "Espada Pesada";
string armaGuerreiro3 = "Espada Média";
string armaMago1 = "Cajado de madeira";
string armaArqueiro1 = "Arco de madeira";

if (classeFerreiro == " Guerreiro")
{
    Console.WriteLine("\n Ele mostrou 3 armas: " + armaGuerreiro1 + ", " + armaGuerreiro2 + ", " + armaGuerreiro3);
    Console.WriteLine("");
    string armaGuerreiro = Console.ReadLine();
    if (armaGuerreiro == " " + armaGuerreiro2)
    {
        Console.WriteLine("\n Boa escolha, uma arma com grande dano, porém com velocidade baixa.");
    }
    else if (armaGuerreiro == " " + armaGuerreiro3)
    {
        Console.WriteLine("\n Boa escolha, uma arma com dano e velocidade equilibrados");
    }
    else if (armaGuerreiro == " " + armaGuerreiro1)
    {
        Console.WriteLine("\n Boa escolha, uma arma com baixo dano, mas com velocidades incriveis nos golpes");
    }
}
else if (classeFerreiro == " Mago")
{
    Console.WriteLine("\n Ele te mostrou a única arma que tinha na loja no momento: " + armaMago1);
    string armaMago = Console.ReadLine();
    Console.WriteLine("\n Boa escolha, uma arma com um poder mágico básico");
}
else if (classeFerreiro == " Arqueiro")
{
    Console.WriteLine("\n Ele te mostrou a única arma que tinha na loja no momento: " + armaArqueiro1);
    string armaArqueiro = Console.ReadLine();
    Console.WriteLine("\n Boa escolha, uma arma com alcance alto e com um dano moderado");
}

Console.WriteLine("\n Incrível! Agora você pode continuar daqui pra frente, boa sorte meu amigo!");