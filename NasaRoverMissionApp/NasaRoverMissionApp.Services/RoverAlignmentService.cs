using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRoverMissionApp.Services
{
    public class RoverAlignmentService: IRoverAlignmentService
    {
        /// <summary>
        /// Gets the changed rover alignment when initial alignment is east and motion instruction is r.
        /// </summary>
        /// <param name="roverMoveCommand">The rover move command.</param>
        /// <returns>returns the final alignment of the rover</returns>
        public string GetChangedRoverAlignmentWhenInitialAlignmentIsEastAndMotionInstructionIsR(char roverMoveCommand)
        {
            return "S";
        }

        /// <summary>
        /// Gets the changed rover alignment when initial alignment is north and motion instruction is r.
        /// </summary>
        /// <param name="roverMoveCommand">The rover move command.</param>
        /// <returns>returns the final alignment of the rover</returns>
        public string GetChangedRoverAlignmentWhenInitialAlignmentIsNorthAndMotionInstructionIsR(char roverMoveCommand)
        {
            return "E";
        }

        /// <summary>
        /// Gets the changed rover alignment when initial alignment is west and motion instruction is r.
        /// </summary>
        /// <param name="roverMoveCommand">The rover move command.</param>
        /// <returns>returns the final alignment of the rover</returns>
        public string GetChangedRoverAlignmentWhenInitialAlignmentIsWestAndMotionInstructionIsR(char roverMoveCommand)
        {
            return "N";
        }

        /// <summary>
        /// Gets the changed rover alignment when initial alignment is south and motion instruction is r.
        /// </summary>
        /// <param name="roverMoveCommand">The rover move command.</param>
        /// <returns>returns the final alignment of the rover</returns>
        public string GetChangedRoverAlignmentWhenInitialAlignmentIsSouthAndMotionInstructionIsR(char roverMoveCommand)
        {
            return "W";
        }

        /// <summary>
        /// Gets the changed rover alignment when initial alignment is north and motion instruction is l.
        /// </summary>
        /// <param name="roverMoveCommand">The rover move command.</param>
        /// <returns>returns the final alignment of the rover</returns>
        public string GetChangedRoverAlignmentWhenInitialAlignmentIsNorthAndMotionInstructionIsL(char roverMoveCommand)
        {
            return "W";
        }

        /// <summary>
        /// Gets the changed rover alignment when initial alignment is east and motion instruction is l.
        /// </summary>
        /// <param name="roverMoveCommand">The rover move command.</param>
        /// <returns>returns the final alignment of the rover</returns>
        public string GetChangedRoverAlignmentWhenInitialAlignmentIsEastAndMotionInstructionIsL(char roverMoveCommand)
        {
            return "N";
        }

        /// <summary>
        /// Gets the changed rover alignment when initial alignment is south and motion instruction is l.
        /// </summary>
        /// <param name="roverMoveCommand">The rover move command.</param>
        /// <returns>returns the final alignment of the rover</returns>
        public string GetChangedRoverAlignmentWhenInitialAlignmentIsSouthAndMotionInstructionIsL(char roverMoveCommand)
        {
            return "E";
        }

        /// <summary>
        /// Gets the changed rover alignment when initial alignment is west and motion instruction is l.
        /// </summary>
        /// <param name="roverMoveCommand">The rover move command.</param>
        /// <returns>returns the final alignment of the rover</returns>
        public string GetChangedRoverAlignmentWhenInitialAlignmentIsWestAndMotionInstructionIsL(char roverMoveCommand)
        {
            return "S";
        }
    }
}
