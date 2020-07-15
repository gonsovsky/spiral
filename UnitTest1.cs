using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpiralTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        [TestMethod]
        public void SquareDecode()
        {
            int[,] inputMatrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            var wantVector = new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            var outputVector = Spiral.Decode(inputMatrix).ToArray();

            var ok = Enumerable.SequenceEqual(outputVector, wantVector);
            Assert.AreEqual(ok, true);
        }

        [TestMethod]
        public void SquareEncode()
        {
            int[] inputVector = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[,] wantMatrix = { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } };
            var outputMatrix = Spiral.Encode(inputVector);

            var ok =
                wantMatrix.Rank == outputMatrix.Rank &&
                Enumerable.Range(0, wantMatrix.Rank).All(dimension => wantMatrix.GetLength(dimension) == outputMatrix.GetLength(dimension)) &&
                wantMatrix.Cast<int>().SequenceEqual(outputMatrix.Cast<int>());
            Assert.AreEqual(ok, true);
        }


        [TestMethod]
        public void NearlySquareDecode()
        {
            int[,] inputMatrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            var wantVector = new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };
            var outputVector = Spiral.Decode(inputMatrix).ToArray();

            var ok = Enumerable.SequenceEqual(outputVector, wantVector);
            Assert.AreEqual(ok, true);
        }


        //This test will fail :(
        [TestMethod]
        public void NearlySquareEncode()
        {
            int[] inputVector = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[,] wantMatrix = { { 1, 2, 3, 4 }, { 10, 11, 12, 5 }, { 9, 8, 7, 6 } };
            var outputMatrix = Spiral.Encode(inputVector);

            var ok =
                wantMatrix.Rank == outputMatrix.Rank &&
                Enumerable.Range(0, wantMatrix.Rank).All(dimension => wantMatrix.GetLength(dimension) == outputMatrix.GetLength(dimension)) &&
                wantMatrix.Cast<int>().SequenceEqual(outputMatrix.Cast<int>());
           
            Assert.AreEqual(ok, true);
        }
    }
}
