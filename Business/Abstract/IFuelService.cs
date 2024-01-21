using Business.Requests.Fuel;
using Business.Responses.Fuel;

namespace Business.Abstract
{
    public interface IFuelService
    {
        public AddFuelResponse Add(AddFuelRequests request);
        public GetFuelListResponse GetList(GetFuelListRequest request);
    }
}
