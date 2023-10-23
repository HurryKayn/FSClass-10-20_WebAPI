using ApiGuest.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace ApiGuest.Controllers
{
    public class HomeController : Controller
    {
    
        private const string portaServer= "7133";
        //private const string portaServer= "5105";
        
        public async Task<IActionResult> Index()
        {
            var lista = new List<GiocatoreBasketAmatoriale>();
            using(HttpClient client = new HttpClient())
            {
                using (var res = await client.GetAsync(GetUrl()+""))
                {
                    string risposta = await res.Content.ReadAsStringAsync();
                    lista = JsonConvert.DeserializeObject<List<GiocatoreBasketAmatoriale>>(risposta);
                }
            }
            return View(lista);
        }
        [HttpGet]
        public ViewResult GetGiocatore()
        {
            return View();
        }

        [HttpPost]
        public async Task <ViewResult> GetGiocatore(int id)
        {
            var player = new GiocatoreBasketAmatoriale();

            using(HttpClient client = new HttpClient())
            {
                using(var res = await client.GetAsync(GetUrl()+"/"+id))
                {
                    if (res.StatusCode==System.Net.HttpStatusCode.OK) 
                    {
                        string risposta = await res.Content.ReadAsStringAsync();
                        player=JsonConvert.DeserializeObject<GiocatoreBasketAmatoriale>(risposta);
                    }
                }
            }
            return View(player);
        }
        private string GetUrl()
        {
            return $"https://localhost:{portaServer}/api/player";
        }

    }
}