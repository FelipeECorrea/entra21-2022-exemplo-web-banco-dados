using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Enums;
using Entra21.CSharp.ClinicaVeterinaria.Servico.Servicos;
using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels.Racas;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplicacao.Controllers
{
    // Dois pontos mais pra frente é sobre Herença
    [Route("raca")]
    public class RacaController : Controller
    {
        private readonly IRacaServico _racaServico;

        /* Construtor: objetivo - construir o objeto de RacaController,
         com o mínimo necessário para o funcionamento correto */

        public RacaController(IRacaServico racaServico)
        {
            _racaServico = racaServico;
        }

        /// <summary>
        /// Endpoint que permite lista todas as raças
        /// </summary>
        /// <returns>Retorna a página html com as raças</returns>
        [HttpGet]
        public IActionResult Index()
        {
            var racas = _racaServico.ObterTodos();

            return View("Index", racas);
        }

        [HttpGet("cadastrar")]
        public IActionResult Cadastrar()
        {
            var especies = ObterEspecies();

            ViewBag.Especies = ObterEspecies();

            var racaCadastrarViewModel = new RacaCadastrarViewModel();

            return View(racaCadastrarViewModel);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromForm] RacaCadastrarViewModel racaCadastrarViewModel)
        {
            // Valida o parâmetro recebido na Action se é inválido
            if (!ModelState.IsValid)
            {
                ViewBag.Especies = ObterEspecies();

                return View(racaCadastrarViewModel);
            }

            _racaServico.Cadastrar(racaCadastrarViewModel);

            return RedirectToAction("Index");
        }

        [HttpGet("apagar")]
        // http://local:host:portaapagar?id=4
        public IActionResult Apagar([FromQuery] int id)
        {
            _racaServico.Apagar(id);

            return RedirectToAction("Index");
        }

        [HttpGet("editar")]
        public IActionResult Editar([FromQuery] int id)
        {
            var raca = _racaServico.ObterPorId(id);
            var especies = ObterEspecies();

            var racaEditarViewModel = new RacaEditarViewModel
            {
                Id = raca.Id,
                Nome = raca.Nome,
                Especie = raca.Especie
            };

            ViewBag.Especies = especies;

            return View(racaEditarViewModel);
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromForm] RacaEditarViewModel racaEditarViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Especies = ObterEspecies();

                return View(racaEditarViewModel);
            }

            _racaServico.Editar(racaEditarViewModel);

            return RedirectToAction("Index");
        }

        [HttpGet("obterTodosSelect2")]
        public IActionResult ObterTodosSelect2()
        {
            var selectViewModel = _racaServico.ObterTodosSelect2();

            return Ok(selectViewModel);
        }

        private List<string> ObterEspecies()
        {
            return Enum
                .GetNames<Especie>()
                .OrderBy(x => x)
                .ToList();
        }
    }
}
