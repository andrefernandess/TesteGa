using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TesteGa.Application.Interfaces;
using TesteGa.Domain.Models;
using TesteGa.Ui.Models;

namespace TesteGa.Ui.Controllers
{
    public class FazendasController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFazendaService _service;
        public FazendasController(IMapper mapper, IFazendaService service)
        {
            _mapper = mapper;
            _service = service;
        }
        public IActionResult Index()
        {
            var results = _service.GetAll();

            if (results == null)
                return View();

            return View(_mapper.Map<FazendaDto[]>(results));
        }

        public ActionResult Cadastro()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastro(FazendaDto fazenda)
        {

            _service.Add(_mapper.Map<Fazenda>(fazenda));
            
            return RedirectToAction("Index");
        }

        #region metodos privados
        //private List<Fazenda> GetAll()
        //{

        //}

        #endregion
    }
}
