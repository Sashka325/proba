using ClassLibrary1;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double x = 1;
            double y = 2;
            double z = 3;
            double itog = Class1.kv(x, y);
            Assert.Equal(z, itog);
        }
    }
}