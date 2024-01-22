using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Core.DataAccess.Ef;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business.DependencyResolvers;

public static class ServiceCollectionBusinessExtension
{
    // Extension method
    // Metodun ve barındığı class'ın static olması gerekiyor
    // İlk parametere genişleteceğimiz tip olmalı ve başında this keyword'ü olmalı.
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services
            .AddSingleton<IBrandService, BrandManager>()
            .AddSingleton<IFuelService, FuelManager>()
            .AddSingleton<ITransmissionService, TransmissionManager>()
            .AddSingleton<ICarService, CarManager>()
            .AddSingleton<IModelService,ModelManager>()
            //MANAGERS

            .AddSingleton<IBrandDal, InMemoryBrandDal>()
            .AddSingleton<IFuelDal, InMemoryFuelDal>()
            .AddSingleton<ITransmissionDal, InMemoryTransmissionDal>()
            .AddSingleton<ICarDal, EfCarDal>()
            .AddSingleton<IModelDal,EfModelDal>()
            //INMEMORYS

            .AddSingleton<BrandBusinessRules>()
            .AddSingleton<FuelBusinnesRules>()
            .AddSingleton<TransmissionBusinnesRules>()
            .AddSingleton<CarBusinnesRules>()
            .AddSingleton<ModelBusinnesRules>()
            ;
        // Fluent
        // Singleton: Tek bir nesne oluşturur ve herkese onu verir.
        // Ek ödev diğer yöntemleri araştırınız.

        services.AddAutoMapper(Assembly.GetExecutingAssembly()); // AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi
        // Reflection yöntemiyle Profile class'ını kalıtım alan tüm class'ları bulur ve AutoMapper'a ekler.

        return services;
    }
}
