namespace StringCalculatorTest
{
    class SumSquareDifference
    {
        public int SumOfFirstTenSquares(int limit)
        {
            var result = 0;

            for (int currentNo = 0; currentNo <= limit; currentNo++)
            {
                int squaredNo = currentNo * currentNo;
                result += squaredNo;
            }

            return result;
        }

        public int SquareSumOfFIrstTenNumbers(int limit)
        {
            var result = 0;

            for (int currenNo = 0; currenNo <= limit; currenNo++)
            {
                result += currenNo;
            }

            return result * result;
        }

        public int FindSquareDifference(int num)
        {
            int result = SquareSumOfFIrstTenNumbers(num) - SumOfFirstTenSquares(num);
            return result;
        }
    }

    [TestFixture]
    class SumSquareDifferenceTest
    {
        //[Test]
        //public void ShouldFind_Sum_OfTheSquares_For_FirstTenNatural_Numbers()
        //{
        //    //arrange 
        //    var sumSquareDiff = new SumSquareDifference();

        //    //act
        //    var result = sumSquareDiff.SumOfFirstTenSquares(100);

        //    //assert
        //    Assert.That(result, Is.EqualTo(385));
        //}

        //[Test]
        //public void ShouldFind_SquareOfSum_OfThe_FirstTen_Natural_Numbers()
        //{
        //    //ararnge
        //    var sumSquareDiff = new SumSquareDifference();

        //    //act
        //    var result = sumSquareDiff.SquareSumOfFIrstTenNumbers(100);

        //    //assert           
        //    Assert.That(result, Is.EqualTo(3025));
        //}

        [Test]
        public void ShouldFind_Sum_Square_Difference()
        {
            //arrange
            var SumSquareDiff = new SumSquareDifference();

            //act
            var result = SumSquareDiff.FindSquareDifference(100);
            
            //assert
            Assert.That(result, Is.EqualTo(25164150));
        }
    }
}
