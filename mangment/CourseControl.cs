using mangment.Context;
using mangment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mangment
{
    public partial class CourseControl : UserControl
    {
        public CourseControl()
        {
            InitializeComponent();
        }
        EFITIContext db = new EFITIContext();
        private void reset()
        {
            name.Text = "";
            duration.Text = "";

        }
        private void loadbtn_Click(object sender, EventArgs e)
        {
            db.Courses.Load();
            courseGridView.DataSource = db.Courses.Local.ToBindingList();
            selectedcourse.DataSource = db.Courses.Local.ToBindingList();
            selectedcourse.DisplayMember = "Name";
            selectedcourse.ValueMember = "Id";
            db.Departments.Load();
            selecteddepartment.DataSource = db.Departments.Local.ToBindingList();
            selecteddepartment.DisplayMember = "Name";
            selecteddepartment.ValueMember = "DepartmentId";
            db.Instructors.Load();
            selectedinstructor.DataSource = db.Instructors.Local.ToBindingList();
            selectedinstructor.DisplayMember = "FullName";
            selectedinstructor.ValueMember = "Id";
        }

        private void selectedcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedcourse.SelectedValue != null && int.TryParse(selectedcourse.SelectedValue.ToString(), out int courseId))
            {
                var s = db.Courses.FirstOrDefault(s => s.Id == courseId);
                if (s != null)
                {
                    name.Text = s.Name;
                    duration.Text = s.Duration.ToString();
                    selectedinstructor.SelectedValue = s.InstructorId;
                    selecteddepartment.SelectedValue = s.DepartmentId;
                }
            }
        }
        private void insertbtnd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(duration.Text) ||
                selectedinstructor.SelectedValue == null ||
                selecteddepartment.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields before inserting.");
                return;
            }

            Course course = new Course
            {
                Name = name.Text,
                Duration = int.Parse(duration.Text),
                InstructorId = int.Parse(selectedinstructor.SelectedValue.ToString()),
                DepartmentId = int.Parse(selecteddepartment.SelectedValue.ToString()),
            };

            try
            {
                db.Add(course);
                db.SaveChanges();
                MessageBox.Show("Course inserted successfully.");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting Coruse: " + ex.Message);
            }
        }

        private void updatebtnd_Click(object sender, EventArgs e)
        {
            var s = db.Courses.Find((int)selectedcourse.SelectedValue);

            if (s != null)
            {
                s.Name = name.Text;
                s.Duration = int.Parse(duration.Text);
                s.InstructorId = int.Parse(selectedinstructor.SelectedValue.ToString());
                s.DepartmentId = int.Parse(selecteddepartment.SelectedValue.ToString());

                db.Update(s);

                try
                {
                    db.SaveChanges();
                    courseGridView.Refresh();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deletebtnd_Click(object sender, EventArgs e)
        {
            if (selectedcourse.SelectedValue == null || !int.TryParse(selectedcourse.SelectedValue.ToString(), out int courseId))
            {
                MessageBox.Show("Please select a valid course.");
                return;
            }

            var s = db.Courses.FirstOrDefault(c => c.Id == courseId);
            if (s == null)
            {
                MessageBox.Show("Course not found.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Course?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.Courses.Remove(s);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Course deleted successfully.");
                    reset();
                }
                catch (DbUpdateException dbEx)
                {
                    MessageBox.Show("Error: Cannot delete this Course because they are referenced in another table.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }
        }
    }
}
