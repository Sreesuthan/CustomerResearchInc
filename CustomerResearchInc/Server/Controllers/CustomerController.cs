using CustomerResearchInc.Shared;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using SelectPdf;

namespace CustomerResearchInc.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly IConfiguration _config;
		private readonly IWebHostEnvironment _env;

		public CustomerController(IConfiguration config, IWebHostEnvironment env)
		{
			_config = config;
			_env = env;
		}


		[HttpGet]
		public async Task<ActionResult<Customer>> GetCustomers()
		{
			using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
			IEnumerable<Customer> customers = await connection.QueryAsync<Customer>("Select Row_Number() over(order by (select 1)) as [SrNo], c.Id, c.FirstName, c.LastName, c.LaborType, c.Advisor, c.Technician, c.VINno, c.Vehicle, c.CallCenterAgent, c.Date, c.TelePhone, c.OvarallCSI, c.CustNo, s.Comments from Customers as c inner join Surveys as s on c.Id = s.CusId");
			return Ok(customers);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Customer>> GetCustomer(int id)
		{
			using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
			var customer = await connection.QueryFirstAsync<Customer>("Select Row_Number() over(order by (select 1)) as [SrNo], c.Id, c.FirstName, c.LastName, c.LaborType, c.Advisor, c.Technician, c.VINno, c.Vehicle, c.CallCenterAgent, c.Date, c.TelePhone, c.OvarallCSI, c.CustNo, s.Q1, s.Q2, s.Q3, s.Q4, s.Q5, s.Q6, s.Q7, s.Q8, s.Q9, s.Comments from Customers as c inner join Surveys as s on c.Id = s.CusId where c.Id = @Id", new { Id = id});
			return Ok(customer);
		}

		[HttpPost("exporttoexcel")]
		public IActionResult ExportToExcel(List<Customer_Export> customer_Exports)
		{
			var stream = new MemoryStream();

			using (var package = new ExcelPackage(stream))
			{
				var workSheet = package.Workbook.Worksheets.Add("Sheet1");
				workSheet.Cells.LoadFromCollection<Customer_Export>(customer_Exports, true);
				package.Save();
			}
			stream.Position = 0;
			string excelName = $"Customers_{DateTime.Now.ToString("dd-MM-yyyy hhmmss")}.xlsx";

			return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
		}

		[HttpPost("pdf")]
		public IActionResult GenaratePdf(List<Customer_Export> customer_Exports)
		{
			string fileName = "";

			HtmlToPdf HtmlToPdf = new HtmlToPdf();
			PdfDocument document = HtmlToPdf.ConvertHtmlString(CreateBody(customer_Exports));

			byte[]? response = null;
			using (MemoryStream ms = new MemoryStream())
			{
				document.Save(ms);
				response = ms.ToArray();
				document.Close();

				ms.Position = 0;
			}
			fileName = $"CustomersReport_{DateTime.Now.ToString("dd-MM-yyyy hhmmss")}.pdf";

			return File(response, "application/pdf", fileName);
		}

		private string CreateBody(List<Customer_Export> customer_Exports)
		{
			var Body1 = System.IO.File.ReadAllText(Path.Combine(_env.ContentRootPath, "ReportTemplate", "ReportPage1.html"));
			Body1 = Body1.Replace("{date1}", DateTime.Now.ToShortDateString());
			var tableBody = "";
			foreach (var customer in customer_Exports)
			{
				var Body2 = System.IO.File.ReadAllText(Path.Combine(_env.ContentRootPath, "ReportTemplate", "ReportPage2.html"));
				Body2 = Body2.Replace("{date2}", customer.Date.ToShortDateString());
				Body2 = Body2.Replace("{status}", (customer.Comments == "" ? "Completely Satisfied" : "Comment"));
				Body2 = Body2.Replace("{type}", customer.LaborType);
				Body2 = Body2.Replace("{csi}", customer.OvarallCSI.ToString());
				Body2 = Body2.Replace("{telephone}", customer.TelePhone.ToString());
				Body2 = Body2.Replace("{firstname}", customer.FirstName);
				Body2 = Body2.Replace("{lastname}", customer.LastName);
				tableBody = tableBody + Body2;
			}
			var Body3 = System.IO.File.ReadAllText(Path.Combine(_env.ContentRootPath, "ReportTemplate", "ReportPage3.html"));

			var newBody = Body1 + tableBody + Body3;
			return newBody;
		}
	}
}
