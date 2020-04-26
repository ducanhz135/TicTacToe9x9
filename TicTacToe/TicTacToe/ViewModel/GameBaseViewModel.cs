using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Model;

namespace TicTacToe.ViewModel
{
    public class GameBaseViewModel: BaseViewModel
    {
        public MarkType[] Results { get; set; }
        public bool IsGameEnd { get; set; }
        public MarkType Winner { get; set; }

        public virtual void FindWinner()
        {
            if (IsGameEnd)
            {
                return;
            }

            if (IsGameWon())
            {
                IsGameEnd = true;
            }

            if(!Results.Any(f=>f == MarkType.Free))
            {
                Winner = MarkType.Nought;
                IsGameEnd = true;
            }

        }

        private bool IsGameWon()
        {
            if (Results[0] != MarkType.Free && (Results[0] & Results[1] & Results[2]) == Results[0])
            {
                Winner = Results[0];
                return true;
            };

            if (Results[3] != MarkType.Free && (Results[3] & Results[4] & Results[5]) == Results[3])
            {
                Winner = Results[3];
                return true;
            };

            if (Results[6] != MarkType.Free && (Results[6] & Results[7] & Results[8]) == Results[6])
            {
                Winner = Results[6];
                return true;
            };

            if (Results[0] != MarkType.Free && (Results[0] & Results[3] & Results[6]) == Results[0])
            {
                Winner = Results[0];
                return true;
            };

            if (Results[1] != MarkType.Free && (Results[1] & Results[4] & Results[7]) == Results[1])
            {
                Winner = Results[1];
                return true;
            };

            if (Results[2] != MarkType.Free && (Results[2] & Results[5] & Results[8]) == Results[2])
            {
                Winner = Results[2];
                return true;
            };

            if (Results[0] != MarkType.Free && (Results[0] & Results[4] & Results[8]) == Results[0])
            {
                Winner = Results[0];
                return true;
            };

            if (Results[2] != MarkType.Free && (Results[2] & Results[4] & Results[6]) == Results[2])
            {
                Winner = Results[2];
                return true;
            };

            return false;
        }
    }
}
