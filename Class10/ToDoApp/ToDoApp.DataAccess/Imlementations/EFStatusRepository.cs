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
    public class EFStatusRepository : IRepository<Status>
    {
        private readonly ToDoAppDbContext _context;

        public EFStatusRepository(ToDoAppDbContext context)
        {
            _context = context;
        }

        public void Create(Status entity)
        {
            _context.Status.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var status = _context.Status.FirstOrDefault(x => x.Id == id);
            if (status != null)
            {
                _context.Status.Remove(status);
                _context.SaveChanges();
            }
        }

        public void Create(Category entity)
        {
            _context.Category.Add(entity);
            _context.SaveChanges();
        }

        public List<Status> GetAll()
        {
            return _context.Status.ToList();
        }

        public void Update(Status entity)
        {
            _context.Status.Update(entity);
            _context.SaveChanges();
        }

        public ToDo GetById(int id)
        {
            var toDo = _context.ToDo
              .Include(x => x.Status)
              .Include(x => x.Category)
              .FirstOrDefault(x => x.Id == id);
            return toDo;
        }

        public List<ToDo> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(ToDo entity)
        {
            _context.ToDo.Update(entity);
            _context.SaveChanges();
        }

        Status IRepository<Status>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

