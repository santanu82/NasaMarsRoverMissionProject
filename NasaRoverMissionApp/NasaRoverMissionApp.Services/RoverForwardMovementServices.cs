using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public class RoverForwardMovementServices: IRoverForwardMovementServices
    {
        /// <summary>
        /// Gets the rover forward movement in x coordinate when alignment is east.
        /// </summary>
        /// <param name="roverXCoordinate">The rover x coordinate.</param>
        /// <returns>returns the forward movement co-ordinate of the rover</returns>
        public int GetRoverForwardMovementInXCoordinateWhenAlignmentIsEast(int roverXCoordinate)
        {
            roverXCoordinate = roverXCoordinate+1;
            return roverXCoordinate;
        }

        /// <summary>
        /// Gets the rover forward movement in x coordinate when alignment is west.
        /// </summary>
        /// <param name="roverXCoordinate">The rover x coordinate.</param>
        /// <returns>returns the forward movement co-ordinate of the rover</returns>
        public int GetRoverForwardMovementInXCoordinateWhenAlignmentIsWest(int roverXCoordinate)
        {
            roverXCoordinate = roverXCoordinate - 1;
            return roverXCoordinate;
        }

        /// <summary>
        /// Gets the rover forward movement in y coordinate when alignment is north.
        /// </summary>
        /// <param name="roverYCoordinate">The rover y coordinate.</param>
        /// <returns>returns the forward movement co-ordinate of the rover</returns>
        public int GetRoverForwardMovementInYCoordinateWhenAlignmentIsNorth(int roverYCoordinate)
        {
            roverYCoordinate = roverYCoordinate + 1;
            return roverYCoordinate;
        }

        /// <summary>
        /// Gets the rover forward movement in y coordinate when alignment is south.
        /// </summary>
        /// <param name="roverYCoordinate">The rover y coordinate.</param>
        /// <returns>returns the forward movement co-ordinate of the rover</returns>
        public int GetRoverForwardMovementInYCoordinateWhenAlignmentIsSouth(int roverYCoordinate)
        {
            roverYCoordinate = roverYCoordinate - 1;
            return roverYCoordinate;
        }

       
    }
}
