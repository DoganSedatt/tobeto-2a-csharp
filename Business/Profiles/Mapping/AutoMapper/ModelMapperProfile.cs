using AutoMapper;
using Business.Dtos.Car;
using Business.Requests.Model;
using Business.Responses.Car;
using Business.Responses.Model;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class ModelMapperProfile : Profile
    {
        public ModelMapperProfile(){

            CreateMap<AddModelRequests, Model>();
            CreateMap<Model, AddModelResponse>();

            CreateMap<Model, ModelListItemDto>();
            CreateMap<List<Model>, GetModelListResponse>().ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src));
        }
        
    }
}
