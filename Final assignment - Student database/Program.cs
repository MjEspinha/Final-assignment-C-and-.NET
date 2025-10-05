using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            // This will create a new Database
            context.Database.EnsureCreated();

            // This will add a new student
            var student = new Student
            {
                Name = "Madjane Espinha",
                Age = 32
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
        }
    }
}

