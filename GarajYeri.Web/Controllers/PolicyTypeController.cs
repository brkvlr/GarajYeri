using GarajYeri.Data;
using GarajYeri.Repository.Shared.Abstract;
using GarajYeriModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GarajYeri.Web.Controllers
{
    [Authorize(Roles ="Admin")]
    public class PolicyTypeController : Controller
    {
        private readonly IRepository<PolicyType> _policyTypeRepository;

        public PolicyTypeController(IRepository<PolicyType> policyTypeRepository)
        {
            _policyTypeRepository = policyTypeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] // default geliyor zaten
        public IActionResult GetAll()
        {
            return Json(new { data = _policyTypeRepository.GetAll()});
        }

        [HttpPost]
        public IActionResult Add(PolicyType policyType)
        {
            return Ok(_policyTypeRepository.Add(policyType));
        }

        [HttpPost]
        public IActionResult SoftDelete(int id)
        {
            var result = _policyTypeRepository.DeleteById(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Hata - Nesne bulunamadı");
            }


        }

        [HttpPost]
        public IActionResult Update(PolicyType policyType)
        {
            return Ok(_policyTypeRepository.Update(policyType));
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            return Ok(_policyTypeRepository.GetById(id));
        }
    }
}
