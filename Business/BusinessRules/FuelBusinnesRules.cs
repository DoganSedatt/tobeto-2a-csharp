using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class FuelBusinnesRules
    {
        private readonly IFuelDal _fuelDal;
        public FuelBusinnesRules(IFuelDal fuelDal)
        {
            _fuelDal = fuelDal;
        }
        public void CheckIfFuelNameNotExists(string fuelName)
        {
            bool isExists = _fuelDal.GetList().Any(p => p.Name == fuelName);
            if (isExists)
            {
                throw new Exception("Fuel already exists");
            }
        }
        
    }
}
