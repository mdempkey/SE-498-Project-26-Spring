using Project498.WebApi.Services;

namespace Project498.WebApi.Tests;

public class StringServiceTests
{
    private readonly StringService _stringService = new();

    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("a", "a")]
    [InlineData("racecar", "racecar")]
    [InlineData("hello world", "dlrow olleh")]
    [InlineData("hello  world", "dlrow  olleh")]
    [InlineData(" hello world", "dlrow olleh ")]
    [InlineData("hello world ", " dlrow olleh")]
    public void Reverse_WithVariousInputs_ReturnsExpectedResult(string? input, string expected)
    {
        var result = _stringService.Reverse(input!);
        Assert.Equal(expected, result);
    }
    
    
    [Theory]
    [InlineData("Hello World", "World Hello")]
    [InlineData("hello", "hello")]
    [InlineData("The quick brown fox", "fox brown quick The")]
    [InlineData("  hello  world  ", "world hello")]
    [InlineData("a b c", "c b a")]
    
    
    
    public void ReverseWords_WithVariousInputs_ReturnsExpectedResult(string input, string expected)
    {
        var result = _stringService.ReverseWords(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseWords_SingleWord_ReturnsSameWord()
    {
        
        
        Assert.Equal("hello", _stringService.ReverseWords("hello"));
    }
}