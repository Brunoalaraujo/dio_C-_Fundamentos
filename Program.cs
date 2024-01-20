using System.Globalization;
using c_Fundamentos.Models; //Importação do namespace da classe

// ---------- CLASSES ----------

// Pessoa pessoa1 = new Pessoa(); // Construtor da Classe Pessoa para virar um Objeto. "pessoa1" representa o nome da varivável. Nome de váriavel usar o camelCase

// pessoa1.Nome = "Buta"; // Definição de Atributo
// pessoa1.Idade = 26;

// pessoa1.Idade += 1; //Incremento de variável


// // ---------- DateTime ----------

// DateTime dataAtual = DateTime.Now; // DateTime Tipo para manipular datas. "DateTime.Now" Pega a data atual da máquina.

// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToShortDateString()); // Tipos de formatação padrão
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); // Formatação da data. Cuidado com a sintax, letras em CAPS LOOK fazem diferença na interpretação.

// string dataString = "2022-13-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data); // Convertemos uma string com uma data expecifica para o formato DateTime. Validando a data. Melhor formato para ralizar a conversão

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }


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

// ******************** MENU INTERATIVO ************************

// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     // Console.Clear(); Limpa o console.
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de Cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             // Environment.Exit(0); //Encerrar o programa
//             break;
//         default:
//             Console.WriteLine("Opção Inválida");
//             break;
//     }

// }

// Console.WriteLine("O programa se encerrou");


// ---------- ARRAY E LISTAS ----------

// int[] arrayInteiros = new int[4]; //Declaração de array de Inteiros. [3] = possui 3 elementos, obrigatório informar a capacidade máxima do array. 
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// Console.WriteLine("Percorrendo o Array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++) //Percorrer array
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }


// Console.WriteLine("Percorrendo o Array com o FOREACH"); //Não consegue pegar elementos pela posição sem manipulação externa.
// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }


// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // Serve para redimencionar o array criando uma cópia do array original. 1º pede a referência na memória de onde o array foi salvo, 2º Pede o Length do array e 3º A o peração para modificar o tamanho do array.

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// List<string> listaStrings = new List<string>(); // Cira uma lista. lista não tem limitação de elementos. Uma lista é um array internamente.

// listaStrings.Add("SP"); // Adiciona um novo elemento a lista
// listaStrings.Add("PE");
// listaStrings.Add("MG");

// Console.WriteLine($"Percorrendo Lista com FOR:");
// for (int contador = 0; contador < listaStrings.Count; contador++) // FOR da lista usa COUNT.
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaStrings[contador]}");
// }

// Console.WriteLine($"Percorrendo Lista com FOREACH:");
// int contadorForeach = 0;
// foreach (string item in listaStrings) // Prioridade no uso
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//     contadorForeach++;
// }

// ---------- FORMATAÇÃO DE VALORES ----------

// using System.Globalization; //Usado para modificar a localização do sistema.

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // Usado para definir a nova "localização da máquina".

// decimal valorMonetario = 1582.40M; // Lmebrar de sempre colocar o M

// Console.WriteLine($"{valorMonetario:C}"); // :C = formartar a string em valores monetários. Busca as informações do sistema para definir o formato da moeda.

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // Usado para converter localmete a string, sem converter todo o programa

// Console.WriteLine(valorMonetario.ToString("C3", CultureInfo.CreateSpecificCulture("en-US"))); // Colocando numero após o C podemos definir a quantidade de casas decimais que serão exibidas. Podemos Usar N3.

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P")); // Usado para representar porcentagem

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##")); // Formato personalizado 


// ---------- Exceções e Coleções (Filas, Pilhas e Dictionary) ----------

// try // Método para tratar Exceções/Erros do programa.
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt"); // File = função para trabalhar abertura de arquivos

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }

// catch (DirectoryNotFoundException ex) // Modelo de Exceção previsivel/específica.
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}"); // Podemos ter vários catch para tratar diferentes tipos de exceções.
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}"); // Usamos a variável ex para acessar as informações da Exception.
// }
// finally // É executado independete se houve catch ou não
// {
//     Console.WriteLine("Chegou até aqui");
// }

// new ExemploExcecao().Metodo1();


// Queue<int> fila = new Queue<int>(); // Filas são coleções onde os elementos são manipulados na mesma sequência que ingressaram nela

// fila.Enqueue(2); // Adiciona elementos ao final da fila.
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // Remove e retorna elementos na sequência da fila.

// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


// Stack<int> pilha = new Stack<int>(); // Pilhas são o oposto da fila, o último elemento a entrar será o primeiro a sair.

// pilha.Push(4); // Adiciona um elemento ao topo da pilha
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}"); // Remove e retorna um elemento do topo da pilha

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Dictionary<string, string> estados = new Dictionary<string, string>(); // Dictionary é um conjunto de chave/valor. A chave deve ser única, igual ao conceito de id.

// estados.Add("PE", "Pernambuco"); // Adicionando conjunto chave/valor
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (KeyValuePair<string, string> item in estados) //KeyValuePair<string, string> forma de chamar o conjunto do Dictionary. Pode ser substituido para palavra "var"
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("............"); // Só para facilitar visualização

// estados.Remove("BA"); // Para manipulação usamos apenas a chave.
// estados["PE"] = "Pernambuco - valor alterado"; // Não podemos alterar a chave (só removendo e adicionando novamente), mas podemos alterar o valor dela.

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("............");

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave)) // ContainsKey procura uma chave.
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

// Console.WriteLine(estados["MG"]); // Método para acessar um valor do Dictionary


// ---------- Tuplas ----------

(int Id, string Nome, string Sobrenome) tuplas = (1, "Fulano", "Teste"); //Tuplas é o nome da variável, pode ser qualquer coisa. Fornece sintax concisa para agrupar vários elementos de dados em uma estrutura de dados leve.

Console.WriteLine($" Id: {tuplas.Id}");
Console.WriteLine($" Nome: {tuplas.Nome}");
Console.WriteLine($" Sobrenome: {tuplas.Sobrenome}");

ValueTuple<int, string, string> outroExemploTupla = (2, "Beltrano", "Alfa");
var outroExemploTuplaCreate = Tuple.Create(3, "Sem", "Nome"); //Dessas formas não conseguimos declarar o nome do elementos

Console.WriteLine($" Id: {outroExemploTupla.Item1}");
Console.WriteLine($" Nome: {outroExemploTupla.Item2}");
Console.WriteLine($" Sobrenome: {outroExemploTupla.Item3}");