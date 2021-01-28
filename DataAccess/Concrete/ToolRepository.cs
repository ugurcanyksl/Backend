using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ToolRepository : IRepository
    {
        public Car CreateTool(Car car)
        {
            using (var appDbContext = new AppDbContext())
            {
                appDbContext.Cars.Add(car);
                appDbContext.SaveChanges();
                return car;
            }
        }

        public void DeleteTool(int id)
        {
            using (var appDbContext = new AppDbContext())
            {
                var deletedTool = GetById(id);
                appDbContext.Cars.Remove(deletedTool);
                appDbContext.SaveChanges();
            }
        }

        public List<Car> GetAll()
        {
            using (var appDbContext = new AppDbContext())
            {
                return appDbContext.Cars.ToList();
            }
        }

        public Car GetById(int id)
        {
            using (var appDbContext = new AppDbContext())
            {
                return appDbContext.Cars.Find(id);
            }
        }

        public Car UpdateTool(Car car)
        {
            using (var appDbContext = new AppDbContext())
            {
                appDbContext.Cars.Update(car);
                appDbContext.SaveChanges();
                return car;
            }
        }
    }
}
