using Xunit;
using library;
using System;
namespace test_library{

    public class NameTest
    {

        [Theory]
        [InlineData("Sco", "Mo")]
        [InlineData("Adonis Julius","Archer")]
        public void Name_CorrectlyInitialize_FirstAndLastName(string expectedGivenName, string expectedLastName)
        {
            string FullName = expectedGivenName +" "+expectedLastName;
            Name actualName = new Name(FullName);
            Assert.Equal(actualName.LastName,expectedLastName.Trim());
            Assert.Equal(actualName.GivenName,expectedGivenName.Trim());
        }

        [Theory]
        [InlineData("Sco Mo")]
        [InlineData("Adonis Julius Archer")]
        public void Name_ToString_ReturnCorrectFullname(string expectedName){
            Name actualName = new Name(expectedName);
            Assert.Equal(actualName.ToString(), expectedName);
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("     ")]
        public void Name_WhenInitializedWithEmptyString_ThrowArgumentException(string name){
             Assert.Throws<ArgumentException>(() => new Name(name));
        }

        [Theory]
        [InlineData("Sco Mo","Adonis Julius Archer")]
        [InlineData("Lee Long","Jake Long")]
        [InlineData("Count Julius Archer","Adonis Julius Archer")]
        [InlineData("Holmer Simson","Simson")]
        public void Name_CompareTo_CorrectlyCompareGreaterString(string name1, string name2){
            Name nameToCompare1 = new Name(name1);
            Name nameToCompare2 = new Name(name2);
            Assert.True(nameToCompare1.CompareTo(nameToCompare2) > 0);
        }

        [Theory]
        [InlineData("Holmer Simson", "Donald Trump")]
        [InlineData("Simson","Holmer Simson")]
        [InlineData("Jake Long","Lee Long")]
        public void Name_CompareTo_CorrectlyCompareLesserString(string name1, string name2){
            Name nameToCompare1 = new Name(name1);
            Name nameToCompare2 = new Name(name2);
            Assert.True(nameToCompare1.CompareTo(nameToCompare2) < 0);
        }

        [Theory]
        [InlineData("Holmer Simson")]
        [InlineData("Donold Trump")]
        public void Name_CompareTo_CorrectlyCompareEqualString(string name1){
            Name nameToCompare1 = new Name(name1);
            Name nameToCompare2 = new Name(name1);
            Assert.True(nameToCompare1.CompareTo(nameToCompare2) == 0);
        }

        


    }
}
