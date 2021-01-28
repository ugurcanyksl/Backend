using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface IRepository
    {
        List<Car> GetAll();

        Car GetById(int id);

        Car CreateTool(Car car);

        Car UpdateTool(Car car);

        void DeleteTool(int id);
    }
}
