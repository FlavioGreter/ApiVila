using System;
namespace ApiVila.Domain.Entities
{
    public class Agenda : BaseEntity
    {
        public Guid AlunoId { get; set; }   
        public Guid ProfessorId { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim {get; set;}
        public string HoraInicial { get; set; }
        public string HoraFinal { get; set; }
    }
}