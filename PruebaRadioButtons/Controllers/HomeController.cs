using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaRadioButtons.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaRadioButtons.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController( ILogger<HomeController> logger )
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var cuentas = new CuentasClienteViewModel
            {
                CuentasAhorros = new List<CuentaAhorro>
                {
                    new CuentaAhorro
                    {
                        NombreCuenta = "Cuenta Ahorro 1 - 1234567",
                        NumeroCuenta = "1234567"
                    },
                    new CuentaAhorro
                    {
                        NombreCuenta = "Cuenta Ahorro 2 - 2345678",
                        NumeroCuenta = "2345678"
                    }
                },
                CuentasCorrientes = new List<CuentaCorriente>
                {
                    new CuentaCorriente
                    {
                        NombreCuenta = "Cuenta Corriente 1 - 3456789",
                        NumeroCuenta = "3456789"
                    },
                    new CuentaCorriente
                    {
                        NombreCuenta = "Cuenta Corriente 2 - 4567890",
                        NumeroCuenta = "4567890"
                    }
                }
            };

            return View(cuentas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
