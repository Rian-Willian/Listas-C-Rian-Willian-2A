
//1
/*
int passos = 0;

while (passos <= 10)
{
    Console.WriteLine("O personagem deu mais um passo.");
    Console.WriteLine("Passos atuais: " + passos);
    passos = passos + 1;
    Console.WriteLine("Você chegou ao destino");
}
*/



//2
/*
Random sorteio = new Random();
int dado = sorteio.Next(1, 7);

while (dado != 6)
{
    Console.WriteLine("Saiu " + dado + " Rolando novamente...");
    dado = sorteio.Next(1, 7); 
}
Console.WriteLine("Você tirou 6! Fim da rolagem.");
*/



//3
/*
Random portaFechadura = new Random();
int tentativas = portaFechadura.Next(1, 6);

while (tentativas != 5)
{
    Console.WriteLine("Número de tentativas: " + tentativas + " A porta continua fechada.");
    tentativas = portaFechadura.Next(1, 6);
}
Console.WriteLine("A porta se abriu!");
*/



//4
/*
Random busca = new Random();
int tentativas = busca.Next(1, 11);
int tentTotal = 0;

while (tentativas != 10)
{
    Console.WriteLine("Tentativas: " + tentativas);
    tentativas = busca.Next(1, 11);
    tentTotal = tentTotal + 1;
}
Console.WriteLine("Você encontrou o item raro!");
Console.WriteLine("Tentativas Totais: " + tentTotal);
*/



//5
/*
Random sorteio = new Random();
int numeroSecreto = sorteio.Next(1, 21);
int palpite = 0;

while ( palpite != numeroSecreto )
{
    Console.WriteLine("Escolha um número entre 1 e 20");
    palpite = int.Parse(Console.ReadLine());
    
    if ( palpite < numeroSecreto )
    {
        Console.WriteLine("O número secreto é maior.");
    }
    else if ( palpite > numeroSecreto)
    {
        Console.WriteLine("O número secreto é menor.");
    }
    
}
Console.WriteLine("Você Acertou!!");
*/


//6
/*
Random sorteio = new Random();
int cristais = sorteio.Next(1, 4);
int busca = 0;

while (busca < 5)
{
    cristais = sorteio.Next(1, 4);

    if (cristais == 1)
    {
        Console.WriteLine("Aumentou 1 cristal.");
        busca = busca + 1;
        Console.WriteLine("Total de cristais: " + busca);
    }
    else if (cristais == 2)
    {
        Console.WriteLine("Nada acontece.");
        Console.WriteLine("Total de cristais: " + busca);
    }
    else if (cristais == 3)
    {
        if(busca > 0)
        {
            Console.WriteLine("Você perdeu um cristal.");
            busca = busca - 1;
            Console.WriteLine("Total de cristais: " + busca);
        }
        else
        {
            Console.WriteLine("Você não tem cristais para perder.");
            Console.WriteLine("Total de cristais: " + busca);
        }
    }
}
Console.WriteLine("Você encontrou todos os cristais.");
Console.WriteLine("Total de cristais: " + busca);
*/



//7
/*
int energia = 100;
Random sorteio = new Random();
int gasto = sorteio.Next(5, 21);

while (energia != 0)
{
    gasto = sorteio.Next(5, 21);
    energia = energia - gasto;

    if (energia < 0)
    {
        energia = 0;
    }

    Console.WriteLine("Você perdeu " + gasto + " energia." +
        "\n Sua energia total é de " + energia);
}
Console.WriteLine("A lanterna apagou.");
*/



//8

int opcao = 0;
Random evento = new Random();
int explorar = evento.Next(1, 5);

while (opcao != 2)
{
    Console.WriteLine("1 - Explorar");
    Console.WriteLine("2 - Sair");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        explorar = evento.Next(1, 5);
        if (explorar == 1)
        {
            Console.WriteLine("1 - Você encontrou moedas.");
        }
        else if (explorar == 2)
        {
            Console.WriteLine("2 - Você encontrou uma pista");
        }
        else if (explorar == 3)
        {
            Console.WriteLine("3 - Você encontrou um obstáculo.");
        }
        else if (explorar == 4)
        {
            Console.WriteLine("4 - Nada aconteceu.");
        }
    }
}
Console.WriteLine("Você saiu.");




//9
/*
int pontosTotais  = 0;
Random sorteio = new Random();
int pontuacao = sorteio.Next(5, 16);

while (pontosTotais < 50)
{
    pontuacao = sorteio.Next(5, 16);
    pontosTotais = pontosTotais + pontuacao;
    
    Console.WriteLine("Quando você fizer 50 pontos ou mais, irá ganhar");
    Console.WriteLine("Pontos Atuais: " + pontosTotais + 
        "\n Você ganhou: " + pontuacao);
}
Console.WriteLine("Objetivo Concluído!");
*/



//10
/*
int vida = 100;
int rodadas = 0;
Random sorteio = new Random();
int evento = sorteio.Next(1, 5);


while (vida > 0 && rodadas < 10)
{
    evento = sorteio.Next(1, 5);
    rodadas = rodadas + 1;
    if (evento == 1)
    {
        Console.WriteLine("Encontrou suprimentos: ganha 10 de vida");
        vida = vida + 10;
        Console.WriteLine("Vida Atual: " + vida);
    }
    else if (evento == 2)
    {
        Console.WriteLine("Caiu em armadilha: perde 20 de vida");
        vida = vida - 20;
        Console.WriteLine("Vida Atual: " + vida);
    }
    else if (evento == 3)
    {
        Console.WriteLine("Descansou: ganha 5 de vida");
        vida = vida + 5;
        Console.WriteLine("Vida Atual: " + vida);
    }
    else if (evento == 4)
    {
        int dano = sorteio.Next(5, 26);
        Console.WriteLine("Enfrentou perigo: perde um valor aleatório entre 5 e 25");
        vida = vida - dano;
        Console.WriteLine("Vida Atual: " + vida);
    }
    

    if (vida < 0)
    {
        vida = 0;
    }

    Console.WriteLine("Rodadas: " + rodadas);
    Console.WriteLine("Evento: " + evento);
    Console.WriteLine("");
    
}

if (vida > 0)
{
    Console.WriteLine("Você sobreviveu aos eventos!");
}
else
{
    Console.WriteLine("Você não conseguiu sobreviver.");
}
*/