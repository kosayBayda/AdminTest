using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DBLayer.Classes
{
    public class AssetType
    {
        private string dbConnection;
        public AssetType()
        {
            dbConnection = Setting.dbConntection;
        }
        public List<Shared.ViewModels.AssetTypeViewModel> GetAssetTypes()
        {
            SqlConnection cnn = new SqlConnection(dbConnection);
            SqlCommand cmd = new SqlCommand("getAssetTypes", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cnn.Open();
            List<Shared.ViewModels.AssetTypeViewModel> result = new List<Shared.ViewModels.AssetTypeViewModel>();
            SqlDataReader departmentsDataReader = cmd.ExecuteReader();
            while (departmentsDataReader.Read())
            {
                result.Add(new Shared.ViewModels.AssetTypeViewModel()
                {
                    Id = System.Convert.ToInt32(departmentsDataReader["asset_type_id"].ToString()),
                    title = departmentsDataReader["title"].ToString(),
                });
            }
            cnn.Close();
            return result;
        }
    }
}
