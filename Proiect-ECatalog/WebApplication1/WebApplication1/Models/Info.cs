using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Info
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Numele trebuie completat!")]
        public string Nume { get; set; }
        [Required(ErrorMessage = "Prenumele trebuie completat!")]
        public string Prenume { get; set; }
        [Required]
        [Range(1,10, ErrorMessage="Nota trebuie sa fie cuprinsa intre 1 si 10!")]
        public int? Nota1 { get; set; }
        [Range(1, 10, ErrorMessage = "Nota trebuie sa fie cuprinsa intre 1 si 10!")]
        public int? Nota2 { get; set; }
        [Range(1, 10, ErrorMessage = "Nota trebuie sa fie cuprinsa intre 1 si 10!")]
        public int? Nota3 { get; set; }
        [Range(1, 10, ErrorMessage = "Nota trebuie sa fie cuprinsa intre 1 si 10!")]
        public int? Teza { get; set; }
    }
}
