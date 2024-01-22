using Business;
using Business.Abstract;
using Business.Requests.Model;
using Business.Responses.Car;
using Business.Responses.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        //Bu sınıfta Wep üzerinden get ve set isteklerini karşılayacağız
        //Bunun için service sınıfını kullanmamız lazım cons içinde
        IModelService _modelService;
        public ModelController(IModelService modelService)
        {
            _modelService = modelService;
        }

        //GET isteğine karşılık verecek metod
        [HttpGet]
        public GetModelListResponse GetModelList([FromQuery] GetModelListRequests request)
        {
            GetModelListResponse response = _modelService.GetModelList(request);
            return response;
        }

        //POST isteğine karşılık verecek metod 
        [HttpPost]
        public ActionResult<AddModelResponse> Add(AddModelRequests request)
        {
            AddModelResponse response = _modelService.Add(request);
            return CreatedAtAction(nameof(GetModelList), response);
        }
    }
}
