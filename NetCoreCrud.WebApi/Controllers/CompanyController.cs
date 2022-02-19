using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreCrud.Business.Abstract;
using NetCoreCrud.Business.Concrete;
using NetCoreCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCrud.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;
        public CompanyController()
        {
            _companyService = new CompanyService();
        }
        //post,get,put,delete
        /// <summary>
        /// Şirket kaydetme methodu
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Company company)
        {
            try
            {
                var createCompany = _companyService.CreateCompany(company);
                return Ok(createCompany);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
            
           
        }
        /// <summary>
        /// Şirketleri sıralama metodu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var companies = await _companyService.GetAllCompaniesAsync();
            return Ok(companies);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            var companies =  _companyService.GetCompanyById(id);
            return Ok(companies);
        }
        [HttpPut]
        public IActionResult Put([FromBody] Company company)
        {
            if (_companyService.GetCompanyById(company.Company_Id)!=null)
            {
                var updateCompany = _companyService.UpdateCompany(company);
                return Ok(updateCompany);
            }
            return NotFound("Data bulunamadı!");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_companyService.GetCompanyById(id)!=null)
            {
                _companyService.DeleteCompany(id);
                return Ok(id+"idli data silindi");
            }
            return NotFound("Silinecek veri bulunamadı!");
        }

    }
}
