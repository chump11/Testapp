using NUnit.Framework;

namespace Twitter.Api.Test
{

    //[TestFixture]
    //public class MyTests
    //{

    //    [SetUp]
    //    public void SetUp()
    //    {

    //    }

    //    [Test]
    //    public void Test1()
    //    {
    //        public int i;
    //    public long l;


    //}
    
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
    }


    public sealed class Circle
    {
        private double radius;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }


       // circle.Calculate(r => 2 * Math.PI* r);
    }

    //public static Void Main()
    //{
    //    int ndistance, nresult;
    //    Console.WriteLine("Enter the distance in kilometers");
    //    ndistance = convert.ToInt32(Console.ReadLine());
    //    nresult = ndistance * 1000;
    //    Console.WriteLine("Distance in meters: " + nresult);
    //    Console.ReadLine();
    //}

}
