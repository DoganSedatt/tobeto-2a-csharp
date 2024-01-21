using AutoMapper;
using Business.Dtos.Car;
using Business.Responses.Brand;
using Business.Responses.Car;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class CarMapperProfile:Profile
    {
        public CarMapperProfile()
        {
            CreateMap<AddCarRequest, Car>();
            CreateMap<Car, AddCarResponse>();

            CreateMap<Car, CarListItemDto>();
            CreateMap<List<Car>, GetCarListResponse>().ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src));
                
        }
    }
}
