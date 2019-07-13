using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees; 

        public EmployeeRepository()
        {
            var email = "@gmail.com";
            this._employees = new List<Employee>()
            {

                new Employee () {id=1, Name="sayed" , Email="sayed@gmail.com" , Department="CSE student"},
                new Employee () {id=2, Name="Israt" , Email="Israt@gmail.com" , Department="Pharma student"},
                new Employee () {id=3, Name="Nayeem" , Email="Nayeem@gmail.com" , Department="EEE student"},
                new Employee () {id=4, Name="Jobair" , Email="Jobair@gmail.com" , Department="Mecha student"},
                new Employee () {id=5, Name="Ankita" , Email="Ankita@gmail.com" , Department="IT student"},
                new Employee () {id=6, Name="Hero" , Email="Hero@gmail.com" , Department="BBA student"}
            };
        }

        Employee IEmployeeRepository.GetEmployee(int id)
        {
            return this._employees.Find(x => x.id == id);
        }
    }
}
