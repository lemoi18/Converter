using RESTTEST.Models;
using RESTTEST.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace RESTTEST.Controllers;

[ApiController]
[Route("[controller]")]
public class UnitDimensionController : ControllerBase
{
    public UnitDimensionController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<UnitDimension>> GetAll() =>
    UnitDimensionService.GetAll();

    [HttpGet("{Name}")]
    public ActionResult<UnitDimension> Get(string Name)
    {
        var unitdimension = UnitDimensionService.Get(Name);

        if (unitdimension == null)
            return NotFound();

        return unitdimension;
    }
    // GET by Id action

    // POST action

    // PUT action

    // DELETE action
}