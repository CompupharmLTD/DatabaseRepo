//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace CompupharmLtd.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductController : ControllerBase
//    {
//        // GET: api/<ProductController>
//        [HttpGet]
//        [Route("ProductList")]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET api/<ProductController>/5
//        [HttpGet("{id}")]
//        [Route("ProductByID")]

//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/<ProductController>
//        [HttpPost]
//        [Route("CreateProduct")]

//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT api/<ProductController>/5
//        [HttpPut("{id}")]
//        [Route("EditProduct")]

//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<ProductController>/5
//        [HttpDelete("{id}")]
//        [Route("DleteProduct")]

//        public void Delete(int id)
//        {
//        }
//    }
//}
