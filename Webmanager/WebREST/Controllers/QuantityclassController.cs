using Webmanager.WebREST.Models;
using Webmanager.WebREST.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RequestLib;

namespace RESTTEST.Controllers;

[ApiController]
[Route("[controller]")]
public class QuantityclassController : ControllerBase
{
    public QuantityclassController()
    {
        RequestLib.IRequests request;
        request = RequestFactory.CreateRequestsFactory("REQUEST");
    }





    // POST action
    [HttpPost("{BaseUnit}")]
    public IActionResult Create(string BaseUnit, Quantity Q)
    {
        AliasService.Add(BaseUnit.Replace('&', ' '), Q.Name.Replace('&', ' '));
        return CreatedAtAction(nameof(Create), new { name = Q.Name, baseunit = BaseUnit }, Q);
    }
    // PUT action
    [HttpPut("{UnitToRemoveFrom}")]
    public IActionResult Update(string UnitToRemoveFrom, Quantity Q)
    {


        AliasService.Update(UnitToRemoveFrom.Replace('&', ' '), Q.Name.Replace('&', ' '));

        return NoContent();
    }



}