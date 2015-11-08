using System;
using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using Billing.Site.Models;
using Billing.Site.Mapper;

namespace Billing.Site.Tests
{
    [TestFixture]
    public class MapperTests
    {
        [TestCase(Subscription.SubscriptionType.Tv, "TV")]
        [TestCase(Subscription.SubscriptionType.Talk, "Talk")]
        [TestCase(Subscription.SubscriptionType.Broadband, "Broadband")]
        public void Mapper_handles_subscription_type_correctly(Subscription.SubscriptionType subscriptionType, string expectedSubscriptionType)
        {
            // act
            var actualSubscriptionType = subscriptionType.ToDescription();

            // assert
            actualSubscriptionType.Should().Be(expectedSubscriptionType);
        }
    }
}
