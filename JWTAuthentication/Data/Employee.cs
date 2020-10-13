using System;

namespace JWTAuthentication.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
    }
}