using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECP.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECP.API.Controllers
{

    public class TestController : Controller
    {
        Data[] datas = new Data[]
        {
        new Data {Period = "01.01.2018", Amount = 7},
        new Data {Period = "02.01.2018", Amount = 5},
        new Data {Period = "03.01.2018", Amount = 9}

        };

        [HttpGet]
        [Route("api/test")]
        public IActionResult GetTest()
        {
            return Ok(datas);
        }

       
    }
}