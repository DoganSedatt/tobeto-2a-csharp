using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Model;
using Business.Responses.Model;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        private readonly IModelDal _modelDal;
        private readonly ModelBusinnesRules _modelBusinnesRules;
        private readonly IMapper _mapper;
        public ModelManager(IModelDal modelDal,ModelBusinnesRules modelBusinnesRules,IMapper mapper)
        {
            _modelDal = modelDal;
            _mapper = mapper;
            _modelBusinnesRules = modelBusinnesRules;
        }

        public AddModelResponse Add(AddModelRequests addModelRequests)
        {
            //Önce ekleme şartına bakacağız.Karşılıyor ise ekleyeceğiz
            _modelBusinnesRules.CheckModelAdded(addModelRequests.ModelName, addModelRequests.DailyPrice);


            Model modelToAdd = _mapper.Map<Model>(addModelRequests);
            _modelDal.Add(modelToAdd);

            AddModelResponse response=_mapper.Map<AddModelResponse>(modelToAdd);
            return response;
        }

        public GetModelListResponse GetModelList(GetModelListRequests getModelListRequests)
        {
            IList<Model> modelList = _modelDal.GetList();

            GetModelListResponse response = _mapper.Map<GetModelListResponse>(modelList); // Mapping
            return response;
        }
    }
}
