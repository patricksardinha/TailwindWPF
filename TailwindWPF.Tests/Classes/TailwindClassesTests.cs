using System.Windows;
using System.Windows.Controls;
using Xunit;

using TailwindWPF.Styling;
using TailwindWPF.Tests.Helpers;
using System.Windows.Documents;

namespace TailwindWPF.Tests.Classes
{
    public class TailwindClassesTests
    {
        [Fact]
        public void Can_Apply_Class_To_Button()
        {
            var actualPadding = HelperSTA.RunInSta(() =>
            {
                var btn = new Button();
                Tw.SetClass(btn, "p-2");
                return btn.Padding;
            });

            Assert.Equal(new Thickness(8), actualPadding);
        }

        [Fact]
        public void Can_Apply_Class_To_TextBlock()
        {
            var actualFont = HelperSTA.RunInSta(() =>
            {
                var textBlock = new TextBlock();
                Tw.SetClass(textBlock, "font-bold");
                return textBlock.FontWeight;
            });


            Assert.Equal(FontWeights.Bold, actualFont);
        }

        [Fact]
        public void Can_Apply_Class_To_Grid()
        {
            var actualClass = HelperSTA.RunInSta(() =>
            {
                var grid = new Grid();
                Tw.SetClass(grid, "grid-cols-3");
                return grid.ColumnDefinitions;
            });


            Assert.Equal(3, actualClass.Count);
        }

        [Fact]
        public void Can_Apply_Multiple_Classes()
        {
            var actualClasses = HelperSTA.RunInSta(() =>
            {
                var btn = new Button();
                Tw.SetClass(btn, "p-4 m-2");
                return (btn.Padding, btn.Margin);
            });

            Assert.Equal(new Thickness(16), actualClasses.Padding);
            Assert.Equal(new Thickness(8), actualClasses.Margin);
        }

        [Fact]
        public void Can_Apply_Class_To_TextBox()
        {
            var actualClasses = HelperSTA.RunInSta(() =>
            {
                var textBox = new TextBox();
                Tw.SetClass(textBox, "border-2 rounded");
                return textBox.BorderThickness;
            });

            Assert.Equal(2.0, actualClasses.Left);
        }

        [Fact]
        public void Invalid_Class_Does_Not_Throw()
        {
            var btn = new Button();

            Tw.SetClass(btn, "undefined");
        }

        [Fact]
        public void Null_Element_Throws_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Tw.SetClass(null, "p-2"));
        }
    }
}