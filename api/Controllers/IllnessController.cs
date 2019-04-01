using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using health_record_app.Models;

namespace health_record_app.Controllers {
    [Route("api/books")]
    [ApiController]
    public class IllnessController : ControllerBase {
            private readonly HealthRecordAppContext db;
    }
}