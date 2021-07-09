using Xunit;
using System.Collections.Generic;  
using library;


namespace test_library
{

    public class SwapTest
    {

        public static IEnumerable<object[]> GetList(bool ValidData)
        {
            if(ValidData){
                yield return new object[] { new List<int>{ 1,2,3,4,5,6,7,8,9 }, 0, 8 };
                yield return new object[] { new List<double>{ 1.2, 1.3, 1.4, 1.5 }, 0, 1 };
                yield return new object[] {  new List<string>{ "1.2", "1.3", "1.4", "1.5" }, 0,3};
                yield return new object[] { new List<Name>{new Name("Sco Mo"), new Name("Andrew Probyn"), new Name("Holder Simson"), new Name("Miyin Legend"), new Name("Larry Ellison")}, 0,1 };
            }else{
                yield return new object[] { new List<int>{},0,1};
                yield return new object[] { new List<double>{},0,1};
                yield return new object[] { new List<string>{},0,1};
                yield return new object[] { new List<Name>{},0,1};
                yield return new object[] { new List<int>{ 1,2,3,4,5,6,7},-1,1};
                yield return new object[] { new List<int>{ 1,2,3,4,5,6,7},1,-1};
                yield return new object[] { new List<int>{ 1,2,3,4,5,6,7},100,1};
                yield return new object[] { new List<int>{ 1,2,3,4,5,6,7},1,100};
            }
            
        }
        
        [Theory]
        [MemberData(nameof(GetList),parameters:true)]
        public void TestSwapWithPopulatedListAndValidIndex<T>(List<T> list,int i , int j)
        {
            T elementAtI = list[i];
            T elementAtJ = list[j];
            list.Swap(i,j);
            Assert.Equal(elementAtI, list[j]);
            Assert.Equal(elementAtJ, list[i]); 
            
        }
     
        [Theory]
        [MemberData(nameof(GetList),parameters:false)]
        public void TestSwapWithInvnalidIndex<T>(List<T> actual, int i , int j)
        {
            List<T> expected = new List<T>(actual.ToArray());
            actual.Swap(i,j);
            Assert.Equal(expected,actual);
        }

        
    }
}
