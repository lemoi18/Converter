using Webmanager.WebREST.Models;
using Webmanager.WebREST.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RequestLib;

namespace RESTTEST.Controllers;


    [ApiController]
    [Route("[controller]")]
    public class AliasController : ControllerBase
    {
        public AliasController()
        {
            RequestLib.IRequests request;
            request = RequestFactory.CreateRequestsFactory("REQUEST");
        }



        // GET by Id action
        [HttpGet("{Name}")]
        public ActionResult<List<Alias>> Get(string Name)
        {
            var Al = AliasService.Get(Name);

            if (Al == null)
                return NotFound();

            return Al;
        }

        // POST action
        [HttpPost("{Unit}")]
        public IActionResult Create(string Unit, Alias al)
        {
            AliasService.Add(Unit, al.Name);
            return CreatedAtAction(nameof(Create), new { name = al.Name }, al);
        }


    }
