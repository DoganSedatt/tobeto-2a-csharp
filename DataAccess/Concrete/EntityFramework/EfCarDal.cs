using Core.DataAccess.Ef;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:InEfEntityRepositoryBase<Car,int>,ICarDal
    {

    }
}
