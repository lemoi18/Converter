using Webmanager.WebREST.Models;
using Webmanager.WebREST.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RequestLib;

namespace RESTTEST.Controllers;

[ApiController]
[Route("[controller]")]
public class UnitDimensionController : ControllerBase
{
    public UnitDimensionController()
    {
        RequestLib.IRequests request;
        request = RequestFactory.CreateRequestsFactory("REQUEST");
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<UnitDimension>> GetAll() => 
    UnitDimensionService.GetAll();

    // GET by Id action
    [HttpGet("{Symbol}")]
    public ActionResult<UnitDimension> Get(string Symbol)
    {
        
        var unitdimension = UnitDimensionService.Get(Symbol);
        
        if (unitdimension == null)
            return NotFound();

        return unitdimension;
    }

    // POST action
    [HttpPost]
    public IActionResult Create(UnitDimension unitDimension)
    {
        UnitDimensionService.Add(unitDimension);
        return CreatedAtAction(nameof(Create), new { symbol = unitDimension.Symbol }, unitDimension);
    }
    // PUT action
    [HttpPut("{Symbol}")]
    public IActionResult Update(string Symbol, UnitDimension unitDimension)
    {
        
        var existingUD = UnitDimensionService.Get(Symbol);
        if (existingUD is null)
            return NotFound();

        UnitDimensionService.Update(Symbol, unitDimension);

        return NoContent();
    }
    // DELETE action
    [HttpDelete("{Symbol}")]
    public IActionResult Delete(string Symbol)
    {
        var UD = UnitDimensionService.Get(Symbol);

        if (UD is null)
            return NotFound();

        UnitDimensionService.Delete(Symbol);

        return NoContent();
    }
}