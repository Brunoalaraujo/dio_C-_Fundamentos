using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_Fundamentos.Models
{
    public class Pessoa // Nome de Classe usar o PascalCase, manter igual ao nome do Arquivo.cs
    {
        public string Nome { get; set; } // Atributos da Classe.
        public int Idade { get; set; }

        public string NomeRepresentanteLegalDaPessoaFisica { get; set; } //Nunca abreivar nome de Atributo Classe, mesmo que fique grande.

        public void Apresentar() // Método da classe
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos"); // Usar $ antes das "" para liberar a interpolação dos Atributos no Método. \n = quebra de linha
        }
    }
}