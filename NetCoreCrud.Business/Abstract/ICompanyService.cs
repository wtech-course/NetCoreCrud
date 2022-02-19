using NetCoreCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCrud.Business.Abstract
{
    public interface ICompanyService
    {
        //CRUD Methods
        Task<List<Company>> GetAllCompaniesAsync();
        Company GetCompanyById(int id);

        Company CreateCompany(Company company);
        Company UpdateCompany(Company company);
        void DeleteCompany(int id);
    }
}
