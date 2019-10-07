using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller
    {
    

        [Route("/")]
        public ActionResult Form() { return View(); }

        [Route("/story")]
        public ActionResult Story(string name, string adjective1, string noun1, string pluralnoun1, string adjective2, string adjective3, string verbing1, string verbing2, string adjective4, string adjective5, string noun2, string pluralfood1, string bodypart, string adjective6, string vehicle, string pluralfood2, string pluralfood3, string alive1, string alive2, string adverb, string pluralnoun2)
        {
            MadlibsVariables myMadlibsVariables = new MadlibsVariables();
            myMadlibsVariables.Name = name;
            myMadlibsVariables.Adjective1 = adjective1;
            myMadlibsVariables.Noun1 = noun1;
            myMadlibsVariables.PluralNoun1 = pluralnoun1;
            myMadlibsVariables.Adjective2 = adjective2;
            myMadlibsVariables.Adjective3 = adjective3;
            myMadlibsVariables.VerbIng1 = verbing1;
            myMadlibsVariables.VerbIng2 = verbing2;
            myMadlibsVariables.Adjective4 = adjective4;
            myMadlibsVariables.Adjective5 = adjective5;
            myMadlibsVariables.Noun2 = noun2;
            myMadlibsVariables.PluralFood1 = pluralfood1;
            myMadlibsVariables.BodyPart = bodypart;
            myMadlibsVariables.Adjective6 = adjective6;
            myMadlibsVariables.Vehicle = vehicle;
            myMadlibsVariables.PluralFood2 = pluralfood2;
            myMadlibsVariables.PluralFood3 = pluralfood3;
            myMadlibsVariables.Alive1 = alive1;
            myMadlibsVariables.Alive2 = alive2;
            myMadlibsVariables.Adverb = adverb;
            myMadlibsVariables.PluralNoun2 = pluralnoun2;
            return View(myMadlibsVariables);
        }
    }
}