using Dormitory.Domain.Enums;
using Dormitory.Domain.Factories;
using Dormitory.Domain.Loggers;
using Dormitory.Domain.Models;
using Dormitory.Domain.Repositories.Abstract;
using System;

namespace Dormitory.Admin.UI
{
    internal class Menu
    {
        private IStudentRepository studentRepository;
        private IWorkerRepository workerRepository; 

        public Menu()
        {
            var factoryProvider = new FactoryProvider(FactoryType.Txt);
            var factory = factoryProvider.GetRepositoryFactory();

            studentRepository = factory.GetStudentRepository();
            workerRepository = factory.GetWorkerRepository();
        }

        public void Demo()
        {
            Console.WriteLine("~~~~~Dormitory Admin Access provided~~~~~");

            while (DemoOnce()) { }

            Console.WriteLine("~~~~~Menu terminated~~~~~");
        }

        private bool DemoOnce()
        {
            Console.WriteLine("Select option:\n1. - Add new Student.\n2. - Add new Worker.\n3. - Print all students." +
                "\n4. - Print all workers.\n5. - Delete student.\n6. - Delete worker.\n0. - Exit." +
                "\n7. - Print Sorted Students by room number.\n8. - Print Sorted Workers by salary." +
                "\n9. - Edit Student.");
            string userInput = Console.ReadLine();

            try
            {
                switch (userInput)
                {
                    case "1":
                        AddNewStudent();
                        return true;
                    case "2":
                        AddNewWorker();
                        return true;
                    case "3":
                        PrintAllStudents();
                        return true;
                    case "4":
                        PrintAllWorkers();
                        return true;
                    case "5":
                        DeleteStudent();
                        return true;
                    case "6":
                        DeleteWorker();
                        return true;
                    case "7":
                        PrintSortedStudentsByRoomNumber();
                        return true;
                    case "8":
                        PrintSortedWorkersBySalary();
                        return true;
                    case "9":
                        EditStudentAt();
                        return true;
                    case "0":
                        return false;
                    default:
                        return true;
                }
            }
            catch (Exception ex)
            {
                TxtLogger.GetLogger().LogError(ex.Message);
                Console.WriteLine($"Error occured");
                Console.WriteLine();
                return true;
            }
        }

        private void AddNewStudent()
        {
            Console.WriteLine("Enter the student info:");
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter surname");
            var surname = Console.ReadLine();

            Console.WriteLine("Enter age");
            var age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter course");
            var course = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Enter room number");
            var room_number = Convert.ToInt32(Console.ReadLine());

            studentRepository.Add(new Student {
                Name = name, Surname = surname, Age = age, Course = course, Room_number = room_number
            });
        }

        private void AddNewWorker()
        {
            Console.WriteLine("Enter the worker info:");
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter surname");
            var surname = Console.ReadLine();

            Console.WriteLine("Enter age");
            var age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter position");
            var position = Console.ReadLine();

            Console.WriteLine("Enter salary");
            var salary = Convert.ToInt32(Console.ReadLine());

            workerRepository.Add(new Worker { Name = name, Surname = surname, Age = age, Position = position, Salary = salary });
        }

        private void PrintAllStudents()
        {
            var students = studentRepository.GetAll();

            for (int i = 0; i < students.Count; ++i)
            {
                Console.WriteLine(students[i]);
            }
            Console.WriteLine();
        }

        private void PrintAllWorkers()
        {
            var workers = workerRepository.GetAll();

            for (int i = 0; i < workers.Count; ++i)
            {
                Console.WriteLine(workers[i]);
            }
            Console.WriteLine();
        }

        private void DeleteStudent()
        {
            Console.WriteLine("Enter positive number");
            int num = Convert.ToInt32(Console.ReadLine());

            var students = studentRepository.GetAll();

            studentRepository.DeleteAt(num - 1);
        }

        private void DeleteWorker()
        {
            Console.WriteLine("Enter positive number");
            int num = Convert.ToInt32(Console.ReadLine());

            var workers = workerRepository.GetAll();

            studentRepository.DeleteAt(num - 1);
        }

        private void PrintSortedStudentsByRoomNumber()
        {
            var students = studentRepository.GetAll();
            students.Sort(delegate (Student x, Student y)
            {
                if (x.Room_number > y.Room_number) return 1;
                else if (x.Room_number == y.Room_number) return 0;
                else return -1;
            });

            for (int i = 0; i < students.Count; ++i)
            {
                Console.WriteLine(students[i]);
            }
            Console.WriteLine();

        }

        private void PrintSortedWorkersBySalary()
        {
            var workers = workerRepository.GetAll();
            workers.Sort(delegate (Worker x, Worker y)
            {
                if (x.Salary > y.Salary) return 1;
                else if (x.Salary == y.Salary) return 0;
                else return -1;
            });

            for (int i = 0; i < workers.Count; ++i)
            {
                Console.WriteLine(workers[i]);
            }
            Console.WriteLine();
        }

        private void EditStudentAt()
        {
            Console.WriteLine("Enter positive number");
            int num = Convert.ToInt32(Console.ReadLine());

            var students = studentRepository.GetAll();

            Console.WriteLine("Enter the student info:");
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter surname");
            var surname = Console.ReadLine();

            Console.WriteLine("Enter age");
            var age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter course");
            var course = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Enter room number");
            var room_number = Convert.ToInt32(Console.ReadLine());

            studentRepository.EditAt(num - 1, new Student
            {
                Name = name,
                Surname = surname,
                Age = age,
                Course = course,
                Room_number = room_number
            });
        }
    }
}
