using Business.Requests.Transmission;
using Business.Responses.Transmission;

namespace Business.Abstract
{
    public interface ITransmissionService
    {
        public AddTransmissionResponses Add(AddTransmissionRequests request);

        public GetTransmissionListResponse GetList(GetTransmissionListRequest request);
    }
}
