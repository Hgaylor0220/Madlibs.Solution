using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller
    {

        public static MadlibsVariables Madlibs { get; set; }
       

        [Route("/")]
        public ActionResult Form() { return View(); }

        [Route("/story")]
        public ActionResult Story(string name, string adjective1, string noun1, string pluralnoun1, string adjective2, string adjective3, string verbing1, string verbing2, string adjective4, string adjective5, string noun2, string pluralfood1, string bodypart1, string adjective6, string vehicle, string pluralfood2, string pluralfood3, string alive1, string alive2, string adverb, string pluralnoun2, string bodypart2, string number,string sillyword, string verb1,string verb2, string verb3, string pluralbodypart)
        {
            Madlibs = new MadlibsVariables();
            Madlibs.Name = name;
            Madlibs.Adjective1 = adjective1;
            Madlibs.Noun1 = noun1;
            Madlibs.PluralNoun1 = pluralnoun1;
            Madlibs.Adjective2 = adjective2;
            Madlibs.Adjective3 = adjective3;
            Madlibs.VerbIng1 = verbing1;
            Madlibs.VerbIng2 = verbing2;
            Madlibs.Adjective4 = adjective4;
            Madlibs.Adjective5 = adjective5;
            Madlibs.Noun2 = noun2;
            Madlibs.PluralFood1 = pluralfood1;
            Madlibs.BodyPart1 = bodypart1;
            Madlibs.Adjective6 = adjective6;
            Madlibs.Vehicle = vehicle;
            Madlibs.PluralFood2 = pluralfood2;
            Madlibs.PluralFood3 = pluralfood3;
            Madlibs.Alive1 = alive1;
            Madlibs.Alive2 = alive2;
            Madlibs.Adverb = adverb;
            Madlibs.PluralNoun2 = pluralnoun2;
            Madlibs.BodyPart2 = bodypart2;
            Madlibs.Number = number;
            Madlibs.Verb1 = verb1;
            Madlibs.Verb2 = verb2;
            Madlibs.Verb3 = verb3;
            Madlibs.PluralBodyPart = pluralbodypart;
            Madlibs.SillyWord = sillyword;
            return View();
        }


        [Route("/bears")]
        public ActionResult Bears()
        {
            return View(Madlibs);
        }

        [Route("/museum")]
        public ActionResult Museum()
        {
            return View(Madlibs);
        }
    }
}