using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class HomeController: Controller
    {
        private readonly ICinemaService _cinemaService;

        public HomeController(ICinemaService cinemaService)
        {
            this._cinemaService = cinemaService;
        }
    }
}
