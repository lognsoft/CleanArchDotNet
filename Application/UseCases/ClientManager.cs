using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTO;
using Domain.Repositoryes;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCases
{
    public class ClientManager
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientManager(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public void CreateClient(string name)
        {
            var clientDTO = new ClientDTO() { Name = name };

            var clientEntity = _mapper.Map<ClientEntity>(clientDTO);

            _clientRepository.Create(clientEntity);
        }

        public ClientDTO GetClient(int id)
        {
            var client = _clientRepository.Get(id);

            var clientDTO = _mapper.Map<ClientDTO>(client);

            return clientDTO;
        }
    }
}
