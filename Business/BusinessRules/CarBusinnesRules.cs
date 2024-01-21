using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CarBusinnesRules
    {
        private readonly ICarDal _carDal;
        public CarBusinnesRules(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void CheckCarAdded(string carName,int modelYear)
        {
            bool isExists = _carDal.GetList().Any(c => c.Name == carName || modelYear >= 20);
               
            if (isExists)
            {
                throw new Exception("Araç daha önce eklenmiş veya model yılı 20'den büyük");
            }
            

        }
    }
}
