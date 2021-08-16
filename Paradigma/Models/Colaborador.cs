using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Paradigma.Models
{
    [Table("colaborador")]
    public class Colaborador :  BaseEntity
    {
   

        [Column("salario")]
        public Decimal  Salario{ get; set; }

        [Column("departamento_id")]
        [ForeignKey(nameof(Departamento))]
        public int DepartamentoId{ get; set; }

        public Departamento GetDepartamento { get; set; }
    }
}
