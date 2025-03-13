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
    public partial class instructorcontrol : UserControl
    {
        EFITIContext db = new EFITIContext();
        public instructorcontrol()
        {
            InitializeComponent();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {

            db.Instructors.Load();
            studentGridView.DataSource = db.Instructors.Local.ToBindingList();
            selectedinstructor.DataSource = db.Instructors.Local.ToBindingList();
            selectedinstructor.DisplayMember = "FullName";
            selectedinstructor.ValueMember = "Id";
            db.Departments.Load();
            selecteddepartment.DataSource = db.Departments.Local.ToBindingList();
            selecteddepartment.DisplayMember = "Name";
            selecteddepartment.ValueMember = "DepartmentId";
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }










        private void reset()
        {
            firstname.Text = "";
            lastname.Text = "";
            phone.Text = "";
        }

        private void selectedinstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedinstructor.SelectedValue != null && int.TryParse(selectedinstructor.SelectedValue.ToString(), out int instructorId))
            {
                var s = db.Instructors.FirstOrDefault(i => i.Id == instructorId);
                if (s != null)
                {
                    firstname.Text = s.FName;
                    lastname.Text = s.LName;
                    phone.Text = s.Phone;
                    selecteddepartment.SelectedValue = s.DepartmentId;
                }
            }
        }

        private void selecteddepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void insertbtnI_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(firstname.Text) || string.IsNullOrWhiteSpace(lastname.Text) ||
                string.IsNullOrWhiteSpace(phone.Text) || selecteddepartment.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields before inserting.");
                return;
            }

            Instructor instructor = new Instructor
            {
                FName = firstname.Text,
                LName = lastname.Text,
                Phone = phone.Text,
                DepartmentId = int.Parse(selecteddepartment.SelectedValue.ToString())
            };

            db.Add(instructor);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Instructor inserted successfully.");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting instructor: " + ex.Message);
            }
        }

        private void updatebtnI_Click_1(object sender, EventArgs e)
        {

            var s = db.Instructors.Find((int)selectedinstructor.SelectedValue);

            if (s != null)
            {
                s.FName = firstname.Text;
                s.LName = lastname.Text;
                s.Phone = phone.Text;
                s.DepartmentId = int.Parse(selecteddepartment.SelectedValue.ToString());

                db.Update(s);

                try
                {
                    db.SaveChanges();
                    studentGridView.Refresh();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deletebtnI_Click_1(object sender, EventArgs e)
        {

            if (selectedinstructor.SelectedValue == null || !int.TryParse(selectedinstructor.SelectedValue.ToString(), out int instructorId))
            {
                MessageBox.Show("Please select a valid instructor.");
                return;
            }

            var s = db.Instructors.FirstOrDefault(i => i.Id == instructorId);
            if (s == null)
            {
                MessageBox.Show("Instructor not found.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this instructor?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.Instructors.Remove(s);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Instructor deleted successfully.");
                    reset();
                }
                catch (DbUpdateException dbEx)
                {
                    MessageBox.Show("Error: Cannot delete this instructor because they are referenced in another table.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }
        }
    }
}
