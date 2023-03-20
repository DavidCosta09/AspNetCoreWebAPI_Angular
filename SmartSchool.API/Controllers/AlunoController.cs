using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "David",
                Sobrenome = "Costa",
                Telefone = "12315346"
            },

            new Aluno()
            {
                Id = 2,
                Nome = "Deborah",
                Sobrenome = "Neco",
                Telefone = "12315346"
            },

            new Aluno()
            {
                Id = 3,
                Nome = "Gabriel",
                Sobrenome = "Neco",
                Telefone = "12315346"
            }

        };

        public AlunoController() { }


        // GET: api/<AlunoController>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        // GET api/<AlunoController>/5
        [HttpGet("ById/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);

            if (aluno == null)
            {
                return BadRequest("O Aluno não foi encontrado!");
            }

            return Ok(aluno);
        }

        // api/aluno/nome
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));

            if (aluno == null)
            {
                return BadRequest("O Aluno não foi encontrado!");
            }

            return Ok(aluno);
        }

        // POST api/<AlunoController

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }


        // PUT api/<AlunoController>/5

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        { 
            return Ok(aluno); 
        }
        
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        { 
            return Ok(aluno); 
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
