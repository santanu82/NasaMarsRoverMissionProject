using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public interface IRoverAlignmentService
    {
        string GetChangedRoverAlignmentWhenInitialAlignmentIsEastAndMotionInstructionIsR(char roverMoveCommand);
        string GetChangedRoverAlignmentWhenInitialAlignmentIsNorthAndMotionInstructionIsR(char roverMoveCommand);
        string GetChangedRoverAlignmentWhenInitialAlignmentIsWestAndMotionInstructionIsR(char roverMoveCommand);
        string GetChangedRoverAlignmentWhenInitialAlignmentIsSouthAndMotionInstructionIsR(char roverMoveCommand);
        string GetChangedRoverAlignmentWhenInitialAlignmentIsNorthAndMotionInstructionIsL(char roverMoveCommand);
        string GetChangedRoverAlignmentWhenInitialAlignmentIsEastAndMotionInstructionIsL(char roverMoveCommand);
        string GetChangedRoverAlignmentWhenInitialAlignmentIsSouthAndMotionInstructionIsL(char roverMoveCommand);
        string GetChangedRoverAlignmentWhenInitialAlignmentIsWestAndMotionInstructionIsL(char roverMoveCommand);
    }
}
