using Dormitory.Domain.Exceptions;
using Dormitory.Domain.Models;
using Dormitory.Domain.Repositories.Concreate.Memory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory.Tests.Domain.Repositories
{
    [TestClass]
    public class MemoryStudentRepositoryTests
    {
        [TestMethod]
        public void TestAddStudent_ReturnsAddedStudent()
        {
            // arrange
            var memoryStudentRepository = new MemoryStudentRepository();

            var studentToAdd = new Student
            {
                Name = "name",
                Surname = "surname",
                Age = 1,
                Course = 1,
                Room_number = 1,
            };
            // act
            memoryStudentRepository.Add(studentToAdd);

            // assert
            var actualAddedStudent = memoryStudentRepository.GetAll()[memoryStudentRepository.GetAll().Count - 1];

            Assert.AreEqual(studentToAdd, actualAddedStudent);
        }

        [TestMethod]
        public void TestAddStudent_ThrowsException()
        {
            // arrange
            var memoryStudentRepository = new MemoryStudentRepository();

            // assert

            Assert.ThrowsException<NameStateException>(() =>
            {
                memoryStudentRepository.Add(new Student
                {
                    Name = "ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss"
                });
            });
        }

        [TestMethod]
        public void TestEditStudent_ReturnsEditedStudent()
        {
            // arrange
            var memoryStudentRepository = new MemoryStudentRepository();

            memoryStudentRepository.Add(new Student
            {
                Name = "name1",
                Surname = "surname1",
                Age = 11,
                Course = 2,
                Room_number = 2,

            });

            var studentToEdit = new Student
            {
                Name = "name",
                Surname = "surname",
                Age = 1,
                Course = 1,
                Room_number = 1,
            };

            var index = 0;

            // act

            memoryStudentRepository.EditAt(index, studentToEdit);

            // assert

            var actualEditedStudent = memoryStudentRepository.GetAll()[index];

            Assert.AreEqual(studentToEdit, actualEditedStudent);
        }

        [TestMethod]
        public void TestDeleteAtStudent_ReturnsEmptyList()
        {
            // arrange
            var memoryStudentRepository = new MemoryStudentRepository();

            memoryStudentRepository.Add(new Student
            {
                Name = "name1",
                Surname = "surname1",
                Age = 11,
                Course = 2,
                Room_number = 2,

            });

            var index = 0;

            // act

            memoryStudentRepository.DeleteAt(index);

            // assert

            Assert.IsTrue(memoryStudentRepository.GetAll().Count == 0);
        }

        [TestMethod]
        public void TestDeleteAtStudent_DeletesStudent()
        {
            // arrange
            var memoryStudentRepository = new MemoryStudentRepository();

            var firstStudent = new Student 
            {
                Name = "name1",
                Surname = "surname1",
                Age = 11,
                Course = 1,
                Room_number = 1,
            };

            var secondtStudent = new Student
            {
                Name = "name2",
                Surname = "surname2",
                Age = 12,
                Course = 2,
                Room_number = 2,
            };

            var thirdStudent = new Student
            {
                Name = "name3",
                Surname = "surname3",
                Age = 13,
                Course = 3,
                Room_number = 3,
            };

            memoryStudentRepository.Add(firstStudent);

            memoryStudentRepository.Add(secondtStudent);

            memoryStudentRepository.Add(thirdStudent);

            var index = 0;

            // act

            memoryStudentRepository.DeleteAt(index);

            // assert

            var actualFirstStudent = memoryStudentRepository.GetAll()[index];

            var actualSecondStudent = memoryStudentRepository.GetAll()[index + 1];

            Assert.AreEqual(secondtStudent, actualFirstStudent);
            Assert.AreEqual(thirdStudent, actualSecondStudent);
        }
    }
}
