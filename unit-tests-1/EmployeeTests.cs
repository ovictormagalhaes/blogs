using Xunit;

namespace unit_tests_1;

public class EmployeeTests
{
    [Fact]
    public void ValidateName_NullName_False()
    {
        //Arrange
        var employee = new Employee
        {
            Name = null
        };

        //Act
        var isValid = employee.ValidateName();

        //Assert
        Assert.False(isValid);
    }

    [Fact]
    public void ValidateName_Empty_False()
    {
        //Arrange
        var employee = new Employee
        {
            Name = string.Empty
        };

        //Act
        var isValid = employee.ValidateName();

        //Assert
        Assert.False(isValid);
    }

    [Fact]
    public void ValidateName_OnlyWhiteSpace_False()
    {
        //Arrange
        var employee = new Employee
        {
            Name = "      "
        };

        //Act
        var isValid = employee.ValidateName();

        //Assert
        Assert.False(isValid);
    }

    [Fact]
    public void ValidateName_3Characters_False()
    {
        //Arrange
        var employee = new Employee
        {
            Name = "Vic"
        };

        //Act
        var isValid = employee.ValidateName();

        //Assert
        Assert.False(isValid);
    }

    [Fact]
    public void ValidateName_51Characters_False()
    {
        //Arrange
        var employee = new Employee
        {
            Name = "HMlO8RCy4a9wwmI80UqEVqUyEd39vgLQL3RJEfXjsNUEgAgvqqV"
        };

        //Act
        var isValid = employee.ValidateName();

        //Assert
        Assert.False(isValid);
    }

    [Fact]
    public void ValidateName_ValidName_True()
    {
        //Arrange
        var employee = new Employee
        {
            Name = "Victor Magalhães"
        };

        //Act
        var isValid = employee.ValidateName();

        //Assert
        Assert.True(isValid);
    }
}