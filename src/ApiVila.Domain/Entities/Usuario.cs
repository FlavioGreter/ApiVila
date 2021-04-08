using System;
namespace ApiVila.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        
         public string Login { get; set; }
         public string Password { get; set; }
         
    }
}