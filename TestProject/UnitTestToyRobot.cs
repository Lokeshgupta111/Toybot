using RobotSimulator;
using System;
using Xunit;


namespace TestProject
{
    public class UnitTestToyRobot
    {
        [Theory]
        [InlineData(1, 2, Face.EAST)]

        public void Test_Place_Pass(int X, int Y, Face F)
        {
            ToyRobot Robot = new ToyRobot();

            var result = Robot.Place(X, Y, F);

            Assert.True(result);

        }

        [Theory]
        [InlineData(7, 2, Face.EAST)]

        public void Test_Place_Fail(int X, int Y, Face F)
        {
            ToyRobot Robot = new ToyRobot();

            var result = Robot.Place(X, Y, F);

            Assert.False(result);

        }

        [Theory]
        [InlineData(4, 5, Face.EAST)]

        public void Test_Move_Pass(int X, int Y, Face F)
        {
            ToyRobot Robot = new ToyRobot();

            Robot.Place(X, Y, F);
            var result = Robot.Move();

            Assert.True(result);

        }

        [Theory]
        [InlineData(6, 2, Face.EAST)]

        public void Test_Move_Fail(int X, int Y, Face F)
        {
            ToyRobot Robot = new ToyRobot();

            Robot.Place(X, Y, F);
            var result = Robot.Move();

            Assert.False(result);

        }

        [Theory]
        [InlineData(4, 2, Face.EAST)]

        public void Test_Report_Pass(int X, int Y, Face F)
        {
            ToyRobot Robot = new ToyRobot();

            Robot.Place(X, Y, F);
            var result = Robot.Report();

            Assert.True(result);

        }

        [Theory]
        [InlineData(17, 2, Face.EAST)]

        public void Test_Report_Fail(int X, int Y, Face F)
        {
            ToyRobot Robot = new ToyRobot();

            Robot.Place(X, Y, F);
            var result = Robot.Report();

            Assert.False(result);

        }
    }
}
