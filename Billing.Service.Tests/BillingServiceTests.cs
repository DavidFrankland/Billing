using System;
using System.Linq;
using System.Collections.Generic;
using Billing.Service.Models;
using Moq;
using NUnit.Framework;
using FluentAssertions;
using Billing.Api.Interfaces;
using Billing.Api.Models;
using Billing.Service.Mapper;

namespace Billing.Service.Tests
{
    [TestFixture]
    public class BillingServiceTests
    {
        [Test]
        public void GetBill_calls_BillingApi_correctly()
        {
            // arrange
            var mockBillingApi = new Mock<IBillingApi>(MockBehavior.Strict);

            mockBillingApi.Setup(x => x.GetBill()).Returns(new Bill());

            var billingService = new BillingService(mockBillingApi.Object);

            // act
            billingService.GetBill();

            // assert
            mockBillingApi.Verify(x => x.GetBill(), Times.Once);
        }

        [TestCase(Subscription.SubscriptionType.Tv, SubscriptionDto.SubscriptionType.Tv)]
        [TestCase(Subscription.SubscriptionType.Talk, SubscriptionDto.SubscriptionType.Talk)]
        [TestCase(Subscription.SubscriptionType.Broadband, SubscriptionDto.SubscriptionType.Broadband)]
        public void Mapper_handles_subscription_type_correctly(Subscription.SubscriptionType subscriptionType, SubscriptionDto.SubscriptionType expectedSubscriptionType)
        {
            // arrange
            var billDto = new Bill
            {
                Package = new Package
                {
                    Subscriptions = new List<Subscription>
                    {
                        new Subscription
                        {
                            Type = subscriptionType
                        }
                    }
                }
            }.ToDto();

            // act
            var actualSubscriptionType = billDto.Package.Subscriptions.Single().Type;

            // assert
            actualSubscriptionType.Should().Be(expectedSubscriptionType);
        }
    }
}
