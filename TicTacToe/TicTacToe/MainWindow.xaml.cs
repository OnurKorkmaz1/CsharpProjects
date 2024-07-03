using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {


        #region Private Members
        /// <summary>
        /// Holds the current results of cells in the active game
        /// </summary>
        private MarkType[] mResults;


        /// <summary>
        /// true if it is player 1's turn (X) or player
        /// </summary>
        private bool mPlayer1Turn;


        /// <summary>
        /// True if the game has end
        /// </summary>
        private bool mGameEnded;

        #endregion

        #region Constructor

        public MainWindow()
        {
            InitializeComponent();

            NewGame();

        }
        

        #endregion

        
        /// <summary>
        /// Starts  a new game and clears all values back to the start
        /// </summary>
        
        private void NewGame()
        {
            //creating a new blank array of free cells
            mResults = new MarkType[9];


            for (int i = 0; i < mResults.Length; i++) 
                mResults[i] = MarkType.Free;

            // Make sure Player 1 starts the game
            mPlayer1Turn = true;

            // Iterate every button on the grid
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                button.Content = string.Empty;

                button.Background = Brushes.White;
                button.Foreground = Brushes.Blue;
            });

            //
            // make sure the game hasn't finished
            mGameEnded = false;



        }

        
        
        /// <summary>
        /// Handles a button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (mGameEnded) 
            {
                NewGame();
                return;
            }

            // Cast the sender to a button
            var button = (Button)sender;

            // find the button position in the array
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var index = column + (row * 3);

            // Dont do anytişng if the cell already has a value in it.
            if (mResults[index] != MarkType.Free)
                return;

            // set the cell value based on which players turn it is
            if(mPlayer1Turn)
                mResults[index] = MarkType.Cross;
            else
                mResults[index] = MarkType.Nought;

            // set button text to the result
            button.Content = mPlayer1Turn ? "X" : "O";

            // change noughs to green
            if (!mPlayer1Turn)
                button.Foreground = Brushes.Red;

            // toggle the players turns

            if (mPlayer1Turn)
                mPlayer1Turn = false;
            else
                mPlayer1Turn = true;


            

            CheckForWinner();
        }

        ///<summary>
        /// check for a winner - a 3 line straight 
        ///</summary>

        private void CheckForWinner()
        {
            #region HORIZONTAL
            //check for horizontal wins. Result contains values.

            // ---- Row 0

            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[1] & mResults[2]) == mResults[0])
            {
                mGameEnded = true;

                // highlight winning cells in green
                Button0_0.Background = Button1_0.Background= Button2_0.Background = Brushes.Green;
            }

            // ---- Row 1

            if (mResults[3] != MarkType.Free && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
            {
                mGameEnded = true;

                // highlight winning cells in green
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.Green;
            }

            // ---- Row 2

            if (mResults[6] != MarkType.Free && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
            {
                mGameEnded = true;

                // highlight winning cells in green
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion


            #region VERTICAL

            //check for vertical wins. Result contains values.


            // ---- Col 0

            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
            {
                mGameEnded = true;

                // highlight winning cells in green
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.Green;
            }

            // ---- Col 1

            if (mResults[1] != MarkType.Free && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
            {
                mGameEnded = true;

                // highlight winning cells in green
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.Green;
            }

            // ---- Col 2

            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
            {
                mGameEnded = true;

                // highlight winning cells in green
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.Green;
            }

            #endregion

            #region DIAGONAL

            //check for diagonal wins. Result contains values.

            // ---- upper left corner

            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
            {
                mGameEnded = true;

                // highlight winning cells in green
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.Green;
            }

            // ----upper right corner

            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
            {
                mGameEnded = true;

                // highlight winning cells in green
                Button2_0.Background = Button1_1.Background = Button0_2.Background = Brushes.Green;
            }



            #endregion

            // check for no winner and full board

            if (!mResults.Any(f => f == MarkType.Free))
            {
                // Game ended
                mGameEnded= true;
                // turn all index to  oranges

                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {

                    button.Background = Brushes.Orange;
                });

            }
        }
    }
}
