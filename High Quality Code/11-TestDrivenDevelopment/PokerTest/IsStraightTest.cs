﻿namespace PokerTest
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class IsStraightTest
    {
        [TestMethod]
        public void TestIsStraightValid()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Three, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Four, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Five, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Six, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraight = poker.IsStraight(hand);
            Assert.AreEqual(true, isStraight, "IsStraight() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsStraightLessCards()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Four, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Three, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraight = poker.IsStraight(hand);
            Assert.AreEqual(false, isStraight, "IsStraight() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsStraight()
        {
            Card cardOne = new Card(CardFace.Ace, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.King, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Jack, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.Two, CardSuit.Spades);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraight = poker.IsStraight(hand);
            Assert.AreEqual(false, isStraight, "IsStraight() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsStraightNotArangedCards()
        {
            Card cardOne = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Queen, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ace, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Jack, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.King, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraight = poker.IsStraight(hand);
            Assert.AreEqual(true, isStraight, "IsStraight() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsStraightOtherCombination()
        {
            Card cardOne = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Ten, CardSuit.Hearts);
            Card cardThree = new Card(CardFace.Ten, CardSuit.Spades);
            Card cardFour = new Card(CardFace.Ten, CardSuit.Clubs);
            Card cardFive = new Card(CardFace.King, CardSuit.Clubs);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraight = poker.IsStraight(hand);
            Assert.AreEqual(false, isStraight, "IsStraight() method in class PokerHandsChecker is not working correctly.");
        }

        [TestMethod]
        public void TestIsStraightStraightFlush()
        {
            Card cardOne = new Card(CardFace.Two, CardSuit.Diamonds);
            Card cardTwo = new Card(CardFace.Three, CardSuit.Diamonds);
            Card cardThree = new Card(CardFace.Four, CardSuit.Diamonds);
            Card cardFour = new Card(CardFace.Five, CardSuit.Diamonds);
            Card cardFive = new Card(CardFace.Six, CardSuit.Diamonds);
            IList<ICard> cards = new List<ICard>();
            cards.Add(cardOne);
            cards.Add(cardTwo);
            cards.Add(cardThree);
            cards.Add(cardFour);
            cards.Add(cardFive);
            Hand hand = new Hand(cards);
            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraight = poker.IsStraight(hand);
            Assert.AreEqual(false, isStraight, "IsStraight() method in class PokerHandsChecker is not working correctly.");
        }
    }
}
