using AutoMapper;
using Business.Dtos.Fuel;
using Business.Requests.Fuel;
using Business.Responses.Fuel;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class FuelMapperProfiles:Profile
    {
        public FuelMapperProfiles() { 
        CreateMap<AddFuelRequests, Fuel>();
        CreateMap<Fuel, AddFuelResponse>();

        CreateMap<Fuel, FuelListItemDto>();
        CreateMap<IList<Fuel>, GetFuelListResponse>()
            .ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
        }
    }
}
