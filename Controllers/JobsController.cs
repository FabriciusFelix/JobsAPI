using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiJobs.Data;
using ApiJobs.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiJobs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobsDbContext _db;
        public JobsController(JobsDbContext db){
            _db = db;
        }

        [HttpGet]
        public IActionResult GetJobs(){
            var getJobs = _db.Jobs.ToList();    

            return Ok(getJobs);
                
        }
        //{"id":1,"nome":"Vaga .net C# com React","descricao":"Nova Vaga para Dev JR","local":"remoto","ativo":true,"salario":4000}
        [HttpPost]
        public IActionResult PostJob(Job input){
            var  novoJob = _db.Jobs.Add(input);   
            _db.SaveChanges();

            return Created();
                
        }
    }
}