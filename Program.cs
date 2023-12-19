using c_Fundamentos.Models; //Importação do namespace da classe

Pessoa pessoa1 = new Pessoa(); // Construtor da Classe Pessoa para virar um Objeto. "pessoa1" representa o nome da várivavel. Nome de váriavel usar o camelCase

pessoa1.Nome = "Buta"; // Definição de Atributo
pessoa1.Idade = 26;

DateTime dataAtual = DateTime.Now; // DateTime Tipo para manipular datas. "DateTime.Now" Pega a data atual da máquina.

string apresentacao = $"Olá, seja bem {pessoa1.Nome} vindo!"; // declaração de váriavel. Começamos com o tipo, nome e atribuimos o valor;

pessoa1.Apresentar(); // Chamada de Método
Console.WriteLine(apresentacao);
Console.WriteLine(dataAtual);
