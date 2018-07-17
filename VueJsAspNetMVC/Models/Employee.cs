using System.Linq;

namespace VueJsAspNetMVC.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
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