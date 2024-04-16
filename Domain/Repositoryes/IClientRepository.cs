using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositoryes
{
    public interface IClientRepository
    {
        void Create(ClientEntity clientEntity);
        void Update(ClientEntity clientEntity);
        void Delete(int id);
        ClientEntity Get(int id);
        ICollection<ClientEntity> GetAll();
    }
}
