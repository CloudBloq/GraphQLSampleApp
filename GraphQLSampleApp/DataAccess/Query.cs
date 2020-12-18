using GraphQLSampleApp.DataAccess.DAO;
using GraphQLSampleApp.DataAccess.Entity;
using HotChocolate;
using System.Collections.Generic;


namespace GraphQLSampleApp.DataAccess
{
    public class Query
    {
        public List<Employee> AllEmployeeOnly([Service] EmployeeRepository employeeRepository) =>
            employeeRepository.GetEmployees();

        public List<Employee> AllEmployeeWithDepartment([Service] EmployeeRepository employeeRepository) =>
            employeeRepository.GetEmployeesWithDepartment();

        public List<Department> AllDepartmentsOnly([Service] DepartmentRepository departmentRepository) =>
            departmentRepository.GetAllDepartmentOnly();

        public List<Department> AllDepartmentsWithEmployee([Service] DepartmentRepository departmentRepository) =>
            departmentRepository.GetAllDepartmentsWithEmployee();
    }
}
