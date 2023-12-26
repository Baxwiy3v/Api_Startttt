using AutoMapper;
using ProniaApi.Application.DTOs.Colors;
using ProniaApi.Domain.Entities;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Application.MappingProfiles
{
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
            CreateMap<Color, ColorItemDto>().ReverseMap();
            CreateMap<Color, ColorGetDto>().ReverseMap();
            CreateMap<ColorUpdateDto, Color>();

        }
    }
}
