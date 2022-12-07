using Webmanager.WebREST.Models;
using Webmanager.WebREST.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RequestLib;

namespace RESTTEST.Controllers;

[ApiController]
[Route("[controller]")]
public class ConvertController : ControllerBase
{
    public ConvertController()
    {
        RequestLib.IRequests request;
        request = RequestFactory.CreateRequestsFactory("REQUEST");
    }



   

    // POST action
    [HttpPost]
    public IActionResult Create(Converts c)
    {
        Converted CO = ConvertService.Add(c);
        return CreatedAtAction(nameof(Create), new { value = CO.Value, uom = CO.Uom, annotation  = CO.Annotation }, CO);
    }
    

}