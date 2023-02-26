using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentsDairy
{
    public partial class AddeditStudent : Form
    {

        private FileHelper<List<Student>> _fileHelper =
            new FileHelper<List<Student>>(Program.FilePath);

        private int _studentId;
        private Student _student;
        private List<Group> _groups;
        public AddeditStudent(int id = 0)
        {

            InitializeComponent();
            _studentId = id;
            _groups = GroupsHelper.GetGroups("Brak");
            InitGroupComboBox();
            GetStudentData();
            tbFirstName.Select();
        }

        private void InitGroupComboBox()
        {
            cbGroupId.DataSource = _groups;
            cbGroupId.DisplayMember = "Name";
            cbGroupId.ValueMember = "Id";
        }

        private void GetStudentData()
        {
            if (_studentId != 0)
            {
                Text = "Edytowanie danych ucznia";

                var students = _fileHelper.DeserializeFromFile();
                _student = students.FirstOrDefault(x => x.Id == _studentId);

                if (_student == null)
                    throw new Exception("Brak użytkownika o podanym Id");

                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _student.Id.ToString();
            tbFirstName.Text = _student.FirstName;
            tbLastName.Text = _student.LastName;
            tbMath.Text = _student.Math;
            tbPhysics.Text = _student.Physics;
            tbChemistry.Text = _student.Chemistry;
            tbBiology.Text = _student.Biology;
            tbPolishLng.Text = _student.PolishLang;
            rtbComments.Text = _student.Comments;
            cbAdditionalActivities.Checked = _student.AdditionalActivities;
            cbGroupId.SelectedItem = _groups.FirstOrDefault(x => x.Id == _student.GroupId);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();

            if (_studentId != 0)
                students.RemoveAll(x => x.Id == _studentId);
            else
                AssignIdToNewStudent(students);

            AddNewUserToList(students);

            _fileHelper.SerializeToFile(students);

            Close();
        }

        private void AddNewUserToList(List<Student> students)
        {
            var student = new Student

            {
                Id = _studentId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Math = tbMath.Text,
                Physics = tbPhysics.Text,
                Chemistry = tbChemistry.Text,
                Biology = tbBiology.Text,
                PolishLang = tbPolishLng.Text,
                Comments = rtbComments.Text,
                AdditionalActivities = cbAdditionalActivities.Checked,
                GroupId = (cbGroupId.SelectedItem as Group).Id
        };
            students.Add(student);
        }
        private void AssignIdToNewStudent(List<Student> students)
        {
            var studentWithHighestId = students.OrderByDescending
                    (x => x.Id).FirstOrDefault();

            _studentId = studentWithHighestId == null ?
                1 : studentWithHighestId.Id + 1;
        }

    }
}
