using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class BookEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }
        public ClientEntity Client { get; set; }

        public BookEntity(string name, bool available)
        {
            Name = name;
            Available = available;
        }
    }
}
