using Microsoft.VisualStudio.TestTools.UnitTesting;
using DriveBCPOM;
using DriveBCPOM.PageObjects;
using FluentAssertions;
using System.Collections.Generic;

namespace POMTests
{
    [TestClass]
    public class HomePage_Should
    {
        [TestInitialize]
        public void InitDriver() => Driver.InitializeDriver();

        [TestMethod]
        public void ReturnClassesPage_WhenClassesClicked()
        {
            //Arrange
            HomePage hp = new HomePage(Driver.BCTestDriver);
            ClassesPage cp = new ClassesPage(Driver.BCTestDriver);
            string result;
            string expected = "Browse Credit Classes";

            //Act
            hp.ClickClasses();
            result = cp.GetTitleText();

            //Assert
            result.Should().Be(expected);

        }

        [TestMethod]
        public void ReturnCorrectListOfPages_WhenClassesClicked()
        {
            //Arrange
            HomePage hp = new HomePage(Driver.BCTestDriver);
            ClassesPage cp = new ClassesPage(Driver.BCTestDriver);

            List<string> result = new List<string>();
            List<string> expected = new List<string>()
            {
                "Welcome to Bellevue College",
                "Browse Credit Classes",
                "<<Back",
                "Welcome to Bellevue College"
            };


            //Act
            result.Add(hp.GetTitleText());

            hp.ClickClasses();
            result.Add(cp.GetTitleText());

            Driver.GoBack();
            result.Add("<<Back");

            result.Add(hp.GetTitleText());

            //Assert
            result.Should().Equal(expected);
        }
    }
}
