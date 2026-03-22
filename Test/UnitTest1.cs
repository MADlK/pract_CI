
using GeometrShapeCI;



namespace Test
{
    public class UnitTest1
    {
        [Fact]

        public void CreateRectangle_NotNull()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 10;
            Assert.NotNull(rectangle);
        }

        //првоерка некорректных данных
        [Fact]
        public void CreateRectangle_ShouldReturnArgumentException_WidthZero()
        {
            Rectangle rectangle = new Rectangle();


            Assert.Throws<ArgumentException>(() => rectangle.Width = 0);
        }

        [Fact]
        public void CreateRectangle_ShouldReturnArgumentException_HeightZero()
        {
            Rectangle rectangle = new Rectangle();


            Assert.Throws<ArgumentException>(() => rectangle.Height = 0);
        }



        //проверка методов Area()
        [Fact]

        public void CheckAreaMethod_ShouldReturn100_Width10_Heaigh10()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 101;
            Assert.Equal(100, rectangle.Area());
        }
        //проверка методов Perimeter()
        //[Fact]
        //public void CheckPerimeterMethod_ShouldReturn20_Width10_Heaigh10()
        //{
        //    Rectangle rectangle = new Rectangle();
        //    rectangle.Width = 10;
        //    rectangle.Height = 10;
        //    Assert.Equal(20, rectangle.Perimeter());
        //}
    }
}