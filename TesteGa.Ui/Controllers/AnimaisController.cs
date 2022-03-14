using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TesteGa.Application.Interfaces;
using TesteGa.Domain.Models;
using TesteGa.Ui.Models;

namespace TesteGa.Ui.Controllers
{
    public class AnimaisController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAnimalService _service;
        private readonly IFazendaService _fazenda_service;
        public AnimaisController(IMapper mapper, IAnimalService service, IFazendaService fazenda_service)
        {
            _mapper = mapper;
            _service = service;
            _fazenda_service = fazenda_service;
        }
        public IActionResult Index()
        {
            var results = _service.GetAll();

            if(results == null)
                return View();

            var animais = _mapper.Map<AnimalDto[]>(results);
            
            return View(animais);
        }

        public ActionResult Cadastro()
        {
            var fazendas = _mapper.Map<FazendaSelectDto[]>(_fazenda_service.GetAll());

            ViewBag.Fazendas = new SelectList
                (
                    fazendas,
                    "Id",
                    "Nome"
                );
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastro(AnimalDto animal)
        {
            if(!ModelState.IsValid)
            {
                var fazendas = _mapper.Map<FazendaSelectDto[]>(_fazenda_service.GetAll());

                ViewBag.Fazendas = new SelectList
                    (
                        fazendas,
                        "Id",
                        "Nome"
                    );
                return View();
            }

            _service.Add(_mapper.Map<Animal>(animal));

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var animal = _service.GetById(id);

            if (animal != null)
                _service.Delete(animal);

            return RedirectToAction("Index");
        }
    }
}