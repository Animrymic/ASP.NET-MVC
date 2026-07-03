using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DataAccess.Interfaces;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess.Implementations;

public class ToDoRepository : IRepository<ToDo>
{
    public void Create(ToDo entity)
    {
        throw new NotImplementedException();
    }
    
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<ToDo> GetAll()
    {
        throw new NotImplementedException();
    }

    public ToDo GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(ToDo entity)
    {
        throw new NotImplementedException();
    }
}
