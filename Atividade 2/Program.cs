// ATIVIDADE 2
/*
//1
string dificuldade = "";
Console.WriteLine("Escolha uma Dificuldade" +
    "\n\n 1 - Fácil" +
    "\n\n 2 - Normal" +
    "\n\n 3 - Difícil");
dificuldade = Console.ReadLine();

switch (dificuldade)
{
    case "Fácil":
        Console.WriteLine("Fácil: 5 vidas, dano inimigo 10, 3 checkpoints");
        break;
    case "Normal":
        Console.WriteLine("Normal: 3 vidas, dano inimigo 20, 2 checkpoints");
        break;
    case "Difícil":
        Console.WriteLine("Difícil: 1 vida, dano inimigo 35, 0 checkpoints");
        break;
    default: Console.WriteLine("Dificuldade inválida");
        break;
}


//2
string jogando = "";
string tutorial = "";

Console.WriteLine("É a sua primeira vez jogando?" +
    "\n\nSim" +
    "\n\nNão");
Console.WriteLine("");
jogando = Console.ReadLine();

Console.WriteLine("");

Console.WriteLine("Quer fazer o tutorial?" +
    "\n\nSim" +
    "\n\nNão");
Console.WriteLine("");
tutorial = Console.ReadLine();

if  (jogando == "Sim" && tutorial == "Sim")
{
    Console.WriteLine("");
    Console.WriteLine("Inicando tutorial...");
}
else
{
    Console.WriteLine("");
    Console.WriteLine("Tutorial pulado. Boa sorte!");
}


//3
string stealth = "";
int barulho = 0;
string olhar = "";

Console.WriteLine("Você está escondido?" +
    "\n\nSim" +
    "\n\nNão");
Console.WriteLine("");
stealth = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Qual é o seu nível de barulho?");
Console.WriteLine("");
barulho = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("O inimigo está te vendo?" +
    "\n\nSim" +
    "\n\nNão");
olhar = Console.ReadLine();
if (stealth == "Não" && olhar == "Sim" ||  barulho > 70)
{
    Console.WriteLine("Você foi detectado!");
}
else
{
    Console.WriteLine("Você passou despercebido");
}


//4
int madeira = 0;
int pedra = 0;
string receita = "";

Console.WriteLine("Quanto de madeira você tem?");
Console.WriteLine("");
madeira = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Quanto de pedra você tem?");
Console.WriteLine("");
pedra = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Você tem a receita?" +
    "\n\nSim" +
    "\n\nNão");
receita = Console.ReadLine();
if(madeira >= 3 &&  pedra >= 2 &&  receita == "Sim")
{
    Console.WriteLine("Lança criada com sucesso!");
}
else
{
    Console.WriteLine("Você não possui os recursos necessários.");
}


//5
string clima = "";
Console.WriteLine("Qual o clima dessa fase?" +
    "\n\n1 - Sol" +
    "\n\n2 - Chuva" +
    "\n\n3 - Neve" +
    "\n\n4 - Tempestade");
clima = Console.ReadLine();
switch (clima)
{
    case "Sol":
        Console.WriteLine("Sol: velocidade normal");
        break;
    case "Chuva":
        Console.WriteLine("Chuva: jogador escorrega");
        break;
    case "Neve":
        Console.WriteLine("Neve: velocidade reduzida");
        break;
    case "Tempestade":
        Console.WriteLine("Tempestade: visão reduzida e risco maior");
        break;
    default: Console.WriteLine("Clima inválido");
        break;
}


//6
int reputacao = 0;
string presenteNpc = "";

Console.WriteLine("Qual é o seu nível de reputação?");
reputacao = int.Parse(Console.ReadLine());
Console.WriteLine("Você entregou um presente ao npc?" +
    "\n\nSim" +
    "\n\nNão");
if (reputacao >= 50 || presenteNpc == "Sim")
{
    Console.WriteLine("O NPC revelou uma informação secreta");
}
else
{
    Console.WriteLine("O NPC não confia em você ainda");
}


//7
string simbolo = "";

Console.WriteLine("Escolha um símbolo:" +
    "\n\n1 - Lua" +
    "\n\n2 - Sol" +
    "\n\n3 - Estrela" +
    "\n\n4 - Chama");
simbolo = Console.ReadLine();

switch (simbolo)
{
    case "Lua":
        Console.WriteLine("Lua: uma ponte aparece");
        break;
    case "Sol":
        Console.WriteLine("Sol: a sala fica iluminada");
        break;
    case "Estrela":
        Console.WriteLine("Estrela: um item secreto surge");
        break;
    case "Chama":
        Console.WriteLine("Chama: uma armadilha é ativada");
        break;
    default : Console.WriteLine("Nada aconteceu");
        break;
}


//8
int bateria = 0;
string monstro = "";
string botao = "";

Console.WriteLine("Qual é a bateria da sua câmera?");
bateria = int.Parse(Console.ReadLine());
Console.WriteLine("Existe monstro na tela?" +
    "\n\nSim" +
    "\n\nNão");
monstro = Console.ReadLine();
Console.WriteLine("Você apertou o botão de gravar?" +
    "\n\nSim" +
    "\n\nNão");
botao = Console.ReadLine();
if (bateria > 0 && botao == "Sim" &&  monstro == "Sim")
{
    Console.WriteLine("Cena assustadora gravada!");
}  
else if (bateria < 0)
{
    Console.WriteLine("A câmera está sem bateria");
}
else if(monstro == "Não")
{
    Console.WriteLine("Você gravou mas nada interessante apareceu");
}


//9
int energia  = 0;
string acao = "";

Console.WriteLine("Qual a sua quantidade de energia?");
Console.WriteLine("");
energia = int.Parse(Console.ReadLine());
Console.WriteLine("\nQual ação você deseja realizar:" +
    "\n\n1 - Ataque Leve" +
    "\n\n2 - Ataque Pesado" +
    "\n\n3 - Especial" +
    "\n\n4 - Esquivar");
Console.WriteLine("");
acao = Console.ReadLine();

int energiaPesado = energia - 15;
int energiaEspecial = energia - 30;
int energiaEsquivar = energia - 10;

switch (acao)
{
    case "Ataque Leve":
        Console.WriteLine("Ataque Leve não gasta energia.");
        if (acao == "Ataque Leve")
        {
            Console.WriteLine("O ataque foi um sucesso");
            Console.WriteLine("Energia restante: " + energia);
        }
        else
        {
            Console.WriteLine("O ataque foi invalido");
        }
        break;

    case "Ataque Pesado":
        Console.WriteLine("Ataque Pesado só funciona se a energia for maior ou igual a 15");
        if(acao == "Ataque Pesado" && energia >= 15)
        {
            Console.WriteLine("O ataque foi um sucesso");
            Console.WriteLine("Energia restante: " + energiaPesado);
        }
        else if (energia < 15)
        {
            Console.WriteLine("O ataque foi invalido, faltou energia");
        }
        break;

    case "Especial":
        Console.WriteLine("Especial só funciona se a energia for maior ou igual a 30");
        if(acao == "Especial" && energia >= 30)
        {
            Console.WriteLine("O ataque foi um sucesso");
            Console.WriteLine("Energia restante: " + energiaEspecial);
        }
        else if(energia < 30)
        {
            Console.WriteLine("O ataque foi invalido, faltou energia");
        }
        break;

    case "Esquivar":
        Console.WriteLine("Esquivar só funciona se a energia for maior ou igual a 10");
        if (acao == "Esquivar" && energia >= 10)
        {
            Console.WriteLine("A esquiva foi um sucesso");
            Console.WriteLine("Energia restante: " + energiaEsquivar);
        }
        else if (energia < 10)
        {
            Console.WriteLine("A esquiva foi invalida, faltou energia");
        }
        break;

}

*/
//10
string area = "";
Console.WriteLine("Qual área você está?" +
    "\n\n1 - Floresta" +
    "\n\n2 - Ruínas" +
    "\n\n3 - Laboratório" +
    "\n\n4 - Praia");
area = Console.ReadLine();
switch (area)
{
    case "Floresta":
        Console.WriteLine("Animal selvagem apareceu !");
        break;
    case "Ruínas":
        Console.WriteLine("Armadilha antiga foi ativada !");
        break;
    case "Laboratório":
        Console.WriteLine("Robô descontrolado apareceu !");
        break;
    case "Praia":
        Console.WriteLine("Tempestade repentina apareceu !");
        break;
}

int lvl = 0;
string item = "";
string aliado = "";

Console.WriteLine("Qual nível você está?");
lvl = int.Parse(Console.ReadLine());
Console.WriteLine("Você tem item especial?" +
    "\n\nSim" +
    "\n\nNão");
item = Console.ReadLine();
Console.WriteLine("Você tem aliado?" +
    "\n\nSim" +
    "\n\nNão");
aliado = Console.ReadLine();

if (lvl >= 5 && item == "Sim" || aliado == "Sim")
{
    Console.WriteLine("Você resolveu o evento com sucesso !");
}
else
{
    Console.WriteLine("Você não estava preparado para esse evento.");
}
