using Business.Dtos.Requests;
using Business.Dtos.Responses;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        CreatedBrandResponse Add(CreatedBrandRequest createdBrandRequest);
        List<GetAllBrandResponse> GetAll();
    }
}
