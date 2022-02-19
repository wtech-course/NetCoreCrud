using Microsoft.EntityFrameworkCore;
using NetCoreCrud.DataAccess.Abstract;
using NetCoreCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCrud.DataAccess.Concrete
{

    public class CompanyRepository : ICompanyRepository
    {
        public Company CreateCompany(Company company)
        {
            using (var companyContext= new NetCoreCrudDbContext())
            {
                companyContext.Add(company);
                companyContext.SaveChanges();
                return company;
            }
        }

        public void DeleteCompany(int id)
        {
            using (var companyContext = new NetCoreCrudDbContext())
            {
                var deleteCompany = GetCompanyById(id);
                companyContext.Companies.Remove(deleteCompany);
                companyContext.SaveChanges();
            }
        }

        public async Task<List<Company>> GetAllCompanies()
        {
            try
            {
                using (var companyContext = new NetCoreCrudDbContext())
                {
                   return await companyContext.Companies.ToListAsync();
                
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        public Company GetCompanyById(int id)
        {
            using (var companyContext=new NetCoreCrudDbContext())
            {
                var company = companyContext.Companies.Find(id);
                return company;
            }
        }

        public Company UpdateCompany(Company company)
        {
            using (var companyContext= new NetCoreCrudDbContext())
            {
                companyContext.Companies.Update(company);
                companyContext.SaveChanges();
                return company;
            }
        }
    }
}
