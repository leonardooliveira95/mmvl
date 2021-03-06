﻿using InovaPrudente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InovaPrudente.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TrocarEndereco()
        {
            TrocarEnderecoViewModel vm = new TrocarEnderecoViewModel();
            vm.EnderecoAtual = "Coronel José Soares Marcondes, 2000, Presidente Prudente";

            return PartialView("_TrocarEndereco", vm);
        }

        public ActionResult AlterarDataEntrega()
        {
            AlterarDataEntregaViewModel vm = new AlterarDataEntregaViewModel();

            vm.DataEntregaAtual = DateTime.Now;

            return PartialView("_AlterarDataEntrega", vm);
        }

        public ActionResult EntregarArmario()
        {
            EntregarArmarioViewModel vm = new EntregarArmarioViewModel();

            vm.EnderecoAtual = "Manoel Goulart, 250, Presidente Prudente";
            vm.Locais = new List<LocalViewModel>
            {
                new LocalViewModel
                {
                    Endereco = "Carrefour Presidente Prudente",
                    Latitude = 34.397,
                    Longitude = 150.644
                },
                new LocalViewModel
                {
                    Endereco = "Muffato Max Presidente Prudente",
                    Latitude = 37.397,
                    Longitude = 180.644
                }
            };

            return PartialView("_EntregarArmario", vm);
        }

        [HttpPost]
        public ActionResult CalcularValorPrecoDistancia(double distancia)
        {

            return Json(new { valor = 52 });

        }
    }
}