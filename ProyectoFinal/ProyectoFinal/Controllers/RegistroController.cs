using Dapper;
using ProyectoFinal.Models;
using ProyectoFinal.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ProyectoFinal.Controllers
{
    public class RegistroController : Controller
    {
        private readonly  IRepositorioRegistro repositorioRegistro;

        public RegistroController(IRepositorioRegistro repositorioRegistro)
        {
            this.repositorioRegistro = repositorioRegistro;
        }

        public async Task<IActionResult> Registro()
        {
            return View();
            return RedirectToAction("Registro");
        }

        }
}
