using BlazorCertificate.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorCertificate.Server.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("")]
        public IActionResult Get()
        {
            List<Question> questions = new List<Question>() {
                new Question
                {
                    Id = 1,
                    QuestionTitle = "Quem eh o criador do Blazor?",
                    Answer1 = "Bill Gates",
                    Answer2 = "Steve Sanderson",
                    Answer3 = "Eduardo Pires",
                    Answer4 = "Elon Musk",
                    SourceUrl = "https://github.com/raffacabofrio",
                },
                new Question
                {
                    Id = 1,
                    QuestionTitle = "Qual o objetivo do Blazor?",
                    Answer1 = "Jogos",
                    Answer2 = "Aplicações web",
                    Answer3 = "Cliente de Banco de dados",
                    Answer4 = "Transmissão via satélite",
                    SourceUrl = "https://www.lambda3.com.br/2018/03/lambda3-podcast-86-blazor/",
                },
                new Question
                {
                    Id = 1,
                    QuestionTitle = "Em que estágio se encontra Blazor?",
                    Answer1 = "Projeto caseiro",
                    Answer2 = "Projeto experimental oficial MS",
                    Answer3 = "Release Candidate",
                    Answer4 = "Production Stable",
                    SourceUrl = "https://blazor.net/",
                }
            };

            // quero ver o loading.
            Thread.Sleep(2000);

            return Ok(questions);
        }
    }
}
