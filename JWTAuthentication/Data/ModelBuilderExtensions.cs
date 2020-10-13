using Microsoft.EntityFrameworkCore;
using System;

namespace JWTAuthentication.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee()
                    {
                        Id = 1,
                        Name = "Phạm Nguyên Vũ",
                        Gender = "Nam",
                        DOB = new DateTime(1997, 06, 23),
                        Department = "Research and Design",
                        Salary = 2000,
                        Address = "Hà Nội",
                        Note = "Very good"
                    },
                    new Employee()
                    {
                        Id = 2,
                        Name = "Nguyễn Ngọc Ánh",
                        Gender = "Nữ",
                        DOB = new DateTime(1997, 09, 01),
                        Department = "Human Resourced",
                        Salary = 500,
                        Address = "Hà Nội",
                        Note = "Good"
                    },
                    new Employee()
                    {
                        Id = 3,
                        Name = "Nguyễn Văn Bách",
                        Gender = "Nam",
                        DOB = new DateTime(1999, 02, 16),
                        Department = "Security",
                        Salary = 200,
                        Address = "Thái Bình",
                        Note = "Normal"
                    }
            );
        }
    }
}