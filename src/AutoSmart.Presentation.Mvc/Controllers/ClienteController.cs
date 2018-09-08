using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using AutoSmart.Application.Interfaces;
using AutoSmart.Application.ViewModel;
using AutoSmart.Domain.Entities;

namespace AutoSmart.Presentation.Mvc.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteAppService _clienteAppService;

        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }
        
        public ActionResult Index()
        {
            var clientes = _clienteAppService.GetAll();

            var model = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(clientes);

            return View(model);
        }
    }
}