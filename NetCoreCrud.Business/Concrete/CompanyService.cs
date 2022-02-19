using NetCoreCrud.Business.Abstract;
using NetCoreCrud.DataAccess.Abstract;
using NetCoreCrud.DataAccess.Concrete;
using NetCoreCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCrud.Business.Concrete
{
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository _companyRepository;
        public CompanyService()
        {
            _companyRepository = new CompanyRepository();
        }
        public Company CreateCompany(Company company)
        {
            _companyRepository.CreateCompany(company);
            return company;
        }

        public void DeleteCompany(int id)
        {
            _companyRepository.DeleteCompany(id);
        }

        public async Task<List<Company>> GetAllCompaniesAsync()
        {
           return await _companyRepository.GetAllCompanies();
        }

        public Company GetCompanyById(int id)
        {
            return _companyRepository.GetCompanyById(id);
        }

        public Company UpdateCompany(Company company)
        {
            return _companyRepository.UpdateCompany(company);
        }
    }
}
