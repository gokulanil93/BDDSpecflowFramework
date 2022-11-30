using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestProject.POM;

namespace TestProject.StepDefenitions
{
    [Binding]
    public class AjioTestsSteps
    {
        [Given(@"user navigates to website and select clothing section")]
        public void GivenTheFirstNumber()
        {
            AjioHeaderPage ajioHeaderPageObj = new AjioHeaderPage();
            ajioHeaderPageObj.SelectClothing();
        }

        [When(@"user selects the brand of product")]
        public void GivenUserSelectsTheBrandOfProduct()
        {
            AjioClothingPage ajioClothingPageObj = new AjioClothingPage();
            ajioClothingPageObj.SelectBrand();
        }


        [Then(@"user selects the first product and verify the product name is ""(.*)"" and price ranges between ""(.*)"" and ""(.*)""")]
        public void ThenUserSelectsTheFirstProductAndVerifyTheProductNameIsAndPriceRangesBetweenAnd(string productName, double min, double max)
        {
            AjioClothingPage ajioClothingPageObj = new AjioClothingPage();
            var productDetails = ajioClothingPageObj.SelectFirstProductReturnDetails();
            bool flag = ajioClothingPageObj.VerifyPriceRange(productDetails.Item2, min, max);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(productName, productDetails.Item1, "Product is different");
                Assert.True(flag, "Price not in Range");
                Console.WriteLine("Test Passed");
            });
        }

        [Then(@"user selects the ""(.*)"" product and verify the product name is ""(.*)"" and price ranges between ""(.*)"" and ""(.*)""")]
        public void ThenUserSelectsTheProductAndVerifyTheProductNameIsAndPriceRangesBetweenAnd(int count, string productName, double min, double max)
        {
            AjioClothingPage ajioClothingPageObj = new AjioClothingPage();
            var productDetails = ajioClothingPageObj.SelectAnyProductReturnDetails(count);
            bool flag = ajioClothingPageObj.VerifyPriceRange(productDetails.Item2, min, max);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(productName, productDetails.Item1, "Product is different");
                Assert.True(flag, "Price not in Range");
                Console.WriteLine("Test Passed");
            });
        }

    }
}
