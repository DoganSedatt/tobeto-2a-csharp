﻿using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class TransmissionBusinnesRules
    {
        private readonly ITransmissionDal _transmissionDal;

        public TransmissionBusinnesRules(ITransmissionDal transmissionDal)
        {
            _transmissionDal = transmissionDal;
        }
        public void CheckIfTransmissionNameNotExists(string transmissionName)
        {
            bool isExists = _transmissionDal.GetList().Any(p => p.Name == transmissionName);
            if (isExists)
            {
                throw new Exception("Transmission already exists");
            }
        }
    }
}
