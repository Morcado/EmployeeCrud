﻿using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud.API.Controllers
{
 
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

    }
    
}