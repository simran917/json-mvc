using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Data.SqlClient;
using System.Data.Entity;


namespace json_mvc.Controllers
{
    public class HomeController : Controller
    {
        public static async Task<List<item>> GetData()
        {
            HttpClient client = new HttpClient();
            var res = await client.GetAsync("http://localhost:7071/api/Function1");
            var data = await res.Content.ReadAsStringAsync();
            Newtonsoft.Json.Linq.JArray jarray = (Newtonsoft.Json.Linq.JArray)JsonConvert.DeserializeObject(data);
            List<item> itemlist = jarray.ToObject<List<item>>();
            return itemlist;
        }
        public IActionResult Index()
        {
            ViewBag.itemlist = GetData().Result;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(item Item)
        {
            ItemContext ctx = new ItemContext();
            ctx.items.Add(Item);
            ctx.SaveChanges();
            return View();

        }
        public IActionResult ViewItems()
        {
            ItemContext ctx = new ItemContext();
            List<item> itemlist = ctx.items.ToList<item>();
            ViewBag.itemlist = itemlist;
            return View();
        }

    }
}
