using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public interface IRoverFinalPositionServices
    {
        int GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsForward(int roverInitialYCoordinate);

        int GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsForward(int roverInitialXCoordinate);

        int GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsForward(int roverInitialYCoordinate);

        int GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsForward(int roverInitialXCoordinate);

        int GetRoversFinalCoordinateWhenItsIntialAlignmentIsNorthAndMoveCommandIsBackward(int roverInitialYCoordinate);

        int GetRoversFinalCoordinateWhenItsIntialAlignmentIsWestAndMoveCommandIsBackward(int roverInitialXCoordinate);

        int GetRoversFinalCoordinateWhenItsIntialAlignmentIsEastAndMoveCommandIsBackward(int roverInitialXCoordinate);

        int GetRoversFinalCoordinateWhenItsIntialAlignmentIsSouthAndMoveCommandIsBackward(int roverInitialYCoordinate);
    }
}
