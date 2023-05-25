using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Login
    {           
        [Key]   
        public int LoginId { get; set; }
        [Required (ErrorMessage = "Debe ingresar un usuario")]
        [Display (Prompt = "Ingrese nombre de usuario")]                
        public string Usuario { get; set; }
        [Required (ErrorMessage = "Debe ingresar una contraseña")]               
        public string Password { get; set; }
        

    }
}