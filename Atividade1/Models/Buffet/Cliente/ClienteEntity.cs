using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        TipoCliente Tipo;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public DateTime Insercao { get; set; }
        public DateTime Modificacao { get; set; }
        public string Observacoes { get; set; }


        public ClienteEntity()
        {
            Id = new int();
        }
    }
}
