﻿using AutoMapper;
using ProniaApi.Application.DTOs.Product;
using ProniaApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Application.MappingProfiles
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, GetProductDto>().ReverseMap();

            CreateMap<Product, ProductGetSingleDto>().ReverseMap();

            CreateMap<CreateProductDto, Product>();

        }
    }
}
