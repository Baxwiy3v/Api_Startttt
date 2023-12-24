using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Application.DTOs.Product
{
    public record ProductGetSingleDto(
        decimal Price,
        string SKU, 
        string? Description);
}

