using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public interface IRoverForwardMovementServices
    {
        int GetRoverForwardMovementInXCoordinateWhenAlignmentIsEast(int roverXCoordinate);

        int GetRoverForwardMovementInXCoordinateWhenAlignmentIsWest(int roverXCoordinate);

        int GetRoverForwardMovementInYCoordinateWhenAlignmentIsNorth(int roverYCoordinate);

        int GetRoverForwardMovementInYCoordinateWhenAlignmentIsSouth(int roverYCoordinate);
    }
}
