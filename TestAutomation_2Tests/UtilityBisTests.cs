using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilitiesBis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skyline.DataMiner.Automation;
using Moq;

namespace UtilitiesBis.Tests
{
	[TestClass()]
	public class UtilityBisTests
	{
		[TestMethod()]
		public void ToLowerTest()
		{
			Console.WriteLine(Skyline.DataMiner.Automation.CalendarMode.Decade);

			var result = UtilitiesBis.UtilityBis.ToLower("B");


			Assert.AreEqual("b", result);
		}

		[TestMethod()]
		public void TestGetInfo()
		{
			// Arrange
			Mock<Engine> fakeEngine = new Mock<Engine>();
			fakeEngine.Setup(p => p.GetAlarmProperty(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<string>())).Returns("PropValue");
			var engine = fakeEngine.Object;

			// Act
			var propertyValue = engine.GetAlarmProperty(1, 2, 3, "PropertyName");

			// Assert
			Assert.AreEqual("PropValue", propertyValue);
		}
	}
}