using System;

namespace unit_tests_1
{
    public class Employee
    {
        public string Name { get; init; }

        public bool ValidateName()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return false;
            if (Name.Length < 4)
                return false;
            if (Name.Length > 50)
                return false;

            return true;
        }

        public bool ValidateNameAndThrow()
        {
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Name cannot be empty or null");
            if (Name.Length < 4)
                throw new Exception("Name must be more than 5 characters");
            if (Name.Length > 50)
                throw new Exception("Name must be up to 50 characters");

            return true;
        }
    }
}