using Курсовая_работа.model;

namespace Курсовая_работа.Interfaces
{
    internal interface IEntityController<T>
    {
        IEnumerable<T> GetElements();
        void Add(T entity);
        void RemoveById(int id);
        void Remove(Func<T, bool> Delegate);
        bool TryFind(Func<T, bool> Delegate);
        T? Find(T entity);
        T? FindById(int id);
        void Change(T entity);
    }
}
