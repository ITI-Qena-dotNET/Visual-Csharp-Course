using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL;

public class DataLayer
{
    SqlConnection sqlConnection;
    SqlCommand sqlCommand;

    public DataLayer()
    {
        sqlConnection = new SqlConnection("Data Source=localhost;Database=Company_SD;User=sa;Password=abcd1234$");
        sqlCommand = new()
        {
            Connection = sqlConnection
        };
    }

    public Employee GetEmployee(string name)
    {
        sqlCommand.CommandText = $"SELECT * FROM Employee WHERE Fname = '{name}'";
        sqlConnection.Open();
        SqlDataReader reader = sqlCommand.ExecuteReader();

        Employee emp = new();

        while (reader.Read())
        {
            emp.fname = reader["Fname"].ToString();
            emp.lname = reader["Lname"].ToString();
            emp.salary = decimal.Parse(reader["Salary"].ToString());
        }

        sqlConnection.Close();

        return emp;
    }

    public int UpdateEmployee(Employee updatedEmployee, string name)
    {
        sqlCommand.CommandText = $"UPDATE [dbo].[Employee] SET [Fname] = '{updatedEmployee.fname}', [Lname] = '{updatedEmployee.lname}', [Salary] = {updatedEmployee.salary} WHERE [Fname] = '{name}'";
        sqlConnection.Open();
        int count = sqlCommand.ExecuteNonQuery();
        sqlConnection.Close();

        return count;
    }

    public int InsertDepartment(Department dept)
    {
        sqlCommand.CommandText = $"INSERT INTO Departments([Dname], [Dnum]) VALUES('{dept.Dname}', {dept.Dnum})";
        sqlConnection.Open();
        int count = sqlCommand.ExecuteNonQuery();
        sqlConnection.Close();
        return count;
    }

    public DataTable GetEmplooyees()
    {
        sqlCommand.CommandText = "Select * From Employee";
        DataTable dataTable = new DataTable();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        sqlDataAdapter.Fill(dataTable);
        return dataTable;
    }
    public DataTable GetDepartments()
    {
        sqlCommand.CommandText = "Select * From Departments";
        DataTable dataTable = new DataTable();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        sqlDataAdapter.Fill(dataTable);
        return dataTable;
    }
    public int InsertEmployee(string fname, string lname, decimal salary, int dno)
    {
        sqlCommand.CommandText = $"INSERT INTO [dbo].[Employee] ([SSN], [Fname]  ,[Lname] ,[Salary],[Dno] ) VALUES({Random.Shared.Next(1, 9999999)}, '{fname}','{lname}',{salary},{dno})";
        sqlConnection.Open();
        int count = sqlCommand.ExecuteNonQuery();
        sqlConnection.Close();
        return count;
    }
}
