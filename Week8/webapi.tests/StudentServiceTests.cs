using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;
using Database.Entities;
using BusinessRules;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

public class StudentServiceTests
{
    private StudentService _studentService; // system under test (SUT)
    private IStudentRepository _studentRepository; // Mock

    [SetUp]
    public void Setup()
    {
        var loggerFactory = A.Fake<LoggerFactory>();
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository, loggerFactory);
    }

    [Test]
    public void ShouldNotReturnSpecial()
    {
        // Arrange
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(new List<Student> {
            new Student {
                studentId=1,
                emailAddress="john.doe@oit.edu"
            },
            new Student {
                studentId=2,
                emailAddress="jimmy.doe@oit.edu"
            }
        });

        // Act
        var studentDtos = _studentService.GetAllStudents();

        // Assert (FluentAssertions)
        Assert.That(studentDtos.Any(sdto => sdto.Special), Is.EqualTo(false));

        // Assert (FluentAssertions)
        studentDtos.Any(sdto => sdto.Special).Should().BeFalse();
    }

    [Test]
    public void ShouldReturnSpecial()
    {
        // Arrange
        string expectedStudentEmailAddress = "jane.doe@oit.edu";

        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(new List<Student> {
            new Student {
                studentId=1,
                emailAddress="john.doe@oit.edu"
            },
            new Student {
                studentId=2,
                emailAddress=expectedStudentEmailAddress
            }
        });

        // Act
        var studentDtos = _studentService.GetAllStudents();

        // Assert (FluentAssertions)
        studentDtos.Single(sdto => sdto.Special).EmailAddress.Should().Be(expectedStudentEmailAddress);
    }
}