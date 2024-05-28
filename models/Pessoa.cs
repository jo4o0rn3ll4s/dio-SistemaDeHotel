using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotel.models
{
    public class Pessoa
    {   
        // Propriedades
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        // Construtores e Overlays
        public Pessoa() {}

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}