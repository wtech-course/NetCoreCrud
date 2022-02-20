using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreCrud.Entities
{
    public class Branch
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public int Company_Id { get; set; }
        public Company Company { get; set; }
    }
}
