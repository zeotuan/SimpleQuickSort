using Xunit;
using System.Collections.Generic;  
using library;
using System;


namespace test_library{

    public class ListQuickSortTest
    {

        public static IEnumerable<object[]> GetList(bool ValidData)
        {
            if(ValidData){
                yield return new object[] { new List<int>{ 9,1,8,2,5,4,7,6,3 }, new List<int>{ 1,2,3,4,5,6,7,8,9 }};
                yield return new object[] { new List<double>{ 2.4, 5.6, 2, 4, 3.1, 2.5, 1.3, 7.0, 1.5}, new List<double>{ 1.3, 1.5, 2, 2.4, 2.5, 3.1, 4, 5.6, 7.0}};
                yield return new object[] {  new List<string>{ "Sco Mo", "Andrew Probyn", "Holder Simson", "Miyin Legend", "Larry Ellison"},new List<string>{ "Andrew Probyn", "Holder Simson","Larry Ellison", "Miyin Legend", "Sco Mo"}};
                yield return new object[] { new List<Name>{new Name("Sco Mo"), new Name("Andrew Probyn"), new Name("Holder Simson"), new Name("Miyin Legend"), new Name("Larry Ellison")}, new List<Name>{new Name("Larry Ellison"), new Name("Miyin Legend"),new Name("Sco Mo"), new Name("Andrew Probyn"), new Name("Holder Simson")}};
            }else{
                yield return new object[] { new List<int>{}};
                yield return new object[] { new List<double>{}};
                yield return new object[] { new List<string>{}};
                yield return new object[] { new List<Name>{}};
                 yield return new object[] { new List<int>{1}};
                yield return new object[] { new List<double>{1.2}};
                yield return new object[] { new List<string>{"Sco Mo"}};
                yield return new object[] { new List<Name>{new Name("Sco Mo")}};
            }
            
        }

        [Theory]
        [MemberData(nameof(GetList),parameters:true)]
        public void TestSorting_ListWithMoreThan1Element<T>(List<T> listToSort, List<T> expectedList) where T : IComparable<T>
        {
            listToSort.PerformSort();
            Assert.Equal(listToSort,expectedList);
        }

        [Theory]
        [MemberData(nameof(GetList),parameters:false)]
        public void TestSorting_ListWithLessThan2Element<T>(List<T> listToSort)
        {
            List<T> expectedList = new List<T>(listToSort.ToArray());
            Assert.Equal(listToSort,expectedList);
        }
        
    }


}
