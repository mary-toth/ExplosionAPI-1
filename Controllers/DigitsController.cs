using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DigitsController : ControllerBase
    {
        [HttpGet("{digit}")]
        public string Digits(string digit)
        {
            var expStr = "";
            for (var i = 0; i < digit.Length; i++)
            {
                var numChar = digit[i].ToString();
                var num = Int32.Parse(numChar);
                for (var j = 0; j < num; j++)
                {
                    expStr += numChar;
                }
            }
            return expStr;
        }
    }
}