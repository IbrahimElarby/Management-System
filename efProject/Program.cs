using efProject.Contexts;
using efProject.Models;
using Microsoft.EntityFrameworkCore;

namespace efProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            EFITIContext db = new EFITIContext();



            //var students = new List<Student>();
            //var arabicFirstNames = new[] { "Ahmed", "Omar", "Khaled", "Youssef", "Ali", "Mohamed", "Tarek", "Hassan", "Ibrahim", "Mustafa",
            //                   "Fatima", "Aisha", "Noor", "Mariam", "Huda", "Layla", "Sarah", "Yasmin", "Reem", "Dana" };
            //var arabicLastNames = new[] { "Ali", "Youssef", "Hassan", "Tarek", "Salem", "Abdullah", "Mostafa", "Hussein", "Ibrahim", "Zayed" };
            //var random = new Random();

            //for (int i = 1; i <= 50; i++)
            //{
            //    var student = new Student
            //    {
            //         // If using identity in the database, remove this
            //        FName = arabicFirstNames[random.Next(arabicFirstNames.Length)],
            //        LName = arabicLastNames[random.Next(arabicLastNames.Length)],
            //        Phone = $"010{random.Next(10000000, 99999999)}"
            //    };
            //    students.Add(student);
            //}

            //// Save to Database (if using EF Core)
            //db.Students.AddRange(students);
            //db.SaveChanges();
            //            var departments = new List<Department>();

            //            var departmentNames = new[]
            //            {
            //    "Computer Science", "Information Technology", "Software Engineering",
            //    "Artificial Intelligence", "Cyber Security", "Data Science",
            //    "Business Administration", "Electronics Engineering", "Civil Engineering", "Medicine"
            //};

            //            var locations = new[] { "Cairo", "Giza", "Alexandria", "Mansoura", "Aswan", "Suez" };

            //            var random = new Random();

            //            for (int i = 1; i <= 10; i++)
            //            {
            //                var department = new Department
            //                {
            //                    // If using identity in the database, remove this
            //                    Name = departmentNames[i - 1], // Select from predefined names
            //                    Location = locations[random.Next(locations.Length)], // Random location
            //                    MangerId = null // You can assign actual Instructor IDs later
            //                };
            //                departments.Add(department);
            //            }

            //            // Save to Database using EF Core
            //            db.Departments.AddRange(departments);
            //            db.SaveChanges();

            //var instructors = new List<Instructor>();

            //var firstNames = new[] { "Ahmed", "Omar", "Khaled", "Youssef", "Ali", "Mohamed", "Tarek", "Hassan", "Ibrahim", "Mustafa",
            //             "Fatima", "Aisha", "Noor", "Mariam", "Huda", "Layla", "Sarah", "Yasmin", "Reem", "Dana" };

            //var lastNames = new[] { "Ali", "Youssef", "Hassan", "Tarek", "Salem", "Abdullah", "Mostafa", "Hussein", "Ibrahim", "Zayed" };

            //var random = new Random();

            //for (int i = 1; i <= 20; i++)
            //{
            //    var instructor = new Instructor
            //    {
            //         // If using identity in the database, remove this
            //        FName = firstNames[random.Next(firstNames.Length)],
            //        LName = lastNames[random.Next(lastNames.Length)],
            //        Phone = $"010{random.Next(10000000, 99999999)}",
            //        DepartmentId = random.Next(1, 11) // Assign to a random department (assuming 10 departments exist)
            //    };
            //    instructors.Add(instructor);
            //}

            //// Save to Database using EF Core
            //db.Instructors.AddRange(instructors);
            //db.SaveChanges();

            //            var courses = new List<Course>();

            //            var courseNames = new[]
            //            {
            //    "Mathematics", "Physics", "Chemistry", "Biology", "Computer Science",
            //    "Data Structures", "Algorithms", "Artificial Intelligence", "Cyber Security", "Software Engineering",
            //    "Machine Learning", "Deep Learning", "Database Systems", "Web Development", "Mobile App Development",
            //    "Operating Systems", "Computer Networks", "Cloud Computing", "Internet of Things", "Blockchain",
            //    "Digital Marketing", "Business Management", "Economics", "Accounting", "Finance",
            //    "Civil Engineering", "Electrical Engineering", "Mechanical Engineering", "Medical Sciences", "Psychology"
            //};

            //            var random = new Random();

            //            for (int i = 1; i <= 30; i++)
            //            {
            //                var course = new Course
            //                {
            //                     // If using identity in the database, remove this
            //                    Name = courseNames[i - 1], // Pick a course name from predefined list
            //                    Duration = random.Next(10, 60), // Random duration (10 to 60 hours)
            //                    InstructorId = random.Next(1, 21), // Assign to a random instructor (assuming 20 exist)
            //                    DepartmentId = random.Next(1, 11) // Assign to a random department (assuming 10 exist)
            //                };
            //                courses.Add(course);
            //            }

            //            // Save to Database using EF Core
            //            db.Courses.AddRange(courses);
            //            db.SaveChanges();

            //var sessions = new List<CouresSession>();
            //var random = new Random();

            //var courses = db.Courses.ToList(); // Get all courses from the database

            //foreach (var course in courses)
            //{
            //    for (int i = 1; i <= 10; i++) // Generate 10 sessions per course
            //    {
            //        var session = new CouresSession
            //        {
            //            Date = DateTime.Now.AddDays(random.Next(1, 60)), // Random future date within 2 months
            //            Title = $"{course.Name} - Session {i}",
            //            CourseId = course.Id,
            //            InstructorID = course.InstructorId // Use the same instructor as the course
            //        };
            //        sessions.Add(session);
            //    }
            //}

            //// Save to Database using EF Core
            //db.CouresSessions.AddRange(sessions);
            //db.SaveChanges();
            //var courseStudents = new List<CourseStudent>();
            //var random = new Random();

            //var courses = db.Courses.ToList(); // Get all courses
            //var students = db.Students.ToList(); // Get all students

            //foreach (var course in courses)
            //{
            //    int studentsPerCourse = random.Next(5, 15); // Assign between 5 and 15 students per course
            //    var assignedStudents = students.OrderBy(x => random.Next()).Take(studentsPerCourse).ToList();

            //    foreach (var student in assignedStudents)
            //    {
            //        var courseStudent = new CourseStudent
            //        {
            //            CourseId = course.Id,
            //            StudentId = student.Id
            //        };
            //        courseStudents.Add(courseStudent);
            //    }
            //}

            //// Save to Database using EF Core
            //db.CourseStudents.AddRange(courseStudents);
            //db.SaveChanges();

            var attendances = new List<CourseSessionAttandance>();
            var random = new Random();

            var sessions = db.CouresSessions.ToList(); // Get all course sessions
            var students = db.Students.ToList(); // Get all students

            foreach (var session in sessions)
            {
                int studentsPerSession = random.Next(3, 10); // Assign between 3 and 10 students per session
                var assignedStudents = students.OrderBy(x => random.Next()).Take(studentsPerSession).ToList();

                foreach (var student in assignedStudents)
                {
                    var attendance = new CourseSessionAttandance
                    {
                        CourseSessionID = session.Id,
                        StudentID = student.Id,
                        Grade = random.Next(50, 100), // Random grade between 50 and 100
                        Notes = random.Next(0, 3) == 0 ? "Needs improvement" : "Good performance" // Random notes
                    };
                    attendances.Add(attendance);
                }
            }

            // Save to Database using EF Core
            db.CourseSessionAttandances.AddRange(attendances);
            db.SaveChanges();

        }
    }
}
