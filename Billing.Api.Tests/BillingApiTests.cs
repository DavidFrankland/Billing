using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Moq;
using NUnit.Framework;
using FluentAssertions;
using Billing.Api.Interfaces;
using Billing.Api.Models;

namespace Billing.Api.Tests
{
    [TestFixture]
    public class BillingApiTests
    {
        [Test]
        public void GetBill_returns_correct_results()
        {
            // arrange
            var mockWebRequestHelper = new Mock<IWebRequestHelper>(MockBehavior.Strict);

            string content;

            // using the sample bill downloaded from:
            // http://safe-plains-5453.herokuapp.com/bill.json
            using (var streamReader = File.OpenText("bill.json"))
            {
                content = streamReader.ReadToEnd();
            }

            var requestResult = new RequestResult
            {
                HttpStatusCode = HttpStatusCode.OK,
                Content = content
            };

            mockWebRequestHelper
                .Setup(x => x.GetRequestResult(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(requestResult);

            var billingApi = new BillingApi(mockWebRequestHelper.Object);

            var call1 = new Call
            {
                Called = "07716393769",
                Cost = 2.13m,
                Duration = new TimeSpan(0, 23, 3)
            };

            var call2 = new Call
            {
                Called = "02074351359",
                Cost = 2.13m,
                Duration = new TimeSpan(0, 23, 3)
            };

            var calls = Enumerable.Repeat(call1, 18).Concat(Enumerable.Repeat(call2, 10)).ToList();

            var expectedBill = new Bill
            {
                Total = 136.03m,
                Statement = new Statement
                {
                    Due = new DateTime(2015, 1, 25),
                    Generated = new DateTime(2015, 1, 11),
                    Period = new Period
                    {
                        From = new DateTime(2015, 1, 26),
                        To = new DateTime(2015, 2, 25)
                    }
                },
                Package = new Package
                {
                    Subscriptions = new List<Subscription>
                    {
                        new Subscription
                        {
                            Cost = 50.00m,
                            Name = "Variety with Movies HD",
                            Type = Subscription.SubscriptionType.Tv
                        },
                        new Subscription
                        {
                            Cost = 5.00m,
                            Name = "Sky Talk Anytime",
                            Type = Subscription.SubscriptionType.Talk
                        },
                        new Subscription
                        {
                            Cost = 16.40m,
                            Name = "Fibre Unlimited",
                            Type = Subscription.SubscriptionType.Broadband
                        }
                    },
                    Total = 71.40m
                },
                CallCharges = new CallCharges
                {
                    Calls = calls,
                    Total = 59.64m
                },
                SkyStore = new SkyStore
                {
                    Rentals = new List<Programme>
                    {
                        new Programme
                        {
                            Title = "50 Shades of Grey",
                            Cost = 4.99m
                        }
                    },
                    BuyAndKeep = new List<Programme>
                    {
                        new Programme
                        {
                            Title = "That's what she said",
                            Cost = 9.99m
                        },
                        new Programme
                        {
                            Title = "Broke back mountain",
                            Cost = 9.99m
                        }
                    },
                    Total = 24.97m
                }
            };

            // act
            var result = billingApi.GetBill();

            // assert
            result.ShouldBeEquivalentTo(expectedBill);
        }
    }
}
