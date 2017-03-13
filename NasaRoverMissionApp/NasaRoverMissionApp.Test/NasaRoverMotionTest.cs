using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NasaRoverMissionApp.Services;

namespace NasaRoverMissionApp.Test
{
    
    [TestClass]
    public class NasaRoverMotionTest
    {
        #region Rover Forward and Backward movement test
        [TestMethod]
        public void Rover_Forward_Movement_In_X_Coordinate_When_Rover_Alignment_Is_East()
        {
            //Arrange
            int roverXCoordinate = 1;
            //Act
            RoverForwardMovementServices myRoverForwardMotion = new RoverForwardMovementServices();
            int actualRoverXCoordinate = myRoverForwardMotion.GetRoverForwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);

            //Assert
            Assert.AreEqual(actualRoverXCoordinate, 2);
        }
        [TestMethod]
        public void Rover_Forward_Movement_In_X_Coordinate_When_Rover_Alignment_Is_West()
        {
            //Arrange
            int roverXCoordinate = 1;
            //Act
            RoverForwardMovementServices myRoverForwardMotion = new RoverForwardMovementServices();
            int actualRoverXCoordinate = myRoverForwardMotion.GetRoverForwardMovementInXCoordinateWhenAlignmentIsWest(roverXCoordinate);

            //Assert
            Assert.AreEqual(actualRoverXCoordinate, 0);
        }
        [TestMethod]
        public void Rover_Forward_Movement_In_Y_Coordinate_When_Rover_Alignment_Is_North()
        {
            //Arrange
            int roverYCoordinate = 1;
            //Act
            RoverForwardMovementServices myRoverForwardMotion = new RoverForwardMovementServices();
            int actualRoverYCoordinate = myRoverForwardMotion.GetRoverForwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);

