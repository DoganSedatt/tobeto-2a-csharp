using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class ModelBusinnesRules
    {
        private readonly IModelDal _modelDal;
        public ModelBusinnesRules(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }
        public void CheckModelAdded(string modelName,int dailyPrice)
        {
            bool isExists = _modelDal.GetList().Any(m => m.ModelName.Length < 2 || m.DailyPrice <= 0);
            if (isExists)
            {
                throw new Exception("Model eklenme şartlarını karşılamadı");
            }
        }
    }
}
