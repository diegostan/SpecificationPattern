using Application.Entities;
using Application.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.EntitiesTest
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        [TestCategory("Entities")]
        public void ReturnTrueWhenPetIsValid()
        {
            var pet1 = new Pet(name: "Dick", age: 10, gender: EGender.Male, size: ESize.Medium);
            Assert.AreEqual(true, pet1.IsValid());
        }        
    }
}