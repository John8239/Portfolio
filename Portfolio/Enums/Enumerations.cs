using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Portfolio.Enums
{
    public class Enumerations
    {
        public enum CarMake
        {
            [Display(Name = "Audi")]
            Audi,
            [Display(Name = "BMW")]
            BMW,
            [Display(Name = "Buick")]
            Buick,
            [Display(Name = "Cadillac")]
            Cadillac,
            [Display(Name = "Chrysler")]
            Chrysler,
            [Display(Name = "Chevrolet")]
            Chevrolet,
            [Display(Name = "Dodge")]
            Dodge,
            [Display(Name = "Ford")]
            Ford,
            [Display(Name = "General Motors")]
            GeneralMotors,
            [Display(Name = "Honda")]
            Honda,
            [Display(Name = "Hyundai")]
            Hyundai,
            [Display(Name = "Jeep")]
            Jeep,
            [Display(Name = "Kia")]
            Kia,
            [Display(Name = "Lexus")]
            Lexus,
            [Display(Name = "Mazada")]
            Mazda,
            [Display(Name = "Mercedes-Benz")]
            MercedesBenz,
            [Display(Name = "Nissan")]
            Nissan,
            [Display(Name = "Subaru")]
            Subaru,
            [Display(Name = "Tesla")]
            Tesla,
            [Display(Name = "Toyota")]
            Toyota,
            [Display(Name = "Volkswagen")]
            Volkswagen
        }

        public enum SheetMusic
        {
            [Display(Name = "Moment Musiceaux no. 3")]
            momentMusiceaux3,
            [Display(Name = "March Slav")]
            marchSlav,
            [Display(Name = "Fugue")]
            fugue,
            [Display(Name = "My Native Land")]
            myNativeLand,
            [Display(Name = "Nocturne no. 1 (Nostalgia)")]
            nocturneNostalgia,
            [Display(Name = "Nocturne no. 2 (Calm)")]
            nocturneCalm,
            [Display(Name = "Rhapsody no.1")]
            rhapsody1,
            [Display(Name = "Rhapsody no.2 (Rhap-Sonata)")]
            rhapsody2,
            [Display(Name = "Sonatina (The Carnival)")]
            sonatinaCarnival,
            [Display(Name = "Thank You (For Sung)")]
            thankYou
        }

        public static List<SelectListItem> GetAllCarMakes()
        {
            List<CarMake> carMakeList = Enum.GetValues(typeof(CarMake)).Cast<CarMake>().ToList();
            List<SelectListItem> carMakeSelectList = new List<SelectListItem>();

            foreach (var make in carMakeList)
            {
                carMakeSelectList.Add(new SelectListItem
                {
                    Text = make.GetType().GetMember(make.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName(),
                    Value = make.ToString()
                });
            }

            return carMakeSelectList;
        }

        public static string GetSheetMusicDisplayName(SheetMusic sheet)
        {
            string sheetName = sheet.GetType().GetMember(sheet.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName();

            return sheetName;
        }
    }
}
