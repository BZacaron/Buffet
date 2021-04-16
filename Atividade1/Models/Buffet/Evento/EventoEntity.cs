using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Evento
{
    public class EventoEntity
    {
        TipoEvento Tipo;
        public string Descricao { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public string Local { get; set; }
        public string Endereco { get; set; }
        public DateTime Insercao { get; set; }
        public DateTime Modificacao { get; set; }
        public string Observacoes { get; set; }

        Cliente.ClienteEntity Cliente;
        SituacaoEvento Situacao;
    }
}
