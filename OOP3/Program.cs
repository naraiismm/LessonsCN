


using OOP3;

Student student1 = new Student();
Lesson lesson1 = new Lesson();
student1.Id = 1;
student1.FullName = "Feride";
student1.PhoneNumber="0708150686";
student1.GpPoint = 56.78;

Teacher teacher = new Teacher();
teacher.Id = 1;
teacher.FullName = "Murad Musali";
teacher.PhoneNumber = "432143434";
teacher.Majority = "C#";
Console.WriteLine(teacher.FullName);

PersonManager personManager = new PersonManager();
personManager.FullNameControllTeacher(teacher);
personManager.FullNameControllStudent(student1);

lesson1.Id = 1;
lesson1.LessonName = "Flutter";
