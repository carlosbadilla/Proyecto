using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Modelo_Registro
    {
        [Required(ErrorMessage = "¡Complete este campo!")]
        public int Registro_Id { get; set; }
        [Required(ErrorMessage = "¡Complete este campo!")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "¡Complete este campo!")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "¡Complete este campo!")]
        public string Contraseña { get; set; }
    }
}
