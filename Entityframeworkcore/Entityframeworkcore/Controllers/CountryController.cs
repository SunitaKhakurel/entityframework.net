using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entityframeworkcore
{
    public class CountryController : Controller
    {
        public readonly EntityFrameWorkcoreEntity _context;
        public CountryController(EntityFrameWorkcoreEntity context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Country> list = _context.Countries.ToList();

            return View(list);
        }
        public IActionResult CreateCountry()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCountry(Country newCountry)
        {
            _context.Countries.Add(newCountry);
            _context.SaveChanges();
            return RedirectToAction("Index");


        }
        public IActionResult DistrictList()
        {

            List<District> list = _context.Districts.ToList();

            return View(list);
        }
        public IActionResult CreateDistrict()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDistrict(District newDistrict)
        {

            _context.Districts.Add(newDistrict);
            _context.SaveChanges();
            return RedirectToAction("DistrictList");




        }
        public IActionResult DeteteCountry(int id)
        {
            var country = _context.Countries.Where(x => x.Id == id).FirstOrDefault();
            _context.Countries.Remove(country);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeteteDistrict(int id)
        {
            var district = _context.Districts.Where(x => x.Id == id).FirstOrDefault();
            _context.Districts.Remove(district);
            _context.SaveChanges();
            return RedirectToAction("DistrictList");
        }
        public IActionResult EditDistrict(int id)
        {
            var district = _context.Districts.Where(x => x.Id == id).FirstOrDefault();

            return View(district);
        }
    }
}
