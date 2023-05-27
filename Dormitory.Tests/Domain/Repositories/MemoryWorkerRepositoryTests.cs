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
    public class MemoryWorkerRepositoryTests
    {
        [TestMethod]
        public void TestAddWorker_ReturnsAddedWorker()
        {
            // arrange
            var memoryWorkerRepository = new MemoryWorkerRepository();

            var workerToAdd = new Worker
            {
                Name = "name",
                Surname = "surname",
                Age = 1,
                Position = "position",
                Salary = 1000,
            };
            // act
            memoryWorkerRepository.Add(workerToAdd);

            // assert
            var actualAddedWorker = memoryWorkerRepository.GetAll()[memoryWorkerRepository.GetAll().Count - 1];

            Assert.AreEqual(workerToAdd, actualAddedWorker);
        }

        [TestMethod]
        public void TestAddWorker_ThrowsException()
        {
            // arrange
            var memoryWorkerRepository = new MemoryWorkerRepository();

            // assert

            Assert.ThrowsException<NameStateException>(() =>
            {
                memoryWorkerRepository.Add(new Worker
                {
                    Name = "ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss"
                });
            });
        }

        [TestMethod]
        public void TestEditWorker_ReturnsEditedWorker()
        {
            // arrange
            var memoryWorkerRepository = new MemoryWorkerRepository();

            memoryWorkerRepository.Add(new Worker
            {
                Name = "name1",
                Surname = "surname1",
                Age = 11,
                Position = "position1",
                Salary = 1001,

            });

            var workerToEdit = new Worker
            {
                Name = "name",
                Surname = "surname",
                Age = 1,
                Position = "position",
                Salary = 1000,
            };

            var index = 0;

            // act

            memoryWorkerRepository.EditAt(index, workerToEdit);

            // assert

            var actualEditedWorker = memoryWorkerRepository.GetAll()[index];

            Assert.AreEqual(workerToEdit, actualEditedWorker);
        }

        [TestMethod]
        public void TestDeleteAtWorker_ReturnsEmptyList()
        {
            // arrange
            var memoryWorkerRepository = new MemoryWorkerRepository();

            memoryWorkerRepository.Add(new Worker
            {
                Name = "name1",
                Surname = "surname1",
                Age = 11,
                Position = "position1",
                Salary = 1001,
            });

            var index = 0;

            // act

            memoryWorkerRepository.DeleteAt(index);

            // assert

            Assert.IsTrue(memoryWorkerRepository.GetAll().Count == 0);
        }

        [TestMethod]
        public void TestDeleteAtWorker_DeletesWorker()
        {
            // arrange
            var memoryWorkerRepository = new MemoryWorkerRepository();

            var firstWorker = new Worker
            {
                Name = "name1",
                Surname = "surname1",
                Age = 11,
                Position = "position1",
                Salary = 1001,
            };

            var secondtWorker = new Worker
            {
                Name = "name2",
                Surname = "surname2",
                Age = 12,
                Position = "position2",
                Salary = 1002,
            };

            var thirdWorker = new Worker
            {
                Name = "name3",
                Surname = "surname3",
                Age = 13,
                Position = "position3",
                Salary = 1003,
            };

            memoryWorkerRepository.Add(firstWorker);

            memoryWorkerRepository.Add(secondtWorker);

            memoryWorkerRepository.Add(thirdWorker);

            var index = 0;

            // act

            memoryWorkerRepository.DeleteAt(index);

            // assert

            var actualFirstStudent = memoryWorkerRepository.GetAll()[index];

            var actualSecondStudent = memoryWorkerRepository.GetAll()[index + 1];

            Assert.AreEqual(secondtWorker, actualFirstStudent);
            Assert.AreEqual(thirdWorker, actualSecondStudent);
        }
    }
}
