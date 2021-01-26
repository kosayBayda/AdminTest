using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DBLayer.Classes
{
    public class Employee
    {
        private string dbConnection;
        public Employee()
        {
            dbConnection = Setting.dbConntection;
        }
        public List<Shared.ViewModels.EmployeeViewModel> GetEmployees()
        {
            SqlConnection cnn = new SqlConnection(dbConnection);
            SqlCommand cmd = new SqlCommand("getEmployees", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cnn.Open();
            List<Shared.ViewModels.EmployeeViewModel> result = new List<Shared.ViewModels.EmployeeViewModel>();
            SqlDataReader employeesDataReader = cmd.ExecuteReader();
            while (employeesDataReader.Read())
            {
                result.Add(new Shared.ViewModels.EmployeeViewModel()
                {
                    Id = System.Convert.ToInt32(employeesDataReader["employee_id"].ToString()),
                    firstName = employeesDataReader["first_name"].ToString(),
                    lastName = employeesDataReader["last_name"].ToString(),
                    createdAt = DateTime.Parse(employeesDataReader["created_at"].ToString()),
                    departmentId = System.Convert.ToInt32(employeesDataReader["department_id"].ToString()),
                    departmentName = employeesDataReader["title"].ToString(),
                });
            }
            cnn.Close();
            return result;
        }
        public void insertEmployee(string firstName,string lastName,int departmentId)
        {
            SqlConnection cnn = new SqlConnection(dbConnection);
            SqlCommand cmd = new SqlCommand("insertEmployee", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter departmentIdParam = new SqlParameter();
            departmentIdParam.ParameterName = "@DepartmentId";
            departmentIdParam.Value = departmentId;

            SqlParameter firstNameParam = new SqlParameter();
            firstNameParam.ParameterName = "@firstName";
            firstNameParam.Value = firstName;

            SqlParameter lastNameParam = new SqlParameter();
            lastNameParam.ParameterName = "@lastName";
            lastNameParam.Value = lastName;

            cmd.Parameters.Add(firstNameParam);
            cmd.Parameters.Add(lastNameParam);
            cmd.Parameters.Add(departmentIdParam);

            cnn.Open();
            cmd.ExecuteScalar();
            cnn.Close();
        }

    }
}
