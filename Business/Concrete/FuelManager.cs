using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Fuel;
using Business.Responses.Fuel;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FuelManager:IFuelService
    {
        private readonly IFuelDal _fuelDal;
        private readonly FuelBusinnesRules _fuelBusinnesRules;
        private readonly IMapper _mapper;

        public FuelManager(IFuelDal fuelDal)
        {
        }

        public FuelManager(IFuelDal fuelDal,FuelBusinnesRules fuelBusinnesRules,IMapper mapper)
        {
            _fuelDal = fuelDal;
            _fuelBusinnesRules = fuelBusinnesRules;
            _mapper = mapper;
        }

        public AddFuelResponse Add(AddFuelRequests addFuelRequests)
        {
            _fuelBusinnesRules.CheckIfFuelNameNotExists(addFuelRequests.Name);
            Fuel fuelToAdd = _mapper.Map<Fuel>(addFuelRequests);
            _fuelDal.Add(fuelToAdd);
            AddFuelResponse response = _mapper.Map<AddFuelResponse>(fuelToAdd);
            return response;
        }
        public IList<Fuel> GetList()
        {
            // İş Kuralları
            // Validation
            // Yetki kontrolü
            // Cache
            // Transaction

            IList<Fuel> fuelList = _fuelDal.GetList();
            return fuelList;
        }
    }
}
