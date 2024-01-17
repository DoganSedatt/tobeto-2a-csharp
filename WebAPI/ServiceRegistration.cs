using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Requests.Brand;
using Business.Requests.Fuel;
using Business.Requests.Transmission;
using Business.Responses.Brand;
using Business.Responses.Fuel;
using Business.Responses.Transmission;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace WebAPI;

public static class ServiceRegistration
{
    public static readonly IBrandDal BrandDal = new InMemoryBrandDal();
    public static readonly IFuelDal FuelDal = new InMemoryFuelDal();
    public static readonly ITransmissionDal TransmissionDal = new InMemoryTransmissionDal();

    public static readonly BrandBusinessRules BrandBusinessRules = new BrandBusinessRules(BrandDal);
    public static readonly FuelBusinnesRules FuelBusinnesRules = new FuelBusinnesRules(FuelDal);
    public static readonly TransmissionBusinnesRules TransmissionBusinnesRules = new TransmissionBusinnesRules(TransmissionDal);

    public static IMapper Mapper = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<AddBrandRequest, Brand>();
        cfg.CreateMap<Brand, AddBrandResponse>();
        cfg.CreateMap<AddFuelRequests, Fuel>();
        cfg.CreateMap<Fuel, AddFuelResponse>();
        cfg.CreateMap<AddTransmissionRequests, Transmission>();
        cfg.CreateMap<Transmission, AddTransmissionResponses>();
    }).CreateMapper();

    public static readonly IBrandService BrandService = new BrandManager(
        BrandDal,
        BrandBusinessRules,
        Mapper
    );
    public static readonly IFuelService FuelService = new FuelManager(
        FuelDal,
        FuelBusinnesRules,
        Mapper
        );
    public static readonly ITransmissionService TransmissionService = new TransmissionManager(
        TransmissionDal,
        TransmissionBusinnesRules,
        Mapper
        );

} // IoC Container yapımızı kurduğumuz Dependency Injection ile daha verimli hale getiricez.
