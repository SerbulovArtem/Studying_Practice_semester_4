using Dormitory.Domain.Repositories.Abstract;
using Dormitory.Domain.Factories;
using Dormitory.Domain.Loggers;
using Dormitory.Domain.Repositories.Abstract;
using Dormitory.Domain.Factories;
using Dormitory.Domain.Loggers;
using System;
using System.Windows.Forms;
using Dormitory.Domain.Models;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace Dormitory.User.Forms
{
    public partial class Form1 : Form
    {
        private readonly IStudentRepository studentRepository;
        private readonly IWorkerRepository workerRepository;
        public Form1()
        {
            var factoryProvider = new FactoryProvider(Domain.Enums.FactoryType.Txt);
            var factory = factoryProvider.GetRepositoryFactory();
            studentRepository = factory.GetStudentRepository();
            workerRepository = factory.GetWorkerRepository();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadStudents();
            ReloadWorkers();
        }

        private void ReloadStudents()
        {
            var students = studentRepository.GetAll();

            var searchSurname = tbSearchStudentSurname.Text;

            if (!string.IsNullOrEmpty(searchSurname))
            {
                // filter
                students = students.Where(student => student.Surname == tbSearchStudentSurname.Text).ToList();
            }

            var sortedStudents = students
                .Select(student => new
                {
                    student.Name,
                    student.Surname,
                    student.Age,
                    student.Course,
                    student.Room_number,
                })
                .OrderBy(student => student.Surname) // sorting
                .ToList();

            lbMaxAge.Text = $"{sortedStudents.Max(student => student.Age)}";

            dataGridView1.DataSource = sortedStudents;

            var groupedStudents = students
                .Select(student => new
                {
                    student.Name,
                    student.Surname,
                    student.Age,
                    student.Course,
                    student.Room_number,
                })
                .GroupBy(student => student.Room_number)
                .ToList();

            var dataTable = new DataTable();

            dataTable.Columns.Add("Surname", typeof(string));
            foreach (var roomNumber in groupedStudents.Select(g => g.Key))
            {
                dataTable.Columns.Add($"Room {roomNumber}", typeof(string));
            }

            foreach (var surnameGroup in groupedStudents)
            {
                var row = dataTable.NewRow();
                row["Surname"] = surnameGroup.Key;

                foreach (var roomNumber in groupedStudents.Select(g => g.Key))
                {
                    var roomMembers = surnameGroup
                        .Where(x => x.Room_number == roomNumber)
                        .Select(x => x.Surname)
                        .ToList();
                    row[$"Room {roomNumber}"] = string.Join(", ", roomMembers);
                }

                dataTable.Rows.Add(row);
            }

            dataGridView3.DataSource = dataTable;
        }

        private void ReloadWorkers()
        {
            var workers = workerRepository.GetAll();

            var searchSurname = tbSearchWorkerSurname.Text;

            if (!string.IsNullOrEmpty(searchSurname))
            {
                // filter
                workers = workers.Where(worker => worker.Surname == tbSearchWorkerSurname.Text).ToList();
            }

            var sortedWorkers = workers
                .Select(worker => new
                {
                    worker.Name,
                    worker.Surname,
                    worker.Age,
                    worker.Position,
                    worker.Salary,
                })
                .OrderBy(worker => worker.Surname) // sorting
                .ToList();

            lbSalaryExpenses.Text = $"{sortedWorkers.Sum(worker => worker.Salary)} $";

            dataGridView2.DataSource = sortedWorkers;

            var groupedWorkers = workers
                .Select(worker => new
                {
                    worker.Name,
                    worker.Surname,
                    worker.Age,
                    worker.Position,
                    worker.Salary,
                })
                .GroupBy(student => student.Position)
                .ToList();

            var dataTable = new DataTable();

            dataTable.Columns.Add("Surname", typeof(string));
            foreach (var position in groupedWorkers.Select(g => g.Key))
            {
                dataTable.Columns.Add($"Position {position}", typeof(string));
            }

            foreach (var surnameGroup in groupedWorkers)
            {
                var row = dataTable.NewRow();
                row["Surname"] = surnameGroup.Key;

                foreach (var position in groupedWorkers.Select(g => g.Key))
                {
                    var positionMembers = surnameGroup
                        .Where(x => x.Position == position)
                        .Select(x => x.Surname)
                        .ToList();
                    row[$"Position {position}"] = string.Join(", ", positionMembers);
                }

                dataTable.Rows.Add(row);
            }

            dataGridView4.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            ReloadStudents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            ReloadWorkers();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tbSearchStudentSurname.Text == "")
            {
                ReloadStudents();
            }
            else
            {
                try
                {
                    ReloadStudents();
                    MessageBox.Show("Student finded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    TxtLogger.GetLogger().LogError($"WinForms (Admin) Error: {ex.Message}");
                    MessageBox.Show("Student with this surname doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tbSearchStudentSurname.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tbSearchWorkerSurname.Text == "")
            {
                ReloadWorkers();
            }
            else
            {
                try
                {
                    ReloadWorkers();
                    MessageBox.Show("Worker finded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    TxtLogger.GetLogger().LogError($"WinForms (Admin) Error: {ex.Message}");
                    MessageBox.Show("Worker with this surname doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tbSearchWorkerSurname.Text = "";
            }
        }
    }
}
