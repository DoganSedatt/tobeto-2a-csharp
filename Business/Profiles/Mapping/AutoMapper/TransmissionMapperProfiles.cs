using AutoMapper;
using Business.Dtos.Fuel;
using Business.Dtos.Transmission;
using Business.Requests.Fuel;
using Business.Requests.Transmission;
using Business.Responses.Fuel;
using Business.Responses.Transmission;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class TransmissionMapperProfiles:Profile
    {
        public TransmissionMapperProfiles()
        {
            CreateMap<AddTransmissionRequests, Transmission>();
            CreateMap<Transmission, AddTransmissionResponses>();

            CreateMap<Transmission, TransmissionListItemDto>();
            CreateMap<IList<Transmission>, GetTransmissionListResponse>()
                .ForMember(
                    destinationMember: dest => dest.Items,
                    memberOptions: opt => opt.MapFrom(mapExpression: src => src)
                );
        }
    }
}
