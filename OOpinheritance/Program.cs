


using OOpinheritance;

Person person = new Person();
Student student1 = new Student();
Teacher teacher1 = new Teacher();
Tutor tutor1 = new Tutor();
Director director1 = new Director();



student1.Majority = "Computer science";

tutor1.TutorInGroupCount = 1;
teacher1.EducateField = "tarix muellimi";



student1.Majority = "Comp sc";
student1.FullName = "Ayaz";
student1.PhoneNumber = "232445455";
student1.Age = 23;
Console.WriteLine($"student:{student1.FullName}");


teacher1.EducateField = "tarix muellimi";
teacher1.FullName = "Narmin";
teacher1.Age=50;
teacher1.PhoneNumber = "235436656";
Console.WriteLine($"teacher:{teacher1.FullName}");