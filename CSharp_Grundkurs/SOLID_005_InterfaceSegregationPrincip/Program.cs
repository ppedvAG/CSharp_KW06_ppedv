using System;
using System.Collections.Generic;

namespace SOLID_005_InterfaceSegregationPrincip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepository<Employee> employeeRepository = new UnflexibleRepository<Employee>();
            //employeeRepository.Insert();
            //employeeRepository.Delete();
            //employeeRepository.Update();
            //employeeRepository.GetAll();
            //employeeRepository.GetById(1);

            IReadCommand<Employee> readCommand = new BetterRepository<Employee>();

            //readCommand.GetAll();
            //readCommand.GetById(123);
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }


    #region BadCode
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();

        void Update(T entity);
        void Insert(T entity);
        void Delete(T entity);
    }

    public class UnflexibleRepository<T> : IRepository<T>
    {
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }


    #endregion

    #region Better Code

    public interface IInsertCommand<T>
    {
        void Insert(T item);
    }

    public interface IUpdateCommand<T>
    {
        void Update(T item);
    }

    public interface IDeleteCommand<T>
    {
        void Delete(T item);
    }

    public interface IReadCommand<T>
    {
        T GetById(int id);
        List<T> GetAll();
    }

    public class BetterRepository<T> : IInsertCommand<T>, IUpdateCommand<T>, IDeleteCommand<T>, IReadCommand<T>
    {
        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
