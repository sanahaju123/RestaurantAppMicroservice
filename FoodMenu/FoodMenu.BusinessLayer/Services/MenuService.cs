using FoodMenu.DataLayer.Data;
using FoodMenu.Entities.Models;
using FoodMenu.BusinessLayer.Services.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodMenu.BusinessLayer.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<IEnumerable<Menu>> FindAllAsync()
        {
            return await _menuRepository.FindAllAsync();
        }

        public async Task<Menu> FindOneAsync(int id)
        {
            return await _menuRepository.FindOneAsync(id);
        }

        public async Task<Menu> InsertAsync(Menu menu)
        {
            return await _menuRepository.InsertAsync(menu);
        }

        public async Task<Menu> UpdateAsync(Menu menu)
        {
            return await _menuRepository.UpdateAsync(menu);
        }
    }
}


