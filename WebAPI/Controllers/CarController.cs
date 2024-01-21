using Business;
using Business.Abstract;
using Business.Responses.Car;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        //Bu sınıfta Wep üzerinden get ve set isteklerini karşılayacağız
        //Bunun için service sınıfını kullanmamız lazım cons içinde
        ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        //GET isteğine karşılık verecek metod
        [HttpGet]
        public GetCarListResponse GetList([FromQuery]GetCarListRequest request)
        {
            GetCarListResponse response = _carService.GetCar(request);
            return response;
        }

        //POST isteğine karşılık verecek metod 
        [HttpPost]
        public ActionResult<AddCarResponse> Add(AddCarRequest request)
        {
            AddCarResponse response = _carService.AddCar(request);
            return CreatedAtAction(nameof(GetList),response);
        }
    }
}
