﻿using FluentAssertions;
using Ravelin.Models;
using Xunit;
namespace Ravelin.Tests
{
    public class RavelinModelTest
    {
	    [Theory]
		[InlineData("APAC","apac")]
	    [InlineData("Apac", "apac")]
	    [InlineData("apac", "apac")]
		public void should_set_market_to_lower(string market,string expected)
	    {
		    var order = new Order(){ Market = market};
		    order.Market.Should().Be(expected);
	    }

	    [Theory]
	    [InlineData("LONDON", "london")]
	    [InlineData("London", "london")]
	    [InlineData("london", "london")]
	    public void should_set_marketCity_to_lower(string marketCity, string expected)
	    {
		    var order = new Order() { MarketCity = marketCity };
		    order.MarketCity.Should().Be(expected);
	    }
	}
}
