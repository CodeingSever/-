using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;

namespace EmployeeManagementSystem
{
    public class DatabaseHelper
    {
        private string _connectionString = "Data Source=Employee.db";

        public void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Employees (
                                EmployeeID INTEGER PRIMARY KEY AUTOINCREMENT,
                                EmployeeName TEXT NOT NULL,
                                Position TEXT,
                                Department TEXT,
                                Email TEXT,
                                Phone TEXT,
                                Status TEXT
                            )";
                using (var command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddEmployee(Employee emp)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Employees (EmployeeName, Position, Department, Email, Phone, Status) VALUES (@Name, @Pos, @Dept, @Email, @Phone, @Status)";
                using (var command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Name", emp.EmployeeName);
                    command.Parameters.AddWithValue("@Pos", emp.Position);
                    command.Parameters.AddWithValue("@Dept", emp.Department);
                    command.Parameters.AddWithValue("@Email", emp.Email);
                    command.Parameters.AddWithValue("@Phone", emp.Phone);
                    command.Parameters.AddWithValue("@Status", emp.Status);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmployee(Employee emp)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                string sql = "UPDATE Employees SET EmployeeName=@Name, Position=@Pos, Department=@Dept, Email=@Email, Phone=@Phone, Status=@Status WHERE EmployeeID=@ID";
                using (var command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", emp.EmployeeID);
                    command.Parameters.AddWithValue("@Name", emp.EmployeeName);
                    command.Parameters.AddWithValue("@Pos", emp.Position);
                    command.Parameters.AddWithValue("@Dept", emp.Department);
                    command.Parameters.AddWithValue("@Email", emp.Email);
                    command.Parameters.AddWithValue("@Phone", emp.Phone);
                    command.Parameters.AddWithValue("@Status", emp.Status);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEmployee(int id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Employees WHERE EmployeeID=@ID";
                using (var command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Employees";
                using (var command = new SqliteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Employee
                            {
                                EmployeeID = reader.GetInt32(0),
                                EmployeeName = reader.GetString(1),
                                Position = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                Department = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                Email = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                Phone = reader.IsDBNull(5) ? "" : reader.GetString(5),
                                Status = reader.IsDBNull(6) ? "" : reader.GetString(6)
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
