using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.ViewModels
{
    public class EmployeeAssetViewModel
    {
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int assetId {get;set;}
        public string assetName { get; set; }
        public string assetType { get; set; }
    }
}
