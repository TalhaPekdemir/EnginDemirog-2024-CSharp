﻿using Day2Assignment3.Entities.Abstarct;

namespace Day2Assignment3.DataAccess.Abstract;

public interface IEntityDal<T>
{
    List<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Delete(T entity);
    void Update(int id, T entity);
}
