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

Calculadora calc = new Calculadora();

calc.Somar(6, 5);
calc.Subitrair(10, 5);
calc.Multiplicar(5, 9);
calc.Dividir(10, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);