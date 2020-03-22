using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prj_GestionPDC_OASG.Entities
{
    public class Departamento
    {
        public Departamento()
        {
            Ciudad = new HashSet<Ciudad>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Codigo { get; set; }

        [Display(Name ="Pais")]
        public int Pais_Id { get; set; }

        public bool Active { get; set; }

        public virtual ICollection<Ciudad> Ciudad { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
