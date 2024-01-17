using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Fuel;
using Business.Requests.Transmission;
using Business.Responses.Fuel;
using Business.Responses.Transmission;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TransmissionManager : ITransmissionService
    {
        private readonly ITransmissionDal _transmissionDal;
        private readonly TransmissionBusinnesRules _transmissionBusinnesRules;
        private readonly IMapper _mapper;
        public TransmissionManager()
        {

        }
        public TransmissionManager(ITransmissionDal transmissionDal, TransmissionBusinnesRules transmissionBusinnesRules, IMapper mapper)
        {
            _transmissionDal = transmissionDal;
            _transmissionBusinnesRules = transmissionBusinnesRules;
            _mapper = mapper;
        }
        public AddTransmissionResponses Add(AddTransmissionRequests request)
        {
            _transmissionBusinnesRules.CheckIfTransmissionNameNotExists(request.Name);
            Transmission transmissionToAdd = _mapper.Map<Transmission>(request);
            _transmissionDal.Add(transmissionToAdd);
            AddTransmissionResponses response = _mapper.Map<AddTransmissionResponses>(transmissionToAdd);
            return response;
        }

        public IList<Transmission> GetList()
        {
            IList<Transmission> transmissionList = _transmissionDal.GetList();
            return transmissionList;
        }
    }
}
