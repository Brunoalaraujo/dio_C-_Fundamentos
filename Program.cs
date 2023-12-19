using c_Fundamentos.Models; //Importação do namespace da classe

Pessoa pessoa1 = new Pessoa(); // Construtor da Classe Pessoa para virar um Objeto. "pessoa1" representa o nome da varivável. Nome de váriavel usar o camelCase

pessoa1.Nome = "Buta"; // Definição de Atributo
pessoa1.Idade = 26;

pessoa1.Idade += 1; //Incremento de variável

DateTime dataAtual = DateTime.Now; // DateTime Tipo para manipular datas. "DateTime.Now" Pega a data atual da máquina.

string apresentacao = $"Olá, seja bem {pessoa1.Nome} vindo!"; // declaração de variável. Começamos com o tipo, nome e atribuimos o valor;

pessoa1.Apresentar(); // Chamada de Método
Console.WriteLine(apresentacao);
Console.WriteLine(dataAtual);


// Cast - Casting - Processo de converter variáveis declaradas em outros tipos
int a = Convert.ToInt32("5"); //Aceita a conversão do valor null, prioridade no uso
int b = int.Parse("5"); //NÃO aceita a conversão do valor null
int inteiro = 5;

string c = inteiro.ToString(); // Para converter qualquer coisa em string não precisa usar o Parse ou Convert, todos os tipos tem de forma nativa essa conversão

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
