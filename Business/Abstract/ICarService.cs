using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Responses.Car;

namespace Business.Abstract
{
    public interface ICarService
    {
        public AddCarResponse AddCar(AddCarRequest addCarRequest);
        public GetCarListResponse GetCar(GetCarListRequest getCarListRequest);
    }
}
