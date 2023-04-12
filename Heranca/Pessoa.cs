using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Pessoa
    {
        protected string nome;
        protected int idade;

        protected void messagePessoa()
        {
            Console.WriteLine(nome);
            Console.WriteLine(idade);
        }
    }
}
