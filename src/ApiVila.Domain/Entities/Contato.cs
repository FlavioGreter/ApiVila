using System;

namespace ApiVila.Domain.Entities
{
    public class Contato : BaseEntity
    {
        public string Email { get; set; }
        public string Whatsapp { get; set; }
        public Guid PessoaId { get; set; }
    }
}