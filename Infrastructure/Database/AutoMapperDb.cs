using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class AutoMapperDb : Profile
    {
        public AutoMapperDb()
        {
            CreateMap<ClientEntity, ClientEntity>().ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
