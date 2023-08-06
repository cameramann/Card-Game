namespace MemoryGame.Forms
{
    public partial class AdvancedGame : Form
    {
        //
        //Properties
        //

        private List<Image> _cardList = new List<Image>(new Image[] {Properties.Resources.CardBack1,
        Properties.Resources.CardsBack2,Properties.Resources.CardsBack3,
        Properties.Resources.CardsBack4,Properties.Resources.CardsBack5,
        Properties.Resources.CardsBack6,Properties.Resources.CardsBack7,
        Properties.Resources.CardsBack8,Properties.Resources.CardsBack9,
        Properties.Resources.CardsBack10,Properties.Resources.CardsBack11,
        Properties.Resources.CardsBack12,Properties.Resources.CardsBack13,
        Properties.Resources.CardsBack14,Properties.Resources.CardsBack15,
        Properties.Resources.CardsBack16});//A List that contain all the cards images

        private int[] _card17Choise;

        private int[] _cardIndex;

        private int _timeLeft;
        private int _movesleft;
        private int _score;
        private int _imageIndex;
        private int _indexSum;
        //
        //Ctor
        //
        public AdvancedGame()
        {
            this._timeLeft = 10;
            this._movesleft = 5;
            this._score = 0;
            this._card17Choise = new int[16];
            this._card17Choise = ArrShuffle(_card17Choise);
            this._imageIndex = 1;
            this._indexSum = _card17Choise.Length - _imageIndex;
            this._cardIndex = new int[16];
            this._cardIndex = ArrShuffle(_cardIndex);
            InitializeComponent();
            lbl_username.Text = $"Player: {Global.Username}";
            timer.Start();
            pic_card1.Image = _cardList[_cardIndex[0]];
            pic_card2.Image = _cardList[_cardIndex[1]];
            pic_card3.Image = _cardList[_cardIndex[2]];
            pic_card4.Image = _cardList[_cardIndex[3]];
            pic_card5.Image = _cardList[_cardIndex[4]];
            pic_card6.Image = _cardList[_cardIndex[5]];
            pic_card7.Image = _cardList[_cardIndex[6]];
            pic_card8.Image = _cardList[_cardIndex[7]];
            pic_card9.Image = _cardList[_cardIndex[8]];
            pic_card10.Image = _cardList[_cardIndex[9]];
            pic_card11.Image = _cardList[_cardIndex[10]];
            pic_card12.Image = _cardList[_cardIndex[11]];
            pic_card13.Image = _cardList[_cardIndex[12]];
            pic_card14.Image = _cardList[_cardIndex[13]];
            pic_card15.Image = _cardList[_cardIndex[14]];
            pic_card16.Image = _cardList[_cardIndex[15]];
        }

        //
        //Buttons
        //
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameMenu new_main = new GameMenu();
            new_main.Show();

        }

        private void pic_card1_Click(object sender, EventArgs e)
        {
            CardClick(pic_card1.Image, pic_card1, _cardIndex[0]);
        }

        private void pic_card2_Click(object sender, EventArgs e)
        {
            CardClick(pic_card2.Image, pic_card2, _cardIndex[1]);
        }

        private void pic_card3_Click(object sender, EventArgs e)
        {
            CardClick(pic_card3.Image, pic_card3, _cardIndex[2]);
        }

        private void pic_card4_Click(object sender, EventArgs e)
        {
            CardClick(pic_card4.Image, pic_card4, _cardIndex[3]);
        }

        private void pic_card5_Click(object sender, EventArgs e)
        {
            CardClick(pic_card5.Image, pic_card5, _cardIndex[4]);
        }

        private void pic_card6_Click(object sender, EventArgs e)
        {
            CardClick(pic_card6.Image, pic_card6, _cardIndex[5]);
        }

        private void pic_card7_Click(object sender, EventArgs e)
        {
            CardClick(pic_card7.Image, pic_card7, _cardIndex[6]);
        }

        private void pic_card8_Click(object sender, EventArgs e)
        {
            CardClick(pic_card8.Image, pic_card8, _cardIndex[7]);
        }

        private void pic_card9_Click(object sender, EventArgs e)
        {
            CardClick(pic_card9.Image, pic_card9, _cardIndex[8]);
        }

        private void pic_card10_Click(object sender, EventArgs e)
        {
            CardClick(pic_card10.Image, pic_card10, _cardIndex[9]);
        }

        private void pic_card11_Click(object sender, EventArgs e)
        {
            CardClick(pic_card11.Image, pic_card11, _cardIndex[10]);
        }

        private void pic_card12_Click(object sender, EventArgs e)
        {
            CardClick(pic_card12.Image, pic_card12, _cardIndex[11]);
        }

        private void pic_card13_Click(object sender, EventArgs e)
        {
            CardClick(pic_card13.Image, pic_card13, _cardIndex[12]);
        }

        private void pic_card14_Click(object sender, EventArgs e)
        {
            CardClick(pic_card14.Image, pic_card14, _cardIndex[13]);

        }

        private void pic_card15_Click(object sender, EventArgs e)
        {
            CardClick(pic_card15.Image, pic_card15, _cardIndex[14]);
        }

        private void pic_card16_Click(object sender, EventArgs e)
        {
            CardClick(pic_card16.Image, pic_card16, _cardIndex[15]);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (_timeLeft > 0)
            {
                _timeLeft--;
                lbl_timer.Text = "00:0" + _timeLeft;
                if (_timeLeft == 3)
                    FlipAll();
            }
            else
            {
                timer.Stop();
                Card17Change();
            }
        }
        //
        //My Code
        //
        private void CardClick(Image cardCurrent, PictureBox pic, int cardReplace)
        //Event to flip the card upwards when clicked
        {
            OutOfMoves();
            WinCondition();
            if (_timeLeft == 0)
            {
                if (CompareImages(cardCurrent, Properties.Resources.CardBackMain1))
                {

                    pic.BackColor = Color.Ivory;
                    pic.Image = _cardList[cardReplace];
                    if (CompareImages(_cardList[cardReplace], pic_card17.Image))
                    {
                        FlipAll();
                        _score++;
                        lbl_score.Text = "Score: " + _score;
                        Card17Change();
                        pic.Enabled = false;
                        pic.BackColor = Color.Transparent;
                        pic.Image = null;
                        pic.InitialImage = null;
                    }
                    else
                    {
                        _movesleft--;
                        lbl_moves.Text = "Moves Left: " + _movesleft;
                    }
                }
                else
                {
                    pic.BackColor = Color.Transparent;
                    pic.Image = Properties.Resources.CardBackMain1;
                }
            }

        }
        private void FlipCard(PictureBox pic)
        {
            if (pic.Enabled)
            {
                pic.BackColor = Color.Transparent;
                pic.Image = Properties.Resources.CardBackMain1;
            }
        }
        private void FlipAll()
        {
            FlipCard(pic_card1);
            FlipCard(pic_card2);
            FlipCard(pic_card2);
            FlipCard(pic_card3);
            FlipCard(pic_card4);
            FlipCard(pic_card5);
            FlipCard(pic_card6);
            FlipCard(pic_card7);
            FlipCard(pic_card8);
            FlipCard(pic_card9);
            FlipCard(pic_card10);
            FlipCard(pic_card11);
            FlipCard(pic_card12);
            FlipCard(pic_card13);
            FlipCard(pic_card14);
            FlipCard(pic_card15);
            FlipCard(pic_card16);
        }
        private void Card17Change()
        {
            _indexSum = _card17Choise.Length - _imageIndex;
            if (_indexSum >= 0)
            {
                pic_card17.BackColor = Color.Ivory;
                pic_card17.Image = _cardList[_card17Choise[_indexSum]];
                _imageIndex++;
            }
        }
        
        private void OutOfMoves()
        //End Game Event - The player ran out of moves
        {
            if (_movesleft == 0)
            {
                MessageBox.Show("You have ran out Moves! Your score is: " + _score);
                this.Hide();
                GameMenu new_menu = new GameMenu();
                new_menu.Show();
            }
        }
        private void WinCondition()
        //End Game Event - The player guessed all the cards
        {
            if (_indexSum == 0)
            {
                MessageBox.Show("Congrats! You have guessed all the Cards! Your score is: " + _score);
                this.Hide();
                GameMenu new_menu = new GameMenu();
                new_menu.Show();
            }
        }

        private static bool CompareImages(Image image1, Image image2)
        {
            // Check if the images have the same dimensions
            if (image1.Width != image2.Width || image1.Height != image2.Height)
            {
                return false;
            }

            // Convert the images to Bitmap objects to access pixel data
            Bitmap bitmap1 = new Bitmap(image1);
            Bitmap bitmap2 = new Bitmap(image2);

            // Compare pixel by pixel
            for (int y = 0; y < bitmap1.Height; y++)
            {
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    Color pixel1 = bitmap1.GetPixel(x, y);
                    Color pixel2 = bitmap2.GetPixel(x, y);

                    if (pixel1 != pixel2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static int[] ArrShuffle(int[] arr)
        {
            int[] temp = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int index;
            int left = temp.Length;
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                index = rand.Next(left);
                arr[i] = temp[index];
                temp[index] = temp[left - 1];
                left--;
            }
            return arr;
        }
    }
}
