using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using TicTacToe.Model;
using System.Windows.Media;
using System.Collections.Generic;

namespace TicTacToe.ViewModel
{
    public class GameViewModel : GameBaseViewModel
    {
        string Cross = "X";
        string Nought = "O";

        public int AllowedBigGameIndex { get; set; } = -1;

        public bool IsPlayer1Turn { get; set; } = true;

        public List<BigSquare> BigSquares { get; set; } = new List<BigSquare>();

        public ICommand TickCommand { get; set; }

        public GameViewModel()
        {
            TickCommand = new RelayCommand<SmallSquare>(
                (p) => {
                    if (p == null)
                        return false;
                    return p.IsEnable;
                },
                (smallSquare) =>
                {
                    // get bigSquare and smallSquare index
                    var BigSquareIndex = smallSquare.BigSquareIndex;
                    var SmallSquareIndex = smallSquare.SmallSquareIndex;

                    // check if current bigSquareIndex not allowed and allowedIndex not -1 then do nothing
                    if(BigSquareIndex != AllowedBigGameIndex && AllowedBigGameIndex != -1)
                    {
                        return;
                    }


                    // set content to current smallSquare and disable the cell 
                    smallSquare.ContentButton = IsPlayer1Turn ? Cross : Nought;
                    smallSquare.Color = IsPlayer1Turn ? Brushes.Blue: Brushes.Red;
                    smallSquare.IsEnable = false;


                    // set the value to the cell via bigSquareindex and switch the player's turn
                    var BigSquare = BigSquares[BigSquareIndex];
                    BigSquare.Results[SmallSquareIndex] = IsPlayer1Turn ? MarkType.Cross : MarkType.Nought;

                    IsPlayer1Turn = !IsPlayer1Turn;

                    // check winner of that bigSquare
                    BigSquare.FindWinner();

                    // if found winner of that big square then set value to the whole big square and disable all small cell in it
                    if (BigSquare.IsGameEnd)
                    {
                        var FoundWinner = BigSquare.Winner != MarkType.Free;
                        if (FoundWinner)
                        {
                            Results[BigSquareIndex] = BigSquare.Winner;
                        }

                        BigSquare.SmallSquares.ForEach((p) =>
                        {
                            p.IsEnable = false;

                        });


                    }


                    // check winner of whole game

                    FindWinner();
                    if (Winner != MarkType.Free)
                    {
                        MessageBox.Show("The Winner is: " + (Winner == MarkType.Cross ? Cross : Nought));

                    }

                    // check winner of the next allowed big square and set suitable value to its allowedbigGame index

                    BigSquares[SmallSquareIndex].FindWinner();

                   AllowedBigGameIndex = BigSquares[SmallSquareIndex].IsGameEnd ? -1 : SmallSquareIndex;

                });

            for (int i = 0; i < 9; i++)
            {
                var BigSquare = new BigSquare(i);

                BigSquares.Add(BigSquare);
            }

            IsGameEnd = false;
            Results = new MarkType[9];

        }

        public override void FindWinner()
        {
            base.FindWinner();
            if (IsGameEnd)
            {
                AllowedBigGameIndex = -1;
            }
        }
    }

    public class BigSquare: GameBaseViewModel
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public List<SmallSquare> SmallSquares { get; set; } = new List<SmallSquare>();

        public BigSquare(int index)
        {
            for (int i = 0; i < 9; i++)
            {

                var SmallSquare = new SmallSquare(i, index);

                SmallSquares.Add(SmallSquare);
            }

            Row = index / 3;
            Column = index % 3;
            IsGameEnd = false;
            Results = new MarkType[9];


        }
    }


    public class SmallSquare: GameBaseViewModel
    {
        private SolidColorBrush _color;
        private SolidColorBrush _backgroundColor = Brushes.LightGray;

        private string _ContentButton;
        public string ContentButton
        {
            get { return _ContentButton; }
            set
            {
                _ContentButton = value;
                OnPropertyChanged();
            }
        }
        private bool _IsEnable = true;
        public bool IsEnable
        {
            get { return _IsEnable; }
            set
            {
                _IsEnable = value;
                OnPropertyChanged();
            }
        }

        public SolidColorBrush Color
        {
            get { return _color; }
            set
            {
                _color = value;
                OnPropertyChanged();
            }
        }

        public SolidColorBrush BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                OnPropertyChanged();
            }
        }

        public int Row { get; set; }
        public int Column { get; set; }

        public int BigSquareIndex { get; set; }
        public int SmallSquareIndex { get; set; }

        public SmallSquare(int SmallSquareIndex, int BigSquareIndex)
        {
            this.BigSquareIndex = BigSquareIndex;
            this.SmallSquareIndex = SmallSquareIndex;
            Row = SmallSquareIndex / 3;
            Column = SmallSquareIndex % 3;

        }

    }

}
