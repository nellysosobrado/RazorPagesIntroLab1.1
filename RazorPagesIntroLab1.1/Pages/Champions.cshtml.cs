using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesIntroLab1._1.Pages
{
    public class ChampionsModel : PageModel
    {
        public class ChampionViewModel //View model ett säkert sätt att skicka data till vyn
                                       //vyn är enbart för att visa data och ska inte innehålla någon logik
        {
            public int Id { get; set; } //Id är en unik identifierare för varje champion
            public string Name { get;set; } //Name är en public string objekt som innehåller namnet på en champion
            public int Damage { get; set; }
        }
        public List<ChampionViewModel> Champions { get; set; } = new();// En lista av ChampionViewModel objekt
        public void OnGet() // GET förfrågan, funktion som körs när sidan laddas
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
