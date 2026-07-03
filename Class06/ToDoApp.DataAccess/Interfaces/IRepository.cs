using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess.Interfaces;

//CRUD methods for the repository pattern (for accessing db)

public interface IRepository<T> where T : BaseEntity
{
    //CRUD methods
    List<T> GetAll(); //Read all
    T GetById(int id); //Read by id
    void Create(T entity); //Create
    void Update(T entity); //Update
    void Delete(int id); // Delete by id
}
