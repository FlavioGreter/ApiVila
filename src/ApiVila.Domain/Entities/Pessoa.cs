using System;
using System.Collections.Generic;

namespace ApiVila.Domain.Entities
{
    public class Pessoa : BaseEntity
    {
        public string Nome { get; set; } 
        public string Cpf { get; set; } 
        public IEnumerable<Contato> Contatos {get; set;}  
        public Endereco Endereco { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
        public virtual Endereco VEndereco {get; set;}
        public virtual IEnumerable<Contato> VContatos {get; set;} 
    }
}