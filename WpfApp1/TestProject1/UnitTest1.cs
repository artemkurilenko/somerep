using System;
using Xunit;
using WpfApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CheckLoginValidation_ReturnsTrue()
        {
            Assert.Equal("1", MainWindow.ValidateEmail("hood@email.ru", "1", "0"));
        }

        public void CheckLoginValidation_ReturnsFalse()
        {
            Assert.Equal("1", MainWindow.ValidateEmail("hood@email.ru", "0", "1"));
        }

        public void CheckTextValidation_ReturnsTrue()
        {
            Assert.Equal("good", MainWindow.ValidateText("123456", 6, 10, "1", "0", "good"));
        }

        public void CheckTextValidation1_ReturnsFalse()
        {
            Assert.Equal("1", MainWindow.ValidateText("123456", 100, 200, "1", "0", "good"));
        }

        public void CheckTextValidation1_ReturnsFalse()
        {
            Assert.Equal("0", MainWindow.ValidateText("123456", 1, 2, "1", "0", "good"));
        }
    }
}
