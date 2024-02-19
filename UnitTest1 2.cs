using Xunit;
using MyRootLib;

namespace MyRootLibTest;

public class UnitTest1{
    [Fact]
	public void TestSquareRootOf4() {
	
		double a = 4; // arrange
		double expected = 2;
	
		double actual = Root.MyRoot(a); // act
 
		Assert.Equal(expected, actual); // assert
	}	
	[Fact]
    public void TestSquareRootOf9() {
    
		double a = 9; // arrange
		double expected = 3;
	
		double actual = Root.MyRoot(a); // act

		Assert.Equal(expected, actual); // assert
	} 
}