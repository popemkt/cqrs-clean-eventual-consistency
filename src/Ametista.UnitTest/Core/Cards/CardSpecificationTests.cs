﻿using Ametista.Core.Entities.Cards;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Ametista.UnitTest.Core.Cards
{
    public class CardSpecificationTests
    {
        public CardSpecificationTests()
        {

        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("371449635398431", true)]
        [InlineData("30569309025904", true)]
        [InlineData("5555555555554444", true)]
        [InlineData("4111111111111111", true)]
        public void Card_Has_Valid_Card_Number_Spec(string number, bool valid)
        {
            // Arrange
            var card = Card.CreateNewCard(number, null, DateTime.Now);
            var spec = new CardHasValidCardNumberSpec();

            // Act
            var isSatisfiedBy = spec.IsSatisfiedBy(card);

            // Assert
            Assert.Equal(valid, isSatisfiedBy);
        }
    }
}