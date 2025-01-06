using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Add2NumbersEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2NumbersController : ControllerBase
    {
        [HttpPost]
        [Route("Add2Numbers/{FirstNumber},{SecondNumber}")]
        public string Add2numbers(int FirstNumber, int SecondNumber){
            int sum = FirstNumber+SecondNumber;

            return $"The sum of {FirstNumber} and {SecondNumber} is {sum}";
        }
    }
}