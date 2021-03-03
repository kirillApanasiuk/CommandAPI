using CommandAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CommandAPI.Tests
{
   public class CommandTests:IDisposable
    {
        Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }
        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Act
            testCommand.HowTo = "Execute Unit Tests";

            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Act
            testCommand.Platform = "java";

            //Assert
            Assert.Equal("java", testCommand.Platform);
        }  
        
        [Fact]
        public void CanChangeCommandLine()
        {
            //Arrange
            //Act
            testCommand.CommandLine = "test case";

            //Assert
            Assert.Equal("test case", testCommand.CommandLine);
        }

    }
}
