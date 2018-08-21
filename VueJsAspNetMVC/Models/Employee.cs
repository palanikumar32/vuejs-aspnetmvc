using System;
using System.Linq;

namespace VueJsAspNetMVC.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Level { get; set; }
        public DateTime DOJ { get; set; }
        public int CountryID { get; set; }
        public string Country {
            get
            {
                return CountryID == 0 ? "" : new Countries().Get().Where(x => x.ID == CountryID).Select(x => x.Country).FirstOrDefault();
            }
        }
        public string State { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public string Address { get; set; }

        public Employee Get(int ID)
        {
            return DB.Employees.FirstOrDefault(x => x.ID == ID);
        }

        public void Save()
        {
            var employees = DB.Employees;
            if (this.ID > 0)
                employees.Remove(employees.FirstOrDefault(x => x.ID == ID));
            else
                this.ID = employees.Select(x => x.ID).DefaultIfEmpty().Max() + 1;

            employees.Add(this);
            DB.Employees = employees;
        }
    }
}