using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var studyOffice = new StudyOffice();
            var student1 = new FirstStudent();
            var student2 = new SecondStudent();

            studyOffice.AttachStudent(student1);
            studyOffice.AttachStudent(student2);
            studyOffice.NotifyAboutDeadline("cursach is coming...");

            studyOffice.DetachStudent(student1);
            studyOffice.NotifyAboutDeadline("first lab deadline in 2 days!!");

            Console.ReadKey();
        }
    }
}
