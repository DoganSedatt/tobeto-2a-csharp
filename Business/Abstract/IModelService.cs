using Business.Requests.Model;
using Business.Responses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IModelService
    {
        public AddModelResponse Add(AddModelRequests addModelRequests);
        public GetModelListResponse GetModelList(GetModelListRequests getModelListRequests);
    }
}
