﻿using Microsoft.EntityFrameworkCore;
using ProniaApi.Application.Abstractions.Repositories;
using ProniaApi.Application.Abstractions.Services;
using ProniaApi.Application.DTOs.Colors;
using ProniaApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Persistence.Implementations.Services
{
    public class ColorService : IColorService
    {
        private readonly IColorRepository _repository;

        public ColorService(IColorRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(ColorCreateDto colorCreateDto)
        {
           Color color = new Color
            {
                Name = colorCreateDto.Name
            };
            await _repository.AddAsync(color);
            await _repository.SaveChangesAsync();
        }

        public async Task<ICollection<ColorItemDto>> GetAllAsync(int page, int take)
        {
            ICollection<Color> colors = await _repository.GetAllWhere(skip: (page - 1) * take, take: take, isTracking: false, ignoreQuery: true).ToListAsync();

            ICollection<ColorItemDto> colorItemDtos = new List<ColorItemDto>();

            foreach (Color color in colors)
            {
                colorItemDtos.Add(new ColorItemDto(color.Id, color.Name));
            }
            return colorItemDtos;
        }
        public async Task UpdateAsync(int id, ColorUpdateDto colorUpdateDto)
        {
            Color color = await _repository.GetByIdAsync(id);

            if (color is null) throw new Exception("Not found");

            color.Name = colorUpdateDto.Name;

            _repository.Update(color);
            await _repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            Color color = await _repository.GetByIdAsync(id);

            if (color is null) throw new Exception("Not found");

            _repository.Delete(color);
            await _repository.SaveChangesAsync();
        }
        public async Task SoftDeleteAsync(int id)
        {
            Color color = await _repository.GetByIdAsync(id);

            if (color is null) throw new Exception("Not found");
            _repository.SoftDelete(color);
            await _repository.SaveChangesAsync();
        }

        public async Task<ColorGetDto> GetAsync(int id)
        {
            Color color = await _repository.GetByIdAsync(id);

            if (color is null) throw new Exception("Not found");
            return new ColorGetDto(color.Id, color.Name);
        }
    }
}
