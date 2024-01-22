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
            bool isExists = _modelDal.GetList().Any(m => m.ModelName==modelName);
            bool isLenght =  modelName.Length <= 2 || dailyPrice<=0;
            
            if (isExists)
            {
                throw new Exception("Model daha önce eklenmiş");
            }
            else if (isLenght)
            {
                throw new Exception("islength");
            }

        }
    }
}
