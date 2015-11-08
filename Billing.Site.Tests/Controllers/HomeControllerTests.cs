using System;
using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using FluentAssertions.Mvc;
using Billing.Site.Controllers;

namespace Billing.Site.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Index_redirects_correctly()
        {
            // arrange
            var controller = new HomeController();

            // act
            var result = controller.Index();

            // assert
            result.Should().BeRedirectToRouteResult().WithController("Billing").WithAction("View");
        }
    }
}
