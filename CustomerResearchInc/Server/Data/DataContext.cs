using CustomerResearchInc.Shared;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Survey> Surveys { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>().HasData(
				new Customer { Id = 1, Advisor = "Bobby Eskey", CallCenterAgent = "", CustNo = 1, Date = DateTime.Now, FirstName = "DONNA", LastName = "BRAZALOVICH", LaborType= "Warranty", OvarallCSI= 100.0m, Technician="", TelePhone= 8604500709, Vehicle= "2016 KIA SORENTO", VINno= "5XYPGDA32GG169581" },
				new Customer { Id = 2, Advisor = "Brian Roush", CallCenterAgent = "", CustNo = 2, Date = DateTime.Now, FirstName = "DENISE", LastName = "ROMAN", LaborType = "Warranty", OvarallCSI = 66.7m, Technician = "", TelePhone = 8602167672, Vehicle = "2020 KIA SPORTAGE", VINno = "KNDP6CAC3L7712568" },
				new Customer { Id = 3, Advisor = "Fernamdo Cruz", CallCenterAgent = "", CustNo = 3, Date = DateTime.Now, FirstName = "SELIN", LastName = "SCHILBERG", LaborType = "Warranty", OvarallCSI = 40.0m, Technician = "", TelePhone = 8609900867, Vehicle = "2023 KIA TELLURID", VINno = "5XYP3DGC3PG330569" },
				new Customer { Id = 4, Advisor = "Fernamdo Cruz", CallCenterAgent = "", CustNo = 4, Date = DateTime.Now, FirstName = "SARAH", LastName = "LATHROP", LaborType = "Warranty", OvarallCSI = 83.3m, Technician = "", TelePhone = 8603016339, Vehicle = "2023 KIA SORENTO", VINno = "KNDRHDLG9P5170080" },
				new Customer { Id = 5, Advisor = "Brian Roush", CallCenterAgent = "", CustNo = 5, Date = DateTime.Now, FirstName = "MARGARET", LastName = "JACOBSON", LaborType = "Warranty", OvarallCSI = 83.3m, Technician = "", TelePhone = 8602679936, Vehicle = "2011 KIA OPTIMA H", VINno = "KNAGM4A71B5096410" },
				new Customer { Id = 6, Advisor = "Joe Berube", CallCenterAgent = "", CustNo = 6, Date = DateTime.Now, FirstName = "JOSEPH", LastName = "SCHULTZ", LaborType = "Warranty", OvarallCSI = 83.3m, Technician = "", TelePhone = 8608107098, Vehicle = "2022 KIA SORENTO", VINno = "KNDRG4LG5N5084281" }
				);

			modelBuilder.Entity<Survey>().HasData(
				new Survey { Id = 1, CusId = 1, Q1 = true, Q2 = false, Q3 = false, Q4 = false, Q5 = false, Q6 = true, Q7 = false, Q8 = false, Q9 = "", Comments = "Donna said she has been buying vehicles from this business for years. Every now and then there is something with the service and it gets tweaked, and it all works out. (Customer chose not to answer all the questions.)" },
				new Survey { Id = 2, CusId = 2, Q1 = true, Q2 = false, Q3 = true, Q4 = false, Q5 = true, Q6 = true, Q7 = false, Q8 = false, Q9 = "", Comments = "Denise stated that carfax keeps sending emails for an oil change and she wants it stopped. It took two hours to get her oil changed and the gentleman stated that they got backed up and should not have to wait so long for an oil change. The gentleman did not charge her and even gave her a free car wash. (Customer chose not to answer all the questions.)" },
				new Survey { Id = 3, CusId = 3, Q1 = false, Q2 = true, Q3 = false, Q4 = false, Q5 = true, Q6 = false, Q7 = false, Q8 = false, Q9 = "", Comments = "Selin said it was not ready, she had to contact them, it was a half hour before closing and they hadn't even worked on her vehicle. They could be more transparent and communicate better. This was her first time there, so she doesn't know if she would recommend them. (Customer chose not to answer all the questions.)" },
				new Survey { Id = 4, CusId = 4, Q1 = true, Q2 = true, Q3 = true, Q4 = false, Q5 = true, Q6 = true, Q7 = false, Q8 = false, Q9 = "", Comments = "Sarah stated that she was dissatisfied with the East Harbor visit work." },
				new Survey { Id = 5, CusId = 5, Q1 = true, Q2 = false, Q3 = true, Q4 = true, Q5 = true, Q6 = true, Q7 = false, Q8 = true, Q9 = "", Comments = "Margaret said everything was done that needed to be done, she also purchased her vehicle from them and she is happy with them." },
				new Survey { Id = 6, CusId = 6, Q1 = true, Q2 = true, Q3 = true, Q4 = false, Q5 = true, Q6 = true, Q7 = false, Q8 = true, Q9 = "", Comments = "" }
				);
		}
	}
}
