using System;
using Xunit;

namespace Lab.UnitTest
{
    public class PieceTest
    {
        [Theory]
        [InlineData()]
        public void Valid_Movement_Succeeds()
        {
            var piece = new PieceFactory();
            var movement = new gameEngine();
            Assert.True(movement.executeMovement(p)== true);
            Assert.Equal(movement.executeMovement); 

        }

        [Theory]
        [InlineData()]
        public void New_Item_Succeeds()
        {
            var piece = new PieceFactory();
            Assert.True(piece == true);
            Assert.Equal(piece);
        }
    }
}
