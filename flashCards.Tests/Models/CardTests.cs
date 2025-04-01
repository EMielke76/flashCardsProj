using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Text;

namespace flashCards.Tests
{
    [TestClass]
    public class CardTests
    {
        //Class-level varaibles accessible in test methods
        private Card card0 = null!;
        public string question = "Card 1";
        public string answer = "An answer";
        public Card.CardCategory category = Card.CardCategory.Geography;


        [TestInitialize]
        public void TestInitialize()
        {
            // Code that runs before each test
            card0 = new Card(question, answer, category);
        }

        [TestMethod]
        public void itExists()
        {
            Assert.IsInstanceOfType(card0, typeof(Card));
        }

        [TestMethod]
        public void itHasAttributes()
        {
            Assert.AreEqual(card0.Question, question);
            Assert.AreEqual(card0.Answer, answer);
            Assert.AreEqual(card0.Category, category);
        }
    }
}