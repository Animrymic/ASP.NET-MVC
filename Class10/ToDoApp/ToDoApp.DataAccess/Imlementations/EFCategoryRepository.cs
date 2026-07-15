using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.DataAccess.Interfaces;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess.Imlementations
{
    public class EFCategoryRepository : IRepository<Category>
    {
        private readonly ToDoAppDbContext _context;

        public EFCategoryRepository(ToDoAppDbContext context)
        {
            _context = context;
        }
        public void Create(Category entity)
        {
            _context.Category.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.Category.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                _context.Category.Remove(category);
                _context.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Category.FirstOrDefault(x => x.Id == id);
        }

        public List<Category> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            _context.Category.Update(entity);
            _context.SaveChanges();
        }
    }
}