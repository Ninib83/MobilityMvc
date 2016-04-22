using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobilityMvc.ViewModels
{
    public class RegistrationViewModel
    {

        [Display(Name = "Användarnamn")]
        [Required(ErrorMessage = "Ange Ett Användarnamn")]
        public string UserName { get; set; }

        [Display(Name = "Lösenord")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Ange ett lösenord")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekräfta lösenordet")]
        [Compare("Password", ErrorMessage = "Lösenordet matchar inte!.")]
        public string ConfirmPassword { get; set; }

    }
}
