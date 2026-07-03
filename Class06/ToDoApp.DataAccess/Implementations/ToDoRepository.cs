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
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }
        entity.Id = StaticDb.Todos.Last().Id + 1;
        StaticDb.Todos.Add(entity);
    }

    public void Delete(int id)
    {
        ToDo toDo = StaticDb.Todos.FirstOrDefault(t => t.Id == id);
        if (toDo == null)
        {
            throw new ArgumentException(nameof(id));
        }
        StaticDb.Todos.Remove(toDo);
    }

    public List<ToDo> GetAll()
    {
        return StaticDb.Todos;
    }

    public ToDo GetById(int id)
    {
        var toDo = StaticDb.Todos.FirstOrDefault(t => t.Id == id);
        if (toDo == null)
        {
            throw new ArgumentException(nameof(id));
        }
        return toDo;
    }

    public void Update(ToDo entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        ToDo toDo = GetById(entity.Id);
        int index = StaticDb.Todos.IndexOf(toDo);
        StaticDb.Todos[index] = entity;
    }
}

