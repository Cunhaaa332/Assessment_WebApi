using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace WebMVC.Controllers
{
    public class AutorController : Controller
    {

        // GET: Autor
        public ActionResult Index()
        {
            var client = new RestClient();

            var request = new RestRequest("https://localhost:5001/api/autores", DataFormat.Json);
            var response = client.Get<List<Autor>>(request);

            return View(response.Data);
        }

        // GET: Autor/Details/5
        public ActionResult Details(int id)
        {
            var client = new RestClient();

            var request = new RestRequest("https://localhost:5001/api/autores/"+id, DataFormat.Json);
            var response = client.Get<Autor>(request);

            return View(response.Data);
        }

        // GET: Autor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Autor autor)
        {
            if (ModelState.IsValid) {
                var client = new RestClient();

                var request = new RestRequest("https://localhost:5001/api/autores", DataFormat.Json);
                request.AddJsonBody(autor);
                var response = client.Post<Autor>(request);
                return Redirect("/autor/index");
            }
            return BadRequest();

        }

        // GET: Autor/Edit/5
        public ActionResult Edit(int id)
        {
            var client = new RestClient();

            var request = new RestRequest("https://localhost:5001/api/autores/" + id, DataFormat.Json);
            var response = client.Get<Autor>(request);

            return View(response.Data);
        }

        // POST: Autor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Autor autorN)
        {
            try
            {
                var client = new RestClient();

                var request = new RestRequest("https://localhost:5001/api/autores/" + id, DataFormat.Json);
                request.AddJsonBody(autorN);
                var response = client.Put<Autor>(request);

                return Redirect("/autor/index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Autor/Delete/5
        public ActionResult Delete(int id)
        {
            var client = new RestClient();

            var request = new RestRequest("https://localhost:5001/api/autores/" + id, DataFormat.Json);
            var response = client.Get<Autor>(request);

            return View(response.Data);
        }

        // POST: Autor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var client = new RestClient();

                var request = new RestRequest("https://localhost:5001/api/autores/" + id, DataFormat.Json);
                var response = client.Delete<Autor>(request);

                return Redirect("/autor");
            }
            catch
            {
                return View();
            }
        }
    }
}