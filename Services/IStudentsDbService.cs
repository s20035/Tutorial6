using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace APBDTUT3.Services
{
    interface IStudentsDbService
    {
        public IActionResult enroll();

        public IActionResult promote();
    }
}
