using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public class RoverBackwardMovementServices : IRoverBackwardMovementServices
    {
        /// <summary>
        /// Gets the rover backward movement in x coordinate when alignment is east.
        /// </summary>
        /// <param name="roverXCoordinate">The rover x coordinate.</param>
        /// <returns>returns the backward movement co-ordinate of the rover</returns>
        public int GetRoverBackwardMovementInXCoordinateWhenAlignmentIsEast(int roverXCoordinate)
        {
            roverXCoordinate = roverXCoordinate - 1;
            return roverXCoordinate;
        }

        /// <summary>
        /// Gets the rover backward movement in x coordinate when alignment is west.
        /// </summary>
        /// <param name="roverXCoordinate">The rover x coordinate.</param>
        /// <returns>returns the backward movement co-ordinate of the rover</returns>
        public int GetRoverBackwardMovementInXCoordinateWhenAlignmentIsWest(int roverXCoordinate)
        {
            roverXCoordinate = roverXCoordinate + 1;
            return roverXCoordinate;
        }

        /// <summary>
        /// Gets the rover backward movement in y coordinate when alignment is north.
        /// </summary>
        /// <param name="roverYCoordinate">The rover y coordinate.</param>
        /// <returns>returns the backward movement co-ordinate of the rover</returns>
        public int GetRoverBackwardMovementInYCoordinateWhenAlignmentIsNorth(int roverYCoordinate)
        {
            roverYCoordinate = roverYCoordinate - 1;
            return roverYCoordinate;
        }

        /// <summary>
        /// Gets the rover backward movement in y coordinate when alignment is south.
        /// </summary>
        /// <param name="roverYCoordinate">The rover y coordinate.</param>
        /// <returns>returns the backward movement co-ordinate of the rover</returns>
        public int GetRoverBackwardMovementInYCoordinateWhenAlignmentIsSouth(int roverYCoordinate)
        {
            roverYCoordinate = roverYCoordinate + 1;
            return roverYCoordinate;
        }
    }
}
