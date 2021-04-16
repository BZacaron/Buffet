using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Evento
{
    public class SituacaoEvento
    {
        public int Id { get; set; }
        public string Descricao { get; set; } //Agendado, Cancelado ou Executando
    }
}
