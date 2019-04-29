using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/shakespeareform")]
    public ActionResult ShakespeareForm() { return View(); }

    [Route("/shakespeareresult")]
    public ActionResult ShakespeareResult(string pluralnoun1, string place1, string noun1, string pluralnoun2, string noun2, string adjective1, string verb1, string number1, string adjective2, string bodypart1, string verb2)
    {
      MadLibVariable myMadLibVariable1 = new MadLibVariable();
      myMadLibVariable1.SetPluralNoun1(pluralnoun1);
      myMadLibVariable1.SetPlace1(place1);
      myMadLibVariable1.SetNoun1(noun1);
      myMadLibVariable1.SetPluralNoun2(pluralnoun2);
      myMadLibVariable1.SetNoun2(noun2);
      myMadLibVariable1.SetAdjective1(adjective1);
      myMadLibVariable1.SetVerb1(verb1);
      myMadLibVariable1.SetNumber1(number1);
      myMadLibVariable1.SetAdjective2(adjective2);
      myMadLibVariable1.SetBodyPart1(bodypart1);
      myMadLibVariable1.SetVerb2(verb2);
      return View(myMadLibVariable1);
    }

    [Route("/poeform")]
    public ActionResult PoeForm() { return View(); }

    [Route("/poeresult")]
    public ActionResult PoeResult(string adjective1, string adjective2, string adjective3, string noun1, string noun2, string pastverb1, string noun3, string noun4, string place1, string noun5)
    {
      MadLibVariable myMadLibVariable2 = new MadLibVariable();
      myMadLibVariable2.SetAdjective1(adjective1);
      myMadLibVariable2.SetAdjective2(adjective2);
      myMadLibVariable2.SetAdjective3(adjective3);
      myMadLibVariable2.SetNoun1(noun1);
      myMadLibVariable2.SetNoun2(noun2);
      myMadLibVariable2.SetPastVerb1(pastverb1);
      myMadLibVariable2.SetNoun3(noun3);
      myMadLibVariable2.SetNoun4(noun4);
      myMadLibVariable2.SetPlace1(place1);
      myMadLibVariable2.SetNoun5(noun5);
      return View(myMadLibVariable2);
    }
  }
}
