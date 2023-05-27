using Dormitory.Domain.Factories;
using Dormitory.Domain.Loggers;
using Dormitory.Domain.Repositories.Abstract;
using Dormitory.Domain.Factories;
using Dormitory.Domain.Loggers;
using System;
using System.Windows.Forms;
using Dormitory.Domain.Models;
using System.Linq;
using System.Data;

namespace Dormitory.Admin.Forms
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
                .Select(MapStudent)
                .OrderBy(student => student.Surname) // sorting
                .ToList();

            lbMaxAge.Text = $"{sortedStudents.Max(student => student.Age)}";

            dataGridView1.DataSource = sortedStudents;

            var groupedStudents = students
                .Select(MapStudent)
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
        
        private class studentView
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public short Age { get; set; }

            public sbyte Course { get; set; }

            public int Room_number { get; set; }
        }
        private studentView MapStudent(Student obj)
        {
            return new studentView
            {
                Name = obj.Name,
                Surname = obj.Surname,
                Age = obj.Age,
                Course = obj.Course,
                Room_number = obj.Room_number,
            };
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OnAddNewStudentUnsafe();
                MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                TxtLogger.GetLogger().LogError($"WinForms (Admin) Error: {ex.Message}");
                MessageBox.Show("Some error occurs during adding a student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnAddNewStudentUnsafe()
        {
            var name = tbStudentName.Text;
            var surname = tbStudentSurname.Text;
            var age = Convert.ToInt16(tbStudentAge.Text);
            var course = Convert.ToSByte(tbStudentCourse.Text);
            var room_number = Convert.ToInt32(tbStudentRoomNumber.Text);

            studentRepository.Add(new Domain.Models.Student
                { Name = name, Surname = surname, Age = age, Course = course, Room_number = room_number });

            dataGridView1.DataSource = null;
            ReloadStudents();
            tbStudentName.Text = "";
            tbStudentSurname.Text = "";
            tbStudentAge.Text = "";
            tbStudentCourse.Text = "";
            tbStudentRoomNumber.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OnEditStudentUnsafe();
                MessageBox.Show("Student editted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                TxtLogger.GetLogger().LogError($"WinForms (Admin) Error: {ex.Message}");
                MessageBox.Show("Some error occurs during editing the student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OnEditStudentUnsafe()
        {
            var name = tbStudentEditName.Text;
            var surname = tbStudentEditSurname.Text;
            var age = Convert.ToInt16(tbStudentEditAge.Text);
            var course = Convert.ToSByte(tbStudentEditCourse.Text);
            var room_number = Convert.ToInt32(tbStudentEditRoomNumber.Text);

            studentRepository.EditAt(dataGridView1.SelectedRows[0].Index, new Domain.Models.Student
            { Name = name, Surname = surname, Age = age, Course = course, Room_number = room_number });

            dataGridView1.DataSource = null;
            ReloadStudents();
            tbStudentEditName.Text = "";
            tbStudentEditSurname.Text = "";
            tbStudentEditAge.Text = "";
            tbStudentEditCourse.Text = "";
            tbStudentEditRoomNumber.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            var studentRow = dataGridView1.SelectedRows[0];

            tbStudentEditName.Text = studentRow.Cells[0].Value.ToString();
            tbStudentEditSurname.Text = studentRow.Cells[1].Value.ToString();
            tbStudentEditAge.Text = studentRow.Cells[2].Value.ToString();
            tbStudentEditCourse.Text = studentRow.Cells[3].Value.ToString();
            tbStudentEditRoomNumber.Text = studentRow.Cells[4].Value.ToString();

            tbStudentDeleteName.Text = studentRow.Cells[0].Value.ToString();
            tbStudentDeleteSurname.Text = studentRow.Cells[1].Value.ToString();
            tbStudentDeleteAge.Text = studentRow.Cells[2].Value.ToString();
            tbStudentDeleteCourse.Text = studentRow.Cells[3].Value.ToString();
            tbStudentDeleteRoomNumber.Text = studentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OnDeleteStudentUnsafe();
                MessageBox.Show("Student deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                TxtLogger.GetLogger().LogError($"WinForms (Admin) Error: {ex.Message}");
                MessageBox.Show("Some error occurs during deleting the student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnDeleteStudentUnsafe()
        {
            studentRepository.DeleteAt(dataGridView1.SelectedRows[0].Index);

            dataGridView1.DataSource = null;
            ReloadStudents();
            tbStudentDeleteName.Text = "";
            tbStudentDeleteSurname.Text = "";
            tbStudentDeleteAge.Text = "";
            tbStudentDeleteCourse.Text = "";
            tbStudentDeleteRoomNumber.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OnAddNewWorkerUnsafe();
                MessageBox.Show("Worker added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                TxtLogger.GetLogger().LogError($"WinForms (Admin) Error: {ex.Message}");
                MessageBox.Show("Some error occurs during adding a worker", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnAddNewWorkerUnsafe()
        {
            var name = tbWorkerName.Text;
            var surname = tbWorkerSurname.Text;
            var age = Convert.ToInt16(tbWorkerAge.Text);
            var position = tbWorkerPosition.Text;
            var salary = Convert.ToInt32(tbWorkerSalary.Text);

            workerRepository.Add(new Domain.Models.Worker
            { Name = name, Surname = surname, Age = age, Position = position, Salary = salary });

            dataGridView2.DataSource = null;
            ReloadWorkers();
            tbWorkerName.Text = "";
            tbWorkerSurname.Text = "";
            tbWorkerAge.Text = "";
            tbWorkerPosition.Text = "";
            tbWorkerSalary.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OnEditWorkerUnsafe();
                MessageBox.Show("Worker editted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                TxtLogger.GetLogger().LogError($"WinForms (Admin) Error: {ex.Message}");
                MessageBox.Show("Some error occurs during editing the worker", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnEditWorkerUnsafe()
        {
            var name = tbWorkerEditName.Text;
            var surname = tbWorkerEditSurname.Text;
            var age = Convert.ToInt16(tbWorkerEditAge.Text);
            var position = tbWorkerEditPosition.Text;
            var salary = Convert.ToInt32(tbWorkerEditSalary.Text);

            workerRepository.EditAt(dataGridView2.SelectedRows[0].Index, new Domain.Models.Worker
            { Name = name, Surname = surname, Age = age, Position = position, Salary = salary });

            dataGridView2.DataSource = null;
            ReloadWorkers();
            tbWorkerEditName.Text = "";
            tbWorkerEditSurname.Text = "";
            tbWorkerEditAge.Text = "";
            tbWorkerEditPosition.Text = "";
            tbWorkerEditSalary.Text = "";
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
                return;

            var workerRow = dataGridView2.SelectedRows[0];

            tbWorkerEditName.Text = workerRow.Cells[0].Value.ToString();
            tbWorkerEditSurname.Text = workerRow.Cells[1].Value.ToString();
            tbWorkerEditAge.Text = workerRow.Cells[2].Value.ToString();
            tbWorkerEditPosition.Text = workerRow.Cells[3].Value.ToString();
            tbWorkerEditSalary.Text = workerRow.Cells[4].Value.ToString();
            
            tbWorkerDeleteName.Text = workerRow.Cells[0].Value.ToString();
            tbWorkerDeleteSurname.Text = workerRow.Cells[1].Value.ToString();
            tbWorkerDeleteAge.Text = workerRow.Cells[2].Value.ToString();
            tbWorkerDeletePosition.Text = workerRow.Cells[3].Value.ToString();
            tbWorkerDeleteSalary.Text = workerRow.Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OnDeleteWorkerUnsafe();
                MessageBox.Show("Worker deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                TxtLogger.GetLogger().LogError($"WinForms (Admin) Error: {ex.Message}");
                MessageBox.Show("Some error occurs during deleting the worker", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnDeleteWorkerUnsafe()
        {
            workerRepository.DeleteAt(dataGridView2.SelectedRows[0].Index);

            dataGridView2.DataSource = null;
            ReloadWorkers();
            tbWorkerDeleteName.Text = "";
            tbWorkerDeleteSurname.Text = "";
            tbWorkerDeleteAge.Text = "";
            tbWorkerDeletePosition.Text = "";
            tbWorkerDeleteSalary.Text = "";
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
