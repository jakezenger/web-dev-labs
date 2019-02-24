using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Person> persons = new List<Person> {
            new Person {
                FirstName="Johnny",
                MiddleInitial='B',
                LastName="Goode"
            },
            new Person {
                FirstName="John",
                MiddleInitial='A',
                LastName="White"
            },
            new Person {
                FirstName="James",
                MiddleInitial='M',
                LastName="Hendrix"
            },
            new Person {
                FirstName="James",
                MiddleInitial='P',
                LastName="Page"
            },
            new Person {
                FirstName="Brian",
                MiddleInitial='H',
                LastName="May"
            }
        };

        public static List<Student> students = new List<Student> {
            new Student {
                ID=15379446,
                Email="johnny.goode@oit.edu"
            },
            new Student {
                ID=34681275,
                Email="jack.white@oit.edu"
            },
            new Student {
                ID=64986523,
                Email="jimi.hendrix@oit.edu"
            },
            new Student {
                ID=72185385,
                Email="jimmy.page@oit.edu"
            },
            new Student {
                ID=58213468,
                Email="brian.may@oit.edu"
            }
        };
    }
}