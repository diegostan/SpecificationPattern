using Application.Entities;
using Application.Specs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.SpecsTest
{
    [TestClass]
    public class IsPetMostValueTests
    {
        [TestMethod]
        [TestCategory("Specs")]
        public void ReturnTrueWhenPetIsMostValue_On_2020()
        {
            var pet1 = new Pet(name:"Pet1", age: 25, gender: Application.Enums.EGender.Female, size: Application.Enums.ESize.Large);
            Assert.AreEqual(true, new IsPetMostValue_On_2020().IsSatisfiedBy(pet1));
        }

        [TestMethod]
        [TestCategory("Specs")]
        public void ReturnTrueWhenPetIsMostValue_On_2021()
        {
            var pet1 = new Pet(name:"Pet1", age: 30, gender: Application.Enums.EGender.Female, size: Application.Enums.ESize.Large);
            Assert.AreEqual(true, new IsPetMostValue_On_2021().IsSatisfiedBy(pet1));
        }
        
    }
}