using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public interface IRoverBackwardMovementServices
    {
        int GetRoverBackwardMovementInXCoordinateWhenAlignmentIsEast(int roverXCoordinate);
        int GetRoverBackwardMovementInXCoordinateWhenAlignmentIsWest(int roverXCoordinate);
        int GetRoverBackwardMovementInYCoordinateWhenAlignmentIsNorth(int roverYCoordinate);

        int GetRoverBackwardMovementInYCoordinateWhenAlignmentIsSouth(int roverYCoordinate);
    }
}
