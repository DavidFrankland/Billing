using System;
using Moq;
using NUnit.Framework;
using FluentAssertions;
using FluentAssertions.Mvc;
using Billing.Site.BillingService;
using Billing.Site.Models;
using Billing.Site.Controllers;

namespace Billing.Site.Tests.Controllers
{
    [TestFixture]
    public class BillingControllerTests
    {
        [Test]
        public void ViewBill_returns_correct_view_model_type()
        {
            // arrange
            var mockBillingService = new Mock<IBillingService>();

            mockBillingService.Setup(x => x.GetBill()).Returns(new BillDto());

            var controller = new BillingController(mockBillingService.Object);

            // act
            var result = controller.View();

            // assert
            result.Should().BeViewResult().ModelAs<Bill>();
        }

        [Test]
        public void ViewBill_calls_BillingService_correctly()
        {
            // arrange
            var mockBillingService = new Mock<IBillingService>();

            mockBillingService.Setup(x => x.GetBill()).Returns(new BillDto());

            var controller = new BillingController(mockBillingService.Object);

            // act
            controller.View();

            // assert
            mockBillingService.Verify(x => x.GetBill(), Times.Once);
        }
    }
}