            //Assert
            Assert.AreEqual(actualRoverYCoordinate, 2);
        }
        [TestMethod]
        public void Rover_Forward_Movement_In_Y_Coordinate_When_Rover_Alignment_Is_South()
        {
            //Arrange
            int roverYCoordinate = 1;
            //Act
            RoverForwardMovementServices myRoverForwardMotion = new RoverForwardMovementServices();
            int actualRoverYCoordinate = myRoverForwardMotion.GetRoverForwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);

            //Assert
            Assert.AreEqual(actualRoverYCoordinate, 0);
        }


        [TestMethod]
        public void Rover_Backward_Movement_In_X_Coordinate_When_Rover_Alignment_Is_East()
        {
            //Arrange
            int roverXCoordinate = 1;
            //Act
            RoverBackwardMovementServices myRoverBackwardMotion = new RoverBackwardMovementServices();
            int actualRoverXCoordinate = myRoverBackwardMotion.GetRoverBackwardMovementInXCoordinateWhenAlignmentIsEast(roverXCoordinate);

            //Assert
            Assert.AreEqual(actualRoverXCoordinate, 0);
        }
        [TestMethod]
        public void Rover_Backward_Movement_In_X_Coordinate_When_Rover_Alignment_Is_West()
        {
            //Arrange
            int roverXCoordinate = 1;
            //Act
            RoverBackwardMovementServices myRoverBackwardMotion = new RoverBackwardMovementServices();
            int actualRoverXCoordinate = myRoverBackwardMotion.GetRoverBackwardMovementInXCoordinateWhenAlignmentIsWest(roverXCoordinate);

            //Assert
            Assert.AreEqual(actualRoverXCoordinate, 2);
        }
        [TestMethod]
        public void Rover_Backward_Movement_In_Y_Coordinate_When_Rover_Alignment_Is_North()
        {
            //Arrange
            int roverYCoordinate = 1;
            //Act
            RoverBackwardMovementServices myRoverBackwardMotion = new RoverBackwardMovementServices();
            int actualRoverYCoordinate = myRoverBackwardMotion.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsNorth(roverYCoordinate);

            //Assert
            Assert.AreEqual(actualRoverYCoordinate, 0);
        }
        [TestMethod]
        public void Rover_Backward_Movement_In_Y_Coordinate_When_Rover_Alignment_Is_South()
        {
            //Arrange
            int roverYCoordinate = 1;
            //Act
            RoverBackwardMovementServices myRoverBackwardMotion = new RoverBackwardMovementServices();
            int actualRoverYCoordinate = myRoverBackwardMotion.GetRoverBackwardMovementInYCoordinateWhenAlignmentIsSouth(roverYCoordinate);

            //Assert
            Assert.AreEqual(actualRoverYCoordinate, 2);
        }
        #endregion

        #region Rover Alignment/Rotation test
        [TestMethod]
        public void Changing_Rover_Alignment_When_Rover_Aligment_Is_North_And_Motion_Instruction_Is_R()
        {
            //Arrange
           
            char roverMoveCommand = 'R';
            //Act
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            string actualRoverChangeAlignment = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsNorthAndMotionInstructionIsR(roverMoveCommand);
            //Assert
            Assert.AreEqual(actualRoverChangeAlignment, "E");
        }
        [TestMethod]
        public void Changing_Rover_Alignment_When_Rover_Aligment_Is_East_And_Motion_Instruction_Is_R()
        {
            //Arrange

            char roverMoveCommand = 'R';
            //Act
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            string actualRoverChangeAlignment = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsEastAndMotionInstructionIsR(roverMoveCommand);
            //Assert
            Assert.AreEqual(actualRoverChangeAlignment, "S");
        }
        [TestMethod]
        public void Changing_Rover_Alignment_When_Rover_Aligment_Is_South_And_Motion_Instruction_Is_R()
        {
            //Arrange

            char roverMoveCommand = 'R';
            //Act
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            string actualRoverChangeAlignment = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsSouthAndMotionInstructionIsR(roverMoveCommand);
            //Assert
            Assert.AreEqual(actualRoverChangeAlignment, "W");
        }
        [TestMethod]
        public void Changing_Rover_Alignment_When_Rover_Aligment_Is_West_And_Motion_Instruction_Is_R()
        {
            //Arrange

            char roverMoveCommand = 'R';
            //Act
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            string actualRoverChangeAlignment = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsWestAndMotionInstructionIsR(roverMoveCommand);
            //Assert
            Assert.AreEqual(actualRoverChangeAlignment, "N");
        }
        
        [TestMethod]
        public void Changing_Rover_Alignment_When_Rover_Aligment_Is_North_And_Motion_Instruction_Is_L()
        {
            //Arrange

            char roverMoveCommand = 'L';
            //Act
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            string actualRoverChangeAlignment = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsNorthAndMotionInstructionIsL(roverMoveCommand);
            //Assert
            Assert.AreEqual(actualRoverChangeAlignment, "W");
        }
        [TestMethod]
        public void Changing_Rover_Alignment_When_Rover_Aligment_Is_East_And_Motion_Instruction_Is_L()
        {
            //Arrange

            char roverMoveCommand = 'L';
            //Act
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            string actualRoverChangeAlignment = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsEastAndMotionInstructionIsL(roverMoveCommand);
            //Assert
            Assert.AreEqual(actualRoverChangeAlignment, "N");
        }
        [TestMethod]
        public void Changing_Rover_Alignment_When_Rover_Aligment_Is_South_And_Motion_Instruction_Is_L()
        {
            //Arrange

            char roverMoveCommand = 'L';
            //Act
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            string actualRoverChangeAlignment = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsSouthAndMotionInstructionIsL(roverMoveCommand);
            //Assert
            Assert.AreEqual(actualRoverChangeAlignment, "E");
        }
        [TestMethod]
        public void Changing_Rover_Alignment_When_Rover_Aligment_Is_West_And_Motion_Instruction_Is_L()
        {
            //Arrange

            char roverMoveCommand = 'L';
            //Act
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            string actualRoverChangeAlignment = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsWestAndMotionInstructionIsL(roverMoveCommand);
            //Assert
            Assert.AreEqual(actualRoverChangeAlignment, "S");
        }
        #endregion

        #region Testing Rover final position when rover moving command contains F and R
        [TestMethod]
        public void Returns_Rover_Final_Coordinate_Correctly_When_Rover_Initial_Alignment_Is_North_And_Move_Command_Is_F_F_R_F_F()
        {
            //Arrange
            int roverInitialXCoordinate = 0;
            int roverInitialYCoordinate = 0;
            //char[] roverMoveCommand = { 'F', 'F', 'R', 'F', 'F' };
            char roverMoveCommand1 = 'F';
            char roverMoveCommand2 = 'F';
            char roverMoveCommand3 = 'R';
            char roverMoveCommand4 = 'F';
            char roverMoveCommand5 = 'F';

            //Act
            RoverFinalPositionServices myRoverPosition = new RoverFinalPositionServices();
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            int roverYCoordinateAfterMoveCommand1 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsForward(roverInitialYCoordinate);
            int roverYCoordinateAfterMoveCommand2 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsForward(roverYCoordinateAfterMoveCommand1);
            string roverAlignmentAfterMoveCommand3 = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsNorthAndMotionInstructionIsR(roverMoveCommand3);
            int roverXCoordinateAfterMoveCommand4 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsForward(roverInitialXCoordinate);
            int roverXCoordinateAfterMoveCommand5 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsForward(roverXCoordinateAfterMoveCommand4);

            string actualRoverFinalCoordinate = roverXCoordinateAfterMoveCommand5.ToString() + roverYCoordinateAfterMoveCommand2.ToString() + roverAlignmentAfterMoveCommand3;
            //Assert
            Assert.AreEqual(actualRoverFinalCoordinate, "22E");
        }
        [TestMethod]
        public void Returns_Rover_Final_Coordinate_Correctly_When_Rover_Initial_Alignment_Is_East_And_Move_Command_Is_F_F_R_F_F()
        {
            //Arrange
            int roverInitialXCoordinate = 0;
            int roverInitialYCoordinate = 0;
            //char[] roverMoveCommand = { 'F', 'F', 'R', 'F', 'F' };
            char roverMoveCommand1 = 'F';
            char roverMoveCommand2 = 'F';
            char roverMoveCommand3 = 'R';
            char roverMoveCommand4 = 'F';
            char roverMoveCommand5 = 'F';

            //Act
            RoverFinalPositionServices myRoverPosition = new RoverFinalPositionServices();
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            int roverXCoordinateAfterMoveCommand1 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsForward(roverInitialXCoordinate);
            int roverXCoordinateAfterMoveCommand2 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsForward(roverXCoordinateAfterMoveCommand1);
            string roverAlignmentAfterMoveCommand3 = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsEastAndMotionInstructionIsR(roverMoveCommand3);
            int roverYCoordinateAfterMoveCommand4 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsForward(roverInitialYCoordinate);
            int roverYCoordinateAfterMoveCommand5 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsForward(roverYCoordinateAfterMoveCommand4);

            string actualRoverFinalCoordinate = roverXCoordinateAfterMoveCommand2.ToString() + roverYCoordinateAfterMoveCommand5.ToString() + roverAlignmentAfterMoveCommand3;
            //Assert
            Assert.AreEqual(actualRoverFinalCoordinate, "2-2S");
        }
        [TestMethod]
        public void Returns_Rover_Final_Coordinate_Correctly_When_Rover_Initial_Alignment_Is_South_And_Move_Command_Is_F_F_R_F_F()
        {
            //Arrange
            int roverInitialXCoordinate = 0;
            int roverInitialYCoordinate = 0;
            //char[] roverMoveCommand = { 'F', 'F', 'R', 'F', 'F' };
            char roverMoveCommand1 = 'F';
            char roverMoveCommand2 = 'F';
            char roverMoveCommand3 = 'R';
            char roverMoveCommand4 = 'F';
            char roverMoveCommand5 = 'F';

            //Act
            RoverFinalPositionServices myRoverPosition = new RoverFinalPositionServices();
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            int roverYCoordinateAfterMoveCommand1 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsForward(roverInitialYCoordinate);
            int roverYCoordinateAfterMoveCommand2 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsForward(roverYCoordinateAfterMoveCommand1);
            string roverAlignmentAfterMoveCommand3 = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsSouthAndMotionInstructionIsR(roverMoveCommand3);
            int roverXCoordinateAfterMoveCommand4 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsForward(roverInitialXCoordinate);
            int roverXCoordinateAfterMoveCommand5 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsForward(roverXCoordinateAfterMoveCommand4);

            string actualRoverFinalCoordinate = roverYCoordinateAfterMoveCommand2.ToString() + roverXCoordinateAfterMoveCommand5.ToString() + roverAlignmentAfterMoveCommand3;
            //Assert
            Assert.AreEqual(actualRoverFinalCoordinate, "-2-2W");
        }
        [TestMethod]
        public void Returns_Rover_Final_Coordinate_Correctly_When_Rover_Initial_Alignment_Is_West_And_Move_Command_Is_F_F_R_F_F()
        {
            //Arrange
            int roverInitialXCoordinate = 0;
            int roverInitialYCoordinate = 0;
            //char[] roverMoveCommand = { 'F', 'F', 'R', 'F', 'F' };
            char roverMoveCommand1 = 'F';
            char roverMoveCommand2 = 'F';
            char roverMoveCommand3 = 'R';
            char roverMoveCommand4 = 'F';
            char roverMoveCommand5 = 'F';

            //Act
            RoverFinalPositionServices myRoverPosition = new RoverFinalPositionServices();
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            int roverXCoordinateAfterMoveCommand1 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsForward(roverInitialXCoordinate);
            int roverXCoordinateAfterMoveCommand2 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsForward(roverXCoordinateAfterMoveCommand1);
            string roverAlignmentAfterMoveCommand3 = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsWestAndMotionInstructionIsR(roverMoveCommand3);
            int roverYCoordinateAfterMoveCommand4 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsForward(roverInitialYCoordinate);
            int roverYCoordinateAfterMoveCommand5 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsForward(roverYCoordinateAfterMoveCommand4);

            string actualRoverFinalCoordinate = roverXCoordinateAfterMoveCommand2.ToString() + roverYCoordinateAfterMoveCommand5.ToString() + roverAlignmentAfterMoveCommand3;
            //Assert
            Assert.AreEqual(actualRoverFinalCoordinate, "-22N");
        }
        #endregion

        #region Testing Rover final position when rover moving command contains B and L
        [TestMethod]
        public void Returns_Rover_Final_Coordinate_Correctly_When_Rover_Initial_Alignment_Is_North_And_Move_Command_Is_B_B_L_B_B()
        {
            //Arrange
            int roverInitialXCoordinate = 0;
            int roverInitialYCoordinate = 0;
            
            char roverMoveCommand1 = 'B';
            char roverMoveCommand2 = 'B';
            char roverMoveCommand3 = 'L';
            char roverMoveCommand4 = 'B';
            char roverMoveCommand5 = 'B';

            //Act
            RoverFinalPositionServices myRoverPosition = new RoverFinalPositionServices();
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            int roverYCoordinateAfterMoveCommand1 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsBackward(roverInitialYCoordinate);
            int roverYCoordinateAfterMoveCommand2 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsBackward(roverYCoordinateAfterMoveCommand1);
            string roverAlignmentAfterMoveCommand3 = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsNorthAndMotionInstructionIsL(roverMoveCommand3);
            int roverXCoordinateAfterMoveCommand4 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsBackward(roverInitialXCoordinate);
            int roverXCoordinateAfterMoveCommand5 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsBackward(roverXCoordinateAfterMoveCommand4);

            string actualRoverFinalCoordinate = roverXCoordinateAfterMoveCommand5.ToString() + roverYCoordinateAfterMoveCommand2.ToString() + roverAlignmentAfterMoveCommand3;
            //Assert
            Assert.AreEqual(actualRoverFinalCoordinate, "2-2W");
        }
        [TestMethod]
        public void Returns_Rover_Final_Coordinate_Correctly_When_Rover_Initial_Alignment_Is_East_And_Move_Command_Is_B_B_L_B_B()
        {
            //Arrange
            int roverInitialXCoordinate = 0;
            int roverInitialYCoordinate = 0;
            
            char roverMoveCommand1 = 'B';
            char roverMoveCommand2 = 'B';
            char roverMoveCommand3 = 'L';
            char roverMoveCommand4 = 'B';
            char roverMoveCommand5 = 'B';

            //Act
            RoverFinalPositionServices myRoverPosition = new RoverFinalPositionServices();
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            int roverXCoordinateAfterMoveCommand1 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsBackward(roverInitialXCoordinate);
            int roverXCoordinateAfterMoveCommand2 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsBackward(roverXCoordinateAfterMoveCommand1);
            string roverAlignmentAfterMoveCommand3 = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsEastAndMotionInstructionIsL(roverMoveCommand3);
            int roverYCoordinateAfterMoveCommand4 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsBackward(roverInitialYCoordinate);
            int roverYCoordinateAfterMoveCommand5 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsBackward(roverYCoordinateAfterMoveCommand4);

            string actualRoverFinalCoordinate = roverXCoordinateAfterMoveCommand2.ToString() + roverYCoordinateAfterMoveCommand5.ToString() + roverAlignmentAfterMoveCommand3;
            //Assert
            Assert.AreEqual(actualRoverFinalCoordinate, "-2-2N");
        }
        [TestMethod]
        public void Returns_Rover_Final_Coordinate_Correctly_When_Rover_Initial_Alignment_Is_South_And_Move_Command_Is_B_B_L_B_B()
        {
            //Arrange
            int roverInitialXCoordinate = 0;
            int roverInitialYCoordinate = 0;
            //char[] roverMoveCommand = { 'F', 'F', 'R', 'F', 'F' };
            char roverMoveCommand1 = 'B';
            char roverMoveCommand2 = 'B';
            char roverMoveCommand3 = 'L';
            char roverMoveCommand4 = 'B';
            char roverMoveCommand5 = 'B';
            //Act
            RoverFinalPositionServices myRoverPosition = new RoverFinalPositionServices();
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            int roverYCoordinateAfterMoveCommand1 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsBackward(roverInitialYCoordinate);
            int roverYCoordinateAfterMoveCommand2 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsBackward(roverYCoordinateAfterMoveCommand1);
            string roverAlignmentAfterMoveCommand3 = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsSouthAndMotionInstructionIsL(roverMoveCommand3);
            int roverXCoordinateAfterMoveCommand4 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsBackward(roverInitialXCoordinate);
            int roverXCoordinateAfterMoveCommand5 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsBackward(roverXCoordinateAfterMoveCommand4);

            string actualRoverFinalCoordinate = roverXCoordinateAfterMoveCommand5.ToString() + roverYCoordinateAfterMoveCommand2.ToString() +  roverAlignmentAfterMoveCommand3;
            //Assert
            Assert.AreEqual(actualRoverFinalCoordinate, "-22E");
        }
        [TestMethod]
        public void Returns_Rover_Final_Coordinate_Correctly_When_Rover_Initial_Alignment_Is_West_And_Move_Command_Is_B_B_L_B_B()
        {
            //Arrange
            int roverInitialXCoordinate = 0;
            int roverInitialYCoordinate = 0;

            char roverMoveCommand1 = 'B';
            char roverMoveCommand2 = 'B';
            char roverMoveCommand3 = 'L';
            char roverMoveCommand4 = 'B';
            char roverMoveCommand5 = 'B';

            //Act
            RoverFinalPositionServices myRoverPosition = new RoverFinalPositionServices();
            RoverAlignmentService myRoverAlignment = new RoverAlignmentService();
            int roverXCoordinateAfterMoveCommand1 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsBackward(roverInitialXCoordinate);
            int roverXCoordinateAfterMoveCommand2 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsBackward(roverXCoordinateAfterMoveCommand1);
            string roverAlignmentAfterMoveCommand3 = myRoverAlignment.GetChangedRoverAlignmentWhenInitialAlignmentIsWestAndMotionInstructionIsL(roverMoveCommand3);
            int roverYCoordinateAfterMoveCommand4 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsBackward(roverInitialYCoordinate);
            int roverYCoordinateAfterMoveCommand5 = myRoverPosition.GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsBackward(roverYCoordinateAfterMoveCommand4);

            string actualRoverFinalCoordinate = roverXCoordinateAfterMoveCommand2.ToString() + roverYCoordinateAfterMoveCommand5.ToString() + roverAlignmentAfterMoveCommand3;
            //Assert
            Assert.AreEqual(actualRoverFinalCoordinate, "22S");
        }
        #endregion


    }
}
