using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.DataAccess.Interfaces;
using ToDoApp.Domain;
using ToDoApp.Mapper;
using ToDoApp.Models.Dtos;
using ToDoApp.Services.Interfaces;


namespace ToDoApp.Services.Implementations
{
    public class FilterService : IFilterService
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Status> _statusRepository;
        public FilterService(IRepository<Category> categoryRepository, IRepository<Status> statusRepository)
        {
            _categoryRepository = categoryRepository;
            _statusRepository = statusRepository;
        }
        public List<CategoryDto> GetCategories()
        {
            var categories = _categoryRepository.GetAll().Select(x => OptionalMapper.MapToCategoryDto(x)).ToList();
            return categories;
        }

        public List<StatusDto> GetStatuses()
        {
            return _statusRepository.GetAll().Select(x => OptionalMapper.MapToStatusDto(x)).ToList();
        }
    }
}
