using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_explorando_desafio.models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public Pessoa(){

        }

        public Pessoa(string nome){
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

    }
}