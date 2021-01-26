using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DBLayer.Classes
{
    public class Asset
    {
        private string dbConnection;
        public Asset()
        {
            dbConnection = Setting.dbConntection;
        }
        public List<Shared.ViewModels.AssetViewModel> GetAssets()
        {
            SqlConnection cnn = new SqlConnection(dbConnection);
            SqlCommand cmd = new SqlCommand("getAssets", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cnn.Open();
            List<Shared.ViewModels.AssetViewModel> result = new List<Shared.ViewModels.AssetViewModel>();
            SqlDataReader departmentsDataReader = cmd.ExecuteReader();
            while (departmentsDataReader.Read())
            {
                result.Add(new Shared.ViewModels.AssetViewModel()
                {
                    Id = System.Convert.ToInt32(departmentsDataReader["asset_id"].ToString()),
                    assetName = departmentsDataReader["asset_name"].ToString(),
                    assetType = departmentsDataReader["title"].ToString(),
                });
            }
            cnn.Close();
            return result;
        }
    }
}
