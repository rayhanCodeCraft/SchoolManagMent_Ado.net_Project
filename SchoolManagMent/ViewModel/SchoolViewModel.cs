using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagMent.ViewModel
{
    public class SchoolViewModel
    {
        public int SchoolId { get; set; }
        public string SchoolCode { get; set; }
        public string SchoolName { get; set; }
        public DateTime EstablishedDate { get; set; }
        public string Madium { get; set; }
        public bool IsGovernment { get; set; }
        public int TotalMarks { get; set; }
        public string TypeTitle { get; set; }
        public string ImagePath { get; set; }
    }
}
