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
    public partial class CourseSeesionControl : UserControl
    {
        public CourseSeesionControl()
        {
            InitializeComponent();
        }

        private void CourseSeesionControl_Load(object sender, EventArgs e)
        {

        }
        EFITIContext db = new EFITIContext();
        private void reset()
        {
            title.Text = "";
            date.Text = "";

        }


        private void loadbtn_Click(object sender, EventArgs e)
        {
            db.CouresSessions.Load();
            coursesessionGridView.DataSource = db.CouresSessions.Local.ToBindingList();
            selectedcoursesession.DataSource = db.CouresSessions.Local.ToBindingList();
            selectedcoursesession.DisplayMember = "Title";
            selectedcoursesession.ValueMember = "Id";
            db.Departments.Load();
            db.Courses.Load();
            selectedcourse.DataSource = db.Courses.Local.ToBindingList();
            selectedcourse.DisplayMember = "Name";
            selectedcourse.ValueMember = "Id";
            db.Instructors.Load();
            selectedinstructor.DataSource = db.Instructors.Local.ToBindingList();
            selectedinstructor.DisplayMember = "FullName";
            selectedinstructor.ValueMember = "Id";
            coursesessionGridView.Columns.Remove("CourseSessionAttandances");
        }
        private void selectedcoursesession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedcoursesession.SelectedValue != null && int.TryParse(selectedcoursesession.SelectedValue.ToString(), out int coursesessionId))
            {
                var s = db.CouresSessions.FirstOrDefault(s => s.Id == coursesessionId);
                if (s != null)
                {
                    title.Text = s.Title;
                    date.Text = s.Date.ToString();
                    selectedinstructor.SelectedValue = s.InstructorID;
                    selectedcourse.SelectedValue = s.CourseId;
                }
            }
        }

        private void insertbtnd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(title.Text) || string.IsNullOrWhiteSpace(date.Text) ||
                selectedinstructor.SelectedValue == null ||
                selectedcourse.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields before inserting.");
                return;
            }

            CouresSession coursesession = new CouresSession
            {
                Title = title.Text,
                Date = DateTime.Parse(date.Text),
                InstructorID = int.Parse(selectedinstructor.SelectedValue.ToString()),
                CourseId = int.Parse(selectedcourse.SelectedValue.ToString()),
            };

            try
            {
                db.Add(coursesession);
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
            var s = db.CouresSessions.Find((int)selectedcoursesession.SelectedValue);

            if (s != null)
            {
                s.Title = title.Text;
                s.Date = DateTime.Parse(date.Text);
                s.InstructorID = int.Parse(selectedinstructor.SelectedValue.ToString());
                s.CourseId = int.Parse(selectedcourse.SelectedValue.ToString());

                db.Update(s);

                try
                {
                    db.SaveChanges();
                    coursesessionGridView.Refresh();
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
            if (selectedcoursesession.SelectedValue == null || !int.TryParse(selectedcoursesession.SelectedValue.ToString(), out int coursesessionId))
            {
                MessageBox.Show("Please select a valid coursesession.");
                return;
            }

            var s = db.CouresSessions.FirstOrDefault(c => c.Id == coursesessionId);
            if (s == null)
            {
                MessageBox.Show("CourseSession not found.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this CourseSession?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.CouresSessions.Remove(s);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("CourseSession deleted successfully.");
                    reset();
                }
                catch (DbUpdateException dbEx)
                {
                    MessageBox.Show("Error: Cannot delete this Coursesession because they are referenced in another table.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }
        }
    }
}
