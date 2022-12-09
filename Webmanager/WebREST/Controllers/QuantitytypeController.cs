using Webmanager.WebREST.Models;
using Webmanager.WebREST.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RequestLib;

namespace RESTTEST.Controllers;

[ApiController]
[Route("[controller]")]
public class QuantitytypeController : ControllerBase
{
    public QuantitytypeController()
    {
        RequestLib.IRequests request;
        request = RequestFactory.CreateRequestsFactory("REQUEST");
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Quantitytype>> GetAll() =>
    QuantitytypeService.GetAll();

    // GET by Id action
    [HttpGet("{Name}")]
    public ActionResult<List<Quantityclass>> Get(string Name)
    {
        var QC = QuantitytypeService.Get(Name);

        if (QC == null)
            return NotFound();

        return QC;
    }

    // POST action
    [HttpPost]
    public IActionResult Create(QuantityA qa)
    {
        QuantitytypeService.Add(qa);
        return CreatedAtAction(nameof(Create), new { name = qa.Name }, qa);
    }

    [HttpPut("{UnitToRemoveFrom}")]
    public IActionResult Update(string UnitToRemoveFrom, Quantity Q)
    {


        QuantitytypeService.Update(UnitToRemoveFrom.Replace('&', ' '), Q.Name.Replace('&', ' '));

        return NoContent();
    }


}
