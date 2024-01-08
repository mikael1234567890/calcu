using Xunit;

public class StringManipulatorTests
{
    [Fact]
    public void ReverseString_ShouldReverseString()
    {
        // Arrange
        StringManipulator manipulator = new StringManipulator();
        string input = "Hello World!";

        // Act
        string result = manipulator.ReverseString(input);

        // Assert
        Assert.Equal("!dlroW olleH", result);
    }

    [Fact]
    public void ConcatenateStrings_ShouldConcatenateStrings()
    {
        // Arrange
        StringManipulator manipulator = new StringManipulator();
        string str1 = "Hello";
        string str2 = "World";

        // Act
        string result = manipulator.ConcatenateStrings(str1, str2);

        // Assert
        Assert.Equal("HelloWorld", result);
    }

    [Fact]
    public void RemoveSpaces_ShouldRemoveSpaces()
    {
        // Arrange
        StringManipulator manipulator = new StringManipulator();
        string input = "   Remove   Spaces   ";

        // Act
        string result = manipulator.RemoveSpaces(input);

        // Assert
        Assert.Equal("RemoveSpaces", result);
    }

    [Fact]
    public void ToUpperCase_ShouldConvertToUpperCase()
    {
        // Arrange
        StringManipulator manipulator = new StringManipulator();
        string input = "convert to uppercase";

        // Act
        string result = manipulator.ToUpperCase(input);

        // Assert
        Assert.Equal("CONVERT TO UPPERCASE", result);
    }

    [Fact]
    public void ToLowerCase_ShouldConvertToLowerCase()
    {
        // Arrange
        StringManipulator manipulator = new StringManipulator();
        string input = "CONVERT TO LOWERCASE";

        // Act
        string result = manipulator.ToLowerCase(input);

        // Assert
        Assert.Equal("convert to lowercase", result);
    }
}
