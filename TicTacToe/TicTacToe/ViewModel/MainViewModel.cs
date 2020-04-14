using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using TicTacToe.Model;
using System.Windows.Media;
using System.Collections.Generic;

namespace TicTacToe.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        string Cross = "X";
        string Nought = "O";

        private MarkType[,] miniGame;

        private MarkType[] bigGame;

        private bool isPlayer1Turn;

        private bool isGameEnded;

        private List<MarkType> MarkTypes;

        #region IsMiniGameTie
        private bool IsMiniGameTie;
        private bool IsMiniGame1Tie;
        private bool IsMiniGame2Tie;
        private bool IsMiniGame3Tie;
        private bool IsMiniGame4Tie;
        private bool IsMiniGame5Tie;
        private bool IsMiniGame6Tie;
        private bool IsMiniGame7Tie;
        private bool IsMiniGame8Tie;
        #endregion

        #region GridEnable
        private bool _IsGridEnabled;
        public bool IsGridEnabled { get => _IsGridEnabled; set { _IsGridEnabled = value; OnPropertyChanged(); } }

        private bool _IsGridEnabled1;
        public bool IsGridEnabled1 { get => _IsGridEnabled1; set { _IsGridEnabled1 = value; OnPropertyChanged(); } }

        private bool _IsGridEnabled2;
        public bool IsGridEnabled2 { get => _IsGridEnabled2; set { _IsGridEnabled2 = value; OnPropertyChanged(); } }

        private bool _IsGridEnabled3;
        public bool IsGridEnabled3 { get => _IsGridEnabled3; set { _IsGridEnabled3 = value; OnPropertyChanged(); } }

        private bool _IsGridEnabled4;
        public bool IsGridEnabled4 { get => _IsGridEnabled4; set { _IsGridEnabled4 = value; OnPropertyChanged(); } }

        private bool _IsGridEnabled5;
        public bool IsGridEnabled5 { get => _IsGridEnabled5; set { _IsGridEnabled5 = value; OnPropertyChanged(); } }

        private bool _IsGridEnabled6;
        public bool IsGridEnabled6 { get => _IsGridEnabled6; set { _IsGridEnabled6 = value; OnPropertyChanged(); } }

        private bool _IsGridEnabled7;
        public bool IsGridEnabled7 { get => _IsGridEnabled7; set { _IsGridEnabled7 = value; OnPropertyChanged(); } }

        private bool _IsGridEnabled8;
        public bool IsGridEnabled8 { get => _IsGridEnabled8; set { _IsGridEnabled8 = value; OnPropertyChanged(); } }

        #endregion

        #region Button content

        //game 0
        private string _ButtonContent000;
        public string ButtonContent000 { get => _ButtonContent000; set { _ButtonContent000 = value; OnPropertyChanged(); } }

        private string _ButtonContent010;
        public string ButtonContent010 { get => _ButtonContent010; set { _ButtonContent010 = value; OnPropertyChanged(); } }

        private string _ButtonContent020;
        public string ButtonContent020 { get => _ButtonContent020; set { _ButtonContent020 = value; OnPropertyChanged(); } }

        private string _ButtonContent001;
        public string ButtonContent001 { get => _ButtonContent001; set { _ButtonContent001 = value; OnPropertyChanged(); } }

        private string _ButtonContent011;
        public string ButtonContent011 { get => _ButtonContent011; set { _ButtonContent011 = value; OnPropertyChanged(); } }

        private string _ButtonContent021;
        public string ButtonContent021 { get => _ButtonContent021; set { _ButtonContent021 = value; OnPropertyChanged(); } }

        private string _ButtonContent002;
        public string ButtonContent002 { get => _ButtonContent002; set { _ButtonContent002 = value; OnPropertyChanged(); } }

        private string _ButtonContent012;
        public string ButtonContent012 { get => _ButtonContent012; set { _ButtonContent012 = value; OnPropertyChanged(); } }

        private string _ButtonContent022;
        public string ButtonContent022 { get => _ButtonContent022; set { _ButtonContent022 = value; OnPropertyChanged(); } }


        //game 1
        private string _ButtonContent100;
        public string ButtonContent100 { get => _ButtonContent100; set { _ButtonContent100 = value; OnPropertyChanged(); } }

        private string _ButtonContent110;
        public string ButtonContent110 { get => _ButtonContent110; set { _ButtonContent110 = value; OnPropertyChanged(); } }

        private string _ButtonContent120;
        public string ButtonContent120 { get => _ButtonContent120; set { _ButtonContent120 = value; OnPropertyChanged(); } }

        private string _ButtonContent101;
        public string ButtonContent101 { get => _ButtonContent101; set { _ButtonContent101 = value; OnPropertyChanged(); } }

        private string _ButtonContent111;
        public string ButtonContent111 { get => _ButtonContent111; set { _ButtonContent111 = value; OnPropertyChanged(); } }

        private string _ButtonContent121;
        public string ButtonContent121 { get => _ButtonContent121; set { _ButtonContent121 = value; OnPropertyChanged(); } }

        private string _ButtonContent102;
        public string ButtonContent102 { get => _ButtonContent102; set { _ButtonContent102 = value; OnPropertyChanged(); } }

        private string _ButtonContent112;
        public string ButtonContent112 { get => _ButtonContent112; set { _ButtonContent112 = value; OnPropertyChanged(); } }

        private string _ButtonContent122;
        public string ButtonContent122 { get => _ButtonContent122; set { _ButtonContent122 = value; OnPropertyChanged(); } }

        //game 2
        private string _ButtonContent200;
        public string ButtonContent200 { get => _ButtonContent200; set { _ButtonContent200 = value; OnPropertyChanged(); } }

        private string _ButtonContent210;
        public string ButtonContent210 { get => _ButtonContent210; set { _ButtonContent210 = value; OnPropertyChanged(); } }

        private string _ButtonContent220;
        public string ButtonContent220 { get => _ButtonContent220; set { _ButtonContent220 = value; OnPropertyChanged(); } }

        private string _ButtonContent201;
        public string ButtonContent201 { get => _ButtonContent201; set { _ButtonContent201 = value; OnPropertyChanged(); } }

        private string _ButtonContent211;
        public string ButtonContent211 { get => _ButtonContent211; set { _ButtonContent211 = value; OnPropertyChanged(); } }

        private string _ButtonContent221;
        public string ButtonContent221 { get => _ButtonContent221; set { _ButtonContent221 = value; OnPropertyChanged(); } }

        private string _ButtonContent202;
        public string ButtonContent202 { get => _ButtonContent202; set { _ButtonContent202 = value; OnPropertyChanged(); } }

        private string _ButtonContent212;
        public string ButtonContent212 { get => _ButtonContent212; set { _ButtonContent212 = value; OnPropertyChanged(); } }

        private string _ButtonContent222;
        public string ButtonContent222 { get => _ButtonContent222; set { _ButtonContent222 = value; OnPropertyChanged(); } }

        //game 3
        private string _ButtonContent300;
        public string ButtonContent300 { get => _ButtonContent300; set { _ButtonContent300 = value; OnPropertyChanged(); } }

        private string _ButtonContent310;
        public string ButtonContent310 { get => _ButtonContent310; set { _ButtonContent310 = value; OnPropertyChanged(); } }

        private string _ButtonContent320;
        public string ButtonContent320 { get => _ButtonContent320; set { _ButtonContent320 = value; OnPropertyChanged(); } }

        private string _ButtonContent301;
        public string ButtonContent301 { get => _ButtonContent301; set { _ButtonContent301 = value; OnPropertyChanged(); } }

        private string _ButtonContent311;
        public string ButtonContent311 { get => _ButtonContent311; set { _ButtonContent311 = value; OnPropertyChanged(); } }

        private string _ButtonContent321;
        public string ButtonContent321 { get => _ButtonContent321; set { _ButtonContent321 = value; OnPropertyChanged(); } }

        private string _ButtonContent302;
        public string ButtonContent302 { get => _ButtonContent302; set { _ButtonContent302 = value; OnPropertyChanged(); } }

        private string _ButtonContent312;
        public string ButtonContent312 { get => _ButtonContent312; set { _ButtonContent312 = value; OnPropertyChanged(); } }

        private string _ButtonContent322;
        public string ButtonContent322 { get => _ButtonContent322; set { _ButtonContent322 = value; OnPropertyChanged(); } }

        //game 4
        private string _ButtonContent400;
        public string ButtonContent400 { get => _ButtonContent400; set { _ButtonContent400 = value; OnPropertyChanged(); } }

        private string _ButtonContent410;
        public string ButtonContent410 { get => _ButtonContent410; set { _ButtonContent410 = value; OnPropertyChanged(); } }

        private string _ButtonContent420;
        public string ButtonContent420 { get => _ButtonContent420; set { _ButtonContent420 = value; OnPropertyChanged(); } }

        private string _ButtonContent401;
        public string ButtonContent401 { get => _ButtonContent401; set { _ButtonContent401 = value; OnPropertyChanged(); } }

        private string _ButtonContent411;
        public string ButtonContent411 { get => _ButtonContent411; set { _ButtonContent411 = value; OnPropertyChanged(); } }

        private string _ButtonContent421;
        public string ButtonContent421 { get => _ButtonContent421; set { _ButtonContent421 = value; OnPropertyChanged(); } }

        private string _ButtonContent402;
        public string ButtonContent402 { get => _ButtonContent402; set { _ButtonContent402 = value; OnPropertyChanged(); } }

        private string _ButtonContent412;
        public string ButtonContent412 { get => _ButtonContent412; set { _ButtonContent412 = value; OnPropertyChanged(); } }

        private string _ButtonContent422;
        public string ButtonContent422 { get => _ButtonContent422; set { _ButtonContent422 = value; OnPropertyChanged(); } }

        //game 5
        private string _ButtonContent500;
        public string ButtonContent500 { get => _ButtonContent500; set { _ButtonContent500 = value; OnPropertyChanged(); } }

        private string _ButtonContent510;
        public string ButtonContent510 { get => _ButtonContent510; set { _ButtonContent510 = value; OnPropertyChanged(); } }

        private string _ButtonContent520;
        public string ButtonContent520 { get => _ButtonContent520; set { _ButtonContent520 = value; OnPropertyChanged(); } }

        private string _ButtonContent501;
        public string ButtonContent501 { get => _ButtonContent501; set { _ButtonContent501 = value; OnPropertyChanged(); } }

        private string _ButtonContent511;
        public string ButtonContent511 { get => _ButtonContent511; set { _ButtonContent511 = value; OnPropertyChanged(); } }

        private string _ButtonContent521;
        public string ButtonContent521 { get => _ButtonContent521; set { _ButtonContent521 = value; OnPropertyChanged(); } }

        private string _ButtonContent502;
        public string ButtonContent502 { get => _ButtonContent502; set { _ButtonContent502 = value; OnPropertyChanged(); } }

        private string _ButtonContent512;
        public string ButtonContent512 { get => _ButtonContent512; set { _ButtonContent512 = value; OnPropertyChanged(); } }

        private string _ButtonContent522;
        public string ButtonContent522 { get => _ButtonContent522; set { _ButtonContent522 = value; OnPropertyChanged(); } }

        //game 6
        private string _ButtonContent600;
        public string ButtonContent600 { get => _ButtonContent600; set { _ButtonContent600 = value; OnPropertyChanged(); } }

        private string _ButtonContent610;
        public string ButtonContent610 { get => _ButtonContent610; set { _ButtonContent610 = value; OnPropertyChanged(); } }

        private string _ButtonContent620;
        public string ButtonContent620 { get => _ButtonContent620; set { _ButtonContent620 = value; OnPropertyChanged(); } }

        private string _ButtonContent601;
        public string ButtonContent601 { get => _ButtonContent601; set { _ButtonContent601 = value; OnPropertyChanged(); } }

        private string _ButtonContent611;
        public string ButtonContent611 { get => _ButtonContent611; set { _ButtonContent611 = value; OnPropertyChanged(); } }

        private string _ButtonContent621;
        public string ButtonContent621 { get => _ButtonContent621; set { _ButtonContent621 = value; OnPropertyChanged(); } }

        private string _ButtonContent602;
        public string ButtonContent602 { get => _ButtonContent602; set { _ButtonContent602 = value; OnPropertyChanged(); } }

        private string _ButtonContent612;
        public string ButtonContent612 { get => _ButtonContent612; set { _ButtonContent612 = value; OnPropertyChanged(); } }

        private string _ButtonContent622;
        public string ButtonContent622 { get => _ButtonContent622; set { _ButtonContent622 = value; OnPropertyChanged(); } }

        //game 7
        private string _ButtonContent700;
        public string ButtonContent700 { get => _ButtonContent700; set { _ButtonContent700 = value; OnPropertyChanged(); } }

        private string _ButtonContent710;
        public string ButtonContent710 { get => _ButtonContent710; set { _ButtonContent710 = value; OnPropertyChanged(); } }

        private string _ButtonContent720;
        public string ButtonContent720 { get => _ButtonContent720; set { _ButtonContent720 = value; OnPropertyChanged(); } }

        private string _ButtonContent701;
        public string ButtonContent701 { get => _ButtonContent701; set { _ButtonContent701 = value; OnPropertyChanged(); } }

        private string _ButtonContent711;
        public string ButtonContent711 { get => _ButtonContent711; set { _ButtonContent711 = value; OnPropertyChanged(); } }

        private string _ButtonContent721;
        public string ButtonContent721 { get => _ButtonContent721; set { _ButtonContent721 = value; OnPropertyChanged(); } }

        private string _ButtonContent702;
        public string ButtonContent702 { get => _ButtonContent702; set { _ButtonContent702 = value; OnPropertyChanged(); } }

        private string _ButtonContent712;
        public string ButtonContent712 { get => _ButtonContent712; set { _ButtonContent712 = value; OnPropertyChanged(); } }

        private string _ButtonContent722;
        public string ButtonContent722 { get => _ButtonContent722; set { _ButtonContent722 = value; OnPropertyChanged(); } }

        //game 8
        private string _ButtonContent800;
        public string ButtonContent800 { get => _ButtonContent800; set { _ButtonContent800 = value; OnPropertyChanged(); } }

        private string _ButtonContent810;
        public string ButtonContent810 { get => _ButtonContent810; set { _ButtonContent810 = value; OnPropertyChanged(); } }

        private string _ButtonContent820;
        public string ButtonContent820 { get => _ButtonContent820; set { _ButtonContent820 = value; OnPropertyChanged(); } }

        private string _ButtonContent801;
        public string ButtonContent801 { get => _ButtonContent801; set { _ButtonContent801 = value; OnPropertyChanged(); } }

        private string _ButtonContent811;
        public string ButtonContent811 { get => _ButtonContent811; set { _ButtonContent811 = value; OnPropertyChanged(); } }

        private string _ButtonContent821;
        public string ButtonContent821 { get => _ButtonContent821; set { _ButtonContent821 = value; OnPropertyChanged(); } }

        private string _ButtonContent802;
        public string ButtonContent802 { get => _ButtonContent802; set { _ButtonContent802 = value; OnPropertyChanged(); } }

        private string _ButtonContent812;
        public string ButtonContent812 { get => _ButtonContent812; set { _ButtonContent812 = value; OnPropertyChanged(); } }

        private string _ButtonContent822;
        public string ButtonContent822 { get => _ButtonContent822; set { _ButtonContent822 = value; OnPropertyChanged(); } }

        #endregion

        #region TickCommand

        public ICommand TickCommand000 { get; set; }
        public ICommand TickCommand010 { get; set; }
        public ICommand TickCommand020 { get; set; }
        public ICommand TickCommand001 { get; set; }
        public ICommand TickCommand011 { get; set; }
        public ICommand TickCommand021 { get; set; }
        public ICommand TickCommand002 { get; set; }
        public ICommand TickCommand012 { get; set; }
        public ICommand TickCommand022 { get; set; }

        public ICommand TickCommand100 { get; set; }
        public ICommand TickCommand110 { get; set; }
        public ICommand TickCommand120 { get; set; }
        public ICommand TickCommand101 { get; set; }
        public ICommand TickCommand111 { get; set; }
        public ICommand TickCommand121 { get; set; }
        public ICommand TickCommand102 { get; set; }
        public ICommand TickCommand112 { get; set; }
        public ICommand TickCommand122 { get; set; }

        public ICommand TickCommand200 { get; set; }
        public ICommand TickCommand210 { get; set; }
        public ICommand TickCommand220 { get; set; }
        public ICommand TickCommand201 { get; set; }
        public ICommand TickCommand211 { get; set; }
        public ICommand TickCommand221 { get; set; }
        public ICommand TickCommand202 { get; set; }
        public ICommand TickCommand212 { get; set; }
        public ICommand TickCommand222 { get; set; }

        public ICommand TickCommand300 { get; set; }
        public ICommand TickCommand310 { get; set; }
        public ICommand TickCommand320 { get; set; }
        public ICommand TickCommand301 { get; set; }
        public ICommand TickCommand311 { get; set; }
        public ICommand TickCommand321 { get; set; }
        public ICommand TickCommand302 { get; set; }
        public ICommand TickCommand312 { get; set; }
        public ICommand TickCommand322 { get; set; }

        public ICommand TickCommand400 { get; set; }
        public ICommand TickCommand410 { get; set; }
        public ICommand TickCommand420 { get; set; }
        public ICommand TickCommand401 { get; set; }
        public ICommand TickCommand411 { get; set; }
        public ICommand TickCommand421 { get; set; }
        public ICommand TickCommand402 { get; set; }
        public ICommand TickCommand412 { get; set; }
        public ICommand TickCommand422 { get; set; }

        public ICommand TickCommand500 { get; set; }
        public ICommand TickCommand510 { get; set; }
        public ICommand TickCommand520 { get; set; }
        public ICommand TickCommand501 { get; set; }
        public ICommand TickCommand511 { get; set; }
        public ICommand TickCommand521 { get; set; }
        public ICommand TickCommand502 { get; set; }
        public ICommand TickCommand512 { get; set; }
        public ICommand TickCommand522 { get; set; }

        public ICommand TickCommand600 { get; set; }
        public ICommand TickCommand610 { get; set; }
        public ICommand TickCommand620 { get; set; }
        public ICommand TickCommand601 { get; set; }
        public ICommand TickCommand611 { get; set; }
        public ICommand TickCommand621 { get; set; }
        public ICommand TickCommand602 { get; set; }
        public ICommand TickCommand612 { get; set; }
        public ICommand TickCommand622 { get; set; }

        public ICommand TickCommand700 { get; set; }
        public ICommand TickCommand710 { get; set; }
        public ICommand TickCommand720 { get; set; }
        public ICommand TickCommand701 { get; set; }
        public ICommand TickCommand711 { get; set; }
        public ICommand TickCommand721 { get; set; }
        public ICommand TickCommand702 { get; set; }
        public ICommand TickCommand712 { get; set; }
        public ICommand TickCommand722 { get; set; }

        public ICommand TickCommand800 { get; set; }
        public ICommand TickCommand810 { get; set; }
        public ICommand TickCommand820 { get; set; }
        public ICommand TickCommand801 { get; set; }
        public ICommand TickCommand811 { get; set; }
        public ICommand TickCommand821 { get; set; }
        public ICommand TickCommand802 { get; set; }
        public ICommand TickCommand812 { get; set; }
        public ICommand TickCommand822 { get; set; }

        #endregion


        public ICommand LoadedWindowCommand { get; set; }

        public MainViewModel()
        {

            // grid col row
            #region TickCommand


            /// Grid 0
            TickCommand000 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) => {

                SetContentToResults(0, 0);
                
                ButtonContent000 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                EnableGrid(true, false, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if(!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {

                    bigGame[0] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand010 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(0,1);

                ButtonContent010 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                EnableGrid(false, true, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {

                    bigGame[0] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand020 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(0, 2);

                ButtonContent020 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                EnableGrid(false, false, true, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {

                    bigGame[0] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand001 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(1, 0);

                ButtonContent001 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(true, false, false, true, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {

                    bigGame[0] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand011 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(1, 1);

                ButtonContent011 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, false, false, false, true, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {

                    bigGame[0] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand021 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(1, 2);

                ButtonContent021 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, false, false, false, false, true, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {

                    bigGame[0] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand002 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(2, 0);

                ButtonContent002 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, false, false, false, false, false, true, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {

                    bigGame[0] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand012 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(2, 1);

                ButtonContent012 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, false, false, false, false, false, false, true, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {

                    bigGame[0] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand022 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(2, 2);

                ButtonContent022 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(true, false, false, false, false, false, false, false, true);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {

                    bigGame[0] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            /// Grid 1
            TickCommand100 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                SetContentToResults(0, 3);

                ButtonContent100 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(true, false, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie. limit change by grid
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8
                    bigGame[1] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand110 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(0, 4);

                ButtonContent110 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, true, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8
                    bigGame[1] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand120 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(0, 5);

                ButtonContent120 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, false, true, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8
                    bigGame[1] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand101 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(1, 3);

                ButtonContent101 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, false, false, true, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8
                    bigGame[1] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand111 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(1, 4);

                ButtonContent111 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, false, false, false, true, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8
                    bigGame[1] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand121 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(1, 5);

                ButtonContent121 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, false, false, false, false, true, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8
                    bigGame[1] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand102 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(2, 3);

                ButtonContent102 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, false, false, false, false, false, true, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8
                    bigGame[1] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand112 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(2, 4);

                ButtonContent112 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, false, false, false, false, false, false, true, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8
                    bigGame[1] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand122 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(2, 5);

                ButtonContent122 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, false, false, false, false, false, false, false, true);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8
                    bigGame[1] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            // Grid 2
            TickCommand200 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {
                //X
                SetContentToResults(0, 6);

                ButtonContent200 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(true, false, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 0; i < 3; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[2] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand210 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                SetContentToResults(0, 7);

                ButtonContent210 = isPlayer1Turn ? Cross : Nought;

                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                EnableGrid(false, true, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 0; i < 3; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8
                    bigGame[2] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand220 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(0, 8);
                ButtonContent220 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, true, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();

                //X row
                for (int i = 0; i < 3; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[2] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand201 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(1, 6);
                ButtonContent201 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, true, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 0; i < 3; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[2] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand211 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(1, 7);
                ButtonContent211 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, true, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 0; i < 3; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[2] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand221 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                //X
                SetContentToResults(1, 8);
                ButtonContent221 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, true, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 0; i < 3; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[2] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand202 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                //X
                SetContentToResults(2, 6);
                ButtonContent202 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, true, false, false, false, true, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 0; i < 3; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[2] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand212 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                //X
                SetContentToResults(2, 7);
                ButtonContent212 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, true, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 0; i < 3; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[2] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand222 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(2, 8);
                ButtonContent222 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, true, false, false, false, false, false, true);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 0; i < 3; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[2] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            // Grid 3
            TickCommand300 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(3, 0);
                ButtonContent300 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(true, false, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[3] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();

            });

            TickCommand310 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                //X
                SetContentToResults(3, 1);
                ButtonContent310 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, true, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[3] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand320 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                //X
                SetContentToResults(3, 2);
                ButtonContent320 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, true, true, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[3] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand301 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(4, 0);
                ButtonContent301 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, true, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[3] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand311 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                //X
                SetContentToResults(4, 1);
                ButtonContent311 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, true, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[3] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand321 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(4, 2);
                ButtonContent321 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, true, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[3] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand302 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(5, 0);
                ButtonContent302 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, true, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[3] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand312 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(5, 1);
                ButtonContent312 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, true, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[3] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand322 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(5, 2);
                ButtonContent322 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, false, true);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    //X
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[3] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });


            // Grid 4
            TickCommand400 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(3, 3);
                ButtonContent400 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(true, false, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {
                    
                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[4] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand410 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                //X
                SetContentToResults(3, 4);
                ButtonContent410 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, true, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[4] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand420 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(3, 5);
                ButtonContent420 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, true, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[4] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand401 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                //X
                SetContentToResults(4, 3);
                ButtonContent401 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, true, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[4] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand411 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(4, 4);
                ButtonContent411 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, true, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[4] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand421 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(4, 5);
                ButtonContent421 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, true, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[4] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand402 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                //X
                SetContentToResults(5, 3);
                ButtonContent402 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, true, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[4] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand412 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(5, 4);
                ButtonContent412 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, true, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[4] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand422 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(5, 5);
                ButtonContent422 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, false, true);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[4] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            // Grid 5
            TickCommand500 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(3, 6);
                ButtonContent500 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(true, false, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[5] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand510 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(3, 7);
                ButtonContent510 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, true, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[5] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand520 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(3, 8);
                ButtonContent520 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, true, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[5] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand501 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {


                //X
                SetContentToResults(4, 6);
                ButtonContent501 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, true, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[5] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand511 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(4, 7);
                ButtonContent511 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, true, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[5] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand521 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(4, 8);
                ButtonContent521 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, true, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[5] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand502 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(5, 6);
                ButtonContent502 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, true, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[5] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand512 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(5, 7);
                ButtonContent512 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, true, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[5] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand522 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(5, 8);
                ButtonContent522 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, false, true);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 3; i < 6; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[5] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            // Grid 6
            TickCommand600 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(6, 0);
                ButtonContent600 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(true, false, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[6] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand610 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(6, 1);
                ButtonContent610 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, true, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[6] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand620 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(6, 2);
                ButtonContent620 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, true, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[6] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand601 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(7, 0);
                ButtonContent601 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, true, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[6] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand611 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(7, 1);
                ButtonContent611 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, true, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[6] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand621 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(7, 2);
                ButtonContent621 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, true, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[6] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand602 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(8, 0);
                ButtonContent602 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, true, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[6] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand612 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(8, 1);
                ButtonContent612 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, true, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[6] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand622 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(8, 2);
                ButtonContent622 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, false, true);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 0; j < 3; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[6] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            //Grid 7
            TickCommand700 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(6, 3);
                ButtonContent700 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(true, false, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[7] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand710 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(6, 4);
                ButtonContent710 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, true, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[7] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand720 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(6, 5);
                ButtonContent720 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, true, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[7] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand701 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(7, 3);
                ButtonContent701 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, true, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[7] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand711 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(7, 4);
                ButtonContent711 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, true, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[7] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand721 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(7, 5);
                ButtonContent721 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, true, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[7] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand702 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(8, 3);
                ButtonContent702 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, true, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[7] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand712 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(8, 4);
                ButtonContent712 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, true, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[7] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand722 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(8, 5);
                ButtonContent722 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, false, true);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 3; j < 6; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[7] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });


            // Grid 8
            TickCommand800 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(6, 6);
                ButtonContent800 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(true, false, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[8] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand810 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(6, 7);
                ButtonContent810 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, true, false, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[8] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand820 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(6, 8);
                ButtonContent820 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, true, false, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[8] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand801 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(7, 6);
                ButtonContent801 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, true, false, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[8] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand811 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(7, 7);
                ButtonContent811 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, true, false, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[8] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand821 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(7, 8);
                ButtonContent821 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, true, false, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[8] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand802 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(8, 6);
                ButtonContent802 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, true, false, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[8] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand812 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(8, 7);
                ButtonContent812 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, true, false);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[8] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            TickCommand822 = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (button) =>
            {

                //X
                SetContentToResults(8, 8);
                ButtonContent822 = isPlayer1Turn ? Cross : Nought;
                #region enableGrid
                // grid 0 1 2 3 4 5 6 7 8
                //X
                EnableGrid(false, false, false, false, false, false, false, false, true);
                #endregion

                // Todo check game tie
                if (!bigGame.Any(f => f == MarkType.Free))
                {

                    isGameEnded = true;

                }

                // check mini game tie
                MarkTypes = new List<MarkType>();
                //X row
                for (int i = 6; i < 9; i++)
                {
                    //X col
                    for (int j = 6; j < 9; j++)
                    {
                        MarkTypes.Add(miniGame[i, j]);
                    }
                }

                if (!MarkTypes.Any(f => f == MarkType.Free))
                {

                    EnableGrid(true, true, true, true, true, true, true, true, true);
                }

                #region Horizontal Wins

                if (IsMiniGameWon())
                {
                    // game 0 1 2 3 4 5 6 7 8 
                    //X
                    bigGame[8] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;


                }

                #endregion

                DefineNextPlayerOrWinner();
            });

            #endregion

            LoadedWindowCommand = new RelayCommand<Grid>((p) => { return true; }, (p) =>
            {

                if (p == null)
                    return;
                IsGridEnabled = true;
                IsGridEnabled1 = true;
                IsGridEnabled2 = true;
                IsGridEnabled3 = true;
                IsGridEnabled4 = true;
                IsGridEnabled5 = true;
                IsGridEnabled6 = true;
                IsGridEnabled7 = true;
                IsGridEnabled8 = true;

                FreeResults();

            });

        }

        private void NewGame()
        {
            FreeResults();

            isGameEnded = false;
        }


        private void FreeResults()
        {
            bigGame = new MarkType[9];
            miniGame = new MarkType[9,9];

            for (var i = 0; i < miniGame.GetLength(0); i++)
            {
                bigGame[i] = MarkType.Free;

                for (int j = 0; j < miniGame.GetLength(1); j++)
                {
                    miniGame[i,j] = MarkType.Free;
                }
                
            }
                

            isPlayer1Turn = true;

            #region ButtonContent

            ButtonContent000 = string.Empty;
            ButtonContent010 = string.Empty;
            ButtonContent020 = string.Empty;
            ButtonContent001 = string.Empty;
            ButtonContent011 = string.Empty;
            ButtonContent021 = string.Empty;
            ButtonContent002 = string.Empty;
            ButtonContent012 = string.Empty;
            ButtonContent022 = string.Empty;

            ButtonContent100 = string.Empty;
            ButtonContent110 = string.Empty;
            ButtonContent120 = string.Empty;
            ButtonContent101 = string.Empty;
            ButtonContent111 = string.Empty;
            ButtonContent121 = string.Empty;
            ButtonContent102 = string.Empty;
            ButtonContent112 = string.Empty;
            ButtonContent122 = string.Empty;

            ButtonContent200 = string.Empty;
            ButtonContent210 = string.Empty;
            ButtonContent220 = string.Empty;
            ButtonContent201 = string.Empty;
            ButtonContent211 = string.Empty;
            ButtonContent221 = string.Empty;
            ButtonContent202 = string.Empty;
            ButtonContent212 = string.Empty;
            ButtonContent222 = string.Empty;

            ButtonContent300 = string.Empty;
            ButtonContent310 = string.Empty;
            ButtonContent320 = string.Empty;
            ButtonContent301 = string.Empty;
            ButtonContent311 = string.Empty;
            ButtonContent321 = string.Empty;
            ButtonContent302 = string.Empty;
            ButtonContent312 = string.Empty;
            ButtonContent322 = string.Empty;

            ButtonContent400 = string.Empty;
            ButtonContent410 = string.Empty;
            ButtonContent420 = string.Empty;
            ButtonContent401 = string.Empty;
            ButtonContent411 = string.Empty;
            ButtonContent421 = string.Empty;
            ButtonContent402 = string.Empty;
            ButtonContent412 = string.Empty;
            ButtonContent422 = string.Empty;

            ButtonContent500 = string.Empty;
            ButtonContent510 = string.Empty;
            ButtonContent520 = string.Empty;
            ButtonContent501 = string.Empty;
            ButtonContent511 = string.Empty;
            ButtonContent521 = string.Empty;
            ButtonContent502 = string.Empty;
            ButtonContent512 = string.Empty;
            ButtonContent522 = string.Empty;

            ButtonContent600 = string.Empty;
            ButtonContent610 = string.Empty;
            ButtonContent620 = string.Empty;
            ButtonContent601 = string.Empty;
            ButtonContent611 = string.Empty;
            ButtonContent621 = string.Empty;
            ButtonContent602 = string.Empty;
            ButtonContent612 = string.Empty;
            ButtonContent622 = string.Empty;

            ButtonContent700 = string.Empty;
            ButtonContent710 = string.Empty;
            ButtonContent720 = string.Empty;
            ButtonContent701 = string.Empty;
            ButtonContent711 = string.Empty;
            ButtonContent721 = string.Empty;
            ButtonContent702 = string.Empty;
            ButtonContent712 = string.Empty;
            ButtonContent722 = string.Empty;

            ButtonContent800 = string.Empty;
            ButtonContent810 = string.Empty;
            ButtonContent820 = string.Empty;
            ButtonContent801 = string.Empty;
            ButtonContent811 = string.Empty;
            ButtonContent821 = string.Empty;
            ButtonContent802 = string.Empty;
            ButtonContent812 = string.Empty;
            ButtonContent822 = string.Empty;

            #endregion



        }

        private void CheckForMiniGameWinner()
        {

            if (IsBigGameWon())
            {
                isGameEnded = true;
            }

            #region No Winners


            if (!bigGame.Any(f => f == MarkType.Free))
            {

                isGameEnded = true;

            }

            #endregion

            
        }

        private void SetContentToResults(int row, int col)
        {

            if (miniGame[row,col] != MarkType.Free)
                return;

            miniGame[row,col] = isPlayer1Turn ? MarkType.Cross : MarkType.Nought;
        }

        private void DefineNextPlayerOrWinner()
        {

            CheckForMiniGameWinner();

            if (isGameEnded)
            {
                MessageBox.Show((isPlayer1Turn ? "Player 1" : "Player 2") + " won the game");
            }

            isPlayer1Turn ^= true;

            if (isGameEnded)
            {
                NewGame();
            }
        }

        private bool IsMiniGameWon()
        {
            return (miniGame[0,0] != MarkType.Free && (miniGame[0,0] & miniGame[0,1] & miniGame[0,2]) == miniGame[0,0])
                || (miniGame[1,0] != MarkType.Free && (miniGame[1,0] & miniGame[1,1] & miniGame[1,2]) == miniGame[1,0])
                || (miniGame[2,0] != MarkType.Free && (miniGame[2,0] & miniGame[2,1] & miniGame[2,2]) == miniGame[2,0])
                || (miniGame[0,0] != MarkType.Free && (miniGame[0,0] & miniGame[1,0] & miniGame[2,0]) == miniGame[0,0])
                || (miniGame[0,1] != MarkType.Free && (miniGame[0,1] & miniGame[1,1] & miniGame[2,1]) == miniGame[0,1])
                || (miniGame[0,2] != MarkType.Free && (miniGame[0,2] & miniGame[1,2] & miniGame[2,2]) == miniGame[0,2])
                || (miniGame[0,0] != MarkType.Free && (miniGame[0,0] & miniGame[1,1] & miniGame[2,2]) == miniGame[0,0])
                || (miniGame[0,2] != MarkType.Free && (miniGame[0,2] & miniGame[1,1] & miniGame[2,0]) == miniGame[0,2]);
        }

        private bool IsMiniGame1Won()
        {
            return (miniGame[0, 3] != MarkType.Free && (miniGame[0, 3] & miniGame[0, 4] & miniGame[0, 5]) == miniGame[0, 3])
                || (miniGame[1, 3] != MarkType.Free && (miniGame[1, 3] & miniGame[1, 4] & miniGame[1, 5]) == miniGame[1, 3])
                || (miniGame[2, 3] != MarkType.Free && (miniGame[2, 3] & miniGame[2, 4] & miniGame[2, 5]) == miniGame[2, 3])
                || (miniGame[0, 3] != MarkType.Free && (miniGame[0, 3] & miniGame[1, 3] & miniGame[2, 3]) == miniGame[0, 3])
                || (miniGame[0, 4] != MarkType.Free && (miniGame[0, 4] & miniGame[1, 4] & miniGame[2, 4]) == miniGame[0, 4])
                || (miniGame[0, 5] != MarkType.Free && (miniGame[0, 5] & miniGame[1, 5] & miniGame[2, 5]) == miniGame[0, 5])
                || (miniGame[0, 3] != MarkType.Free && (miniGame[0, 3] & miniGame[1, 4] & miniGame[2, 5]) == miniGame[0, 3])
                || (miniGame[0, 5] != MarkType.Free && (miniGame[0, 5] & miniGame[1, 4] & miniGame[2, 3]) == miniGame[0, 5]);
        }

        private bool IsMiniGame2Won()
        {
            return (miniGame[0, 6] != MarkType.Free && (miniGame[0, 6] & miniGame[0, 7] & miniGame[0, 8]) == miniGame[0, 6])
                || (miniGame[1, 6] != MarkType.Free && (miniGame[1, 6] & miniGame[1, 7] & miniGame[1, 8]) == miniGame[1, 6])
                || (miniGame[2, 6] != MarkType.Free && (miniGame[2, 6] & miniGame[2, 7] & miniGame[2, 8]) == miniGame[2, 6])
                || (miniGame[0, 6] != MarkType.Free && (miniGame[0, 6] & miniGame[1, 6] & miniGame[2, 6]) == miniGame[0, 6])
                || (miniGame[0, 7] != MarkType.Free && (miniGame[0, 7] & miniGame[1, 7] & miniGame[2, 7]) == miniGame[0, 7])
                || (miniGame[0, 8] != MarkType.Free && (miniGame[0, 8] & miniGame[1, 8] & miniGame[2, 8]) == miniGame[0, 8])
                || (miniGame[0, 6] != MarkType.Free && (miniGame[0, 6] & miniGame[1, 7] & miniGame[2, 8]) == miniGame[0, 6])
                || (miniGame[0, 8] != MarkType.Free && (miniGame[0, 8] & miniGame[1, 7] & miniGame[2, 6]) == miniGame[0, 8]);
        }

        private bool IsMiniGame3Won()
        {
            return (miniGame[3, 0] != MarkType.Free && (miniGame[3, 0] & miniGame[3, 1] & miniGame[3, 2]) == miniGame[3, 0])
                || (miniGame[4, 0] != MarkType.Free && (miniGame[4, 0] & miniGame[4, 1] & miniGame[4, 2]) == miniGame[4, 0])
                || (miniGame[5, 0] != MarkType.Free && (miniGame[5, 0] & miniGame[5, 1] & miniGame[5, 2]) == miniGame[5, 0])
                || (miniGame[3, 0] != MarkType.Free && (miniGame[3, 0] & miniGame[4, 0] & miniGame[5, 0]) == miniGame[3, 0])
                || (miniGame[3, 1] != MarkType.Free && (miniGame[3, 1] & miniGame[4, 1] & miniGame[5, 1]) == miniGame[3, 1])
                || (miniGame[3, 2] != MarkType.Free && (miniGame[3, 2] & miniGame[4, 2] & miniGame[5, 2]) == miniGame[3, 2])
                || (miniGame[3, 0] != MarkType.Free && (miniGame[3, 0] & miniGame[4, 1] & miniGame[5, 2]) == miniGame[3, 0])
                || (miniGame[3, 2] != MarkType.Free && (miniGame[3, 2] & miniGame[4, 1] & miniGame[5, 0]) == miniGame[3, 2]);
        }


        private bool IsMiniGame4Won()
        {
            return (miniGame[3, 3] != MarkType.Free && (miniGame[3, 3] & miniGame[3, 4] & miniGame[3, 5]) == miniGame[3, 3])
                || (miniGame[4, 3] != MarkType.Free && (miniGame[4, 3] & miniGame[4, 4] & miniGame[4, 5]) == miniGame[4, 3])
                || (miniGame[5, 3] != MarkType.Free && (miniGame[5, 3] & miniGame[5, 4] & miniGame[5, 5]) == miniGame[5, 3])
                || (miniGame[3, 3] != MarkType.Free && (miniGame[3, 3] & miniGame[4, 3] & miniGame[5, 3]) == miniGame[3, 3])
                || (miniGame[3, 4] != MarkType.Free && (miniGame[3, 4] & miniGame[4, 4] & miniGame[5, 4]) == miniGame[3, 4])
                || (miniGame[3, 5] != MarkType.Free && (miniGame[3, 5] & miniGame[4, 5] & miniGame[5, 5]) == miniGame[3, 5])
                || (miniGame[3, 3] != MarkType.Free && (miniGame[3, 3] & miniGame[4, 4] & miniGame[5, 5]) == miniGame[3, 3])
                || (miniGame[3, 5] != MarkType.Free && (miniGame[3, 5] & miniGame[4, 4] & miniGame[5, 3]) == miniGame[3, 5]);
        }

        private bool IsMiniGame5Won()
        {
            return (miniGame[3, 6] != MarkType.Free && (miniGame[3, 6] & miniGame[3, 7] & miniGame[3, 8]) == miniGame[3, 6])
                || (miniGame[4, 6] != MarkType.Free && (miniGame[4, 6] & miniGame[4, 7] & miniGame[4, 8]) == miniGame[4, 6])
                || (miniGame[5, 6] != MarkType.Free && (miniGame[5, 6] & miniGame[5, 7] & miniGame[5, 8]) == miniGame[5, 6])
                || (miniGame[3, 6] != MarkType.Free && (miniGame[3, 6] & miniGame[4, 6] & miniGame[5, 6]) == miniGame[3, 6])
                || (miniGame[3, 7] != MarkType.Free && (miniGame[3, 7] & miniGame[4, 7] & miniGame[5, 7]) == miniGame[3, 7])
                || (miniGame[3, 8] != MarkType.Free && (miniGame[3, 8] & miniGame[4, 8] & miniGame[5, 8]) == miniGame[3, 8])
                || (miniGame[3, 6] != MarkType.Free && (miniGame[3, 6] & miniGame[4, 7] & miniGame[5, 8]) == miniGame[3, 6])
                || (miniGame[3, 8] != MarkType.Free && (miniGame[3, 8] & miniGame[4, 7] & miniGame[5, 6]) == miniGame[3, 8]);
        }

        private bool IsMiniGame6Won()
        {
            return (miniGame[6, 0] != MarkType.Free && (miniGame[6, 0] & miniGame[6, 1] & miniGame[6, 2]) == miniGame[6, 0])
                || (miniGame[7, 0] != MarkType.Free && (miniGame[7, 0] & miniGame[7, 1] & miniGame[7, 2]) == miniGame[7, 0])
                || (miniGame[8, 0] != MarkType.Free && (miniGame[8, 0] & miniGame[8, 1] & miniGame[8, 2]) == miniGame[8, 0])
                || (miniGame[6, 0] != MarkType.Free && (miniGame[6, 0] & miniGame[7, 0] & miniGame[8, 0]) == miniGame[6, 0])
                || (miniGame[6, 1] != MarkType.Free && (miniGame[6, 1] & miniGame[7, 1] & miniGame[8, 1]) == miniGame[6, 1])
                || (miniGame[6, 2] != MarkType.Free && (miniGame[6, 2] & miniGame[7, 2] & miniGame[8, 2]) == miniGame[6, 2])
                || (miniGame[6, 0] != MarkType.Free && (miniGame[6, 0] & miniGame[7, 1] & miniGame[8, 2]) == miniGame[6, 0])
                || (miniGame[6, 2] != MarkType.Free && (miniGame[6, 2] & miniGame[7, 1] & miniGame[8, 0]) == miniGame[6, 2]);
        }

        private bool IsMiniGame7Won()
        {
            return (miniGame[6, 3] != MarkType.Free && (miniGame[6, 3] & miniGame[6, 4] & miniGame[6, 5]) == miniGame[6, 3])
                || (miniGame[7, 3] != MarkType.Free && (miniGame[7, 3] & miniGame[7, 4] & miniGame[7, 5]) == miniGame[7, 3])
                || (miniGame[8, 3] != MarkType.Free && (miniGame[8, 3] & miniGame[8, 4] & miniGame[8, 5]) == miniGame[8, 3])
                || (miniGame[6, 3] != MarkType.Free && (miniGame[6, 3] & miniGame[7, 3] & miniGame[8, 3]) == miniGame[6, 3])
                || (miniGame[6, 4] != MarkType.Free && (miniGame[6, 4] & miniGame[7, 4] & miniGame[8, 4]) == miniGame[6, 4])
                || (miniGame[6, 5] != MarkType.Free && (miniGame[6, 5] & miniGame[7, 5] & miniGame[8, 5]) == miniGame[6, 5])
                || (miniGame[6, 3] != MarkType.Free && (miniGame[6, 3] & miniGame[7, 4] & miniGame[8, 5]) == miniGame[6, 3])
                || (miniGame[6, 5] != MarkType.Free && (miniGame[6, 5] & miniGame[7, 4] & miniGame[8, 3]) == miniGame[6, 5]);
        }

        private bool IsMiniGame8Won()
        {
            return (miniGame[6, 6] != MarkType.Free && (miniGame[6, 6] & miniGame[6, 7] & miniGame[6, 8]) == miniGame[6, 6])
                || (miniGame[7, 6] != MarkType.Free && (miniGame[7, 6] & miniGame[7, 7] & miniGame[7, 8]) == miniGame[7, 6])
                || (miniGame[8, 6] != MarkType.Free && (miniGame[8, 6] & miniGame[8, 7] & miniGame[8, 8]) == miniGame[8, 6])
                || (miniGame[6, 6] != MarkType.Free && (miniGame[6, 6] & miniGame[7, 6] & miniGame[8, 6]) == miniGame[6, 6])
                || (miniGame[6, 7] != MarkType.Free && (miniGame[6, 7] & miniGame[7, 7] & miniGame[8, 7]) == miniGame[6, 7])
                || (miniGame[6, 8] != MarkType.Free && (miniGame[6, 8] & miniGame[7, 8] & miniGame[8, 8]) == miniGame[6, 8])
                || (miniGame[6, 6] != MarkType.Free && (miniGame[6, 6] & miniGame[7, 7] & miniGame[8, 8]) == miniGame[6, 6])
                || (miniGame[6, 8] != MarkType.Free && (miniGame[6, 8] & miniGame[7, 7] & miniGame[8, 6]) == miniGame[6, 8]);
        }

        private bool IsBigGameWon()
        {
                return (bigGame[0] != MarkType.Free && (bigGame[0] & bigGame[1] & bigGame[2]) == bigGame[0])
                    || (bigGame[3] != MarkType.Free && (bigGame[3] & bigGame[4] & bigGame[5]) == bigGame[3])
                    || (bigGame[6] != MarkType.Free && (bigGame[6] & bigGame[7] & bigGame[8]) == bigGame[6])
                    || (bigGame[0] != MarkType.Free && (bigGame[0] & bigGame[3] & bigGame[6]) == bigGame[0])
                    || (bigGame[1] != MarkType.Free && (bigGame[1] & bigGame[4] & bigGame[7]) == bigGame[1])
                    || (bigGame[2] != MarkType.Free && (bigGame[2] & bigGame[5] & bigGame[8]) == bigGame[2])
                    || (bigGame[0] != MarkType.Free && (bigGame[0] & bigGame[4] & bigGame[8]) == bigGame[0])
                    || (bigGame[2] != MarkType.Free && (bigGame[2] & bigGame[4] & bigGame[6]) == bigGame[2]);
        }

        private void EnableGrid(bool grid, bool grid1, bool grid2, bool grid3, bool grid4,
            bool grid5, bool grid6, bool grid7, bool grid8)
        {
            IsGridEnabled = grid;
            IsGridEnabled1 = grid1;
            IsGridEnabled2 = grid2;
            IsGridEnabled3 = grid3;
            IsGridEnabled4 = grid4;
            IsGridEnabled5 = grid5;
            IsGridEnabled6 = grid6;
            IsGridEnabled7 = grid7;
            IsGridEnabled8 = grid8;
        }
    }
}
