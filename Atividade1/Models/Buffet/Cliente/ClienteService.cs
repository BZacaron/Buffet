using Buffet.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteService
    {
        private readonly DatabaseContext _databaseContext;

        public ClienteService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
    }
}
