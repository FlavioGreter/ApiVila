using System;
using System.ComponentModel.DataAnnotations;

namespace ApiVila.Domain.Entities
{
    
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } 
        public DateTime DataCadastro {get; set;}
        public DateTime? DataAlteracao { get; set; }  
              
    }
}