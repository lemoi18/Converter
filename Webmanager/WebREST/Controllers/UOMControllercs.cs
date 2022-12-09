using Webmanager.WebREST.Models;
using Webmanager.WebREST.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RequestLib;
using Microsoft.Extensions.Hosting;
using System.Xml.Linq;

namespace RESTTEST.Controllers;


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
        UOMService.Delete(Name);

        return NoContent();
    }
}