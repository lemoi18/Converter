using Webmanager.WebREST.Models;
using Webmanager.WebREST.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RequestLib;
using Microsoft.Extensions.Hosting;
using System.Xml.Linq;

namespace RESTTEST.Controllers;

[ApiController]
[Route("[controller]")]
public class UOMController : ControllerBase
{
    public UOMController()
    {
        RequestLib.IRequests request;
        request = RequestFactory.CreateRequestsFactory("REQUEST");
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<UOM>> GetAll() =>
    UOMService.GetAll();

    // GET by Id action
    [HttpGet("{Name}")]
    public ActionResult<UOM> Get(string Name)
    {
        var uom = UOMService.Get(Name);

        if (uom == null)
            return NotFound();

        return uom;
    }

    // POST action
    [HttpPost]
    public IActionResult Create(UOM uom)
    {

        
        UOMService.Add(uom);
        return CreatedAtAction(nameof(Create), new { name = uom.Name }, uom);
    }
    // PUT action
    [HttpPut("{NameOfUnitToChange}")]
    public IActionResult Update(string NameOfUnitToChange, UOM_Update uom)
    {
        
        UOMService.Update(NameOfUnitToChange, uom);

        return NoContent();
    }
    // DELETE action
    [HttpDelete("{Name}")]
    public IActionResult Delete(string Name)
    {
        var Uom = UOMService.Get(Name);

        if (Uom is null)
            return NotFound();

        UOMService.Delete(Name);

        return NoContent();
    }
}