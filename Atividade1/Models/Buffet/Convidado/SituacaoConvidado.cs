using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Convidado
{
    public class SituacaoConvidado
    {
        public int Id { get; set; }
        public string Descricao { get; set; } //Confirmado, Cancelado ou Pendente
    }
}
