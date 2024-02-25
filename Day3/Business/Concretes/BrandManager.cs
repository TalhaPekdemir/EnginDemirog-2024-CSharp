using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponse Add(CreatedBrandRequest createdBrandRequest)
    {
        // business rules

        Brand brand = new Brand()
        {
            Name = createdBrandRequest.Name,
            CreatedDate = DateTime.Now
        };

        _brandDal.Add(brand);

        // mapping -> automapper
        // amaç veritabanı nesnesini son kullanıcıya açmamak
        // db de gösterilmemesi gereken ancak tutulan veriler olabilir 
        CreatedBrandResponse createdBrandResponse = new()
        {
            Id = 4,
            Name = createdBrandRequest.Name,
            CreatedDate = brand.CreatedDate
        };

        return createdBrandResponse;
    }

    public List<GetAllBrandResponse> GetAll()
    {
        List<Brand> brands = _brandDal.GetAll();

        List<GetAllBrandResponse> getAllBrandResponses = new();

        foreach (var brand in brands)
        {
            GetAllBrandResponse getAllBrandResponse = new()
            {
                Id = brand.Id,
                Name = brand.Name,
                CreatedDate = brand.CreatedDate
            };

            getAllBrandResponses.Add(getAllBrandResponse);
        }

        return getAllBrandResponses;
    }
}
