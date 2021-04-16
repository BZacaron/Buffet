using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Convidado
{
    public class ConvidadoEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInsercao { get; set; }
        public string Observacoes { get; set; }

        Evento.EventoEntity Evento;
        SituacaoConvidado Situacao;
    }
}
