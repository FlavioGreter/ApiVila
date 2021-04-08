using System;

namespace ApiVila.Domain.Entities
{
    public class Endereco : BaseEntity
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public Guid PessoaId { get; set; }
    }
}