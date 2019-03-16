using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using BusinessRules;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    private readonly ILogger _logger;

    public StudentService(IStudentRepository studentRepository, ILoggerFactory loggerFactory)
    {
        _studentRepository = studentRepository;
        _logger = loggerFactory.CreateLogger("Controllers.StudentService");
    }
    public List<StudentDto> GetAllStudents()
    {
        var studentDtos = new List<StudentDto>();

        foreach (var student in _studentRepository.GetAllStudents())
        {
            studentDtos.Add(new StudentDto {
                ID = student.studentId,
                EmailAddress = student.emailAddress,
                Special = StudentBusinessRules.IsSpecial(student)
            });

            if (StudentBusinessRules.IsSpecial(student))
            {
                _logger.LogInformation("Found special student: " + student.studentId);
            }
        }

        return studentDtos;
    }
}