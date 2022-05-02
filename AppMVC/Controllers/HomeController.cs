using AppMVC.Models;
using AppMVC.ViewModels;
using AutoMapper;
using Businiss.Interface;
using Businiss.Model;
using DataBase.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FornecedorRepository _fornecedor;
        private readonly IMapper _mapper;
       

        public HomeController(ILogger<HomeController> logger, FornecedorRepository context, IMapper mapper )
        {
            _logger = logger;
            _fornecedor = context;
            _mapper = mapper;
           
        }

        public IActionResult Index()
        {
            var fornecedores = _mapper.Map<FornecedorViewModel>(_fornecedor.ListarFornecedorEndereco());
            return View(fornecedores);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(FornecedorViewModel fornecedorView)
        {
            if (!ModelState.IsValid) { return View(fornecedorView); }
            var fornecedor = _mapper.Map<Fornecedor>(fornecedorView);
            _fornecedor.Adicionar(fornecedor);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}