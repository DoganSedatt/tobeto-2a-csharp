using Business.Dtos.Car;
using Business.Dtos.Fuel;

namespace Business
{
    public class GetCarListResponse
    {
        public ICollection<CarListItemDto> Items { get; set; }

        public GetCarListResponse()
        {
            Items = Array.Empty<CarListItemDto>();
        }

        public GetCarListResponse(ICollection<CarListItemDto> items)
        {
            Items = items;
        }
    }
}