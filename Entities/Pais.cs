using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prj_GestionPDC_OASG.Entities
{
    public class Pais
    {
        public Pais()
        {
            Departamento = new HashSet<Departamento>();
        }

        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string  Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Codigo { get; set; }

        public bool Active { get; set; }
        public virtual ICollection<Departamento> Departamento { get; set; }
    }
}
