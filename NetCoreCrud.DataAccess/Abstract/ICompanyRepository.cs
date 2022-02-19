using NetCoreCrud.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCrud.DataAccess.Abstract
{
    public interface ICompanyRepository
    {
        //CRUD Methods
        Task<List<Company>> GetAllCompanies();
        Company GetCompanyById(int id);

        Company CreateCompany(Company company);
        Company UpdateCompany(Company company);
        void DeleteCompany(int id);
    }
}
