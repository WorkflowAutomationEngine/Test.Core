using Test.Core.Interfaces;

namespace Test.Core.Models
{
    public class Employee : IEmployee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetEmployeeId()
        {
            return Id.ToString();
        }
    }
}
