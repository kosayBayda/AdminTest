using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DBLayer.Classes
{
    public class EmployeeAsset
    {
        private string dbConnection;
        public EmployeeAsset()
        {
            dbConnection = Setting.dbConntection;
        }
        public List<Shared.ViewModels.EmployeeAssetViewModel> GetEmployeesAssets()
        {
            SqlConnection cnn = new SqlConnection(dbConnection);
            SqlCommand cmd = new SqlCommand("getEmployeesAssets", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cnn.Open();
            List<Shared.ViewModels.EmployeeAssetViewModel> result = new List<Shared.ViewModels.EmployeeAssetViewModel>();
            SqlDataReader employeesAssetsDataReader = cmd.ExecuteReader();
            while (employeesAssetsDataReader.Read())
            {
                result.Add(new Shared.ViewModels.EmployeeAssetViewModel()
                {
                    employeeId = System.Convert.ToInt32(employeesAssetsDataReader["employee_id"].ToString()),
                    firstName = employeesAssetsDataReader["first_name"].ToString(),
                    lastName = employeesAssetsDataReader["last_name"].ToString(),
                    assetId = System.Convert.ToInt32(employeesAssetsDataReader["asset_id"].ToString()),
                    assetName = employeesAssetsDataReader["asset_name"].ToString(),
                    assetType = employeesAssetsDataReader["title"].ToString()

                });
            }
            cnn.Close();
            return result;
        }
    }

}
