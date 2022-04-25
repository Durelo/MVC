using System;
using Microsoft.AspNetCore.Mvc;
using Essai_WebApplicationMVC.Models;
using System.Linq;
namespace Essai_WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()//Vert, il  ouvre le bal
        {
            int hour = DateTime.Now.Hour;
            ViewBag.hour = DateTime.Now.Hour;
            ViewBag.secondes = DateTime.Now.Second;
            ViewBag.minutes = DateTime.Now.Minute;
            ViewBag.Greeting = hour < 12 ? "Bonjour, c'est un transfer" : "Bonsoir, c'est un transfer";

            return View("MyView");//Violette, la vrai activite commence
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {

            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)//Donne le vert pour enregistrer les informations
        {
            // TODO: store repsonse from guest
            Repository.AddResponse(guestResponse);//vert, pour l'ajout les paticipants
            return View("Confirmation", guestResponse);//vert, remerciement
        }
        //[HttpGet]
        //public ViewResult Confirmation()
        //{

        //    return View("Thanks");
        //}
        [HttpPost]
        public ViewResult Confirmation(GuestResponse guestResponseC)//Donne le vert pour enregistrer les informations
        {
            // TODO: store repsonse from guest
            Repository.AddResponse(guestResponseC);//vert, pour l'ajout les paticipants
            return View("Thanks", guestResponseC);//vert, remerciement
        }
       


        public ViewResult ListResponses()
        {


            return View(Repository.Responses.Where(r => r.WillAttend == true && r.Confirmation == true));
        }

        }
}