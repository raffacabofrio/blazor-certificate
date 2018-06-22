using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorCertificate.Shared;
using System.Net.Http;
using Newtonsoft.Json;

namespace BlazorCertificate.Server.Controllers
{
    [Route("api/Diary")]
    public class DiaryController : Controller
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            // A parte de diário está hospedado num CMS multi tenant chamado MKTE.
            // Isso nos poupa de criar um CRUD com essa finalidade.

            var httpClient = new HttpClient();
            var json = httpClient.GetStringAsync("http://www.wservices.srv.br/public/webservices/blazor/index.php").Result;
            var diario = JsonConvert.DeserializeObject<List<Diary>>(json);

            return Ok(diario);
        }

    }
}