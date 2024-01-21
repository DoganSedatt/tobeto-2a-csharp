using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Responses.Car;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        private readonly CarBusinnesRules _carBusinnesRules;
        private readonly IMapper _mapper;

        public CarManager(ICarDal carDal,CarBusinnesRules carBusinnesRules,IMapper mapper)
        {
            _carDal = carDal;
            _carBusinnesRules = carBusinnesRules;
            _mapper = mapper;
        }


        public AddCarResponse AddCar(AddCarRequest addCarRequest)
        {
            _carBusinnesRules.CheckCarAdded(addCarRequest.Name, addCarRequest.ModelYear);
            //Bundan sonra şunu yapacağız.Eklenecek CarRequest'i(İstek) Car nesnesine,
            //Car nesnesini de CarResponse(Cevap) çevireceğim
            Car carToAdd = _mapper.Map<Car>(addCarRequest);//AddCarREquest Car'a dönüşücek.İlgili alanlar eşleşecek
            _carDal.Add(carToAdd);//Aracı ekleme işlemi yapıldı

            AddCarResponse response = _mapper.Map<AddCarResponse>(carToAdd);
            return response;
        }

        public GetCarListResponse GetCar(GetCarListRequest getCarListRequest)
        {
            IList<Car> carList = _carDal.GetList();

            GetCarListResponse response = _mapper.Map<GetCarListResponse>(carList); // Mapping
            return response;
        }
    }
}
