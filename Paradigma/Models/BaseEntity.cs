using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Paradigma.Models
{
    public class BaseEntity
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("id")]
        public int Id { get; set; }
    }
}
