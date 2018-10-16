using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WarGame
{
    [Activity(Label = "GamePlayActivity")]
    public class GamePlayActivity : Activity
    {
        public int player1Score;
        public int player2Score;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.GamePlay);

            Deck.CreateDeck();
            Deck.Shuffle(3);



            Button button = FindViewById<Button>(Resource.Id.dealHand);
            button.Click += delegate
            {
                ImageView card1 = FindViewById<ImageView>(Resource.Id.card1);
                ImageView card2 = FindViewById<ImageView>(Resource.Id.card2);

                if (Deck.player1.Count < 52 || Deck.player2.Count < 52)
                {
                    TextView score1 = FindViewById<TextView>(Resource.Id.player1Score);
                    score1.Text = "Player 1: " + player1Score;
                    TextView score2 = FindViewById<TextView>(Resource.Id.player2Score);
                    score2.Text = "Player 2: " + player2Score;

                    Card selectedCard1 = Deck.player1.NextOf(null);
                    Card selectedCard2 = Deck.player2.NextOf(null);

                    card1.SetImageResource(CardID(selectedCard1));
                    card2.SetImageResource(CardID(selectedCard2));

                    if (selectedCard1.FaceValue > selectedCard2.FaceValue)
                    {

                        Toast.MakeText(this, "Winner: Player 1", ToastLength.Short).Show();

                        Deck.player1.Add(selectedCard2);
                        Deck.player2.Remove(selectedCard2);

                        Deck.player1.Remove(selectedCard1);
                        Deck.player1.Add(selectedCard1);

                        player1Score += 1;

                    }
                    else if (selectedCard2.FaceValue > selectedCard1.FaceValue)
                    {

                        Toast.MakeText(this, "Winner: Player 2", ToastLength.Short).Show();

                        Deck.player2.Add(selectedCard1);
                        Deck.player1.Remove(selectedCard1);

                        Deck.player2.Remove(selectedCard2);
                        Deck.player2.Add(selectedCard2);

                        player2Score += 1;
                    }
                    else if (selectedCard1.FaceValue == selectedCard2.FaceValue)
                    {
                        WarLogic(selectedCard1, selectedCard2);
                    }

                }
                else 
                {
                    if (Deck.player1.Count >= 52)
                    {
                        button.Enabled = false;

                        AlertDialog.Builder alert = new AlertDialog.Builder(this);
                        alert.SetTitle("Player 1 Wins!");
                        alert.SetPositiveButton("OK!", (senderAlert, args) =>
                        {

                        });
                    }
                    else
                    {
                        button.Enabled = false;

                        AlertDialog.Builder alert = new AlertDialog.Builder(this);
                        alert.SetTitle("Player 2 Wins!");
                        alert.SetPositiveButton("OK!", (senderAlert, args) =>
                        {

                        });
                    }
                }


            };

        }

        public void WarLogic(Card selectedCard1, Card selectedCard2)
        {
            ImageView card1 = FindViewById<ImageView>(Resource.Id.card1);
            ImageView card2 = FindViewById<ImageView>(Resource.Id.card2);
            Button button = FindViewById<Button>(Resource.Id.dealHand);

            button.Enabled = false;


            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("War!");
            alert.SetPositiveButton("Let's Play!", (senderAlert, args) => {

                Deck.warCards.Add(selectedCard1);
                Deck.warCards.Add(selectedCard2);

                Deck.player1.Remove(selectedCard1);
                Deck.player2.Remove(selectedCard2);


                selectedCard1 = Deck.player1.NextOf(null);
                selectedCard2 = Deck.player2.NextOf(null);
                Deck.warCards.Add(selectedCard1);
                Deck.warCards.Add(selectedCard2);
                Deck.player1.Remove(selectedCard1);
                Deck.player2.Remove(selectedCard2);

                selectedCard1 = Deck.player1.NextOf(null);
                selectedCard2 = Deck.player2.NextOf(null);

                card1.SetImageResource(CardID(selectedCard1));
                card2.SetImageResource(CardID(selectedCard2));

                if (selectedCard1.FaceValue > selectedCard2.FaceValue)
                {
                    Toast.MakeText(this, "Player 1 Wins the War!", ToastLength.Short).Show();
                    Deck.player1.Add(selectedCard2);
                    Deck.player2.Remove(selectedCard2);

                    foreach (Card c in Deck.warCards)
                    {
                        Deck.player1.Add(c);
                    }
                    Deck.warCards.Clear();
                    player1Score += 6;
                    button.Enabled = true;
                }
                else if (selectedCard2.FaceValue > selectedCard1.FaceValue)
                {

                    Toast.MakeText(this, "Player 2 Wins the War!", ToastLength.Short).Show();
                    Deck.player2.Add(selectedCard1);
                    Deck.player1.Remove(selectedCard1);

                    foreach (Card c in Deck.warCards)
                    {
                        Deck.player2.Add(c);
                    }

                    Deck.warCards.Clear();
                    player2Score += 6;
                    button.Enabled = true;
                }
                else if (selectedCard1.FaceValue == selectedCard2.FaceValue)
                {
                    WarLogic(selectedCard1, selectedCard2);
                }
            });
            alert.Show();
        }

        public int CardID(Card card)
        {
            switch (card.FaceValue)
            {
                #region Aces
                case Card.Rank.Ace:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.ClubsAce;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.DiamondsAce;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.HeartsAce;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.SpadesAce;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }

                    }
                #endregion

                #region Two
                case Card.Rank.Two:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs2;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds2;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts2;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades2;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }
                #endregion

                #region Three
                case Card.Rank.Three:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs3;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds3;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts3;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades3;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }
                #endregion

                #region Four
                case Card.Rank.Four:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs4;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds4;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts4;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades4;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }
                #endregion

                #region Five
                case Card.Rank.Five:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs5;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds5;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts5;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades5;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }
                #endregion

                #region Six
                case Card.Rank.Six:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs6;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds6;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts6;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades6;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }
                #endregion

                #region Seven
                case Card.Rank.Seven:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs7;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds7;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts7;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades7;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }

                #endregion

                #region Eight
                case Card.Rank.Eight:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs8;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds8;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts8;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades8;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }

                #endregion

                #region Nine
                case Card.Rank.Nine:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs9;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds9;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts9;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades9;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }
                #endregion

                #region Ten
                case Card.Rank.Ten:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs10;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds10;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts10;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades10;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }
                #endregion

                #region Jack
                case Card.Rank.Jack:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.ClubsJ;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.DiamondsJ;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.HeartsJ;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.SpadesJ;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }
                #endregion

                #region King
                case Card.Rank.King:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.ClubsK;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.DiamondsK;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.HeartsK;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.SpadesK;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }
                #endregion

                #region Queen
                case Card.Rank.Queen:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.ClubsQ;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.DiamondsQ;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.HeartsQ;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.SpadesQ;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                    }
                #endregion

                default:
                    {
                        return Resource.Drawable.Joker;
                    }
            }
        }
    }
}