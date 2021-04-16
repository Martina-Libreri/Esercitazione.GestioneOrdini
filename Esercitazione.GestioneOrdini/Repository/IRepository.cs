using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.GestioneOrdini.Repository
{
    public interface IRepository<T>
    {
        bool Create(T item);
        bool Delete(T item);
        T GetById(int id);
        bool Update(T item);
    }
}
