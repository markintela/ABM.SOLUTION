using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.ABM.Context;
using WEBAPI.ABM.Models;
using System.Xml;
using System.Net;
using ABM.API.LIBRARY.BUSINESS;

namespace WEBAPI.ABM.Controllers
{

    [Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json", "application/json-patch+json", "multipart/form-data")]
    [ApiController]
    public class XmlFileController : ControllerBase
    {

        private readonly XmlFileContext _context;


        /* VERBS */
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            return new string[] { "NO FILES, USE A TOOL TO SEND DOCUMENTS" };
        }


        [HttpPost]
        public async Task<IActionResult> Post(IFormFile file)
        {


            if (file == null && file.Length == 0)
            {

                return Content("FILE NOT FOUND");

            }
            else
            {

                var stream = file.OpenReadStream();
                var name = file.FileName;
                var tam = file.Length;
                XElement xmlElement = XElement.Load(stream);
                Business business = new Business();
                string message = business.ResponseXml(xmlElement);

    

                return StatusCode((int)HttpStatusCode.OK , message);

            }   


            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

          
        }
    }
}
