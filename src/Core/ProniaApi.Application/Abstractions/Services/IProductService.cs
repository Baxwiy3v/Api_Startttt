using ProniaApi.Application.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Application.Abstractions.Services
{
    public interface IProductService
    {
        Task<IEnumerable<GetProductDto>> GetAllPaginated(int page, int take);
        Task<ProductGetSingleDto> GetByIsAsync(int id);
        Task CreateAsync(CreateProductDto productDto);
        Task UpdateAsync(int id, ProductUpdateDto productDto);
    }
}
