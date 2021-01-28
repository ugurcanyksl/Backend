using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ToolManager : IService
    {
        private IRepository _repository;
        public ToolManager(IRepository repository)
        {
            _repository = repository;  /*new ToolRepository();*/
        }

        public Car CreateTool(Car car)
        {
            return _repository.CreateTool(car);
        }

        public void DeleteTool(int id)
        {
            _repository.DeleteTool(id);
        }

        public List<Car> GetAll()
        {
            return _repository.GetAll();
        }

        public Car GetById(int id)
        {
            if (id > 0)
            {
                return _repository.GetById(id);
            }
            throw new Exception("id can not be les than 1");
        }

        public Car UpdateTool(Car car)
        {
            return _repository.UpdateTool(car);
        }
    }
}
