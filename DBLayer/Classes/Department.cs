using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using Shared.ViewModels;
namespace DBLayer.Classes
{
    public class Department
    {
        private string dbConnection;
        public Department()
        {
            dbConnection=Setting.dbConntection;
        }
        public List<DepartmentViewModel> GetDepartments()
        {
            SqlConnection cnn = new SqlConnection(dbConnection);
            SqlCommand cmd = new SqlCommand("getDepartments", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cnn.Open();
            List<Shared.ViewModels.DepartmentViewModel> result = new List<Shared.ViewModels.DepartmentViewModel>();
            SqlDataReader departmentsDataReader = cmd.ExecuteReader();
            while (departmentsDataReader.Read())
            {
                result.Add(new Shared.ViewModels.DepartmentViewModel()
                {
                    Id = System.Convert.ToInt32(departmentsDataReader["department_id"].ToString()),
                    title = departmentsDataReader["title"].ToString(),
                    createdAt = DateTime.Parse(departmentsDataReader["created_at"].ToString())
                });
            }
            cnn.Close();
            return result;
        }
        public void insertDepartment(string title) 
        {
            SqlConnection cnn = new SqlConnection(dbConnection);
            SqlCommand cmd = new SqlCommand("insertDepartment", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter departmentTitleParam = new SqlParameter();
            departmentTitleParam.ParameterName = "@title";
            departmentTitleParam.Value = title.ToString();
            cmd.Parameters.Add(departmentTitleParam);
            cnn.Open();
            cmd.ExecuteScalar();
            cnn.Close();
        }
        public void updateDepartment(int id,string title)
        {
            SqlConnection cnn = new SqlConnection(dbConnection);
            SqlCommand cmd = new SqlCommand("updateDepartment", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter departmentIdParam = new SqlParameter();
            departmentIdParam.ParameterName = "@id";
            departmentIdParam.Value = id;
            SqlParameter departmentTitleParam = new SqlParameter();
            departmentTitleParam.ParameterName = "@title";
            departmentTitleParam.Value = title.ToString();
            cmd.Parameters.Add(departmentIdParam);
            cmd.Parameters.Add(departmentTitleParam);
            cnn.Open();
            cmd.ExecuteScalar();
            cnn.Close();
        }
        public Shared.ViewModels.DepartmentViewModel getDepartmentById(int id)
        {
            SqlConnection cnn = new SqlConnection(dbConnection);
            SqlCommand cmd = new SqlCommand("getDepartmentById", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter daptIdparam = new SqlParameter();
            daptIdparam.ParameterName = "@id";
            daptIdparam.Value = id;
            cmd.Parameters.Add(daptIdparam);
            cnn.Open();
            Shared.ViewModels.DepartmentViewModel result = new Shared.ViewModels.DepartmentViewModel();
            SqlDataReader deptReader = cmd.ExecuteReader();
            while (deptReader.Read())
            {
                result.Id = int.Parse(deptReader["department_id"].ToString());
                result.title = deptReader["title"].ToString();
                result.createdAt = DateTime.Parse(deptReader["created_at"].ToString());
            }
            cnn.Close();
            return result;
        }
        public void deleteDepartmentById(int id)
        {
            SqlConnection cnn = new SqlConnection(dbConnection);
            SqlCommand cmd = new SqlCommand("deleteDepartmentById", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter departmentIdParam = new SqlParameter();
            departmentIdParam.ParameterName = "@id";
            departmentIdParam.Value = id;
            cmd.Parameters.Add(departmentIdParam);
            cnn.Open();
            cmd.ExecuteScalar();
            cnn.Close();
        }

    }
}
