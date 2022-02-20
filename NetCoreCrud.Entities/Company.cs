using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetCoreCrud.Entities
{
    public class Company
    {
        public Company()
        {
            Branchs = new Collection<Branch>();
        }

        public int Company_Id { get; set; }
       
        public string Company_Name { get; set; }
     
        public string Company_Address { get; set; }

        //Bir company nesnesine ait tüm branch nesnelerini beraberinde getirir.
        public ICollection<Branch> Branchs { get; set; }
    }
}


