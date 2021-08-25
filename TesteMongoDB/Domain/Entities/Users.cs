using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMongoDB.Domain.Entities
{
    public class Users
    {
        public object Id { get; set; }
        public string Nome { get; set;  }
        public string Dados { get; set; }
        public IEnumerable<Carros> Carros { get; set; }
    }
}
