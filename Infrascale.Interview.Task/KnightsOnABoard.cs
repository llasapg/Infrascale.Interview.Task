using System;
using System.Collections.Generic;

namespace Infrascale.Interview.Task
{
    /// <summary>
    /// Class to represent the task "Knights On A Board"
    /// </summary>
    public class KnightsOnABoard
    {
        #region Task description
        /*
        Write a function that returns true if the knights are placed on a chessboard
        such that no knight can capture another knight.
        Here, 0s represent empty squares and 1s represent knights.
        */
        #endregion

        /// <summary>
        /// As I understood, so that the knight could not capture another,
        /// there should be only zeros in front of him and near him
        /// </summary>
        /// <returns></returns>
        public bool CheckThatKnigthCantCaptureAnother(int[,] chessPlate)
        {
            var positionsOfKnigths = new List<Knigth>(); // to save all of the knigth positions

            for (var i = 0; i < 8; i++)
            {
                // Knights can be present in any of the 64 squares ==> 8 elements in each row
                for (var j = 0; j < 8; j++)
                {
                    if(chessPlate[i, j] == 1) // save all the knigths with their position
                    {
                        positionsOfKnigths.Add(new Knigth { PositionX = i,PositionY = j });
                    }
                }
            }

            // Check
            foreach (var position in positionsOfKnigths)
            {
                if (position.PositionX != 0) // first row
                {
                    if (chessPlate[position.PositionX - 1, position.PositionY] != 0)
                    {
                        return false;
                    }
                }

                if (position.PositionY != 0) // its not the first element in the row
                {
                    if (chessPlate[position.PositionX, position.PositionY - 1] != 0)
                    {
                        return false;
                    }
                }

                if (position.PositionY < 7) // its not the last element in the row
                {
                    if (chessPlate[position.PositionX, position.PositionY + 1] != 0)
                    {
                        return false;
                    }
                }

                if (position.PositionX < 7)
                {
                    if (chessPlate[position.PositionX + 1, position.PositionY] != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }

    public class Knigth
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }
}
