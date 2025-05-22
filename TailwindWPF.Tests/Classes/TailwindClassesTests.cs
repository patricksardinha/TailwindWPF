using System.Windows;
using System.Windows.Controls;
using TailwindWPF.Styling;
using Xunit;

namespace TailwindWPF.Tests.Classes
{
    public class TailwindClassesTests
    {
        [Fact]
        public void Can_Apply_Class_To_Button()
        {
            var btn = new Button();

            Tw.SetClass(btn, "p-2");

            Assert.Equal(new Thickness(8), btn.Padding);
        }

        [Fact]
        public void Can_Apply_Multiple_Classes()
        {
            var btn = new Button();

            Tw.SetClass(btn, "p-4 m-2 bg-blue-500");

            Assert.Equal(new Thickness(16), btn.Padding);
            Assert.Equal(new Thickness(8), btn.Margin);
        }

        [Theory]
        [InlineData("p-1", 4)]
        [InlineData("p-2", 8)]
        [InlineData("p-4", 16)]
        public void Padding_Classes_Apply_Correct_Values(string className, double expectedValue)
        {
            var element = new Button();

            Tw.SetClass(element, className);

            Assert.Equal(new Thickness(expectedValue), element.Padding);
        }

        [Fact]
        public void Can_Apply_Class_To_TextBox()
        {
            var textBox = new TextBox();

            Tw.SetClass(textBox, "border-2 rounded");

            Assert.Equal(2.0, textBox.BorderThickness.Left);
        }

        [Fact]
        public void Can_Apply_Class_To_Grid()
        {
            var grid = new Grid();

            Tw.SetClass(grid, "gap-4");

        }

        [Fact]
        public void Invalid_Class_Does_Not_Throw()
        {
            var btn = new Button();

            Tw.SetClass(btn, "classe-inexistante");
        }

        [Fact]
        public void Null_Element_Throws_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Tw.SetClass(null, "p-2"));
        }
    }
}