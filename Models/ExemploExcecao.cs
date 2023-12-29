using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_Fundamentos.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception) // Tratamento da exceção
            {
                Console.WriteLine("Exceção Tratada");
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção"); // Programa joga exceção para os passos anteriores até encontra um try/catch para realizar o tratamento.
        }
    }
}