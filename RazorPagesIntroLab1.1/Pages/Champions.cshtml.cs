using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesIntroLab1._1.Pages
{
    public class ChampionsModel : PageModel
    {
        public class ChampionViewModel //View model ett s�kert s�tt att skicka data till vyn
                                       //vyn �r enbart f�r att visa data och ska inte inneh�lla n�gon logik
        {
            public int Id { get; set; } //Id �r en unik identifierare f�r varje champion
            public string Name { get;set; } //Name �r en public string objekt som inneh�ller namnet p� en champion
            public int Damage { get; set; }
        }
        public List<ChampionViewModel> Champions { get; set; } = new();// En lista av ChampionViewModel objekt
        public void OnGet() // GET f�rfr�gan, funktion som k�rs n�r sidan laddas
        {
            //Adds 3 champions to the Champions list
            Champions.Add(new ChampionViewModel
            {
                Id = 1, Name="Annie", Damage = 100,
            });
            Champions.Add(new ChampionViewModel
            {
                Id = 2,
                Name = "Brand",
                Damage = 110,

            });
            Champions.Add(new ChampionViewModel
            {
                Id = 3, Name = "Calista", Damage = 130,

            });
        }
    }
}
