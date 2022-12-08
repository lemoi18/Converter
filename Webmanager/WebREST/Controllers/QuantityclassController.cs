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
    [HttpPost("{Unit}")]
    public IActionResult Create(string Unit, Quantity Q)
    {
        Console.WriteLine(Q.Name);
        AliasService.Add(Unit.Replace('&', ' '), Q.Name.Replace('&', ' '));
        return CreatedAtAction(nameof(Create), new { name = Q.Name, baseunit = Unit }, Q);
    }
    // PUT action
    [HttpPut("{UnitToRemoveFrom}")]
    public IActionResult Update(string UnitToRemoveFrom, Quantity Q)
    {


        AliasService.Update(UnitToRemoveFrom.Replace('&', ' '), Q.Name.Replace('&', ' '));

        return NoContent();
    }



}