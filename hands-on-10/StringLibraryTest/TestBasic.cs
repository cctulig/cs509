using Fare;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

namespace StringLibraryTest;

using FluentAssertions;
using Moq;
using AutoFixture;
using StringLibrary;

public class TestBasic
{
    [Fact]
    public void adding_3_and_4()
    {
        Basic.add(3.0, 4.0).Should().Be(7.0);
    }
    
    [Fact]
    public void f_should_just_reutrn_first_input_parameter()
    {
        Fixture fixture = new Fixture();
        int expectedNumber = fixture.Create<int>();
        
        var a = new Mock<IOne>();
        //a.Setup(x => x.complexFunction(It.IsAny<int>())).Returns(2);
        a.Setup(x => x.complexFunction(It.IsAny<int>())).Returns(expectedNumber);

        //var a = new One();
        var b = Two.f(2, a.Object);

        b.Should().Be(expectedNumber);
    }
}