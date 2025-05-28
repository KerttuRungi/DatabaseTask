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
        public int ChildId { get; set; }  // PK

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("Date_Of_Birth")]
        public DateTime DateOfBirth { get; set; } 

        [Column("Employee_Id")]
        public int EmployeeId { get; set; }
        
        
    }
    public class JobTitle
    {
        [Key]
        [Column("JobTitle_ID")]
        public int JobTitleId { get; set; }  // PK 

        [Column("Name")]
        public string Name { get; set; }

        [Column("Description")]
        public string Description { get; set; }
    }
    public class SickLeave
    {
        [Key]
        [Column("SickLeave_ID")]
        public int SickLeaveId { get; set; }  // PK

        [Column("Start_Date")]
        public DateTime StartDate { get; set; }
        
        [Column("End_Date")]
        public DateTime EndDate { get; set; }
        
        [Column("Diagnosis")]
        public string Diagnosis { get; set; }

        [Column("Employee_Id")]
        public int EmployeeId { get; set; }
        
        
    }
    public class HealthCheck
    {
        [Key]
        [Column("HealthCheck_ID")]
        public int HealthCheckId { get; set; }  // PK
        
        [Column("Check_Date")]
        public DateTime CheckDate { get; set; }

        [Column("Result")]
        public string Result { get; set; }
        
        [Column("Employee_Id")]
        public int EmployeeId { get; set; }

       
    }
    public class Access
    {
        [Key]
        [Column("Access_ID")]
        public int AccessId { get; set; }  // PK

        [Column("Name")]
        public string Name { get; set; }

        [Column("Description")]
        public string Description { get; set; }
        
        
    }
    public class Rent
    {
        [Key]
        [Column("Rent_ID")] // PK
        public int RentId { get; set; }
        
        [Column("Start_Date")]
        public DateTime StartDate { get; set; }
        
        [Column("End_Date")]
        public DateTime EndDate { get; set; }
        
        [Column("Employee_Id")]
        public int EmployeeId { get; set; }
        
        [Column("Object_Id")]
        public int ObjectId { get; set; }
        
       
    }
    public class RentObject
    {
        [Key]
        [Column("Object_ID")] // PK
        public int ObjectId { get; set; }
        
        [Column("Name")]
        public string Name { get; set; }
        
        [Column("Description")]
        public string Description { get; set; }

        [Column("Availability")]
        public bool Availability { get; set; }

    }
    public class HintAndRequest
    {
        [Key]
        [Column("HintAndRequest_ID")]
        public int HintAndRequestId { get; set; }  // PK

        [Column("Date")]
        public DateTime Date { get; set; }

        [Column("Content")]
        public string Content { get; set; }

        [Column("Employee_Id")]
        public int EmployeeId { get; set; }
        
        

    }
}

