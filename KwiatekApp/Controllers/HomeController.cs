using KwiatekApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KwiatekApp.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PanelKlienta()
        {
            List<string> rezerwacjaList = new List<string>();
            rezerwacjaList.Add("Rezerwacja1 ");
            rezerwacjaList.Add("Rezerwacja2 ");

            ViewData["Rezerwacja"] = rezerwacjaList;

            List<string> usługaList = new List<string>();
            usługaList.Add("Usługa1 ");
            usługaList.Add("Usługa2 ");

            ViewData["Usługa"] = usługaList;

            List<string> nagrodaList = new List<string>();
            nagrodaList.Add("Nagroda1 ");
            nagrodaList.Add("Nagroda2 ");
            ViewData["Nagroda"] = nagrodaList;
            

            return View();
        }

        public ActionResult PanelAdministratora()
        {
            ViewData["Message"] = "Tutaj panel";
            List<string> cenaList = new List<string>();
            cenaList.Add("Cena1: ");
            cenaList.Add("Cena2: ");

            ViewData["Cena"] = cenaList;

            List<string> klientList = new List<string>();
            klientList.Add("Klient1 ");
            klientList.Add("Klient2 ");

            ViewData["Klient"] = klientList;

            List<string> dostawaList = new List<string>();
            dostawaList.Add("Dostawa1 ");
            dostawaList.Add("Dostawa2 ");

            ViewData["Dostawa"] = dostawaList;

            List<string> programList = new List<string>();
            programList.Add("Program1 ");
            programList.Add("Program2 ");

            ViewData["Program"] = programList;
            return View();
        }

        public ActionResult PanelPracownika()
        {
            ViewData["Message"] = "Tutaj panel";
            List<string> controlerList = new List<string>();
            controlerList.Add("Kontroler1: ");
            controlerList.Add("Kontroler2: ");

            ViewData["Controler"] = controlerList;

            List<string> cameraList = new List<string>();
            cameraList.Add("Kamera1 ");
            cameraList.Add("Kamera2 ");

            ViewData["Kamera"] = cameraList;

            List<string> raportList = new List<string>();
            raportList.Add("Raport1 ");
            raportList.Add("Raport2 ");

            ViewData["Raport"] = raportList;

            List<string> klientList = new List<string>();
            klientList.Add("Klient1 ");
            klientList.Add("Klient2 ");

            ViewData["Klient"] = klientList;

            List<string> fakturaList = new List<string>();
            fakturaList.Add("Faktura1 ");
            fakturaList.Add("Faktura2 ");

            ViewData["Faktura"] = fakturaList;
            return View();
        }


        client mysql = new client(1);

        public ActionResult AddClient()
        {
            return View(mysql);
        }


















        /*
        public ActionResult Create()
        {
            return View();
        }
        private ApplicationDbContext db = new ApplicationDbContext();
        // POST: PersonalDetails/Create
        // To protect from overposting attacks, please enable the specific
        //properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="AutoId,FirstName,LastName,Age,Active")] PersonalDetail personalDetail)
        {
            if (ModelState.IsValid)
            {
                db.PersonalDetails.Add(personalDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personalDetail);
        }
    */
    }
}