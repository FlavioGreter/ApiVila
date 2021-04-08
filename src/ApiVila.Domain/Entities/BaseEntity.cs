using System;
namespace ApiVila.Domain.Entities
{
    
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } 
        public DateTime DataCadastro {get; set;}
        public DateTime? DataAlteracao { get; set; }        
    }
}