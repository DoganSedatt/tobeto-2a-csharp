using Business.Requests.Brand;
using Business.Requests.Transmission;
using Business.Responses.Brand;
using Business.Responses.Transmission;
using Business.Requests.Transmission;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransmissionService
    {
        public AddTransmissionResponses Add(AddTransmissionRequests request);

        public IList<Transmission> GetList();
    }
}
