using System;
using Database.Entities;

namespace BusinessRules 
{
    public static class StudentBusinessRules
    {
        public static bool IsSpecial(Student student)
        {
            return student.emailAddress.Contains("a");
        }
    }
}