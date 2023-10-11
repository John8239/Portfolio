using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using Portfolio.Enums;

namespace Portfolio.Pages
{
    public class AboutYouFormModel : PageModel
    {
        [DisplayName("First Name")]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime? BirthDate { get; set; }

        [DisplayName("Job Title")]
        public string? JobTitle { get; set; }

        [DisplayName("Salary")]
        public double? Salary { get; set; }

        [DisplayName("Car Make")]
        public Enumerations.CarMake? CarMake { get; set; }

        public List<SelectListItem> CarMakeList = Enumerations.GetAllCarMakes();

        [DisplayName("Favorite Game")]
        public string? FavoriteGame { get; set; }

        [DisplayName("Favorite Movie")]
        public string? FavoriteMovie { get; set; }

        [DisplayName("Favorite Book")]
        public string? FavoriteBook { get; set; }

        [DisplayName("Pets")]
        public bool? Pets { get; set; }

        [DisplayName("How Many Pets")]
        public int? NumberOfPets { get; set; }

        public AboutYouFormModel()
        {

        }

        public void OnGet()
        {

        }

        public void OnPostFormSubmit(AboutYouFormModel model)
        {
            Console.WriteLine(model.FirstName);
        }
    }
}

