using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace conversor_temperatura.Controllers
{
    [Produces("application/json")]
    [Route("api/Conversor")]
    public class ConversorController : Controller
    {
        // POST: api/Conversor
        [HttpPost]
        public double Post([FromBody]double temperatura, string escalaEntrada, string escalaSaida)
        {
            if (escalaEntrada.Equals("celsius"))
            {
                if (escalaSaida.Equals("fahrenheit"))
                {
                    return (temperatura * 2) + 30;
                }
                else if (escalaSaida.Equals("kelvin"))
                {
                    return temperatura + 273;
                }
                else
                {
                    return 0;
                }
            }
            else if (escalaEntrada.Equals("fahrenheit"))
            {
                if (escalaSaida.Equals("celsius"))
                {
                    return (temperatura - 30) / 2;
                }
                else if (escalaSaida.Equals("kelvin"))
                {
                    return ((temperatura - 30) / 2) + 273;

                }
                else
                {
                    return 0;
                }
            }
            else if (escalaEntrada.Equals("kelvin"))
            {
                if (escalaSaida.Equals("celsius"))
                {
                    return temperatura - 273;
                }
                else if (escalaSaida.Equals("fahrenheit"))
                {
                    return ((temperatura - 30) / 2) - 273;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
