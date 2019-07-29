using HighSchool.Infrastructure.Entities.Students;
using System.Linq;

namespace HighSchool.Infrastructure.Context
{
    public static class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Student.Any(p => p.Id == 1))
            {
                context.Add<Student>(new Student() { Id = 1, FullName = "Anna Taylor" });
                context.Add<Student>(new Student() { Id = 2, FullName = "Mark Smith" });
                context.Add<Student>(new Student() { Id = 3, FullName = "John Doe" });
                context.Add<Student>(new Student() { Id = 4, FullName = "Jack Jones" });
                context.Add<Student>(new Student() { Id = 5, FullName = "Melody Queens" });
                context.Add<Student>(new Student() { Id = 6, FullName = "Noah Menac" });

                context.SaveChanges();

                context.Add<Subject>(new Subject() { Id = 1, Name = "Language & Arts" });
                context.Add<Subject>(new Subject() { Id = 2, Name = "Science" });
                context.Add<Subject>(new Subject() { Id = 3, Name = "Social Studies" });
                context.Add<Subject>(new Subject() { Id = 4, Name = "Maths" });

                context.SaveChanges();


                context.Add<Mark>(new Mark() {Id= 1, StudentId = 1, SubjectId = 1, Score = 90 });
                context.Add<Mark>(new Mark() { Id = 2, StudentId = 1, SubjectId = 2, Score = 85 });
                context.Add<Mark>(new Mark() { Id = 3, StudentId = 1, SubjectId = 3, Score = 86 });
                context.Add<Mark>(new Mark() { Id = 4, StudentId = 1, SubjectId = 4, Score = 89 });

                context.Add<Mark>(new Mark() { Id = 5, StudentId = 2, SubjectId = 1, Score = 82 });
                context.Add<Mark>(new Mark() { Id = 6, StudentId = 2, SubjectId = 2, Score = 75 });
                context.Add<Mark>(new Mark() { Id = 7, StudentId = 2, SubjectId = 3, Score = 89 });
                context.Add<Mark>(new Mark() { Id = 8, StudentId = 2, SubjectId = 4, Score = 86 });

                context.Add<Mark>(new Mark() { Id = 9, StudentId = 3, SubjectId = 1, Score = 89 });
                context.Add<Mark>(new Mark() { Id = 10, StudentId = 3, SubjectId = 2, Score = 76 });
                context.Add<Mark>(new Mark() { Id = 11, StudentId = 3, SubjectId = 3, Score = 74 });
                context.Add<Mark>(new Mark() { Id = 12, StudentId = 3, SubjectId = 4, Score = 82 });

                context.Add<Mark>(new Mark() { Id = 13, StudentId = 4, SubjectId = 1, Score = 93 });
                context.Add<Mark>(new Mark() { Id = 14, StudentId = 4, SubjectId = 2, Score = 73 });
                context.Add<Mark>(new Mark() { Id = 15, StudentId = 4, SubjectId = 3, Score = 97 });
                context.Add<Mark>(new Mark() { Id = 16, StudentId = 4, SubjectId = 4, Score = 90 });


                context.Add<Mark>(new Mark() { Id = 17, StudentId = 5, SubjectId = 1, Score = 87 });
                context.Add<Mark>(new Mark() { Id = 18, StudentId = 5, SubjectId = 2, Score = 89 });
                context.Add<Mark>(new Mark() { Id = 19, StudentId = 5, SubjectId = 3, Score = 80 });
                context.Add<Mark>(new Mark() { Id = 20, StudentId = 5, SubjectId = 4, Score = 83 });

                context.Add<Mark>(new Mark() { Id = 21, StudentId = 6, SubjectId = 1, Score = 86 });
                context.Add<Mark>(new Mark() { Id = 22, StudentId = 6, SubjectId = 2, Score = 90 });
                context.Add<Mark>(new Mark() { Id = 23, StudentId = 6, SubjectId = 3, Score = 83 });
                context.Add<Mark>(new Mark() { Id = 24, StudentId = 6, SubjectId = 4, Score = 85 });

                context.SaveChanges();
            }
        }
    }
}
