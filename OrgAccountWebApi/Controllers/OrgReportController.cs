using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrgAccount.Repository;
using OrgAccountWebApi.ApplicationServices;

namespace OrgAccountWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/OrgReport")]
    public class OrgReportController : Controller
    {
        private IOrgAccountRepository _orgAccountRepository;

        public OrgReportController(IOrgAccountRepository orgAccountRepository)
        {
            _orgAccountRepository = orgAccountRepository;
        }
        [HttpGet("List")]
        public ActionResult OrgReportList(string ID)
        {
            _orgAccountRepository.OrgReportFeeList(ID);
            return null;
        }
        [HttpGet("SalaryMatrix")]
        public ActionResult OrgSalaryMatrix(string ID)
        {
            var result = ConverterHelper.OrgReportToSalaryMatrix(_orgAccountRepository.OrgReportList(ID));
            return Ok(result);
        }
    }
}