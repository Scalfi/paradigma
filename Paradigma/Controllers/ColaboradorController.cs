using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Paradigma.Data;
using Paradigma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paradigma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController : ControllerBase
    {
        private readonly DataContext _context;
        public ColaboradorController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("maioressalariopordepartamento")]
        public  async Task<IActionResult> Get() 
        {
            //Escreva uma consulta usando linguagem SQL para encontrar os colaboradores que tem o salário mais alto em cada um dos departamentos.

            //SELECT d.nome as departamento, co1.nome as pessoas, co1.salario
            // FROM colaborador co1
            //JOIN departamento d ON(d.id = co1.departamento_id)
            //WHERE salario in (SELECT max(salario) from colaborador group by departamento_id)
            //ORDER BY 3 DESC

            //Utilização consulta em linq

            var response = await _context.Colaboradores
                            .Select(a => new
                            {
                                Pessoa = a.Nome,
                                Departamento = a.GetDepartamento.Nome,
                                Salario = a.Salario
                            })
                            .Where(a => _context.Colaboradores.GroupBy(x => x.DepartamentoId).Select(g => g.Max(a => a.Salario)).ToList().Contains(a.Salario))
                            .OrderByDescending(a => a.Salario)
                            .ToListAsync();
            return Ok(response);
        }
    }

}
