using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositoryes;
using AutoMapper;

namespace Infrastructure.Database
{
    public class dbClient : IClientRepository
    {
        private readonly ICollection<ClientEntity> _clientsEntities;
        private readonly IMapper _mapper;
        private int fakeid;

        public dbClient(IMapper mapper)
        {
            _clientsEntities = new List<ClientEntity>();
            _mapper = mapper;
        }

        public void Create(ClientEntity clientEntity)
        {
            clientEntity.Id = ++fakeid;
            _clientsEntities.Add(clientEntity);
        }

        public void Update(ClientEntity clientEntity)
        {
            var findedClient = _clientsEntities.FirstOrDefault(x => x.Id == clientEntity.Id);

            if (findedClient == null) return;

            _mapper.Map(clientEntity, findedClient);
        }

        public void Delete(int id)
        {
            var findedClient = _clientsEntities.FirstOrDefault(x => x.Id == id);

            if (findedClient == null) return;

            _clientsEntities.Remove(findedClient);
        }

        public ClientEntity Get(int id)
        {
            var findedClient = _clientsEntities.FirstOrDefault(x => x.Id == id);

            if (findedClient == null) return null;

            return findedClient;
        }

        public ICollection<ClientEntity> GetAll()
        {
            return _clientsEntities;
        }
    }
}
