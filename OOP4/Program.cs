

using OOP4;
using OOP4.Abstract;
using OOP4.Concrete;


Student student1 = new() { Id=1,FullName="Elmir Mikayilli",Birthday=new DateTime(2000,07,23)};

XAcademyStudentManager xAcademyStudentManager = new XAcademyStudentManager();
xAcademyStudentManager.Add(student1);

BaseStudentManager yAcademyStudentManager =new YAcademyStudentManager();

yAcademyStudentManager.Add(student1 );