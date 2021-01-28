using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IService _service;

        public ValuesController(IService service)
        {
            _service = service;  /*new ToolManager();*/
        }

        /// <summary>
        /// Get All Cars
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Car> Get()
        {
            return _service.GetAll();
        }

        /// <summary>
        /// Get Cars By id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return _service.GetById(id);
        }

        /// <summary>
        /// Create an Car
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        [HttpPost]
        public Car Post([FromBody] Car car)
        {
            return _service.CreateTool(car);
        }

        /// <summary>
        /// Update the Car
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        [HttpPut]
        public Car Put([FromBody] Car car)
        {
            return _service.UpdateTool(car);
        }

        /// <summary>
        /// Delete the Car
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.DeleteTool(id);
        }
    }
}
