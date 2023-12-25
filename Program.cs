using c_Fundamentos.Models; //Importação do namespace da classe

// ---------- CLASSES ----------

// Pessoa pessoa1 = new Pessoa(); // Construtor da Classe Pessoa para virar um Objeto. "pessoa1" representa o nome da varivável. Nome de váriavel usar o camelCase

// pessoa1.Nome = "Buta"; // Definição de Atributo
// pessoa1.Idade = 26;

// pessoa1.Idade += 1; //Incremento de variável


// // ---------- DateTime ----------

// DateTime dataAtual = DateTime.Now; // DateTime Tipo para manipular datas. "DateTime.Now" Pega a data atual da máquina.


// // ---------- CHAMANDO CLASSE ----------

// string apresentacao = $"Olá, seja bem {pessoa1.Nome} vindo!"; // declaração de variável. Começamos com o tipo, nome e atribuimos o valor;

// pessoa1.Apresentar(); // Chamada de Método
// Console.WriteLine(apresentacao);
// Console.WriteLine(dataAtual);


// // ---------- CAST - CASTING ----------

// // Cast - Casting - Processo de converter variáveis declaradas em outros tipos
// int a = Convert.ToInt32("5"); //Aceita a conversão do valor null, prioridade no uso
// int b = int.Parse("5"); //NÃO aceita a conversão do valor null
// int inteiro = 5;

// string c = inteiro.ToString(); // Para converter qualquer coisa em string não precisa usar o Parse ou Convert, todos os tipos tem de forma nativa essa conversão

// string d = "15-";

// // int e = 0; Exemplo sem a declaração no out do TryParse

// int.TryParse(d, out int e); // TryParse é usado para tentar realizar a converção de tipos sem para o programa, maniera segura de realizar uma conversão. A variável pode ser delcarada no out. 

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine(e);


// // ---------- OPERADORES CONDICIONAIS ----------

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Inválida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada.");
// }
// else
// {
//     Console.WriteLine($"Desculpe, no momentos só temos {quantidadeEmEstoque} unidades.");
// }

// Console.WriteLine("Digite uma letra");
// string? letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }


// ---------- OPERADORES ARITMÉTICOS E A CLASSE MATH ----------

// Calculadora calc = new Calculadora();

// calc.Somar(6, 5);
// calc.Subitrair(10, 5);
// calc.Multiplicar(5, 9);
// calc.Dividir(10, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);


// ---------- ESTRUTURAS DE REPETIÇÃO ----------
// int numero = 5;

// for (int contador = 0; contador <= 10; contador++) //(Declaração da variável; Condição; Incremento da variável)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


// int numero2 = 8;
// int contador2 = 0;

// while (contador2 <= 10) //Enquanto a variável for verdadeira vai continuar o loop. cuidado com o loop infinito
// {
//     Console.WriteLine($"{contador2}º Execução: {numero2} x {contador2} = {numero2 * contador2}");
//     contador2++; // Método para controle de variável.
// }


// int soma = 0, numero3 = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para sair do programa):");
//     numero3 = Convert.ToInt32(Console.ReadLine());

//     soma += numero3;
//     Console.WriteLine($"a soma até o momento é de: {soma}");

// } while (numero3 != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// MENU INTERATIVO

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    // Console.Clear(); Limpa o console.
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        case "2":
            Console.WriteLine("Busca de Cliente");
            break;
        case "3":
            Console.WriteLine("Apagar Cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            // Environment.Exit(0); //Encerrar o programa
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

}

Console.WriteLine("O programa se encerrou");