using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public class RoverFinalPositionServices: IRoverFinalPositionServices
    {
        /// <summary>
        /// Gets the rovers final coordinate when its intial alignment is north and move command is forward.
        /// </summary>
        /// <param name="roverInitialYCoordinate">The rover initial y coordinate.</param>
        /// <returns></returns>
        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsForward(int roverInitialYCoordinate)
        {
            roverInitialYCoordinate = roverInitialYCoordinate + 1;
            return roverInitialYCoordinate;
        }

        /// <summary>
        /// Gets the rovers final coordinate when its intial alignment is east and move command is forward.
        /// </summary>
        /// <param name="roverInitialXCoordinate">The rover initial x coordinate.</param>
        /// <returns></returns>
        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsForward(int roverInitialXCoordinate)
        {
            roverInitialXCoordinate = roverInitialXCoordinate + 1;
            return roverInitialXCoordinate;
        }

        /// <summary>
        /// Gets the rovers final coordinate when its intial alignment is south and move command is forward.
        /// </summary>
        /// <param name="roverInitialYCoordinate">The rover initial y coordinate.</param>
        /// <returns></returns>
        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsForward(int roverInitialYCoordinate)
        {
            roverInitialYCoordinate = roverInitialYCoordinate - 1;
            return roverInitialYCoordinate;
        }

        /// <summary>
        /// Gets the rovers final coordinate when its intial alignment is west and move command is forward.
        /// </summary>
        /// <param name="roverInitialXCoordinate">The rover initial x coordinate.</param>
        /// <returns></returns>
        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsForward(int roverInitialXCoordinate)
        {
            roverInitialXCoordinate = roverInitialXCoordinate - 1;
            return roverInitialXCoordinate;
        }

        /// <summary>
        /// Gets the rovers final coordinate when its intial alignment is north and move command is backward.
        /// </summary>
        /// <param name="roverInitialYCoordinate">The rover initial y coordinate.</param>
        /// <returns></returns>
        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsBackward(int roverInitialYCoordinate)
        {
            roverInitialYCoordinate = roverInitialYCoordinate - 1;
            return roverInitialYCoordinate; 
        }

        /// <summary>
        /// Gets the rovers final coordinate when its intial alignment is west and move command is backward.
        /// </summary>
        /// <param name="roverInitialXCoordinate">The rover initial x coordinate.</param>
        /// <returns></returns>
        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsBackward(int roverInitialXCoordinate)
        {
            roverInitialXCoordinate = roverInitialXCoordinate + 1;
            return roverInitialXCoordinate;
        }

        /// <summary>
        /// Gets the rovers final coordinate when its intial alignment is east and move command is backward.
        /// </summary>
        /// <param name="roverInitialXCoordinate">The rover initial x coordinate.</param>
        /// <returns></returns>
        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsBackward(int roverInitialXCoordinate)
        {
            roverInitialXCoordinate = roverInitialXCoordinate - 1;
            return roverInitialXCoordinate;
        }

        /// <summary>
        /// Gets the rovers final coordinate when its intial alignment is south and move command is backward.
        /// </summary>
        /// <param name="roverInitialYCoordinate">The rover initial y coordinate.</param>
        /// <returns></returns>
        public int GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsBackward(int roverInitialYCoordinate)
        {
            roverInitialYCoordinate = roverInitialYCoordinate + 1;
            return roverInitialYCoordinate;
        }
    }
}
