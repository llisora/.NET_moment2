using System.ComponentModel.DataAnnotations;
namespace GamesMvc.Models
{
    public class GameModel
    {
        //Properties

        [Required(ErrorMessage = "Ange en korrekt titel")]
        [Display(Name = "Titel:")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Välj en konsoll!")]
        [Display(Name = "Konsol:")]
        public string? Console { get; set; }
        [Required(ErrorMessage = "Välj ett betyg!")]
        [Display(Name = "Betyg (1-10):")]
        public string? Rating { get; set; }

        [Required(ErrorMessage = "Välj ja eller nej!")]
        public string? Recommend { get; set; }
    }
}