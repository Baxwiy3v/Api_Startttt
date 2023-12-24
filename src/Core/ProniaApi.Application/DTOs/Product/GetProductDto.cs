using ProniaApi.Application.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Application.DTOs.Product
{
    public record GetProductDto(
        decimal Price, 
        string SKU, 
        string? Description,
        int CategoryId,
        IncludeCategoryDto Category);
}
