using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalTest.Web.Data;

namespace TechnicalTest.Web.Controllers.API
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UsuarioController(
            DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
