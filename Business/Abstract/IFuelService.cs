using Business.Requests.Brand;
using Business.Requests.Fuel;
using Business.Responses.Brand;
using Business.Responses.Fuel;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFuelService
    {
        public AddFuelResponse Add(AddFuelRequests request);
        public IList<Fuel> GetList();
    }
}
