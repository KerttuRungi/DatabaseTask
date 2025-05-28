using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        [Column("Employee_ID")]
        public int EmployeeId { get; set; }  // PK - INT

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Id_Code")]
        public string IdCode { get; set; }  

        [Column("Position")]
        public int Position { get; set; }  

        [Column("Department")]
        public string Department { get; set; }

        [Column("Phone_Number")]
        public string PhoneNumber { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Access_ID")]
        public int AccessId { get; set; }
    }
    
    public class Child
    {
        [Key]
        [Column("Child_ID")]
        public int ChildId { get; set; }  

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("Date_Of_Birth")]
        public DateTime DateOfBirth { get; set; } 

        [Column("Employee_Id")]
        public int EmployeeId { get; set; }
    }
    public class JobTitle
    {
        public string Name { get; set; }
        public string description { get; set; }
    }
}

