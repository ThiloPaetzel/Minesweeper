///My version of minesweeper, when a non bomb button is clicked a text in the button will appear and tell how far the clicked button is from the nearest bomb


using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demineur
{
    public partial class Form1 : Form
    {   
        Bitmap flag = new Bitmap(@"F:\05-repertoires-ict-ssd\AUTRES\Demineur\Demineur\Images\flag.png");//Must be changed if used somewhere else
        int nbrOfBomb;//number of bombs
        bool quit = false;//Bool to know if it has to go out of the double for loop
        int score;//Score
        Random random = new Random();//Random
        int randomNumber;//Result of the random (to know if the button is a bomb or not)
        const int NBROWCOLS = 10;//Not touch (Number of cols and rows)
        Button[,] arrButtons = new Button[NBROWCOLS, NBROWCOLS];//Array of all the buttons
        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            int btnWidth = splitContainer.Panel2.Size.Width / NBROWCOLS;
            int btnHeight = splitContainer.Panel2.Size.Height / NBROWCOLS;
            for (int i = 0; i < NBROWCOLS; i++)
            {
                for (int j = 0; j < NBROWCOLS; j++)
                {
                    randomNumber = random.Next(0, 8);
                    Point coordBtn = new Point(j * btnWidth, i * btnHeight);//btnCoord
                    arrButtons[i, j] = new Button();//Add the button to array
                    arrButtons[i, j].Location = coordBtn;//Location of the button
                    arrButtons[i, j].Size = new Size(btnWidth, btnHeight);//Size of the button
                    arrButtons[i, j].BackColor = Color.LightGray;//Backcolor of the button

                    splitContainer.Panel2.Controls.Add(arrButtons[i, j]);//Add the button to the split container

                    //If the random is 1 the button is a bomb
                    if (randomNumber == 1)
                    {
                        nbrOfBomb++;
                        arrButtons[i, j].Tag = "Bomb";
                    }
                    else
                    {
                        arrButtons[i, j].Tag = "not bomb";
                    }

                    arrButtons[i, j].MouseWheel += new MouseEventHandler(this.arrButtons_wheelClicked);//Flag
                    arrButtons[i, j].MouseClick += new MouseEventHandler(this.arrButtons_click);//Click
                }
            }
            lblNbrOfBombs.Text = "Number of bombs : " + Convert.ToString(nbrOfBomb);
        }

        /// <summary>
        /// Method to check if the button that was clicked is not a Bomb and to know how far the bomb is from the clicked button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arrButtons_click(object sender, MouseEventArgs e)
        {
            Button btnClicked = (Button)sender;
            if (btnClicked.Tag == "Bomb")
            {
                btnClicked.Text = "Was a bomb";
                for (int i = 0; i < NBROWCOLS; i++)
                {
                    for (int j = 0; j < NBROWCOLS; j++)
                    {
                        if (arrButtons[i,j].Tag == "Bomb")
                        {
                            arrButtons[i, j].BackColor = Color.Red;
                        }
                    }
                }
                DialogResult result = MessageBox.Show("Perdu rejouer ?", "Partie terminée", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                score++;
                lblScore.Text = "Score : " + score;
                btnClicked.Enabled = false;
                quit = false;

                if (score == 100-nbrOfBomb)//Won
                {
                    DialogResult win = MessageBox.Show("Gagné ! Rejouer ?", "Partie terminée", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (win == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Close();
                    }
                }

                //One away from bomb
                for (int i = 0; i < NBROWCOLS; i++)
                {
                    for (int j = 0; j < NBROWCOLS; j++)
                    {
                        if (arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.X + 94 == arrButtons[i, j].Location.X && btnClicked.Location.Y == arrButtons[i, j].Location.Y || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.X - 94 == arrButtons[i, j].Location.X && btnClicked.Location.Y == arrButtons[i, j].Location.Y || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.Y + 38 == arrButtons[i, j].Location.Y && btnClicked.Location.X == arrButtons[i, j].Location.X || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.Y - 38 == arrButtons[i, j].Location.Y && btnClicked.Location.X == arrButtons[i, j].Location.X)
                        {
                            btnClicked.Text = "1";
                            quit = true;
                            break;
                        }
                    }
                    if (quit == true)
                    {
                        break;
                    }
                }
                
                //Two away from bomb
                if (quit == false)
                {
                    for (int i = 0; i < NBROWCOLS; i++)
                    {
                        for (int j = 0; j < NBROWCOLS; j++)
                        {
                            if (arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.X + 188 == arrButtons[i, j].Location.X && btnClicked.Location.Y == arrButtons[i, j].Location.Y || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.X - 188 == arrButtons[i, j].Location.X && btnClicked.Location.Y == arrButtons[i, j].Location.Y || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.Y + 76 == arrButtons[i, j].Location.Y && btnClicked.Location.X == arrButtons[i, j].Location.X || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.Y - 76 == arrButtons[i, j].Location.Y && btnClicked.Location.X == arrButtons[i, j].Location.X)
                            {
                                btnClicked.Text = "2";
                                quit = true;
                                break;
                            }
                        }
                        if (quit == true)
                        {
                            break;
                        }
                    }
                }

                //Three away from bomb
                if (quit == false)
                {
                    for (int i = 0; i < NBROWCOLS; i++)
                    {
                        for (int j = 0; j < NBROWCOLS; j++)
                        {
                            if (arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.X + 282 == arrButtons[i, j].Location.X && btnClicked.Location.Y == arrButtons[i, j].Location.Y || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.X - 282 == arrButtons[i, j].Location.X && btnClicked.Location.Y == arrButtons[i, j].Location.Y || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.Y + 114 == arrButtons[i, j].Location.Y && btnClicked.Location.X == arrButtons[i, j].Location.X || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.Y - 114 == arrButtons[i, j].Location.Y && btnClicked.Location.X == arrButtons[i, j].Location.X)
                            {
                                btnClicked.Text = "3";
                                quit = true;
                                break;
                            }
                        }
                        if (quit == true)
                        {
                            break;
                        }
                    }
                }

                //Four away from bomb
                if (quit == false)
                {
                    for (int i = 0; i < NBROWCOLS; i++)
                    {
                        for (int j = 0; j < NBROWCOLS; j++)
                        {
                            if (arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.X + 376 == arrButtons[i, j].Location.X && btnClicked.Location.Y == arrButtons[i, j].Location.Y || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.X - 376 == arrButtons[i, j].Location.X && btnClicked.Location.Y == arrButtons[i, j].Location.Y || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.Y + 152 == arrButtons[i, j].Location.Y && btnClicked.Location.X == arrButtons[i, j].Location.X || arrButtons[i, j].Tag == "Bomb" && btnClicked.Location.Y - 152 == arrButtons[i, j].Location.Y && btnClicked.Location.X == arrButtons[i, j].Location.X)
                            {
                                btnClicked.Text = "4";
                                quit = true;
                                break;
                            }
                        }
                        if (quit == true)
                        {
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Flag the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arrButtons_wheelClicked(object sender, MouseEventArgs e)
        {
            Button mouseWheelButton = (Button)sender;

            if (mouseWheelButton.Image != flag)
            {
                mouseWheelButton.Image = flag;
            }
            else
            {
                mouseWheelButton.Image = null;
            }
        }

        /// <summary>
        /// Restart the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
