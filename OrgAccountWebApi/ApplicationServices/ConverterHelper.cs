using OrgAccount.Domain;
using OrgAccountWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgAccountWebApi.ApplicationServices
{
    public static class ConverterHelper
    {
        public static OrgSalaryMatrixModel OrgReportToSalaryMatrix(OrgReport orgReport)
        {
            if (orgReport == null)
                return null;
            var matrix = new OrgSalaryMatrixModel()
            {
                Benefic = orgReport.Insuree,
                Org = orgReport.Org,
                CalYear = orgReport.Year,
                Salary1 = orgReport.Month == 1 ? orgReport.Salary : 0,
                Salary2 = orgReport.Month == 2 ? orgReport.Salary : 0,
                Salary3 = orgReport.Month == 3 ? orgReport.Salary : 0,
                Salary4 = orgReport.Month == 4 ? orgReport.Salary : 0,
                Salary5 = orgReport.Month == 5 ? orgReport.Salary : 0,
                Salary6 = orgReport.Month == 6 ? orgReport.Salary : 0,
                Salary7 = orgReport.Month == 7 ? orgReport.Salary : 0,
                Salary8 = orgReport.Month == 8 ? orgReport.Salary : 0,
                Salary9 = orgReport.Month == 9 ? orgReport.Salary : 0,
                Salary10 = orgReport.Month == 10 ? orgReport.Salary : 0,
                Salary11 = orgReport.Month == 11 ? orgReport.Salary : 0,
                Salary12 = orgReport.Month == 12 ? orgReport.Salary : 0,
            };
            return matrix;
        }
        public static List<OrgSalaryMatrixModel> OrgReportToSalaryMatrix(List<OrgReport> orgReport)
        {
            if (orgReport == null)
                return null;
            var list = new List<OrgSalaryMatrixModel>();
            foreach(var r in orgReport)
            {
                list.Add(OrgReportToSalaryMatrix(r));
            }
            return list;
        }
    }
}
