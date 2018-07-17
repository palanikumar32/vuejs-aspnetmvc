using System.Collections.Generic;

namespace VueJsAspNetMVC.Models
{
    public class DB
    {
        public static List<Employee> _employees;
        public static List<Employee> Employees 
        {
            get
            {
                return _employees ?? new List<Employee>();
            }
            set
            {
                _employees = value;
            }
        }
    }
}