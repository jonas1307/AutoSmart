using System;
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

            return View(Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(clientes));
        }

        public ActionResult Criar()
        {
            return View("FormCliente", new ClienteViewModel());
        }

        public ActionResult Editar(long id)
        {
            var cliente = _clienteAppService.GetById(id);

            if (cliente == null)
                return new HttpNotFoundResult();

            return View("FormCliente", Mapper.Map<Cliente, ClienteViewModel>(cliente));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Salvar(ClienteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("FormCliente", model);
            }

            try
            {
                if (model.Id == 0)
                {
                    _clienteAppService.Add(Mapper.Map<ClienteViewModel, Cliente>(model));
                }
                else
                {
                    _clienteAppService.Update(Mapper.Map<ClienteViewModel, Cliente>(model));
                }
            }
            catch (Exception)
            {
                return View("FormCliente", model);
            }

            return RedirectToAction("Index");
        }
    }
}