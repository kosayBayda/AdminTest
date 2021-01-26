using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int departmentId { get; set; }
        public string departmentName { get; set; }
        public DateTime createdAt { get; set; }


    }
}
